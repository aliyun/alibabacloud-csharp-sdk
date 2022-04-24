// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeSavingsPlansUsageDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSavingsPlansUsageDetailResponseBodyData Data { get; set; }
        public class DescribeSavingsPlansUsageDetailResponseBodyData : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeSavingsPlansUsageDetailResponseBodyDataItems> Items { get; set; }
            public class DescribeSavingsPlansUsageDetailResponseBodyDataItems : TeaModel {
                public string Currency { get; set; }
                public float? DeductValue { get; set; }
                public string EndPeriod { get; set; }
                public string InstanceId { get; set; }
                public float? PoolValue { get; set; }
                public float? PostpaidCost { get; set; }
                public float? SavedCost { get; set; }
                public string StartPeriod { get; set; }
                public string Status { get; set; }
                public string Type { get; set; }
                public float? UsagePercentage { get; set; }
                public long? UserId { get; set; }
                public string UserName { get; set; }
            }
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

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
