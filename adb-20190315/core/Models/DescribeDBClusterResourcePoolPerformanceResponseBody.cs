// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBClusterResourcePoolPerformanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end of the time range for monitoring the resource group. The time follows the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mm:ssZ</em> format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-06-10T07:01:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The queried monitoring information about the metrics.</para>
        /// </summary>
        [NameInMap("Performances")]
        [Validation(Required=false)]
        public List<DescribeDBClusterResourcePoolPerformanceResponseBodyPerformances> Performances { get; set; }
        public class DescribeDBClusterResourcePoolPerformanceResponseBodyPerformances : TeaModel {
            /// <summary>
            /// <para>The metric of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AnalyticDB_RP_CPU</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The queried monitoring information about the resource groups.</para>
            /// </summary>
            [NameInMap("ResourcePoolPerformances")]
            [Validation(Required=false)]
            public List<DescribeDBClusterResourcePoolPerformanceResponseBodyPerformancesResourcePoolPerformances> ResourcePoolPerformances { get; set; }
            public class DescribeDBClusterResourcePoolPerformanceResponseBodyPerformancesResourcePoolPerformances : TeaModel {
                /// <summary>
                /// <para>The name of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_pool</para>
                /// </summary>
                [NameInMap("ResourcePoolName")]
                [Validation(Required=false)]
                public string ResourcePoolName { get; set; }

                /// <summary>
                /// <para>The sequential monitoring information about the resource groups.</para>
                /// </summary>
                [NameInMap("ResourcePoolSeries")]
                [Validation(Required=false)]
                public List<DescribeDBClusterResourcePoolPerformanceResponseBodyPerformancesResourcePoolPerformancesResourcePoolSeries> ResourcePoolSeries { get; set; }
                public class DescribeDBClusterResourcePoolPerformanceResponseBodyPerformancesResourcePoolPerformancesResourcePoolSeries : TeaModel {
                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cpu</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The value of the metric.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

            }

            /// <summary>
            /// <para>The unit of the metric value.</para>
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
        /// <para>C7EDB8E4-9769-4233-88C7-DCA4C9******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range for monitoring the resource group. The time follows the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mm:ssZ</em> format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-06-10T07:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
