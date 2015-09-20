using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Submail.AppConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submail.Lib
{
    public class MessageMultiXSend : SendBase
    {
        public const string PROJECT = "project";
        public const string MULTI = "multi";
      
        public MessageMultiXSend(IAppConfig appConfig) : base(appConfig)
        {
        }

        protected override ISender GetSender()
        {
            return new Message(_appConfig);
        }

        public void SetProject(string project)
        {
            this._dataPair.Add(PROJECT, project);
        }

        public void SetMulti(List<MultiMessageItem> multiItems)
        {
            JArray jArray = new JArray();
            foreach (var item in multiItems)
            {
                jArray.Add(item.ToString());
            }

            this._dataPair.Add(MULTI, jArray.ToString());
        }

        public bool MultiXSend(out string returnMessage)
        {
            return this.GetSender().MultiXSend(_dataPair, out returnMessage);
        }
    }

    public class MultiMessageItem
    {
        public const string TO = "to";
        public const string VARS = "vars";

        public override string ToString()
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add(TO, this.To);
            if (this.Vars != null && this.Vars.Count > 0)
            {
                map.Add(VARS, JsonConvert.SerializeObject(this.Vars));
            }

            return JsonConvert.SerializeObject(map);
        }

        public MultiMessageItem()
        {
            Vars = new Dictionary<string, string>();
        }

        public string To { get; set; }

        public Dictionary<string, string> Vars { get; set; }
    }
}
