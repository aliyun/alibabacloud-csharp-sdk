// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeSavingsPlansUsageTotalResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned query data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSavingsPlansUsageTotalResponseBodyData Data { get; set; }
        public class DescribeSavingsPlansUsageTotalResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The usage data for each time period.</para>
            /// </summary>
            [NameInMap("PeriodCoverage")]
            [Validation(Required=false)]
            public List<DescribeSavingsPlansUsageTotalResponseBodyDataPeriodCoverage> PeriodCoverage { get; set; }
            public class DescribeSavingsPlansUsageTotalResponseBodyDataPeriodCoverage : TeaModel {
                /// <summary>
                /// <para>The usage percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Percentage")]
                [Validation(Required=false)]
                public float? Percentage { get; set; }

                /// <summary>
                /// <para>The time period to which the data belongs. Format: yyyyMMddHH.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021041500</para>
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public string Period { get; set; }

            }

            /// <summary>
            /// <para>The total usage overview.</para>
            /// </summary>
            [NameInMap("TotalUsage")]
            [Validation(Required=false)]
            public DescribeSavingsPlansUsageTotalResponseBodyDataTotalUsage TotalUsage { get; set; }
            public class DescribeSavingsPlansUsageTotalResponseBodyDataTotalUsage : TeaModel {
                /// <summary>
                /// <para>The total amount of savings plans.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("PoolValue")]
                [Validation(Required=false)]
                public float? PoolValue { get; set; }

                /// <summary>
                /// <para>The pay-as-you-go cost.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("PostpaidCost")]
                [Validation(Required=false)]
                public float? PostpaidCost { get; set; }

                /// <summary>
                /// <para>The amount saved.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("SavedCost")]
                [Validation(Required=false)]
                public float? SavedCost { get; set; }

                /// <summary>
                /// <para>The total usage percentage.</para>
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
        /// <para>The message returned for the API call.</para>
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
        /// <para>79EE7556-0CFD-44EB-9CD6-B3B526E3A85F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
