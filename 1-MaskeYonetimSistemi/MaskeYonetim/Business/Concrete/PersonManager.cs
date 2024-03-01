using Business.Abstract;
using Entities.Concrete;
using MerniceServiceReference;
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
            //mernis kontrolü  yapılacak.
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);

            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest(
                    new TCKimlikNoDogrulaRequestBody(person.NationalIdentityNumber,person.FirstName,person.LastName,person.DateOfBirthYear)
                    )
                )
                .Result.Body.TCKimlikNoDogrulaResult;
        }

    }
}
