// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AssociateVpcCidrBlockRequest : TeaModel {
        /// <summary>
        /// The secondary IPv4 CIDR block. Take note of the following requirements:
        /// 
        /// *   You can specify one of the following standard IPv4 CIDR blocks or their subnets as the secondary IPv4 CIDR block: 192.168.0.0/16, 172.16.0.0/12, and 10.0.0.0/8.
        /// *   You can also use a custom CIDR block other than 100.64.0.0/10, 224.0.0.0/4, 127.0.0.0/8, 169.254.0.0/16, or their subnets as the secondary IPv4 CIDR block of the VPC.
        /// 
        /// In addition, the following requirements must be met:
        /// 
        /// *   The CIDR block cannot start with 0. The subnet mask must be 8 to 28 bits in length.
        /// *   The secondary CIDR block cannot overlap with the primary CIDR block or an existing secondary CIDR block.
        /// 
        /// >  You must set one of the **SecondaryCidrBlock** and **Ipv6CidrBlock** parameters.
        /// </summary>
        [NameInMap("IPv6CidrBlock")]
        [Validation(Required=false)]
        public string IPv6CidrBlock { get; set; }

        /// <summary>
        /// The type of the IPv6 CIDR block. Valid values:
        /// 
        /// *   **BGP** (default): Alibaba Cloud Border Gateway Protocol (BGP) IPv6
        /// *   **ChinaMobile**: China Mobile (single line)
        /// *   **ChinaUnicom**: China Unicom (single line)
        /// *   **ChinaTelecom**: China Telecom (single line)
        /// 
        /// >  If your Alibaba Cloud account is allowed to use single-ISP bandwidth, valid values are: **ChinaTelecom**, **ChinaUnicom**, and **ChinaMobile**.
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        [NameInMap("IpamPoolId")]
        [Validation(Required=false)]
        public string IpamPoolId { get; set; }

        /// <summary>
        /// The IPv6 CIDR block.
        /// 
        /// >  You must set one of the **SecondaryCidrBlock** and **Ipv6CidrBlock** parameters.
        /// </summary>
        [NameInMap("Ipv6Isp")]
        [Validation(Required=false)]
        public string Ipv6Isp { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// *   The following list describes the limits on the maximum number of secondary CIDR blocks that can be added:
        /// 
        ///     *   You can add up to five secondary IPv4 CIDR blocks to each VPC.
        ///     *   You can add up to three secondary IPv6 CIDR blocks to each VPC.
        /// 
        /// *   You cannot repeatedly call the **AssociateVpcCidrBlock** operation to add secondary CIDR blocks to a VPC within the specified period of time.
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
        /// The ID of the VPC.
        /// </summary>
        [NameInMap("SecondaryCidrBlock")]
        [Validation(Required=false)]
        public string SecondaryCidrBlock { get; set; }

        /// <summary>
        /// The region ID of the VPC to which you want to add a secondary CIDR block.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
