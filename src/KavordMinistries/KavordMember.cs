using System;
namespace KavordMinistriesDomain.Models
{
    public class KavordMember : IntIdentifiedEntity
    {
        public KavordMember()
        {
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Id_Number { get; set; }
        public string Address { get; set; }
        public string MeritalStatus { get; set; }
        public string Gender { get; set; }
        public string CellNumber { get; set; }
        public string MemberType { get; set; }
        public int Age { get; set; }
        public DateTime DOB { get; set; }
        public DateTime MemberFrom { get; set; }
        public string Photo { get; set; }
    }
}
