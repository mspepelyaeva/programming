using System;
using System.Collections;

namespace Task10
{
    class SortByName : IComparer
    {
        int IComparer.Compare(object ob1, object ob2)
        {
            Organization s1 = (Organization) ob1;
            Organization s2 = (Organization) ob2;
            return String.Compare(s1.Name, s2.Name);
        }
    }
}
