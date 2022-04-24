// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeSavingsPlansUsageTotalResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSavingsPlansUsageTotalResponseBodyData Data { get; set; }
        public class DescribeSavingsPlansUsageTotalResponseBodyData : TeaModel {
            [NameInMap("PeriodCoverage")]
            [Validation(Required=false)]
            public List<DescribeSavingsPlansUsageTotalResponseBodyDataPeriodCoverage> PeriodCoverage { get; set; }
            public class DescribeSavingsPlansUsageTotalResponseBodyDataPeriodCoverage : TeaModel {
                public float? Percentage { get; set; }
                public string Period { get; set; }
            }
            [NameInMap("TotalUsage")]
            [Validation(Required=false)]
            public DescribeSavingsPlansUsageTotalResponseBodyDataTotalUsage TotalUsage { get; set; }
            public class DescribeSavingsPlansUsageTotalResponseBodyDataTotalUsage : TeaModel {
                [NameInMap("PoolValue")]
                [Validation(Required=false)]
                public float? PoolValue { get; set; }

                [NameInMap("PostpaidCost")]
                [Validation(Required=false)]
                public float? PostpaidCost { get; set; }

                [NameInMap("SavedCost")]
                [Validation(Required=false)]
                public float? SavedCost { get; set; }

                [NameInMap("UsagePercentage")]
                [Validation(Required=false)]
                public float? UsagePercentage { get; set; }

            }
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
