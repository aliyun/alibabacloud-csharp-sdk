// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeNetworkInterfacesResponseBody : TeaModel {
        /// <summary>
        /// Details about the ENIs.
        /// </summary>
        [NameInMap("NetworkInterfaceSets")]
        [Validation(Required=false)]
        public DescribeNetworkInterfacesResponseBodyNetworkInterfaceSets NetworkInterfaceSets { get; set; }
        public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSets : TeaModel {
            [NameInMap("NetworkInterfaceSet")]
            [Validation(Required=false)]
            public List<DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSet> NetworkInterfaceSet { get; set; }
            public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSet : TeaModel {
                /// <summary>
                /// The EIPs that are associated with the secondary private IP addresses of the ENI.
                /// </summary>
                [NameInMap("AssociatedPublicIp")]
                [Validation(Required=false)]
                public DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetAssociatedPublicIp AssociatedPublicIp { get; set; }
                public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetAssociatedPublicIp : TeaModel {
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
                /// >  This parameter is in invitational preview and is not publicly available.
                /// </summary>
                [NameInMap("Attachment")]
                [Validation(Required=false)]
                public DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetAttachment Attachment { get; set; }
                public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetAttachment : TeaModel {
                    /// <summary>
                    /// >  This parameter is in invitational preview and is not publicly available.
                    /// </summary>
                    [NameInMap("DeviceIndex")]
                    [Validation(Required=false)]
                    public int? DeviceIndex { get; set; }

                    /// <summary>
                    /// >  This parameter is in invitational preview and is not publicly available.
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// The index of the network card.
                    /// 
                    /// *   If the ENI is in the Available state or if no network card index was specified when the ENI was attached, this parameter is empty.
                    /// *   If the ENI is in the InUse state and a network card index was specified when the ENI was attached, the specified network card index is returned as the value of this parameter.
                    /// </summary>
                    [NameInMap("NetworkCardIndex")]
                    [Validation(Required=false)]
                    public int? NetworkCardIndex { get; set; }

                    /// <summary>
                    /// >  This parameter is in invitational preview and is not publicly available.
                    /// </summary>
                    [NameInMap("TrunkNetworkInterfaceId")]
                    [Validation(Required=false)]
                    public string TrunkNetworkInterfaceId { get; set; }

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
                /// The ID of the Elastic Compute Service (ECS) instance to which the ENI is attached.
                /// 
                /// >  If the ENI is managed by other Alibaba Cloud services, no instance ID is returned.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The IPv4 prefixes of the ENI.
                /// </summary>
                [NameInMap("Ipv4PrefixSets")]
                [Validation(Required=false)]
                public DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetIpv4PrefixSets Ipv4PrefixSets { get; set; }
                public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetIpv4PrefixSets : TeaModel {
                    [NameInMap("Ipv4PrefixSet")]
                    [Validation(Required=false)]
                    public List<DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetIpv4PrefixSetsIpv4PrefixSet> Ipv4PrefixSet { get; set; }
                    public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetIpv4PrefixSetsIpv4PrefixSet : TeaModel {
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
                public DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetIpv6PrefixSets Ipv6PrefixSets { get; set; }
                public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetIpv6PrefixSets : TeaModel {
                    [NameInMap("Ipv6PrefixSet")]
                    [Validation(Required=false)]
                    public List<DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetIpv6PrefixSetsIpv6PrefixSet> Ipv6PrefixSet { get; set; }
                    public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetIpv6PrefixSetsIpv6PrefixSet : TeaModel {
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
                public DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetIpv6Sets Ipv6Sets { get; set; }
                public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetIpv6Sets : TeaModel {
                    [NameInMap("Ipv6Set")]
                    [Validation(Required=false)]
                    public List<DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetIpv6SetsIpv6Set> Ipv6Set { get; set; }
                    public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetIpv6SetsIpv6Set : TeaModel {
                        /// <summary>
                        /// The IPv6 address of the ENI.
                        /// </summary>
                        [NameInMap("Ipv6Address")]
                        [Validation(Required=false)]
                        public string Ipv6Address { get; set; }

                    }

                }

                /// <summary>
                /// The MAC address of the ENI.
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
                /// The communication mode of the ENI. Valid values:
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
                /// The primary private IP address of the ENI.
                /// </summary>
                [NameInMap("PrivateIpAddress")]
                [Validation(Required=false)]
                public string PrivateIpAddress { get; set; }

                /// <summary>
                /// Details about the private IP addresses of the ENI.
                /// </summary>
                [NameInMap("PrivateIpSets")]
                [Validation(Required=false)]
                public DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetPrivateIpSets PrivateIpSets { get; set; }
                public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetPrivateIpSets : TeaModel {
                    [NameInMap("PrivateIpSet")]
                    [Validation(Required=false)]
                    public List<DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetPrivateIpSetsPrivateIpSet> PrivateIpSet { get; set; }
                    public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetPrivateIpSetsPrivateIpSet : TeaModel {
                        /// <summary>
                        /// The elastic IP address (EIP) that is associated with the private IP address.
                        /// </summary>
                        [NameInMap("AssociatedPublicIp")]
                        [Validation(Required=false)]
                        public DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetPrivateIpSetsPrivateIpSetAssociatedPublicIp AssociatedPublicIp { get; set; }
                        public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetPrivateIpSetsPrivateIpSetAssociatedPublicIp : TeaModel {
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
                        /// Indicates whether the private IP address is the primary private IP address. Valid values:
                        /// 
                        /// *   true: The IP address is the primary private IP address.
                        /// *   false: The IP address is a secondary private IP address.
                        /// </summary>
                        [NameInMap("Primary")]
                        [Validation(Required=false)]
                        public bool? Primary { get; set; }

                        /// <summary>
                        /// >  This parameter is in invitational preview and is not publicly available.
                        /// </summary>
                        [NameInMap("PrivateDnsName")]
                        [Validation(Required=false)]
                        public string PrivateDnsName { get; set; }

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
                /// *   If the ENI is a secondary ENI in the InUse state and the number of queues supported by the ENI has never been modified, the default number of queues per secondary ENI that the instance type supports is returned.
                /// *   If the ENI is a secondary ENI and the number of queues supported by the ENI has been modified, the new number of queues is returned.
                /// *   If the ENI is a secondary ENI in the Available state and the number of queues supported by the ENI has never been modified, an empty value is returned.
                /// *   If the ENI is a primary ENI, the default number of queues per primary ENI that the instance type supports is returned.
                /// </summary>
                [NameInMap("QueueNumber")]
                [Validation(Required=false)]
                public int? QueueNumber { get; set; }

                /// <summary>
                /// >  This parameter is in invitational preview and is not publicly available.
                /// </summary>
                [NameInMap("QueuePairNumber")]
                [Validation(Required=false)]
                public int? QueuePairNumber { get; set; }

                /// <summary>
                /// The ID of the resource group to which the ENI belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The security groups to which the ENI belongs.
                /// </summary>
                [NameInMap("SecurityGroupIds")]
                [Validation(Required=false)]
                public DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetSecurityGroupIds SecurityGroupIds { get; set; }
                public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetSecurityGroupIds : TeaModel {
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
                /// The state of the ENI.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The tags of the ENI.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetTags Tags { get; set; }
                public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetTagsTag> Tag { get; set; }
                    public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetTagsTag : TeaModel {
                        /// <summary>
                        /// The tag key.
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// The tag value.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// The type of the ENI.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The ID of the vSwitch.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The ID of the VPC to which the ENI belongs.
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

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// 
        /// > This parameter will be removed in the future. We recommend that you use the NextToken and MaxResults parameters for a paged query.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// 
        /// > This parameter will be removed in the future. We recommend that you use the NextToken and MaxResults parameters for a paged query.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of ENIs.
        /// 
        /// > If you specify the `MaxResults` and `NextToken` parameters to perform a paged query, the value of the `TotalCount` response parameter is invalid.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
