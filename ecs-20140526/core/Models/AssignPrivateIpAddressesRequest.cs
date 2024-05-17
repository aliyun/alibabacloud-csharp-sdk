// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class AssignPrivateIpAddressesRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The **token** can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](https://help.aliyun.com/document_detail/25693.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The IPv4 prefixes to assign to the ENI. Valid values of N: 1 to 10.
        /// 
        /// >  To assign IPv4 prefixes to the ENI, you must specify the Ipv4Prefix.N or Ipv4PrefixCount parameter, but not both.
        /// </summary>
        [NameInMap("Ipv4Prefix")]
        [Validation(Required=false)]
        public List<string> Ipv4Prefix { get; set; }

        /// <summary>
        /// The number of IPv4 prefixes to be randomly generated for the ENI. Valid values: 1 to 10.
        /// 
        /// >  To assign IPv4 prefixes to the ENI, you must specify the Ipv4Prefix.N or Ipv4PrefixCount parameter, but not both.
        /// </summary>
        [NameInMap("Ipv4PrefixCount")]
        [Validation(Required=false)]
        public int? Ipv4PrefixCount { get; set; }

        /// <summary>
        /// The ID of the ENI.
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
        /// Secondary private IP address N to be automatically assigned from the CIDR block of the vSwitch that is connected to the ENI. Valid values of N:
        /// 
        /// *   When the ENI is in the Available (`Available`) state, the valid values of N are 1 to 50.
        /// *   When the ENI is in the InUse (`InUse`) state, the valid values of N are subject to the instance type. For more information, see [Overview of instance families](https://help.aliyun.com/document_detail/25378.html).
        /// 
        /// To assign secondary private IP addresses to the ENI, you must specify `PrivateIpAddress.N` or `SecondaryPrivateIpAddressCount` but not both.
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public List<string> PrivateIpAddress { get; set; }

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

        /// <summary>
        /// The number of private IP addresses to be automatically assigned from the CIDR block of the vSwitch that is connected to the ENI.
        /// 
        /// To assign secondary private IP addresses to the ENI, you must specify `PrivateIpAddress.N` or `SecondaryPrivateIpAddressCount` but not both.
        /// </summary>
        [NameInMap("SecondaryPrivateIpAddressCount")]
        [Validation(Required=false)]
        public int? SecondaryPrivateIpAddressCount { get; set; }

    }

}
