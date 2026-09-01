// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeKnowledgeBaseAnswerResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>财报的内容总结如下：******</para>
        /// </summary>
        [NameInMap("Answer")]
        [Validation(Required=false)]
        public string Answer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3935</para>
        /// </summary>
        [NameInMap("CompletionTokens")]
        [Validation(Required=false)]
        public int? CompletionTokens { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Space not found: pks-xxxx</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>not_found</para>
        /// </summary>
        [NameInMap("ErrorType")]
        [Validation(Required=false)]
        public string ErrorType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OO1A6p8B******_xPUC</para>
        /// </summary>
        [NameInMap("LLMModelId")]
        [Validation(Required=false)]
        public string LLMModelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2459</para>
        /// </summary>
        [NameInMap("PromptTokens")]
        [Validation(Required=false)]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>R3BGbnBqcXN******.2a5a23c9-******-179970533d30</para>
        /// </summary>
        [NameInMap("QueryId")]
        [Validation(Required=false)]
        public string QueryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CDB3258F-B5DE-43C4-8935-CBA0CA******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Sources")]
        [Validation(Required=false)]
        public List<DescribeKnowledgeBaseAnswerResponseBodySources> Sources { get; set; }
        public class DescribeKnowledgeBaseAnswerResponseBodySources : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ChunkMetadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> ChunkMetadata { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>91b97b71-xxxx-xxxx-xxxx-33c6a6341cdc</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>财报.pdf</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pkb-xxxxx</para>
            /// </summary>
            [NameInMap("KnowledgeBaseId")]
            [Validation(Required=false)]
            public string KnowledgeBaseId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metadata { get; set; }

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
            /// <para>8</para>
            /// </summary>
            [NameInMap("ShardIndex")]
            [Validation(Required=false)]
            public int? ShardIndex { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.75</para>
            /// </summary>
            [NameInMap("SimilarityScore")]
            [Validation(Required=false)]
            public double? SimilarityScore { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SourceId")]
            [Validation(Required=false)]
            public int? SourceId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>COMPLETED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
