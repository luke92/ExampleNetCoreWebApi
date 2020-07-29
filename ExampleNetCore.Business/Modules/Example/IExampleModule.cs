using ExampleNetCore.Business.Modules.Example.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleNetCore.Business.Modules.Example
{
    public interface IExampleModule
    {
        ExampleModel GetItem(Guid id);
        IList<ExampleModel> GetItems();
        bool AddItem(ExampleModel item);
        bool UpdateItem(ExampleModel item);
        bool DeleteItem(ExampleModel item);

    }
}
