// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20180501.Models
{
    public class BatchSendMessageToGlobeRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>sms-djnfjn344</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The mobile phone number of the sender. You can also specify a sender ID. The sender ID can contain both letters and digits. If it does, the ID must be between 1 to 11 characters in length. If the sender ID contains only digits, it must be 1 to 15 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alicloud321</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The content of the message.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;message to 931520581****\&quot;,\&quot;message to 931530581****\&quot;,\&quot;message to 931540581****\&quot;,\&quot;message to 931550581****\&quot;]</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the messaging campaign. It must be 1 to 255 characters in length. The ID is the value of the TaskId field in the delivery receipt of the message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123789****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The mobile phone numbers to which the message is sent. You must add the dialing code to the beginning of each mobile phone number.</para>
        /// <para>For more information, see <a href="https://www.alibabacloud.com/help/en/short-message-service/latest/dialing-codes">Dialing codes</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;931520581****\&quot;,\&quot;931530581****\&quot;,\&quot;931540581****\&quot;,\&quot;931550581****\&quot;]</para>
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public string To { get; set; }

        /// <summary>
        /// <para>The type of the message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NOTIFY</b>: notification</description></item>
        /// <item><description><b>MKT</b>: promotional message</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NOTIFY</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The validity period of the message. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ValidityPeriod")]
        [Validation(Required=false)]
        public long? ValidityPeriod { get; set; }

    }

}
