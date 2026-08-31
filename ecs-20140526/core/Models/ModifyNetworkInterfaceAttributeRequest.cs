// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyNetworkInterfaceAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The network connectivity tracking configuration.</para>
        /// <para>Before you use this parameter, read <a href="https://help.aliyun.com/document_detail/2865958.html">Connection timeout management</a>.</para>
        /// </summary>
        [NameInMap("ConnectionTrackingConfiguration")]
        [Validation(Required=false)]
        public ModifyNetworkInterfaceAttributeRequestConnectionTrackingConfiguration ConnectionTrackingConfiguration { get; set; }
        public class ModifyNetworkInterfaceAttributeRequestConnectionTrackingConfiguration : TeaModel {
            /// <summary>
            /// <para>The timeout period for TCP connections in the TIME_WAIT and CLOSED states. Unit: seconds. Valid values: integers from 3 to 15.</para>
            /// <para>Default value: 3.</para>
            /// <remarks>
            /// <para>If your ECS instance is used with NLB or CLB, the default timeout period for connections in the <c>TIME_WAIT</c> state is 15 seconds.</para>
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
            /// <para>If your ECS instance is used with NLB or CLB, the default value is 100 seconds.</para>
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
        /// <para>The description of the network interface controller (NIC). The description must be 2 to 255 characters in length and cannot start with http:// or https://.</para>
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
        /// <para>This parameter is not publicly available.</para>
        /// </summary>
        [NameInMap("EnhancedNetwork")]
        [Validation(Required=false)]
        public ModifyNetworkInterfaceAttributeRequestEnhancedNetwork EnhancedNetwork { get; set; }
        public class ModifyNetworkInterfaceAttributeRequestEnhancedNetwork : TeaModel {
            [NameInMap("EnableExpress")]
            [Validation(Required=false)]
            public bool? EnableExpress { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableRss")]
            [Validation(Required=false)]
            public bool? EnableRss { get; set; }

            /// <summary>
            /// <para>This parameter is not publicly available.</para>
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
        /// <para>The ID of the network interface controller (NIC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// <para>The name of the network interface controller (NIC). The name must be 2 to 128 characters in length and must start with a letter or a Chinese character. It cannot start with <c>http://</c> or <c>https://</c>. The name can contain characters under the categorization of letter in Unicode, including English letters, Chinese characters, and digits. The name can also contain colons (:), underscores (_), periods (.), or hyphens (-).</para>
        /// <para>Default value: empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eniTestName</para>
        /// </summary>
        [NameInMap("NetworkInterfaceName")]
        [Validation(Required=false)]
        public string NetworkInterfaceName { get; set; }

        /// <summary>
        /// <para>The communication parameter of the network interface controller (NIC).</para>
        /// </summary>
        [NameInMap("NetworkInterfaceTrafficConfig")]
        [Validation(Required=false)]
        public ModifyNetworkInterfaceAttributeRequestNetworkInterfaceTrafficConfig NetworkInterfaceTrafficConfig { get; set; }
        public class ModifyNetworkInterfaceAttributeRequestNetworkInterfaceTrafficConfig : TeaModel {
            /// <summary>
            /// <para>The communication pattern of the network interface controller (NIC). Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Standard: uses the TCP communication pattern.</description></item>
            /// <item><description>HighPerformance: enables the Elastic RDMA Interface (ERI) and uses the RDMA communication pattern.</description></item>
            /// </list>
            /// <para>When the network interface controller (NIC) is in the attached state, take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>The total number of RDMA network interface controllers (NICs) of an instance cannot exceed the RDMA network interface controller (NIC) quota allowed by the instance type. You can call DescribeInstanceTypes to query the EriQuantity field for the RDMA network interface controller (NIC) quota.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>HighPerformance</para>
            /// </summary>
            [NameInMap("NetworkInterfaceTrafficMode")]
            [Validation(Required=false)]
            public string NetworkInterfaceTrafficMode { get; set; }

            /// <summary>
            /// <para>The number of queues for the network interface controller (NIC).
            /// When the network interface controller (NIC) is in the attached state, take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>The value cannot exceed the maximum number of queues per network interface controller (NIC) allowed by the instance type.</description></item>
            /// <item><description>The total number of queues across all network interface controllers (NICs) of an instance cannot exceed the total queue quota allowed by the instance type. You can call DescribeInstanceTypes to query the MaximumQueueNumberPerEni and TotalEniQueueQuantity fields.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("QueueNumber")]
            [Validation(Required=false)]
            public int? QueueNumber { get; set; }

            /// <summary>
            /// <para>The number of RDMA queues for the network interface controller (NIC).
            /// When the network interface controller (NIC) is in the attached state, take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>The value cannot exceed the maximum number of queues per RDMA network interface controller (NIC) allowed by the instance type. You can call DescribeInstanceTypes to query the QueuePairNumber field for the maximum number of queues per RDMA network interface controller (NIC).</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("QueuePairNumber")]
            [Validation(Required=false)]
            public int? QueuePairNumber { get; set; }

            /// <summary>
            /// <para>The inbound queue depth of the network interface controller (NIC).</para>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not publicly available. To use this parameter, submit a ticket to request access.</para>
            /// </remarks>
            /// <para>Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>This parameter applies only to instances of the seventh generation or later.</description></item>
            /// <item><description>This parameter currently applies only to Linux images.</description></item>
            /// <item><description>A larger inbound queue depth can improve inbound throughput and reduce packet loss, but consumes more memory.</description></item>
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
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not publicly available. To use this parameter, submit a ticket to request access.</para>
            /// </remarks>
            /// <para>Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>This parameter applies only to instances of the seventh generation or later.</description></item>
            /// <item><description>This parameter currently applies only to Linux images.</description></item>
            /// <item><description>A larger outbound queue depth can improve outbound throughput and reduce packet loss, but consumes more memory.</description></item>
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
        /// <item><description><para>You can modify the queue number of an ENI that is in the Available state, or an ENI that is in the InUse state but attached to an instance in the Stopped state.</para>
        /// </description></item>
        /// <item><description><para>The queue number cannot exceed the maximum number of queues per ENI allowed by the instance type. The total number of queues across all ENIs of an instance cannot exceed the total queue quota allowed by the instance type. You can call <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> to query the MaximumQueueNumberPerEni and TotalEniQueueQuantity fields for the instance type.</para>
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
        /// <para>The region ID of the network interface controller (NIC). You can invoke <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
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
        /// <para>The inbound queue depth of the network interface controller (NIC).</para>
        /// <remarks>
        /// <para>This parameter is in invitational preview and is not publicly available. To use this parameter, submit a ticket to request access.</para>
        /// </remarks>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>This parameter applies only to instances of the seventh generation or later.</description></item>
        /// <item><description>This parameter currently applies only to Linux images.</description></item>
        /// <item><description>A larger inbound queue depth can improve inbound throughput and reduce packet loss, but consumes more memory.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8192</para>
        /// </summary>
        [NameInMap("RxQueueSize")]
        [Validation(Required=false)]
        public int? RxQueueSize { get; set; }

        /// <summary>
        /// <para>The list of security group IDs. The secondary network interface controller (NIC) joins the specified security groups and is removed from the existing security groups.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values of N depend on the maximum number of security groups to which a network interface controller (NIC) can belong. For more information, see <a href="~~25412#SecurityGroupQuota~~">Limits</a>.</para>
        /// </description></item>
        /// <item><description><para>The modification takes effect shortly, but a slight delay may occur.</para>
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
        /// <para>Only specific regions support this feature. Before using this feature, read <a href="https://help.aliyun.com/document_detail/2863210.html">Source/destination checking</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SourceDestCheck")]
        [Validation(Required=false)]
        public bool? SourceDestCheck { get; set; }

        /// <summary>
        /// <para>The outbound queue depth of the network interface controller (NIC).</para>
        /// <remarks>
        /// <para>This parameter is in invitational preview and is not publicly available. To use this parameter, submit a ticket to request access.</para>
        /// </remarks>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>This parameter applies only to instances of the seventh generation or later.</description></item>
        /// <item><description>This parameter currently applies only to Linux images.</description></item>
        /// <item><description>A larger outbound queue depth can improve outbound throughput and reduce packet loss, but consumes more memory.</description></item>
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
