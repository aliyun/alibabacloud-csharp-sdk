// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class QueryKnowledgeBasesContentShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The text content to search for.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>What is ADBPG?</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to view the details of all AnalyticDB for PostgreSQL instances in a specific region, including their instance IDs.</para>
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
        /// <para>The method for merging results from multiple knowledge bases. The default value is <c>RRF</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>RRF</para>
        /// </description></item>
        /// <item><description><para>Weight</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RRF</para>
        /// </summary>
        [NameInMap("MergeMethod")]
        [Validation(Required=false)]
        public string MergeMethod { get; set; }

        /// <summary>
        /// <para>The arguments for the specified <c>MergeMethod</c>.</para>
        /// </summary>
        [NameInMap("MergeMethodArgs")]
        [Validation(Required=false)]
        public string MergeMethodArgsShrink { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The reranking factor. If specified, the system reranks the final merged results. Valid values: 1 &lt; RerankFactor &lt;= 5.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Sparse document chunking reduces reranking efficiency.</para>
        /// </description></item>
        /// <item><description><para>We recommend that the number of items to rerank (TopK × Factor, rounded up) does not exceed 50.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RerankFactor")]
        [Validation(Required=false)]
        public double? RerankFactor { get; set; }

        /// <summary>
        /// <para>Parameters for the rerank model applied to the final merged results.</para>
        /// </summary>
        [NameInMap("RerankModel")]
        [Validation(Required=false)]
        public string RerankModelShrink { get; set; }

        /// <summary>
        /// <para>The source collections to search.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SourceCollection")]
        [Validation(Required=false)]
        public string SourceCollectionShrink { get; set; }

        /// <summary>
        /// <para>The number of top results to return after the results from all recall paths are merged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public long? TopK { get; set; }

    }

}
