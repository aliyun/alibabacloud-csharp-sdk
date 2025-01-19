// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class DescribePhoneNumberOperatorAttributeAnnualResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribePhoneNumberOperatorAttributeAnnualResponseBodyData Data { get; set; }
        public class DescribePhoneNumberOperatorAttributeAnnualResponseBodyData : TeaModel {
            [NameInMap("BasicCarrier")]
            [Validation(Required=false)]
            public string BasicCarrier { get; set; }

            [NameInMap("Carrier")]
            [Validation(Required=false)]
            public string Carrier { get; set; }

            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            [NameInMap("Mts")]
            [Validation(Required=false)]
            public string Mts { get; set; }

            [NameInMap("NumberPortability")]
            [Validation(Required=false)]
            public bool? NumberPortability { get; set; }

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

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
