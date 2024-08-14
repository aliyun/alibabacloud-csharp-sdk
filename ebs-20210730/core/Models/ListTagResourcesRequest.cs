// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that the value is unique among different requests. The **ClientToken** value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](https://help.aliyun.com/document_detail/25693.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The token used to start the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The region ID of the resource. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID list of the resource. You can specify up to 50 resource IDs in each call.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// The type of the resource. Valid values:
        /// 
        /// *   dedicatedblockstoragecluster: dedicated block storage cluster
        /// *   diskreplicapair: replication pair
        /// *   diskreplicagroup: replication pair-consistent group
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The information about the tags.
        /// 
        /// You can specify at most 20 tags in each call.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N used for exact search of EBS resources. The tag key must be 1 to 128 characters in length. Valid values of N: 1 to 20.
            /// 
            /// The `Tag.N` parameter pair (Tag.N.Key and Tag.N.Value) is used for exact search of EBS resources that have specified tags added. Each tag is a key-value pair.
            /// 
            /// *   If you specify only `Tag.N.Key`, all EBS resources whose tags contain the specified tag key are returned.
            /// *   If you specify only `Tag.N.Value`, the `InvalidParameter.TagValue` error is returned.
            /// *   If you specify multiple tag key-value pairs at the same time, only EBS resources that match all tag key-value pairs are returned.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N used for exact search of EBS resources. The tag value must be 1 to 128 characters in length. Valid values of N: 1 to 20.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
