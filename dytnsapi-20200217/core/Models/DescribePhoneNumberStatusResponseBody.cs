// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class DescribePhoneNumberStatusResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PhoneStatus")]
        [Validation(Required=false)]
        public DescribePhoneNumberStatusResponseBodyPhoneStatus PhoneStatus { get; set; }
        public class DescribePhoneNumberStatusResponseBodyPhoneStatus : TeaModel {
            [NameInMap("Carrier")]
            [Validation(Required=false)]
            public string Carrier { get; set; }
            [NameInMap("SerialId")]
            [Validation(Required=false)]
            public string SerialId { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
