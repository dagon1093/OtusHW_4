using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHM_4
{
    static class StackExtensions
    {
        public static void Merge(this Stack s1, Stack s2)
        {
            foreach (var item in s2.Elements) {
                s1.Add(item);
            }
        }
    }
}
