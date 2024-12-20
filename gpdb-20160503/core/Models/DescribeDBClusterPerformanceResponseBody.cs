// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBClusterPerformanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp12ga6v69h86****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end time of the query. The time follows the ISO 8601 standard in the <c>YYYY-MM-DDTHH:mmZ</c> format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-11-03T15:10Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The name of the performance metric. For more information, see <a href="https://help.aliyun.com/document_detail/86943.html">Performance parameters</a>.</para>
        /// </summary>
        [NameInMap("PerformanceKeys")]
        [Validation(Required=false)]
        public List<DescribeDBClusterPerformanceResponseBodyPerformanceKeys> PerformanceKeys { get; set; }
        public class DescribeDBClusterPerformanceResponseBodyPerformanceKeys : TeaModel {
            /// <summary>
            /// <para>The name of the performance metric. For more information, see <a href="https://help.aliyun.com/document_detail/86943.html">Performance parameters</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adbpg_group_cpu_used_percent</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Details of the performance metric of a node.</para>
            /// </summary>
            [NameInMap("Series")]
            [Validation(Required=false)]
            public List<DescribeDBClusterPerformanceResponseBodyPerformanceKeysSeries> Series { get; set; }
            public class DescribeDBClusterPerformanceResponseBodyPerformanceKeysSeries : TeaModel {
                /// <summary>
                /// <para>The name of the compute node or compute group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>standby-********-cpu</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The role of the node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>master</b>: primary coordinator node</description></item>
                /// <item><description><b>standby</b>: standby coordinator node</description></item>
                /// <item><description><b>segment</b>: compute node</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>standby</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>The value of the performance metric collected at a point in time.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<DescribeDBClusterPerformanceResponseBodyPerformanceKeysSeriesValues> Values { get; set; }
                public class DescribeDBClusterPerformanceResponseBodyPerformanceKeysSeriesValues : TeaModel {
                    /// <summary>
                    /// <para>The value of the performance metric and the time when the metric value was collected.</para>
                    /// </summary>
                    [NameInMap("Point")]
                    [Validation(Required=false)]
                    public List<string> Point { get; set; }

                }

            }

            /// <summary>
            /// <para>The unit of the performance metric.</para>
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
        /// <para>8E8990F0-C81E-4C94-8F51-5F**********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time of the query. The time follows the ISO 8601 standard in the <c>YYYY-MM-DDTHH:mmZ</c> format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-11-03T15:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
