using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MySQL_CRUD_Forms
{
    class Validation
    {
        public static bool GetEmail(string emailString, string control)
        {
            // Check this pattern to ensure the email is valid.
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);

            if(regex.IsMatch(emailString))
            {
                return true;
            }

            else
            {
                MessageBox.Show($"{control} must be valid.");
                return false;
            }
        }

        public static bool GetString(string testString, string control)
        {
            // Test each char and space for valid.
            if (String.IsNullOrWhiteSpace(testString))
            {
                MessageBox.Show($"{control} cannot be left blank.");
                return false;
            }
            
            foreach(char c in testString)
            {
               if(Char.IsDigit(c))
                {
                    MessageBox.Show($"{control} must not contain numbers.");
                    return false;
                }
            }

            return true;
        }

        public static bool GetPhoneNumber(string testString, string control)
        {
            // Test each char and space for valid.
            // The test for length is in form1.
            if (String.IsNullOrWhiteSpace(testString))
            {
                MessageBox.Show($"{control} cannot be left blank.");
                return false;
            }
            
            foreach (char c in testString)
            {
                if (!Char.IsDigit(c))
                {
                    MessageBox.Show($"{control} must only contain numbers.");
                    return false;
                }
            }

            return true;
        }
    }
}

