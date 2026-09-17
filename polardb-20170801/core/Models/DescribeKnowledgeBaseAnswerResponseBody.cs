// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeKnowledgeBaseAnswerResponseBody : TeaModel {
        /// <summary>
        /// <para>Agent ID</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The answer content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The financial report summary is as follows: ******</para>
        /// </summary>
        [NameInMap("Answer")]
        [Validation(Required=false)]
        public string Answer { get; set; }

        /// <summary>
        /// <para>The cumulative number of tokens generated for completion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3935</para>
        /// </summary>
        [NameInMap("CompletionTokens")]
        [Validation(Required=false)]
        public int? CompletionTokens { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Space not found: pks-xxxx</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The error type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>not_found</para>
        /// </summary>
        [NameInMap("ErrorType")]
        [Validation(Required=false)]
        public string ErrorType { get; set; }

        /// <summary>
        /// <para>The large language model ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OO1A6p8B******_xPUC</para>
        /// </summary>
        [NameInMap("LLMModelId")]
        [Validation(Required=false)]
        public string LLMModelId { get; set; }

        /// <summary>
        /// <para>The cumulative number of tokens consumed by the prompt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2459</para>
        /// </summary>
        [NameInMap("PromptTokens")]
        [Validation(Required=false)]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// <para>The unique ID of the Q&amp;A task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>R3BGbnBqcXN******.2a5a23c9-******-179970533d30</para>
        /// </summary>
        [NameInMap("QueryId")]
        [Validation(Required=false)]
        public string QueryId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>CDB3258F-B5DE-43C4-8935-CBA0CA******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of reference sources for the answer.</para>
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public List<DescribeKnowledgeBaseAnswerResponseBodySources> Sources { get; set; }
        public class DescribeKnowledgeBaseAnswerResponseBodySources : TeaModel {
            /// <summary>
            /// <para>The chunk metadata.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ChunkMetadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> ChunkMetadata { get; set; }

            /// <summary>
            /// <para>The file ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>91b97b71-xxxx-xxxx-xxxx-33c6a6341cdc</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinancialReport.pdf</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The list of image resources associated with the referenced chunk in the Q&amp;A.</para>
            /// </summary>
            [NameInMap("ImageResources")]
            [Validation(Required=false)]
            public List<DescribeKnowledgeBaseAnswerResponseBodySourcesImageResources> ImageResources { get; set; }
            public class DescribeKnowledgeBaseAnswerResponseBodySourcesImageResources : TeaModel {
                /// <summary>
                /// <para>The index of the source document to which the image belongs, starting from 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DocumentIndex")]
                [Validation(Required=false)]
                public int? DocumentIndex { get; set; }

                /// <summary>
                /// <para>The unique ID of the image resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>document-0/pictures/1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The element reference of the image in the Docling source document structure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>#/pictures/1</para>
                /// </summary>
                [NameInMap("ItemRef")]
                [Validation(Required=false)]
                public string ItemRef { get; set; }

                /// <summary>
                /// <para>The media type of the image resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>image/png</para>
                /// </summary>
                [NameInMap("MimeType")]
                [Validation(Required=false)]
                public string MimeType { get; set; }

                /// <summary>
                /// <para>The OSS URI of the image resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://my-bucket/results/my-space/doc-001/artifacts/image-1.png</para>
                /// </summary>
                [NameInMap("Uri")]
                [Validation(Required=false)]
                public string Uri { get; set; }

            }

            /// <summary>
            /// <para>The unique ID of the knowledge base.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pkb-xxxxx</para>
            /// </summary>
            [NameInMap("KnowledgeBaseId")]
            [Validation(Required=false)]
            public string KnowledgeBaseId { get; set; }

            /// <summary>
            /// <para>The document metadata.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metadata { get; set; }

            /// <summary>
            /// <para>The list of page numbers to which the chunk belongs.</para>
            /// </summary>
            [NameInMap("PageNumbers")]
            [Validation(Required=false)]
            public List<int?> PageNumbers { get; set; }

            /// <summary>
            /// <para>The chunk content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinancialReport</para>
            /// </summary>
            [NameInMap("ShardContent")]
            [Validation(Required=false)]
            public string ShardContent { get; set; }

            /// <summary>
            /// <para>The chunk ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("ShardIndex")]
            [Validation(Required=false)]
            public int? ShardIndex { get; set; }

            /// <summary>
            /// <para>The similarity score.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.75</para>
            /// </summary>
            [NameInMap("SimilarityScore")]
            [Validation(Required=false)]
            public double? SimilarityScore { get; set; }

            /// <summary>
            /// <para>The source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SourceId")]
            [Validation(Required=false)]
            public int? SourceId { get; set; }

        }

        /// <summary>
        /// <para>The status of the Q&amp;A task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RUNNING: In progress.</description></item>
        /// <item><description>COMPLETED: Completed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>COMPLETED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
