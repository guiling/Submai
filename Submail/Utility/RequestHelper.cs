using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submail.Utility
{
    public class RequestHelper
    {
        public static string FormatRequest(Dictionary<string, object> data)
        {
            StringBuilder builder = new StringBuilder();
            foreach (string key in data.Keys)
            {
                string value = data[key] as string;
                if (value != null)
                {
                    builder.Append(string.Format("{0}={1}&", key,value));
                }
            }

            string formatData = builder.ToString();
            if (formatData.Length > 0)
            {
                return formatData.Substring(0, formatData.Length - 1);
            }

            return null;
        }
    }
}
