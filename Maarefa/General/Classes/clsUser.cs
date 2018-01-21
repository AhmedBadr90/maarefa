using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maarefa.General.Classes
{
    public class clsUser : DBHandlerSqlServer
    {
        #region Variables
        int userID;
        string fullName;
        string userName;
        string password;
        int gender;
        int nationID;
        int nationalID;
        string mobile;
        string address;
        string email;
        string jobName;
        int discount;
        int roleID;
        int status;
        int createUser;
        string createPC;
        DateTime createTimeStamp;
        int lUpdateUser;
        string lUpdatePC;
        DateTime lUpdateTimeStamp;
        int transStatus;
        int recordStatus;
        int branchID;
        #endregion

        #region Properties

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public int NationID
        {
            get { return nationID; }
            set { nationID = value; }
        }

        public int NationalID
        {
            get { return nationalID; }
            set { nationalID = value; }
        }

        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string JobName
        {
            get { return jobName; }
            set { jobName = value; }
        }

        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        public int RoleID
        {
            get { return roleID; }
            set { roleID = value; }
        }

        public int Status
        {
            get { return status; }
            set { status = value; }
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

        public DateTime CreateTimeStamp
        {
            get { return createTimeStamp; }
            set { createTimeStamp = value; }
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


        public DateTime LUpdateTimeStamp
        {
            get { return lUpdateTimeStamp; }
            set { lUpdateTimeStamp = value; }
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
        public int BranchID
        {
            get { return branchID; }
            set { branchID = value; }
        }
        #endregion

        #region Methods

        public DataTable checkUserCredentials(clsUser user)
        {
            try
            {
                return GetDataTable("spCheckUserCredentials", "@UserName", user.UserName, "@Password", user.Password, "@BranchID", user.BranchID);
            }
            catch (Exception)
            {

                MessageBox.Show("نأسف لقد حدث خطأ");
                return new DataTable();
            }
        }

        public DataTable checkUserNameISExisting(string userName)
        {
            try
            {
                return GetDataTable("spCheckUserNameIsExisting", "@UserName", userName);
            }
            catch (Exception)
            {

                MessageBox.Show("نأسف لقد حدث خطأ");
                return new DataTable();
            }
        }

        public DataTable getAllUsers()
        {
            try
            {
                return GetDataTable("spGetAllUsers");
            }
            catch (Exception ex)
            {

                MessageBox.Show("نأسف لقد حدث خطأ" + ex.Message);
                return new DataTable();
            }
        }

        public DataTable getUserData(int id)
        {
            try
            {
                return GetDataTable("spGetUserData","@userID",id);
            }
            catch (Exception ex)
            {

                MessageBox.Show("نأسف لقد حدث خطأ\n" + ex.Message);
                return new DataTable();
            }
        }

        public void addUser(clsUser user)
        {
            try
            {
                ExecuteCommandWithoutTransaction("spAddUser", "@userName", user.UserName,
                                             "@password", user.Password,
                                             "@full_NAME_AR", user.FullName,
                                             "@gender", user.Gender,
                                             "@ID_No", user.NationalID,
                                             "@nationID", user.NationID,
                                             "@mobile", user.Mobile,
                                             "@address", user.Address,
                                             "@email", user.Email,
                                             "@jobName", user.JobName,
                                             "@discount", user.Discount,
                                             "@roleID", user.RoleID,
                                             //"@status", user.Status,
                                             "@create_User", user.CreateUser,
                                             "@create_PC", user.CreatePC,
                                             "@create_TIMESTAMP", user.CreateTimeStamp,
                                             "@lUpdate_User", user.LUpdateUser,
                                             "@lUpdate_PC", user.LUpdatePC,
                                             "@lUpdate_TIMESTAMP", user.LUpdateTimeStamp,
                                             "@BranchID", user.BranchID);

            }
            catch (Exception ex)
            {

                MessageBox.Show("نأسف لقد حدث خطأ\n" + ex.Message);
            }
        }

        public void editUser(clsUser user)
        {
            try
            {
                ExecuteCommandWithoutTransaction("spEditUser", "@userID", user.UserID,
                                             "@userName", user.UserName,
                                             "@password", user.Password,
                                             "@full_NAME_AR", user.FullName,
                                             "@gender", user.Gender,
                                             "@ID_No", user.NationalID,
                                             "@nationID", user.NationID,
                                             "@mobile", user.Mobile,
                                             "@address", user.Address,
                                             "@email", user.Email,
                                             "@jobName", user.JobName,
                                             "@discount", user.Discount,
                                             "@roleID", user.RoleID,
                                             "@status", user.Status,
                                             "@lUpdate_User", user.LUpdateUser,
                                             "@lUpdate_PC", user.LUpdatePC,
                                             "@lUpdate_TIMESTAMP", user.LUpdateTimeStamp,
                                             "@BranchID", user.BranchID);
            }
            catch (Exception ex)
            {

                MessageBox.Show("نأسف لقد حدث خطأ\n" + ex.Message);
            }
        }

        public void deleteUser(int ID)
        {
            try
            {
                ExecuteCommandWithoutTransaction("spDeleteUser", "@userID", ID);
            }
            catch (Exception ex)
            {

                MessageBox.Show("نأسف لقد حدث خطأ\n" + ex.Message);
            }
        }

        #endregion
    }
}
