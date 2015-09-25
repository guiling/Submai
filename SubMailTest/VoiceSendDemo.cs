using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
    public class VoiceSendDemo
    {
        public void VoiceVerify()
        {
            IAppConfig appConfig = new MessageConfig("10051", "d13ff6b6ab46bd713d1d5ce6a0a0b78a");
            VoiceSend voiceSend = new VoiceSend(appConfig);
            voiceSend.AddTo("13756563150");
            // 此数字为语音播报的4位数字验证码
            voiceSend.AddCode("1234");
            string returnMessage = string.Empty;
            if (voiceSend.VoiceVerify(out returnMessage) == false)
            {
                Console.WriteLine(returnMessage);
            }
        }
    }
}
