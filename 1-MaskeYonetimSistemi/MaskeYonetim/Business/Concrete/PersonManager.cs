using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        //EĞER CLASS I PUBLIC YAPMAZSAK BAŞKA KATMANLARDA ERİŞEMEYİZ
        public void ApplyForMask(Person person)
        {

        }

        //İçerisinde verdiğimiz tipte bir listedir.
        public List<Person> GetList() 
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            return true;
        }

    }
}
