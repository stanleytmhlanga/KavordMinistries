using System;
using System.Collections.Generic;

namespace KavordMinistriesApi.Repositories
{
    public interface IKavordMemberRepository : IDisposable
    {
        IEnumerable<KavordMinistriesApi> GetAllMembers();
        KavordMinistriesApi GetMemberById(int id);
        void InsertMember(KavordMinistriesApi member);
        void DeleteMember(int id);
        void Updatemember(KavordMinistriesApi member);
        void save();
    }
}


