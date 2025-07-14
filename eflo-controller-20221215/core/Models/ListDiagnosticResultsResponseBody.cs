// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListDiagnosticResultsResponseBody : TeaModel {
        /// <summary>
        /// <para>The diagnostic information.</para>
        /// </summary>
        [NameInMap("DiagnosticResults")]
        [Validation(Required=false)]
        public List<ListDiagnosticResultsResponseBodyDiagnosticResults> DiagnosticResults { get; set; }
        public class ListDiagnosticResultsResponseBodyDiagnosticResults : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i118578141694745246055</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>Cluster Name</para>
            /// 
            /// <b>Example:</b>
            /// <para>pjlab-lingjun</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>Creation time of the diagnostic task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-15T02:01:12Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>Diagnostic content. For example, in network diagnostics, there are static configuration checks, dynamic operation checks, and other diagnostic contents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>diagcontent</para>
            /// </summary>
            [NameInMap("DiagContent")]
            [Validation(Required=false)]
            public string DiagContent { get; set; }

            /// <summary>
            /// <para>Diagnosis ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("DiagId")]
            [Validation(Required=false)]
            public string DiagId { get; set; }

            /// <summary>
            /// <para>Diagnostic result, either success or failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("DiagResult")]
            [Validation(Required=false)]
            public string DiagResult { get; set; }

            /// <summary>
            /// <para>Completion time of the diagnostic task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-16T02:04Z</para>
            /// </summary>
            [NameInMap("FinishedTime")]
            [Validation(Required=false)]
            public string FinishedTime { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e01-cn-bl03ofg6206</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>Server name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>proxy-rps.mos.csvw.com</para>
            /// </summary>
            [NameInMap("ServerName")]
            [Validation(Required=false)]
            public string ServerName { get; set; }

            /// <summary>
            /// <para>Status of the diagnostic task. Possible values:</para>
            /// <list type="bullet">
            /// <item><description>InProgress: Diagnosing.</description></item>
            /// <item><description>Finished: Diagnosis completed.</description></item>
            /// <item><description>Failed: Diagnosis failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>succeed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Number of items per page in a paginated query. The maximum value is 100.</para>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description>If no value is set or the set value is less than 20, the default value is 20.</description></item>
        /// <item><description>If the set value is greater than 100, the default value is 100.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>NextToken for the next page. Include this value when requesting the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a3f2224a5ec7224116c4f5246120abe4</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AC4F0004-7BCE-52E0-891B-CAC7D64E3368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
