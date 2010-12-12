using System;
using System.Collections.Generic;
using System.Text;

namespace UMLDes.GUI {
	public class Calculate {

		public static double DoCalculate (StaticView curr,out int LineNum,out int PackageNum) {
			double result;
			int RelationValue;

			// TODO 
			PackageNum=GetPackageNum (curr);
			

			
			RelationValue=GetRelationValue (curr,out LineNum,PackageNum);
			result=(double) RelationValue/(double) PackageNum/(double) PackageNum;


			return result;
		}

		private static int GetPackageNum (StaticView curr) {
			int i=0;
//					private static void SelectNameFor (GuiItem v,StaticView parent) {
//			String name="",tname,ename="",type=(v.GetType ().Name);
//			select (v,ref name,type,false);
//			if (name.IndexOf ('1')!=-1)
//				name=name.Substring (0,name.IndexOf ('1'));
//			int i=1;
//			do {
//				tname=name+i.ToString ();
			foreach (GuiObject d in curr.active_objects)
				if(d is GuiPackage)
					i++;
			return i;
//						if (d.GetType ().Name==type) {
//							select (d as GuiItem,ref ename,type,false);
//							if (ename.Equals (tname)) {
//								tname=null;
//								break;
//							}
//						}
//					i++;
//			}
//			while (tname==null);
//			select (v,ref tname,type,true);
//		}
		}

		private static int GetRelationValue (StaticView curr,out int LineNum,int PackageNum) {
			int RelationValue=0;
			int[,] RelationSign=new int [PackageNum,PackageNum];
			//int[,]和int[][]区别？？？前者为二维数组(也可用new int [x,y]{{},{}...}及类似的形式赋初值)，后者为交错数组(数组的数组)，可不为矩形？？？
			int PackageID1,PackageID2;
			GuiConnectionPoint GCP1,GCP2;
			LineNum=0;

			
			for(PackageID1=0;PackageID1<PackageNum;PackageID1++)
				RelationSign[PackageID1,PackageID1]=1;
			//					private static void SelectNameFor (GuiItem v,StaticView parent) {
			//			String name="",tname,ename="",type=(v.GetType ().Name);
			//			select (v,ref name,type,false);
			//			if (name.IndexOf ('1')!=-1)
			//				name=name.Substring (0,name.IndexOf ('1'));
			//			int i=1;
			//			do {
			//				tname=name+i.ToString ();
			foreach (GuiObject d in curr.active_objects)
				if (d is GuiConnection) {
					LineNum++;
					GCP1=(d as GuiConnection).children[0] as GuiConnectionPoint;
					GCP2=(d as GuiConnection).children[1] as GuiConnectionPoint;
					if ((GCP1.item is GuiPackage)&&(GCP2.item is GuiPackage)) {
						PackageID1=int.Parse(GCP1.item_id.Substring (8))-1;
						PackageID2=int.Parse(GCP2.item_id.Substring (8))-1;
						RelationSign[PackageID1,PackageID2]=1;
					}
				}
			for (PackageID1=0;PackageID1<PackageNum;PackageID1++)
				for (PackageID2=0;PackageID2<PackageNum;PackageID2++)
					RelationValue=RelationValue+RelationSign[PackageID1,PackageID2];
			return RelationValue;
			//						if (d.GetType ().Name==type) {
			//							select (d as GuiItem,ref ename,type,false);
			//							if (ename.Equals (tname)) {
			//								tname=null;
			//								break;
			//							}
			//						}
			//					i++;
			//			}
			//			while (tname==null);
			//			select (v,ref tname,type,true);
			//		}
		}
	}
}
