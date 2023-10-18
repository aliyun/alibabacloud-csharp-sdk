// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AssociateEipAddressRequest : TeaModel {
        /// <summary>
        /// The ID of the EIP that you want to associate with an instance.
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public string AllocationId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate a token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the instance with which you want to associate the EIP.
        /// 
        /// You can enter the ID of a NAT gateway, CLB instance, ECS instance, secondary ENI, HAVIP, or IP address.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the region in which the instance with which you want to associate the EIP resides.
        /// 
        /// >  This parameter is required only when the EIP is added to a shared Global Accelerator (GA) instance.
        /// </summary>
        [NameInMap("InstanceRegionId")]
        [Validation(Required=false)]
        public string InstanceRegionId { get; set; }

        /// <summary>
        /// The type of the instance with which you want to associate the EIP. Valid values:
        /// 
        /// *   **Nat**: NAT gateway
        /// *   **SlbInstance**: CLB instance
        /// *   **EcsInstance** (default): ECS instance
        /// *   **NetworkInterface**: secondary ENI
        /// *   **HaVip**: HAVIP
        /// *   **IpAddress**: IP address
        /// 
        /// >  The default value is **EcsInstance**. If the instance with which you want to associate the EIP is not an ECS instance, this parameter is required.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The association mode. Valid values:
        /// 
        /// *   **NAT** (default): NAT mode
        /// *   **MULTI_BINDED**: multi-EIP-to-ENI mode
        /// *   **BINDED**: cut-network interface controller mode
        /// 
        /// >  This parameter is required only when **InstanceType** is set to **NetworkInterface**.
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The IP address in the CIDR block of the vSwitch.
        /// 
        /// If you leave this parameter empty, the system allocates a private IP address based on the VPC ID and vSwitch ID.
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// The ID of the region to which the EIP belongs.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the region ID.
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
        /// The ID of the VPC in which an IPv4 gateway is created. The VPC and the EIP must be in the same region.
        /// 
        /// When you associate an EIP with an IP address, the system can enable the IP address to access the Internet based on VPC route configurations.
        /// 
        /// >  This parameter is required if **InstanceType** is set to **IpAddress**, which indicates that the EIP is to be associated with an IP address.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
