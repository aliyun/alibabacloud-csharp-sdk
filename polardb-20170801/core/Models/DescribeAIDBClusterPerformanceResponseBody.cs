// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAIDBClusterPerformanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The API key for the model service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The ID of the database cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-a************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The type of the database engine. Only <b>polardb_ai</b> is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polardb_ai</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// <para>The version number of the database AI engine.</para>
        /// <para>Example: 3.0</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.0</para>
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// <para>The end of the time range that was queried. The time is in the <c>YYYY-MM-DDThh:mmZ</c> format and is in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-11-16T16:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity of the performance data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>60</description></item>
        /// <item><description>3600</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The details of the instance performance parameters.</para>
        /// </summary>
        [NameInMap("PerformanceKeys")]
        [Validation(Required=false)]
        public List<DescribeAIDBClusterPerformanceResponseBodyPerformanceKeys> PerformanceKeys { get; set; }
        public class DescribeAIDBClusterPerformanceResponseBodyPerformanceKeys : TeaModel {
            /// <summary>
            /// <para>The ID of the cluster node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pi-*************</para>
            /// </summary>
            [NameInMap("DBNodeId")]
            [Validation(Required=false)]
            public string DBNodeId { get; set; }

            /// <summary>
            /// <para>The performance metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PolarDBAIModelCall</para>
            /// </summary>
            [NameInMap("Measurement")]
            [Validation(Required=false)]
            public string Measurement { get; set; }

            /// <summary>
            /// <para>The name of the specific performance metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>model_input_amount</para>
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>The array of performance data.</para>
            /// </summary>
            [NameInMap("Points")]
            [Validation(Required=false)]
            public List<DescribeAIDBClusterPerformanceResponseBodyPerformanceKeysPoints> Points { get; set; }
            public class DescribeAIDBClusterPerformanceResponseBodyPerformanceKeysPoints : TeaModel {
                /// <summary>
                /// <para>The UNIX timestamp that indicates when the metric was collected. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1724206183</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// <para>The value of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>42.38</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D0CEC6AC-7760-409A-A0D5-E6CD86******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range that was queried. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format and is in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-11-15T16:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
