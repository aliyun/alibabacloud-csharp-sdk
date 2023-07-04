// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AssociateEipAddressRequest : TeaModel {
        /// <summary>
        /// The type of instance with which you want to associate the EIP. Valid values:
        /// 
        /// *   **Nat**: a NAT gateway
        /// *   **SlbInstance**: a CLB instance
        /// *   **EcsInstance** (default): an ECS instance in a VPC
        /// *   **NetworkInterface**: a secondary ENI
        /// *   **HaVip**: an HAVIP
        /// *   **IpAddress**: an IP address
        /// 
        /// >  If you do not set this parameter, the type of the instance with which you want to associate the EIP is **EcsInstance**. If the type of the instance with which you want to associate the EIP is not **EcsInstance**, this parameter is required.
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public string AllocationId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The region ID of the instance with which you want to associate the EIP.
        /// 
        /// >  This parameter is required only when the EIP is associated with a shared-bandwidth Global Accelerator (GA) instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The association mode. Valid values:
        /// 
        /// *   **NAT** (default): NAT mode
        /// *   **MULTI_BINDED**: multi-EIP-to-ENI mode
        /// *   **BINDED**: cut-through mode
        /// 
        /// >  This parameter is required only when **InstanceType** is set to **NetworkInterface**.
        /// </summary>
        [NameInMap("InstanceRegionId")]
        [Validation(Required=false)]
        public string InstanceRegionId { get; set; }

        /// <summary>
        /// An IP address in the CIDR block of the vSwitch.
        /// 
        /// If you do not set this parameter, the system allocates a private IP address based on the VPC ID and vSwitch ID.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. ClientToken can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, the system sets **ClientToken** to the value of **RequestId**. The value of **RequestId** for each API request may be different.
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
        /// The ID of the VPC that has IPv4 gateways enabled and that is deployed in the same region as the EIP.
        /// 
        /// When you associate an EIP with an IP address, the system can enable the IP address to access the Internet based on VPC route configurations.
        /// 
        /// >  This parameter is required if **InstanceType** is set to **IpAddress**. In this case, the EIP is associated with an IP address.
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// The ID of the instance with which you want to associate the EIP.
        /// 
        /// You can enter the ID of a NAT gateway, CLB instance, ECS instance, secondary ENI, HAVIP, or IP address.
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
