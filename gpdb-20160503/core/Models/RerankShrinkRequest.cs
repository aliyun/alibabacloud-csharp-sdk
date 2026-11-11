// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class RerankShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to view the details of all AnalyticDB for PostgreSQL instances in the specified region, including instance IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The list of documents to be reranked.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADBPG is an Alibaba Cloud OLAP database.</para>
        /// </summary>
        [NameInMap("Documents")]
        [Validation(Required=false)]
        public string DocumentsShrink { get; set; }

        /// <summary>
        /// <para>The description of the custom ranking task type. This parameter can be set when RerankModel.Name is qwen3-rerank. It guides the model to use different ranking strategies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Given a web search query, retrieve relevant passages that answer the query</para>
        /// </summary>
        [NameInMap("Instruct")]
        [Validation(Required=false)]
        public string Instruct { get; set; }

        /// <summary>
        /// <para>The maximum number of chunks allowed when the text exceeds the model window. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>bge-reranker-v2-m3: 10. This is the default value.</description></item>
        /// <item><description>bge-reranker-v2-minicpm-layerwise: 5. This is the default value.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Chunking example</para>
        /// <list type="bullet">
        /// <item><description>If you use the bge-reranker-v2-minicpm-layerwise model, the maximum single inference window is 2,048 tokens. If the query is 48 tokens and a single document parameter contains 9,000 tokens, the document is split into chunks: tokens 1 to 2,000 form the first chunk, tokens 2,001 to 4,000 form the second chunk, and so on. If the number of chunks exceeds the value of MaxChunksPerDoc, the subsequent text is discarded.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxChunksPerDoc")]
        [Validation(Required=false)]
        public int? MaxChunksPerDoc { get; set; }

        /// <summary>
        /// <para>The rerank model. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>bge-reranker-v2-m3: provides good performance and supports up to 8,192 tokens for a single inference. Text that exceeds this limit is split into chunks, which may degrade performance. This is the default value.</description></item>
        /// <item><description>bge-reranker-v2-minicpm-layerwise: provides better performance than bge-reranker-v2-m3 and supports up to 2,048 tokens for a single inference. Text that exceeds this limit is split into chunks, which may degrade performance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>bge-reranker-v2-m3</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The query statement for reranking.</para>
        /// 
        /// <b>Example:</b>
        /// <para>What is ADBPG?</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the document text. If this parameter is set to false, the document text is not returned. Only the indexes and rerank scores of the sorted documents are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ReturnDocuments")]
        [Validation(Required=false)]
        public bool? ReturnDocuments { get; set; }

        /// <summary>
        /// <para>The number of most relevant documents to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

    }

}
