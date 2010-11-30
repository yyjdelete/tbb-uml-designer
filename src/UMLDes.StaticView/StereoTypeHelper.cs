using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using UMLDes.Controls;

namespace UMLDes.GUI {

	public class StereoTypeHelper {

		IHasStereotype obj;
		StaticView parent;
		string[] hashed_stereo_list;

		public StereoTypeHelper (IHasStereotype obj) {
			this.obj = obj;
			this.parent = ((GuiObject) obj).parent;
		}

		private void EditedStereo (string ns) {
			obj.Stereo = ns.Length > 0 ? ns : null;
		}

		private void set_stereo (object o,EventArgs ev) {
			int MergeIndex=((o as ToolStripMenuItem).OwnerItem as ToolStripMenuItem).DropDownItems.IndexOf (o as ToolStripMenuItem);
			if (MergeIndex==0) {
				Rectangle r = obj.EditRect;
				InPlaceTextEdit.Start ("±à¼­ stereotype",obj.Stereo,parent.cview.point_to_screen (r.X,r.Y),Math.Max (r.Width,70),r.Height,parent.cview,new StringEditedEvent (EditedStereo),false);
				return;
			}

			if (MergeIndex>=3) {
				obj.Stereo=hashed_stereo_list[MergeIndex-3];
			}
			else if (MergeIndex==1)
				obj.Stereo = null;
		}

		public ToolStripMenuItem  GetStereoMenu () {

			ToolStripMenuItem curr;
			EventHandler evh;

			// Display Options
			evh = new EventHandler (set_stereo);
			curr = new ToolStripMenuItem ("Stereotype");
			parent.AddItem (curr,"ÆäËü",ToolBarIcons.None,false,evh);
			parent.AddItem (curr,"Çå³ý",ToolBarIcons.None,false,evh);
			parent.AddItem (curr,"-",ToolBarIcons.None,false,null);
			hashed_stereo_list = obj.StereoList;
			foreach (string s in hashed_stereo_list)
				if (s != null)
					parent.AddItem (curr,"\x00AB" + s + "\xBB",ToolBarIcons.None,false,evh);
				else
					parent.AddItem (curr,"-",ToolBarIcons.None,false,null);

			return curr;
		}

	}

}