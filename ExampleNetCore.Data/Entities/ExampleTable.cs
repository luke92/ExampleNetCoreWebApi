using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleNetCore.Data.Entities
{
    public class ExampleTable
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

        public ExampleTable()
        {
            Id = Guid.NewGuid();
            Active = true;
        }
    }

}
