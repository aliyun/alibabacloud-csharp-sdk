// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class SmsConversionIntlRequest : TeaModel {
        /// <summary>
        /// The time when the OTP message was delivered. The value is a UNIX timestamp. Unit: milliseconds.
        /// 
        /// *   If you leave the parameter empty, the current timestamp is specified by default.
        /// *   If you specify the parameter, the timestamp must be greater than the message sending time and less than the current timestamp.
        /// </summary>
        [NameInMap("ConversionTime")]
        [Validation(Required=false)]
        public long? ConversionTime { get; set; }

        /// <summary>
        /// Specifies whether customers replied to the OTP message. Valid values: true and false.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Delivered")]
        [Validation(Required=false)]
        public bool? Delivered { get; set; }

        /// <summary>
        /// The ID of the message.
        /// 
        /// This parameter is required.
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
