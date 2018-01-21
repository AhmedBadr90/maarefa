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
    public partial class frmRoles : Form
    {
        public frmRoles()
        {
            InitializeComponent();
        }
        #region Variables
        clsRoles objroles = new clsRoles();
        DataTable tblroles = new DataTable();
        #endregion

        #region Methods

        #endregion

        #region Events

        #endregion
        private void frmRoles_Load(object sender, EventArgs e)
        {
          tblroles=  objroles.GetRoles();
            Gview.DataSource = tblroles;
            ColRoleId.DataPropertyName = "ROLE_ID";
            ColRoleName.DataPropertyName = "ROLE_NAME_AR";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
