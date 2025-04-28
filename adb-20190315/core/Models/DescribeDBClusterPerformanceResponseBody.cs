// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBClusterPerformanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the request denial. This parameter is returned only if Resource Access Management (RAM) permission verification failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;AuthAction&quot;: &quot;xxx&quot;,
        ///   &quot;AuthPrincipalDisplayName&quot;: &quot;sampleName&quot;,
        ///   &quot;AuthPrincipalOwnerId&quot;: &quot;111111111111111111&quot;,
        ///   &quot;AuthPrincipalType&quot;: &quot;SubUser&quot;,
        ///   &quot;AuthResource&quot;: &quot;xxx&quot;,
        ///   &quot;NoPermissionType&quot;: &quot;xxx&quot;,
        ///   &quot;PolicyType&quot;: &quot;xxx&quot;
        /// }</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end time of the query. The time follows the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mm:ssZ</em> format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-03T15:01:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The queried performance metrics.</para>
        /// </summary>
        [NameInMap("Performances")]
        [Validation(Required=false)]
        public List<DescribeDBClusterPerformanceResponseBodyPerformances> Performances { get; set; }
        public class DescribeDBClusterPerformanceResponseBodyPerformances : TeaModel {
            /// <summary>
            /// <para>The name of the performance metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AnalyticDB_CPU</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The queried performance metric data.</para>
            /// </summary>
            [NameInMap("Series")]
            [Validation(Required=false)]
            public List<DescribeDBClusterPerformanceResponseBodyPerformancesSeries> Series { get; set; }
            public class DescribeDBClusterPerformanceResponseBodyPerformancesSeries : TeaModel {
                /// <summary>
                /// <para>The name of the performance metric value. For more information about the performance metrics, see <a href="https://help.aliyun.com/document_detail/2863211.html">Metric overview</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>worker_avg_cpu_used</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The tags that are added to the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instance_name: &quot;amv-8vbf80pjcz*****&quot;</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                /// <summary>
                /// <para>The key that is used to obtain the name of the performance metric value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>elastic_executor_avg_cpu_use</para>
                /// </summary>
                [NameInMap("TranslateKey")]
                [Validation(Required=false)]
                public string TranslateKey { get; set; }

                /// <summary>
                /// <para>The values of the queried performance metric.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

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
        /// <para>25B56BC7-4978-40B3-9E48-4B7067******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time of the query. The time follows the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mm:ssZ</em> format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-03T15:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
