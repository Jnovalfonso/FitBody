using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBody.Models
{
    public abstract class User
    {
        private string _username;
        private string _name;
        private string _email;
        private string _password;
        private int _age;
        private string _gender;
        private int _height;
        private int _weight;
        //private bool _isPremium;
        //private Routine _userRoutine;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        //public bool IsPremium
        //{
        //    get { return _isPremium; }
        //    set { _isPremium = value; }
        //}

        //public Routine UserRoutine
        //{
        //    get { return _routine; }
        //    set { _routine = value; }
        //}
    }
}
