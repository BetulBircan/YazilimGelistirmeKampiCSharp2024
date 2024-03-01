using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager
    {
        //Dependency Injecion
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService) //constructor-sınıf oluştuüunda newlendiğinde çalışır
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            //PersonManager personManager = new PersonManager(); komple bağımlı hale gelir o yüzden kullanılmaz.

            if(_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " " + "için maske verildi");

            }
        }
    }
}
