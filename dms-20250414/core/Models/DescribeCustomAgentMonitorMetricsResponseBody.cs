// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DescribeCustomAgentMonitorMetricsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCustomAgentMonitorMetricsResponseBodyData Data { get; set; }
        public class DescribeCustomAgentMonitorMetricsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of active users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("ActiveUserCount")]
            [Validation(Required=false)]
            public long? ActiveUserCount { get; set; }

            /// <summary>
            /// <para>The custom agent ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca-4y3ca4khkcu**********ysf</para>
            /// </summary>
            [NameInMap("CustomAgentId")]
            [Validation(Required=false)]
            public string CustomAgentId { get; set; }

            /// <summary>
            /// <para>The total number of dislikes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DislikeCount")]
            [Validation(Required=false)]
            public long? DislikeCount { get; set; }

            /// <summary>
            /// <para>The end time of the statistical period (epoch millis).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1756742400000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The aggregation granularity: DAY / HOUR.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DAY</para>
            /// </summary>
            [NameInMap("Granularity")]
            [Validation(Required=false)]
            public string Granularity { get; set; }

            /// <summary>
            /// <para>The total number of likes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("LikeCount")]
            [Validation(Required=false)]
            public long? LikeCount { get; set; }

            /// <summary>
            /// <para>The total number of sessions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>102</para>
            /// </summary>
            [NameInMap("SessionCount")]
            [Validation(Required=false)]
            public long? SessionCount { get; set; }

            /// <summary>
            /// <para>The start time of the statistical period (epoch millis).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1782835200000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The trend data aggregated by the specified granularity. Time points without data are filled with 0. The data is sorted in chronological order.</para>
            /// </summary>
            [NameInMap("Trend")]
            [Validation(Required=false)]
            public List<DescribeCustomAgentMonitorMetricsResponseBodyDataTrend> Trend { get; set; }
            public class DescribeCustomAgentMonitorMetricsResponseBodyDataTrend : TeaModel {
                /// <summary>
                /// <para>The number of active users within the statistical period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ActiveUserCount")]
                [Validation(Required=false)]
                public long? ActiveUserCount { get; set; }

                /// <summary>
                /// <para>The number of dislikes within the statistical period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DislikeCount")]
                [Validation(Required=false)]
                public long? DislikeCount { get; set; }

                /// <summary>
                /// <para>The number of likes within the statistical period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LikeCount")]
                [Validation(Required=false)]
                public long? LikeCount { get; set; }

                /// <summary>
                /// <para>The number of sessions within the statistical period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("SessionCount")]
                [Validation(Required=false)]
                public long? SessionCount { get; set; }

                /// <summary>
                /// <para>The statistical time. For daily granularity, the format is 2026-09-01. For hourly granularity, the format is 2026-09-01 13:00.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-01</para>
                /// </summary>
                [NameInMap("StatTime")]
                [Validation(Required=false)]
                public string StatTime { get; set; }

                /// <summary>
                /// <para>The start timestamp of the statistical period (epoch millis).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1782835200000</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code returned when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidTid</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Specified parameter Tid is not valid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>E0D21075-CD3E-4D98-8264-FD8AD04A63B6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
