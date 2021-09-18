// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20180501.Models
{
    public class SmsConversionRequest : TeaModel {
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        [NameInMap("Delivered")]
        [Validation(Required=false)]
        public bool? Delivered { get; set; }

        [NameInMap("ConversionTime")]
        [Validation(Required=false)]
        public long? ConversionTime { get; set; }

    }

}
