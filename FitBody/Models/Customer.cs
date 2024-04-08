using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBody.Models
{
    public class Customer:User
    {
        private int _age;
        private string _gender;
        private int _height;
        private int _weight;
        //private bool _isPremium;
        //private Routine _userRoutine;

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

        //public Routine UserRoutine
        //{
        //    get { return _routine; }
        //    set { _routine = value; }
        //}

        public Customer(string userName, string name, string email, string password)
        {
            Username = userName;
            Name = name;
            Email = email;
            Password = password;
        }

        public override string ToString()
        {
            return $"Username: {Username}, Name: {Name}, Email: {Email}, Age: {Age}, Gender: {Gender}, Height: {Height}, Weight: {Weight}";
        }
    }
}

