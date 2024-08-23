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
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The **token** can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](https://help.aliyun.com/document_detail/25693.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// >  This parameter is not publicly available.
        /// </summary>
        [NameInMap("ConnectionTrackingConfiguration")]
        [Validation(Required=false)]
        public CreateNetworkInterfaceRequestConnectionTrackingConfiguration ConnectionTrackingConfiguration { get; set; }
        public class CreateNetworkInterfaceRequestConnectionTrackingConfiguration : TeaModel {
            /// <summary>
            /// >  This parameter is not publicly available.
            /// </summary>
            [NameInMap("TcpClosedAndTimeWaitTimeout")]
            [Validation(Required=false)]
            public int? TcpClosedAndTimeWaitTimeout { get; set; }

            /// <summary>
            /// >  This parameter is not publicly available.
            /// </summary>
            [NameInMap("TcpEstablishedTimeout")]
            [Validation(Required=false)]
            public int? TcpEstablishedTimeout { get; set; }

            /// <summary>
            /// >  This parameter is not publicly available.
            /// </summary>
            [NameInMap("UdpTimeout")]
            [Validation(Required=false)]
            public int? UdpTimeout { get; set; }

        }

        /// <summary>
        /// Specifies whether to release the ENI when the associated instance is released. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
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
        /// >  This parameter is unavailable.
        /// </summary>
        [NameInMap("EnhancedNetwork")]
        [Validation(Required=false)]
        public CreateNetworkInterfaceRequestEnhancedNetwork EnhancedNetwork { get; set; }
        public class CreateNetworkInterfaceRequestEnhancedNetwork : TeaModel {
            /// <summary>
            /// >  This parameter is not publicly available.
            /// </summary>
            [NameInMap("EnableSriov")]
            [Validation(Required=false)]
            public bool? EnableSriov { get; set; }

        }

        /// <summary>
        /// The type of the ENI. Valid values:
        /// 
        /// *   Secondary: secondary ENI.
        /// *   Trunk: trunk ENI. This value is in invitational preview.
        /// 
        /// Default value: Secondary.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// IPv4 prefixes to assign to the ENI. Valid values of N: 1 to 10.
        /// 
        /// >  To assign IPv4 prefixes to the ENI, you must specify the Ipv4Prefix.N or Ipv4PrefixCount parameter, but not both.
        /// </summary>
        [NameInMap("Ipv4Prefix")]
        [Validation(Required=false)]
        public List<string> Ipv4Prefix { get; set; }

        /// <summary>
        /// The number of IPv4 prefixes to assign to the ENI. Valid values: 1 to 10.
        /// 
        /// >  To assign IPv4 prefixes to the ENI, you must specify the Ipv4Prefix.N or Ipv4PrefixCount parameter, but not both.
        /// </summary>
        [NameInMap("Ipv4PrefixCount")]
        [Validation(Required=false)]
        public int? Ipv4PrefixCount { get; set; }

        /// <summary>
        /// IPv6 addresses to assign to the ENI. Valid values of N: 1 to 10.
        /// 
        /// Example: Ipv6Address.1=2001:db8:1234:1a00::\\*\\*\\*\\*
        /// 
        /// >  To assign IPv6 addresses to the ENI, you must specify the `Ipv6Addresses.N` or `Ipv6AddressCount` parameter, but not both.
        /// </summary>
        [NameInMap("Ipv6Address")]
        [Validation(Required=false)]
        public List<string> Ipv6Address { get; set; }

        /// <summary>
        /// The number of IPv6 addresses to randomly generate for the ENI. Valid values: 1 to 10.
        /// 
        /// >  To assign IPv6 addresses to the ENI, you must specify the `Ipv6Addresses.N` or `Ipv6AddressCount` parameter, but not both.
        /// </summary>
        [NameInMap("Ipv6AddressCount")]
        [Validation(Required=false)]
        public int? Ipv6AddressCount { get; set; }

        /// <summary>
        /// IPv6 prefixes to assign to the ENI. Valid values of N: 1 to 10.
        /// 
        /// >  To assign IPv6 prefixes to the ENI, you must specify the Ipv6Prefix.N or Ipv6PrefixCount parameter, but not both.
        /// </summary>
        [NameInMap("Ipv6Prefix")]
        [Validation(Required=false)]
        public List<string> Ipv6Prefix { get; set; }

        /// <summary>
        /// The number of IPv6 prefixes to assign to the ENI. Valid values: 1 to 10.
        /// 
        /// >  To assign IPv6 prefixes to the ENI, you must specify the Ipv6Prefix.N or Ipv6PrefixCount parameter, but not both.
        /// </summary>
        [NameInMap("Ipv6PrefixCount")]
        [Validation(Required=false)]
        public int? Ipv6PrefixCount { get; set; }

        /// <summary>
        /// The name of the ENI. The name must be 2 to 128 characters in length and can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).
        /// 
        /// This parameter is left empty by default.
        /// </summary>
        [NameInMap("NetworkInterfaceName")]
        [Validation(Required=false)]
        public string NetworkInterfaceName { get; set; }

        /// <summary>
        /// The communication settings of the ENI.
        /// </summary>
        [NameInMap("NetworkInterfaceTrafficConfig")]
        [Validation(Required=false)]
        public CreateNetworkInterfaceRequestNetworkInterfaceTrafficConfig NetworkInterfaceTrafficConfig { get; set; }
        public class CreateNetworkInterfaceRequestNetworkInterfaceTrafficConfig : TeaModel {
            /// <summary>
            /// The communication mode of the ENI.
            /// </summary>
            [NameInMap("NetworkInterfaceTrafficMode")]
            [Validation(Required=false)]
            public string NetworkInterfaceTrafficMode { get; set; }

            /// <summary>
            /// The number of queues supported by the ENI.
            /// </summary>
            [NameInMap("QueueNumber")]
            [Validation(Required=false)]
            public int? QueueNumber { get; set; }

            /// <summary>
            /// The number of queues supported by the ERI.
            /// </summary>
            [NameInMap("QueuePairNumber")]
            [Validation(Required=false)]
            public int? QueuePairNumber { get; set; }

            /// <summary>
            /// The receive (Rx) queue depth of the ENI.
            /// </summary>
            [NameInMap("RxQueueSize")]
            [Validation(Required=false)]
            public int? RxQueueSize { get; set; }

            /// <summary>
            /// The transmit (Tx) queue depth of the ENI.
            /// </summary>
            [NameInMap("TxQueueSize")]
            [Validation(Required=false)]
            public int? TxQueueSize { get; set; }

        }

        /// <summary>
        /// The communication mode of the ENI. Valid values:
        /// 
        /// *   Standard: uses the TCP communication mode.
        /// *   HighPerformance: uses the remote direct memory access (RDMA) communication mode with Elastic RDMA Interface (ERI) enabled.
        /// 
        /// >  ENIs in RDMA mode can be attached only to instances of the instance types that support ERIs. The number of ENIs in RDMA mode that are attached to an instance cannot exceed the maximum number of ENIs that the instance type supports. For more information, see [Overview of ECS instance families](https://help.aliyun.com/document_detail/25378.html) and [Configure eRDMA on an enterprise-level instance](https://help.aliyun.com/document_detail/336853.html).
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
        /// Secondary private IP addresses to assign to the ENI. The IP addresses must be idle IP addresses in the CIDR block of the vSwitch with which to associate the ENI. Valid values of N: 0 to 10.
        /// 
        /// >  To assign secondary private IP addresses to the ENI, you can specify the `PrivateIpAddress.N` or `SecondaryPrivateIpAddressCount` parameter, but not both.
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public List<string> PrivateIpAddress { get; set; }

        /// <summary>
        /// The number of queues supported by the ENI. Valid values: 1 to 2048.
        /// 
        /// When you attach the ENI to an instance, make sure that the value of this parameter is less than the maximum number of queues per ENI that is allowed for the instance type. To view the maximum number of queues per ENI allowed for an instance type, you can call the [DescribeInstanceTypes](https://help.aliyun.com/document_detail/25620.html) operation and then check the return value of `MaximumQueueNumberPerEni`.
        /// 
        /// This parameter is left empty by default. If you do not specify this parameter, the default number of queues per ENI for the instance type of an instance is used when you attach the ENI to the instance. To view the default number of queues per ENI for an instance type, you can call the [DescribeInstanceTypes](https://help.aliyun.com/document_detail/25620.html) operation and then check the return value of `SecondaryEniQueueNumber`.
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
        /// The region in which to create the ENI. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which you want to assign the ENI. You can call the [ListResourceGroups](https://help.aliyun.com/document_detail/158855.html) operation to query the most recent resource group list.
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
        /// The receive (Rx) queue depth of the ENI.
        /// 
        /// Take note of the following items:
        /// 
        /// *   The Rx queue depth of an ENI must be the same as the Tx queue depth of the ENI. Valid values: powers of 2 in the range of 8192 to 16384.
        /// *   A larger Rx queue depth yields higher inbound throughput but consumes more memory.
        /// </summary>
        [NameInMap("RxQueueSize")]
        [Validation(Required=false)]
        public int? RxQueueSize { get; set; }

        /// <summary>
        /// The number of private IP addresses to be assigned by ECS. Valid values: 1 to 49.
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
        /// The IDs of security groups to which to assign the ENI. The security groups and the ENI must belong to the same VPC. The valid values of N are determined based on the maximum number of security groups to which an ENI can be assigned. For more information, see [Limits](https://help.aliyun.com/document_detail/25412.html).
        /// 
        /// >  You must specify `SecurityGroupId` or `SecurityGroupIds.N` but not both.
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
            /// The key of tag N to add to the ENI. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N to add to the ENI. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The transmit (Tx) queue depth of the ENI.
        /// 
        /// Take note of the following items:
        /// 
        /// *   The Tx queue depth of an ENI must be the same as the Rx queue depth of the ENI. Valid values: powers of 2 in the range of 8192 to 16384.
        /// *   A larger Tx queue depth yields higher outbound throughput but consumes more memory.
        /// </summary>
        [NameInMap("TxQueueSize")]
        [Validation(Required=false)]
        public int? TxQueueSize { get; set; }

        /// <summary>
        /// The ID of the vSwitch with which to associate the ENI. Private IP addresses are assigned to the ENI from within the CIDR block of the vSwitch.
        /// 
        /// This parameter is required.
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
