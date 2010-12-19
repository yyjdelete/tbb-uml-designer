using System;
using System.Collections.Generic;
using System.Text;

namespace UMLDes.GUI {
	public class Calculate {

		public static double DoCalculate (StaticView curr,out int lineNum,out int packageNum,out int classNum) {
			double result;
			int RelationValue;

			GetPCNum (curr,out packageNum,out classNum);
			RelationValue=GetRelationValue (curr,out lineNum,packageNum,classNum);
			result=(double) RelationValue/(double) packageNum/(double) packageNum;

			return result;
		}

		private static void GetPCNum (StaticView curr,out int packageNum,out int classNum) {
			packageNum=0;
			classNum=0;

			foreach (GuiObject d in curr.active_objects)
				if (d is GuiPackage)
					packageNum++;
				else if (d is GuiClass)
					classNum++;
		}

		private static int GetRelationValue (StaticView curr,out int lineNum,int packageNum,int classNum) {
			int RelationValue=0,totalNum=packageNum+classNum;
			int[,] RelationSign=new int[totalNum,totalNum];
			//int[,]和int[][]区别？？？前者为二维数组(也可用new int [x,y]{{},{}...}及类似的形式赋初值)，后者为交错数组(数组的数组)，可不为矩形？？？
			int PackageID1,PackageID2;
			GuiConnectionPoint GCP1,GCP2;
			lineNum=0;


			for (PackageID1=0;PackageID1<totalNum;PackageID1++)
				RelationSign[PackageID1,PackageID1]=1;
			foreach (GuiObject d in curr.active_objects)
				if (d is GuiConnection) {
					lineNum++;
					GCP1=(d as GuiConnection).children[0] as GuiConnectionPoint;
					GCP2=(d as GuiConnection).children[1] as GuiConnectionPoint;
					if ((GCP1.item is GuiPackage||GCP1.item is GuiClass)&&(GCP2.item is GuiPackage||GCP2.item is GuiClass)) {
						PackageID1=int.Parse (GCP1.item_id.Split ('#')[1])-1;//GCP1.item_id.Substring (GCP1.item_id.IndexOf('#')+1)
						PackageID2=int.Parse (GCP2.item_id.Split ('#')[1])-1;//GCP2.item_id.Substring (GCP2.item_id.IndexOf('#')+1)
						if (GCP1.item is GuiClass)
							PackageID1=PackageID1+packageNum;
						if (GCP2.item is GuiClass)
							PackageID2=PackageID2+packageNum;
						RelationSign[PackageID1,PackageID2]=1;
					}
				}
			for (PackageID1=0;PackageID1<totalNum;PackageID1++)
				for (PackageID2=0;PackageID2<totalNum;PackageID2++)
					RelationValue=RelationValue+RelationSign[PackageID1,PackageID2];

			return RelationValue;
		}
	}
}
