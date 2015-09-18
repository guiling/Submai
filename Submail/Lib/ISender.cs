using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Submail.Lib
{
    interface ISender
    {
        /**
	     * Send the request data.
	     * @param data {@link HashMap}contains the request data.Such as
	     * <p>
	     * to->xxx@submail.cn
	     * cc->nnn@submail.cn
	     * text->Hello,world!
	     * </p>
	     * @return If send successfully,return true.Error occurs,return false.
	     **/
        bool Send(Dictionary<string, string> data);

        bool XSend(Dictionary<string, string> data);

        bool Subscribe(Dictionary<string, string> data);

        bool UnSubscribe(Dictionary<string, string> data);
    }
}
