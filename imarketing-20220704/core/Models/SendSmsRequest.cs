// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imarketing20220704.Models
{
    public class SendSmsRequest : TeaModel {
        [NameInMap("NowStamp")]
        [Validation(Required=false)]
        public long? NowStamp { get; set; }

        [NameInMap("PhoneNumbers")]
        [Validation(Required=false)]
        public string PhoneNumbers { get; set; }

        [NameInMap("SignKey")]
        [Validation(Required=false)]
        public string SignKey { get; set; }

    }

}
