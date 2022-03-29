using System;
namespace static_task.Models
{
    internal class User : IAccount
    {
        public static int id { get; set; }
        public string fullname { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        

        public User(string fullname, string email, string password)
        {
            this.fullname = fullname;
            this.email = email;
            this.password = password;


        }

        public string PasswordChecker(string password)

        {
            bool result;
            
                foreach (var item in password)
                {
                    if (password.Length >= 8 && char.IsUpper(item) && char.IsLower(item) && char.IsNumber(item))
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }

                }

            
            return password;


        }



        public void ShowInfo()
        {
            Console.WriteLine($"Id: {id} \n" +
                $"email: {email} /n" +
                $"fullname: {fullname}");
        }
        public User()
        {
            id++;
        }
    }
}
