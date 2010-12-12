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

		#region �Զ����

		/// <summary>
		/// �Զ����
		/// </summary>
		/// <param name="v">����Ŷ���</param>
		/// <param name="parent">�������ھ�̬��ͼ</param>
		private static void SelectNameFor (GuiItem v,StaticView parent) {
			String name="",tname,ename="",type=(v.GetType ().Name);
			select (v,ref name,type,false);
			if (name.IndexOf ('1')!=-1)
				name=name.Substring (0,name.IndexOf ('1'));
			int i=1;
			do {
				tname=name+i.ToString ();
				foreach (GuiObject d in parent.active_objects)
						if (d.GetType ().Name==type) {
							select (d as GuiItem,ref ename,type,false);
							if (ename.Equals (tname)) {
								tname=null;
								break;
							}
						}
					i++;
			}
			while (tname==null);
			select (v,ref tname,type,true);
		}

		/// <summary>
		/// ��Բ�ͬGuiItem�̳������ѡ��
		/// </summary>
		/// <param name="v">������GuiItem�̳������</param>
		/// <param name="name">����ȡ/д���ַ���</param>
		/// <param name="type">ѡ���GuiItem�̳�����������</param>
		/// <param name="input">�����name������д��v��Ϊ true����v������д��name��Ϊ false��</param>
		private static void select (GuiItem v,ref String name,String type,bool input) {
			if (input) {
				if (type=="GuiMemo")//�����µ����������
					(v as GuiMemo).text=name;
				else
					(v as GuiPackage).name=name;
			}
			else {
				if (type=="GuiMemo")//�����µ����������
					name=(v as GuiMemo).text;
				else
					name=(v as GuiPackage).name;
			}
		}

		#endregion

	}
}