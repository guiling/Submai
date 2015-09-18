using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Submail.Lib
{
    public class Message : ISender
    {
        public bool Send(Dictionary<string, string> data)
        {
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
