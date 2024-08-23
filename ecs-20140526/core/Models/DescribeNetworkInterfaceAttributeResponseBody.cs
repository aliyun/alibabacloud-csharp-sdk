// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeNetworkInterfaceAttributeResponseBody : TeaModel {
        /// <summary>
        /// Details about the elastic IP address (EIP) that is associated with the secondary private IP address of the ENI.
        /// </summary>
        [NameInMap("AssociatedPublicIp")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyAssociatedPublicIp AssociatedPublicIp { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyAssociatedPublicIp : TeaModel {
            /// <summary>
            /// The ID of the EIP.
            /// </summary>
            [NameInMap("AllocationId")]
            [Validation(Required=false)]
            public string AllocationId { get; set; }

            /// <summary>
            /// The EIP.
            /// </summary>
            [NameInMap("PublicIpAddress")]
            [Validation(Required=false)]
            public string PublicIpAddress { get; set; }

        }

        /// <summary>
        /// >  This parameter is in invitational preview and unavailable for general users.
        /// </summary>
        [NameInMap("Attachment")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyAttachment Attachment { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyAttachment : TeaModel {
            /// <summary>
            /// >  This parameter is in invitational preview and unavailable for general users.
            /// </summary>
            [NameInMap("DeviceIndex")]
            [Validation(Required=false)]
            public int? DeviceIndex { get; set; }

            /// <summary>
            /// >  This parameter is in invitational preview and unavailable for general users.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// >  This parameter is in invitational preview and unavailable for general users.
            /// </summary>
            [NameInMap("MemberNetworkInterfaceIds")]
            [Validation(Required=false)]
            public DescribeNetworkInterfaceAttributeResponseBodyAttachmentMemberNetworkInterfaceIds MemberNetworkInterfaceIds { get; set; }
            public class DescribeNetworkInterfaceAttributeResponseBodyAttachmentMemberNetworkInterfaceIds : TeaModel {
                [NameInMap("MemberNetworkInterfaceId")]
                [Validation(Required=false)]
                public List<string> MemberNetworkInterfaceId { get; set; }

            }

            /// <summary>
            /// The index of the network interface controller (NIC).
            /// 
            /// *   If the ENI is in the Available state or if no NIC index was specified when the ENI was attached, this parameter has no value.
            /// *   If the ENI is in the InUse state and an NIC index was specified when the ENI was attached, the specified NIC index is returned as the value of this parameter.
            /// </summary>
            [NameInMap("NetworkCardIndex")]
            [Validation(Required=false)]
            public int? NetworkCardIndex { get; set; }

            /// <summary>
            /// >  This parameter is in invitational preview and unavailable for general users.
            /// </summary>
            [NameInMap("TrunkNetworkInterfaceId")]
            [Validation(Required=false)]
            public string TrunkNetworkInterfaceId { get; set; }

        }

        /// <summary>
        /// >  This parameter is in invitational preview and unavailable for general users.
        /// </summary>
        [NameInMap("BondInterfaceSpecification")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyBondInterfaceSpecification BondInterfaceSpecification { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyBondInterfaceSpecification : TeaModel {
            /// <summary>
            /// >  This parameter is in invitational preview and unavailable for general users.
            /// </summary>
            [NameInMap("BondMode")]
            [Validation(Required=false)]
            public string BondMode { get; set; }

            /// <summary>
            /// >  This parameter is in invitational preview and unavailable for general users.
            /// </summary>
            [NameInMap("SlaveInterfaceSpecification")]
            [Validation(Required=false)]
            public DescribeNetworkInterfaceAttributeResponseBodyBondInterfaceSpecificationSlaveInterfaceSpecification SlaveInterfaceSpecification { get; set; }
            public class DescribeNetworkInterfaceAttributeResponseBodyBondInterfaceSpecificationSlaveInterfaceSpecification : TeaModel {
                [NameInMap("SlaveInterfaceSpecificationSet")]
                [Validation(Required=false)]
                public List<DescribeNetworkInterfaceAttributeResponseBodyBondInterfaceSpecificationSlaveInterfaceSpecificationSlaveInterfaceSpecificationSet> SlaveInterfaceSpecificationSet { get; set; }
                public class DescribeNetworkInterfaceAttributeResponseBodyBondInterfaceSpecificationSlaveInterfaceSpecificationSlaveInterfaceSpecificationSet : TeaModel {
                    /// <summary>
                    /// >  This parameter is in invitational preview and is not publicly available.
                    /// </summary>
                    [NameInMap("BondNetworkInterfaceId")]
                    [Validation(Required=false)]
                    public string BondNetworkInterfaceId { get; set; }

                    /// <summary>
                    /// >  This parameter is in invitational preview and is not publicly available.
                    /// </summary>
                    [NameInMap("SlaveNetworkInterfaceId")]
                    [Validation(Required=false)]
                    public string SlaveNetworkInterfaceId { get; set; }

                    /// <summary>
                    /// >  This parameter is in invitational preview and is not publicly available.
                    /// </summary>
                    [NameInMap("WorkState")]
                    [Validation(Required=false)]
                    public string WorkState { get; set; }

                }

            }

        }

        /// <summary>
        /// >  This parameter is not publicly available.
        /// </summary>
        [NameInMap("ConnectionTrackingConfiguration")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyConnectionTrackingConfiguration ConnectionTrackingConfiguration { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyConnectionTrackingConfiguration : TeaModel {
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
        /// The time when the ENI was created.
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// Indicates whether to retain the ENI when the associated instance is released. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("DeleteOnRelease")]
        [Validation(Required=false)]
        public bool? DeleteOnRelease { get; set; }

        /// <summary>
        /// The description of the ENI.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// This parameter is not publicly available.
        /// </summary>
        [NameInMap("EnhancedNetwork")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyEnhancedNetwork EnhancedNetwork { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyEnhancedNetwork : TeaModel {
            /// <summary>
            /// This parameter is not publicly available.
            /// </summary>
            [NameInMap("EnableSriov")]
            [Validation(Required=false)]
            public bool? EnableSriov { get; set; }

        }

        /// <summary>
        /// The ID of the instance to which the ENI is attached.
        /// 
        /// >  If the ENI is managed and controlled by other Alibaba Cloud services, no instance ID is returned.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The IPv4 prefixes of the ENI.
        /// </summary>
        [NameInMap("Ipv4PrefixSets")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyIpv4PrefixSets Ipv4PrefixSets { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyIpv4PrefixSets : TeaModel {
            [NameInMap("Ipv4PrefixSet")]
            [Validation(Required=false)]
            public List<DescribeNetworkInterfaceAttributeResponseBodyIpv4PrefixSetsIpv4PrefixSet> Ipv4PrefixSet { get; set; }
            public class DescribeNetworkInterfaceAttributeResponseBodyIpv4PrefixSetsIpv4PrefixSet : TeaModel {
                /// <summary>
                /// The IPv4 prefix of the ENI.
                /// </summary>
                [NameInMap("Ipv4Prefix")]
                [Validation(Required=false)]
                public string Ipv4Prefix { get; set; }

            }

        }

        /// <summary>
        /// The IPv6 prefixes of the ENI.
        /// </summary>
        [NameInMap("Ipv6PrefixSets")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyIpv6PrefixSets Ipv6PrefixSets { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyIpv6PrefixSets : TeaModel {
            [NameInMap("Ipv6PrefixSet")]
            [Validation(Required=false)]
            public List<DescribeNetworkInterfaceAttributeResponseBodyIpv6PrefixSetsIpv6PrefixSet> Ipv6PrefixSet { get; set; }
            public class DescribeNetworkInterfaceAttributeResponseBodyIpv6PrefixSetsIpv6PrefixSet : TeaModel {
                /// <summary>
                /// The IPv6 prefix of the ENI.
                /// </summary>
                [NameInMap("Ipv6Prefix")]
                [Validation(Required=false)]
                public string Ipv6Prefix { get; set; }

            }

        }

        /// <summary>
        /// The IPv6 addresses of the ENI.
        /// </summary>
        [NameInMap("Ipv6Sets")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyIpv6Sets Ipv6Sets { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyIpv6Sets : TeaModel {
            [NameInMap("Ipv6Set")]
            [Validation(Required=false)]
            public List<DescribeNetworkInterfaceAttributeResponseBodyIpv6SetsIpv6Set> Ipv6Set { get; set; }
            public class DescribeNetworkInterfaceAttributeResponseBodyIpv6SetsIpv6Set : TeaModel {
                /// <summary>
                /// The IPv6 address of the ENI.
                /// </summary>
                [NameInMap("Ipv6Address")]
                [Validation(Required=false)]
                public string Ipv6Address { get; set; }

            }

        }

        /// <summary>
        /// The media access control (MAC) address of the ENI.
        /// </summary>
        [NameInMap("MacAddress")]
        [Validation(Required=false)]
        public string MacAddress { get; set; }

        /// <summary>
        /// The ID of the ENI.
        /// </summary>
        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// The name of the ENI.
        /// </summary>
        [NameInMap("NetworkInterfaceName")]
        [Validation(Required=false)]
        public string NetworkInterfaceName { get; set; }

        /// <summary>
        /// The communication settings of the ENI.
        /// </summary>
        [NameInMap("NetworkInterfaceTrafficConfig")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyNetworkInterfaceTrafficConfig NetworkInterfaceTrafficConfig { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyNetworkInterfaceTrafficConfig : TeaModel {
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

        }

        /// <summary>
        /// The communication model of the ENI. Valid values:
        /// 
        /// *   Standard: The TCP communication mode is used.
        /// *   HighPerformance: The Elastic RDMA Interface (ERI) is enabled and the remote direct memory access (RDMA) communication mode is used.
        /// 
        /// >  This parameter can have a value of HighPerformance only when the ENI is attached to a c7re RDMA-enhanced instance that resides in Beijing Zone K.
        /// </summary>
        [NameInMap("NetworkInterfaceTrafficMode")]
        [Validation(Required=false)]
        public string NetworkInterfaceTrafficMode { get; set; }

        /// <summary>
        /// The ID of the account to which the ENI belongs.
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// The private IP address of the ENI.
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// The private IP addresses of the ENI.
        /// </summary>
        [NameInMap("PrivateIpSets")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyPrivateIpSets PrivateIpSets { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyPrivateIpSets : TeaModel {
            [NameInMap("PrivateIpSet")]
            [Validation(Required=false)]
            public List<DescribeNetworkInterfaceAttributeResponseBodyPrivateIpSetsPrivateIpSet> PrivateIpSet { get; set; }
            public class DescribeNetworkInterfaceAttributeResponseBodyPrivateIpSetsPrivateIpSet : TeaModel {
                /// <summary>
                /// The EIP that is associated with the secondary private IP address of the ENI.
                /// </summary>
                [NameInMap("AssociatedPublicIp")]
                [Validation(Required=false)]
                public DescribeNetworkInterfaceAttributeResponseBodyPrivateIpSetsPrivateIpSetAssociatedPublicIp AssociatedPublicIp { get; set; }
                public class DescribeNetworkInterfaceAttributeResponseBodyPrivateIpSetsPrivateIpSetAssociatedPublicIp : TeaModel {
                    /// <summary>
                    /// >  This parameter is in invitational preview and is not publicly available.
                    /// </summary>
                    [NameInMap("AllocationId")]
                    [Validation(Required=false)]
                    public string AllocationId { get; set; }

                    /// <summary>
                    /// The EIP.
                    /// </summary>
                    [NameInMap("PublicIpAddress")]
                    [Validation(Required=false)]
                    public string PublicIpAddress { get; set; }

                }

                /// <summary>
                /// Indicates whether the IP address is the primary private IP address. Valid values:
                /// 
                /// *   true: The IP address is the primary private IP address.
                /// *   false: The IP address is a secondary private IP address.
                /// </summary>
                [NameInMap("Primary")]
                [Validation(Required=false)]
                public bool? Primary { get; set; }

                /// <summary>
                /// The private IP address of the ENI.
                /// </summary>
                [NameInMap("PrivateIpAddress")]
                [Validation(Required=false)]
                public string PrivateIpAddress { get; set; }

            }

        }

        /// <summary>
        /// The number of queues supported by the ENI.
        /// 
        /// *   For a primary ENI: The default number of queues that the instance type supports for the ENI is returned.
        /// 
        /// *   For a secondary ENI:
        /// 
        ///     *   When the ENI is in the InUse state, the following situations occur for the QueueNumber parameter:
        /// 
        ///         *   If the number of queues supported by the ENI has not been modified, the default number of queues that the instance type supports for the ENI is returned.
        ///         *   If the number of queues supported by the ENI has been modified, the new number of queues is returned.
        /// 
        ///     *   When the ENI is in the Available state, the following situations occur for the QueueNumber parameter:
        /// 
        ///         *   If the number of queues supported by the ENI has not been modified, the return value is empty.
        ///         *   If the number of queues supported by the ENI has been modified, the new number of queues is returned.
        /// </summary>
        [NameInMap("QueueNumber")]
        [Validation(Required=false)]
        public int? QueueNumber { get; set; }

        /// <summary>
        /// >  This parameter is in invitational preview and unavailable for general users.
        /// </summary>
        [NameInMap("QueuePairNumber")]
        [Validation(Required=false)]
        public int? QueuePairNumber { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs. If this parameter is specified to query ENIs, up to 1,000 ENIs that belong to the specified resource group can be displayed in the response.
        /// 
        /// >  ENIs in the default resource group are displayed in the response regardless of how this parameter is set.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The IDs of the security groups to which the ENI belongs.
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodySecurityGroupIds SecurityGroupIds { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodySecurityGroupIds : TeaModel {
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public List<string> SecurityGroupId { get; set; }

        }

        /// <summary>
        /// The ID of the distributor to which the ENI belongs.
        /// </summary>
        [NameInMap("ServiceID")]
        [Validation(Required=false)]
        public long? ServiceID { get; set; }

        /// <summary>
        /// Indicates whether the user of the ENI is an Alibaba Cloud service or a distributor.
        /// </summary>
        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public bool? ServiceManaged { get; set; }

        /// <summary>
        /// >  This parameter is in invitational preview and unavailable for general users.
        /// </summary>
        [NameInMap("SlaveInterfaceSpecification")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodySlaveInterfaceSpecification SlaveInterfaceSpecification { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodySlaveInterfaceSpecification : TeaModel {
            /// <summary>
            /// >  This parameter is in invitational preview and unavailable for general users.
            /// </summary>
            [NameInMap("BondNetworkInterfaceId")]
            [Validation(Required=false)]
            public string BondNetworkInterfaceId { get; set; }

            /// <summary>
            /// >  This parameter is in invitational preview and unavailable for general users.
            /// </summary>
            [NameInMap("SlaveNetworkInterfaceId")]
            [Validation(Required=false)]
            public string SlaveNetworkInterfaceId { get; set; }

            /// <summary>
            /// >  This parameter is in invitational preview and unavailable for general users.
            /// </summary>
            [NameInMap("WorkState")]
            [Validation(Required=false)]
            public string WorkState { get; set; }

        }

        /// <summary>
        /// The state of the ENI. Valid values:
        /// 
        /// *   Available: The ENI is not attached to an instance.
        /// *   Attaching: The ENI is being attached to an instance.
        /// *   InUse: The ENI is attached to an instance.
        /// *   Detaching: The ENI is being detached from an instance.
        /// *   Deleting: The ENI is being deleted.
        /// 
        /// This parameter is empty by default, which indicates that all states are queried.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The tags of the ENI.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyTags Tags { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeNetworkInterfaceAttributeResponseBodyTagsTag> Tag { get; set; }
            public class DescribeNetworkInterfaceAttributeResponseBodyTagsTag : TeaModel {
                /// <summary>
                /// The tag key of the ENI.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The tag value of the ENI.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// >  This parameter is in invitational preview and is not publicly available.
        /// </summary>
        [NameInMap("TcpOptionAddressEnabled")]
        [Validation(Required=false)]
        public string TcpOptionAddressEnabled { get; set; }

        /// <summary>
        /// The type of the ENI. Valid values:
        /// 
        /// *   Primary
        /// *   Secondary
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The ID of the vSwitch to which the ENI is connected.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) to which the ENI belongs.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The zone ID of the ENI.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
