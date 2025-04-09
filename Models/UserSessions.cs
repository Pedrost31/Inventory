using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.Models
{
    public static class UserSession
    {
        public static int UserId { get; set; }
        public static string UserName { get; set; }
        public static string UserEmail { get; set; }
        public static string UserRole { get; set; }

        public static void Clear()
        {
            UserId = 0;
            UserName = string.Empty;
            UserEmail = string.Empty;
            UserRole = string.Empty;
        }
    }
}
