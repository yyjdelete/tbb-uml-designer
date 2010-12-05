//.cs
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UMLDes.Controls {
	public interface IVisible {
		bool Visible {
			get;
			set;
		}
		string Name {
			get;
		}
		int ImageIndex {
			get;
		}
	}
	/// <summary>
	/// Form1  的摘要说明.
	/// </summary>
	public partial class ShowHideDialog:System.Windows.Forms.Form {
		public ShowHideDialog () {
			InitializeComponent ();
		}

		#region 按钮行为

		private void OK_Click (object sender,System.EventArgs e) {
			Apply ();
			Close ();
		}

		private void Cancel_Click (object sender,System.EventArgs e) {
			Close ();
		}

		private void ShowSelected_Click (object sender,System.EventArgs e) {
			foreach (ListViewItem lvi in listView1.SelectedItems) {
				lvi.Checked = true;
			}
		}

		private void HideSelected_Click (object sender,System.EventArgs e) {
			foreach (ListViewItem lvi in listView1.SelectedItems) {
				lvi.Checked = false;
			}
		}

		private void ShowAll_Click (object sender,System.EventArgs e) {
			foreach (ListViewItem lvi in listView1.Items) {
				lvi.Checked = true;
			}
		}

		private void HideAll_Click (object sender,System.EventArgs e) {
			foreach (ListViewItem lvi in listView1.Items) {
				lvi.Checked = false;
			}
		}

		private void Invert_Click (object sender,System.EventArgs e) {
			foreach (ListViewItem lvi in listView1.Items) {
				lvi.Checked = !lvi.Checked;
			}
		}

		#endregion

		bool applied = false;

		void Apply () {
			foreach (ListViewItem lvi in listView1.Items) {
				IVisible v = (IVisible) lvi.Tag;
				if (lvi.Checked != v.Visible) {
					v.Visible = lvi.Checked;
					applied = true;
				}
			}
		}

		public static bool Process (IWin32Window owner,IEnumerable items,ImageList list) {
			using (ShowHideDialog shd = new ShowHideDialog ()) {
				shd.listView1.SmallImageList = list;
				shd.listView1.Items.Clear ();
				foreach (IVisible v in items) {
					ListViewItem lvi = new ListViewItem (v.Name,v.ImageIndex);
					lvi.Checked = v.Visible;
					lvi.Tag = v;
					shd.listView1.Items.Add (lvi);
				}
				shd.RefreshHiddenCount ();
				shd.ShowDialog (owner);
				return shd.applied;
			}
		}

		int hiddencount_val;

		void RefreshHiddenCount () {
			hiddencount_val = 0;
			foreach (ListViewItem lvi in listView1.Items)
				if (!lvi.Checked)
					hiddencount_val++;
			hiddencount.Text = hiddencount_val + "个项目被隐藏";
		}

		private void listView1_ItemCheck (object sender,System.Windows.Forms.ItemCheckEventArgs e) {
			hiddencount_val += (e.CurrentValue == CheckState.Checked ? 1 : 0) - (e.NewValue == CheckState.Checked ? 1 : 0);
			hiddencount.Text = hiddencount_val + "个项目被隐藏";

		}

		private void ShowHideDialog_Load (object sender,System.EventArgs e) {
			listView1.ItemCheck += new ItemCheckEventHandler (listView1_ItemCheck);
		}
	}
}
