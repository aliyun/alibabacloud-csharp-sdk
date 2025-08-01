// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20180501.Models
{
    public class SendMessageToGlobeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3790</para>
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
        /// <para>Hello</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the messaging campaign. It must be 1 to 255 characters in length. The ID is the value of the TaskId field in the delivery receipt of the message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123****789</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The mobile phone number to which the message is sent. You must add the dialing code to the beginning of the mobile phone number. Example: 8521245567\<em>\</em>\<em>\</em>.</para>
        /// <para>For more information, see <a href="https://www.alibabacloud.com/help/en/sms/product-overview/dialing-codes?spm=a2c63.p38356.0.0.48b940a1PFYRMz">Dialing codes</a>.</para>
        /// <remarks>
        /// <para> You cannot call the SendMessageToGlobe operation to send messages to the Chinese mainland.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8521245567****</para>
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public string To { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The validity period of the message. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("ValidityPeriod")]
        [Validation(Required=false)]
        public long? ValidityPeriod { get; set; }

    }

}
