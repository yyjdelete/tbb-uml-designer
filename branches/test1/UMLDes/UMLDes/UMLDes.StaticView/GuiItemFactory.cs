using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

using UMLDes.Model;

namespace UMLDes.GUI {

	class GuiElementFactory {

		public static GuiItem CreateElement (UmlObject obj) {

			if (obj is UmlClass)
				return GuiClass.fromUML (obj as UmlClass);
			else if (obj is UmlEnum)
				return GuiEnum.fromUML (obj as UmlEnum);
			else if (obj is UmlNamespace)
				return GuiPackage.fromUML (obj as UmlNamespace);
			else
				return null;
		}

		public static GuiClass CreateClass (StaticView parent,int x,int y,UmlClass cl) {
			GuiClass c = GuiClass.fromUML (cl);
			c.X = x;
			c.Y = y;
			parent.AddObject (c,UmlModel.GetUniversal (cl));
			return c;
		}

		public static GuiMemo CreateMemo (StaticView parent,int x,int y) {
			GuiMemo m=new GuiMemo ();
			SelectNameFor (m,parent);
			m.X = x;
			m.Y = y;
			parent.AddObject (m,"memo");
			return m;
		}

		public static GuiPackage CreatePackage (StaticView parent,int x,int y) {
			GuiPackage m = new GuiPackage ();
			m.name="Package1";
			SelectNameFor (m,parent);
			m.source_dependant = false;
			m.X = x;
			m.Y = y;
			m.Created ();
			parent.AddObject (m,"package");
			return m;
		}

		#region 自动编号

		/// <summary>
		/// 自动编号
		/// </summary>
		/// <param name="v">待编号Memo对象</param>
		/// <param name="parent">对象所在静态视图</param>
		private static void SelectNameFor (GuiMemo v,StaticView parent) {
			string name=v.text,tname;
			if (name.IndexOf ('1')!=-1)
				name=name.Substring (0,name.IndexOf ('1'));
			int i=1;
			do {
				tname=name+i.ToString ();
				foreach (GuiMemo d in parent.active_objects)
					if (d.text.Equals (tname)) {
						tname=null;
						break;
					}
				i++;
			}
			while (tname==null);
			v.text=tname;
		}

		/// <summary>
		/// 自动编号
		/// </summary>
		/// <param name="v">待编号Package对象</param>
		/// <param name="parent">对象所在静态视图</param>
		private static void SelectNameFor (GuiPackage v,StaticView parent) {
			string name=v.name,tname;
			if (name.IndexOf ('1')!=-1)
				name=name.Substring (0,name.IndexOf ('1'));
			int i=1;
			do {
				tname=name+i.ToString ();
				foreach (GuiPackage d in parent.active_objects)
					if (d.name.Equals (tname)) {
						tname=null;
						break;
					}
				i++;
			}
			while (tname==null);
			v.name=tname;
		}

		#endregion

	}
}