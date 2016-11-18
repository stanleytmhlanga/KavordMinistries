using System;


namespace KavordMinistriesDomain
{
    public class KavordMinistriesDomain : IntIdentifiedEntity

    {
        public KavordMinistriesDomain()
        {

        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string IdNumber { get; set; }
        public string Gender { get; set; }
        public string MeritalStatus { get; set; }
        public int Age { get; set; }
        public DateTime MemberFrom { get; set; }
        public DateTime DOB { get; set; }
        public string CellNumber { get; set; }
        public string MemberType { get; set; }
        public string Photo { get; set; }


    }
}


public class IntIdentifiedEntity : BaseEntity<int> { }

public class BaseEntity<TIdentifier> : IEntity<TIdentifier>
{
    public TIdentifier Id { get; set; }

    public bool DeletedFlag { get; protected set; }

    public DateTime CreatedOnDateUtc { get; internal set; }
    public DateTime? AmendedOnDateUtc { get; protected set; }

    public string CreatedByUsername { get; internal set; }
    public string AmendedByUsername { get; protected set; }

    public BaseEntity()
    {
        this.Id = default(TIdentifier);
        this.CreatedOnDateUtc = DateTime.UtcNow;
        this.CreatedByUsername = "Created from a relationship";
    }

    public void MarkEntityAsDeleted()
    {
        this.DeletedFlag = true;
    }

    public void UpdateCreatedOnFields(string username)
    {
        this.UpdateCreatedOnFields(DateTime.UtcNow, username);
    }

    public void UpdateCreatedOnFields(DateTime createdOnDate, string username)
    {
        this.CreatedOnDateUtc = createdOnDate;
        this.CreatedByUsername = username;
    }

    public void UpdateAmendedOnFields(string username)
    {
        this.AmendedOnDateUtc = DateTime.UtcNow;
        this.AmendedByUsername = username;
    }
}

public interface IEntity<TIdentifier>
{
    DateTime CreatedOnDateUtc { get; }
    string CreatedByUsername { get; }
    TIdentifier Id { get; set; }

    bool DeletedFlag { get; }

    void MarkEntityAsDeleted();

    void UpdateCreatedOnFields(string username);
    void UpdateCreatedOnFields(DateTime createdOnDate, string username);

    void UpdateAmendedOnFields(string username);
}