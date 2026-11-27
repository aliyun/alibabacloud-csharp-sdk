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
            /// <para>The ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i11857814169474524****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pjlab-lingjun</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The time when the diagnostic task was created. The time follows the ISO 8601 standard. Z in the example indicates UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-15T02:01:12Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The diagnostic content. For example, in the network diagnostic type, the diagnostic content includes static configuration checks and dynamic runtime checks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test diagnostic information</para>
            /// </summary>
            [NameInMap("DiagContent")]
            [Validation(Required=false)]
            public string DiagContent { get; set; }

            /// <summary>
            /// <para>The diagnostic ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("DiagId")]
            [Validation(Required=false)]
            public string DiagId { get; set; }

            /// <summary>
            /// <para>The diagnostic result, which indicates success or failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("DiagResult")]
            [Validation(Required=false)]
            public string DiagResult { get; set; }

            /// <summary>
            /// <para>The time when the diagnostic task was completed. The time follows the ISO 8601 standard. Z in the example indicates UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-16T02:04Z</para>
            /// </summary>
            [NameInMap("FinishedTime")]
            [Validation(Required=false)]
            public string FinishedTime { get; set; }

            /// <summary>
            /// <para>The ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e01-cn-bl03ofg6****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>proxy-rps.mos.csvw.com</para>
            /// </summary>
            [NameInMap("ServerName")]
            [Validation(Required=false)]
            public string ServerName { get; set; }

            /// <summary>
            /// <para>The governance status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>succeed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries to return on each page during paging in a paged query. Valid values: 1 to 100. If you do not specify this parameter in the Settings, the default value is 10. If the specified value is greater than 100, the value 100 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The NextToken value for the next page. Include this value in the request to query the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a3f2224a5ec7224116c4f5246120****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AC4F0004-7BCE-52E0-891B-CAC7D64E3368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
