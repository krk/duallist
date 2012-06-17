using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DualListDemo.Infrastructure
{
    public class DualListDump : IDualListHandler
    {
        public int[] AddedTo1 { get; set; }
        public int[] AddedTo2 { get; set; }
        public int[] RemovedFrom1 { get; set; }
        public int[] RemovedFrom2 { get; set; }

        public void Handle(int[] addedTo1, int[] removedFrom1, int[] addedTo2, int[] removedFrom2)
        {
            AddedTo1 = addedTo1;
            AddedTo2 = addedTo2;
            RemovedFrom1 = removedFrom1;
            RemovedFrom2 = removedFrom2;
        }
    }
}