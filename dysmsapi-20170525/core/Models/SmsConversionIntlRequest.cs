// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class SmsConversionIntlRequest : TeaModel {
        /// <summary>
        /// <para>The timestamp at which the message reached the recipient. Must be a Unix timestamp, expressed as a long integer in milliseconds.</para>
        /// <list type="bullet">
        /// <item><description><para>If this field is not specified: defaults to the current timestamp.</para>
        /// </description></item>
        /// <item><description><para>If this field is specified: the timestamp must be greater than the send time and less than the current timestamp.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1349055900000</para>
        /// </summary>
        [NameInMap("ConversionTime")]
        [Validation(Required=false)]
        public long? ConversionTime { get; set; }

        /// <summary>
        /// <para>Set to true if your user replied to the message you sent. Otherwise, set to false.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Delivered")]
        [Validation(Required=false)]
        public bool? Delivered { get; set; }

        /// <summary>
        /// <para>Message ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1008030300****</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
