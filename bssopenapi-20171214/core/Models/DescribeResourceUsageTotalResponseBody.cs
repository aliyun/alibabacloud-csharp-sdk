// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeResourceUsageTotalResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The queried data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeResourceUsageTotalResponseBodyData Data { get; set; }
        public class DescribeResourceUsageTotalResponseBodyData : TeaModel {
            /// <summary>
            /// The usage of resource plans in the specified period.
            /// </summary>
            [NameInMap("PeriodCoverage")]
            [Validation(Required=false)]
            public List<DescribeResourceUsageTotalResponseBodyDataPeriodCoverage> PeriodCoverage { get; set; }
            public class DescribeResourceUsageTotalResponseBodyDataPeriodCoverage : TeaModel {
                /// <summary>
                /// The period.
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public string Period { get; set; }

                /// <summary>
                /// The usage of resource plans.
                /// </summary>
                [NameInMap("UsagePercentage")]
                [Validation(Required=false)]
                public float? UsagePercentage { get; set; }

            }

            /// <summary>
            /// The total usage of resource plans.
            /// </summary>
            [NameInMap("TotalUsage")]
            [Validation(Required=false)]
            public DescribeResourceUsageTotalResponseBodyDataTotalUsage TotalUsage { get; set; }
            public class DescribeResourceUsageTotalResponseBodyDataTotalUsage : TeaModel {
                /// <summary>
                /// The total costs of pay-as-you-go instances.
                /// </summary>
                [NameInMap("PostpaidCost")]
                [Validation(Required=false)]
                public float? PostpaidCost { get; set; }

                /// <summary>
                /// The total potential savings.
                /// </summary>
                [NameInMap("PotentialSavedCost")]
                [Validation(Required=false)]
                public float? PotentialSavedCost { get; set; }

                /// <summary>
                /// The fee of purchased resource plans.
                /// </summary>
                [NameInMap("ReservationCost")]
                [Validation(Required=false)]
                public float? ReservationCost { get; set; }

                /// <summary>
                /// The total savings.
                /// </summary>
                [NameInMap("SavedCost")]
                [Validation(Required=false)]
                public float? SavedCost { get; set; }

                /// <summary>
                /// The total usage of resource plans.
                /// </summary>
                [NameInMap("UsagePercentage")]
                [Validation(Required=false)]
                public float? UsagePercentage { get; set; }

            }

        }

        /// <summary>
        /// The returned message. If the request was successful, a success message is returned. If the request failed, an error message is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
