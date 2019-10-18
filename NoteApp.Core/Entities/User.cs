﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Linq;

namespace NoteApp.Core.Entities
{
    class User : BaseEntity
    {
        readonly static byte[] secretBytes = Encoding.ASCII.GetBytes("NOTEAPP_SECRET");
        private string userName;
        private string password;

        public User(string userName, string password)
        {
            this.userName = userName;
            this.password = GetHash(userName, password);
        }

        private User()
        {

        }

        public static string GetHash(string userName, string password)
        {
            using (var algorithm = SHA256.Create())
            {


                var passwordBytes = Encoding.ASCII.GetBytes(password);
                var userNameBytes = Encoding.ASCII.GetBytes(userName);
                var totalBytes = passwordBytes.Concat(userNameBytes).Concat(secretBytes).ToArray();
                var hash = algorithm.ComputeHash(totalBytes);
                return Encoding.ASCII.GetString(hash);
            }
        }

        public string UserName {
            get
            {
                return userName;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
        }
    }
}
