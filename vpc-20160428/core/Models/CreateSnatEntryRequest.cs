// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateSnatEntryRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. `The token can contain only ASCII characters.`
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** for each API request may be different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to enable EIP affinity. Valid values:
        /// 
        /// *   **0**: no
        /// *   **1**: yes
        /// 
        /// >  If EIP affinity is enabled and the SNAT entry is associated with multiple EIPs, a client uses the same EIP to access the Internet. Otherwise, the client uses an EIP selected from the associated EIPs to access the Internet.
        /// </summary>
        [NameInMap("EipAffinity")]
        [Validation(Required=false)]
        public int? EipAffinity { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region where the NAT gateway is deployed.
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
        /// Enter a name for the SNAT entry.
        /// 
        /// The name must be 2 to 128 characters in length. It must start with a letter but cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("SnatEntryName")]
        [Validation(Required=false)]
        public string SnatEntryName { get; set; }

        /// <summary>
        /// *   The EIPs in the SNAT entry when you add an SNAT entry to an Internet NAT gateway. Separate EIPs with commas (,).
        /// 
        /// >  If you select multiple EIPs to create an SNAT address pool, connections are hashed to these EIPs. Network traffic may not be evenly distributed to the EIPs because the amount of traffic that passes through each connection varies. We recommend that you associate these EIPs with the same EIP bandwidth plan to prevent service interruptions due to the bandwidth limit of an individual EIP.
        /// 
        /// *   When you add an SNAT entry to a VPC NAT gateway, this parameter specifies the NAT IP address in the SNAT entry.
        /// </summary>
        [NameInMap("SnatIp")]
        [Validation(Required=false)]
        public string SnatIp { get; set; }

        /// <summary>
        /// The ID of the SNAT table.
        /// </summary>
        [NameInMap("SnatTableId")]
        [Validation(Required=false)]
        public string SnatTableId { get; set; }

        /// <summary>
        /// You can specify the CIDR block of a VPC, a vSwitch, or an ECS instance or enter a custom CIDR block.
        /// 
        /// You can specify an SNAT entry in the following ways:
        /// 
        /// *   You can specify the CIDR block of the VPC where the NAT gateway is deployed. Then, all ECS instances in the VPC can access the Internet or external networks by using SNAT.
        /// *   You can specify the CIDR block of a vSwitch, for example, 192.168.1.0/24. Then, the ECS instances in the vSwitch can access the Internet or external networks by using SNAT.
        /// *   You can specify the IP address of an ECS instance, for example, 192.168.1.1/32. Then, the ECS instance can access the Internet or external networks by using SNAT.
        /// *   You can specify a custom CIDR block. Then, all ECS instances within the specified CIDR block can access the Internet or external networks by using SNAT.
        /// 
        /// When you add an SNAT entry to an Internet NAT gateway, if **SnatIp** is set to an EIP, the ECS instance uses the specified EIP to access the Internet.
        /// 
        /// If **SnatIp** is set to multiple EIPs, the ECS instance randomly selects an EIP specified in the **SnatIp** parameter to access the Internet.
        /// 
        /// You cannot set this parameter and **SourceVSwtichId** at the same time. If the **SourceVSwitchId** parameter is set, you cannot set the **SourceCIDR** parameter. If the **SourceCIDR** parameter is set, you cannot set the **SourceVSwitchId** parameter.
        /// </summary>
        [NameInMap("SourceCIDR")]
        [Validation(Required=false)]
        public string SourceCIDR { get; set; }

        /// <summary>
        /// The ID of the vSwitch.
        /// 
        /// *   When you add an SNAT entry to an Internet NAT gateway, this parameter specifies that ECS instances in the vSwitch can use the SNAT entry to access the Internet. If you select multiple elastic IP addresses (EIPs) to create an SNAT address pool, connections are hashed to these EIPs. Network traffic may not be evenly distributed to the EIPs because the amount of traffic that passes through each connection varies. We recommend that you associate these EIPs with the same EIP bandwidth plan to prevent service interruptions due to the bandwidth limits on individual EIPs.
        /// *   When you add an SNAT entry to a VPC NAT gateway, this parameter specifies that ECS instances in the vSwitch can use the SNAT entry to access external networks.
        /// </summary>
        [NameInMap("SourceVSwitchId")]
        [Validation(Required=false)]
        public string SourceVSwitchId { get; set; }

    }

}
