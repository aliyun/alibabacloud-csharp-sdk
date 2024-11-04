// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeNetworkInterfacesResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the ENIs.</para>
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
                /// <para>The EIPs that are associated with the secondary private IP addresses of the ENI.</para>
                /// </summary>
                [NameInMap("AssociatedPublicIp")]
                [Validation(Required=false)]
                public DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetAssociatedPublicIp AssociatedPublicIp { get; set; }
                public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetAssociatedPublicIp : TeaModel {
                    /// <summary>
                    /// <remarks>
                    /// <para> This parameter is in invitational preview and is not publicly available.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("AllocationId")]
                    [Validation(Required=false)]
                    public string AllocationId { get; set; }

                    /// <summary>
                    /// <para>The EIP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><c>116.62.**.**</c></para>
                    /// </summary>
                    [NameInMap("PublicIpAddress")]
                    [Validation(Required=false)]
                    public string PublicIpAddress { get; set; }

                }

                /// <summary>
                /// <remarks>
                /// <para> This parameter is in invitational preview and is not publicly available.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Attachment")]
                [Validation(Required=false)]
                public DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetAttachment Attachment { get; set; }
                public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetAttachment : TeaModel {
                    /// <summary>
                    /// <remarks>
                    /// <para> This parameter is in invitational preview and is not publicly available.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("DeviceIndex")]
                    [Validation(Required=false)]
                    public int? DeviceIndex { get; set; }

                    /// <summary>
                    /// <remarks>
                    /// <para> This parameter is in invitational preview and is not publicly available.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The index of the network card.</para>
                    /// <list type="bullet">
                    /// <item><description>If the ENI is in the Available state or if no network card index was specified when the ENI was attached, this parameter is empty.</description></item>
                    /// <item><description>If the ENI is in the InUse state and a network card index was specified when the ENI was attached, the specified network card index is returned as the value of this parameter.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("NetworkCardIndex")]
                    [Validation(Required=false)]
                    public int? NetworkCardIndex { get; set; }

                    /// <summary>
                    /// <remarks>
                    /// <para> This parameter is in invitational preview and is not publicly available.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("TrunkNetworkInterfaceId")]
                    [Validation(Required=false)]
                    public string TrunkNetworkInterfaceId { get; set; }

                }

                /// <summary>
                /// <para>The time when the ENI was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-12-25T12:31:31Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>Indicates whether to retain the ENI when the associated instance is released. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DeleteOnRelease")]
                [Validation(Required=false)]
                public bool? DeleteOnRelease { get; set; }

                /// <summary>
                /// <para>The description of the ENI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DescriptionTest</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the Elastic Compute Service (ECS) instance to which the ENI is attached.</para>
                /// <remarks>
                /// <para> If the ENI is managed by other Alibaba Cloud services, no instance ID is returned.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp1e2l6djkndyuli****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The IPv4 prefixes of the ENI.</para>
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
                        /// <para>The IPv4 prefix of the ENI.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>hide</para>
                        /// </summary>
                        [NameInMap("Ipv4Prefix")]
                        [Validation(Required=false)]
                        public string Ipv4Prefix { get; set; }

                    }

                }

                /// <summary>
                /// <para>The IPv6 prefixes of the ENI.</para>
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
                        /// <para>The IPv6 prefix of the ENI.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>hide</para>
                        /// </summary>
                        [NameInMap("Ipv6Prefix")]
                        [Validation(Required=false)]
                        public string Ipv6Prefix { get; set; }

                    }

                }

                /// <summary>
                /// <para>The IPv6 addresses of the ENI.</para>
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
                        /// <para>The IPv6 address of the ENI.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2408:4321:180:1701:94c7:bc38:3bfa:****</para>
                        /// </summary>
                        [NameInMap("Ipv6Address")]
                        [Validation(Required=false)]
                        public string Ipv6Address { get; set; }

                    }

                }

                /// <summary>
                /// <para>The MAC address of the ENI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:16:3e:12:<b>:</b></para>
                /// </summary>
                [NameInMap("MacAddress")]
                [Validation(Required=false)]
                public string MacAddress { get; set; }

                /// <summary>
                /// <para>The ID of the ENI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eni-bp125p95hhdhn3ot****</para>
                /// </summary>
                [NameInMap("NetworkInterfaceId")]
                [Validation(Required=false)]
                public string NetworkInterfaceId { get; set; }

                /// <summary>
                /// <para>The name of the ENI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-eni-name</para>
                /// </summary>
                [NameInMap("NetworkInterfaceName")]
                [Validation(Required=false)]
                public string NetworkInterfaceName { get; set; }

                /// <summary>
                /// <para>The communication mode of the ENI. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Standard: The TCP communication mode is used.</description></item>
                /// <item><description>HighPerformance: The Elastic RDMA Interface (ERI) is enabled and the remote direct memory access (RDMA) communication mode is used.</description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter can have a value of HighPerformance only when the ENI is attached to a c7re RDMA-enhanced instance that resides in Beijing Zone K.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Standard</para>
                /// </summary>
                [NameInMap("NetworkInterfaceTrafficMode")]
                [Validation(Required=false)]
                public string NetworkInterfaceTrafficMode { get; set; }

                /// <summary>
                /// <para>The ID of the account to which the ENI belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456****</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                /// <summary>
                /// <para>The primary private IP address of the ENI.</para>
                /// 
                /// <b>Example:</b>
                /// <para><c>172.17.**.**</c></para>
                /// </summary>
                [NameInMap("PrivateIpAddress")]
                [Validation(Required=false)]
                public string PrivateIpAddress { get; set; }

                /// <summary>
                /// <para>Details about the private IP addresses of the ENI.</para>
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
                        /// <para>The elastic IP address (EIP) that is associated with the private IP address.</para>
                        /// </summary>
                        [NameInMap("AssociatedPublicIp")]
                        [Validation(Required=false)]
                        public DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetPrivateIpSetsPrivateIpSetAssociatedPublicIp AssociatedPublicIp { get; set; }
                        public class DescribeNetworkInterfacesResponseBodyNetworkInterfaceSetsNetworkInterfaceSetPrivateIpSetsPrivateIpSetAssociatedPublicIp : TeaModel {
                            /// <summary>
                            /// <remarks>
                            /// <para> This parameter is in invitational preview and is not publicly available.</para>
                            /// </remarks>
                            /// 
                            /// <b>Example:</b>
                            /// <para>null</para>
                            /// </summary>
                            [NameInMap("AllocationId")]
                            [Validation(Required=false)]
                            public string AllocationId { get; set; }

                            /// <summary>
                            /// <para>The EIP.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para><c>116.62.**.**</c></para>
                            /// </summary>
                            [NameInMap("PublicIpAddress")]
                            [Validation(Required=false)]
                            public string PublicIpAddress { get; set; }

                        }

                        /// <summary>
                        /// <para>Indicates whether the private IP address is the primary private IP address. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>true: The IP address is the primary private IP address.</description></item>
                        /// <item><description>false: The IP address is a secondary private IP address.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Primary")]
                        [Validation(Required=false)]
                        public bool? Primary { get; set; }

                        /// <summary>
                        /// <remarks>
                        /// <para> This parameter is in invitational preview and is not publicly available.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>DnsTestName</para>
                        /// </summary>
                        [NameInMap("PrivateDnsName")]
                        [Validation(Required=false)]
                        public string PrivateDnsName { get; set; }

                        /// <summary>
                        /// <para>The private IP address of the ENI.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><c>172.17.**.**</c></para>
                        /// </summary>
                        [NameInMap("PrivateIpAddress")]
                        [Validation(Required=false)]
                        public string PrivateIpAddress { get; set; }

                    }

                }

                /// <summary>
                /// <para>The number of queues supported by the ENI.</para>
                /// <list type="bullet">
                /// <item><description>If the ENI is a secondary ENI in the InUse state and the number of queues supported by the ENI has never been modified, the default number of queues per secondary ENI that the instance type supports is returned.</description></item>
                /// <item><description>If the ENI is a secondary ENI and the number of queues supported by the ENI has been modified, the new number of queues is returned.</description></item>
                /// <item><description>If the ENI is a secondary ENI in the Available state and the number of queues supported by the ENI has never been modified, an empty value is returned.</description></item>
                /// <item><description>If the ENI is a primary ENI, the default number of queues per primary ENI that the instance type supports is returned.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("QueueNumber")]
                [Validation(Required=false)]
                public int? QueueNumber { get; set; }

                /// <summary>
                /// <remarks>
                /// <para> This parameter is in invitational preview and is not publicly available.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("QueuePairNumber")]
                [Validation(Required=false)]
                public int? QueuePairNumber { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the ENI belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-2ze88m67qx5z****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The security groups to which the ENI belongs.</para>
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
                /// <para>The ID of the distributor to which the ENI belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345678910</para>
                /// </summary>
                [NameInMap("ServiceID")]
                [Validation(Required=false)]
                public long? ServiceID { get; set; }

                /// <summary>
                /// <para>Indicates whether the user of the ENI is an Alibaba Cloud service or a distributor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ServiceManaged")]
                [Validation(Required=false)]
                public bool? ServiceManaged { get; set; }

                /// <summary>
                /// <remarks>
                /// <para> This parameter is in invitational preview and is not publicly available.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("SourceDestCheck")]
                [Validation(Required=false)]
                public bool? SourceDestCheck { get; set; }

                /// <summary>
                /// <para>The state of the ENI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tags of the ENI.</para>
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
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestKey</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestValue</para>
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// <para>The type of the ENI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Secondary</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp16usj2p27htro3****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The ID of the VPC to which the ENI belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp1j7w3gc1cexjqd****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The zone ID of the ENI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-e</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// <remarks>
        /// <para>This parameter will be removed in the future. We recommend that you use the NextToken and MaxResults parameters for a paged query.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// <remarks>
        /// <para>This parameter will be removed in the future. We recommend that you use the NextToken and MaxResults parameters for a paged query.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of ENIs.</para>
        /// <remarks>
        /// <para>If you specify the <c>MaxResults</c> and <c>NextToken</c> parameters to perform a paged query, the value of the <c>TotalCount</c> response parameter is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
