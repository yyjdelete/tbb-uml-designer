//designer.cs

namespace UMLDes.Controls {
	public partial class ShowHideDialog:System.Windows.Forms.Form {
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose (bool disposing) {
			if (disposing) {
				if (components != null) {
					components.Dispose ();
				}
			}
			base.Dispose (disposing);
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent () {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (ShowHideDialog));
			this.groupBox1 = new System.Windows.Forms.GroupBox ();
			this.HideSelected = new System.Windows.Forms.Button ();
			this.ShowSelected = new System.Windows.Forms.Button ();
			this.Invert = new System.Windows.Forms.Button ();
			this.HideAll = new System.Windows.Forms.Button ();
			this.ShowAll = new System.Windows.Forms.Button ();
			this.listView1 = new System.Windows.Forms.ListView ();
			this.Cancel = new System.Windows.Forms.Button ();
			this.OK = new System.Windows.Forms.Button ();
			this.hiddencount = new System.Windows.Forms.Label ();
			this.groupBox1.SuspendLayout ();
			this.SuspendLayout ();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add (this.HideSelected);
			this.groupBox1.Controls.Add (this.ShowSelected);
			this.groupBox1.Controls.Add (this.Invert);
			this.groupBox1.Controls.Add (this.HideAll);
			this.groupBox1.Controls.Add (this.ShowAll);
			this.groupBox1.Controls.Add (this.listView1);
			this.groupBox1.Location = new System.Drawing.Point (0,4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size (432,329);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "可见性";
			// 
			// HideSelected
			// 
			this.HideSelected.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.HideSelected.Location = new System.Drawing.Point (317,60);
			this.HideSelected.Name = "HideSelected";
			this.HideSelected.Size = new System.Drawing.Size (106,26);
			this.HideSelected.TabIndex = 2;
			this.HideSelected.Text = "隐藏";
			this.HideSelected.Click += new System.EventHandler (this.HideSelected_Click);
			// 
			// ShowSelected
			// 
			this.ShowSelected.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ShowSelected.Location = new System.Drawing.Point (317,26);
			this.ShowSelected.Name = "ShowSelected";
			this.ShowSelected.Size = new System.Drawing.Size (106,26);
			this.ShowSelected.TabIndex = 1;
			this.ShowSelected.Text = "显示";
			this.ShowSelected.Click += new System.EventHandler (this.ShowSelected_Click);
			// 
			// Invert
			// 
			this.Invert.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Invert.Location = new System.Drawing.Point (317,190);
			this.Invert.Name = "Invert";
			this.Invert.Size = new System.Drawing.Size (106,25);
			this.Invert.TabIndex = 5;
			this.Invert.Text = "反向选择";
			this.Invert.Click += new System.EventHandler (this.Invert_Click);
			// 
			// HideAll
			// 
			this.HideAll.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.HideAll.Location = new System.Drawing.Point (317,155);
			this.HideAll.Name = "HideAll";
			this.HideAll.Size = new System.Drawing.Size (106,26);
			this.HideAll.TabIndex = 4;
			this.HideAll.Text = "全部隐藏";
			this.HideAll.Click += new System.EventHandler (this.HideAll_Click);
			// 
			// ShowAll
			// 
			this.ShowAll.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ShowAll.Location = new System.Drawing.Point (317,121);
			this.ShowAll.Name = "ShowAll";
			this.ShowAll.Size = new System.Drawing.Size (106,25);
			this.ShowAll.TabIndex = 3;
			this.ShowAll.Text = "全部显示";
			this.ShowAll.Click += new System.EventHandler (this.ShowAll_Click);
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.CheckBoxes = true;
			this.listView1.FullRowSelect = true;
			this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point (10,17);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size (298,301);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.List;
			// 
			// Cancel
			// 
			this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancel.Location = new System.Drawing.Point (279,341);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size (134,26);
			this.Cancel.TabIndex = 7;
			this.Cancel.Text = "取消";
			this.Cancel.Click += new System.EventHandler (this.Cancel_Click);
			// 
			// OK
			// 
			this.OK.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.OK.Location = new System.Drawing.Point (135,341);
			this.OK.Name = "OK";
			this.OK.Size = new System.Drawing.Size (134,26);
			this.OK.TabIndex = 6;
			this.OK.Text = "确定";
			this.OK.Click += new System.EventHandler (this.OK_Click);
			// 
			// hiddencount
			// 
			this.hiddencount.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.hiddencount.Location = new System.Drawing.Point (10,346);
			this.hiddencount.Name = "hiddencount";
			this.hiddencount.Size = new System.Drawing.Size (91,17);
			this.hiddencount.TabIndex = 8;
			this.hiddencount.Text = "0个项目被隐藏";
			// 
			// ShowHideDialog
			// 
			this.AcceptButton = this.OK;
			this.AutoScaleBaseSize = new System.Drawing.Size (6,14);
			this.CancelButton = this.Cancel;
			this.ClientSize = new System.Drawing.Size (432,373);
			this.Controls.Add (this.hiddencount);
			this.Controls.Add (this.Cancel);
			this.Controls.Add (this.OK);
			this.Controls.Add (this.groupBox1);
			this.Icon = ((System.Drawing.Icon) (resources.GetObject ("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size (446,302);
			this.Name = "ShowHideDialog";
			this.ShowInTaskbar = false;
			this.Text = "显示/隐藏 Dialog";
			this.Load += new System.EventHandler (this.ShowHideDialog_Load);
			this.groupBox1.ResumeLayout (false);
			this.ResumeLayout (false);

		}
		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button HideSelected;
		private System.Windows.Forms.Button ShowSelected;
		private System.Windows.Forms.Button Invert;
		private System.Windows.Forms.Button HideAll;
		private System.Windows.Forms.Button ShowAll;
		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.Button OK;
		private System.Windows.Forms.Label hiddencount;
	}
}