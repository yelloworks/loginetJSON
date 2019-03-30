using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace loginetJSON.Helper
{
    public static class Splitter
    {
        public static string GetUsername(string email)
        {
            return GetItemByPosition(email, 0);
        }

        public static string GetDomain(string email)
        {
            return GetItemByPosition(email, 1);
        }

        private static string GetItemByPosition(string email, int posotion)
        {
            return email.Split('@')[posotion];
        }
    }
}