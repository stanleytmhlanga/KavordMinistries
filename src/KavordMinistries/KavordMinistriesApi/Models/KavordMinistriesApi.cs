using System;
using System.ComponentModel;

namespace KavordMinistriesApi
{
    public class KavordMinistriesApi
    {
        public KavordMinistriesApi(KavordMinistriesDomain.KavordMinistriesDomain domain)
        {
            this.Name = domain.Name;
            this.Surname = domain.Surname;
            this.Address = domain.Address;
            this.Age = domain.Age;
            this.CellNumber = domain.CellNumber;
            this.Gender = domain.Gender;
            this.IdNumber = domain.IdNumber;
            this.DOB = domain.DOB;
            this.MemberFrom = domain.MemberFrom;
            this.MeritalStatus = domain.MeritalStatus;
            this.Photo = domain.Photo;
            this.MemberType = domain.MemberType;



        }

        public void MapToDomain(KavordMinistriesApi api)
        {
            var domain = new KavordMinistriesDomain.KavordMinistriesDomain();

            domain.Name = api.Name;
            domain.Surname = api.Surname;
            domain.Address = api.Address;
            domain.Age = api.Age;
            domain.DOB = api.DOB;
            domain.MemberType = api.MemberType;
            domain.MeritalStatus = api.MeritalStatus;
            domain.MemberFrom = api.MemberFrom;
            domain.Photo = api.Photo;
            domain.IdNumber = api.IdNumber;
            domain.Gender = api.Gender;
            domain.CellNumber = api.CellNumber;

        }



        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        [DisplayName("Id Number")]
        public string IdNumber { get; set; }
        public string Gender { get; set; }
        [DisplayName("Merital Status")]
        public string MeritalStatus { get; set; }
        public int Age { get; set; }
        [DisplayName("Member Stated ")]
        public DateTime MemberFrom { get; set; }
        [DisplayName("Date Of Birth")]
        public DateTime DOB { get; set; }
        [DisplayName("Cell Number")]
        public string CellNumber { get; set; }
        [DisplayName("Member Type")]
        public string MemberType { get; set; }
        public string Photo { get; set; }

    }
}
