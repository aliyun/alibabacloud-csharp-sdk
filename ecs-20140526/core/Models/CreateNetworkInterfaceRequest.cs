// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateNetworkInterfaceRequest : TeaModel {
        /// <summary>
        /// <remarks>
        /// <para>This parameter is deprecated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests. <b>ClientToken</b> can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The network connectivity tracking configuration.</para>
        /// <para>Before you use this parameter, read <a href="https://help.aliyun.com/document_detail/2865958.html">Connection timeout management</a>.</para>
        /// </summary>
        [NameInMap("ConnectionTrackingConfiguration")]
        [Validation(Required=false)]
        public CreateNetworkInterfaceRequestConnectionTrackingConfiguration ConnectionTrackingConfiguration { get; set; }
        public class CreateNetworkInterfaceRequestConnectionTrackingConfiguration : TeaModel {
            /// <summary>
            /// <para>The timeout period for TCP connections in the TIME_WAIT and CLOSED states. Unit: seconds. Valid values: integers from 3 to 15.</para>
            /// <para>Default value: 3.</para>
            /// <remarks>
            /// <para>If your ECS instance is used with NLB/CLB, the default timeout period for connections in the <c>TIME_WAIT</c> state is 15 seconds.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TcpClosedAndTimeWaitTimeout")]
            [Validation(Required=false)]
            public int? TcpClosedAndTimeWaitTimeout { get; set; }

            /// <summary>
            /// <para>The timeout period for established TCP connections. Unit: seconds. Valid values: [30, 60, 80, 100, 200, 300, 500, 700, 910].</para>
            /// <para>Default value: 910.</para>
            /// 
            /// <b>Example:</b>
            /// <para>910</para>
            /// </summary>
            [NameInMap("TcpEstablishedTimeout")]
            [Validation(Required=false)]
            public int? TcpEstablishedTimeout { get; set; }

            /// <summary>
            /// <para>The timeout period for UDP flows. Unit: seconds. Valid values: [10, 20, 30, 60, 80, 100].</para>
            /// <para>Default value: 30.</para>
            /// <remarks>
            /// <para>If your ECS instance is used with NLB/CLB, the default value is 100 seconds.</para>
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
        /// <para>Specifies whether to retain the ENI when the associated instance is released. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: does not retain the ENI.</para>
        /// </description></item>
        /// <item><description><para>false: retains the ENI.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeleteOnRelease")]
        [Validation(Required=false)]
        public bool? DeleteOnRelease { get; set; }

        /// <summary>
        /// <para>The description of the network interface controller (NIC). The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// <para>Default value: empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EnablePrimaryIPv6")]
        [Validation(Required=false)]
        public bool? EnablePrimaryIPv6 { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not publicly available.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("EnhancedNetwork")]
        [Validation(Required=false)]
        public CreateNetworkInterfaceRequestEnhancedNetwork EnhancedNetwork { get; set; }
        public class CreateNetworkInterfaceRequestEnhancedNetwork : TeaModel {
            [NameInMap("EnableExpress")]
            [Validation(Required=false)]
            public bool? EnableExpress { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableRss")]
            [Validation(Required=false)]
            public bool? EnableRss { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
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
        /// <para>The type of the Elastic Network Interface (ENI). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Secondary: secondary ENI.</description></item>
        /// <item><description>Trunk: trunk network interface controller (NIC) (in invitational preview).</description></item>
        /// </list>
        /// <para>Default value: Secondary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Secondary</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>One or more IPv4 prefixes to assign to the network interface controller (NIC). Valid values of N: 1 to 10.</para>
        /// <remarks>
        /// <para>If you want to set IPv4 prefixes for the network interface controller (NIC), you must set either the parameter Ipv4Prefix.N or the parameter Ipv4PrefixCount but not both.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Ipv4Prefix")]
        [Validation(Required=false)]
        public List<string> Ipv4Prefix { get; set; }

        /// <summary>
        /// <para>The number of IPv4 prefixes to assign to the network interface controller (NIC). Valid values: 1 to 10.</para>
        /// <remarks>
        /// <para>If you want to set IPv4 prefixes for the network interface controller (NIC), you must set either the parameter Ipv4Prefix.N or the parameter Ipv4PrefixCount but not both.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Ipv4PrefixCount")]
        [Validation(Required=false)]
        public int? Ipv4PrefixCount { get; set; }

        /// <summary>
        /// <para>One or more IPv6 addresses to assign to the network interface controller (NIC). You can specify up to 10 IPv6 addresses. Valid values of N: 1 to 10.</para>
        /// <para>Example: Ipv6Address.1=2001:db8:1234:1a00::\<em>\</em>\<em>\</em></para>
        /// <remarks>
        /// <para>If you want to set IPv6 addresses for the network interface controller (NIC), you must set either the parameter <c>Ipv6Addresses.N</c> or the parameter <c>Ipv6AddressCount</c> but not both.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2001:db8:1234:1a00::****</para>
        /// </summary>
        [NameInMap("Ipv6Address")]
        [Validation(Required=false)]
        public List<string> Ipv6Address { get; set; }

        /// <summary>
        /// <para>The number of IPv6 addresses to randomly generate for the network interface controller (NIC). Valid values: 1 to 10.</para>
        /// <remarks>
        /// <para>If you want to set IPv6 addresses for the network interface controller (NIC), you must set either the parameter <c>Ipv6Addresses.N</c> or the parameter <c>Ipv6AddressCount</c> but not both.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Ipv6AddressCount")]
        [Validation(Required=false)]
        public int? Ipv6AddressCount { get; set; }

        /// <summary>
        /// <para>One or more IPv6 prefixes to assign to the network interface controller (NIC). Valid values of N: 1 to 10.</para>
        /// <remarks>
        /// <para>If you want to set IPv6 prefixes for the network interface controller (NIC), you must set either the parameter Ipv6Prefix.N or the parameter Ipv6PrefixCount but not both.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Ipv6Prefix")]
        [Validation(Required=false)]
        public List<string> Ipv6Prefix { get; set; }

        /// <summary>
        /// <para>The number of IPv6 prefixes to assign to the network interface controller (NIC). Valid values: 1 to 10.</para>
        /// <remarks>
        /// <para>If you want to set IPv6 prefixes for the network interface controller (NIC), you must set either the parameter Ipv6Prefix.N or the parameter Ipv6PrefixCount but not both.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Ipv6PrefixCount")]
        [Validation(Required=false)]
        public int? Ipv6PrefixCount { get; set; }

        /// <summary>
        /// <para>The name of the network interface controller (NIC). The name must be 2 to 128 characters in length and can contain characters from the Unicode letter categorization (including English and Chinese characters) and ASCII digits (0-9). The name can contain colons (:), underscores (_), periods (.), or hyphens (-).</para>
        /// <para>Default value: empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testNetworkInterfaceName</para>
        /// </summary>
        [NameInMap("NetworkInterfaceName")]
        [Validation(Required=false)]
        public string NetworkInterfaceName { get; set; }

        /// <summary>
        /// <para>The traffic configuration parameter set of the network interface controller (NIC).</para>
        /// </summary>
        [NameInMap("NetworkInterfaceTrafficConfig")]
        [Validation(Required=false)]
        public CreateNetworkInterfaceRequestNetworkInterfaceTrafficConfig NetworkInterfaceTrafficConfig { get; set; }
        public class CreateNetworkInterfaceRequestNetworkInterfaceTrafficConfig : TeaModel {
            /// <summary>
            /// <para>The communication pattern of the network interface controller (NIC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>HighPerformance</para>
            /// </summary>
            [NameInMap("NetworkInterfaceTrafficMode")]
            [Validation(Required=false)]
            public string NetworkInterfaceTrafficMode { get; set; }

            /// <summary>
            /// <para>The number of queues for the network interface controller (NIC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("QueueNumber")]
            [Validation(Required=false)]
            public int? QueueNumber { get; set; }

            /// <summary>
            /// <para>The number of queues for the RDMA ENI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("QueuePairNumber")]
            [Validation(Required=false)]
            public int? QueuePairNumber { get; set; }

            /// <summary>
            /// <para>The inbound queue depth of the network interface controller (NIC).</para>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not publicly available. If you want to use this parameter, <a href="https://selfservice.console.aliyun.com/ticket/createIndex">submit a ticket</a> to request access.</para>
            /// </remarks>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not publicly available. If you want to use this parameter, <a href="https://smartservice.console.aliyun.com/service/create-ticket-intl">submit a ticket</a> to request access.</para>
            /// </remarks>
            /// <para>Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description><para>This parameter applies only to seventh-generation and later ECS instance types.</para>
            /// </description></item>
            /// <item><description><para>This parameter currently applies only to Linux images.</para>
            /// </description></item>
            /// <item><description><para>A larger inbound queue depth of the network interface controller (NIC) increases inbound throughput and reduces packet loss probability but consumes more memory.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("RxQueueSize")]
            [Validation(Required=false)]
            public int? RxQueueSize { get; set; }

            /// <summary>
            /// <para>The outbound queue depth of the network interface controller (NIC).</para>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not publicly available. If you want to use this parameter, <a href="https://selfservice.console.aliyun.com/ticket/createIndex">submit a ticket</a> to request access.</para>
            /// </remarks>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not publicly available. If you want to use this parameter, <a href="https://smartservice.console.aliyun.com/service/create-ticket-intl">submit a ticket</a> to request access.</para>
            /// </remarks>
            /// <para>Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description><para>This parameter applies only to seventh-generation and later ECS instance types.</para>
            /// </description></item>
            /// <item><description><para>This parameter currently applies only to Linux images.</para>
            /// </description></item>
            /// <item><description><para>A larger outbound queue depth of the network interface controller (NIC) increases outbound throughput and reduces packet loss probability but consumes more memory.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("TxQueueSize")]
            [Validation(Required=false)]
            public int? TxQueueSize { get; set; }

        }

        /// <summary>
        /// <para>The communication pattern of the network interface controller (NIC). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard: uses the TCP communication pattern.</description></item>
        /// <item><description>HighPerformance: enables the Elastic RDMA Interface (ERI) and uses the RDMA communication pattern.</description></item>
        /// </list>
        /// <remarks>
        /// <para>A network interface controller (NIC) in RDMA communication pattern can be attached only to an instance whose instance type supports ERI. The number of ENIs in RDMA pattern cannot exceed the limit of the instance family. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> and <a href="https://help.aliyun.com/document_detail/336853.html">Configure eRDMA on enterprise-level instances</a>&lt;props=&quot;china&quot;&gt; and <a href="https://help.aliyun.com/document_detail/2248432.html">Configure eRDMA on GPU-accelerated instances</a>.</para>
        /// </remarks>
        /// <para>Default value: Standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
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
        /// <para>The primary private IP address of the network interface controller (NIC).</para>
        /// <para>The specified IP address must be an idle address within the CIDR block of the vSwitch. If you do not specify this parameter, an idle private IP address in the vSwitch CIDR block is randomly allocated by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para><c>172.17.**.**</c></para>
        /// </summary>
        [NameInMap("PrimaryIpAddress")]
        [Validation(Required=false)]
        public string PrimaryIpAddress { get; set; }

        /// <summary>
        /// <para>One or more secondary private IP addresses selected from the idle addresses within the CIDR block of the vSwitch to which the network interface controller (NIC) belongs. Valid values of N: 0 to 10.</para>
        /// <remarks>
        /// <para>When you allocate secondary private IP addresses, you cannot specify both the parameter <c>PrivateIpAddress.N</c> and the parameter <c>SecondaryPrivateIpAddressCount</c> at the same time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><c>172.17.**.**</c></para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public List<string> PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The number of queues for the network interface controller (NIC). Valid values: 1 to 2048.</para>
        /// <para>When you attach the ENI to an instance, the value must be less than the maximum number of queues per network interface controller (NIC) supported by the instance type. You can call <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> to query the <c>MaximumQueueNumberPerEni</c> field.</para>
        /// <para>Default value: empty. When the ENI is attached, the default queue number for the instance type is used. You can call <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> to query the <c>SecondaryEniQueueNumber</c> field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("QueueNumber")]
        [Validation(Required=false)]
        public int? QueueNumber { get; set; }

        /// <summary>
        /// <para>The number of queues for the RDMA ENI.</para>
        /// <para>If you want to attach multiple RDMA ENIs to an instance, we recommend that you manually specify QueuePairNumber for each ENI based on the upper limit of <c>QueuePairNumber</c> supported by the instance type and the number of ENIs you plan to use. Make sure that the total QueuePairNumber of all ENIs does not exceed the maximum value allowed by the instance type. Call <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> to query the upper limit for the instance type.</para>
        /// <remarks>
        /// <para>Notice: If QueuePairNumber is not specified for an RDMA ENI, the upper limit of QueuePairNumber for all RDMA ENIs supported by the instance type is used by default. Therefore, after an RDMA ENI without a specified QueuePairNumber is attached, no more RDMA ENIs can be added (regular ENIs are not affected by this limit).</notice></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("QueuePairNumber")]
        [Validation(Required=false)]
        public int? QueuePairNumber { get; set; }

        /// <summary>
        /// <para>The region ID of the network interface controller (NIC) to create. You can invoke <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID. You can call <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> to query resource group information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4ph****</para>
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
        /// <para>The inbound queue depth of the network interface controller (NIC).</para>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description><para>The inbound queue depth of the network interface controller (NIC) must be equal to the outbound queue depth. Valid values: 8192 to 16384. The value must be a power of 2.</para>
        /// </description></item>
        /// <item><description><para>A larger inbound queue depth increases inbound throughput but consumes more memory.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8192</para>
        /// </summary>
        [NameInMap("RxQueueSize")]
        [Validation(Required=false)]
        public int? RxQueueSize { get; set; }

        /// <summary>
        /// <para>The number of private IP addresses for automatic creation by ECS. Valid values: 1 to 49.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SecondaryPrivateIpAddressCount")]
        [Validation(Required=false)]
        public int? SecondaryPrivateIpAddressCount { get; set; }

        /// <summary>
        /// <para>The ID of the security group to which the network interface controller (NIC) belongs. The security group and the ENI must be in the same VPC.</para>
        /// <remarks>
        /// <para>When you invoke this operation, you must set either <c>SecurityGroupId</c> or <c>SecurityGroupIds.N</c> but not both.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp1fg655nh68xyz9i****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of one or more security groups to which the network interface controller (NIC) belongs. The security groups and the ENI must be in the same VPC. The valid values of N depend on the quota for the maximum number of security groups to which an ENI can belong. For more information, see <a href="https://help.aliyun.com/document_detail/25412.html">Limits</a>.</para>
        /// <remarks>
        /// <para>When you invoke this operation, you must set either <c>SecurityGroupId</c> or <c>SecurityGroupIds.N</c> but not both.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp1fg655nh68xyz9i****</para>
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable source/destination checking. We recommend that you enable this feature to improve network security. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enabled.</para>
        /// </description></item>
        /// <item><description><para>false: disabled.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>This feature is supported only in specific regions. Before you use this feature, read <a href="https://help.aliyun.com/document_detail/2863210.html">Source/destination checking</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SourceDestCheck")]
        [Validation(Required=false)]
        public bool? SourceDestCheck { get; set; }

        /// <summary>
        /// <para>The tags of the network interface controller (NIC).</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateNetworkInterfaceRequestTag> Tag { get; set; }
        public class CreateNetworkInterfaceRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the network interface controller (NIC). Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with aliyun or acs:. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the network interface controller (NIC). Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The outbound queue depth of the network interface controller (NIC).</para>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description><para>The outbound queue depth of the network interface controller (NIC) must be equal to the inbound queue depth. Valid values: 8192 to 16384. The value must be a power of 2.</para>
        /// </description></item>
        /// <item><description><para>A larger outbound queue depth increases outbound throughput but consumes more memory.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8192</para>
        /// </summary>
        [NameInMap("TxQueueSize")]
        [Validation(Required=false)]
        public int? TxQueueSize { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the network interface controller (NIC). The private IP address of the ENI is allocated from the idle addresses within the CIDR block of the vSwitch.</para>
        /// <remarks>
        /// <para>Notice: The network interface controller (NIC) and the instance to which you want to attach the ENI must be in the same zone but can belong to different vSwitches.</notice></para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1s5fnvk4gn2tws03****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is deprecated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Visible")]
        [Validation(Required=false)]
        public bool? Visible { get; set; }

    }

}
