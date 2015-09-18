using Submail.AppConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace Submail.Lib
{
    public class Mail : ISender
    {
        private const string API_SEND = "http://api.submail.cn/mail/send.json";
        private const string API_XSEND = "http://api.submail.cn/mail/xsend.json";
        private const string API_SUBSCRIBE = "http://api.submail.cn/addressbook/mail/subscribe.json";
        private const string API_UNSUBSCRIBE = "http://api.submail.cn/addressbook/mail/unsubscribe.json";

        private IAppConfig _appConfig;

        public Mail(IAppConfig appConfig)
        {
            this._appConfig = appConfig;
        }

        public bool Send(Dictionary<string, string> data)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress =  new Uri(API_SEND);
            throw new NotImplementedException();
        }

        public bool XSend(Dictionary<string, string> data)
        {
            throw new NotImplementedException();
        }

        public bool Subscribe(Dictionary<string, string> data)
        {
            throw new NotImplementedException();
        }

        public bool UnSubscribe(Dictionary<string, string> data)
        {
            throw new NotImplementedException();
        }
    }
}
