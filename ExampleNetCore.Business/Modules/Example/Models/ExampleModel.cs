using ExampleNetCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleNetCore.Business.Modules.Example.Models
{
    public class ExampleModel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

        public ExampleModel()
        {
            Id = Guid.NewGuid();
            Active = true;
        }

        public ExampleTable ToEntity()
        {
            return new ExampleTable
            {
                Id = Id,
                Description = Description,
                Active = Active
            };
        }
    }
}
