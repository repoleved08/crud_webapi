using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_Two.Entities
{
    public class EmsUsers
    {
        public Guid Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public int PhoneNumber { get; set; }
        public string Email { get; set; }=string.Empty;
        public string? Password { get; set; }
        public virtual ICollection<EmsEvent> Events { get; set; }
    }
}
