using System;
using System.Collections.Generic;
using System.Text;
using ExampleNetCore.Business.Modules.Example.Models;
using ExampleNetCore.Data;
using Microsoft.EntityFrameworkCore;

namespace ExampleNetCore.Business.Modules.Example
{
    public class ExampleModule : IExampleModule
    {
        private readonly ExampleContext _context;

        public ExampleModule(ExampleContext exampleContext)
        {
            _context = exampleContext;
        }
        public bool AddItem(ExampleModel item)
        {
            try
            {
                _context.Examples.Add(item.ToEntity());
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteItem(ExampleModel item)
        {
            throw new NotImplementedException();
        }

        public ExampleModel GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public IList<ExampleModel> GetItems()
        {
            throw new NotImplementedException();
        }

        public bool UpdateItem(ExampleModel item)
        {
            throw new NotImplementedException();
        }
    }
}
