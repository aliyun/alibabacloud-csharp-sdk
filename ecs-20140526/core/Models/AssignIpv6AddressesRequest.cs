// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class AssignIpv6AddressesRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.**** For more information, see [How to ensure idempotence](https://help.aliyun.com/document_detail/25693.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The IPv6 addresses to assign to the ENI. Valid values of N: 1 to 10.
        /// 
        /// Example: Ipv6Address.1=2001:db8:1234:1a00::\\*\\*\\*\\*
        /// 
        /// >  You must specify `Ipv6Addresses.N` or `Ipv6AddressCount`, but not both.
        /// </summary>
        [NameInMap("Ipv6Address")]
        [Validation(Required=false)]
        public List<string> Ipv6Address { get; set; }

        /// <summary>
        /// The number of IPv6 addresses to randomly generate for the ENI. Valid values: 1 to 10.
        /// 
        /// >  You must specify `Ipv6Addresses.N` or `Ipv6AddressCount`, but not both.
        /// </summary>
        [NameInMap("Ipv6AddressCount")]
        [Validation(Required=false)]
        public int? Ipv6AddressCount { get; set; }

        /// <summary>
        /// The IPv6 prefixes to assign to the ENI. Valid values of N: 1 to 10.
        /// 
        /// >  To assign IPv6 prefixes to the ENI, you must specify Ipv6Prefix.N or Ipv6PrefixCount, but not both.
        /// </summary>
        [NameInMap("Ipv6Prefix")]
        [Validation(Required=false)]
        public List<string> Ipv6Prefix { get; set; }

        /// <summary>
        /// The number of IPv6 prefixes to assign to the ENI. Valid values: 1 to 10.
        /// 
        /// >  To assign IPv6 prefixes to the ENI, you must specify Ipv6Prefix.N or Ipv6PrefixCount, but not both.
        /// </summary>
        [NameInMap("Ipv6PrefixCount")]
        [Validation(Required=false)]
        public int? Ipv6PrefixCount { get; set; }

        /// <summary>
        /// The ENI ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public string NetworkInterfaceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the ENI. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
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

    }

}
