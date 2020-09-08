using CleanArchitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Entities
{
    public class Person : AuditableEntity
    {
        public int Id { get; set; }
        public string Nickname { get; set; }

        public Person(int id, string nickname)
        {
            this.Id = id;
            this.Nickname = nickname;

        }
    }
}
