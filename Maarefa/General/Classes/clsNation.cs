using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maarefa.General.Classes
{
    class clsNation:DBHandlerSqlServer
    {
        #region Variables

        int nationID;
        string nationName_AR;
        string nationName_En;
        int createUser;
        string createPC;
        int lUpdateUser;
        string lUpdatePC;
        int transStatus;
        int recordStatus;

        #endregion

        #region Properties
        public int NationID
        {
            get { return nationID; }
            set { nationID = value; }
        }

        public string NationName_AR
        {
            get { return nationName_AR; }
            set { nationName_AR = value; }
        }

        public string NationName_En
        {
            get { return nationName_En; }
            set { nationName_En = value; }
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
        public DataTable getNations()
        {
            try
            {
                return GetDataTable("spGetNations");
            }
            catch (Exception)
            {

                throw;
            }


        }
        #endregion
    }
}
