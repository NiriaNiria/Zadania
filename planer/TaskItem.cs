using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class TaskItem
    {
        public string Name { get; set; }
        public string Priority { get; set; }

        public TaskItem(string name,string priority)
        {
            Name = name;
            Priority = priority;
        }
        public override string ToString()
        {
            return Name + "(" + Priority + ")";
        }

    }
}
