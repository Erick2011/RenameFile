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
        List<string> RenamedItems = new List<string>();
        string shortPath = string.Empty;
        #endregion

        #region Constructor
        public RenameFile()
        {
            InitializeComponent();
            this.AllowDrop = true;
        }
        #endregion


        #region Methods
        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            txtPathFolder.Text = string.Empty;
            clOriginalList.Items.Clear();
            lbRenamedList.Items.Clear();
            checkedItems.Clear();
            lblDragMessage.Visible = true;
            btnUndoChanges.Enabled = false;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Seleccione la Carpeta";
            fbd.RootFolder = Environment.SpecialFolder.Desktop;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtPathFolder.Text = fbd.SelectedPath;
                lblDragMessage.Visible = false;
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
            try
            {
                Point point = lbRenamedList.PointToClient(new Point(e.X, e.Y));
                int index = this.lbRenamedList.IndexFromPoint(point);
                if (index < 0) index = this.lbRenamedList.Items.Count - 1;
                object data = e.Data.GetData(typeof(string));
                this.lbRenamedList.Items.Remove(data);
                this.lbRenamedList.Items.Insert(index, data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Acción no permitida", 
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation, 
                    MessageBoxDefaultButton.Button1);
            }          
        }

        private void clOriginalList_DragEnter(object sender, DragEventArgs e)
        {
            DragDropEffects effects = DragDropEffects.None;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];

                FileAttributes attr = File.GetAttributes(path);
                bool isFolder = (attr & FileAttributes.Directory) == FileAttributes.Directory;
                if (!isFolder)
                {
                    MessageBox.Show(
                        "Archivo no permitido", 
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                    return;
                }

                effects = DragDropEffects.Copy;
                lblDragMessage.Visible = false;
                btnUndoChanges.Enabled = true;
                txtPathFolder.Text = path;
                FillOriginalList();
            }

            e.Effect = effects;
        }

        private bool isChecked()
        {
            bool result = clOriginalList.CheckedItems.Count == clOriginalList.Items.Count ? true : false;
            return result;
        }

        private void txtCopyPath_Click(object sender, EventArgs e)
        {
            txtPathFolder.Text = Clipboard.GetText();
            if (!Directory.Exists(txtPathFolder.Text))
            {
                MessageBox.Show(
                    "Ruta de carpeta no valida", 
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);

                txtPathFolder.Text = string.Empty;
                clOriginalList.Items.Clear();
                lbRenamedList.Items.Clear();
                checkedItems.Clear();
                lblDragMessage.Visible = true;
                return;
            }
            lblDragMessage.Visible = false;
            FillOriginalList();
        }
        #endregion

        private void btnRename_Click(object sender, EventArgs e)
        {
            RenamedItems.Clear();

            if (txtSerieName.Text.Equals(""))
            {
                MessageBox.Show(
                    "Debe ingresar el nombre de la Serie/Película", 
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation, 
                    MessageBoxDefaultButton.Button1);
                return;
            }
            if(checkedItems.Count == 0)
            {
                MessageBox.Show(
                    "Debe ingresar al menos un archivo a renombrar", 
                    "Error",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation, 
                    MessageBoxDefaultButton.Button1);
                return;
            }
            int i = 1;
            shortPath = txtPathFolder.Text;

            if (txtSeason.Text.Contains("*"))
            {
                string beginningExp = txtSeason.Text;

                string[] values = beginningExp.Split('*');

                string season = values[0];

                int capitule = Convert.ToInt32(values[1]);

                foreach (string filename in checkedItems)
                {
                    if (capitule < 10)
                    {
                        File.Move($"{txtPathFolder.Text}\\{filename}", $"{txtPathFolder.Text}\\{season}x0{capitule} {txtSerieName.Text}");
                        RenamedItems.Add($"{txtPathFolder.Text}\\{season}x0{capitule} {txtSerieName.Text}");
                    }
                    else
                    {
                        File.Move($"{txtPathFolder.Text}\\{filename}", $"{txtPathFolder.Text}\\{season}x{capitule} {txtSerieName.Text}");
                        RenamedItems.Add($"{txtPathFolder.Text}\\{season}x{capitule} {txtSerieName.Text}");
                    }
                    capitule++;
                }
            }
            else
            {
                if (txtSeason.Text.Equals(string.Empty))
                {
                    foreach (string filename in checkedItems)
                    {
                        if (i < 10)
                        {
                            File.Move($"{txtPathFolder.Text}\\{filename}", $"{txtPathFolder.Text}\\0{i} {txtSerieName.Text}");
                            RenamedItems.Add($"{txtPathFolder.Text}\\0{i} {txtSerieName.Text}");
                        }
                        else
                        {
                            File.Move($"{txtPathFolder.Text}\\{filename}", $"{txtPathFolder.Text}\\{i} {txtSerieName.Text}");
                            RenamedItems.Add($"{txtPathFolder.Text}\\{i} {txtSerieName.Text}");
                        }
                        i++;
                    }
                }
                else
                {
                    foreach (string filename in checkedItems)
                    {
                        if (i < 10)
                        {
                            File.Move($"{txtPathFolder.Text}\\{filename}", $"{txtPathFolder.Text}\\{txtSeason.Text}x0{i} {txtSerieName.Text}");
                            RenamedItems.Add($"{txtPathFolder.Text}\\{txtSeason.Text}x0{i} {txtSerieName.Text}");
                        }
                        else
                        {
                            File.Move($"{txtPathFolder.Text}\\{filename}", $"{txtPathFolder.Text}\\{txtSeason.Text}x{i} {txtSerieName.Text}");
                            RenamedItems.Add($"{txtPathFolder.Text}\\{txtSeason.Text}x{i} {txtSerieName.Text}");
                        }
                        i++;
                    }
                }
            }
          
            MessageBox.Show("Archivos renombrados exitosamente!!", 
                "Información", 
                MessageBoxButtons.OK,
                MessageBoxIcon.Information, 
                MessageBoxDefaultButton.Button1);
            ClearControls();
            btnUndoChanges.Enabled = true;
        }       

        private void ClearControls()
        {
            txtSeason.Text = string.Empty;
            txtPathFolder.Text = string.Empty;
            txtSerieName.Text = string.Empty;
            clOriginalList.Items.Clear();
            lbRenamedList.Items.Clear();
            btnSelectAll.Text = "Selecciona Todo";
        }

        private void btnUndoChanges_Click(object sender, EventArgs e)
        {
            UndoChanges();
        }

        private void UndoChanges()
        {
            for (int i = 0; i < checkedItems.Count; i++)
            {
                File.Move($"{RenamedItems[i].ToString()}", $"{shortPath}\\{checkedItems[i].ToString()}");
            }
            MessageBox.Show(
                "Cambios deshechos exitosamente!!", 
                "Información", 
                MessageBoxButtons.OK,
                MessageBoxIcon.Information, 
                MessageBoxDefaultButton.Button1);

            btnUndoChanges.Enabled = false;
        }
    }
}
