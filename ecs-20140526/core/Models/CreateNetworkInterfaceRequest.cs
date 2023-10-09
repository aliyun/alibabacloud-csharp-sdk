// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateNetworkInterfaceRequest : TeaModel {
        /// <summary>
        /// > This parameter is no longer used.
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The **token** can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](~~25693~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DeleteOnRelease")]
        [Validation(Required=false)]
        public bool? DeleteOnRelease { get; set; }

        /// <summary>
        /// The description of the ENI. The description must be 2 to 256 characters in length and cannot start with `http://` or `https://`.
        /// 
        /// This parameter is empty by default.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// > This parameter is no longer used.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// > 该参数正在邀测中，暂未开放使用。
        /// </summary>
        [NameInMap("Ipv4Prefix")]
        [Validation(Required=false)]
        public List<string> Ipv4Prefix { get; set; }

        /// <summary>
        /// > 该参数正在邀测中，暂未开放使用。
        /// </summary>
        [NameInMap("Ipv4PrefixCount")]
        [Validation(Required=false)]
        public int? Ipv4PrefixCount { get; set; }

        /// <summary>
        /// IPv6 address N to assign to the ENI. Valid values of N: 1 to 10.
        /// 
        /// Example: Ipv6Address.1=2001:db8:1234:1a00::\*\*\*\*
        /// 
        /// > To assign IPv6 addresses to the ENI, you must specify `Ipv6Addresses.N` or `Ipv6AddressCount` but not both.
        /// </summary>
        [NameInMap("Ipv6Address")]
        [Validation(Required=false)]
        public List<string> Ipv6Address { get; set; }

        /// <summary>
        /// The number of IPv6 addresses to randomly generate for the ENI. Valid values: 1 to 10.
        /// 
        /// > To assign IPv6 addresses to the ENI, you must specify `Ipv6Addresses.N` or `Ipv6AddressCount` but not both.
        /// </summary>
        [NameInMap("Ipv6AddressCount")]
        [Validation(Required=false)]
        public int? Ipv6AddressCount { get; set; }

        /// <summary>
        /// > 该参数正在邀测中，暂未开放使用。
        /// </summary>
        [NameInMap("Ipv6Prefix")]
        [Validation(Required=false)]
        public List<string> Ipv6Prefix { get; set; }

        /// <summary>
        /// > 该参数正在邀测中，暂未开放使用。
        /// </summary>
        [NameInMap("Ipv6PrefixCount")]
        [Validation(Required=false)]
        public int? Ipv6PrefixCount { get; set; }

        /// <summary>
        /// The name of the ENI. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with `http://` or `https://`. The name can contain letters, digits, colons (:), underscores (\_), and hyphens (-).
        /// 
        /// This parameter is empty by default.
        /// </summary>
        [NameInMap("NetworkInterfaceName")]
        [Validation(Required=false)]
        public string NetworkInterfaceName { get; set; }

        /// <summary>
        /// The communication model of the ENI. Valid values:
        /// 
        /// *   Standard: uses the TCP communication mode.
        /// *   HighPerformance: enables Elastic RDMA Interface (ERI) and uses the remote direct memory access (RDMA) communication mode.
        /// 
        /// > HighPerformance supports only the c7re RDMA-enhanced instance family. The maximum number of ENIs in the RDMA mode that can be attached to a c7re instance is determined by the instance type. The c7re instance family is in invitational preview in Beijing Zone K. For more information, see [Overview of instance families](~~25378~~).
        /// 
        /// Default value: Standard.
        /// </summary>
        [NameInMap("NetworkInterfaceTrafficMode")]
        [Validation(Required=false)]
        public string NetworkInterfaceTrafficMode { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The primary private IP address of the ENI.
        /// 
        /// The specified IP address must be an idle IP address within the CIDR block of the vSwitch with which to associate the ENI. If this parameter is not specified, an idle IP address is assigned from within the vSwitch CIDR block at random.
        /// </summary>
        [NameInMap("PrimaryIpAddress")]
        [Validation(Required=false)]
        public string PrimaryIpAddress { get; set; }

        /// <summary>
        /// Secondary private IP address N to assign to the ENI. This IP address must be an idle IP address within the CIDR block of the vSwitch with which to associate the ENI. Valid values of N: 0 to 10.
        /// 
        /// > To assign secondary private IP addresses to the ENI, you can specify `PrivateIpAddress.N` and `SecondaryPrivateIpAddressCount` but not both.
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public List<string> PrivateIpAddress { get; set; }

        /// <summary>
        /// The number of queues supported by the ENI. Valid values: 1 to 2048.
        /// 
        /// When you attach the ENI to an instance, make sure that the value of this parameter is less than the maximum number of queues per ENI that is allowed for the instance type. To view the maximum number of queues per ENI allowed for an instance type, you can call the [DescribeInstanceTypes](~~25620~~) operation and then check the return value of `MaximumQueueNumberPerEni`.
        /// 
        /// This parameter is left empty by default. If you do not specify this parameter, the default number of queues per ENI for the instance type of an instance is used when you attach the ENI to the instance. To view the default number of queues per ENI for an instance type, you can call the [DescribeInstanceTypes](~~25620~~) operation and then check the return value of `SecondaryEniQueueNumber`.
        /// </summary>
        [NameInMap("QueueNumber")]
        [Validation(Required=false)]
        public int? QueueNumber { get; set; }

        /// <summary>
        /// > This parameter is in invitational preview and is not publicly available.
        /// </summary>
        [NameInMap("QueuePairNumber")]
        [Validation(Required=false)]
        public int? QueuePairNumber { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which you want to assign the ENI. You can call the [ListResourceGroups](~~158855~~) operation to query the most recent resource group list.
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
        /// The number of private IP addresses to be automatically created by ECS.
        /// </summary>
        [NameInMap("SecondaryPrivateIpAddressCount")]
        [Validation(Required=false)]
        public int? SecondaryPrivateIpAddressCount { get; set; }

        /// <summary>
        /// The ID of the security group to which to assign the ENI. The security group and the ENI must belong to the same VPC.
        /// 
        /// > You must specify `SecurityGroupId` or `SecurityGroupIds.N` but not both.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// The ID of security group N to which to assign the ENI. The security group and the ENI must belong to the same VPC. The valid values of N are determined based on the maximum number of security groups to which an ENI can be assigned. For more information, see [Limits](~~25412~~).
        /// 
        /// **
        /// 
        /// You must specify **SecurityGroupId** or SecurityGroupIds.N but not both.````
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        /// <summary>
        /// The tags to add to the ENI.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateNetworkInterfaceRequestTag> Tag { get; set; }
        public class CreateNetworkInterfaceRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N to add to the ENI. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with acs: or aliyun. It cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N to add to the ENI. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length. It cannot start with acs: or contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the vSwitch with which to associate the ENI. Private IP addresses are assigned to the ENI from within the CIDR block of the vSwitch.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// > This parameter is no longer used.
        /// </summary>
        [NameInMap("Visible")]
        [Validation(Required=false)]
        public bool? Visible { get; set; }

    }

}
