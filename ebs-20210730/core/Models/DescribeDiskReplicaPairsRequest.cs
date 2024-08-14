// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDiskReplicaPairsRequest : TeaModel {
        /// <summary>
        /// The maximum number of entries per page. You can use this parameter together with NextToken.
        /// 
        /// Valid values: 1 to 500.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken. If you specify NextToken, the PageSize and PageNumber request parameters do not take effect, and the TotalCount response parameter is invalid.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: 1 to 100.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The IDs of replication pairs. You can specify the IDs of one or more replication pairs and separate the IDs with commas (,). Example: `pair-cn-dsa****,pair-cn-asd****`.
        /// 
        /// This parameter is empty by default, which indicates that all replication pairs in the specified region are queried. You can specify a maximum of 100 replication pair IDs.
        /// </summary>
        [NameInMap("PairIds")]
        [Validation(Required=false)]
        public string PairIds { get; set; }

        /// <summary>
        /// The region ID of the primary or secondary disk in the replication pair. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/354276.html) operation to query the most recent list of regions in which async replication is supported.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the replication pair-consistent group. You can specify the ID of a replication pair-consistent group to query the replication pairs in the group. Example: `pg-****`.
        /// 
        /// This parameter is empty by default, which indicates that all replication pairs in the specified region are queried.
        /// 
        /// >  If this parameter is set to`-`, replication pairs that are not added to any replication pair-consistent groups are returned.
        /// </summary>
        [NameInMap("ReplicaGroupId")]
        [Validation(Required=false)]
        public string ReplicaGroupId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the replication pair belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The type of the site from which the information of replication pairs is retrieved. Valid value:
        /// 
        /// *   production: primary site
        /// *   backup: secondary site
        /// 
        /// Default value: production.
        /// </summary>
        [NameInMap("Site")]
        [Validation(Required=false)]
        public string Site { get; set; }

        /// <summary>
        /// The tags. Up to 20 tags are supported.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDiskReplicaPairsRequestTag> Tag { get; set; }
        public class DescribeDiskReplicaPairsRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
