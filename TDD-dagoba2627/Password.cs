using System;
using System.Collections.Generic;
using System.Text;

namespace TDD_dagoba2627
{
    public class Password
    {
        public static bool CheckPassword(string? password)
        {
            if (String.IsNullOrEmpty(password))
            {
                return false;
            }
            if (password.Length < 8)
            {
                return false;
            }

            return password.Contains("#");
        }
    }
}
