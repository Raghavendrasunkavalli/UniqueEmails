using System;
using System.Linq;
using System.Collections.Generic;

namespace UniqueEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> emails = new List<string>();
            emails.Add("dis.email+bull@usf.com");
            emails.Add("dis.e.mail+bob.cathy@usf.com");
            emails.Add("disemail+david@us.f.com");
            int ans5 = UniqueEmails(emails);
            Console.WriteLine("Q5");
            Console.WriteLine("The number of unique emails is " + ans5);
        }
        private static int UniqueEmails(List<string> emails)
        {
            int count = 0;
            try
            {
                for (int x = 0; x < emails.Count; x++)
                {
                    int i = emails[x].IndexOf("@");
                    String local = emails[x].Substring(0, i);
                    String domain = emails[x].Substring(i);
                    if (local.Contains("+"))
                    {
                        local = local.Substring(0, local.IndexOf('+'));
                    }

                    local = local.Replace(".", "");
                    emails[x] = local + domain;
                    count = emails.Distinct().Count();

                }

                return count;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

    }
}

            

