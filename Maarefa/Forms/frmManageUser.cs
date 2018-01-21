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
    public partial class frmManageUser : Form
    {
        #region Variables
        clsUser _clsUser;
        clsNation _clsNation;
        clsRole _clsRole;
        DataTable tbl;
        int userID;
        string frmMode;
        #endregion
        public frmManageUser(string mode,int id)
        {
            _clsUser = new clsUser();
            InitializeComponent();
            if (mode == "add")
            {
                btnManage.Text = "إضافة";
                btnManage.Click += btnManage_Click_Add;
            }
            else if (mode == "edit")
            {
                btnManage.Text = "تعديل";
                userID = id;
                frmMode = mode;
                btnManage.Click += btnManage_Click_Edit;
                //ShowUserData(userID);
            }
        }

        private void ShowUserData(int userID)
        {
            tbl = _clsUser.getUserData(userID);
            if(tbl.Rows.Count>0)
            {

                txtName.Text = tbl.Rows[0]["FULL_NAME_AR"].ToString();
                txtUserName.Text = tbl.Rows[0]["USER_NAME"].ToString();
                txtPassword.Text = tbl.Rows[0]["PASSWORD"].ToString();
                if (tbl.Rows[0]["GENDER"].ToString() == "1")
                    rdMale.Checked = true;
                else if (tbl.Rows[0]["GENDER"].ToString() == "0")
                    rdFemale.Checked = true;
                txtNationalID.Text = tbl.Rows[0]["ID_NO"].ToString();
                cmbxNations.SelectedValue = tbl.Rows[0]["NATION_ID"];
                txtMobile.Text = tbl.Rows[0]["MOBILE"].ToString();
                txtEmail.Text = tbl.Rows[0]["EMAIL"].ToString();
                txtAddress.Text = tbl.Rows[0]["ADDRESS"].ToString();
                txtJob.Text = tbl.Rows[0]["JOB_NAME"].ToString();
                txtDiscount.Text = tbl.Rows[0]["DISCOUNT"].ToString();
                cmbxRoles.SelectedValue = tbl.Rows[0]["ROLE_ID"].ToString();
            }
        }

        #region Events
        private void btnManage_Click_Edit(object sender, EventArgs e)
        {
            try
            {

                _clsUser.UserID =userID;
                _clsUser.FullName = txtName.Text;
                _clsUser.UserName = txtUserName.Text;
                _clsUser.Password = txtPassword.Text;
                if (rdMale.Checked)
                    _clsUser.Gender = 1;
                else if (rdFemale.Checked)
                    _clsUser.Gender = 0;
                _clsUser.NationalID = int.Parse(txtNationalID.Text);
                _clsUser.NationID = int.Parse(cmbxNations.SelectedValue.ToString());
                _clsUser.Mobile = txtMobile.Text;
                _clsUser.Email = txtEmail.Text;
                _clsUser.Address = txtAddress.Text;
                _clsUser.JobName = txtJob.Text;
                _clsUser.Discount = int.Parse(txtDiscount.Text);
                _clsUser.RoleID = int.Parse(cmbxRoles.SelectedValue.ToString());
                _clsUser.LUpdateUser = Globalclass.UserID;
                _clsUser.LUpdatePC = Globalclass.PC_IP;
                _clsUser.editUser(_clsUser);
            }
            catch (Exception ex)
            {

                MessageBox.Show("نأسف لقد حدث خطأ ولم يتم التعديل" + ex.Message);
            }
        }

        private void btnManage_Click_Add(object sender, EventArgs e)
        {
            try
            {
                _clsUser = new clsUser();
                _clsUser.FullName = txtName.Text;
                _clsUser.UserName = txtUserName.Text;
                _clsUser.Password = txtPassword.Text;
                if (rdMale.Checked)
                    _clsUser.Gender = 1;
                else if (rdFemale.Checked)
                    _clsUser.Gender = 0;
                _clsUser.NationalID = int.Parse(txtNationalID.Text);
                _clsUser.NationID = int.Parse(cmbxNations.SelectedValue.ToString());
                _clsUser.Mobile = txtMobile.Text;
                _clsUser.Email = txtEmail.Text;
                _clsUser.Address = txtAddress.Text;
                _clsUser.JobName = txtJob.Text;
                _clsUser.Discount = int.Parse(txtDiscount.Text);
                _clsUser.RoleID = int.Parse(cmbxRoles.SelectedValue.ToString());
                _clsUser.CreateUser = Globalclass.UserID;
                _clsUser.CreatePC = Globalclass.PC_IP;
                _clsUser.LUpdateUser = Globalclass.UserID;
                _clsUser.LUpdatePC = Globalclass.PC_IP;
                _clsUser.addUser(_clsUser);
            }
            catch (Exception ex)
            {

                MessageBox.Show("نأسف لقد حدث خطأ ولم تتم الإضافة" + ex.Message);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmAllUsers frm = new frmAllUsers();
            frm.Show();
            this.Hide();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {

        }

        private void frmManageUser_Load(object sender, EventArgs e)
        {
            #region Load Nations
            _clsNation = new clsNation();
            cmbxNations.DataSource = _clsNation.getNations();
            cmbxNations.ValueMember = "NATION_ID";
            cmbxNations.DisplayMember = "NATION_NAME_AR";
            cmbxNations.SelectedIndex = -1;
            #endregion

            #region Load Roles
            _clsRole = new clsRole();
            cmbxRoles.DataSource = _clsRole.getRoles();
            cmbxRoles.ValueMember = "ROLE_ID";
            cmbxRoles.DisplayMember = "ROLE_NAME_AR";
            cmbxRoles.SelectedIndex = -1;
            #endregion

            txtName.Focus();
            if (frmMode=="edit")
            {
                ShowUserData(userID);
            }

        }
        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
