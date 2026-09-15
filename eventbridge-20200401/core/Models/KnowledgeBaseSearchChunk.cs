// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class KnowledgeBaseSearchChunk : TeaModel {
        /// <summary>
        /// <para>The sequence number of the chunk within the document.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("ChunkSeq")]
        [Validation(Required=false)]
        public int? ChunkSeq { get; set; }

        /// <summary>
        /// <para>The body content of the hit chunk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EventBridge supports routing events to multiple target services</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The ID of the document to which the hit chunk belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>doc-bp1xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("DocumentId")]
        [Validation(Required=false)]
        public string DocumentId { get; set; }

        /// <summary>
        /// <para>The file name of the document to which the hit chunk belongs. This value has the same source as the FileName returned by GetDocument and can be used to render the reference source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>product-handbook.pdf</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The retrieval relevance score. A higher score indicates higher relevance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.92</para>
        /// </summary>
        [NameInMap("Score")]
        [Validation(Required=false)]
        public double? Score { get; set; }

        /// <summary>
        /// <para>The score details for each stage. Score fields that are not involved in the calculation are not returned.</para>
        /// </summary>
        [NameInMap("Scores")]
        [Validation(Required=false)]
        public KnowledgeBaseSearchChunkScores Scores { get; set; }
        public class KnowledgeBaseSearchChunkScores : TeaModel {
            /// <summary>
            /// <para>The score after hybrid search fusion (reciprocal rank fusion or weighted normalization, depending on the active fusion algorithm). Value range: [0, 1].</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.78</para>
            /// </summary>
            [NameInMap("Fusion")]
            [Validation(Required=false)]
            public double? Fusion { get; set; }

            /// <summary>
            /// <para>The normalized score of keyword (full-text) search. Value range: [0, 1].</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.62</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public double? Keyword { get; set; }

            /// <summary>
            /// <para>The score assigned by the rerank model. Value range: [0, 1].</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.91</para>
            /// </summary>
            [NameInMap("Rerank")]
            [Validation(Required=false)]
            public double? Rerank { get; set; }

            /// <summary>
            /// <para>The similarity score of vector retrieval. Value range: [0, 1].</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.85</para>
            /// </summary>
            [NameInMap("Vector")]
            [Validation(Required=false)]
            public double? Vector { get; set; }

        }

        /// <summary>
        /// <para>The location of the chunk in the original document. p.N indicates page N (PDF). s.N indicates slide N (PPT/PPTX).</para>
        /// 
        /// <b>Example:</b>
        /// <para>p.3</para>
        /// </summary>
        [NameInMap("SourceLocation")]
        [Validation(Required=false)]
        public string SourceLocation { get; set; }

        /// <summary>
        /// <para>The title path to which the chunk belongs, such as Chapter 1&gt;1.1 Overview.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Installation Guide&gt;Prerequisites</para>
        /// </summary>
        [NameInMap("TitlePath")]
        [Validation(Required=false)]
        public string TitlePath { get; set; }

    }

}
