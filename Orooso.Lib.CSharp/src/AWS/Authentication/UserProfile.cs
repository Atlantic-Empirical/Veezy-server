using System;

namespace Orooso.Lib.Authentication
{
    public class UserProfile
    {
        public string UserName { get; set; }
        public string ApplicationName { get; set; }
        public bool IsAnonymous { get; set; }
        public DateTime LastActivityDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}