// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class DescribePhoneNumberAttributeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PhoneNumberAttribute")]
        [Validation(Required=false)]
        public DescribePhoneNumberAttributeResponseBodyPhoneNumberAttribute PhoneNumberAttribute { get; set; }
        public class DescribePhoneNumberAttributeResponseBodyPhoneNumberAttribute : TeaModel {
            [NameInMap("BasicCarrier")]
            [Validation(Required=false)]
            public string BasicCarrier { get; set; }
            [NameInMap("Carrier")]
            [Validation(Required=false)]
            public string Carrier { get; set; }
            [NameInMap("IsNumberPortability")]
            [Validation(Required=false)]
            public bool? IsNumberPortability { get; set; }
            [NameInMap("NumberSegment")]
            [Validation(Required=false)]
            public long? NumberSegment { get; set; }
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }
            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }
        };

    }

}
