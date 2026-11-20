// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeAiEngineEventTrendsResponseBody : TeaModel {
        /// <summary>
        /// <para>The aggregation interval, which is automatically selected based on the query time range. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1m</b>: 1 minute</description></item>
        /// <item><description><b>5m</b>: 5 minutes</description></item>
        /// <item><description><b>15m</b>: 15 minutes</description></item>
        /// <item><description><b>1h</b>: 1 hour</description></item>
        /// <item><description><b>1d</b>: 1 day</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1m</para>
        /// </summary>
        [NameInMap("AggregateInterval")]
        [Validation(Required=false)]
        public string AggregateInterval { get; set; }

        /// <summary>
        /// <para>The time series data of events aggregated by first discovery time, sorted in ascending order of time.</para>
        /// </summary>
        [NameInMap("Points")]
        [Validation(Required=false)]
        public List<DescribeAiEngineEventTrendsResponseBodyPoints> Points { get; set; }
        public class DescribeAiEngineEventTrendsResponseBodyPoints : TeaModel {
            /// <summary>
            /// <para>The number of events first discovered within the time period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EventCount")]
            [Validation(Required=false)]
            public long? EventCount { get; set; }

            /// <summary>
            /// <para>The number of events within the time period, aggregated by risk level.</para>
            /// </summary>
            [NameInMap("RiskCounts")]
            [Validation(Required=false)]
            public DescribeAiEngineEventTrendsResponseBodyPointsRiskCounts RiskCounts { get; set; }
            public class DescribeAiEngineEventTrendsResponseBodyPointsRiskCounts : TeaModel {
                /// <summary>
                /// <para>The number of critical events.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Critical")]
                [Validation(Required=false)]
                public long? Critical { get; set; }

                /// <summary>
                /// <para>The number of high-risk events.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("High")]
                [Validation(Required=false)]
                public long? High { get; set; }

                /// <summary>
                /// <para>The number of low-risk events.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Low")]
                [Validation(Required=false)]
                public long? Low { get; set; }

                /// <summary>
                /// <para>The number of medium-risk events.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Medium")]
                [Validation(Required=false)]
                public long? Medium { get; set; }

            }

            /// <summary>
            /// <para>The start time of the statistical period in the UNIX timestamp format. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1792973400000</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A****-1219-019A-8B44-2557C*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
