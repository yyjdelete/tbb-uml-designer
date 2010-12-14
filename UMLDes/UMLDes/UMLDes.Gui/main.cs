using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UMLDes.Model;
using UMLDes.GUI;
using UMLDes.Controls;

namespace UMLDes {

	public partial class MainWnd:Form {
		public MainWnd () {
			InitializeComponent ();
			PostInitialize ();
			list = toolbarImages;

			TurnOnProject (UmlDesignerSolution.createNew ());
		}

		#region 工具栏相关
		bool unIrreversibleChange=false;//非不可逆改动判断标志

		public void UpdateToolBar () {
			//撤销状态改变,引起工具栏刷新,并对文件是否改动进行判断
			tool_Undo.Enabled=(ViewCtrl1.Curr.undo.undo_count>0);
			tool_Redo.Enabled=(ViewCtrl1.Curr.undo.redo_count>0);
			if (ViewCtrl1.Curr.ModifiedValue!=0&&ViewCtrl1.Curr.undo.undo_count<=ViewCtrl1.Curr.ModifiedValue&&ViewCtrl1.Curr.undo.redo_count==0&&unIrreversibleChange==false) {
				p.IrreversibleChange ();//判定当前图产生了不可逆的改动
			}
			else {
				if (unIrreversibleChange)
					unIrreversibleChange=false;//重置标志
				ViewCtrl1.Curr.SetCurModifiedSign ();//检查当前图是否改动
			}
			Text=Text.TrimEnd ('*');//切割掉标题末尾的'*'
			if (p.ModifiedSign) 
				Text=Text+"*";
		}

		/// <summary>
		/// 刷新按钮选中状态。
		/// </summary>
		/// <param name="tsb">被点击的按钮。</param>
		private void CheckButton (ToolStripButton tsb) {
					int maxnum=tsb.Owner.Items.Count;
					int i;
					for (i=0;i<maxnum;i++)
						if (tsb.Owner.Items[i] is ToolStripButton&&(tsb.Owner.Items[i] as ToolStripButton).Name!="tool_lock")//跳过间隔条toolStripSeparator和锁定标志tool_lock
							(tsb.Owner.Items[i] as ToolStripButton).Checked=false;
					tsb.Checked=true;//采用.CheckState=System.Windows.Forms.CheckState.xxx亦可
		}

		public void SetDefDraw () {//回归默认绘制对象
			toolStrip_Select (tool_arrow,null);
		}

		private void toolStrip_Select (object sender,EventArgs e) {//选择绘制对象、风格
			ToolStripButton stsb=sender as ToolStripButton;
			if (stsb.Checked==false) {//若更改选择
				if((ViewCtrl1.Curr as UMLDes.GUI.StaticView).ToolbarAction (stsb.Name))
					CheckButton (stsb);
			}
		}

		private void tool_lock_change (object sender,EventArgs e) {//切换锁定状态
			ToolStripButton stsb=sender as ToolStripButton;
			(ViewCtrl1.Curr as UMLDes.GUI.StaticView).ToolbarAction (stsb.Name);
			stsb.Checked=!stsb.Checked;
		}
		#endregion

		#region 主窗口、关闭及保存提示

		[STAThread]
		static void Main () {
			Application.Run (new MainWnd ());
		}

		private bool SaveChanges () {
			if (p.ModifiedSign) {
				DialogResult r = MessageBox.Show ("工程已被更改,是否保存?","警告!",MessageBoxButtons.YesNoCancel);
				if (r == DialogResult.Cancel)
					return false;
				if (r == DialogResult.Yes)
					p.Save (false);
			}
			return true;
		}

		protected override void OnClosing (CancelEventArgs e) {
#if !DEBUG
			if (!SaveChanges ())
				e.Cancel = true;
#endif
			base.OnClosing (e);
		}

		#endregion

		#region 菜单行为

		private void NewProject (object sender,System.EventArgs e) {
			if (!SaveChanges ())
				return;
			TurnOnProject (UmlDesignerSolution.createNew ());
		}

