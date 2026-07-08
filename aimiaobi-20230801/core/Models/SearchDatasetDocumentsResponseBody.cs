// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SearchDatasetDocumentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoData</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SearchDatasetDocumentsResponseBodyData Data { get; set; }
        public class SearchDatasetDocumentsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The document list.</para>
            /// </summary>
            [NameInMap("Documents")]
            [Validation(Required=false)]
            public List<SearchDatasetDocumentsResponseBodyDataDocuments> Documents { get; set; }
            public class SearchDatasetDocumentsResponseBodyDataDocuments : TeaModel {
                /// <summary>
                /// <para>The unique identifier for the category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("CategoryUuid")]
                [Validation(Required=false)]
                public string CategoryUuid { get; set; }

                /// <summary>
                /// <para>The content of the relevant chunk. This field is returned only in <c>chunk</c> mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("Chunk")]
                [Validation(Required=false)]
                public string Chunk { get; set; }

                /// <summary>
                /// <para>A list of relevant chunks from the document. This field is returned only in <c>document</c> mode.</para>
                /// </summary>
                [NameInMap("ChunkInfos")]
                [Validation(Required=false)]
                public List<SearchDatasetDocumentsResponseBodyDataDocumentsChunkInfos> ChunkInfos { get; set; }
                public class SearchDatasetDocumentsResponseBodyDataDocumentsChunkInfos : TeaModel {
                    /// <summary>
                    /// <para>The content of the chunk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("Chunk")]
                    [Validation(Required=false)]
                    public string Chunk { get; set; }

                    /// <summary>
                    /// <para>The relevance score of the chunk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.77</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public double? Score { get; set; }

                }

                /// <summary>
                /// <para>The content of the document.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The user-defined unique ID for the document.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("DocId")]
                [Validation(Required=false)]
                public string DocId { get; set; }

                /// <summary>
                /// <para>The document type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("DocType")]
                [Validation(Required=false)]
                public string DocType { get; set; }

                /// <summary>
                /// <para>The unique system ID of the document.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("DocUuid")]
                [Validation(Required=false)]
                public string DocUuid { get; set; }

                /// <summary>
                /// <para>Custom extension field 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("Extend1")]
                [Validation(Required=false)]
                public string Extend1 { get; set; }

                /// <summary>
                /// <para>Custom extension field 2.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("Extend2")]
                [Validation(Required=false)]
                public string Extend2 { get; set; }

                /// <summary>
                /// <para>Custom extension field 3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("Extend3")]
                [Validation(Required=false)]
                public string Extend3 { get; set; }

                /// <summary>
                /// <para>The publication time, in <c>yyyy-MM-dd HH:mm:ss</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-12-09 17:09:40</para>
                /// </summary>
                [NameInMap("PubTime")]
                [Validation(Required=false)]
                public string PubTime { get; set; }

                /// <summary>
                /// <para>The relevance score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                /// <summary>
                /// <para>The unique identifier for the dataset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("SearchSource")]
                [Validation(Required=false)]
                public string SearchSource { get; set; }

                /// <summary>
                /// <para>The name of the dataset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("SearchSourceName")]
                [Validation(Required=false)]
                public string SearchSourceName { get; set; }

                /// <summary>
                /// <para>The dataset type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("SearchSourceType")]
                [Validation(Required=false)]
                public string SearchSourceType { get; set; }

                /// <summary>
                /// <para>The source of the document.</para>
                /// 
                /// <b>Example:</b>
                /// <para>来源</para>
                /// </summary>
                [NameInMap("SourceFrom")]
                [Validation(Required=false)]
                public string SourceFrom { get; set; }

                /// <summary>
                /// <para>The summary of the document.</para>
                /// 
                /// <b>Example:</b>
                /// <para>文章摘要</para>
                /// </summary>
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                /// <summary>
                /// <para>A list of tags.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

                /// <summary>
                /// <para>The title of the document.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The URL of the document.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The status message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates if the request succeeded (<c>true</c>) or failed (<c>false</c>).</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
