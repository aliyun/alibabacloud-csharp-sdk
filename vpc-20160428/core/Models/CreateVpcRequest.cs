// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVpcRequest : TeaModel {
        /// <summary>
        /// The CIDR block of the VPC.
        /// 
        /// *   You can specify one of the following CIDR blocks or their subsets as the primary IPv4 CIDR block of the VPC: 192.168.0.0/16, 172.16.0.0/12, and 10.0.0.0/8. These CIDR blocks are standard private CIDR blocks as defined by Request for Comments (RFC) documents. The subnet mask must be 8 to 28 bits in length.
        /// *   You can also use a custom CIDR block other than 100.64.0.0/10, 224.0.0.0/4, 127.0.0.0/8, 169.254.0.0/16, and their subnets as the primary IPv4 CIDR block of the VPC.
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must ensure that it is unique among all requests. ClientToken can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** for each API request may be different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the VPC.
        /// 
        /// The description must be 1 to 256 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether to perform a dry run. Valid values:
        /// 
        /// *   **true**: performs a dry run. The system checks the required parameters, request syntax, and limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false** (default): performs a dry run and sends the request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Specifies whether to enable IPv6. Valid values:
        /// 
        /// *   **false** (default): no
        /// *   **true**: yes
        /// </summary>
        [NameInMap("EnableIpv6")]
        [Validation(Required=false)]
        public bool? EnableIpv6 { get; set; }

        [NameInMap("Ipv4IpamPoolId")]
        [Validation(Required=false)]
        public string Ipv4IpamPoolId { get; set; }

        /// <summary>
        /// The IPv6 CIDR blocks of the VPC.
        /// </summary>
        [NameInMap("Ipv6CidrBlock")]
        [Validation(Required=false)]
        public string Ipv6CidrBlock { get; set; }

        /// <summary>
        /// The type of the IPv6 CIDR block. Valid values:
        /// 
        /// *   **BGP** (default): Alibaba Cloud Border Gateway Protocol (BGP)
        /// *   **ChinaMobile**: China Mobile (single ISP).
        /// *   **ChinaUnicom**: China Unicom (single ISP).
        /// *   **ChinaTelecom**: China Telecom (single ISP).
        /// 
        /// >  If your Alibaba Cloud account is allowed to use single-ISP bandwidth, you can set this parameter to **ChinaTelecom**, **ChinaUnicom**, or **ChinaMobile**.
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
        /// The ID of the region to which the VPC belongs.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// 
        /// For more information about resource groups, see [What is a resource group?](~~94475~~)
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The user CIDR block. Separate user CIDR blocks with commas (,). You can specify up to three user CIDR blocks.
        /// 
        /// For more information about user CIDR blocks, see the `What is a user CIDR block?` section in [VPC FAQ](~~185311~~).
        /// </summary>
        [NameInMap("UserCidr")]
        [Validation(Required=false)]
        public string UserCidr { get; set; }

        /// <summary>
        /// The name of the VPC.
        /// 
        /// The name must be 1 to 128 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("VpcName")]
        [Validation(Required=false)]
        public string VpcName { get; set; }

    }

}
