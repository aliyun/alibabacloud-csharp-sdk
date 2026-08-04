// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListAlgorithmVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of algorithm version details.</para>
        /// </summary>
        [NameInMap("AlgorithmVersions")]
        [Validation(Required=false)]
        public List<ListAlgorithmVersionsResponseBodyAlgorithmVersions> AlgorithmVersions { get; set; }
        public class ListAlgorithmVersionsResponseBodyAlgorithmVersions : TeaModel {
            /// <summary>
            /// <para>The algorithm ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>algo-sidjc8134hv</para>
            /// </summary>
            [NameInMap("AlgorithmId")]
            [Validation(Required=false)]
            public string AlgorithmId { get; set; }

            /// <summary>
            /// <para>The algorithm name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>llm_train</para>
            /// </summary>
            [NameInMap("AlgorithmName")]
            [Validation(Required=false)]
            public string AlgorithmName { get; set; }

            /// <summary>
            /// <para>The algorithm provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pai</para>
            /// </summary>
            [NameInMap("AlgorithmProvider")]
            [Validation(Required=false)]
            public string AlgorithmProvider { get; set; }

            /// <summary>
            /// <para>The algorithm version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v0.1.0</para>
            /// </summary>
            [NameInMap("AlgorithmVersion")]
            [Validation(Required=false)]
            public string AlgorithmVersion { get; set; }

            /// <summary>
            /// <para>The time when the algorithm was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-19T02:00:26Z</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The time when the algorithm was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-22T02:00:59Z</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <para>The tenant ID that owns the algorithm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>The user ID that owns the algorithm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of algorithm versions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
