using System;
namespace ConsoleApp
{
    class Person
    {
        public string Name;
        public string Surname;
        protected string _email;
        private string _password;
        private int _age;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 99)
                {
                    Console.WriteLine("Gopa basma");
                }
                else
                {

                    _age = value;
                }
            }
        }

        public string getFullInfo()
        {
            return $"{Name} {Surname} {_age}";
        }
        //encapsulation
        public void setEmail(string mail)
        {
            if (mail.Contains("@"))
            {
                _email = mail;
            }
            else
            {
                Console.WriteLine("Duzgun email daxil edin");
            }
        }

        public string getEmail() => _email;

        public void setPassword(string pass)
        {
            _password = HashPassword(pass);
        }

        public bool CheckPassword(string password)
        {
            if (HashPassword(password) == _password)
            {
                return true;
            }
            return false;
        }

        private string HashPassword(string pass)
        {
            return pass + "123";
        }
    }

    class Developer : Person
    {
        public void TestMethod()
        {
            Console.WriteLine(_email);
        }
    }
}
