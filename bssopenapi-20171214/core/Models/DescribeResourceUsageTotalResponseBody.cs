// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeResourceUsageTotalResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The queried data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeResourceUsageTotalResponseBodyData Data { get; set; }
        public class DescribeResourceUsageTotalResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The usage of resource plans in the specified period.</para>
            /// </summary>
            [NameInMap("PeriodCoverage")]
            [Validation(Required=false)]
            public List<DescribeResourceUsageTotalResponseBodyDataPeriodCoverage> PeriodCoverage { get; set; }
            public class DescribeResourceUsageTotalResponseBodyDataPeriodCoverage : TeaModel {
                /// <summary>
                /// <para>The period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021071500</para>
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public string Period { get; set; }

                /// <summary>
                /// <para>The usage of resource plans.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("UsagePercentage")]
                [Validation(Required=false)]
                public float? UsagePercentage { get; set; }

            }

            /// <summary>
            /// <para>The total usage of resource plans.</para>
            /// </summary>
            [NameInMap("TotalUsage")]
            [Validation(Required=false)]
            public DescribeResourceUsageTotalResponseBodyDataTotalUsage TotalUsage { get; set; }
            public class DescribeResourceUsageTotalResponseBodyDataTotalUsage : TeaModel {
                /// <summary>
                /// <para>The total costs of pay-as-you-go instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("PostpaidCost")]
                [Validation(Required=false)]
                public float? PostpaidCost { get; set; }

                /// <summary>
                /// <para>The total potential savings.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("PotentialSavedCost")]
                [Validation(Required=false)]
                public float? PotentialSavedCost { get; set; }

                /// <summary>
                /// <para>The fee of purchased resource plans.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ReservationCost")]
                [Validation(Required=false)]
                public float? ReservationCost { get; set; }

                /// <summary>
                /// <para>The total savings.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("SavedCost")]
                [Validation(Required=false)]
                public float? SavedCost { get; set; }

                /// <summary>
                /// <para>The total usage of resource plans.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UsagePercentage")]
                [Validation(Required=false)]
                public float? UsagePercentage { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message. If the request was successful, a success message is returned. If the request failed, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>364C7C81-5E5E-51A0-B738-1969D2671B05</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
