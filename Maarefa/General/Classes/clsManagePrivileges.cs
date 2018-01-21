﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net;
using System.Net.Sockets;

namespace maarefa.General.Classes
{
    class clsManagePrivileges : DBHandlerSqlServer
    {
        #region Variables
        string _ObjectNameAR, _OBJECTCOMMAND, _OBJECTPRIVILEGE, _CREATEPC = GetLocalIPAddress(), _LUPDATEPC = GetLocalIPAddress();
        int _OBJECTID, _ROLEID, _OBJECTTYPE, _PARNTOBJECT, _SHOWTOOLBAR, _MENUICON, _TOOLBARICON, _CREATEUSER = 1, _LUPDATEUSER = 1, _TRANSSTATUS = 0;// _RECORDSTATUS = 0
        DateTime _CREATETIMESTAMP = DateTime.Now,_LUPDATETIMESTAMP = DateTime.Now;
        #endregion

        #region Properties

        public string ObjectNameAR
        {
            get { return _ObjectNameAR; }
            set { _ObjectNameAR = value; }
        }
        public string OBJECTCOMMAND
        {
            get { return _OBJECTCOMMAND; }
            set { _OBJECTCOMMAND = value; }
        }

        public string OBJECTPRIVILEGE
        {
            get { return _OBJECTPRIVILEGE; }
            set { _OBJECTPRIVILEGE = value; }
        }

        //public string CREATEPC
        //{
        //    get { return _CREATEPC; }
        //    set { _CREATEPC = value; }
        //}
        //public DateTime CREATETIMESTAMP
        //{
        //    get { return _CREATETIMESTAMP; }
        //    set { _CREATETIMESTAMP = value; }
        //}
        //public int TRANSSTATUS
        //{
        //    get { return _TRANSSTATUS; }
        //    set { _TRANSSTATUS = value; }
        //}
        //public int RECORDSTATUS
        //{
        //    get { return _RECORDSTATUS; }
        //    set { _RECORDSTATUS = value; }
        //}
        public int OBJECTID
        {
            get { return _OBJECTID; }
            set { _OBJECTID = value; }
        }
        public int OBJECTTYPE
        {
            get { return _OBJECTTYPE; }
            set { _OBJECTTYPE = value; }
        }

        public int ROLEID
        {
            get { return _ROLEID; }
            set { _ROLEID = value; }
        }
        
        public int PARNTOBJECT
        {
            get { return _PARNTOBJECT; }
            set { _PARNTOBJECT = value; }
        }
        public int SHOWTOOLBAR
        {
            get { return _SHOWTOOLBAR; }
            set { _SHOWTOOLBAR = value; }
        }
        public int MENUICON
        {
            get { return _MENUICON; }
            set { _MENUICON = value; }
        }
        public int TOOLBARICON
        {
            get { return _TOOLBARICON; }
            set { _TOOLBARICON = value; }
        }
        //public int CREATEUSER
        //{
        //    get { return _CREATEUSER; }
        //    set { _CREATEUSER = value; }
        //}

        #endregion


        #region Methods
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }
        public DataTable GetRoles()
        {
            return GetDataTable("spGetRoles");
            
        }
        public DataTable GetMenuObjects()
        {
            return GetDataTable("spGetObjects");
        }
        public DataTable GetPrivilege()
        {
            return GetDataTable("spGetPrivilege", "@OBJECTID", _OBJECTID, "@ROLEID", _ROLEID);

        }
        public void InsertObjectPrivilege()
        {
            ExecuteCommandWithoutTransaction("spInsertObjectPrivilege", "@OBJECTID", _OBJECTID, "@ROLEID", _ROLEID, "@OBJECTPRIVILEGE", _OBJECTPRIVILEGE, "@CREATEUSER", _CREATEUSER, "@CREATEPC", _CREATEPC, "@CREATETIMESTAMP", _CREATETIMESTAMP, "@TRANSSTATUS", _TRANSSTATUS, "@RECORDSTATUS", 0);

        }
        public void UpdateObjectPrivilege()
        {
            ExecuteCommandWithoutTransaction("spUpdateObjectPrivilege", "@OBJECTID", _OBJECTID, "@ROLEID", _ROLEID, "@OBJECTPRIVILEGE", _OBJECTPRIVILEGE, "@LUPDATEUSER", _LUPDATEUSER, "@LUPDATEPC", _LUPDATEPC, "@LUPDATETIMESTAMP", _LUPDATETIMESTAMP, "@TRANSSTATUS", _TRANSSTATUS, "@RECORDSTATUS", 1);

        }

        #endregion

     
    }
}
