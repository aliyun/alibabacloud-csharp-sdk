// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeDBClusterPerformanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-bp125e3uu94wo****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end time of the query. Format: yyyy-MM-ddTHH:mmZ (UTC time).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-11-27T16:38Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The list of cluster performance metric values.</para>
        /// </summary>
        [NameInMap("Performances")]
        [Validation(Required=false)]
        public List<DescribeDBClusterPerformanceResponseBodyPerformances> Performances { get; set; }
        public class DescribeDBClusterPerformanceResponseBodyPerformances : TeaModel {
            /// <summary>
            /// <para>The name of the performance metrics.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MEM_USAGE</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The name of the performance value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mem_usage</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The collection of performance metrics.</para>
            /// </summary>
            [NameInMap("Series")]
            [Validation(Required=false)]
            public List<DescribeDBClusterPerformanceResponseBodyPerformancesSeries> Series { get; set; }
            public class DescribeDBClusterPerformanceResponseBodyPerformancesSeries : TeaModel {
                /// <summary>
                /// <para>The name of the performance data list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cc-bp125e3uu94wo1s0k16****</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The performance metric values. Each value corresponds to a collection time point.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<DescribeDBClusterPerformanceResponseBodyPerformancesSeriesValues> Values { get; set; }
                public class DescribeDBClusterPerformanceResponseBodyPerformancesSeriesValues : TeaModel {
                    /// <summary>
                    /// <para>The performance value.</para>
                    /// </summary>
                    [NameInMap("Point")]
                    [Validation(Required=false)]
                    public List<string> Point { get; set; }

                }

            }

            /// <summary>
            /// <para>The data unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>%</para>
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE242962-6DA3-5FC8-9691-37B62A3210F7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time of the query. Format: yyyy-MM-ddTHH:mmZ (UTC time).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-11-27T16:37Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
