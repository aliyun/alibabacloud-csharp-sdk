// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeResourceUsageTotalResponseBody : TeaModel {
        /// <summary>
        /// The total savings.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The usage of deduction plans within the specified period.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeResourceUsageTotalResponseBodyData Data { get; set; }
        public class DescribeResourceUsageTotalResponseBodyData : TeaModel {
            /// <summary>
            /// The total potential savings.
            /// </summary>
            [NameInMap("PeriodCoverage")]
            [Validation(Required=false)]
            public List<DescribeResourceUsageTotalResponseBodyDataPeriodCoverage> PeriodCoverage { get; set; }
            public class DescribeResourceUsageTotalResponseBodyDataPeriodCoverage : TeaModel {
                /// <summary>
                /// The returned data.
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public string Period { get; set; }

                /// <summary>
                /// The fee of purchased deduction plans.
                /// </summary>
                [NameInMap("UsagePercentage")]
                [Validation(Required=false)]
                public float? UsagePercentage { get; set; }

            }

            /// <summary>
            /// The total usage of deduction plans.
            /// </summary>
            [NameInMap("TotalUsage")]
            [Validation(Required=false)]
            public DescribeResourceUsageTotalResponseBodyDataTotalUsage TotalUsage { get; set; }
            public class DescribeResourceUsageTotalResponseBodyDataTotalUsage : TeaModel {
                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("PostpaidCost")]
                [Validation(Required=false)]
                public float? PostpaidCost { get; set; }

                [NameInMap("PotentialSavedCost")]
                [Validation(Required=false)]
                public float? PotentialSavedCost { get; set; }

                [NameInMap("ReservationCost")]
                [Validation(Required=false)]
                public float? ReservationCost { get; set; }

                /// <summary>
                /// Queries the total usage data of reserved instances (RIs) or storage capacity units (SCUs).
                /// </summary>
                [NameInMap("SavedCost")]
                [Validation(Required=false)]
                public float? SavedCost { get; set; }

                [NameInMap("UsagePercentage")]
                [Validation(Required=false)]
                public float? UsagePercentage { get; set; }

            }

        }

        /// <summary>
        /// The total costs of pay-as-you-go instances.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The status code.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to DescribeResourceUsageTotal.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
