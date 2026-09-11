// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class RetrievalKnowledgeBaseResponseBody : TeaModel {
        /// <summary>
        /// <para>The query text.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Financial report</para>
        /// </summary>
        [NameInMap("QueryText")]
        [Validation(Required=false)]
        public string QueryText { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD35F3-F3-44CA-AFFF-BAF869******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ResultCount")]
        [Validation(Required=false)]
        public int? ResultCount { get; set; }

        /// <summary>
        /// <para>The search results.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<RetrievalKnowledgeBaseResponseBodyResults> Results { get; set; }
        public class RetrievalKnowledgeBaseResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The list of figure or table captions associated with the chunk.</para>
            /// </summary>
            [NameInMap("Captions")]
            [Validation(Required=false)]
            public List<string> Captions { get; set; }

            /// <summary>
            /// <para>The list of Docling source document structured element references associated with the chunk. You can use these references to precisely locate elements in the original document.</para>
            /// </summary>
            [NameInMap("DocItems")]
            [Validation(Required=false)]
            public List<string> DocItems { get; set; }

            /// <summary>
            /// <para>The unique identifier of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>91b97b71-xxxx-xxxx-xxxx-33c6a6341cdc</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The name of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024FinancialReport.pdf</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The chain of section headings to which the chunk belongs.</para>
            /// </summary>
            [NameInMap("Headings")]
            [Validation(Required=false)]
            public List<string> Headings { get; set; }

            /// <summary>
            /// <para>The list of image resources referenced by the chunk.</para>
            /// </summary>
            [NameInMap("ImageResources")]
            [Validation(Required=false)]
            public List<RetrievalKnowledgeBaseResponseBodyResultsImageResources> ImageResources { get; set; }
            public class RetrievalKnowledgeBaseResponseBodyResultsImageResources : TeaModel {
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
                /// <para>The unique identifier of the image resource.</para>
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
            /// <para>The metadata.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public string Metadata { get; set; }

            /// <summary>
            /// <para>The list of page numbers to which the chunk belongs.</para>
            /// </summary>
            [NameInMap("PageNumbers")]
            [Validation(Required=false)]
            public List<int?> PageNumbers { get; set; }

            /// <summary>
            /// <para>The text content of the chunk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Financial report</para>
            /// </summary>
            [NameInMap("ShardContent")]
            [Validation(Required=false)]
            public string ShardContent { get; set; }

            /// <summary>
            /// <para>The index of the chunk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ShardIndex")]
            [Validation(Required=false)]
            public int? ShardIndex { get; set; }

            /// <summary>
            /// <para>The similarity score.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.8</para>
            /// </summary>
            [NameInMap("SimilarityScore")]
            [Validation(Required=false)]
            public double? SimilarityScore { get; set; }

        }

    }

}
