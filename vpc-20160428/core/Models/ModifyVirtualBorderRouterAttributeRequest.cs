// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVirtualBorderRouterAttributeRequest : TeaModel {
        /// <summary>
        /// The information about the Express Connect circuit associated with the VBR, including the following parameters:
        /// 
        /// *   **CircuitCode**: the circuit code provided by the connectivity provider for the Express Connect circuit.
        /// *   **LocalGatewayIp**: the IP address of the gateway device on the Alibaba Cloud side.
        /// *   **PeerGatewayIp**: the IP address of the gateway device on the user side.
        /// *   **PeeringSubnetMask**: the subnet mask for the IP addresses of gateway devices on the Alibaba Cloud side and the user side.
        /// *   **PhysicalConnectionId**: the ID of the Express Connect circuit.
        /// </summary>
        [NameInMap("AssociatedPhysicalConnections")]
        [Validation(Required=false)]
        public string AssociatedPhysicalConnections { get; set; }

        /// <summary>
        /// The bandwidth value. Unit: Mbit/s.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// The circuit code of the Express Connect circuit. The circuit code is provided by the connectivity provider.
        /// 
        /// >  Only the owner of the Express Connect circuit can set this parameter.
        /// </summary>
        [NameInMap("CircuitCode")]
        [Validation(Required=false)]
        public string CircuitCode { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, the system uses **RequestId** as **ClientToken**. **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the VBR.
        /// 
        /// It must be 2 to 256 characters in length. It must start with a letter but cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The maximum number of dropped packets that is allowed by the receiver when the initiator transmits packets. This value can be used to check whether a connection works as expected.
        /// 
        /// Valid values: **3 to 10**.
        /// </summary>
        [NameInMap("DetectMultiplier")]
        [Validation(Required=false)]
        public long? DetectMultiplier { get; set; }

        /// <summary>
        /// Specifies whether to enable IPv6. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false** (default): no
        /// </summary>
        [NameInMap("EnableIpv6")]
        [Validation(Required=false)]
        public bool? EnableIpv6 { get; set; }

        /// <summary>
        /// The IP address of the gateway device on the Alibaba Cloud side.
        /// 
        /// Only the owner of the VBR can set or modify this parameter.
        /// </summary>
        [NameInMap("LocalGatewayIp")]
        [Validation(Required=false)]
        public string LocalGatewayIp { get; set; }

        /// <summary>
        /// The IPv6 address of the gateway device on the Alibaba Cloud side.
        /// </summary>
        [NameInMap("LocalIpv6GatewayIp")]
        [Validation(Required=false)]
        public string LocalIpv6GatewayIp { get; set; }

        /// <summary>
        /// The time interval to receive BFD packets. Valid values: **200 to 1000**. Unit: milliseconds.
        /// </summary>
        [NameInMap("MinRxInterval")]
        [Validation(Required=false)]
        public long? MinRxInterval { get; set; }

        /// <summary>
        /// The time interval to send BFD packets. Valid values: **200 to 1000**. Unit: milliseconds.
        /// </summary>
        [NameInMap("MinTxInterval")]
        [Validation(Required=false)]
        public long? MinTxInterval { get; set; }

        /// <summary>
        /// The name of the VBR.
        /// 
        /// The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-). The name must start with a letter. It cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The IP address of the gateway device on the user side.
        /// 
        /// Only the owner of the VBR can set or modify this parameter.
        /// </summary>
        [NameInMap("PeerGatewayIp")]
        [Validation(Required=false)]
        public string PeerGatewayIp { get; set; }

        /// <summary>
        /// The IPv6 address of the gateway device in the data center.
        /// 
        /// *   Only the owner of the VBR can set or modify this property.
        /// *   This property is required when you create a VBR for the owner of the Express Connect circuit. You can ignore this property when you create a VBR for another Alibaba Cloud account.
        /// </summary>
        [NameInMap("PeerIpv6GatewayIp")]
        [Validation(Required=false)]
        public string PeerIpv6GatewayIp { get; set; }

        /// <summary>
        /// The subnet mask of the IPv6 addresses of the VBR and the gateway device in the data center.
        /// 
        /// The two IPv6 addresses must fall within the same subnet.
        /// </summary>
        [NameInMap("PeeringIpv6SubnetMask")]
        [Validation(Required=false)]
        public string PeeringIpv6SubnetMask { get; set; }

        /// <summary>
        /// The subnet mask for the IP addresses of the gateway devices on the Alibaba Cloud side and on the user side. Only the owner of the VBR can set or modify this parameter.
        /// 
        /// The two IP addresses must fall within the same subnet.
        /// </summary>
        [NameInMap("PeeringSubnetMask")]
        [Validation(Required=false)]
        public string PeeringSubnetMask { get; set; }

        /// <summary>
        /// The region ID of the VBR.
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
        /// The ID of the VBR.
        /// </summary>
        [NameInMap("VbrId")]
        [Validation(Required=false)]
        public string VbrId { get; set; }

        /// <summary>
        /// The VLAN ID of the VBR. Valid values: **0 to 2999**.
        /// 
        /// >  Only the owner of the Express Connect circuit can set this parameter. The VLAN IDs of two VBRs of the same the Express Connect circuit must be different.
        /// </summary>
        [NameInMap("VlanId")]
        [Validation(Required=false)]
        public int? VlanId { get; set; }

    }

}
