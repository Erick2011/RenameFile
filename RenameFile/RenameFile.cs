using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RenameFile
{
    public partial class RenameFile : Form
    {
        #region Attributos
        List<string> checkedItems = new List<string>();
        #endregion

        #region Constructor
        public RenameFile()
        {
            InitializeComponent();
            this.lbRenamedList.AllowDrop = true;
        }
        #endregion

        #region Methods
        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            txtPathFolder.Text = string.Empty;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Seleccione la Carpeta";
            fbd.RootFolder = Environment.SpecialFolder.Desktop;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtPathFolder.Text = fbd.SelectedPath;
                FillOriginalList();
            }
        }

        private void FillOriginalList()
        {
            clOriginalList.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(txtPathFolder.Text);
            if (dir.GetFiles().Length == 0)
            {
                btnSelectAll.Enabled = false;
                return;
            }

            btnSelectAll.Enabled = true;

            foreach (var file in dir.GetFiles())
            {
                clOriginalList.Items.Add(file.Name);
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            if (btnSelectAll.Text.Equals("Selecciona Todo"))
            {
                for (int i = 0; i < clOriginalList.Items.Count; i++)
                {
                    clOriginalList.SetItemChecked(i, true);
                }
                btnSelectAll.Text = "Deselecciona Todo";
            }
            else
            {
                for (int i = 0; i < clOriginalList.Items.Count; i++)
                {
                    clOriginalList.SetItemChecked(i, false);
                }
                btnSelectAll.Text = "Selecciona Todo";
            }
        }

        private void clOriginalList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                checkedItems.Add(clOriginalList.Items[e.Index].ToString());

            if (e.NewValue == CheckState.Unchecked)
                checkedItems.Remove(clOriginalList.Items[e.Index].ToString());

            lbRenamedList.Items.Clear();
            foreach (string item in checkedItems)
            {
                lbRenamedList.Items.Add(item);
            }
        }

        private void lbRenamedList_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.lbRenamedList.SelectedItem == null) return;
            this.lbRenamedList.DoDragDrop(this.lbRenamedList.SelectedItem, DragDropEffects.Move);
        }

        private void lbRenamedList_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void lbRenamedList_DragDrop(object sender, DragEventArgs e)
        {
            Point point = lbRenamedList.PointToClient(new Point(e.X, e.Y));
            int index = this.lbRenamedList.IndexFromPoint(point);
            if (index < 0) index = this.lbRenamedList.Items.Count - 1;
            object data = e.Data.GetData(typeof(string));
            this.lbRenamedList.Items.Remove(data);
            this.lbRenamedList.Items.Insert(index, data);
        }
        #endregion
    }
}
