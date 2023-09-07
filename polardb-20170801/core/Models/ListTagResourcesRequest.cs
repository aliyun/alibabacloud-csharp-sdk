// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// The token required to obtain more results. This parameter is not required in the first query. If the first query does not return all results, you can use the token that is returned from the first query in the next query to obtain more results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region. You can call the [DescribeRegions](~~98041~~) operation to query available region IDs.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The cluster ID. To query the tags of multiple clusters, click **Add** to add cluster IDs.
        /// 
        /// > 
        /// 
        /// *   You must specify at least one of the `ResourceId.N` and `Tag.N.Key` parameters.
        /// 
        /// *   If you specify the `ResourceId.N` parameter, you can add a maximum of 50 cluster IDs at a time.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The type of the resource. Set the value to **cluster**.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag. To query the details of clusters to which multiple tags are bound, click **Add** to add tags.
            /// 
            /// > 
            /// 
            /// *   You must specify at least one of the `ResourceId.N` and `Tag.N.Key` parameters.
            /// 
            /// *   If you specify the `Tag.N.Key` parameter, you can create up to 20 tags at a time.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value that is paired with the tag key. This parameter can be set to an empty string.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
