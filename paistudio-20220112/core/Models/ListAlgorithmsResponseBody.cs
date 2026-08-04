// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListAlgorithmsResponseBody : TeaModel {
        /// <summary>
        /// <para>Algorithm list.</para>
        /// </summary>
        [NameInMap("Algorithms")]
        [Validation(Required=false)]
        public List<ListAlgorithmsResponseBodyAlgorithms> Algorithms { get; set; }
        public class ListAlgorithmsResponseBodyAlgorithms : TeaModel {
            /// <summary>
            /// <para>Algorithm description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Large language model training.</para>
            /// </summary>
            [NameInMap("AlgorithmDescription")]
            [Validation(Required=false)]
            public string AlgorithmDescription { get; set; }

            /// <summary>
            /// <para>Algorithm ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>algo-sidjc8134hv</para>
            /// </summary>
            [NameInMap("AlgorithmId")]
            [Validation(Required=false)]
            public string AlgorithmId { get; set; }

            /// <summary>
            /// <para>Algorithm name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>llm_train</para>
            /// </summary>
            [NameInMap("AlgorithmName")]
            [Validation(Required=false)]
            public string AlgorithmName { get; set; }

            /// <summary>
            /// <para>Algorithm provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pai</para>
            /// </summary>
            [NameInMap("AlgorithmProvider")]
            [Validation(Required=false)]
            public string AlgorithmProvider { get; set; }

            /// <summary>
            /// <para>Algorithm display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LLM Train</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>Algorithm creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-07-21T03:35:24Z</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>Algorithm update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-07-25T02:15:40Z</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <para>Algorithm owner ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>Workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total algorithms.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
