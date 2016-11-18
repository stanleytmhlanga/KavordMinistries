using System;
using System.Collections.Generic;

namespace KavordMinistriesApi.Repositories
{
    class KavordMemberRepository : IKavordMemberRepository, IDisposable
    {
        private MemberContext _context;
        public KavordMemberRepository(MemberContext context)
        {
            this._context = context;
        }
        public void DeleteMember(int id)
        {
            var member = _context.Members.Find(id);
            _context.Members.Remove(member);
        }

        public IEnumerable<KavordMinistriesApi> GetAllMembers()
        {
            using (var member = new MemberContext())
            {
                return _context.Members;
            }

        }

        public KavordMinistriesApi GetMemberById(int id)
        {
            return _context.Members.Find(id);
        }

        public void InsertMember(KavordMinistriesApi member)
        {
            _context.Members.Add(member);
        }

        public void save()
        {
            _context.SaveChanges();
        }

        public void Updatemember(KavordMinistriesApi member)
        {
            _context.Entry(member).State = System.Data.Entity.EntityState.Modified;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
