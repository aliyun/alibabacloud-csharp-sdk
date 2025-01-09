// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeNetworkInterfaceAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the elastic IP address (EIP) that is associated with the secondary private IP address of the ENI.</para>
        /// </summary>
        [NameInMap("AssociatedPublicIp")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyAssociatedPublicIp AssociatedPublicIp { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyAssociatedPublicIp : TeaModel {
            /// <summary>
            /// <para>The ID of the EIP.</para>
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
        /// <para> This parameter is in invitational preview and unavailable for general users.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Attachment")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyAttachment Attachment { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyAttachment : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para> This parameter is in invitational preview and unavailable for general users.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>hide</para>
            /// </summary>
            [NameInMap("DeviceIndex")]
            [Validation(Required=false)]
            public int? DeviceIndex { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is in invitational preview and unavailable for general users.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>hide</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is in invitational preview and unavailable for general users.</para>
            /// </remarks>
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
            /// <para>The index of the network interface controller (NIC).</para>
            /// <list type="bullet">
            /// <item><description>If the ENI is in the Available state or if no NIC index was specified when the ENI was attached, this parameter has no value.</description></item>
            /// <item><description>If the ENI is in the InUse state and an NIC index was specified when the ENI was attached, the specified NIC index is returned as the value of this parameter.</description></item>
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
            /// <para> This parameter is in invitational preview and unavailable for general users.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>hide</para>
            /// </summary>
            [NameInMap("TrunkNetworkInterfaceId")]
            [Validation(Required=false)]
            public string TrunkNetworkInterfaceId { get; set; }

        }

        /// <summary>
        /// <remarks>
        /// <para> This parameter is in invitational preview and unavailable for general users.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("BondInterfaceSpecification")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyBondInterfaceSpecification BondInterfaceSpecification { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyBondInterfaceSpecification : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para> This parameter is in invitational preview and unavailable for general users.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("BondMode")]
            [Validation(Required=false)]
            public string BondMode { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is in invitational preview and unavailable for general users.</para>
            /// </remarks>
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
                    /// <remarks>
                    /// <para> This parameter is in invitational preview and is not publicly available.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("BondNetworkInterfaceId")]
                    [Validation(Required=false)]
                    public string BondNetworkInterfaceId { get; set; }

                    /// <summary>
                    /// <remarks>
                    /// <para> This parameter is in invitational preview and is not publicly available.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("SlaveNetworkInterfaceId")]
                    [Validation(Required=false)]
                    public string SlaveNetworkInterfaceId { get; set; }

                    /// <summary>
                    /// <remarks>
                    /// <para> This parameter is in invitational preview and is not publicly available.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("WorkState")]
                    [Validation(Required=false)]
                    public string WorkState { get; set; }

                }

            }

        }

        /// <summary>
        /// <remarks>
        /// <para> This parameter is not publicly available.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ConnectionTrackingConfiguration")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyConnectionTrackingConfiguration ConnectionTrackingConfiguration { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyConnectionTrackingConfiguration : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para> This parameter is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TcpClosedAndTimeWaitTimeout")]
            [Validation(Required=false)]
            public int? TcpClosedAndTimeWaitTimeout { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>910</para>
            /// </summary>
            [NameInMap("TcpEstablishedTimeout")]
            [Validation(Required=false)]
            public int? TcpEstablishedTimeout { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("UdpTimeout")]
            [Validation(Required=false)]
            public int? UdpTimeout { get; set; }

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
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is not publicly available.</para>
        /// </summary>
        [NameInMap("EnhancedNetwork")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyEnhancedNetwork EnhancedNetwork { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyEnhancedNetwork : TeaModel {
            [NameInMap("EnableRss")]
            [Validation(Required=false)]
            public bool? EnableRss { get; set; }

            /// <summary>
            /// <para>This parameter is not publicly available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableSriov")]
            [Validation(Required=false)]
            public bool? EnableSriov { get; set; }

        }

        /// <summary>
        /// <para>The ID of the instance to which the ENI is attached.</para>
        /// <remarks>
        /// <para> If the ENI is managed and controlled by other Alibaba Cloud services, no instance ID is returned.</para>
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
        public DescribeNetworkInterfaceAttributeResponseBodyIpv4PrefixSets Ipv4PrefixSets { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyIpv4PrefixSets : TeaModel {
            [NameInMap("Ipv4PrefixSet")]
            [Validation(Required=false)]
            public List<DescribeNetworkInterfaceAttributeResponseBodyIpv4PrefixSetsIpv4PrefixSet> Ipv4PrefixSet { get; set; }
            public class DescribeNetworkInterfaceAttributeResponseBodyIpv4PrefixSetsIpv4PrefixSet : TeaModel {
                /// <summary>
                /// <para>The IPv4 prefix of the ENI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.**.0/28</para>
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
        public DescribeNetworkInterfaceAttributeResponseBodyIpv6PrefixSets Ipv6PrefixSets { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyIpv6PrefixSets : TeaModel {
            [NameInMap("Ipv6PrefixSet")]
            [Validation(Required=false)]
            public List<DescribeNetworkInterfaceAttributeResponseBodyIpv6PrefixSetsIpv6PrefixSet> Ipv6PrefixSet { get; set; }
            public class DescribeNetworkInterfaceAttributeResponseBodyIpv6PrefixSetsIpv6PrefixSet : TeaModel {
                /// <summary>
                /// <para>The IPv6 prefix of the ENI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2001:db8:1234:1a00:****::/80</para>
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
        public DescribeNetworkInterfaceAttributeResponseBodyIpv6Sets Ipv6Sets { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyIpv6Sets : TeaModel {
            [NameInMap("Ipv6Set")]
            [Validation(Required=false)]
            public List<DescribeNetworkInterfaceAttributeResponseBodyIpv6SetsIpv6Set> Ipv6Set { get; set; }
            public class DescribeNetworkInterfaceAttributeResponseBodyIpv6SetsIpv6Set : TeaModel {
                /// <summary>
                /// <para>The IPv6 address of the ENI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2001:db8:1234:1a00::****</para>
                /// </summary>
                [NameInMap("Ipv6Address")]
                [Validation(Required=false)]
                public string Ipv6Address { get; set; }

            }

        }

        /// <summary>
        /// <para>The media access control (MAC) address of the ENI.</para>
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
        /// <para>The communication settings of the ENI.</para>
        /// </summary>
        [NameInMap("NetworkInterfaceTrafficConfig")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyNetworkInterfaceTrafficConfig NetworkInterfaceTrafficConfig { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyNetworkInterfaceTrafficConfig : TeaModel {
            /// <summary>
            /// <para>The communication mode of the ENI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HighPerformance</para>
            /// </summary>
            [NameInMap("NetworkInterfaceTrafficMode")]
            [Validation(Required=false)]
            public string NetworkInterfaceTrafficMode { get; set; }

            /// <summary>
            /// <para>The number of queues supported by the ENI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("QueueNumber")]
            [Validation(Required=false)]
            public int? QueueNumber { get; set; }

            /// <summary>
            /// <para>The number of queues supported by the ERI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("QueuePairNumber")]
            [Validation(Required=false)]
            public int? QueuePairNumber { get; set; }

        }

        /// <summary>
        /// <para>The communication mode of the ENI. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard: The TCP communication mode is used.</description></item>
        /// <item><description>HighPerformance: The Elastic RDMA Interface (ERI) feature is enabled and the remote direct memory access (RDMA) communication mode is used.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter can have a value of HighPerformance only when the ENI is attached to a c7re RDMA-enhanced instance.</para>
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
        /// <para>The private IP address of the ENI.</para>
        /// 
        /// <b>Example:</b>
        /// <para><c>10.1.**.**</c></para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The private IP addresses of the ENI.</para>
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
                /// <para>The EIP that is associated with the secondary private IP address of the ENI.</para>
                /// </summary>
                [NameInMap("AssociatedPublicIp")]
                [Validation(Required=false)]
                public DescribeNetworkInterfaceAttributeResponseBodyPrivateIpSetsPrivateIpSetAssociatedPublicIp AssociatedPublicIp { get; set; }
                public class DescribeNetworkInterfaceAttributeResponseBodyPrivateIpSetsPrivateIpSetAssociatedPublicIp : TeaModel {
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
                /// <para>Indicates whether the IP address is the primary private IP address. Valid values:</para>
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
        /// <item><description><para>For a primary ENI: The default number of queues that the instance type supports for the ENI is returned.</para>
        /// </description></item>
        /// <item><description><para>For a secondary ENI:</para>
        /// <list type="bullet">
        /// <item><description><para>When the ENI is in the InUse state, the following situations occur for the QueueNumber parameter:</para>
        /// <list type="bullet">
        /// <item><description>If the number of queues supported by the ENI has not been modified, the default number of queues that the instance type supports for the ENI is returned.</description></item>
        /// <item><description>If the number of queues supported by the ENI has been modified, the new number of queues is returned.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>When the ENI is in the Available state, the following situations occur for the QueueNumber parameter:</para>
        /// <list type="bullet">
        /// <item><description>If the number of queues supported by the ENI has not been modified, the return value is empty.</description></item>
        /// <item><description>If the number of queues supported by the ENI has been modified, the new number of queues is returned.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
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
        /// <para> This parameter is in invitational preview and unavailable for general users.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("QueuePairNumber")]
        [Validation(Required=false)]
        public int? QueuePairNumber { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs. If this parameter is specified to query ENIs, up to 1,000 ENIs that belong to the specified resource group can be displayed in the response.</para>
        /// <remarks>
        /// <para> ENIs in the default resource group are displayed in the response regardless of how this parameter is set.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of the security groups to which the ENI belongs.</para>
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
        /// <para> This parameter is in invitational preview and unavailable for general users.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("SlaveInterfaceSpecification")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodySlaveInterfaceSpecification SlaveInterfaceSpecification { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodySlaveInterfaceSpecification : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para> This parameter is in invitational preview and unavailable for general users.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("BondNetworkInterfaceId")]
            [Validation(Required=false)]
            public string BondNetworkInterfaceId { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is in invitational preview and unavailable for general users.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("SlaveNetworkInterfaceId")]
            [Validation(Required=false)]
            public string SlaveNetworkInterfaceId { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is in invitational preview and unavailable for general users.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("WorkState")]
            [Validation(Required=false)]
            public string WorkState { get; set; }

        }

        /// <summary>
        /// <para>This parameter is not publicly available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SourceDestCheck")]
        [Validation(Required=false)]
        public bool? SourceDestCheck { get; set; }

        /// <summary>
        /// <para>The state of the ENI. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Available: The ENI is not attached to an instance.</description></item>
        /// <item><description>Attaching: The ENI is being attached to an instance.</description></item>
        /// <item><description>InUse: The ENI is attached to an instance.</description></item>
        /// <item><description>Detaching: The ENI is being detached from an instance.</description></item>
        /// <item><description>Deleting: The ENI is being deleted.</description></item>
        /// </list>
        /// <para>This parameter is empty by default, which indicates that all states are queried.</para>
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
        public DescribeNetworkInterfaceAttributeResponseBodyTags Tags { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeNetworkInterfaceAttributeResponseBodyTagsTag> Tag { get; set; }
            public class DescribeNetworkInterfaceAttributeResponseBodyTagsTag : TeaModel {
                /// <summary>
                /// <para>The tag key of the ENI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value of the ENI.</para>
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
        /// <remarks>
        /// <para> This parameter is in invitational preview and is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("TcpOptionAddressEnabled")]
        [Validation(Required=false)]
        public string TcpOptionAddressEnabled { get; set; }

        /// <summary>
        /// <para>The type of the ENI. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Primary</description></item>
        /// <item><description>Secondary</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Secondary</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch to which the ENI is connected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1s5fnvk4gn2tws0****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) to which the ENI belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone ID of the ENI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
