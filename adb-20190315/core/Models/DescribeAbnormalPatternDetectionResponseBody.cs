// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeAbnormalPatternDetectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-xxxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The queried detection items and detection results.</para>
        /// </summary>
        [NameInMap("DetectionItems")]
        [Validation(Required=false)]
        public List<DescribeAbnormalPatternDetectionResponseBodyDetectionItems> DetectionItems { get; set; }
        public class DescribeAbnormalPatternDetectionResponseBodyDetectionItems : TeaModel {
            /// <summary>
            /// <para>The description of the detection result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Two SQL patterns that have abnormal totalTime metric values are detected. This may result in increased CPU utilization, query slowdown, and degraded system stability. Go to the monitoring page to diagnose the issue and then perform optimization.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The name of the detection item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Cost，PeakMemory</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The detection result.</para>
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<DescribeAbnormalPatternDetectionResponseBodyDetectionItemsResults> Results { get; set; }
            public class DescribeAbnormalPatternDetectionResponseBodyDetectionItemsResults : TeaModel {
                /// <summary>
                /// <para>The IP address of the SQL client that submits the SQL pattern.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11.81.238.102</para>
                /// </summary>
                [NameInMap("AccessIp")]
                [Validation(Required=false)]
                public string AccessIp { get; set; }

                /// <summary>
                /// <para>The details about the detection report of the SQL pattern.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                /// <summary>
                /// <para>The number of failed SQL patterns within the time range.</para>
                /// 
                /// <b>Example:</b>
                /// <para>63</para>
                /// </summary>
                [NameInMap("FailedCount")]
                [Validation(Required=false)]
                public long? FailedCount { get; set; }

                /// <summary>
                /// <para>The SQL pattern ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5495577090378760322</para>
                /// </summary>
                [NameInMap("PatternId")]
                [Validation(Required=false)]
                public string PatternId { get; set; }

                /// <summary>
                /// <para>The number of executed SQL patterns within the time range.</para>
                /// 
                /// <b>Example:</b>
                /// <para>72</para>
                /// </summary>
                [NameInMap("QueryCount")]
                [Validation(Required=false)]
                public long? QueryCount { get; set; }

                /// <summary>
                /// <para>The metrics related to the SQL pattern.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Maximum query duration: 1.43s
                /// Maximum peak memory: 20.73 MB
                /// Maximum read table data: 10.12 MB</para>
                /// </summary>
                [NameInMap("RelatedMetrics")]
                [Validation(Required=false)]
                public string RelatedMetrics { get; set; }

                /// <summary>
                /// <para>The SQL statement that represents the SQL pattern.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT *nFROM HIVE.<c>ADB_EXTERNAL_TPCH_10GB</c>.<c>External_customer</c>nLIMIT ?</para>
                /// </summary>
                [NameInMap("SQLPattern")]
                [Validation(Required=false)]
                public string SQLPattern { get; set; }

                /// <summary>
                /// <para>The names of tables.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ad_marketing_engine.prod_dws_oe_promotion_daily_trend_report</para>
                /// </summary>
                [NameInMap("Tables")]
                [Validation(Required=false)]
                public string Tables { get; set; }

                /// <summary>
                /// <para>The name of the database account that is used to submit the query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("User")]
                [Validation(Required=false)]
                public string User { get; set; }

            }

            /// <summary>
            /// <para>The severity level of the detection result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NORMAL</description></item>
            /// <item><description>WARNING</description></item>
            /// <item><description>CRITICAL</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL
            /// WARNNING
            /// CRITICAL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36B66482-A215-5F04-A42E-859983D89D7B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
