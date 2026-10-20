// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class RetrieveShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The top K value for AISearch. The system generates a vector for the input text and retrieves the top K text chunks in the knowledge base that are most similar to the vector representation. Valid values: 0 to 100.
        /// The sum of DenseSimilarityTopK and SparseSimilarityTopK must be less than or equal to 200.</para>
        /// <para>Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("DenseSimilarityTopK")]
        [Validation(Required=false)]
        public int? DenseSimilarityTopK { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable reranking. For more information, see <a href="https://help.aliyun.com/document_detail/2807740.html">Knowledge base</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
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
        /// <para>Specifies whether to enable &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/model-studio/use-cases/rag-optimization#b7031e2ad6cji">multi-turn conversation rewriting</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/model-studio/use-cases/rag-optimization#b7031e2ad6cji">multi-turn conversation rewriting</a>.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableRewrite")]
        [Validation(Required=false)]
        public bool? EnableRewrite { get; set; }

        [NameInMap("Extra")]
        [Validation(Required=false)]
        public string ExtraShrink { get; set; }

        /// <summary>
        /// <para>The URLs of the images passed in the query.</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public string ImagesShrink { get; set; }

        /// <summary>
        /// <para>The ID of the knowledge base, which is the Data.Id returned by the CreateIndex operation.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Make sure that the corresponding knowledge base is created and not deleted.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5pwe0mxxxx</para>
        /// </summary>
        [NameInMap("IndexId")]
        [Validation(Required=false)]
        public string IndexId { get; set; }

        /// <summary>
        /// <para>The input text, which is the original input prompt. The length and characters of Query are not limited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Introduction to Alibaba Cloud Model Studio</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/model-studio/use-cases/rag-optimization#b7031e2ad6cji">Multi-turn conversation rewriting</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/model-studio/use-cases/rag-optimization#b7031e2ad6cji">Multi-turn conversation rewriting</a> allows you to pass in your own managed conversation history. This parameter takes effect only when EnableRewrite is set to <b>true</b>. Otherwise, it does not take effect even if you specify it.</para>
        /// </summary>
        [NameInMap("QueryHistory")]
        [Validation(Required=false)]
        public string QueryHistoryShrink { get; set; }

        /// <summary>
        /// <para>The reranking configuration.</para>
        /// </summary>
        [NameInMap("Rerank")]
        [Validation(Required=false)]
        public string RerankShrink { get; set; }

        /// <summary>
        /// <para>The similarity threshold. This threshold specifies the minimum similarity score allowed for recalled text chunks and is used to filter the text chunks returned by the ranking model. Only text chunks with a score greater than this value are recalled. Valid values: 0.01 to 1.00. This parameter has a higher priority than the similarity threshold configured for the knowledge base.</para>
        /// <para>If no specific value is specified, the similarity threshold configured for the knowledge base is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.20</para>
        /// </summary>
        [NameInMap("RerankMinScore")]
        [Validation(Required=false)]
        public float? RerankMinScore { get; set; }

        /// <summary>
        /// <para>The top N text chunks to return after reranking. Valid values: 1 to 20. Default value: 5.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("RerankTopN")]
        [Validation(Required=false)]
        public int? RerankTopN { get; set; }

        /// <summary>
        /// <para>The multi-turn conversation rewriting configuration.</para>
        /// </summary>
        [NameInMap("Rewrite")]
        [Validation(Required=false)]
        public string RewriteShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to save the historical text chunk recall test data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Save.</description></item>
        /// <item><description>false: Do not save.</description></item>
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
        /// <para>The personalized retrieval conditions, such as tags, configured by using SearchFilter to filter semantic retrieval results and exclude information irrelevant to the query.
        /// The filtering logic takes effect when the is_displayed_chunk_content parameter is set to true. For more information, see <a href="https://help.aliyun.com/document_detail/2869641.html">Knowledge base SearchFilters</a>.</para>
        /// </summary>
        [NameInMap("SearchFilters")]
        [Validation(Required=false)]
        public string SearchFiltersShrink { get; set; }

        /// <summary>
        /// <para>The top K value for keyword retrieval. The system retrieves chunks from the knowledge base that are an exact match for the keywords in the input text. This helps you filter out irrelevant text chunks and provides more accurate results.
        /// Valid values: 0 to 100.
        /// The sum of DenseSimilarityTopK and SparseSimilarityTopK must be less than or equal to 200.</para>
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
