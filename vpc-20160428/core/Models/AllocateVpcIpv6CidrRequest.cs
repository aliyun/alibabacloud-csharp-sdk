// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AllocateVpcIpv6CidrRequest : TeaModel {
        /// <summary>
        /// The type of the IPv6 address pool. Set the value to **custom**.
        /// 
        /// >  This parameter is required.
        /// </summary>
        [NameInMap("AddressPoolType")]
        [Validation(Required=false)]
        public string AddressPoolType { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that it is unique among different requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, the system automatically uses **RequestId** as **ClientToken**. **RequestId** of each API request may be different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The IPv6 CIDR block that you want to reserve.
        /// </summary>
        [NameInMap("Ipv6CidrBlock")]
        [Validation(Required=false)]
        public string Ipv6CidrBlock { get; set; }

        /// <summary>
        /// The type of the IPv6 CIDR block. Valid values:
        /// 
        /// *   **BGP**: Alibaba Cloud Border Gateway Protocol (BGP) IPv6. This is the default value.
        /// *   **ChinaMobile**: China Mobile (single ISP).
        /// *   **ChinaUnicom**: China Unicom (single ISP).
        /// *   **ChinaTelecom**: China Telecom (single ISP).
        /// 
        /// > 
        /// 
        /// *   If your Alibaba Cloud account is allowed to use single-ISP bandwidth, valid values are: **ChinaTelecom**, **ChinaUnicom**, and **ChinaMobile**.
        /// *   You can reserve only one IPv6 CIDR block of each type. After a reserved IPv6 CIDR block of a type is allocated to a VPC, you can reserve another IPv6 CIDR of the type.
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

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
