using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UMLDes.Controls {

	public interface IVisible {
		bool Visible { get; set; }
		string Name { get; }
		int ImageIndex { get; }
	}

	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class ShowHideDialog : System.Windows.Forms.Form
	{
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
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		#region Constructor/Dispose

		public ShowHideDialog() {
			InitializeComponent();
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		/// <param name="disposing">���Ӧ�ͷ��й���Դ��Ϊ true������Ϊ false��</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#endregion

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫ
		/// ʹ�ô���༭���޸Ĵ˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowHideDialog));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.HideSelected = new System.Windows.Forms.Button();
			this.ShowSelected = new System.Windows.Forms.Button();
			this.Invert = new System.Windows.Forms.Button();
			this.HideAll = new System.Windows.Forms.Button();
			this.ShowAll = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.Cancel = new System.Windows.Forms.Button();
			this.OK = new System.Windows.Forms.Button();
			this.hiddencount = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.HideSelected);
			this.groupBox1.Controls.Add(this.ShowSelected);
			this.groupBox1.Controls.Add(this.Invert);
			this.groupBox1.Controls.Add(this.HideAll);
			this.groupBox1.Controls.Add(this.ShowAll);
			this.groupBox1.Controls.Add(this.listView1);
			this.groupBox1.Location = new System.Drawing.Point(0, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(432, 329);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "�ɼ���";
			// 
			// HideSelected
			// 
			this.HideSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.HideSelected.Location = new System.Drawing.Point(317, 60);
			this.HideSelected.Name = "HideSelected";
			this.HideSelected.Size = new System.Drawing.Size(106, 26);
			this.HideSelected.TabIndex = 2;
			this.HideSelected.Text = "����";
			this.HideSelected.Click += new System.EventHandler(this.HideSelected_Click);
			// 
			// ShowSelected
			// 
			this.ShowSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ShowSelected.Location = new System.Drawing.Point(317, 26);
			this.ShowSelected.Name = "ShowSelected";
			this.ShowSelected.Size = new System.Drawing.Size(106, 26);
			this.ShowSelected.TabIndex = 1;
			this.ShowSelected.Text = "��ʾ";
			this.ShowSelected.Click += new System.EventHandler(this.ShowSelected_Click);
			// 
			// Invert
			// 
			this.Invert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Invert.Location = new System.Drawing.Point(317, 190);
			this.Invert.Name = "Invert";
			this.Invert.Size = new System.Drawing.Size(106, 25);
			this.Invert.TabIndex = 5;
			this.Invert.Text = "����ѡ��";
			this.Invert.Click += new System.EventHandler(this.Invert_Click);
			// 
			// HideAll
			// 
			this.HideAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.HideAll.Location = new System.Drawing.Point(317, 155);
			this.HideAll.Name = "HideAll";
			this.HideAll.Size = new System.Drawing.Size(106, 26);
			this.HideAll.TabIndex = 4;
			this.HideAll.Text = "ȫ������";
			this.HideAll.Click += new System.EventHandler(this.HideAll_Click);
			// 
			// ShowAll
			// 
			this.ShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ShowAll.Location = new System.Drawing.Point(317, 121);
			this.ShowAll.Name = "ShowAll";
			this.ShowAll.Size = new System.Drawing.Size(106, 25);
			this.ShowAll.TabIndex = 3;
			this.ShowAll.Text = "ȫ����ʾ";
			this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.CheckBoxes = true;
			this.listView1.FullRowSelect = true;
			this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(10, 17);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(298, 301);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.List;
			// 
			// Cancel
			// 
			this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancel.Location = new System.Drawing.Point(279, 341);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(134, 26);
			this.Cancel.TabIndex = 7;
			this.Cancel.Text = "ȡ��";
			this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// OK
			// 
			this.OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.OK.Location = new System.Drawing.Point(135, 341);
			this.OK.Name = "OK";
			this.OK.Size = new System.Drawing.Size(134, 26);
			this.OK.TabIndex = 6;
			this.OK.Text = "ȷ��";
			this.OK.Click += new System.EventHandler(this.OK_Click);
			// 
			// hiddencount
			// 
			this.hiddencount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.hiddencount.Location = new System.Drawing.Point(10, 346);
			this.hiddencount.Name = "hiddencount";
			this.hiddencount.Size = new System.Drawing.Size(91, 17);
			this.hiddencount.TabIndex = 8;
			this.hiddencount.Text = "0����Ŀ������";
			// 
			// ShowHideDialog
			// 
			this.AcceptButton = this.OK;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Cancel;
			this.ClientSize = new System.Drawing.Size(432, 373);
			this.Controls.Add(this.hiddencount);
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.OK);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(446, 302);
			this.Name = "ShowHideDialog";
			this.ShowInTaskbar = false;
			this.Text = "��ʾ/���� Dialog";
			this.Load += new System.EventHandler(this.ShowHideDialog_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Button handlers

		private void OK_Click(object sender, System.EventArgs e) {
			Apply();
			Close();
		}

		private void Cancel_Click(object sender, System.EventArgs e) {
			Close();
		}

		private void ShowSelected_Click(object sender, System.EventArgs e) {
			foreach( ListViewItem lvi in listView1.SelectedItems ) {
				lvi.Checked = true;
			}
		}

		private void HideSelected_Click(object sender, System.EventArgs e) {
			foreach( ListViewItem lvi in listView1.SelectedItems ) {
				lvi.Checked = false;
			}
		}

		private void ShowAll_Click(object sender, System.EventArgs e) {
			foreach( ListViewItem lvi in listView1.Items ) {
				lvi.Checked = true;
			}
		}

		private void HideAll_Click(object sender, System.EventArgs e) {
			foreach( ListViewItem lvi in listView1.Items ) {
				lvi.Checked = false;
			}
		}

		private void Invert_Click(object sender, System.EventArgs e) {
			foreach( ListViewItem lvi in listView1.Items ) {
				lvi.Checked = !lvi.Checked;
			}
		}

		#endregion

		bool applied = false;

		void Apply() {
			foreach( ListViewItem lvi in listView1.Items ) {
				IVisible v = (IVisible)lvi.Tag;
				if( lvi.Checked != v.Visible ) {
					v.Visible = lvi.Checked;
					applied = true;
				}
			}
		}

		public static bool Process( IWin32Window owner, IEnumerable items, ImageList list ) {
			using( ShowHideDialog shd = new ShowHideDialog() ) {
				shd.listView1.SmallImageList = list;
				shd.listView1.Items.Clear();
				foreach( IVisible v in items ) {
					ListViewItem lvi = new ListViewItem( v.Name, v.ImageIndex );
					lvi.Checked = v.Visible;
					lvi.Tag = v;
					shd.listView1.Items.Add( lvi );
				}
				shd.RefreshHiddenCount();
				shd.ShowDialog( owner );
				return shd.applied;
			}
		}

		int hiddencount_val;

		void RefreshHiddenCount() {
			hiddencount_val = 0;
			foreach( ListViewItem lvi in listView1.Items )
				if( !lvi.Checked )
                    hiddencount_val++;
            hiddencount.Text = hiddencount_val + "����Ŀ������";
		}

		private void listView1_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e) {
			hiddencount_val += (e.CurrentValue == CheckState.Checked ? 1 : 0 ) - (e.NewValue == CheckState.Checked ? 1 : 0 );
            hiddencount.Text = hiddencount_val + "����Ŀ������";
			
		}

		private void ShowHideDialog_Load(object sender, System.EventArgs e) {
			listView1.ItemCheck += new ItemCheckEventHandler(listView1_ItemCheck);
		}
	}
}
