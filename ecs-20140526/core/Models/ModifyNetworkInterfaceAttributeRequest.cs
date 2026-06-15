// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyNetworkInterfaceAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The connection tracking configuration.</para>
        /// <para>Before using this parameter, we recommend that you read <a href="https://help.aliyun.com/document_detail/2865958.html">Connection timeout management</a>.</para>
        /// </summary>
        [NameInMap("ConnectionTrackingConfiguration")]
        [Validation(Required=false)]
        public ModifyNetworkInterfaceAttributeRequestConnectionTrackingConfiguration ConnectionTrackingConfiguration { get; set; }
        public class ModifyNetworkInterfaceAttributeRequestConnectionTrackingConfiguration : TeaModel {
            /// <summary>
            /// <para>The timeout period, in seconds, for TCP connections in the <c>TIME_WAIT</c> or <c>CLOSE_WAIT</c> state. The value must be an integer from 3 to 15.</para>
            /// <para>Default value: 3.</para>
            /// <remarks>
            /// <para>If your ECS instance is used with Network Load Balancer (NLB) or Classic Load Balancer (CLB), the default timeout period for connections in the <c>TIME_WAIT</c> state is 15 seconds.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TcpClosedAndTimeWaitTimeout")]
            [Validation(Required=false)]
            public int? TcpClosedAndTimeWaitTimeout { get; set; }

            /// <summary>
            /// <para>The timeout period for TCP connections in the <c>ESTABLISHED</c> state, in seconds. Valid values: 30, 60, 80, 100, 200, 300, 500, 700, and 910.</para>
            /// <para>Default value: 910.</para>
            /// 
            /// <b>Example:</b>
            /// <para>910</para>
            /// </summary>
            [NameInMap("TcpEstablishedTimeout")]
            [Validation(Required=false)]
            public int? TcpEstablishedTimeout { get; set; }

            /// <summary>
            /// <para>The timeout period for UDP flows, in seconds. Valid values: 10, 20, 30, 60, 80, and 100.</para>
            /// <para>Default value: 30.</para>
            /// <remarks>
            /// <para>If your ECS instance is used with Network Load Balancer (NLB) or Classic Load Balancer (CLB), the default value is 100 seconds.</para>
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
        /// <para>Specifies whether to delete the elastic network interface when its attached instance is released. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The elastic network interface is deleted.</para>
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
        /// <para>The description of the elastic network interface. The description must be 2 to 255 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// <para>Default value: empty.</para>
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
        public ModifyNetworkInterfaceAttributeRequestEnhancedNetwork EnhancedNetwork { get; set; }
        public class ModifyNetworkInterfaceAttributeRequestEnhancedNetwork : TeaModel {
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
        /// <para>The ID of the elastic network interface.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// <para>The name of the elastic network interface. The name must be 2 to 128 characters in length, start with a letter or a Chinese character, and not start with <c>http://</c> or <c>https://</c>. It can contain letters, digits, Chinese characters, colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// <para>Default value: empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eniTestName</para>
        /// </summary>
        [NameInMap("NetworkInterfaceName")]
        [Validation(Required=false)]
        public string NetworkInterfaceName { get; set; }

        /// <summary>
        /// <para>The traffic configuration of the elastic network interface.</para>
        /// </summary>
        [NameInMap("NetworkInterfaceTrafficConfig")]
        [Validation(Required=false)]
        public ModifyNetworkInterfaceAttributeRequestNetworkInterfaceTrafficConfig NetworkInterfaceTrafficConfig { get; set; }
        public class ModifyNetworkInterfaceAttributeRequestNetworkInterfaceTrafficConfig : TeaModel {
            /// <summary>
            /// <para>The traffic mode of the elastic network interface. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Standard</c>: The standard TCP traffic mode.</para>
            /// </description></item>
            /// <item><description><para><c>HighPerformance</c>: The RDMA traffic mode with the Elastic RDMA Interface (ERI) feature enabled.</para>
            /// </description></item>
            /// </list>
            /// <para>If the elastic network interface is attached to an instance, note the following:</para>
            /// <list type="bullet">
            /// <item><description>The total number of ERI-enabled elastic network interfaces on the instance cannot exceed the quota for the instance type. You can call the <a href="">DescribeInstanceTypes operation to query the value of the <c>EriQuantity</c> parameter.</a></description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is available by invitation only.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>HighPerformance</para>
            /// </summary>
            [NameInMap("NetworkInterfaceTrafficMode")]
            [Validation(Required=false)]
            public string NetworkInterfaceTrafficMode { get; set; }

            /// <summary>
            /// <para>The number of queues for the elastic network interface.
            /// If the elastic network interface is attached to an instance, note the following:</para>
            /// <list type="bullet">
            /// <item><description><para>The value cannot exceed the maximum number of queues per elastic network interface that is supported by the instance type.</para>
            /// </description></item>
            /// <item><description><para>The total number of queues for all elastic network interfaces on the instance cannot exceed the queue quota for the instance type. You can call the <a href="">DescribeInstanceTypes operation to query the <c>MaximumQueueNumberPerEni</c> and <c>TotalEniQueueQuantity</c> values for an instance type.</a></para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is available by invitation only. To use this feature, submit a ticket.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("QueueNumber")]
            [Validation(Required=false)]
            public int? QueueNumber { get; set; }

            /// <summary>
            /// <para>The number of queue pairs for the ERI.
            /// If the elastic network interface is attached to an instance, note the following:</para>
            /// <list type="bullet">
            /// <item><description>The value cannot exceed the maximum number of queue pairs per ERI that is supported by the instance type. You can call the <a href="">DescribeInstanceTypes operation to query the value of the <c>QueuePairNumber</c> parameter for an instance type.</a></description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is available by invitation only. To use this feature, submit a ticket.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("QueuePairNumber")]
            [Validation(Required=false)]
            public int? QueuePairNumber { get; set; }

            /// <summary>
            /// <para>The queue depth for inbound traffic on the elastic network interface.</para>
            /// <remarks>
            /// <para>This parameter is available by invitation only. To use this feature, submit a ticket.</para>
            /// </remarks>
            /// <para>Note the following:</para>
            /// <list type="bullet">
            /// <item><description><para>This parameter is available only for instance types of the 7th generation and later.</para>
            /// </description></item>
            /// <item><description><para>This parameter is available only for instances that use Linux images.</para>
            /// </description></item>
            /// <item><description><para>A larger queue depth for inbound traffic increases throughput and reduces the packet loss rate, but consumes more memory.</para>
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
            /// <para>The queue depth for outbound traffic on the elastic network interface.</para>
            /// <remarks>
            /// <para>This parameter is available by invitation only. To use this feature, submit a ticket.</para>
            /// </remarks>
            /// <para>Note the following:</para>
            /// <list type="bullet">
            /// <item><description><para>This parameter is available only for instance types of the 7th generation and later.</para>
            /// </description></item>
            /// <item><description><para>This parameter is available only for instances that use Linux images.</para>
            /// </description></item>
            /// <item><description><para>A larger queue depth for outbound traffic increases throughput and reduces the packet loss rate, but consumes more memory.</para>
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

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of queues for the elastic network interface. Valid values: 1 to 2048.</para>
        /// <list type="bullet">
        /// <item><description><para>You can change the number of queues for an elastic network interface only when it is in the <c>Available</c> state or is attached to an instance in the <c>Stopped</c> state.</para>
        /// </description></item>
        /// <item><description><para>The number of queues cannot exceed the maximum supported by the instance type. The total number of queues for all elastic network interfaces attached to the instance cannot exceed the instance\&quot;s queue quota. You can call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation to query the <c>MaximumQueueNumberPerEni</c> and <c>TotalEniQueueQuantity</c> values for an instance type.</para>
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
        /// <para>The ID of the region where the elastic network interface is located. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the latest list of Alibaba Cloud regions.</para>
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
        /// <para>The queue depth for inbound traffic on the elastic network interface.</para>
        /// <remarks>
        /// <para>This parameter is available by invitation only. To use this feature, submit a ticket.</para>
        /// </remarks>
        /// <para>Note the following:</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is available only for instance types of the 7th generation and later.</para>
        /// </description></item>
        /// <item><description><para>This parameter is available only for instances that use Linux images.</para>
        /// </description></item>
        /// <item><description><para>A larger queue depth for inbound traffic increases throughput and reduces the packet loss rate, but consumes more memory.</para>
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
        /// <para>The IDs of new security groups to associate with the secondary elastic network interface. The interface is then detached from its original security groups.</para>
        /// <list type="bullet">
        /// <item><description><para>The number of security groups that you can specify is limited by the maximum number of security groups to which an elastic network interface can be attached. For more information, see <a href="~~25412#SecurityGroupQuota~~">Usage limits</a>.</para>
        /// </description></item>
        /// <item><description><para>The changes take effect after a short delay.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public List<string> SecurityGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the source/destination check. For enhanced security, we recommend enabling this feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Enabled</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Disabled</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// <remarks>
        /// <para>This feature is available only in specific regions. Before you use this parameter, read <a href="https://help.aliyun.com/document_detail/2863210.html">Source/destination check</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SourceDestCheck")]
        [Validation(Required=false)]
        public bool? SourceDestCheck { get; set; }

        /// <summary>
        /// <para>The queue depth for outbound traffic on the elastic network interface.</para>
        /// <remarks>
        /// <para>This parameter is available by invitation only. To use this feature, submit a ticket.</para>
        /// </remarks>
        /// <para>Note the following:</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is available only for instance types of the 7th generation and later.</para>
        /// </description></item>
        /// <item><description><para>This parameter is available only for instances that use Linux images.</para>
        /// </description></item>
        /// <item><description><para>A larger queue depth for outbound traffic increases throughput and reduces the packet loss rate, but consumes more memory.</para>
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

}
