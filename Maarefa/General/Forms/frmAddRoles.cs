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
namespace maarefa.Forms
{
    public partial class frmAddRoles : Form
    {
        public frmAddRoles()
        {
            InitializeComponent();
        }

        #region Variables
        clsRoles ObjName = new clsRoles();
        #endregion
        private void btnSave_Click(object sender, EventArgs e)
        {
            ObjName.RoleName = txtRoleName.Text;
            
        }
    }
}
