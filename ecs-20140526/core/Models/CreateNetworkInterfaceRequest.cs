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
        /// <para>A client token to ensure request idempotence. Your client generates this token, which must be unique across requests. The token can contain only ASCII characters and must not exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The connection tracking settings.</para>
        /// <para>Before using this parameter, read <a href="https://help.aliyun.com/document_detail/2865958.html">Connection timeout management</a>.</para>
        /// </summary>
        [NameInMap("ConnectionTrackingConfiguration")]
        [Validation(Required=false)]
        public CreateNetworkInterfaceRequestConnectionTrackingConfiguration ConnectionTrackingConfiguration { get; set; }
        public class CreateNetworkInterfaceRequestConnectionTrackingConfiguration : TeaModel {
            /// <summary>
            /// <para>The timeout for a TCP connection in the TIME_WAIT or closing state, in seconds. Valid values: integers from 3 to 15.</para>
            /// <para>Default value: 3.</para>
            /// <remarks>
            /// <para>If your ECS instance works with NLB or CLB, the default timeout period for connections in the <c>TIME_WAIT</c> state is 15 seconds.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TcpClosedAndTimeWaitTimeout")]
            [Validation(Required=false)]
            public int? TcpClosedAndTimeWaitTimeout { get; set; }

            /// <summary>
            /// <para>The timeout for an established TCP connection, in seconds. Valid values: 30, 60, 80, 100, 200, 300, 500, 700, and 910.</para>
            /// <para>Default value: 910.</para>
            /// 
            /// <b>Example:</b>
            /// <para>910</para>
            /// </summary>
            [NameInMap("TcpEstablishedTimeout")]
            [Validation(Required=false)]
            public int? TcpEstablishedTimeout { get; set; }

            /// <summary>
            /// <para>The timeout for a UDP stream, in seconds. Valid values: 10, 20, 30, 60, 80, and 100.</para>
            /// <para>Default value: 30.</para>
            /// <remarks>
            /// <para>If your ECS instance works with NLB or CLB, the default value is 100 seconds.</para>
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
        /// <para>Specifies whether to release the elastic network interface when its attached instance is released. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The elastic network interface is released.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The elastic network interface is retained.</para>
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
        /// <para>The description of the elastic network interface. The description must be 2 to 256 characters long and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// <para>Default value: empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not publicly available.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("EnhancedNetwork")]
        [Validation(Required=false)]
        public CreateNetworkInterfaceRequestEnhancedNetwork EnhancedNetwork { get; set; }
        public class CreateNetworkInterfaceRequestEnhancedNetwork : TeaModel {
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
        /// <para>The type of the elastic network interface. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Secondary</c>: a secondary elastic network interface.</para>
        /// </description></item>
        /// <item><description><para><c>Trunk</c>: a trunk network interface. (This feature is available by invitation only.)</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>Secondary</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Secondary</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>One or more IPv4 prefixes to assign to the elastic network interface. Valid values of N: 1 to 10.</para>
        /// <remarks>
        /// <para>You must specify either <c>Ipv4Prefix.N</c> or <c>Ipv4PrefixCount</c>, but not both, to assign IPv4 prefixes.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Ipv4Prefix")]
        [Validation(Required=false)]
        public List<string> Ipv4Prefix { get; set; }

        /// <summary>
        /// <para>The number of IPv4 prefixes to assign to the elastic network interface. Valid values: 1 to 10.</para>
        /// <remarks>
        /// <para>You must specify either <c>Ipv4Prefix.N</c> or <c>Ipv4PrefixCount</c>, but not both, to assign IPv4 prefixes.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Ipv4PrefixCount")]
        [Validation(Required=false)]
        public int? Ipv4PrefixCount { get; set; }

        /// <summary>
        /// <para>One or more IPv6 addresses to assign to the elastic network interface. You can specify up to 10 IPv6 addresses. Valid values of N: 1 to 10.</para>
        /// <para>Example: <c>Ipv6Address.1=2001:db8:1234:1a00::****</c></para>
        /// <remarks>
        /// <para>You must specify either <c>Ipv6Address.N</c> or <c>Ipv6AddressCount</c>, but not both, to assign IPv6 addresses.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2001:db8:1234:1a00::****</para>
        /// </summary>
        [NameInMap("Ipv6Address")]
        [Validation(Required=false)]
        public List<string> Ipv6Address { get; set; }

        /// <summary>
        /// <para>The number of random IPv6 addresses to assign to the elastic network interface. Valid values: 1 to 10.</para>
        /// <remarks>
        /// <para>You must specify either <c>Ipv6Address.N</c> or <c>Ipv6AddressCount</c>, but not both, to assign IPv6 addresses.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Ipv6AddressCount")]
        [Validation(Required=false)]
        public int? Ipv6AddressCount { get; set; }

        /// <summary>
        /// <para>One or more IPv6 prefixes to assign to the elastic network interface. Valid values of N: 1 to 10.</para>
        /// <remarks>
        /// <para>You must specify either <c>Ipv6Prefix.N</c> or <c>Ipv6PrefixCount</c>, but not both, to assign IPv6 prefixes.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Ipv6Prefix")]
        [Validation(Required=false)]
        public List<string> Ipv6Prefix { get; set; }

        /// <summary>
        /// <para>The number of IPv6 prefixes to assign to the elastic network interface. Valid values: 1 to 10.</para>
        /// <remarks>
        /// <para>You must specify either <c>Ipv6Prefix.N</c> or <c>Ipv6PrefixCount</c>, but not both, to assign IPv6 prefixes.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Ipv6PrefixCount")]
        [Validation(Required=false)]
        public int? Ipv6PrefixCount { get; set; }

        /// <summary>
        /// <para>The name of the elastic network interface. The name must be 2 to 128 characters long and can contain Unicode letters (such as English and Chinese characters), digits (0-9), colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// <para>Default value: empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testNetworkInterfaceName</para>
        /// </summary>
        [NameInMap("NetworkInterfaceName")]
        [Validation(Required=false)]
        public string NetworkInterfaceName { get; set; }

        /// <summary>
        /// <para>The communication parameters of the elastic network interface.</para>
        /// </summary>
        [NameInMap("NetworkInterfaceTrafficConfig")]
        [Validation(Required=false)]
        public CreateNetworkInterfaceRequestNetworkInterfaceTrafficConfig NetworkInterfaceTrafficConfig { get; set; }
        public class CreateNetworkInterfaceRequestNetworkInterfaceTrafficConfig : TeaModel {
            /// <summary>
            /// <para>The traffic mode of the elastic network interface.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HighPerformance</para>
            /// </summary>
            [NameInMap("NetworkInterfaceTrafficMode")]
            [Validation(Required=false)]
            public string NetworkInterfaceTrafficMode { get; set; }

            /// <summary>
            /// <para>The number of queues for the elastic network interface.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("QueueNumber")]
            [Validation(Required=false)]
            public int? QueueNumber { get; set; }

            /// <summary>
            /// <para>The number of queue pairs for the RDMA-enabled elastic network interface.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("QueuePairNumber")]
            [Validation(Required=false)]
            public int? QueuePairNumber { get; set; }

            /// <summary>
            /// <para>The receive (Rx) queue depth of the elastic network interface.</para>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <remarks>
            /// <para>This parameter is available by invitation only. To request access, submit a ticket.</para>
            /// </remarks>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <remarks>
            /// <para>This parameter is available by invitation only. To request access, submit a ticket.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>This parameter is applicable only to seventh-generation or later ECS instance types.</para>
            /// </description></item>
            /// <item><description><para>This parameter is applicable only to Linux images.</para>
            /// </description></item>
            /// <item><description><para>A larger Rx queue depth can improve receive throughput and reduce the packet loss rate, but consumes more memory.</para>
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
            /// <para>The transmit (Tx) queue depth of the elastic network interface.</para>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <remarks>
            /// <para>This parameter is available by invitation only. To request access, submit a ticket.</para>
            /// </remarks>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <remarks>
            /// <para>This parameter is available by invitation only. To request access, submit a ticket.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>This parameter is applicable only to seventh-generation or later ECS instance types.</para>
            /// </description></item>
            /// <item><description><para>This parameter is applicable only to Linux images.</para>
            /// </description></item>
            /// <item><description><para>A larger Tx queue depth can improve transmit throughput and reduce the packet loss rate, but consumes more memory.</para>
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
        /// <para>The traffic mode of the elastic network interface. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Standard</c>: uses the TCP traffic mode.</para>
        /// </description></item>
        /// <item><description><para><c>HighPerformance</c>: enables the Elastic RDMA Interface (ERI) and uses the RDMA traffic mode.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>An elastic network interface in RDMA traffic mode can be attached only to an ERI-supported instance type. The number of these elastic network interfaces that can be attached is limited by the instance family. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>, <a href="https://help.aliyun.com/document_detail/336853.html">Configure eRDMA on an enterprise-level instance</a>&lt;props=&quot;china&quot;&gt;, and <a href="https://help.aliyun.com/document_detail/2248432.html">Configure eRDMA on a GPU instance</a>.</para>
        /// </remarks>
        /// <para>Default value: <c>Standard</c>.</para>
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
        /// <para>The primary private IP address of the elastic network interface.</para>
        /// <para>The IP address must be an available IP address within the CIDR block of the VSwitch. If this parameter is not specified, the system randomly assigns an available IP address from the VSwitch\&quot;s CIDR block.</para>
        /// 
        /// <b>Example:</b>
        /// <para><c>172.17.**.**</c></para>
        /// </summary>
        [NameInMap("PrimaryIpAddress")]
        [Validation(Required=false)]
        public string PrimaryIpAddress { get; set; }

        /// <summary>
        /// <para>One or more secondary private IP addresses to assign to the elastic network interface. The IP addresses must be available addresses from the CIDR block of the VSwitch to which the elastic network interface belongs. Valid values of N: 0 to 10.</para>
        /// <remarks>
        /// <para>You cannot specify both <c>PrivateIpAddress.N</c> and <c>SecondaryPrivateIpAddressCount</c> to assign secondary private IP addresses.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><c>172.17.**.**</c></para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public List<string> PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The number of queues for the elastic network interface. Valid values: 1 to 2048.</para>
        /// <para>When attached to an instance, this value must be less than the maximum number of queues per elastic network interface that the instance type supports. You can call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation and check the <c>MaximumQueueNumberPerEni</c> value in the response to query this limit.</para>
        /// <para>If you do not specify this parameter, the default queue number for the instance type is used upon attachment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("QueueNumber")]
        [Validation(Required=false)]
        public int? QueueNumber { get; set; }

        /// <summary>
        /// <para>The number of queue pairs for the RDMA-enabled elastic network interface.</para>
        /// <para>If you want to attach multiple RDMA-enabled elastic network interfaces to an instance, we recommend that you specify a <c>QueuePairNumber</c> value for each elastic network interface. The value should be based on the maximum <c>QueuePairNumber</c> value supported by the instance type and the number of elastic network interfaces that you plan to use. The total number of queue pairs for all elastic network interfaces cannot exceed the maximum value for the instance type. You can call the <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> operation to query the maximum value.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>If you do not specify <c>QueuePairNumber</c> for an RDMA-enabled elastic network interface, the system defaults to the maximum value that the instance type supports. Consequently, you cannot attach any more RDMA-enabled elastic network interfaces to that instance. This does not affect standard elastic network interfaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("QueuePairNumber")]
        [Validation(Required=false)]
        public int? QueuePairNumber { get; set; }

        /// <summary>
        /// <para>The ID of the region in which to create the elastic network interface. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to view the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. You can call the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation to query resource groups.</para>
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
        /// <para>The receive (Rx) queue depth of the elastic network interface.</para>
        /// <list type="bullet">
        /// <item><description><para>The receive (Rx) and transmit (Tx) queue depths must be equal. The value must be a power of 2 between 8,192 and 16,384.</para>
        /// </description></item>
        /// <item><description><para>A larger Rx queue depth can improve receive throughput but consumes more memory.</para>
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
        /// <para>The number of secondary private IP addresses to automatically assign to the elastic network interface. Valid values: 1 to 49.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SecondaryPrivateIpAddressCount")]
        [Validation(Required=false)]
        public int? SecondaryPrivateIpAddressCount { get; set; }

        /// <summary>
        /// <para>The ID of the security group for the elastic network interface. The security group and the elastic network interface must be in the same VPC.</para>
        /// <remarks>
        /// <para>You must specify either <c>SecurityGroupId</c> or <c>SecurityGroupIds.N</c>, but not both.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp1fg655nh68xyz9i****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of one or more security groups to which to add the elastic network interface. The security groups and the elastic network interface must be in the same VPC. The valid values of N depend on the maximum number of security groups to which an elastic network interface can be added. For more information, see <a href="https://help.aliyun.com/document_detail/25412.html">Limits</a>.</para>
        /// <remarks>
        /// <para>You must specify either <c>SecurityGroupId</c> or <c>SecurityGroupIds.N</c>, but not both.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp1fg655nh68xyz9i****</para>
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable source/destination check. Enabling this feature enhances network security. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: enabled.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: disabled.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>This feature is available only in some regions. Before you use this feature, read <a href="https://help.aliyun.com/document_detail/2863210.html">Source/destination check</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SourceDestCheck")]
        [Validation(Required=false)]
        public bool? SourceDestCheck { get; set; }

        /// <summary>
        /// <para>The tags to add to the elastic network interface.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateNetworkInterfaceRequestTag> Tag { get; set; }
        public class CreateNetworkInterfaceRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag. Valid values for N: 1 to 20. The tag key cannot be an empty string. It can be up to 128 characters long and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag. Valid values for N: 1 to 20. The tag value can be an empty string. It can be up to 128 characters long and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The transmit (Tx) queue depth of the elastic network interface.</para>
        /// <list type="bullet">
        /// <item><description><para>The transmit (Tx) and receive (Rx) queue depths must be equal. The value must be a power of 2 between 8,192 and 16,384.</para>
        /// </description></item>
        /// <item><description><para>A larger Tx queue depth can improve transmit throughput but consumes more memory.</para>
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
        /// <para>The ID of the VSwitch for the elastic network interface. The private IP addresses for the elastic network interface are assigned from the available CIDR block of the VSwitch.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>The elastic network interface and the instance to be attached must be in the same availability zone but can belong to different VSwitches.</para>
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
