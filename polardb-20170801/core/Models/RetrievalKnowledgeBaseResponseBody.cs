// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class RetrievalKnowledgeBaseResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>财报</para>
        /// </summary>
        [NameInMap("QueryText")]
        [Validation(Required=false)]
        public string QueryText { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CD35F3-F3-44CA-AFFF-BAF869******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ResultCount")]
        [Validation(Required=false)]
        public int? ResultCount { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<RetrievalKnowledgeBaseResponseBodyResults> Results { get; set; }
        public class RetrievalKnowledgeBaseResponseBodyResults : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>91b97b71-xxxx-xxxx-xxxx-33c6a6341cdc</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024财报.pdf</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("Headings")]
            [Validation(Required=false)]
            public List<string> Headings { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public string Metadata { get; set; }

            [NameInMap("PageNumbers")]
            [Validation(Required=false)]
            public List<int?> PageNumbers { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>财报</para>
            /// </summary>
            [NameInMap("ShardContent")]
            [Validation(Required=false)]
            public string ShardContent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ShardIndex")]
            [Validation(Required=false)]
            public int? ShardIndex { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.8</para>
            /// </summary>
            [NameInMap("SimilarityScore")]
            [Validation(Required=false)]
            public double? SimilarityScore { get; set; }

        }

    }

}
