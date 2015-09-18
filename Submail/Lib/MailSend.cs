using Submail.AppConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submail.Lib
{
    public class MailSend : ISenderFactory
    {
        private const string TO = "to";
        private const string ADDRESSBOOK = "addressbook";
        private const string FROM = "from";
        private const string FROM_NAME = "from_name";
        private const string REPLY = "reply";
        private const string CC = "cc";
        private const string BCC = "bcc";
        private const string SUBJECT = "subject";
        private const string TEXT = "text";
        private const string HTML = "html";
        private const string VARS = "vars";
        private const string LINKS = "links";
        private const string ATTACHMENTS = "attachments";
        private const string HEADERS = "headers";

        private IAppConfig _appConfig = null;

        public MailSend(IAppConfig appConfig)
        {
            _appConfig = appConfig;
        }

        public ISender GetSender()
        {
            return new Mail(_appConfig);
        }
    }
}
