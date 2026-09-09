// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class SumComputeMetricsByUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>The usage data for each metering type.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<SumComputeMetricsByUsageResponseBodyData> Data { get; set; }
        public class SumComputeMetricsByUsageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The daily usage statistics.</para>
            /// </summary>
            [NameInMap("dailyComputeMetrics")]
            [Validation(Required=false)]
            public List<SumComputeMetricsByUsageResponseBodyDataDailyComputeMetrics> DailyComputeMetrics { get; set; }
            public class SumComputeMetricsByUsageResponseBodyDataDailyComputeMetrics : TeaModel {
                /// <summary>
                /// <para>The date of the usage, in <c>yyyyMMdd</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20260413</para>
                /// </summary>
                [NameInMap("dateTime")]
                [Validation(Required=false)]
                public string DateTime { get; set; }

                /// <summary>
                /// <para>The unit of compute usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GBCplx</para>
                /// </summary>
                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

                /// <summary>
                /// <para>The total usage for the day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.149683987</para>
                /// </summary>
                [NameInMap("usage")]
                [Validation(Required=false)]
                public string Usage { get; set; }

            }

            /// <summary>
            /// <para>The metering type.</para>
            /// <para><c>ComputationSql</c>: Metering data for SQL jobs on internal tables.</para>
            /// <para><c>ComputationSqlOTS</c>: Metering data for SQL jobs on OTS external tables.</para>
            /// <para><c>ComputationSqlOSS</c>: Metering data for SQL jobs on OSS external tables.</para>
            /// <para><c>MapReduce</c>: Metering data for MapReduce jobs.</para>
            /// <para><c>spark</c>: Metering data for Spark jobs.</para>
            /// <para><c>mars</c>: Metering data for Mars jobs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ComputationSql</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description><para><c>1xx</c>: Informational response. The request is received and is being processed.</para>
        /// </description></item>
        /// <item><description><para><c>2xx</c>: Success. The request was successfully received, understood, and accepted.</para>
        /// </description></item>
        /// <item><description><para><c>3xx</c>: Redirection. Further action is required to complete the request.</para>
        /// </description></item>
        /// <item><description><para><c>4xx</c>: Client error. The request has invalid syntax or cannot be fulfilled.</para>
        /// </description></item>
        /// <item><description><para><c>5xx</c>: Server error. The server failed to fulfill an otherwise valid request.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc0598d17544456742466519e6611</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
