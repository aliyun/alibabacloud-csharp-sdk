// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListDiagnosticResultsResponseBody : TeaModel {
        [NameInMap("DiagnosticResults")]
        [Validation(Required=false)]
        public List<ListDiagnosticResultsResponseBodyDiagnosticResults> DiagnosticResults { get; set; }
        public class ListDiagnosticResultsResponseBodyDiagnosticResults : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>i118578141694745246055</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pjlab-lingjun</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-01-15T02:01:12Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("DiagContent")]
            [Validation(Required=false)]
            public string DiagContent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("DiagId")]
            [Validation(Required=false)]
            public string DiagId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("DiagResult")]
            [Validation(Required=false)]
            public string DiagResult { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-10-16T02:04Z</para>
            /// </summary>
            [NameInMap("FinishedTime")]
            [Validation(Required=false)]
            public string FinishedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>e01-cn-bl03ofg6206</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>proxy-rps.mos.csvw.com</para>
            /// </summary>
            [NameInMap("ServerName")]
            [Validation(Required=false)]
            public string ServerName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>succeed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a3f2224a5ec7224116c4f5246120abe4</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>AC4F0004-7BCE-52E0-891B-CAC7D64E3368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
