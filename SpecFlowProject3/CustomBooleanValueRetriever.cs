using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject3
{
    public class CustomBooleanValueRetriever : IValueRetriever
    {
        public bool CanRetrieve(KeyValuePair<string, string> keyValuePair, Type targetType, Type propertyType)
        {
            switch (keyValuePair.Value.ToLowerInvariant())
            {
                case "true":
                case "false":
                case "t":
                case "f":
                case "yes":
                case "no":
                    return true;
                default:
                    return false;
            }
        }

        public object Retrieve(KeyValuePair<string, string> keyValuePair, Type targetType, Type propertyType)
        {
            switch (keyValuePair.Value.ToLowerInvariant())
                            {
                case "true":
                case "false":
                case "t":
                    return true;
                case "f":
                case "yes":
                case "no":
                    return false;
                default:
                    return false;
                }
            }
    }
}
