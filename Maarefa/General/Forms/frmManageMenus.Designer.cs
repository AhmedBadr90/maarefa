﻿namespace maarefa
{
    partial class frmManageMenus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageMenus));
            this.treeVMenus = new System.Windows.Forms.TreeView();
            this.btnAddNode = new System.Windows.Forms.Button();
            this.btnDeleteNode = new System.Windows.Forms.Button();
            this.txtOBJECT_NAME_AR = new System.Windows.Forms.TextBox();
            this.lblOBJECT_NAME_AR = new System.Windows.Forms.Label();
            this.lblPARNT_OBJECT = new System.Windows.Forms.Label();
            this.txtPARNT_OBJECT = new System.Windows.Forms.TextBox();
            this.lblOBJECT_TYPE = new System.Windows.Forms.Label();
            this.lblOBJECT_COMMAND = new System.Windows.Forms.Label();
            this.txtOBJECT_COMMAND = new System.Windows.Forms.TextBox();
            this.chkbxSHOWTOOLBAR = new System.Windows.Forms.CheckBox();
            this.lblSHOWTOOLBAR = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblMenuImage = new System.Windows.Forms.Label();
            this.lblShortcutImage = new System.Windows.Forms.Label();
            this.cmbMenuIcon = new System.Windows.Forms.ComboBox();
            this.cmbShortcutIcon = new System.Windows.Forms.ComboBox();
            this.cmbOBJECT_TYPE = new System.Windows.Forms.ComboBox();
            this.btnRemoveMImage = new System.Windows.Forms.Button();
            this.btnRemoveTImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.Images.SetKeyName(0, "books-small.png");
            this.imageList1.Images.SetKeyName(1, "books-startup.png");
            this.imageList1.Images.SetKeyName(2, "icons8-cancel (1).png");
            this.imageList1.Images.SetKeyName(3, "icons8-plus (1).png");
            this.imageList1.Images.SetKeyName(4, "icons8-plus.png");
            // 
            // treeVMenus
            // 
            this.treeVMenus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.treeVMenus.Location = new System.Drawing.Point(466, 12);
            this.treeVMenus.Name = "treeVMenus";
            this.treeVMenus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.treeVMenus.RightToLeftLayout = true;
            this.treeVMenus.Size = new System.Drawing.Size(324, 401);
            this.treeVMenus.TabIndex = 0;
            this.treeVMenus.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeVMenus_AfterSelect);
            // 
            // btnAddNode
            // 
            this.btnAddNode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddNode.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddNode.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAddNode.FlatAppearance.BorderSize = 0;
            this.btnAddNode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNode.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNode.Image")));
            this.btnAddNode.Location = new System.Drawing.Point(652, 419);
            this.btnAddNode.Name = "btnAddNode";
            this.btnAddNode.Size = new System.Drawing.Size(48, 49);
            this.btnAddNode.TabIndex = 1;
            this.btnAddNode.UseVisualStyleBackColor = false;
            this.btnAddNode.Click += new System.EventHandler(this.btnAddNode_Click);
            // 
            // btnDeleteNode
            // 
            this.btnDeleteNode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteNode.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteNode.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnDeleteNode.FlatAppearance.BorderSize = 0;
            this.btnDeleteNode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNode.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteNode.Image")));
            this.btnDeleteNode.Location = new System.Drawing.Point(551, 419);
            this.btnDeleteNode.Name = "btnDeleteNode";
            this.btnDeleteNode.Size = new System.Drawing.Size(48, 49);
            this.btnDeleteNode.TabIndex = 2;
            this.btnDeleteNode.UseVisualStyleBackColor = false;
            this.btnDeleteNode.Click += new System.EventHandler(this.btnDeleteNode_Click);
            // 
            // txtOBJECT_NAME_AR
            // 
            this.txtOBJECT_NAME_AR.Location = new System.Drawing.Point(16, 41);
            this.txtOBJECT_NAME_AR.Name = "txtOBJECT_NAME_AR";
            this.txtOBJECT_NAME_AR.Size = new System.Drawing.Size(276, 20);
            this.txtOBJECT_NAME_AR.TabIndex = 3;
            this.txtOBJECT_NAME_AR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOBJECT_NAME_AR
            // 
            this.lblOBJECT_NAME_AR.AutoSize = true;
            this.lblOBJECT_NAME_AR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOBJECT_NAME_AR.Location = new System.Drawing.Point(421, 40);
            this.lblOBJECT_NAME_AR.Name = "lblOBJECT_NAME_AR";
            this.lblOBJECT_NAME_AR.Size = new System.Drawing.Size(34, 18);
            this.lblOBJECT_NAME_AR.TabIndex = 4;
            this.lblOBJECT_NAME_AR.Text = "الاسم";
            // 
            // lblPARNT_OBJECT
            // 
            this.lblPARNT_OBJECT.AutoSize = true;
            this.lblPARNT_OBJECT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPARNT_OBJECT.Location = new System.Drawing.Point(369, 186);
            this.lblPARNT_OBJECT.Name = "lblPARNT_OBJECT";
            this.lblPARNT_OBJECT.Size = new System.Drawing.Size(86, 18);
            this.lblPARNT_OBJECT.TabIndex = 6;
            this.lblPARNT_OBJECT.Text = "المستوى الأعلى";
            // 
            // txtPARNT_OBJECT
            // 
            this.txtPARNT_OBJECT.Enabled = false;
            this.txtPARNT_OBJECT.Location = new System.Drawing.Point(16, 187);
            this.txtPARNT_OBJECT.Name = "txtPARNT_OBJECT";
            this.txtPARNT_OBJECT.Size = new System.Drawing.Size(276, 20);
            this.txtPARNT_OBJECT.TabIndex = 6;
            this.txtPARNT_OBJECT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOBJECT_TYPE
            // 
            this.lblOBJECT_TYPE.AutoSize = true;
            this.lblOBJECT_TYPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOBJECT_TYPE.Location = new System.Drawing.Point(400, 137);
            this.lblOBJECT_TYPE.Name = "lblOBJECT_TYPE";
            this.lblOBJECT_TYPE.Size = new System.Drawing.Size(55, 18);
            this.lblOBJECT_TYPE.TabIndex = 8;
            this.lblOBJECT_TYPE.Text = "نوع الأمر";
            // 
            // lblOBJECT_COMMAND
            // 
            this.lblOBJECT_COMMAND.AutoSize = true;
            this.lblOBJECT_COMMAND.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOBJECT_COMMAND.Location = new System.Drawing.Point(421, 90);
            this.lblOBJECT_COMMAND.Name = "lblOBJECT_COMMAND";
            this.lblOBJECT_COMMAND.Size = new System.Drawing.Size(33, 18);
            this.lblOBJECT_COMMAND.TabIndex = 10;
            this.lblOBJECT_COMMAND.Text = "الأمر";
            // 
            // txtOBJECT_COMMAND
            // 
            this.txtOBJECT_COMMAND.Location = new System.Drawing.Point(16, 91);
            this.txtOBJECT_COMMAND.Name = "txtOBJECT_COMMAND";
            this.txtOBJECT_COMMAND.Size = new System.Drawing.Size(276, 20);
            this.txtOBJECT_COMMAND.TabIndex = 4;
            this.txtOBJECT_COMMAND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkbxSHOWTOOLBAR
            // 
            this.chkbxSHOWTOOLBAR.AutoSize = true;
            this.chkbxSHOWTOOLBAR.Location = new System.Drawing.Point(274, 241);
            this.chkbxSHOWTOOLBAR.Name = "chkbxSHOWTOOLBAR";
            this.chkbxSHOWTOOLBAR.Size = new System.Drawing.Size(15, 14);
            this.chkbxSHOWTOOLBAR.TabIndex = 7;
            this.chkbxSHOWTOOLBAR.UseVisualStyleBackColor = true;
            // 
            // lblSHOWTOOLBAR
            // 
            this.lblSHOWTOOLBAR.AutoSize = true;
            this.lblSHOWTOOLBAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSHOWTOOLBAR.Location = new System.Drawing.Point(300, 235);
            this.lblSHOWTOOLBAR.Name = "lblSHOWTOOLBAR";
            this.lblSHOWTOOLBAR.Size = new System.Drawing.Size(155, 18);
            this.lblSHOWTOOLBAR.TabIndex = 12;
            this.lblSHOWTOOLBAR.Text = "إظهار في شريط الاختصارات";
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(230, 401);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 53);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(59, 401);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 53);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "تراجع";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblMenuImage
            // 
            this.lblMenuImage.AutoSize = true;
            this.lblMenuImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuImage.Location = new System.Drawing.Point(381, 284);
            this.lblMenuImage.Name = "lblMenuImage";
            this.lblMenuImage.Size = new System.Drawing.Size(74, 18);
            this.lblMenuImage.TabIndex = 16;
            this.lblMenuImage.Text = "صورة القائمة";
            // 
            // lblShortcutImage
            // 
            this.lblShortcutImage.AutoSize = true;
            this.lblShortcutImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShortcutImage.Location = new System.Drawing.Point(316, 333);
            this.lblShortcutImage.Name = "lblShortcutImage";
            this.lblShortcutImage.Size = new System.Drawing.Size(139, 18);
            this.lblShortcutImage.TabIndex = 17;
            this.lblShortcutImage.Text = "صورة شريط الاختصارات";
            // 
            // cmbMenuIcon
            // 
            this.cmbMenuIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenuIcon.FormattingEnabled = true;
            this.cmbMenuIcon.Location = new System.Drawing.Point(59, 280);
            this.cmbMenuIcon.Name = "cmbMenuIcon";
            this.cmbMenuIcon.Size = new System.Drawing.Size(233, 21);
            this.cmbMenuIcon.TabIndex = 8;
            // 
            // cmbShortcutIcon
            // 
            this.cmbShortcutIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShortcutIcon.FormattingEnabled = true;
            this.cmbShortcutIcon.Location = new System.Drawing.Point(59, 334);
            this.cmbShortcutIcon.Name = "cmbShortcutIcon";
            this.cmbShortcutIcon.Size = new System.Drawing.Size(233, 21);
            this.cmbShortcutIcon.TabIndex = 10;
            // 
            // cmbOBJECT_TYPE
            // 
            this.cmbOBJECT_TYPE.AllowDrop = true;
            this.cmbOBJECT_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOBJECT_TYPE.FormattingEnabled = true;
            this.cmbOBJECT_TYPE.Location = new System.Drawing.Point(16, 138);
            this.cmbOBJECT_TYPE.Name = "cmbOBJECT_TYPE";
            this.cmbOBJECT_TYPE.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbOBJECT_TYPE.Size = new System.Drawing.Size(276, 21);
            this.cmbOBJECT_TYPE.TabIndex = 5;
            // 
            // btnRemoveMImage
            // 
            this.btnRemoveMImage.FlatAppearance.BorderSize = 0;
            this.btnRemoveMImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveMImage.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveMImage.Image")));
            this.btnRemoveMImage.Location = new System.Drawing.Point(12, 275);
            this.btnRemoveMImage.Name = "btnRemoveMImage";
            this.btnRemoveMImage.Size = new System.Drawing.Size(41, 33);
            this.btnRemoveMImage.TabIndex = 9;
            this.btnRemoveMImage.UseVisualStyleBackColor = true;
            this.btnRemoveMImage.Click += new System.EventHandler(this.btnRemoveMImage_Click);
            // 
            // btnRemoveTImage
            // 
            this.btnRemoveTImage.FlatAppearance.BorderSize = 0;
            this.btnRemoveTImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTImage.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveTImage.Image")));
            this.btnRemoveTImage.Location = new System.Drawing.Point(12, 329);
            this.btnRemoveTImage.Name = "btnRemoveTImage";
            this.btnRemoveTImage.Size = new System.Drawing.Size(41, 36);
            this.btnRemoveTImage.TabIndex = 11;
            this.btnRemoveTImage.UseVisualStyleBackColor = true;
            // 
            // frmManageMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 472);
            this.Controls.Add(this.btnRemoveTImage);
            this.Controls.Add(this.btnRemoveMImage);
            this.Controls.Add(this.cmbOBJECT_TYPE);
            this.Controls.Add(this.cmbShortcutIcon);
            this.Controls.Add(this.cmbMenuIcon);
            this.Controls.Add(this.lblShortcutImage);
            this.Controls.Add(this.lblMenuImage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSHOWTOOLBAR);
            this.Controls.Add(this.chkbxSHOWTOOLBAR);
            this.Controls.Add(this.lblOBJECT_COMMAND);
            this.Controls.Add(this.txtOBJECT_COMMAND);
            this.Controls.Add(this.lblOBJECT_TYPE);
            this.Controls.Add(this.lblPARNT_OBJECT);
            this.Controls.Add(this.txtPARNT_OBJECT);
            this.Controls.Add(this.lblOBJECT_NAME_AR);
            this.Controls.Add(this.txtOBJECT_NAME_AR);
            this.Controls.Add(this.btnDeleteNode);
            this.Controls.Add(this.btnAddNode);
            this.Controls.Add(this.treeVMenus);
            this.Name = "frmManageMenus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة إدارة القوائم";
            this.Load += new System.EventHandler(this.frmManageMenus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeVMenus;
        private System.Windows.Forms.Button btnAddNode;
        private System.Windows.Forms.Button btnDeleteNode;
        private System.Windows.Forms.TextBox txtOBJECT_NAME_AR;
        private System.Windows.Forms.Label lblOBJECT_NAME_AR;
        private System.Windows.Forms.Label lblPARNT_OBJECT;
        private System.Windows.Forms.TextBox txtPARNT_OBJECT;
        private System.Windows.Forms.Label lblOBJECT_TYPE;
        private System.Windows.Forms.Label lblOBJECT_COMMAND;
        private System.Windows.Forms.TextBox txtOBJECT_COMMAND;
        private System.Windows.Forms.CheckBox chkbxSHOWTOOLBAR;
        private System.Windows.Forms.Label lblSHOWTOOLBAR;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblMenuImage;
        private System.Windows.Forms.Label lblShortcutImage;
        private System.Windows.Forms.ComboBox cmbMenuIcon;
        private System.Windows.Forms.ComboBox cmbShortcutIcon;
        private System.Windows.Forms.ComboBox cmbOBJECT_TYPE;
        private System.Windows.Forms.Button btnRemoveMImage;
        private System.Windows.Forms.Button btnRemoveTImage;
    }
}