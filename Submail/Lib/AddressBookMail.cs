using Submail.AppConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submail.Lib
{
    public class AddressBookMail : ISenderFactory
    {
        private const string ADDRESS = "address";
        private const string TARGET = "target";

        private IAppConfig _appConfig;

        private Dictionary<string, object> _dataPair = new Dictionary<string, object>();

        public AddressBookMail(IAppConfig appConfig)
        {
            _appConfig = appConfig;
        }

        public ISender GetSender()
        {
            return new Mail(_appConfig);
        }

        public void SetAddress(string address, string name)
        {
            _dataPair.Add(ADDRESS, string.Format("{0}<{1}>", name, address));
        }


        public void SetAddressBook(string target)
        {
            _dataPair.Add(TARGET, target);
        }


        public bool Subscribe()
        {
            return GetSender().Subscribe(_dataPair);
        }

        public bool UnSubscribe()
        {
            return GetSender().UnSubscribe(_dataPair);
        }
    }
}
