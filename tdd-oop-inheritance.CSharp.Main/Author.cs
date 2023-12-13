using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Author : IAuthor
    {
        public string name { get ; set; }
        public string contact { get; set; }
        public string website { get; set; }
    }
}