		private void Exit (object sender,System.EventArgs e) {
			this.Close ();
		}


		private void SaveProject (object sender,System.EventArgs e) {
			p.Save (false);
		}

		private void SaveAsProject (object sender,System.EventArgs e) {
			p.Save (true);
		}

		private void LoadProject (object sender,System.EventArgs e) {
			UmlDesignerSolution q = UmlDesignerSolution.Load (this);
			if (q != null)
				TurnOnProject (q);
		}

		/// <summary>
		/// 刷新标题栏
		/// </summary>
		public void RefreshTitle () {
			this.Text = "TBB UML Designer: " + p.name + " [" + ViewCtrl1.Curr.name + "]";
			UpdateToolBar ();
		}

		private void TurnOnProject (UmlDesignerSolution p) {

			if (p.diagrams.Count == 0)
				return;

			if (this.p != null)
				this.p.container = null;

			this.p = p;
			p.container = this;
			ProjectTree.NewSolution (p);
			SelectView ((GUI.View) p.diagrams[0],true);
			UpdateToolBar ();
		}

		public GUI.View GetCurrentView () {
			return ViewCtrl1.Curr;
		}

		public void SelectView (GUI.View v,bool update) {
			ViewCtrl1.Curr = v;
			if (update) {
				RefreshTitle ();
				ViewCtrl1.Invalidate ();//重绘
				toolStrip_Select (tool_arrow,null);//刷新选择状态
				toolStrip_Select (tool_straight_conn,null);
			}
		}

		private void AddFiles (object sender,System.EventArgs e) {
			p.AddFile ();
		}

		private void RefreshProject (object sender,System.EventArgs e) {
			p.Refresh ();
		}

		private void Print (object sender,System.EventArgs e) {
			ViewCtrl1.Print (false);
		}

		private void PrintPreview (object sender,System.EventArgs e) {
			ViewCtrl1.Print (true);
		}

		private void AddStaticView (object sender,System.EventArgs e) {
			UMLDes.GUI.View v = p.newStaticView ();
			SelectView (v,true);
		}

		#region 图像相关

		#region 图像格式

		private struct FormatDescr {
			public System.Drawing.Imaging.ImageFormat format;
			public string ext,descr;

			public FormatDescr (System.Drawing.Imaging.ImageFormat format,string ext,string descr) {
				this.format = format;
				this.ext = ext;
				this.descr = descr;
			}
		}

		private FormatDescr[] formats = new FormatDescr[] { 
			new FormatDescr( System.Drawing.Imaging.ImageFormat.Png, "png", "PNG" ),
			new FormatDescr( System.Drawing.Imaging.ImageFormat.Bmp, "bmp", "Bitmap" ), 
			new FormatDescr( System.Drawing.Imaging.ImageFormat.Gif, "gif", "GIF" ), 
			new FormatDescr( System.Drawing.Imaging.ImageFormat.Tiff, "tif", "TIFF" ), 
			new FormatDescr( System.Drawing.Imaging.ImageFormat.Jpeg, "jpg", "JPEG" ), 
		};

		#endregion

