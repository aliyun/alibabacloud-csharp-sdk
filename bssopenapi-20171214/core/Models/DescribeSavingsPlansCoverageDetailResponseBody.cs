// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeSavingsPlansCoverageDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSavingsPlansCoverageDetailResponseBodyData Data { get; set; }
        public class DescribeSavingsPlansCoverageDetailResponseBodyData : TeaModel {
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeSavingsPlansCoverageDetailResponseBodyDataItems> Items { get; set; }
            public class DescribeSavingsPlansCoverageDetailResponseBodyDataItems : TeaModel {
                public long? UserId { get; set; }
                public string InstanceId { get; set; }
                public string Currency { get; set; }
                public string InstanceSpec { get; set; }
                public float? PostpaidCost { get; set; }
                public float? CoveragePercentage { get; set; }
                public string Region { get; set; }
                public float? DeductAmount { get; set; }
                public string StartPeriod { get; set; }
                public float? TotalAmount { get; set; }
                public string UserName { get; set; }
                public string EndPeriod { get; set; }
            }
        };

    }

}
