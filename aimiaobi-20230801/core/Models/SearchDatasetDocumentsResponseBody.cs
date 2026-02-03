// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SearchDatasetDocumentsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>NoData</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SearchDatasetDocumentsResponseBodyData Data { get; set; }
        public class SearchDatasetDocumentsResponseBodyData : TeaModel {
            [NameInMap("Documents")]
            [Validation(Required=false)]
            public List<SearchDatasetDocumentsResponseBodyDataDocuments> Documents { get; set; }
            public class SearchDatasetDocumentsResponseBodyDataDocuments : TeaModel {
                [NameInMap("CategoryUuid")]
                [Validation(Required=false)]
                public string CategoryUuid { get; set; }

                [NameInMap("Chunk")]
                [Validation(Required=false)]
                public string Chunk { get; set; }

                [NameInMap("ChunkInfos")]
                [Validation(Required=false)]
                public List<SearchDatasetDocumentsResponseBodyDataDocumentsChunkInfos> ChunkInfos { get; set; }
                public class SearchDatasetDocumentsResponseBodyDataDocumentsChunkInfos : TeaModel {
                    [NameInMap("Chunk")]
                    [Validation(Required=false)]
                    public string Chunk { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public double? Score { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>用户指定的文档唯一ID</para>
                /// </summary>
                [NameInMap("DocId")]
                [Validation(Required=false)]
                public string DocId { get; set; }

                [NameInMap("DocType")]
                [Validation(Required=false)]
                public string DocType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>内部文档唯一ID</para>
                /// </summary>
                [NameInMap("DocUuid")]
                [Validation(Required=false)]
                public string DocUuid { get; set; }

                [NameInMap("Extend1")]
                [Validation(Required=false)]
                public string Extend1 { get; set; }

                [NameInMap("Extend2")]
                [Validation(Required=false)]
                public string Extend2 { get; set; }

                [NameInMap("Extend3")]
                [Validation(Required=false)]
                public string Extend3 { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-12-09 17:09:40</para>
                /// </summary>
                [NameInMap("PubTime")]
                [Validation(Required=false)]
                public string PubTime { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                [NameInMap("SearchSource")]
                [Validation(Required=false)]
                public string SearchSource { get; set; }

                [NameInMap("SearchSourceName")]
                [Validation(Required=false)]
                public string SearchSourceName { get; set; }

                [NameInMap("SearchSourceType")]
                [Validation(Required=false)]
                public string SearchSourceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>来源</para>
                /// </summary>
                [NameInMap("SourceFrom")]
                [Validation(Required=false)]
                public string SourceFrom { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>文章摘要</para>
                /// </summary>
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
