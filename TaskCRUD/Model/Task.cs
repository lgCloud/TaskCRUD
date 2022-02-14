using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskCRUD.Model
{
    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; } = false;
    }
}
