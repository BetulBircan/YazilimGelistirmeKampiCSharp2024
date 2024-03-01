# Maske Yönetim Sistemi
Bu proje maske yönetim sistemi yapmak için oluşturuldu
- WorkAround(Class Library)

  Burada değişkenler, method vs temel konular burada işlendi.(Program.cs)

- Entities(Class Library)

  Person gibi özellik içeren sınıflar burada oluşturuldu.

- Business (Class Library)

  Abstract ve Concrete klasörü oluşturuldu. Abstract klasöründe soyulama yani interface ler tutuluyor ve Concrete klasöründe de somut olanlanlar tutluyor.

  Abstract Klasöründe;

  - ISupplierService : Maske Verilmesi İşlemleri İçin
  - IApplicantService : Maske Başvuruları için

  Concrete Klasöründe;

  - PersonManager : TC Vatandaşları için oluşturulan sınıftır mesela kişi doğrulama, listeleme işlemleri vs.
  - PttManager : Maske verilmesi işlemleri için yapılan sınıftır.
  - ForeignManager : Yabancı uyruklu vatandaşlar için oluşturulan sınıftır.

  Daha sonrasında Mernis doğrulaması yani vatandaş olup olmadığını doğrulaması için [KPS Public](https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx) Saop servisini WCF Web Service ile bağladım.

  Son olarak Ptt tarafından maske verilip verilmeyeceğini gösteren bir ptogramı workaround da çalıştırıldı.


  
