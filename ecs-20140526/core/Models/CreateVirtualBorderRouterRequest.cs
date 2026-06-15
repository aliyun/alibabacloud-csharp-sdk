// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateVirtualBorderRouterRequest : TeaModel {
        /// <summary>
        /// <para>The circuit code of the physical connection. This code is provided by your connectivity provider.</para>
        /// </summary>
        [NameInMap("CircuitCode")]
        [Validation(Required=false)]
        public string CircuitCode { get; set; }

        /// <summary>
        /// <para>A client token to ensure that the request is idempotent.</para>
        /// <para>You can generate this token on your client, but you must ensure that it is unique for each request. The token can contain only ASCII characters and cannot be longer than 64 characters.</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the VBR.</para>
        /// <para>The description must be 2 to 256 characters long and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The IP address of the VBR gateway in Alibaba Cloud.</para>
        /// </summary>
        [NameInMap("LocalGatewayIp")]
        [Validation(Required=false)]
        public string LocalGatewayIp { get; set; }

        /// <summary>
        /// <para>The name of the VBR.</para>
        /// <para>The name must be 2 to 128 characters long, start with a letter, and can contain only letters, digits, periods (.), underscores (_), and hyphens (-).</para>
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
        /// <para>The IP address of the gateway in your on-premises data center.</para>
        /// </summary>
        [NameInMap("PeerGatewayIp")]
        [Validation(Required=false)]
        public string PeerGatewayIp { get; set; }

        /// <summary>
        /// <para>The peering subnet mask for the IP addresses of the local gateway and the peer gateway.</para>
        /// </summary>
        [NameInMap("PeeringSubnetMask")]
        [Validation(Required=false)]
        public string PeeringSubnetMask { get; set; }

        /// <summary>
        /// <para>The ID of the physical connection.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PhysicalConnectionId")]
        [Validation(Required=false)]
        public string PhysicalConnectionId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the Virtual Border Router (VBR) is located.</para>
        /// <para>You can call the <c>DescribeRegions</c> operation to get the latest list of regions.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>The CIDR block of your on-premises network. Required when the VBR is connected to a Cloud Enterprise Network (CEN) instance.</para>
        /// </summary>
        [NameInMap("UserCidr")]
        [Validation(Required=false)]
        public string UserCidr { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that owns the VBR. Specify this parameter when creating a VBR for another account.</para>
        /// </summary>
        [NameInMap("VbrOwnerId")]
        [Validation(Required=false)]
        public long? VbrOwnerId { get; set; }

        /// <summary>
        /// <para>The VLAN ID of the VBR.</para>
        /// <para>Valid values: 0 to 4095.</para>
        /// <para>A value of 0 indicates that the VBR is connected to the physical connection in Layer 3 router mode.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("VlanId")]
        [Validation(Required=false)]
        public int? VlanId { get; set; }

    }

}
