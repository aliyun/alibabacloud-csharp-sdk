// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAgenticDBPerformanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The AgenticDB cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end time of the query. Specify the time in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-09-23T01:01:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("PerformanceKeys")]
        [Validation(Required=false)]
        public DescribeAgenticDBPerformanceResponseBodyPerformanceKeys PerformanceKeys { get; set; }
        public class DescribeAgenticDBPerformanceResponseBodyPerformanceKeys : TeaModel {
            [NameInMap("performanceKeys")]
            [Validation(Required=false)]
            public List<DescribeAgenticDBPerformanceResponseBodyPerformanceKeysPerformanceKeys> PerformanceKeys { get; set; }
            public class DescribeAgenticDBPerformanceResponseBodyPerformanceKeysPerformanceKeys : TeaModel {
                [NameInMap("BranchId")]
                [Validation(Required=false)]
                public string BranchId { get; set; }

                [NameInMap("EndpointId")]
                [Validation(Required=false)]
                public string EndpointId { get; set; }

                [NameInMap("Measurement")]
                [Validation(Required=false)]
                public string Measurement { get; set; }

                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                [NameInMap("Points")]
                [Validation(Required=false)]
                public DescribeAgenticDBPerformanceResponseBodyPerformanceKeysPerformanceKeysPoints Points { get; set; }
                public class DescribeAgenticDBPerformanceResponseBodyPerformanceKeysPerformanceKeysPoints : TeaModel {
                    [NameInMap("points")]
                    [Validation(Required=false)]
                    public List<DescribeAgenticDBPerformanceResponseBodyPerformanceKeysPerformanceKeysPointsPoints> Points { get; set; }
                    public class DescribeAgenticDBPerformanceResponseBodyPerformanceKeysPerformanceKeysPointsPoints : TeaModel {
                        [NameInMap("Timestamp")]
                        [Validation(Required=false)]
                        public long? Timestamp { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2F029645-FED9-4FE8-A6D3-488954******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time of the query. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format and in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-09-23T01:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
