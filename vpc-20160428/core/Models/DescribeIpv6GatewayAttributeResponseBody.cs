// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIpv6GatewayAttributeResponseBody : TeaModel {
        /// <summary>
        /// The status of the IPv6 gateway. Valid values:
        /// 
        /// *   **Normal**
        /// *   **FinancialLocked**
        /// *   **SecurityLocked**
        /// </summary>
        [NameInMap("BusinessStatus")]
        [Validation(Required=false)]
        public string BusinessStatus { get; set; }

        /// <summary>
        /// The time when the IPv6 gateway was created.
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// The description of the IPv6 gateway.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The time when the IPv6 gateway expires.
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// The ID of the gateway route table associated with the IPv6 gateway.
        /// 
        /// >  This parameter is available only when the IPv6 gateway is associated with a gateway route table.
        /// </summary>
        [NameInMap("GatewayRouteTableId")]
        [Validation(Required=false)]
        public string GatewayRouteTableId { get; set; }

        /// <summary>
        /// The metering method of the IPv6 gateway.
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The ID of the IPv6 gateway.
        /// </summary>
        [NameInMap("Ipv6GatewayId")]
        [Validation(Required=false)]
        public string Ipv6GatewayId { get; set; }

        /// <summary>
        /// The name of the IPv6 gateway.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the region where the IPv6 gateway is deployed.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The status of the IPv6 gateway. Valid values:
        /// 
        /// *   **Pending**
        /// *   **Available**
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The information about the tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeIpv6GatewayAttributeResponseBodyTags Tags { get; set; }
        public class DescribeIpv6GatewayAttributeResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeIpv6GatewayAttributeResponseBodyTagsTag> Tag { get; set; }
            public class DescribeIpv6GatewayAttributeResponseBodyTagsTag : TeaModel {
                /// <summary>
                /// The key of tag N. You can specify at most 20 tag keys. The tag key cannot be an empty string.
                /// 
                /// The tag key can be up to 128 characters in length. It must start with a letter and can contain digits, periods (.), underscores (_), and hyphens (-). It cannot start with `aliyun` or `acs:`, and cannot contain `http://` or `https://`.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of tag N. You can specify at most 20 tag values. The tag value can be an empty string.
                /// 
                /// The tag value can be up to 128 characters in length. It must start with a letter and can contain digits, periods (.), underscores (_), and hyphens (-). It cannot start with `aliyun` or `acs:`, and cannot contain `http://` or `https://`.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) to which the IPv6 gateway belongs.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
