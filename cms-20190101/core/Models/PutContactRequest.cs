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
            /// <para>The TradeManager ID of the alert contact.</para>
            /// <para>Specify at least one of the following alert notification targets: email address or webhook URL of the DingTalk chatbot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Jim</para>
            /// </summary>
            [NameInMap("AliIM")]
            [Validation(Required=false)]
            public string AliIM { get; set; }

            /// <summary>
            /// <para>The webhook URL of the DingTalk chatbot.</para>
            /// <para>Specify at least one of the following alert notification targets: email address or webhook URL of the DingTalk chatbot.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=7d49515e8ebf21106a80a9cc4bb3d247771305d52fb15d6201234565">https://oapi.dingtalk.com/robot/send?access_token=7d49515e8ebf21106a80a9cc4bb3d247771305d52fb15d6201234565</a>****</para>
            /// </summary>
            [NameInMap("DingWebHook")]
            [Validation(Required=false)]
            public string DingWebHook { get; set; }

            /// <summary>
            /// <para>The email address of the alert contact. After you add or modify an email address, the recipient receives an email that contains an activation link. The system adds the recipient to the list of alert contacts only after the recipient activates the email address.</para>
            /// <para>Specify at least one of the following alert notification targets: email address or webhook URL of the DingTalk chatbot.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@aliyun.com">test@aliyun.com</a></para>
            /// </summary>
            [NameInMap("Mail")]
            [Validation(Required=false)]
            public string Mail { get; set; }

            /// <summary>
            /// <para>The phone number of the alert contact. After you add or modify a phone number, the recipient receives a text message that contains an activation link. The system adds the recipient to the list of alert contacts only after the recipient activates the phone number.</para>
            /// <para>Specify at least one of the following alert notification targets: email address or webhook URL of the DingTalk chatbot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1333333****</para>
            /// </summary>
            [NameInMap("SMS")]
            [Validation(Required=false)]
            public string SMS { get; set; }

        }

        /// <summary>
        /// <para>The name of the alert contact.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alice</para>
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// <para>The description of the alert contact.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_Instance</para>
        /// </summary>
        [NameInMap("Describe")]
        [Validation(Required=false)]
        public string Describe { get; set; }

        /// <summary>
        /// <para>The language in which the alert information is displayed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-cn: simplified Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you do not specify a value for this parameter, Cloud Monitor identifies the language of the alert information based on the region of your Alibaba Cloud account.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>zh-cn</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
