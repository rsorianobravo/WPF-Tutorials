using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCommands.Models
{
    public class TodoItems
    {
        public string Description { get; set; }
        public string OwnerName { get; set; }
        public bool IsCompleted { get; set; }
    }
}
