using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DualListDemo.Infrastructure
{
    public interface IDualListHandler
    {
        void Handle(int[] addedTo1, int[] removedFrom1, int[] addedTo2, int[] removedFrom2);
    }
}