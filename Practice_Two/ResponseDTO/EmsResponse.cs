using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_Two.ResponseDTO
{
    public class EmsResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public int PhoneNumber { get; set; }
        [EmailAddress]
        public string Email { get; set; }=string.Empty;
         public string? Password { get; set; }
    }
}
