// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyNetworkInterfaceAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The network connectivity tracking configuration information set.</para>
        /// <para>Before using this parameter, read <a href="https://help.aliyun.com/document_detail/2865958.html">Connection timeout management</a>.</para>
        /// </summary>
        [NameInMap("ConnectionTrackingConfiguration")]
        [Validation(Required=false)]
        public ModifyNetworkInterfaceAttributeRequestConnectionTrackingConfiguration ConnectionTrackingConfiguration { get; set; }
        public class ModifyNetworkInterfaceAttributeRequestConnectionTrackingConfiguration : TeaModel {
            /// <summary>
            /// <para>The timeout period for closed and TIME_WAIT TCP connections. Unit: seconds. Valid values: integers from 3 to 15.</para>
            /// <para>Default value: 3.</para>
            /// <remarks>
            /// <para>If your ECS instance is used together with an NLB or CLB instance, the default timeout period for connections in the <c>TIME_WAIT</c> state is 15 seconds.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TcpClosedAndTimeWaitTimeout")]
            [Validation(Required=false)]
            public int? TcpClosedAndTimeWaitTimeout { get; set; }

            /// <summary>
            /// <para>The timeout period for established TCP connections. Unit: seconds. Valid values: 30, 60, 80, 100, 200, 300, 500, 700, and 910.</para>
            /// <para>Default value: 910.</para>
            /// 
            /// <b>Example:</b>
            /// <para>910</para>
            /// </summary>
            [NameInMap("TcpEstablishedTimeout")]
            [Validation(Required=false)]
            public int? TcpEstablishedTimeout { get; set; }

            /// <summary>
            /// <para>The timeout period for UDP flows. Unit: seconds. Valid values: 10, 20, 30, 60, 80, and 100.</para>
            /// <para>Default value: 30.</para>
            /// <remarks>
            /// <para>If your ECS instance is used together with an NLB or CLB instance, the default value is 100 seconds.</para>
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
        /// <para>Specifies whether to retain the ENI when the instance is released. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The ENI is not retained.</para>
        /// </description></item>
        /// <item><description><para>false: The ENI is retained.</para>
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
        /// <para>The description of the Elastic Network Interface (ENI) (network interface controller (NIC)). The description must be 2 to 255 characters in length and cannot start with http:// or https://.</para>
        /// <para>Default value: empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether the primary IPv6 address is enabled for the Elastic Network Interface (ENI) (network interface controller (NIC)).</para>
        /// </summary>
        [NameInMap("EnablePrimaryIPv6")]
        [Validation(Required=false)]
        public bool? EnablePrimaryIPv6 { get; set; }

        /// <summary>
        /// <para>This parameter is not available for public use.</para>
        /// </summary>
        [NameInMap("EnhancedNetwork")]
        [Validation(Required=false)]
        public ModifyNetworkInterfaceAttributeRequestEnhancedNetwork EnhancedNetwork { get; set; }
        public class ModifyNetworkInterfaceAttributeRequestEnhancedNetwork : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This parameter is not available for public use.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("EnableExpress")]
            [Validation(Required=false)]
            public bool? EnableExpress { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not available for public use.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableRss")]
            [Validation(Required=false)]
            public bool? EnableRss { get; set; }

            /// <summary>
            /// <para>This parameter is not available for public use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableSriov")]
            [Validation(Required=false)]
            public bool? EnableSriov { get; set; }

            /// <summary>
            /// <para>The number of virtual functions when SR-IOV is enabled. Valid values: 1 to 256.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("VirtualFunctionQuantity")]
            [Validation(Required=false)]
            public int? VirtualFunctionQuantity { get; set; }

            /// <summary>
            /// <para>The total number of queues for virtual functions when SR-IOV is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("VirtualFunctionTotalQueueNumber")]
            [Validation(Required=false)]
            public int? VirtualFunctionTotalQueueNumber { get; set; }

        }

        /// <summary>
        /// <para>The ID of the Elastic Network Interface (ENI) (network interface controller (NIC)).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// <para>The name of the Elastic Network Interface (ENI) (network interface controller (NIC)). The name must be 2 to 128 characters in length. It must start with a letter or a Chinese character and cannot start with <c>http://</c> or <c>https://</c>. It supports Unicode characters in the letter categorization, including English letters, Chinese characters, and digits. It can contain colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// <para>Default value: empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eniTestName</para>
        /// </summary>
        [NameInMap("NetworkInterfaceName")]
        [Validation(Required=false)]
        public string NetworkInterfaceName { get; set; }

        /// <summary>
        /// <para>The traffic parameter of the Elastic Network Interface (ENI) (network interface controller (NIC)).</para>
        /// </summary>
        [NameInMap("NetworkInterfaceTrafficConfig")]
        [Validation(Required=false)]
        public ModifyNetworkInterfaceAttributeRequestNetworkInterfaceTrafficConfig NetworkInterfaceTrafficConfig { get; set; }
        public class ModifyNetworkInterfaceAttributeRequestNetworkInterfaceTrafficConfig : TeaModel {
            /// <summary>
            /// <para>The traffic pattern of the network interface controller (NIC). Valid values for the parameter:</para>
            /// <list type="bullet">
            /// <item><description>Standard: uses the TCP traffic pattern.</description></item>
            /// <item><description>HighPerformance: enables the Elastic RDMA Interface (ERI) and uses the RDMA traffic pattern.</description></item>
            /// </list>
            /// <para>When the Elastic Network Interface (ENI) is attached to an instance, take note of the following item:</para>
            /// <list type="bullet">
            /// <item><description>The total number of RDMA network interface controllers (NICs) for the instance cannot exceed the RDMA network interface controller (NIC) quota allowed by the instance type. You can invoke the DescribeInstanceTypes operation and query the EriQuantity field to obtain the RDMA network interface controller (NIC) quota for the instance type.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HighPerformance</para>
            /// </summary>
            [NameInMap("NetworkInterfaceTrafficMode")]
            [Validation(Required=false)]
            public string NetworkInterfaceTrafficMode { get; set; }

            /// <summary>
            /// <para>The number of queues for the Elastic Network Interface (ENI).
            /// When the Elastic Network Interface (ENI) is attached to an instance, take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>The number of queues cannot exceed the maximum number of queues per network interface controller (NIC) allowed by the instance type.</description></item>
            /// <item><description>The total number of queues for all network interface controllers (NICs) attached to the instance cannot exceed the total queue quota allowed by the instance type. You can invoke the DescribeInstanceTypes operation and query the MaximumQueueNumberPerEni and TotalEniQueueQuantity fields to obtain the maximum number of queues per network interface controller (NIC) and the total queue quota for the instance type.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not available for public use.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("QueueNumber")]
            [Validation(Required=false)]
            public int? QueueNumber { get; set; }

            /// <summary>
            /// <para>The number of queues for the RDMA network interface controller (NIC).
            /// When the Elastic Network Interface (ENI) is attached to an instance, take note of the following item:</para>
            /// <list type="bullet">
            /// <item><description>The number of queues cannot exceed the maximum number of queues per RDMA network interface controller (NIC) allowed by the instance type. You can invoke the DescribeInstanceTypes operation and query the QueuePairNumber field to obtain the maximum number of queues per RDMA network interface controller (NIC) for the instance type.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("QueuePairNumber")]
            [Validation(Required=false)]
            public int? QueuePairNumber { get; set; }

            /// <summary>
            /// <para>The inbound queue depth of the Elastic Network Interface (ENI) (network interface controller (NIC)).</para>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not available for public use. If you need to use this parameter, submit a ticket to apply for whitelist access.</para>
            /// </remarks>
            /// <para>Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>This parameter applies only to seventh-generation and later ECS instance types.</description></item>
            /// <item><description>This parameter currently applies only to Linux images.</description></item>
            /// <item><description>A larger inbound queue depth can increase inbound throughput and reduce the packet loss rate, but it consumes more memory.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("RxQueueSize")]
            [Validation(Required=false)]
            public int? RxQueueSize { get; set; }

            /// <summary>
            /// <para>The outbound queue depth of the Elastic Network Interface (ENI) (network interface controller (NIC)).</para>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not available for public use. If you need to use this parameter, submit a ticket to apply for whitelist access.</para>
            /// </remarks>
            /// <para>Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>This parameter applies only to seventh-generation and later ECS instance types.</description></item>
            /// <item><description>This parameter currently applies only to Linux images.</description></item>
            /// <item><description>A larger outbound queue depth can increase outbound throughput and reduce the packet loss rate, but it consumes more memory.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("TxQueueSize")]
            [Validation(Required=false)]
            public int? TxQueueSize { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of queues for the ENI. Valid values: 1 to 2048.</para>
        /// <list type="bullet">
        /// <item><description><para>You can modify the number of queues for an ENI that is in the <c>Available</c> state, or an ENI that is attached (<c>InUse</c>) to an instance that is in the <c>Stopped</c> state.</para>
        /// </description></item>
        /// <item><description><para>The number of queues for the ENI cannot exceed the maximum number of queues per ENI allowed by the instance type. The total number of queues for all ENIs attached to the instance cannot exceed the total queue quota allowed by the instance type. You can call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation and query the MaximumQueueNumberPerEni and TotalEniQueueQuantity fields to obtain the maximum number of queues per ENI and the total queue quota for the instance type.</para>
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
        /// <para>The region ID of the Elastic Network Interface (ENI) (network interface controller (NIC)). You can invoke the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
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
        /// <para>The inbound queue depth of the Elastic Network Interface (ENI) (network interface controller (NIC)).</para>
        /// <remarks>
        /// <para>This parameter is in invitational preview and is not available for public use. If you need to use this parameter, submit a ticket to apply for whitelist access.</para>
        /// </remarks>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>This parameter applies only to seventh-generation and later ECS instance types.</description></item>
        /// <item><description>This parameter currently applies only to Linux images.</description></item>
        /// <item><description>A larger inbound queue depth can increase inbound throughput and reduce the packet loss rate, but it consumes more memory.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8192</para>
        /// </summary>
        [NameInMap("RxQueueSize")]
        [Validation(Required=false)]
        public int? RxQueueSize { get; set; }

        /// <summary>
        /// <para>The list of security group IDs. The secondary Elastic Network Interface (ENI) (network interface controller (NIC)) will be added to the specified security groups and removed from its existing security groups.</para>
        /// <list type="bullet">
        /// <item><description><para>The valid values of N depend on the quota of security groups that each Elastic Network Interface (ENI) can join. For more information, see <a href="~~25412#SecurityGroupQuota~~">Limits</a>.</para>
        /// </description></item>
        /// <item><description><para>Changes to security groups take effect shortly, but a slight delay may occur.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public List<string> SecurityGroupId { get; set; }

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
        /// <para>The outbound queue depth of the Elastic Network Interface (ENI) (network interface controller (NIC)).</para>
        /// <remarks>
        /// <para>This parameter is in invitational preview and is not available for public use. If you need to use this parameter, submit a ticket to apply for whitelist access.</para>
        /// </remarks>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>This parameter applies only to seventh-generation and later ECS instance types.</description></item>
        /// <item><description>This parameter currently applies only to Linux images.</description></item>
        /// <item><description>A larger outbound queue depth can increase outbound throughput and reduce the packet loss rate, but it consumes more memory.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8192</para>
        /// </summary>
        [NameInMap("TxQueueSize")]
        [Validation(Required=false)]
        public int? TxQueueSize { get; set; }

    }

}
