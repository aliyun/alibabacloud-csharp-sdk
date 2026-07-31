// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeNetworkInterfaceAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The Elastic IP Address (EIP) associated with the secondary private IP address of the network interface controller (NIC).</para>
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
            /// <para>The EIP address.</para>
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
        /// <para>This parameter is in invitational preview and is not publicly available.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Attachment")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyAttachment Attachment { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyAttachment : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not publicly available.</para>
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
            /// <para>This parameter is in invitational preview and is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>hide</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("MemberNetworkInterfaceIds")]
            [Validation(Required=false)]
            public DescribeNetworkInterfaceAttributeResponseBodyAttachmentMemberNetworkInterfaceIds MemberNetworkInterfaceIds { get; set; }
            public class DescribeNetworkInterfaceAttributeResponseBodyAttachmentMemberNetworkInterfaceIds : TeaModel {
                [NameInMap("MemberNetworkInterfaceId")]
                [Validation(Required=false)]
                public List<string> MemberNetworkInterfaceId { get; set; }

            }

            /// <summary>
            /// <para>The index of the network card to which the ENI is attached.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NetworkCardIndex")]
            [Validation(Required=false)]
            public int? NetworkCardIndex { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not publicly available.</para>
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
        /// <para>This parameter is in invitational preview and is not publicly available.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("BondInterfaceSpecification")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyBondInterfaceSpecification BondInterfaceSpecification { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyBondInterfaceSpecification : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("BondMode")]
            [Validation(Required=false)]
            public string BondMode { get; set; }

            [NameInMap("SlaveInterfaceSpecification")]
            [Validation(Required=false)]
            public DescribeNetworkInterfaceAttributeResponseBodyBondInterfaceSpecificationSlaveInterfaceSpecification SlaveInterfaceSpecification { get; set; }
            public class DescribeNetworkInterfaceAttributeResponseBodyBondInterfaceSpecificationSlaveInterfaceSpecification : TeaModel {
                [NameInMap("SlaveInterfaceSpecificationSet")]
                [Validation(Required=false)]
                public List<DescribeNetworkInterfaceAttributeResponseBodyBondInterfaceSpecificationSlaveInterfaceSpecificationSlaveInterfaceSpecificationSet> SlaveInterfaceSpecificationSet { get; set; }
                public class DescribeNetworkInterfaceAttributeResponseBodyBondInterfaceSpecificationSlaveInterfaceSpecificationSlaveInterfaceSpecificationSet : TeaModel {
                    [NameInMap("BondNetworkInterfaceId")]
                    [Validation(Required=false)]
                    public string BondNetworkInterfaceId { get; set; }

                    [NameInMap("SlaveNetworkInterfaceId")]
                    [Validation(Required=false)]
                    public string SlaveNetworkInterfaceId { get; set; }

                    [NameInMap("WorkState")]
                    [Validation(Required=false)]
                    public string WorkState { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The collection of network connectivity tracking configuration information.</para>
        /// </summary>
        [NameInMap("ConnectionTrackingConfiguration")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyConnectionTrackingConfiguration ConnectionTrackingConfiguration { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyConnectionTrackingConfiguration : TeaModel {
            /// <summary>
            /// <para>The timeout period for a TCP connection in the TIME_WAIT or CLOSED state. Unit: seconds. Valid values: an integer from 3 to 15.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TcpClosedAndTimeWaitTimeout")]
            [Validation(Required=false)]
            public int? TcpClosedAndTimeWaitTimeout { get; set; }

            /// <summary>
            /// <para>The timeout period for an established TCP connection. Unit: seconds. Valid values: [30, 60, 80, 100, 200, 300, 500, 700, 910].</para>
            /// 
            /// <b>Example:</b>
            /// <para>910</para>
            /// </summary>
            [NameInMap("TcpEstablishedTimeout")]
            [Validation(Required=false)]
            public int? TcpEstablishedTimeout { get; set; }

            /// <summary>
            /// <para>The timeout period for a UDP flow. Unit: seconds. Valid values: [10, 20, 30, 60, 80, 100].</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("UdpTimeout")]
            [Validation(Required=false)]
            public int? UdpTimeout { get; set; }

        }

        /// <summary>
        /// <para>The time when the network interface controller (NIC) was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-12-25T12:31:31Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the ENI is retained when the associated instance is released. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeleteOnRelease")]
        [Validation(Required=false)]
        public bool? DeleteOnRelease { get; set; }

        /// <summary>
        /// <para>The description of the network interface controller (NIC).</para>
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
            /// <summary>
            /// <remarks>
            /// <para>This parameter is not yet available for use.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
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

            [NameInMap("VirtualFunctionQuantity")]
            [Validation(Required=false)]
            public int? VirtualFunctionQuantity { get; set; }

            [NameInMap("VirtualFunctionTotalQueueNumber")]
            [Validation(Required=false)]
            public int? VirtualFunctionTotalQueueNumber { get; set; }

        }

        /// <summary>
        /// <para>The ID of the instance to which the network interface controller (NIC) is attached.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1e2l6djkndyuli****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Ipv4PrefixSets")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyIpv4PrefixSets Ipv4PrefixSets { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyIpv4PrefixSets : TeaModel {
            [NameInMap("Ipv4PrefixSet")]
            [Validation(Required=false)]
            public List<DescribeNetworkInterfaceAttributeResponseBodyIpv4PrefixSetsIpv4PrefixSet> Ipv4PrefixSet { get; set; }
            public class DescribeNetworkInterfaceAttributeResponseBodyIpv4PrefixSetsIpv4PrefixSet : TeaModel {
                [NameInMap("Ipv4Prefix")]
                [Validation(Required=false)]
                public string Ipv4Prefix { get; set; }

            }

        }

        [NameInMap("Ipv6PrefixSets")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyIpv6PrefixSets Ipv6PrefixSets { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyIpv6PrefixSets : TeaModel {
            [NameInMap("Ipv6PrefixSet")]
            [Validation(Required=false)]
            public List<DescribeNetworkInterfaceAttributeResponseBodyIpv6PrefixSetsIpv6PrefixSet> Ipv6PrefixSet { get; set; }
            public class DescribeNetworkInterfaceAttributeResponseBodyIpv6PrefixSetsIpv6PrefixSet : TeaModel {
                [NameInMap("Ipv6Prefix")]
                [Validation(Required=false)]
                public string Ipv6Prefix { get; set; }

            }

        }

        [NameInMap("Ipv6Sets")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyIpv6Sets Ipv6Sets { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyIpv6Sets : TeaModel {
            [NameInMap("Ipv6Set")]
            [Validation(Required=false)]
            public List<DescribeNetworkInterfaceAttributeResponseBodyIpv6SetsIpv6Set> Ipv6Set { get; set; }
            public class DescribeNetworkInterfaceAttributeResponseBodyIpv6SetsIpv6Set : TeaModel {
                [NameInMap("Ipv6Address")]
                [Validation(Required=false)]
                public string Ipv6Address { get; set; }

                [NameInMap("Primary")]
                [Validation(Required=false)]
                public bool? Primary { get; set; }

            }

        }

        /// <summary>
        /// <para>The MAC address of the network interface controller (NIC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:16:3e:12:<b>:</b></para>
        /// </summary>
        [NameInMap("MacAddress")]
        [Validation(Required=false)]
        public string MacAddress { get; set; }

        /// <summary>
        /// <para>The ID of the network interface controller (NIC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-bp125p95hhdhn3ot****</para>
        /// </summary>
        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// <para>The name of the network interface controller (NIC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-eni-name</para>
        /// </summary>
        [NameInMap("NetworkInterfaceName")]
        [Validation(Required=false)]
        public string NetworkInterfaceName { get; set; }

        /// <summary>
        /// <para>The traffic parameters of the network interface controller (NIC).</para>
        /// </summary>
        [NameInMap("NetworkInterfaceTrafficConfig")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyNetworkInterfaceTrafficConfig NetworkInterfaceTrafficConfig { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyNetworkInterfaceTrafficConfig : TeaModel {
            /// <summary>
            /// <para>The communication mode of the network interface controller (NIC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>HighPerformance</para>
            /// </summary>
            [NameInMap("NetworkInterfaceTrafficMode")]
            [Validation(Required=false)]
            public string NetworkInterfaceTrafficMode { get; set; }

            /// <summary>
            /// <para>The number of queues supported by the network interface controller (NIC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("QueueNumber")]
            [Validation(Required=false)]
            public int? QueueNumber { get; set; }

            /// <summary>
            /// <para>The number of queues supported by the RDMA ENI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("QueuePairNumber")]
            [Validation(Required=false)]
            public int? QueuePairNumber { get; set; }

        }

        /// <summary>
        /// <para>The communication mode of the network interface controller (NIC). Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("NetworkInterfaceTrafficMode")]
        [Validation(Required=false)]
        public string NetworkInterfaceTrafficMode { get; set; }

        /// <summary>
        /// <para>The ID of the account that owns the network interface controller (NIC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The private network IP address of the network interface controller (NIC).</para>
        /// 
        /// <b>Example:</b>
        /// <para><c>10.1.**.**</c></para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        [NameInMap("PrivateIpSets")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyPrivateIpSets PrivateIpSets { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyPrivateIpSets : TeaModel {
            [NameInMap("PrivateIpSet")]
            [Validation(Required=false)]
            public List<DescribeNetworkInterfaceAttributeResponseBodyPrivateIpSetsPrivateIpSet> PrivateIpSet { get; set; }
            public class DescribeNetworkInterfaceAttributeResponseBodyPrivateIpSetsPrivateIpSet : TeaModel {
                [NameInMap("AssociatedPublicIp")]
                [Validation(Required=false)]
                public DescribeNetworkInterfaceAttributeResponseBodyPrivateIpSetsPrivateIpSetAssociatedPublicIp AssociatedPublicIp { get; set; }
                public class DescribeNetworkInterfaceAttributeResponseBodyPrivateIpSetsPrivateIpSetAssociatedPublicIp : TeaModel {
                    [NameInMap("AllocationId")]
                    [Validation(Required=false)]
                    public string AllocationId { get; set; }

                    [NameInMap("PublicIpAddress")]
                    [Validation(Required=false)]
                    public string PublicIpAddress { get; set; }

                }

                [NameInMap("Primary")]
                [Validation(Required=false)]
                public bool? Primary { get; set; }

                [NameInMap("PrivateIpAddress")]
                [Validation(Required=false)]
                public string PrivateIpAddress { get; set; }

            }

        }

        /// <summary>
        /// <para>The QoS rate limiting settings.</para>
        /// </summary>
        [NameInMap("QoSConfig")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyQoSConfig QoSConfig { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyQoSConfig : TeaModel {
            /// <summary>
            /// <para>Indicates whether QoS rate limiting is enabled.</para>
            /// </summary>
            [NameInMap("EnableQoS")]
            [Validation(Required=false)]
            public bool? EnableQoS { get; set; }

            /// <summary>
            /// <para>The QoS rate limiting settings.</para>
            /// </summary>
            [NameInMap("QoS")]
            [Validation(Required=false)]
            public DescribeNetworkInterfaceAttributeResponseBodyQoSConfigQoS QoS { get; set; }
            public class DescribeNetworkInterfaceAttributeResponseBodyQoSConfigQoS : TeaModel {
                /// <summary>
                /// <para>The maximum inbound internal bandwidth limit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50000</para>
                /// </summary>
                [NameInMap("BandwidthRx")]
                [Validation(Required=false)]
                public long? BandwidthRx { get; set; }

                /// <summary>
                /// <para>The maximum outbound internal bandwidth limit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50000</para>
                /// </summary>
                [NameInMap("BandwidthTx")]
                [Validation(Required=false)]
                public long? BandwidthTx { get; set; }

                /// <summary>
                /// <para>The maximum number of sessions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50000</para>
                /// </summary>
                [NameInMap("ConcurrentConnections")]
                [Validation(Required=false)]
                public long? ConcurrentConnections { get; set; }

                /// <summary>
                /// <para>The inbound internal network packet forwarding rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50000</para>
                /// </summary>
                [NameInMap("PpsRx")]
                [Validation(Required=false)]
                public long? PpsRx { get; set; }

                /// <summary>
                /// <para>The outbound internal network packet forwarding rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50000</para>
                /// </summary>
                [NameInMap("PpsTx")]
                [Validation(Required=false)]
                public long? PpsTx { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of queues supported by the network interface controller (NIC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("QueueNumber")]
        [Validation(Required=false)]
        public int? QueueNumber { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is in invitational preview and is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("QueuePairNumber")]
        [Validation(Required=false)]
        public int? QueuePairNumber { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs. When you use this parameter to filter resources, the resource count cannot exceed 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodySecurityGroupIds SecurityGroupIds { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodySecurityGroupIds : TeaModel {
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public List<string> SecurityGroupId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the Virtual Network Operator (VNO) to which the network interface controller (NIC) belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678910</para>
        /// </summary>
        [NameInMap("ServiceID")]
        [Validation(Required=false)]
        public long? ServiceID { get; set; }

        /// <summary>
        /// <para>Indicates whether the user of the network interface controller (NIC) is an Alibaba Cloud service or a VNO.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public bool? ServiceManaged { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is in invitational preview and is not publicly available.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("SlaveInterfaceSpecification")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodySlaveInterfaceSpecification SlaveInterfaceSpecification { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodySlaveInterfaceSpecification : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not publicly available.</para>
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
            /// <para>This parameter is in invitational preview and is not publicly available.</para>
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
            /// <para>This parameter is in invitational preview and is not publicly available.</para>
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
        /// <para>The status of the network interface controller (NIC). Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeNetworkInterfaceAttributeResponseBodyTags Tags { get; set; }
        public class DescribeNetworkInterfaceAttributeResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeNetworkInterfaceAttributeResponseBodyTagsTag> Tag { get; set; }
            public class DescribeNetworkInterfaceAttributeResponseBodyTagsTag : TeaModel {
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is in invitational preview and is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("TcpOptionAddressEnabled")]
        [Validation(Required=false)]
        public string TcpOptionAddressEnabled { get; set; }

        /// <summary>
        /// <para>The type of the network interface controller (NIC). Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>Secondary</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch to which the network interface controller (NIC) belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1s5fnvk4gn2tws0****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the network interface controller (NIC) belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
