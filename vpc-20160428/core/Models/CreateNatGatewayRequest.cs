// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateNatGatewayRequest : TeaModel {
        /// <summary>
        /// Subscription Internet NAT gateways are no longer available for purchase. Ignore this parameter.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests.
        /// 
        /// >  If you do not specify this parameter, the system automatically sets **ClientToken** to the value of **RequestId**. **RequestId** might be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the NAT gateway.
        /// 
        /// You can leave this parameter empty or enter a description. If you enter a description, the description must be 2 to 256 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Subscription Internet NAT gateways are no longer available for purchase. Ignore this parameter.
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// The mode in which the EIP is associated with the NAT gateway. Valid values:
        /// 
        /// *   **MULTI_BINDED** (default): Multi-EIP-to-ENI mode.
        /// 
        /// *   **NAT**: NAT mode. IPv4 gateways are supported.
        /// 
        /// > If you use the NAT mode, the EIP occupies one private IP address on the vSwitch of the NAT gateway. Make sure that the vSwitch has sufficient private IP addresses. Otherwise, the NAT gateway fails to be associated with the EIP. In NAT mode, you can associate a NAT gateway with at most 50 EIPs.
        /// </summary>
        [NameInMap("EipBindMode")]
        [Validation(Required=false)]
        public string EipBindMode { get; set; }

        /// <summary>
        /// Specifies whether to enable the ICMP non-retrieval feature. Valid values:
        /// 
        /// *   **false** (default): no
        /// *   **true**: yes
        /// </summary>
        [NameInMap("IcmpReplyEnabled")]
        [Validation(Required=false)]
        public bool? IcmpReplyEnabled { get; set; }

        /// <summary>
        /// The billing method of the NAT gateway.
        /// 
        /// Set the value to **PostPaid** (pay-as-you-go), which is the default value.
        /// 
        /// For more information, see [Internet NAT gateway billing](~~48126~~) and [VPC NAT gateway billing](~~270913~~).
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The metering method of the NAT gateway. Set the value to **PayByLcu**, which specifies the pay-by-CU metering method.
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// The name of the NAT gateway.
        /// 
        /// The name must be 2 to 128 characters in length and can contain letters, digits, underscores (\_), and hyphens (-). The name must start with a letter.
        /// 
        /// If this parameter is not set, the system assigns a default name to the NAT gateway.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The type of NAT gateway. Set the value to **Enhanced** (enhanced NAT gateway).
        /// </summary>
        [NameInMap("NatType")]
        [Validation(Required=false)]
        public string NatType { get; set; }

        /// <summary>
        /// The network type of the NAT gateway. Valid values:
        /// 
        /// *   **internet**: an Internet NAT gateway
        /// *   **intranet**: a VPC NAT gateway
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// Subscription Internet NAT gateways are no longer available for purchase. Ignore this parameter.
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// The ID of the region where you want to create the NAT gateway.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// Specifies whether to enable the firewall feature. Valid values:
        /// 
        /// *   **false** (default): no
        /// *   **true**: yes
        /// </summary>
        [NameInMap("SecurityProtectionEnabled")]
        [Validation(Required=false)]
        public bool? SecurityProtectionEnabled { get; set; }

        /// <summary>
        /// Subscription Internet NAT gateways are no longer available for purchase. Ignore this parameter.
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// The list of Tag entries.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateNatGatewayRequestTag> Tag { get; set; }
        public class CreateNatGatewayRequestTag : TeaModel {
            /// <summary>
            /// The tag key. The format of Tag.N.Key when you call the operation. Valid values of N: 1 to 20. It cannot be an empty string. It can be up to 128 characters in length and cannot start with acs: or aliyun. It cannot contain http:// or https://.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value. The format of Tag.N.Value when you call the operation. Valid values of N: 1 to 20. It cannot be an empty string. It can be up to 128 characters in length and cannot start with acs: or aliyun. It cannot contain http:// or https://.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the vSwitch to which the NAT gateway is attached.
        /// 
        /// When you create a NAT gateway, you must specify a vSwitch for the NAT gateway. Then, the system assigns an idle private IP address from the vSwitch to the NAT gateway.
        /// 
        /// *   To attach the NAT gateway to an existing vSwitch, make sure that the zone to which the vSwitch belongs supports NAT gateways. In addition, the vSwitch must have idle IP addresses.
        /// *   If no vSwitch exists in the VPC, create a vSwitch in a zone that supports NAT gateways. Then, specify the vSwitch for the NAT gateway.
        /// 
        /// >  You can query the zones that support NAT gateways by calling the [ListEnhanhcedNatGatewayAvailableZones](~~182292~~) operation. You can query the number of available IP addresses in a vSwitch by calling the [DescribeVSwitches](~~35748~~) operation.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the VPC where you want to create the NAT gateway.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
