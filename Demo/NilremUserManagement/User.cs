using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace NilremUserManagement
{
    class User
    {

        public User()
        {
            this.Picture = NilremUserManagement.Properties.Resources.DefaultFace;
            this.Permissions = new PermissionsData();

        }

        public string UserId { get; set; }
        public string FullName { get; set; }
        public UserRole Role { get; set; }
        public Image Picture { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public PermissionsData Permissions {get; private set;}


        #region Nested Types
        public class Name
        {
            public string First{ get; set; }
            public string Middle { get; set; }
            public string Last { get; set; }
            public Image Picture { get; set; }

            public override string ToString()
            {
                return First + " " + Middle + " " + Last;
            }
        }

        public enum UserRole { Guest, Standard, Administrator, Spy };

        public class PermissionsData
        {
            public bool CompanyConfidential { get; set; }
            public bool PersonalData { get; set; }
            public bool Embezzle { get; set; }
        }
        #endregion
    }
}
