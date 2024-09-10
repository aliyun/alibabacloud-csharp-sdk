// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutContactRequest : TeaModel {
        [NameInMap("Channels")]
        [Validation(Required=false)]
        public PutContactRequestChannels Channels { get; set; }
        public class PutContactRequestChannels : TeaModel {
            /// <summary>
            /// The TradeManager ID of the alert contact.
            /// 
            /// Specify at least one of the following alert notification targets: email address or webhook URL of the DingTalk chatbot.
            /// </summary>
            [NameInMap("AliIM")]
            [Validation(Required=false)]
            public string AliIM { get; set; }

            /// <summary>
            /// The webhook URL of the DingTalk chatbot.
            /// 
            /// Specify at least one of the following alert notification targets: email address or webhook URL of the DingTalk chatbot.
            /// </summary>
            [NameInMap("DingWebHook")]
            [Validation(Required=false)]
            public string DingWebHook { get; set; }

            /// <summary>
            /// The email address of the alert contact. After you add or modify an email address, the recipient receives an email that contains an activation link. The system adds the recipient to the list of alert contacts only after the recipient activates the email address.
            /// 
            /// Specify at least one of the following alert notification targets: email address or webhook URL of the DingTalk chatbot.
            /// </summary>
            [NameInMap("Mail")]
            [Validation(Required=false)]
            public string Mail { get; set; }

            /// <summary>
            /// The phone number of the alert contact. After you add or modify a phone number, the recipient receives a text message that contains an activation link. The system adds the recipient to the list of alert contacts only after the recipient activates the phone number.
            /// 
            /// Specify at least one of the following alert notification targets: email address or webhook URL of the DingTalk chatbot.
            /// </summary>
            [NameInMap("SMS")]
            [Validation(Required=false)]
            public string SMS { get; set; }

        }

        /// <summary>
        /// The name of the alert contact.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// The description of the alert contact.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Describe")]
        [Validation(Required=false)]
        public string Describe { get; set; }

        /// <summary>
        /// The language in which the alert information is displayed. Valid values:
        /// 
        /// *   zh-cn: simplified Chinese
        /// *   en: English
        /// 
        /// >  If you do not specify a value for this parameter, Cloud Monitor identifies the language of the alert information based on the region of your Alibaba Cloud account.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
