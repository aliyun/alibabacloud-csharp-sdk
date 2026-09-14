// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDiskReplicaPairsRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return on each page. Use this parameter with NextToken.</para>
        /// <para>Valid values: 1 to 500.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The name of the replication pair. Fuzzy matching is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name***</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The query token. Set this parameter to the NextToken value returned from the previous call to this operation. You do not need to set this parameter for the first call. If you set NextToken, the PageSize and PageNumber parameters are ignored, and the TotalCount value in the response is invalid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.
        /// Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The IDs of replication pairs. Specify one or more replication pair IDs. The IDs must be in the <c>pair-cn-dsa****,pair-cn-asd****</c> format.</para>
        /// <para>If you leave this parameter empty, all replication pairs in the current region are queried. You can specify up to 100 replication pair IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pair-cn-dsa****</para>
        /// </summary>
        [NameInMap("PairIds")]
        [Validation(Required=false)]
        public string PairIds { get; set; }

        /// <summary>
        /// <para>The ID of the region where the primary or secondary disk of the replication pair resides. Call the <a href="https://help.aliyun.com/document_detail/354276.html">DescribeRegions</a> operation to query the regions that support asynchronous replication.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the replication pair-consistent group. Specify the ID of a replication pair-consistent group to query the replication pairs in the group. The ID must be in the <c>pg-****</c> format.</para>
        /// <para>If you leave this parameter empty, all replication pairs in the current region are queried.</para>
        /// <remarks>
        /// <para>If you set this parameter to <c>-</c>, replication pairs that are not in any replication pair-consistent group are returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pg-****</para>
        /// </summary>
        [NameInMap("ReplicaGroupId")]
        [Validation(Required=false)]
        public string ReplicaGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the replication pair belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmvs******</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The site from which to query data. Query data from the production site or the disaster recovery site. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>production: the production site.</para>
        /// </description></item>
        /// <item><description><para>backup: the disaster recovery site.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: production.</para>
        /// 
        /// <b>Example:</b>
        /// <para>production</para>
        /// </summary>
        [NameInMap("Site")]
        [Validation(Required=false)]
        public string Site { get; set; }

        /// <summary>
        /// <para>The tags. You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDiskReplicaPairsRequestTag> Tag { get; set; }
        public class DescribeDiskReplicaPairsRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
