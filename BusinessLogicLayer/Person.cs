using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milestoneTwo.BusinessLogicLayer
{
    internal class Person
    {
        private string name, surname, gender, phone, address, moduleCodes;
        private DateTime dateOfBirth;
        private int studentNumber;

        public string ImagePath { get; set; }


        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string ModuleCodes { get => moduleCodes; set => moduleCodes = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public int StudentNumber { get => studentNumber; set => studentNumber = value; }
       

        public Person(int studentNumber, string name, string surname, DateTime dateOfBirth, string gender, string phone, string address, string moduleCodes)
        {
            this.name = name;
            this.surname = surname;
            this.gender = gender;
            this.phone = phone;
            this.address = address;
            this.moduleCodes = moduleCodes;
            this.dateOfBirth = dateOfBirth;
            this.studentNumber = studentNumber;
          
        }
    }
}
