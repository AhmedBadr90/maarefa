using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maarefa.General.Classes
{
    class clsRole:DBHandlerSqlServer
    {
        #region Variables

        int roleID;
        string roleName_AR;
        string roleName_En;
        int createUser;
        string createPC;
        int lUpdateUser;
        string lUpdatePC;
        int transStatus;
        int recordStatus;

        #endregion

        #region Properties
        public int RoleID
        {
            get { return roleID; }
            set { roleID = value; }
        }

        public string RoleName_AR
        {
            get { return roleName_AR; }
            set { roleName_AR = value; }
        }

        public string RoleName_En
        {
            get { return roleName_En; }
            set { roleName_En = value; }
        }

        public int CreateUser
        {
            get { return createUser; }
            set { createUser = value; }
        }

        public string CreatePC
        {
            get { return createPC; }
            set { createPC = value; }
        }

        public int LUpdateUser
        {
            get { return lUpdateUser; }
            set { lUpdateUser = value; }
        }

        public string LUpdatePC
        {
            get { return lUpdatePC; }
            set { lUpdatePC = value; }
        }

        public int TransStatus
        {
            get { return transStatus; }
            set { transStatus = value; }
        }

        public int RecordStatus
        {
            get { return recordStatus; }
            set { recordStatus = value; }
        }
        #endregion

        #region Functions
        public DataTable getRoles()
        {
            try
            {
                return GetDataTable("spGetRoles");
            }
            catch (Exception)
            {

                throw;
            }


        }
        #endregion
    }
}
