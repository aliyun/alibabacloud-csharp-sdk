// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class QueryKnowledgeBasesContentShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The text content used for retrieval.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the details of all AnalyticDB for PostgreSQL instances in a region, including instance IDs.</para>
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
        /// <para>The method used to merge results from multiple knowledge bases. Default value: RRF. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RRF</description></item>
        /// <item><description>Weight.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RRF</para>
        /// </summary>
        [NameInMap("MergeMethod")]
        [Validation(Required=false)]
        public string MergeMethod { get; set; }

        /// <summary>
        /// <para>The parameters for the merge method of each SourceCollection.</para>
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
        /// <para>The reranking factor. If this parameter is not empty, the vector retrieval results are reranked. Valid values: 1 &lt; RerankFactor &lt;= 5.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Reranking is slow when document chunks are sparse.</description></item>
        /// <item><description>The recommended reranking count (TopK × Factor, rounded up) should not exceed 50.</description></item>
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
        /// <para>The reranking model parameters for performing an additional reranking on the overall results after multi-channel merging.</para>
        /// </summary>
        [NameInMap("RerankModel")]
        [Validation(Required=false)]
        public string RerankModelShrink { get; set; }

        /// <summary>
        /// <para>The information about the multiple collections to retrieve.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SourceCollection")]
        [Validation(Required=false)]
        public string SourceCollectionShrink { get; set; }

        /// <summary>
        /// <para>The number of top results to return after multi-channel recall merging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public long? TopK { get; set; }

    }

}
