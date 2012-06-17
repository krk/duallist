using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DualListDemo.Models
{
    public class DualListViewModel
    {
        public DualListViewModel()
        {
            LeftList = Enumerable.Empty<IPrimaryKey>();
            RightList = Enumerable.Empty<IPrimaryKey>();

            var lst = new List<IPrimaryKey>();
            lst.Add(new FruitViewModel() { Id = 1, Name = "Apple" });
            lst.Add(new FruitViewModel() { Id = 2, Name = "Orange" });
            lst.Add(new FruitViewModel() { Id = 3, Name = "Kiwi" });

            LeftList = lst;

            lst = new List<IPrimaryKey>();
            lst.Add(new FruitViewModel() { Id = 4, Name = "Blueberry" });
            lst.Add(new FruitViewModel() { Id = 5, Name = "Blackberry" });
            lst.Add(new FruitViewModel() { Id = 6, Name = "Raspberry" });

            RightList = lst;
        }

        public string ControllerName { get; set; }
        public string ContainerId { get; set; }
        public string SubmitButtonId { get; set; }
        public string LeftListId { get; set; }
        public string RightListId { get; set; }
        public string ConnectWithClass { get; set; }
        public string LeftListHeader { get; set; }
        public string RightListHeader { get; set; }

        public IEnumerable<IPrimaryKey> LeftList { get; set; }
        public IEnumerable<IPrimaryKey> RightList { get; set; }

        public string UpdateJS { get; set; }
    }
}