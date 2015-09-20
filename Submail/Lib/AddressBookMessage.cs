using Submail.AppConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submail.Lib
{
    public class AddressBookMessage : SendBase
    {
        private const string ADDRESS = "address";
        private const string TARGET = "target";

        public AddressBookMessage(IAppConfig appConfig) : base(appConfig)
        {
        }       

        protected override ISender GetSender()
        {
            return new Message(_appConfig);
        }

        public void SetAddress(string address)
        {
            _dataPair.Add(ADDRESS, address);
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
