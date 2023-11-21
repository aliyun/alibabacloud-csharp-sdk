// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class TagResourcesRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the resource.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource ID. You can specify at most 20 IDs.
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
        /// The resource type. Valid values:
        /// 
        /// *   **VPC**: a VPC
        /// *   **VSWITCH**: a vSwitch
        /// *   **ROUTETABLE**: a route table
        /// *   **EIP**: an EIP
        /// *   **VpnGateway**: a VPN gateway
        /// *   **NATGATEWAY**: a NAT gateway
        /// *   **COMMONBANDWIDTHPACKAGE**: an EIP bandwidth plan
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag that is added to the resource. You can specify at most 20 tag keys. 
            /// 
            /// The key cannot exceed 128 characters in length. The key cannot start with `aliyun` or `acs:` and cannot contain `http://` or `https://`.
            /// 
            /// > When you call this operation, the **Tag.N.Key** parameter is required and cannot be an empty string.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag that is added to the resource. You can specify at most 20 tag values. 
            /// 
            /// The tag value cannot exceed 128 characters in length. The key cannot start with `aliyun` or `acs:`. The key cannot contain `http://` or `https://`.
            /// 
            /// > When you call this operation, the **Tag.N.Value** parameter is required and can be an empty string.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
