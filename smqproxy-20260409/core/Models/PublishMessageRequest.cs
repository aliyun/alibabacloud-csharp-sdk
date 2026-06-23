// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SMQProxy20260409.Models
{
    public class PublishMessageRequest : TeaModel {
        [NameInMap("MessageAttributes")]
        [Validation(Required=false)]
        public PublishMessageRequestMessageAttributes MessageAttributes { get; set; }
        public class PublishMessageRequestMessageAttributes : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>详见 <a href="https://help.aliyun.com/zh/direct-mail/singlesendmail">https://help.aliyun.com/zh/direct-mail/singlesendmail</a></para>
            /// </summary>
            [NameInMap("DirectMail")]
            [Validation(Required=false)]
            public string DirectMail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;FreeSignName&quot;:&quot;阿里云&quot;,&quot;TemplateCode&quot;:&quot;SMS_123456&quot;,&quot;Type&quot;:&quot;singleContent&quot;,&quot;Receiver&quot;:&quot;13800000000&quot;,&quot;SmsParams&quot;:&quot;{\&quot;code\&quot;:\&quot;1234\&quot;}&quot;}</para>
            /// </summary>
            [NameInMap("DirectSMS")]
            [Validation(Required=false)]
            public string DirectSMS { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>移动推送属性示例值</para>
            /// </summary>
            [NameInMap("Push")]
            [Validation(Required=false)]
            public string Push { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hello topic</para>
        /// </summary>
        [NameInMap("MessageBody")]
        [Validation(Required=false)]
        public string MessageBody { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>order-event</para>
        /// </summary>
        [NameInMap("MessageTag")]
        [Validation(Required=false)]
        public string MessageTag { get; set; }

    }

}
