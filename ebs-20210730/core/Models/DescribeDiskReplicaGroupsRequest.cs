// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDiskReplicaGroupsRequest : TeaModel {
        /// <summary>
        /// The IDs of replication pair-consistent groups. You can specify the IDs of one or more replication pair-consistent groups. Separate the IDs with commas (,).
        /// 
        /// This parameter is empty by default, which indicates that all replication pair-consistent groups in the specified region are queried.
        /// </summary>
        [NameInMap("GroupIds")]
        [Validation(Required=false)]
        public string GroupIds { get; set; }

        /// <summary>
        /// The maximum number of entries to return on each page. Valid values: 1 to 500.
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
        /// The query token. Set the value to the NextToken value returned in the previous call to the DescribeDiskReplicaGroups operation. Leave this parameter empty the first time you call this operation. When NextToken is specified, the PageSize and PageNumber request parameters do not take effect and the TotalCount response parameter is invalid.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Valid values: 1 to 100.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the replication pair-consistent group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the replication group belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The type of the site from which the information of replication pair-consistent groups is retrieved. This parameter is used for scenarios where data is replicated across zones in replication pairs.
        /// 
        /// *   If the Site parameter is not specified, information such as the state of replication pair-consistent groups at the primary site is queried and returned.
        /// 
        /// *   Otherwise, information such as the state of replication pair-consistent groups at the site specified by the Site parameter is queried and returned. Valid values:
        /// 
        ///     *   production: primary site
        ///     *   backup: secondary site
        /// </summary>
        [NameInMap("Site")]
        [Validation(Required=false)]
        public string Site { get; set; }

        /// <summary>
        /// The resource tags. You can specify up to 20 tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDiskReplicaGroupsRequestTag> Tag { get; set; }
        public class DescribeDiskReplicaGroupsRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N of the replication group.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N to add to the replication group.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
