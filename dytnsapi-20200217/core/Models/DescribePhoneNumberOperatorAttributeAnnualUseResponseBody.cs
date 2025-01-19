// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class DescribePhoneNumberOperatorAttributeAnnualUseResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribePhoneNumberOperatorAttributeAnnualUseResponseBodyData Data { get; set; }
        public class DescribePhoneNumberOperatorAttributeAnnualUseResponseBodyData : TeaModel {
            [NameInMap("BasicCarrier")]
            [Validation(Required=false)]
            public string BasicCarrier { get; set; }

            [NameInMap("Carrier")]
            [Validation(Required=false)]
            public string Carrier { get; set; }

            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            [NameInMap("IsNumberPortability")]
            [Validation(Required=false)]
            public bool? IsNumberPortability { get; set; }

            [NameInMap("NumberSegment")]
            [Validation(Required=false)]
            public long? NumberSegment { get; set; }

            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
