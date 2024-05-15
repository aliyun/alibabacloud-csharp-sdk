// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results.
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
        /// The region ID of the resource. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource IDs. Valid values of N: 1 to 50.
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
        /// The type of the resource. Valid values:
        /// 
        /// *   instance: ECS instance
        /// *   disk: disk
        /// *   snapshot: snapshot
        /// *   image: image
        /// *   securitygroup: security group
        /// *   volume: storage volume
        /// *   eni: ENI
        /// *   ddh: dedicated host
        /// *   ddhcluster: dedicated host cluster
        /// *   keypair: SSH key pair
        /// *   launchtemplate: launch template
        /// *   reservedinstance: reserved instance
        /// *   snapshotpolicy: automatic snapshot policy
        /// *   elasticityassurance: elasticity assurance
        /// *   capacityreservation: capacity reservation
        /// *   command: Cloud Assistant command
        /// *   invocation: Cloud Assistant command execution result
        /// 
        /// This parameter is required.
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
            /// The key of tag N used for exact search of ECS resources. The tag key must be 1 to 128 characters in length. Valid values of N: 1 to 20.
            /// 
            /// Methods of using the `Tag.N` parameter pair (Tag.N.Key and Tag.N.Value):
            /// 
            /// *   Method 1: Use this parameter pair for exact search of ECS resources that have specified tags added. Each tag is a key-value pair.
            /// 
            ///     *   If you specify only `Tag.N.Key`, all ECS resources whose tags contain the specified tag key are returned.
            ///     *   If you specify only `Tag.N.Value`, the `InvalidParameter.TagValue` error is returned.
            ///     *   If you specify multiple tag key-value pairs, only the ECS resources that have all these tag key-value pairs added are returned.
            /// 
            /// *   Method 2: Use this parameter pair to query resource information of a non-default resource group. Set `Key` to `acs:rm:rgId` and `Value` to the ID of a resource group.
            /// 
            ///     *   If you set `Key` to `acs:rm:rgId`, you must set `Value` to the ID of a non-default resource group. If you set Value to the ID of the default resource group, an error message is returned.
            ///     *   If you set `Key` to `acs:rm:rgId`, you cannot specify other Tag.N parameter pairs. If you specify multiple `Tag.N` parameter pairs to query resource groups and resources at the same time, an error message is returned.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N used for exact search of ECS resources. The tag value must be 1 to 128 characters in length. Valid values of N: 1 to 20.
            /// 
            /// > When Key is set to `acs:rm:rgId`, you can set Value only to the ID of a non-default resource group.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The regular expressions used to filter tags.
        /// </summary>
        [NameInMap("TagFilter")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTagFilter> TagFilter { get; set; }
        public class ListTagResourcesRequestTagFilter : TeaModel {
            /// <summary>
            /// The key of tag N used for fuzzy search of ECS resources. The tag key must be 1 to 128 characters in length. Valid values of N: 1 to 5.
            /// 
            /// The `TagFilter.N` parameter pair (TagFilter.N.TagKey and TagFilter.N.TagValues.N) is used for fuzzy search of ECS resources that have specified tags added. In the specified tags, a single tag key may correspond to one or more tag values. Fuzzy search may have a latency of 2 seconds. A fuzzy search can return a result set of entries about a maximum of 5,000 resources.
            /// 
            /// *   When you use `TagFilter.N.TagKey` for fuzzy search of ECS resources, you must leave `TagFilter.N.TagValues.N` empty. For example, to query ECS resources whose tags contain the `environment` tag key, you can set `TagFilter.1.TagKey` to `env*` for prefix search, `*env*` for infix search, or `env` for exact search, but you must leave `TagFilter.1.TagValues` empty.
            /// *   When you use `TagFilter.N.TagValues.N` for fuzzy search of ECS resources, you must set `TagFilter.N.TagKey` to an exact value. For example, to query ECS resources that have a tag composed of the `env` tag key and the `product` tag value, you must set `TagFilter.1.TagKey` to `env` and can set `TagFilter.1.TagValues.1` to `proc*` for prefix search, to `*proc*` for infix search, or to `proc` for exact search. Only one of the preceding search methods can be used for each tag key (`TagFilter.N.TagKey`). If multiple search methods are configured for a tag key, the first search method prevails.
            /// *   If you specify multiple tag keys, only the ECS resources that have all the specified tag keys added are returned.
            /// *   If you specify a tag key that corresponds to multiple tag values, all the ECS resources that have one or more of these tag key-value pairs added are returned.
            /// 
            /// > The `TagFilter.N` parameter pair (TagFilter.N.TagKey and TagFilter.N.TagValues.N) cannot be used together with the `Tag.N` parameter pair (Tag.N.Key and Tag.N.Value). Otherwise, an error message is returned.
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// The values of tag N used for fuzzy search of ECS resources. The tag values must be 1 to 128 characters in length. Valid values of N: 1 to 5. For more information, see the description of `TagFilter.N.TagKey`.
            /// </summary>
            [NameInMap("TagValues")]
            [Validation(Required=false)]
            public List<string> TagValues { get; set; }

        }

    }

}