		private void SaveToImage (object sender,System.EventArgs e) {
			Bitmap bmp = ViewCtrl1.PrintToImage ();
			if (bmp == null) {
				MessageBox.Show ("没有待保存的对象","图为空",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}

			SaveFileDialog sfd = new SaveFileDialog ();
			string filter = String.Empty;
			for (int i = 0;i < formats.Length;i++)
				filter += "|" + formats[i].descr + "(*." + formats[i].ext + ")|*." + formats[i].ext;
			sfd.Filter = filter.Substring (1);
			sfd.FilterIndex = 0;
			sfd.AddExtension = true;
			sfd.Title = "保存为图片...";
			sfd.ValidateNames = true;
			sfd.FileName = ViewCtrl1.Curr.name;


			if (sfd.ShowDialog (this) == DialogResult.OK) {
				string ext = System.IO.Path.GetExtension (sfd.FileName).ToLower ();
				System.Drawing.Imaging.ImageFormat format = null;
				for (int i = 0;i < formats.Length;i++)
					if (ext.Equals ("." + formats[i].ext))
						format = formats[i].format;
				if (format != null)
					bmp.Save (sfd.FileName,format);
				else
					MessageBox.Show ("未知扩展名: " + ext,"无法保存",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
		}

		private void CopyAsImage (object sender,System.EventArgs e) {
			Bitmap bmp = ViewCtrl1.PrintToImage ();
			if (bmp == null) {
				MessageBox.Show ("没有待复制的对象","图为空",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}

			System.Windows.Forms.Clipboard.SetDataObject (bmp,false);
		}
		#endregion

		#region 缩放

		private void menu_ZoomOut_Click (object sender,System.EventArgs e) {
			ViewCtrl1.ZoomOut ();
		}

		private void menu_ZoomIn_Click (object sender,System.EventArgs e) {
			ViewCtrl1.ZoomIn ();
		}

		#endregion

		#endregion

		#region “编辑”菜单

		private void EditMenuPopup (object sender,System.EventArgs e) {
			menu_Undo.Enabled=ViewCtrl1.Curr.undo.undo_count>0;
			menu_Redo.Enabled=ViewCtrl1.Curr.undo.redo_count>0;
			menu_Delete.Enabled = ViewCtrl1.Curr.IfEnabled (UMLDes.GUI.View.EditOperation.Delete);
			menu_Cut.Enabled = ViewCtrl1.Curr.IfEnabled (UMLDes.GUI.View.EditOperation.Cut);
			menu_Copy.Enabled = ViewCtrl1.Curr.IfEnabled (UMLDes.GUI.View.EditOperation.Copy);
			menu_Paste.Enabled = ViewCtrl1.Curr.IfEnabled (UMLDes.GUI.View.EditOperation.Paste);
//			menu_SelectAll.Enabled = ViewCtrl1.Curr.IfEnabled (UMLDes.GUI.View.EditOperation.SelectAll);
		}

		private void Undo (object sender,System.EventArgs e) {
			ViewCtrl1.Curr.undo.DoUndo ();
		}

		private void Redo (object sender,System.EventArgs e) {
			unIrreversibleChange=true;//设置非不可逆改动判断标志
			ViewCtrl1.Curr.undo.DoRedo ();
		}

		private void Copy (object sender,System.EventArgs e) {
			ViewCtrl1.Curr.DoOperation (UMLDes.GUI.View.EditOperation.Copy);
		}

		private void Paste (object sender,System.EventArgs e) {
			ViewCtrl1.Curr.DoOperation (UMLDes.GUI.View.EditOperation.Paste);
		}

		private void Cut (object sender,System.EventArgs e) {
			ViewCtrl1.Curr.DoOperation (UMLDes.GUI.View.EditOperation.Cut);
		}

		private void Delete (object sender,System.EventArgs e) {
			ViewCtrl1.Curr.DoOperation (UMLDes.GUI.View.EditOperation.Delete);
		}

		private void SelectAll (object sender,System.EventArgs e) {
			ViewCtrl1.Curr.DoOperation (UMLDes.GUI.View.EditOperation.SelectAll);
		}

		#endregion

		#region 树列表中的菜单(图\右键\重命名)

		void RenameNode (object v,EventArgs ev) {
			TreeNode tn = (TreeNode) ((ToolStripMenuItem) v).Tag;
			tn.BeginEdit ();
		}

		void TryDropDownMenu (int x,int y,object obj,TreeNode n) {
			ToolStripItem[] mi=null;
			ToolStripMenuItem fmi=null;
			if (obj is UMLDes.GUI.View) {
				fmi=new ToolStripMenuItem ("重命名");
				fmi.Click += new EventHandler (RenameNode);
				fmi.Tag=n;
				mi=new ToolStripMenuItem[] { fmi };
			}

			if (mi == null)
				return;
			ContextMenuStrip m=new ContextMenuStrip ();
			m.Items.AddRange (mi);
			m.Show (ProjectTree,new Point (x,y));
		}

		#endregion

		#region 拖放及其他树操作

		Rectangle dragbox = Rectangle.Empty;
		UmlObject dragobject;

		void TreeMouseDown (object sender,System.Windows.Forms.MouseEventArgs e) {
			TreeNode node = (sender as TreeView).GetNodeAt (e.X,e.Y);
			if (node == null)
				return;
			object obj = ProjectTree.GetNodeObject (node);

			dragbox = Rectangle.Empty;
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left) {

				if (obj is UMLDes.GUI.View) {
					if (e.Clicks == 2) {
						UMLDes.GUI.View v = obj as UMLDes.GUI.View;
						SelectView (v,true);
					}

				}
				else if (!(obj is UmlDesignerSolution)) {
					Size dragSize = SystemInformation.DragSize;
					dragbox = new Rectangle (new Point (e.X - (dragSize.Width / 2),e.Y - (dragSize.Height / 2)),dragSize);
					dragobject = obj as UmlObject;
				}
			}
			else if ((e.Button & MouseButtons.Right) == MouseButtons.Right) {
				ProjectTree.SelectedNode = node;
				if (obj != null)
					TryDropDownMenu (e.X,e.Y,obj,node);
			}
		}

		void TreeMouseMove (object sender,System.Windows.Forms.MouseEventArgs e) {
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left) {
				if (dragbox != Rectangle.Empty && !dragbox.Contains (e.X,e.Y) && dragobject != null) {
					ViewCtrl1.DragObject = dragobject;
					DragDropEffects dropEffect = ((TreeView) sender).DoDragDrop (dragobject.Name,DragDropEffects.Copy);
					///....
					dragbox = Rectangle.Empty;
				}
			}
		}

		void TreeMouseUp (object sender,System.Windows.Forms.MouseEventArgs e) {
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
				dragbox = Rectangle.Empty;
		}

		private void BeforeLabelEdit (object sender,NodeLabelEditEventArgs e) {
			object obj = ProjectTree.GetNodeObject (e.Node);
			e.CancelEdit = !(obj != null && obj is UMLDes.GUI.View);
		}

		private void AfterLabelEdit (object sender,NodeLabelEditEventArgs e) {
			object obj = ProjectTree.GetNodeObject (e.Node);
			if (obj != null && obj is UMLDes.GUI.View) {
				UMLDes.GUI.View v = obj as UMLDes.GUI.View;
				if (e.Label != null)
					v.name = e.Label;
			}
			RefreshTitle ();
		}

		private void tree_GiveFeedback (object sender,System.Windows.Forms.GiveFeedbackEventArgs e) {

			e.UseDefaultCursors = false;
			if ((e.Effect & DragDropEffects.Copy) == DragDropEffects.Copy)
				Cursor.Current = Cursors.Hand;
			else
				Cursor.Current = Cursors.No;
		}

		#endregion

		#region “帮助”菜单

		private void Help_Popup (object sender,System.EventArgs e) {
			menu_GC_Collect.Text = "GC.Collect (" + GC.GetTotalMemory (false) / 1024 + " Kb alloc)";//内存回收
		}

		private void menu_GC_Collect_Click (object sender,System.EventArgs e) {
			GC.Collect ();
		}

		//yyj
		private void menu_About_Click (object sender,System.EventArgs e) {
			About aboutfrm = new About ();
			aboutfrm.ShowDialog ();
		}
		#endregion

		#region 状态栏相关

		internal void SetStatus (string text) {
			status_Label.Text = text;
		}

		internal void SetAdvise (string text) {
			//advise_panel.Text = text;
		}

		#endregion

		private void Calculate (object sender,EventArgs e) {
			int LineNum,PackageNum;
			SetStatus ("正在计算耦合度,请稍候...");
			double result=(ViewCtrl1.Curr as UMLDes.GUI.StaticView).CallCalculate (out LineNum,out PackageNum);
			MessageBox.Show ("当前图中共有Package"+PackageNum.ToString ()+"个,Line"+LineNum.ToString()+"条,耦合度为:"+result.ToString ());
			SetStatus ("就绪");
		}
	}
}
