// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDiskReplicaGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the replication pair-consistent groups. You can specify one or more group IDs. Separate multiple IDs with a comma (,).</para>
        /// <para>If you do not specify this parameter, all replication pair-consistent groups in the current region are queried. You can specify up to 100 group IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("GroupIds")]
        [Validation(Required=false)]
        public string GroupIds { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on a single page. You can use this parameter with NextToken.</para>
        /// <para>Valid values: 1 to 500.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The name of the replication group. Fuzzy search is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-name***</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The query token. Set this parameter to the NextToken value returned from the previous call to this operation. You do not need to set this parameter for the first call. If you set NextToken, the PageSize and PageNumber parameters are ignored, and the TotalCount in the response is invalid.</para>
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
        /// <para>The region ID of the replication pair-consistent group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the replication pair-consistent group belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekz*****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The site to query. This parameter is used when replication pairs are deployed across zones.</para>
        /// <list type="bullet">
        /// <item><description><para>If you do not specify this parameter, the records and status information of replication pairs at the production site are returned.</para>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, only the records and status information of replication pairs at the specified site are returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>production: The production site.</para>
        /// </description></item>
        /// <item><description><para>backup: The disaster recovery site.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>production</para>
        /// </summary>
        [NameInMap("Site")]
        [Validation(Required=false)]
        public string Site { get; set; }

        /// <summary>
        /// <para>The tags. The list can contain up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDiskReplicaGroupsRequestTag> Tag { get; set; }
        public class DescribeDiskReplicaGroupsRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag of the replication pair-consistent group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag of the replication pair-consistent group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
