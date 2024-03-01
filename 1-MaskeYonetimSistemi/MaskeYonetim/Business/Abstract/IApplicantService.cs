using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        //interface de sadece method imzası oluşturulur. Interface ler belli metod imzalarını barındırırlar.
        //birbirinin alternatifi olan sistemlerin farklıSS implementasyon yapmalarını sağlar.
        //interface ler newlenemez.
        void ApplyForMask(Person person);

        //İçerisinde verdiğimiz tipte bir listedir.
         List<Person> GetList();

         bool CheckPerson(Person person);
    }
}
