namespace maarefa
{
    partial class frmRoles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoles));
            this.Gview = new System.Windows.Forms.DataGridView();
            this.ColRoleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Gview)).BeginInit();
            this.SuspendLayout();
            // 
            // Gview
            // 
            this.Gview.AllowUserToAddRows = false;
            this.Gview.AllowUserToDeleteRows = false;
            this.Gview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gview.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Gview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColRoleId,
            this.ColRoleName,
            this.ColEdit,
            this.ColDelete});
            this.Gview.Location = new System.Drawing.Point(12, 78);
            this.Gview.MultiSelect = false;
            this.Gview.Name = "Gview";
            this.Gview.ReadOnly = true;
            this.Gview.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Gview.Size = new System.Drawing.Size(646, 386);
            this.Gview.TabIndex = 0;
            // 
            // ColRoleId
            // 
            this.ColRoleId.HeaderText = "مسلسل";
            this.ColRoleId.Name = "ColRoleId";
            this.ColRoleId.ReadOnly = true;
            // 
            // ColRoleName
            // 
            this.ColRoleName.HeaderText = "مجموعة";
            this.ColRoleName.Name = "ColRoleName";
            this.ColRoleName.ReadOnly = true;
            this.ColRoleName.Width = 300;
            // 
            // ColEdit
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "تعديل";
            this.ColEdit.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColEdit.HeaderText = "تعديل";
            this.ColEdit.Name = "ColEdit";
            this.ColEdit.ReadOnly = true;
            this.ColEdit.Text = "تعديل";
            // 
            // ColDelete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "حذف";
            this.ColDelete.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColDelete.HeaderText = "حذف";
            this.ColDelete.Name = "ColDelete";
            this.ColDelete.ReadOnly = true;
            this.ColDelete.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(599, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 49);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 476);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Gview);
            this.Name = "frmRoles";
            this.Text = "frmRoles";
            this.Load += new System.EventHandler(this.frmRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Gview;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRoleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRoleName;
        private System.Windows.Forms.DataGridViewButtonColumn ColEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColDelete;
        private System.Windows.Forms.Button btnAdd;
    }
}