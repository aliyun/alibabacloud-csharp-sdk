// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class QueryContentResponseBody : TeaModel {
        /// <summary>
        /// <para>Number of tokens used for vectorization.</para>
        /// <remarks>
        /// <para>A token refers to the smallest unit into which the input text is divided; a token can be a word, a phrase, a punctuation mark, or a character, etc.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("EmbeddingTokens")]
        [Validation(Required=false)]
        public string EmbeddingTokens { get; set; }

        /// <summary>
        /// <para>The retrieved data.</para>
        /// </summary>
        [NameInMap("Matches")]
        [Validation(Required=false)]
        public QueryContentResponseBodyMatches Matches { get; set; }
        public class QueryContentResponseBodyMatches : TeaModel {
            [NameInMap("MatchList")]
            [Validation(Required=false)]
            public List<QueryContentResponseBodyMatchesMatchList> MatchList { get; set; }
            public class QueryContentResponseBodyMatchesMatchList : TeaModel {
                /// <summary>
                /// <para>The content that is used for full-text search. If you leave this parameter empty, only vector search is used. If you do not leave this parameter empty, two-way retrieval based on vector search and full-text search is used.</para>
                /// <remarks>
                /// <para> You must specify at least one of the Content and Vector parameters.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Cloud-native data warehouse AnalyticDB PostgreSQL Edition provides a simple, fast, and cost-effective PB-level cloud data warehouse solution.</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The name of the document.</para>
                /// <remarks>
                /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2618453.html">ListDocuments</a> operation to query a list of documents.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>my_doc.txt</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The public URL of the query result image, valid for 2 hours</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://xxx-cn-beijing.aliyuncs.com/image/test.png">https://xxx-cn-beijing.aliyuncs.com/image/test.png</a></para>
                /// </summary>
                [NameInMap("FileURL")]
                [Validation(Required=false)]
                public string FileURL { get; set; }

                /// <summary>
                /// <para>The unique ID of the vector data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>doca-1234</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Metadata during document loader loading.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;page_pos&quot;: 1}</para>
                /// </summary>
                [NameInMap("LoaderMetadata")]
                [Validation(Required=false)]
                public string LoaderMetadata { get; set; }

                /// <summary>
                /// <para>The metadata.</para>
                /// </summary>
                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public Dictionary<string, string> Metadata { get; set; }

                /// <summary>
                /// <para>Re-ranking score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6.2345</para>
                /// </summary>
                [NameInMap("RerankScore")]
                [Validation(Required=false)]
                public double? RerankScore { get; set; }

                /// <summary>
                /// <para>Source of the retrieval results:</para>
                /// <list type="bullet">
                /// <item><description>1 indicates vector retrieval</description></item>
                /// <item><description>2 indicates full-text retrieval</description></item>
                /// <item><description>3 indicates dual-path recall</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RetrievalSource")]
                [Validation(Required=false)]
                public int? RetrievalSource { get; set; }

                /// <summary>
                /// <para>The similarity score of the data. It is related to the <c>l2, ip, or cosine</c> algorithm that is specified when you create an index.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.12345</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                /// <summary>
                /// <para>The vector data. The length of the value must be the same as that of the Dimension parameter in the <a href="https://help.aliyun.com/document_detail/2401497.html">CreateCollection</a> operation.</para>
                /// <remarks>
                /// <para> If you leave this parameter empty, only full-text search results are returned.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Vector")]
                [Validation(Required=false)]
                public QueryContentResponseBodyMatchesMatchListVector Vector { get; set; }
                public class QueryContentResponseBodyMatchesMatchListVector : TeaModel {
                    [NameInMap("VectorList")]
                    [Validation(Required=false)]
                    public List<double?> VectorList { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>Return message.</para>
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
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The execution state of the operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: The operation fails.</description></item>
        /// <item><description><b>true</b>: The operation is successful.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Resource usage for this query.</para>
        /// </summary>
        [NameInMap("Usage")]
        [Validation(Required=false)]
        public QueryContentResponseBodyUsage Usage { get; set; }
        public class QueryContentResponseBodyUsage : TeaModel {
            /// <summary>
            /// <para>The number of entries used for vectorization.</para>
            /// <remarks>
            /// <para>An entry refers to the number of processing items when performing vectorization on text or images. For example, processing one piece of text counts as 1 entry, while processing one image counts as 2 entries.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("EmbeddingEntries")]
            [Validation(Required=false)]
            public string EmbeddingEntries { get; set; }

            /// <summary>
            /// <para>Number of tokens used for vectorization.</para>
            /// <remarks>
            /// <para>A token refers to the smallest unit into which the input text is divided; a token can be a word, a phrase, a punctuation mark, or a character, etc.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("EmbeddingTokens")]
            [Validation(Required=false)]
            public string EmbeddingTokens { get; set; }

        }

        /// <summary>
        /// <para>List of windowed matches.</para>
        /// </summary>
        [NameInMap("WindowMatches")]
        [Validation(Required=false)]
        public QueryContentResponseBodyWindowMatches WindowMatches { get; set; }
        public class QueryContentResponseBodyWindowMatches : TeaModel {
            [NameInMap("windowMatches")]
            [Validation(Required=false)]
            public List<QueryContentResponseBodyWindowMatchesWindowMatches> WindowMatches { get; set; }
            public class QueryContentResponseBodyWindowMatchesWindowMatches : TeaModel {
                /// <summary>
                /// <para>List of individual top windowed matches.</para>
                /// </summary>
                [NameInMap("WindowMatch")]
                [Validation(Required=false)]
                public QueryContentResponseBodyWindowMatchesWindowMatchesWindowMatch WindowMatch { get; set; }
                public class QueryContentResponseBodyWindowMatchesWindowMatchesWindowMatch : TeaModel {
                    [NameInMap("windowMatch")]
                    [Validation(Required=false)]
                    public List<QueryContentResponseBodyWindowMatchesWindowMatchesWindowMatchWindowMatch> WindowMatch { get; set; }
                    public class QueryContentResponseBodyWindowMatchesWindowMatchesWindowMatchWindowMatch : TeaModel {
                        /// <summary>
                        /// <para>Text content.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>AnalyticDB for PostgreSQL is a cloud-native data warehouse service that provides large-scale parallel processing (MPP) capabilities for massive online data analysis.</para>
                        /// </summary>
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// <para>File name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>my_doc.txt</para>
                        /// </summary>
                        [NameInMap("FileName")]
                        [Validation(Required=false)]
                        public string FileName { get; set; }

                        /// <summary>
                        /// <para>Unique ID of the vector data.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>doca-2345</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>Metadata information when the document loader was loaded.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{&quot;page_pos&quot;: 2}</para>
                        /// </summary>
                        [NameInMap("LoaderMetadata")]
                        [Validation(Required=false)]
                        public string LoaderMetadata { get; set; }

                        /// <summary>
                        /// <para>Metadata map.</para>
                        /// </summary>
                        [NameInMap("Metadata")]
                        [Validation(Required=false)]
                        public Dictionary<string, string> Metadata { get; set; }

                    }

                }

            }

        }

    }

}
