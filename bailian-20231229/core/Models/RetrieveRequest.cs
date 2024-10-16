// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class RetrieveRequest : TeaModel {
        /// <summary>
        /// <para>Vector retrieval top K. After generating vectors based on input text, the top K chunks in the knowledge base that are most similar to the vector representation of the input text are retrieved. Valid values: 0 to 100. The sum of the <c>DenseSimilarityTopK</c> and <c>SparseSimilarityTopK</c> parameters must be less than or equal to 200.</para>
        /// <para>Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("DenseSimilarityTopK")]
        [Validation(Required=false)]
        public int? DenseSimilarityTopK { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable reranking. For more information, see <a href="https://help.aliyun.com/zh/model-studio/user-guide/rag-knowledge-base">Create a knowledge base</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableReranking")]
        [Validation(Required=false)]
        public bool? EnableReranking { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable multi-round conversation rewriting. For more information, see <a href="https://help.aliyun.com/zh/model-studio/user-guide/rag-knowledge-base">Create a knowledge base</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableRewrite")]
        [Validation(Required=false)]
        public bool? EnableRewrite { get; set; }

        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<string> Images { get; set; }

        /// <summary>
        /// <para>The primary key ID of the knowledge base, which is the <c>Data.Id</c> parameter returned by the <a href="https://help.aliyun.com/zh/model-studio/developer-reference/api-bailian-2023-12-29-createindex">CreateIndex</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5pwe0m2g6t</para>
        /// </summary>
        [NameInMap("IndexId")]
        [Validation(Required=false)]
        public string IndexId { get; set; }

        /// <summary>
        /// <para>The input query prompt. The length and characters of the query are not limited.</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>Ranking configurations.</para>
        /// </summary>
        [NameInMap("Rerank")]
        [Validation(Required=false)]
        public List<RetrieveRequestRerank> Rerank { get; set; }
        public class RetrieveRequestRerank : TeaModel {
            /// <summary>
            /// <para>The name of the rank model. For more information, see <a href="https://help.aliyun.com/zh/model-studio/user-guide/rag-knowledge-base">Create a knowledge base</a>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>gte-rerank-hybrid: Recommended official model.</description></item>
            /// <item><description>gte-rerank</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>gte-rerank-hybrid</para>
            /// </summary>
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

        }

        /// <summary>
        /// <para>Similarity Threshold The lowest similarity score of chunks that can be returned. This parameter is used to filter text chunks returned by the rank model. For more information, see <a href="https://help.aliyun.com/zh/model-studio/user-guide/rag-knowledge-base">Create a knowledge base</a>. Valid values: [0.01-1.00]. The priority of this parameter is greater than the similarity threshold configured for the knowledge base.</para>
        /// <para>By default, this parameter is left empty. In this case, the similarity threshold of the knowledge base is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.20</para>
        /// </summary>
        [NameInMap("RerankMinScore")]
        [Validation(Required=false)]
        public float? RerankMinScore { get; set; }

        /// <summary>
        /// <para>The top N return data after reranking. Valid values: 1 to 20. Default value: 5.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("RerankTopN")]
        [Validation(Required=false)]
        public int? RerankTopN { get; set; }

        /// <summary>
        /// <para>Conversation rewriting configurations.</para>
        /// </summary>
        [NameInMap("Rewrite")]
        [Validation(Required=false)]
        public List<RetrieveRequestRewrite> Rewrite { get; set; }
        public class RetrieveRequestRewrite : TeaModel {
            /// <summary>
            /// <para>Conversation rewriting model name. The query rewriting model automatically adjusts the original prompt based on the context to improve retrieval performance. Valid value:</para>
            /// <list type="bullet">
            /// <item><description>conv-rewrite-qwen-1.8b</description></item>
            /// </list>
            /// <para>By default, this parameter is left empty, which means conv-rewrite-qwen-1.8b is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>conv-rewrite-qwen-1.8b</para>
            /// </summary>
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to save the retrieve test history. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SaveRetrieverHistory")]
        [Validation(Required=false)]
        public bool? SaveRetrieverHistory { get; set; }

        /// <summary>
        /// <para>Specifies complex filter conditions. For more information about the syntax of SearchFilters, see the SearchFilter syntax section of this topic.</para>
        /// </summary>
        [NameInMap("SearchFilters")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> SearchFilters { get; set; }

        /// <summary>
        /// <para>The top K of keyword retrieval. Chunks that exactly match the keywords of the input text are retrieved from the knowledge base. This filters out irrelevant chunks and boosts accuracy. Valid values: 0 to 100. The sum of the <c>DenseSimilarityTopK</c> and <c>SparseSimilarityTopK</c> parameters must be less than or equal to 200.</para>
        /// <para>Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("SparseSimilarityTopK")]
        [Validation(Required=false)]
        public int? SparseSimilarityTopK { get; set; }

    }

}
