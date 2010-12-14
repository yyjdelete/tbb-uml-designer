using System;
using System.Collections.Generic;
using System.Text;

namespace UMLDes.GUI {
	public class Calculate {

		public static double DoCalculate (StaticView curr,out int LineNum,out int PackageNum) {
			double result;
			int RelationValue;

			PackageNum=GetPackageNum (curr);
			RelationValue=GetRelationValue (curr,out LineNum,PackageNum);
			result=(double) RelationValue/(double) PackageNum/(double) PackageNum;

			return result;
		}

		private static int GetPackageNum (StaticView curr) {
			int i=0;

			foreach (GuiObject d in curr.active_objects)
				if(d is GuiPackage)
					i++;

			return i;
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
			foreach (GuiObject d in curr.active_objects)
				if (d is GuiConnection) {
					LineNum++;
					GCP1=(d as GuiConnection).children[0] as GuiConnectionPoint;
					GCP2=(d as GuiConnection).children[1] as GuiConnectionPoint;
					if ((GCP1.item is GuiPackage)&&(GCP2.item is GuiPackage)) {
						PackageID1=int.Parse (GCP1.item_id.Split ('#')[1])-1;//GCP1.item_id.Substring (GCP1.item_id.IndexOf('#')+1)
						PackageID2=int.Parse (GCP2.item_id.Split ('#')[1])-1;//GCP2.item_id.Substring (GCP2.item_id.IndexOf('#')+1)
						RelationSign[PackageID1,PackageID2]=1;
					}
				}
			for (PackageID1=0;PackageID1<PackageNum;PackageID1++)
				for (PackageID2=0;PackageID2<PackageNum;PackageID2++)
					RelationValue=RelationValue+RelationSign[PackageID1,PackageID2];

			return RelationValue;
		}
	}
}
