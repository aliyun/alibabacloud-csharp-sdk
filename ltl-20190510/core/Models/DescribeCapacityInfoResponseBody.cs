// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ltl20190510.Models
{
    public class DescribeCapacityInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCapacityInfoResponseBodyData Data { get; set; }
        public class DescribeCapacityInfoResponseBodyData : TeaModel {
            [NameInMap("CapacityQuota")]
            [Validation(Required=false)]
            public long? CapacityQuota { get; set; }

            [NameInMap("CountQuota")]
            [Validation(Required=false)]
            public long? CountQuota { get; set; }

            [NameInMap("MemberUsedCapacity")]
            [Validation(Required=false)]
            public long? MemberUsedCapacity { get; set; }

            [NameInMap("MemberUsedCount")]
            [Validation(Required=false)]
            public long? MemberUsedCount { get; set; }

            [NameInMap("UsedCapacity")]
            [Validation(Required=false)]
            public long? UsedCapacity { get; set; }

            [NameInMap("UsedCount")]
            [Validation(Required=false)]
            public long? UsedCount { get; set; }

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
