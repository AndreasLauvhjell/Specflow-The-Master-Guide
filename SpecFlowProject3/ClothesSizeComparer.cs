using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject3
{
    public class ClothesSizeComparer : IValueComparer
    {
        public bool CanCompare(object actualValue)
        {
            return actualValue is InternalSize;
        }

        public bool Compare(string expectedValue, object actualValue)
        {
            return (actualValue as InternalSize).InternalName == expectedValue;
        }
    }
}
