using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DualListDemo.Models
{
    public interface IPrimaryKey<T>
    {
        T Id { get; set; }
    }

    public interface IPrimaryKey : IPrimaryKey<int>
    {
    }
}