// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// The number of entries to return on each page. Valid values:**1** to **50**. Default value: **50**.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that determines the start point of the query. Valid values:
        /// 
        /// *   If this is your first query or no subsequent query is to be sent, ignore this parameter.
        /// *   If a next query is to be sent, set the value to the value of **NextToken** that is returned in the last call.
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
        /// The ID of the region to which the resource belongs.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to obtain the region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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
        /// *   **VPC**: virtual private cloud (VPC)
        /// *   **VSWITCH**: vSwitch
        /// *   **ROUTETABLE**: route table
        /// *   **EIP**: EIP
        /// *   **VpnGateWay**: VPN gateway
        /// *   **NATGATEWAY**: NAT gateway
        /// *   **COMMONBANDWIDTHPACKAGE**: EIP bandwidth plan
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag that is added to the resource. You can specify up to 20 tag keys. The tag key cannot be an empty string.
            /// 
            /// The key can be up to 64 characters in length and can contain letters, digits, periods (.), underscores (\_), and hyphens (-). The key must start with a letter but cannot start with `aliyun` or `acs:`. The key cannot contain `http://` or `https://`.
            /// 
            /// >  Specify at least one of the **ResourceId.N** and **Tag.N** parameters (**Tag.N.Key** and **Tag.N.Value**).
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag that is added to the resource. You can specify up to 20 tag values. The tag value can be an empty string.
            /// 
            /// The value can be up to 128 characters in length and can contain letters, digits, periods (.), underscores (\_), and hyphens (-). The value must start with a letter but cannot start with `aliyun` or `acs:`. The value cannot contain `http://` or `https://`.
            /// 
            /// >  Specify at least one of the **ResourceId.N** and **Tag.N** parameters (**Tag.N.Key** and **Tag.N.Value**).
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
