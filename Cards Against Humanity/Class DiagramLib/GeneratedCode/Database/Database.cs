﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Server.Database
{
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Client;

    public class Database : DBManager
	{
        public string DBName
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        private string IP
		{
			get;
			set;
		}

		private string Password
		{
			get;
			set;
		}

		private string Username
		{
			get;
			set;
		}

        public int checkUserLogin(ClientUser User)
        {
            throw new NotImplementedException();
        }

        public List<ClientUser> loadUsers()
        {
            throw new NotImplementedException();
        }

        public int registerUser(ClientUser User)
        {
            throw new NotImplementedException();
        }
    }
}

