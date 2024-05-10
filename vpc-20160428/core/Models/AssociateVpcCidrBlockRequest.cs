// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AssociateVpcCidrBlockRequest : TeaModel {
        /// <summary>
        /// The IPv6 CIDR block to be added.
        /// 
        /// >  You must and can specify only one of **SecondaryCidrBlock** and **Ipv6CidrBlock**.
        /// </summary>
        [NameInMap("IPv6CidrBlock")]
        [Validation(Required=false)]
        public string IPv6CidrBlock { get; set; }

        /// <summary>
        /// The version of the IP address. Valid values:
        /// 
        /// *   **IPV4**: the IPv4 address.
        /// *   **IPV6**: the IPv6 address. If you set **IpVersion** to **IPV6** and do not specify **SecondaryCidrBlock**, you can add a secondary IPv6 CIDR block to the VPC.
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// The ID of the IP Address Manager (IPAM) pool that contains IPv4 addresses.
        /// </summary>
        [NameInMap("IpamPoolId")]
        [Validation(Required=false)]
        public string IpamPoolId { get; set; }

        /// <summary>
        /// The type of the IPv6 CIDR block. Valid values:
        /// 
        /// *   **BGP** (default)
        /// *   **ChinaMobile**
        /// *   **ChinaUnicom**
        /// *   **ChinaTelecom**
        /// 
        /// >  If your Alibaba Cloud account is allowed to activate single-ISP bandwidth, you can set this parameter to **ChinaTelecom**, **ChinaUnicom**, or **ChinaMobile**.
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
        /// The region ID of the VPC to which you want to add a secondary CIDR block.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to query the region ID.
        /// 
        /// This parameter is required.
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
        /// The IPv4 CIDR block to be added. Take note of the following requirements:
        /// 
        /// *   You can specify one of the following standard IPv4 CIDR blocks or their subnets as the secondary IPv4 CIDR block of the VPC: 192.168.0.0/16, 172.16.0.0/12, and 10.0.0.0/8.
        /// *   You can also use a custom CIDR block other than 100.64.0.0/10, 224.0.0.0/4, 127.0.0.0/8, 169.254.0.0/16, or their subnets as the secondary IPv4 CIDR block of the VPC.
        /// 
        /// The CIDR block must meet the following requirements:
        /// 
        /// *   The CIDR block cannot start with 0. The subnet mask must be 8 to 28 bits in length.
        /// *   The CIDR block cannot overlap with the primary CIDR block or an existing secondary CIDR block of the VPC.
        /// 
        /// >  You must and can specify only one of **SecondaryCidrBlock** and **Ipv6CidrBlock**.
        /// </summary>
        [NameInMap("SecondaryCidrBlock")]
        [Validation(Required=false)]
        public string SecondaryCidrBlock { get; set; }

        [NameInMap("SecondaryCidrMask")]
        [Validation(Required=false)]
        public int? SecondaryCidrMask { get; set; }

        /// <summary>
        /// The ID of the VPC to which you want to add a secondary CIDR block.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
