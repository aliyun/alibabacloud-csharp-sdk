// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeResourceUsageTotalResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeResourceUsageTotalResponseBodyData Data { get; set; }
        public class DescribeResourceUsageTotalResponseBodyData : TeaModel {
            [NameInMap("PeriodCoverage")]
            [Validation(Required=false)]
            public List<DescribeResourceUsageTotalResponseBodyDataPeriodCoverage> PeriodCoverage { get; set; }
            public class DescribeResourceUsageTotalResponseBodyDataPeriodCoverage : TeaModel {
                public string Period { get; set; }
                public float? UsagePercentage { get; set; }
            }
            [NameInMap("TotalUsage")]
            [Validation(Required=false)]
            public DescribeResourceUsageTotalResponseBodyDataTotalUsage TotalUsage { get; set; }
            public class DescribeResourceUsageTotalResponseBodyDataTotalUsage : TeaModel {
                [NameInMap("PostpaidCost")]
                [Validation(Required=false)]
                public float? PostpaidCost { get; set; }

                [NameInMap("PotentialSavedCost")]
                [Validation(Required=false)]
                public float? PotentialSavedCost { get; set; }

                [NameInMap("ReservationCost")]
                [Validation(Required=false)]
                public float? ReservationCost { get; set; }

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
