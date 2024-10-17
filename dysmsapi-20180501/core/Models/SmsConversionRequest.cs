// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20180501.Models
{
    public class SmsConversionRequest : TeaModel {
        /// <summary>
        /// <para>The time when the OTP message was delivered. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// <list type="bullet">
        /// <item><description>If you leave the parameter empty, the current timestamp is specified by default.</description></item>
        /// <item><description>If you specify the parameter, the timestamp must be greater than the message sending time and less than the current timestamp.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1349055900000</para>
        /// </summary>
        [NameInMap("ConversionTime")]
        [Validation(Required=false)]
        public long? ConversionTime { get; set; }

        /// <summary>
        /// <para>Specifies whether customers replied to the OTP message. Valid values: true and false.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Delivered")]
        [Validation(Required=false)]
        public bool? Delivered { get; set; }

        /// <summary>
        /// <para>The ID of the OTP message.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1008030300****</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

    }

}
