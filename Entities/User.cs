using System;

namespace CoreWiki.Entities {
    public class User {
        public string Id {get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public DateTime CreatedDate {get;set;}
        public bool IsAuthorized {get;set;}
        public bool IsDeleted {get;set;}

        public string FullName => $"{this.FirstName} {this.LastName}";
    }
}