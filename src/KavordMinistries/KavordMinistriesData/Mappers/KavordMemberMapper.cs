using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace KavordMinistriesData.Mappers
{
    class KavordMemberMapper : EntityTypeConfiguration<KavordMinistriesDomain.KavordMinistriesDomain>
    {
        public KavordMemberMapper()
        {
            this.ToTable("KavordMember", "dbo");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).HasColumnName("KavordMember_Id");
        }
    }
}
