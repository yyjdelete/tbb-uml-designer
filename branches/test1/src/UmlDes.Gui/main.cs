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
		public GUI.IDrawSelect sv;
		public MainWnd () {
			InitializeComponent ();
			PostInitialize ();
			list = toolbarImages;

			TurnOnProject (UmlDesignerSolution.createNew ());
		}

		#region 工具栏相关

		void EnableButton (ToolStripButton b,bool en) {
			if (!b.Enabled != en)
				b.Enabled=!b.Enabled;
		}

		public void UpdateToolBar () {
			EnableButton (tool_Undo,ViewCtrl1.Curr.undo.can_undo);
			EnableButton (tool_Redo,ViewCtrl1.Curr.undo.can_redo);
		}

		void ToolbarAction (int index) {
			switch ((ToolBarIcons) index) {
				case ToolBarIcons.New:   // 新建
					NewProject (null,null);
					break;
				case ToolBarIcons.Open:   // 打开
					LoadProject (null,null);
					break;
				case ToolBarIcons.Save:   // 保存
					SaveProject (null,null);
					break;
				case ToolBarIcons.Saveas:   // 另存为
					SaveAsProject (null,null);
					break;
				case ToolBarIcons.add_file: // 添加文件
					AddFiles (null,null);
					break;
				case ToolBarIcons.new_diagram: // New Static view
					AddStaticView (null,null);
					break;
				case ToolBarIcons.refresh:  // 刷新模型
					RefreshProject (null,null);
					break;
				case ToolBarIcons.print: // 打印
					Print (null,null);
					break;
				case ToolBarIcons.print_preview: // 打印预览
					PrintPreview (null,null);
					break;
				case ToolBarIcons.undo:   // 撤销
					Undo (null,null);
					break;
				case ToolBarIcons.redo:   // 重做
					Redo (null,null);
					break;
				case ToolBarIcons.cut:
				case ToolBarIcons.copy:
				case ToolBarIcons.paste:
					MessageBox.Show ("CopyPaste" + ((ToolBarIcons) index).ToString ());
					break;
			}
		}



		/// <summary>
		/// 刷新按钮选中状态
		/// </summary>
		/// <param name="tsb">待选中的工具栏按钮对象(ToolStripButton)</param>
		void UnCheckAllOther (ToolStripButton tsb) {
			int maxnum=tsb.Owner.Items.Count;
			int i;
			for (i=0;i<maxnum;i++)
				if (tsb.Owner.Items[i] is ToolStripButton)//跳过间隔条toolStripSeparator
					(tsb.Owner.Items[i] as ToolStripButton).Checked=false;
			tsb.Checked=true;//采用.CheckState=System.Windows.Forms.CheckState.xxx亦可
		}

		private void toolStrip_Select (object sender,EventArgs e) {//选择绘制对象
			ToolStripButton stsb=sender as ToolStripButton;
			if (stsb.Checked==false) {//若更改选择
				UnCheckAllOther (stsb);
				(ViewCtrl1.Curr as UMLDes.GUI.StaticView).ToolbarAction (stsb.Name);
			}
		}

		#endregion

		#region 主窗口、关闭及保存提示

		[STAThread]
		static void Main () {
			Application.Run (new MainWnd ());
		}

		private bool SaveChanges () {
			if (p.modified) {
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

		public void RefreshTitle () {
			this.Text = "TBB UML Designer: " + p.name + " [" + ViewCtrl1.Curr.name + "]";
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

		ArrayList view_toolbar_panels = null;

		public GUI.View GetCurrentView () {
			return ViewCtrl1.Curr;
		}

		public void SelectView (GUI.View v,bool update) {
			ViewCtrl1.Curr = v;
			if (update) {
				if (view_toolbar_panels != null)
					foreach (FlatToolBarPanel panel in view_toolbar_panels)
//					toolBar1.RemovePanel (panel);
				view_toolbar_panels = v.LoadToolbars ();
				RefreshTitle ();
				ViewCtrl1.Invalidate ();
				UnCheckAllOther (tool_arrow);
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
				MessageBox.Show ("图为空","没有待保存的对象",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
				MessageBox.Show ("图为空","没有待复制的对象",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
			menu_Undo.Enabled = ViewCtrl1.Curr.undo.can_undo;
			menu_Redo.Enabled = ViewCtrl1.Curr.undo.can_redo;
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



		/*void ToolbarAction (int index) {
			switch ((ToolBarIcons) index) {
				// what to do
				case ToolBarIcons.arrow:
					MouseAgent.current_operation=MouseOperation.Select;
					break;
				case ToolBarIcons.conn_inher:
					MouseAgent.current_operation=MouseOperation.DrawConnection;
					MouseAgent.conn_type=UmlRelationType.Inheritance;
					break;
				case ToolBarIcons.conn_assoc:
					MouseAgent.current_operation=MouseOperation.DrawConnection;
					MouseAgent.conn_type=UmlRelationType.Association;
					break;
				case ToolBarIcons.conn_aggregation:
					MouseAgent.current_operation=MouseOperation.DrawConnection;
					MouseAgent.conn_type=UmlRelationType.Aggregation;
					break;
				case ToolBarIcons.conn_composition:
					MouseAgent.current_operation=MouseOperation.DrawConnection;
					MouseAgent.conn_type=UmlRelationType.Composition;
					break;
				case ToolBarIcons.conn_realiz:
					MouseAgent.current_operation=MouseOperation.DrawConnection;
					MouseAgent.conn_type=UmlRelationType.Realization;
					break;
				case ToolBarIcons.conn_attachm:
					MouseAgent.current_operation=MouseOperation.DrawConnection;
					MouseAgent.conn_type=UmlRelationType.Attachment;
					break;
				case ToolBarIcons.conn_dependence:
					MouseAgent.current_operation=MouseOperation.DrawConnection;
					MouseAgent.conn_type=UmlRelationType.Dependency;
					break;
				case ToolBarIcons.memo:
					MouseAgent.current_operation=MouseOperation.DrawComment;
					break;
				case ToolBarIcons.package:
					MouseAgent.current_operation=MouseOperation.DrawPackage;
					break;
				// line type
				case ToolBarIcons.straight_conn:
					MouseAgent.conn_style=GuiConnectionStyle.Line;
					break;
				case ToolBarIcons.segmented_conn:
					MouseAgent.conn_style=GuiConnectionStyle.Segmented;
					break;
				case ToolBarIcons.quadric_conn:
					MouseAgent.conn_style=GuiConnectionStyle.Quadric;
					break;
				case ToolBarIcons.curved_conn:
					MouseAgent.conn_style=GuiConnectionStyle.Besier;
					break;
			}
		}*/

/*
		private void tool_arrow_Click (object sender,EventArgs e) {
			if ((sender as ToolStripButton).Checked==false) {
				UnCheckAllOther (sender as ToolStripButton);

			}
		}

		private void tool_conn_inher_Click (object sender,EventArgs e) {
			UnCheckAllOther (sender as ToolStripButton);
		}

		private void tool_conn_assoc_Click (object sender,EventArgs e) {
			UnCheckAllOther (sender as ToolStripButton);
		}

		private void tool_conn_aggregation_Click (object sender,EventArgs e) {
			UnCheckAllOther (sender as ToolStripButton);
		}

		private void tool_conn_composition_Click (object sender,EventArgs e) {
			UnCheckAllOther (sender as ToolStripButton);
		}

		private void tool_conn_attachm_Click (object sender,EventArgs e) {
			UnCheckAllOther (sender as ToolStripButton);
		}

		private void tool_conn_dependence_Click (object sender,EventArgs e) {
			UnCheckAllOther (sender as ToolStripButton);
		}

		private void tool_conn_realiz_Click (object sender,EventArgs e) {
			UnCheckAllOther (sender as ToolStripButton);
		}

		private void tool_memo_Click (object sender,EventArgs e) {
			UnCheckAllOther (sender as ToolStripButton);
		}

		private void tool_package_Click (object sender,EventArgs e) {
			UnCheckAllOther (sender as ToolStripButton);
		}

		private void tool_constraint_Click (object sender,EventArgs e) {
			UnCheckAllOther (sender as ToolStripButton);
		}

		private void tool_actor_Click (object sender,EventArgs e) {
			UnCheckAllOther (sender as ToolStripButton);
		}
		*/
	}
}
