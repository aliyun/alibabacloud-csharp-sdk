// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// The token that determines the start point of the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the resource. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/2679950.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The IDs of the Auto Scaling resources. You can specify 1 to 50 resource IDs.
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The resource type. Set the value to scalinggroup.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Details of the tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTags> Tags { get; set; }
        public class ListTagResourcesRequestTags : TeaModel {
            /// <summary>
            /// The key of the tag. The key is used to perform an exact match of Auto Scaling resources. The key must be 1 to 128 characters in length.
            /// 
            /// `Tags` is used to perform an exact match of Auto Scaling resources to which the specified tags are added. Specify a tag in the key-value pair format.
            /// 
            /// *   If you specify only `Tags.Key`, all resources whose tags contain the specified tag key are returned.
            /// *   If you specify only `Tags.Value`, the `MissingParameter.TagKey` error is reported.
            /// *   If you specify multiple key-value pairs at the same time, only Auto Scaling resources that match all the tag keys and tag values are returned.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag. The value is used to perform an exact match of Auto Scaling resources. The value can be up to 128 characters in length.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
