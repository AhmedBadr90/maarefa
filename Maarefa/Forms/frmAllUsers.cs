using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using maarefa.General.Classes;

namespace maarefa
{
    public partial class frmAllUsers : Form
    {
        #region Variables
        clsUser _clsUser;
        DataTable tbl;
        #endregion
        public frmAllUsers()
        {
            InitializeComponent();
        }

        #region Events
        private void frmAllUsers_Load(object sender, EventArgs e)
        {

            _clsUser = new clsUser();
            tbl = _clsUser.getAllUsers();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 6;

            if (tbl.Rows.Count > 0)
            {
                dataGridView1.Columns[0].Name = "USER_ID";
                dataGridView1.Columns[0].HeaderText = "USER_ID";
                dataGridView1.Columns[0].DataPropertyName = "USER_ID";

                dataGridView1.Columns[1].Name = "FULL_NAME_AR";
                dataGridView1.Columns[1].HeaderText = "الاسم";
                dataGridView1.Columns[1].DataPropertyName = "FULL_NAME_AR";

                dataGridView1.Columns[2].Name = "GENDER";
                dataGridView1.Columns[2].HeaderText = "النوع";
                dataGridView1.Columns[2].DataPropertyName = "GENDER";

                dataGridView1.Columns[3].Name = "ID_NO";
                dataGridView1.Columns[3].HeaderText = "الرقم القومي";
                dataGridView1.Columns[3].DataPropertyName = "ID_NO";

                dataGridView1.Columns[4].Name = "MOBILE";
                dataGridView1.Columns[4].HeaderText = "رقم الهاتف";
                dataGridView1.Columns[4].DataPropertyName = "MOBILE";

                dataGridView1.Columns[5].Name = "JOB_NAME";
                dataGridView1.Columns[5].HeaderText = "الوظيفة";
                dataGridView1.Columns[5].DataPropertyName = "JOB_NAME";


                DataGridViewLinkColumn dgvLinkEdit = new DataGridViewLinkColumn();
                dgvLinkEdit.UseColumnTextForLinkValue = true;
                dgvLinkEdit.LinkBehavior = LinkBehavior.SystemDefault;
                dgvLinkEdit.HeaderText = "تعديل";
                dgvLinkEdit.Name = "lnkUpdate";
                dgvLinkEdit.LinkColor = Color.Blue;
                dgvLinkEdit.TrackVisitedState = true;
                dgvLinkEdit.Text = "تعديل";
                dgvLinkEdit.UseColumnTextForLinkValue = true;
                dataGridView1.Columns.Add(dgvLinkEdit);

                DataGridViewLinkColumn dgvLinkDelete = new DataGridViewLinkColumn();
                dgvLinkDelete.UseColumnTextForLinkValue = true;
                dgvLinkDelete.LinkBehavior = LinkBehavior.SystemDefault;
                dgvLinkDelete.HeaderText = "حذف";
                dgvLinkDelete.Name = "lnkDelete";
                dgvLinkDelete.LinkColor = Color.Blue;
                dgvLinkDelete.TrackVisitedState = true;
                dgvLinkDelete.Text = "حذف";
                dgvLinkDelete.UseColumnTextForLinkValue = true;
                dataGridView1.Columns.Add(dgvLinkDelete);

            }
            dataGridView1.DataSource = tbl;
            dataGridView1.Columns[0].Visible = false;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmManageUser frm = new frmManageUser("add", 0);
            frm.Show();
            this.Hide();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _clsUser.UserID = int.Parse(dataGridView1["USER_ID", e.RowIndex].Value.ToString());

            if (e.ColumnIndex == 6)
            {
                EditUser();
            }
            else if (e.ColumnIndex == 7)
            {
                DeleteUser();
            }
        }
        #endregion

        #region Functions
        private void EditUser()
        {
            frmManageUser frm = new frmManageUser("edit", _clsUser.UserID);
            frm.Show();
            this.Hide();
        }

        private void DeleteUser()
        {
            DialogResult dialogResult = MessageBox.Show("هل انت متأكد من حذف هذا المستخدم؟", "حذف مستخدم", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _clsUser.deleteUser(_clsUser.UserID);
            }

        }
        #endregion


    }
}
