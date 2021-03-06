﻿namespace RenameFile
{
    partial class RenameFile
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenameFile));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCopyPath = new System.Windows.Forms.Button();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.txtPathFolder = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.txtSerieName = new System.Windows.Forms.TextBox();
            this.txtSeason = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clOriginalList = new System.Windows.Forms.CheckedListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbRenamedList = new System.Windows.Forms.ListBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblDragMessage = new System.Windows.Forms.Label();
            this.btnUndoChanges = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCopyPath);
            this.groupBox1.Controls.Add(this.btnSelectPath);
            this.groupBox1.Controls.Add(this.txtPathFolder);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Seleccione la Carpeta / Pegar Ruta";
            // 
            // btnCopyPath
            // 
            this.btnCopyPath.Location = new System.Drawing.Point(328, 16);
            this.btnCopyPath.Name = "btnCopyPath";
            this.btnCopyPath.Size = new System.Drawing.Size(75, 23);
            this.btnCopyPath.TabIndex = 2;
            this.btnCopyPath.Text = "Pegar Ruta";
            this.btnCopyPath.UseVisualStyleBackColor = true;
            this.btnCopyPath.Click += new System.EventHandler(this.txtCopyPath_Click);
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(285, 16);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(37, 23);
            this.btnSelectPath.TabIndex = 1;
            this.btnSelectPath.Text = "...";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // txtPathFolder
            // 
            this.txtPathFolder.Enabled = false;
            this.txtPathFolder.Location = new System.Drawing.Point(6, 17);
            this.txtPathFolder.Name = "txtPathFolder";
            this.txtPathFolder.Size = new System.Drawing.Size(273, 20);
            this.txtPathFolder.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRename);
            this.groupBox2.Controls.Add(this.txtSerieName);
            this.groupBox2.Controls.Add(this.txtSeason);
            this.groupBox2.Location = new System.Drawing.Point(427, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 55);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Temporada / Nombre de la Serie";
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(328, 16);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 23);
            this.btnRename.TabIndex = 2;
            this.btnRename.Text = "Renombrar";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // txtSerieName
            // 
            this.txtSerieName.Location = new System.Drawing.Point(83, 17);
            this.txtSerieName.Name = "txtSerieName";
            this.txtSerieName.Size = new System.Drawing.Size(239, 20);
            this.txtSerieName.TabIndex = 1;
            // 
            // txtSeason
            // 
            this.txtSeason.Location = new System.Drawing.Point(9, 17);
            this.txtSeason.Name = "txtSeason";
            this.txtSeason.Size = new System.Drawing.Size(68, 20);
            this.txtSeason.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblDragMessage);
            this.groupBox3.Controls.Add(this.clOriginalList);
            this.groupBox3.Location = new System.Drawing.Point(12, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 304);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Archivos de la Carpeta";
            // 
            // clOriginalList
            // 
            this.clOriginalList.AllowDrop = true;
            this.clOriginalList.CheckOnClick = true;
            this.clOriginalList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clOriginalList.FormattingEnabled = true;
            this.clOriginalList.Location = new System.Drawing.Point(6, 19);
            this.clOriginalList.Name = "clOriginalList";
            this.clOriginalList.Size = new System.Drawing.Size(397, 270);
            this.clOriginalList.TabIndex = 0;
            this.clOriginalList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clOriginalList_ItemCheck);
            this.clOriginalList.DragEnter += new System.Windows.Forms.DragEventHandler(this.clOriginalList_DragEnter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbRenamedList);
            this.groupBox4.Location = new System.Drawing.Point(427, 100);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(409, 304);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " Archivos a Renombrar";
            // 
            // lbRenamedList
            // 
            this.lbRenamedList.AllowDrop = true;
            this.lbRenamedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRenamedList.FormattingEnabled = true;
            this.lbRenamedList.ItemHeight = 18;
            this.lbRenamedList.Location = new System.Drawing.Point(6, 20);
            this.lbRenamedList.Name = "lbRenamedList";
            this.lbRenamedList.Size = new System.Drawing.Size(397, 274);
            this.lbRenamedList.TabIndex = 0;
            this.lbRenamedList.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbRenamedList_DragDrop);
            this.lbRenamedList.DragOver += new System.Windows.Forms.DragEventHandler(this.lbRenamedList_DragOver);
            this.lbRenamedList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbRenamedList_MouseDown);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Enabled = false;
            this.btnSelectAll.Location = new System.Drawing.Point(297, 76);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(124, 23);
            this.btnSelectAll.TabIndex = 1;
            this.btnSelectAll.Text = "Selecciona Todo";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredits.Location = new System.Drawing.Point(586, 419);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(250, 13);
            this.lblCredits.TabIndex = 4;
            this.lblCredits.Text = "Hecho por _Mugiwara_  Solo para @CanalesLocos";
            // 
            // lblDragMessage
            // 
            this.lblDragMessage.AutoSize = true;
            this.lblDragMessage.BackColor = System.Drawing.SystemColors.Window;
            this.lblDragMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDragMessage.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblDragMessage.Location = new System.Drawing.Point(72, 144);
            this.lblDragMessage.Name = "lblDragMessage";
            this.lblDragMessage.Size = new System.Drawing.Size(250, 20);
            this.lblDragMessage.TabIndex = 1;
            this.lblDragMessage.Text = "Arrastra la carpeta de tus archivos";
            // 
            // btnUndoChanges
            // 
            this.btnUndoChanges.Enabled = false;
            this.btnUndoChanges.Location = new System.Drawing.Point(704, 76);
            this.btnUndoChanges.Name = "btnUndoChanges";
            this.btnUndoChanges.Size = new System.Drawing.Size(126, 23);
            this.btnUndoChanges.TabIndex = 3;
            this.btnUndoChanges.Text = "Deshacer Renombrado";
            this.btnUndoChanges.UseVisualStyleBackColor = true;
            this.btnUndoChanges.Click += new System.EventHandler(this.btnUndoChanges_Click);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(430, 81);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(232, 13);
            this.lblNote.TabIndex = 5;
            this.lblNote.Text = "Crea correlativos (Temp*Nro Corelativo)";
            // 
            // RenameFile
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 441);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.btnUndoChanges);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RenameFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rename File v1.1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCopyPath;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.TextBox txtPathFolder;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.TextBox txtSerieName;
        private System.Windows.Forms.TextBox txtSeason;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.CheckedListBox clOriginalList;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.ListBox lbRenamedList;
        private System.Windows.Forms.Label lblDragMessage;
        private System.Windows.Forms.Button btnUndoChanges;
        private System.Windows.Forms.Label lblNote;
    }
}

