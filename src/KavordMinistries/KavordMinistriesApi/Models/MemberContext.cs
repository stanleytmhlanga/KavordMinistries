
using System.Data.Entity;

namespace KavordMinistriesApi
{
    public class MemberContext : DbContext
    {
        public MemberContext()
            : base("name=KavordMinistriesDatabase")
        { }
        public DbSet<KavordMinistriesApi> Members { get; set; }
    }
}
