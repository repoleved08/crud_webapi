using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_Two.Entities
{
    public class EmsEvent
    {
    public int Id { get; set; }
    public string Name { get; set; }=string.Empty;
    public string Description { get; set; }=string.Empty;
    public string Location { get; set; }=string.Empty;
    public int Capacity { get; set; }
    public int TicketAmount { get; set; }
    public DateTime Date { get; set; }
    public virtual ICollection<EmsUsers> Users { get; set; }
    }
}
