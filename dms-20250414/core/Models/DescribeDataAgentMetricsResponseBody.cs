// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DescribeDataAgentMetricsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDataAgentMetricsResponseBodyData Data { get; set; }
        public class DescribeDataAgentMetricsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The end time of the query range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1782836200000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The metric type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>basic</para>
            /// </summary>
            [NameInMap("MetricType")]
            [Validation(Required=false)]
            public string MetricType { get; set; }

            /// <summary>
            /// <para>The list of metrics.</para>
            /// </summary>
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public List<DescribeDataAgentMetricsResponseBodyDataMetrics> Metrics { get; set; }
            public class DescribeDataAgentMetricsResponseBodyDataMetrics : TeaModel {
                /// <summary>
                /// <para>The error message returned when the call fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Timeout</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The metric name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>data_agent_session_per_user</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>Indicates whether the request is successful.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

                /// <summary>
                /// <para>The metric value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The start time of the query range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1782835200000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <para>The error code returned when the request is abnormal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
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
        /// <para>67E910F2-4B62-5B0C-ACA3-7547695C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
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
