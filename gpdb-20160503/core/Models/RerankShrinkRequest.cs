// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class RerankShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> API to view details of all AnalyticDB PostgreSQL instances in the target region, including the instance ID.</para>
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
        /// <para>List of documents to be re-ordered.</para>
        /// </summary>
        [NameInMap("Documents")]
        [Validation(Required=false)]
        public string DocumentsShrink { get; set; }

        /// <summary>
        /// <para>Maximum number of chunks allowed when the text exceeds the model window:</para>
        /// <list type="bullet">
        /// <item><description>bge-reranker-v2-m3: default value is 10.</description></item>
        /// <item><description>bge-reranker-v2-minicpm-layerwise: default value is 5:</description></item>
        /// </list>
        /// <remarks>
        /// <para>Example of splitting</para>
        /// <list type="bullet">
        /// <item><description>If using the bge-reranker-v2-minicpm-layerwise model, the maximum single inference window is 2048 tokens. If the query is 48 tokens and the content of a single document parameter is 9000 tokens, it will be divided as follows: 1-2000 for the first, 2001-4000 for the second, and so on. If the number of splits exceeds MaxChunksPerDoc, the remaining sentences will be discarded.</description></item>
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
        /// <para>Rerank model, currently supports:</para>
        /// <list type="bullet">
        /// <item><description>bge-reranker-v2-m3: (default), better performance, supports 8192 tokens per inference, if exceeded, it will be split, which may reduce the effect.</description></item>
        /// <item><description>bge-reranker-v2-minicpm-layerwise: better performance than v2-m3, supports 2048 tokens per inference, if exceeded, it will be split, which may reduce the effect.</description></item>
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
        /// <para>Query statement for Rerank.</para>
        /// 
        /// <b>Example:</b>
        /// <para>What is ADBPG?</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>Region ID where the instance is located.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>If set to false, does not return the Documents text, only returns the index of the document order and the rerank score.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ReturnDocuments")]
        [Validation(Required=false)]
        public bool? ReturnDocuments { get; set; }

        /// <summary>
        /// <para>Number of most relevant documents to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

    }

}
