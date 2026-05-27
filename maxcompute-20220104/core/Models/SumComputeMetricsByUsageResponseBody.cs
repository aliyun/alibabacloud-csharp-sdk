// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class SumComputeMetricsByUsageResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<SumComputeMetricsByUsageResponseBodyData> Data { get; set; }
        public class SumComputeMetricsByUsageResponseBodyData : TeaModel {
            [NameInMap("dailyComputeMetrics")]
            [Validation(Required=false)]
            public List<SumComputeMetricsByUsageResponseBodyDataDailyComputeMetrics> DailyComputeMetrics { get; set; }
            public class SumComputeMetricsByUsageResponseBodyDataDailyComputeMetrics : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>20260413</para>
                /// </summary>
                [NameInMap("dateTime")]
                [Validation(Required=false)]
                public string DateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>GBCplx</para>
                /// </summary>
                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.149683987</para>
                /// </summary>
                [NameInMap("usage")]
                [Validation(Required=false)]
                public string Usage { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ComputationSql</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0bc0598d17544456742466519e6611</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
