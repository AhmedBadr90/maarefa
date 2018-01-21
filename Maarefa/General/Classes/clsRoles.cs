using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace maarefa.General.Classes
{
    class clsRoles:DBHandlerSqlServer
    {
        #region Variables
        string _RoleName;

        #endregion
        #region Properities
        public  string RoleName
        {
            get { return _RoleName; }
            set { _RoleName = value; }
        }

        #endregion

        #region Methods
        public DataTable GetRoles()
        {
            try
            {
                return GetDataTable("spRoles_Getdata");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void InsertRole()
        {
            try
            {
                 ExecuteCommandWithoutTransaction("spRoles_Insert", "@ROLE_NAME_AR", _RoleName,
                                                                    "@CREATE_USER",Globalclass.UserID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion



    }
}
