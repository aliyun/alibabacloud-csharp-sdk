// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAbnormalPatternDetectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-xxxx</para>
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
            /// <para>The name of the detection item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Cost</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The detection result items.</para>
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<DescribeAbnormalPatternDetectionResponseBodyDetectionItemsResults> Results { get; set; }
            public class DescribeAbnormalPatternDetectionResponseBodyDetectionItemsResults : TeaModel {
                /// <summary>
                /// <para>The IP address of the SQL client that submits the SQL pattern.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.16.133.168</para>
                /// </summary>
                [NameInMap("AccessIp")]
                [Validation(Required=false)]
                public string AccessIp { get; set; }

                /// <summary>
                /// <para>The description of the detection result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Two SQL patterns that have abnormal totalTime metric values are detected. This may result in increased CPU utilization, query slowdown, and degraded system stability. Go to the monitoring page to diagnose the issue and then perform optimization.</para>
                /// </summary>
                [NameInMap("Detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                /// <summary>
                /// <para>The number of failed SQL patterns within the time range.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("FailedCount")]
                [Validation(Required=false)]
                public long? FailedCount { get; set; }

                /// <summary>
                /// <para>The SQL pattern ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2803084667741875187</para>
                /// </summary>
                [NameInMap("PatternId")]
                [Validation(Required=false)]
                public string PatternId { get; set; }

                /// <summary>
                /// <para>The number of queries.</para>
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
                /// <para>SELECT <c>tsid</c>nFROM <c>prod_ods_marketing_engine_material</c>nWHERE <c>tsid</c> = ?nLIMIT ?</para>
                /// </summary>
                [NameInMap("SQLPattern")]
                [Validation(Required=false)]
                public string SQLPattern { get; set; }

                /// <summary>
                /// <para>The names of tables.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dw_student_exam.ods_school_queanal</para>
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

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19B824E0-690D-5A78-9992-5398C2F43694</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
