using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_Two.Requests
{
    public class AddEmsUser
    {
        public string Name { get; set; }=string.Empty;
        public int PhoneNumber { get; set; }
        public string Email { get; set; }=string.Empty;
        public string? Password { get; set; }
    }
}
