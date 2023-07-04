// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AssociatePhysicalConnectionToVirtualBorderRouterRequest : TeaModel {
        /// <summary>
        /// The IP address of the gateway device in the data center.
        /// 
        /// *   Only the owner of the VBR can set or modify this parameter.
        /// *   When you create a VBR for the owner of the Express Connect circuit, this parameter is required.
        /// </summary>
        [NameInMap("CircuitCode")]
        [Validation(Required=false)]
        public string CircuitCode { get; set; }

        /// <summary>
        /// The IPv6 address of the gateway device in the data center.
        /// 
        /// *   Only the owner of the VBR can set or modify this parameter.
        /// *   When you create a VBR for the owner of the Express Connect circuit, this parameter is required.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("EnableIpv6")]
        [Validation(Required=false)]
        public string EnableIpv6 { get; set; }

        /// <summary>
        /// The subnet mask of the IP addresses of the VBR and the gateway device in the data center.
        /// 
        /// The two IP addresses must fall within the same subnet.
        /// </summary>
        [NameInMap("LocalGatewayIp")]
        [Validation(Required=false)]
        public string LocalGatewayIp { get; set; }

        /// <summary>
        /// The subnet mask of the IPv6 addresses of the VBR and the gateway device in the data center.
        /// 
        /// The two IPv6 addresses must fall within the same subnet.
        /// </summary>
        [NameInMap("LocalIpv6GatewayIp")]
        [Validation(Required=false)]
        public string LocalIpv6GatewayIp { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **AssociatePhysicalConnectionToVirtualBorderRouter**.
        /// </summary>
        [NameInMap("PeerGatewayIp")]
        [Validation(Required=false)]
        public string PeerGatewayIp { get; set; }

        /// <summary>
        /// Specifies whether to enable IPv6. Valid values:
        /// 
        /// *   **true**: enables IPv6
        /// *   **false** (default): disables IPv6
        /// </summary>
        [NameInMap("PeerIpv6GatewayIp")]
        [Validation(Required=false)]
        public string PeerIpv6GatewayIp { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("PeeringIpv6SubnetMask")]
        [Validation(Required=false)]
        public string PeeringIpv6SubnetMask { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// 
        /// >  If you do not set this parameter, the system automatically uses **RequestId** as **ClientToken**. **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("PeeringSubnetMask")]
        [Validation(Required=false)]
        public string PeeringSubnetMask { get; set; }

        /// <summary>
        /// The circuit code of the Express Connect circuit. The circuit code is provided by the connectivity provider.
        /// 
        /// >  Only the owner of the Express Connect circuit can set this parameter.
        /// </summary>
        [NameInMap("PhysicalConnectionId")]
        [Validation(Required=false)]
        public string PhysicalConnectionId { get; set; }

        /// <summary>
        /// The ID of the Express Connect circuit.
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
        /// The VLAN ID of the VBR. Valid values: **0 to 2999**.
        /// 
        /// >  Only the owner of the Express Connect circuit can set this parameter. The VLAN IDs of two VBRs of the same the Express Connect circuit must be different.
        /// </summary>
        [NameInMap("VbrId")]
        [Validation(Required=false)]
        public string VbrId { get; set; }

        /// <summary>
        /// The IP address of the VBR.
        /// </summary>
        [NameInMap("VlanId")]
        [Validation(Required=false)]
        public string VlanId { get; set; }

    }

}
