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
        /// </summary>
        [NameInMap("ConnectionTrackingConfiguration")]
        [Validation(Required=false)]
        public ModifyNetworkInterfaceAttributeRequestConnectionTrackingConfiguration ConnectionTrackingConfiguration { get; set; }
        public class ModifyNetworkInterfaceAttributeRequestConnectionTrackingConfiguration : TeaModel {
            /// <summary>
            /// <para>The timeout period for TCP connections in the TIME_WAIT or CLOSED state. Unit: seconds. Valid values: integers from 3 to 15.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TcpClosedAndTimeWaitTimeout")]
            [Validation(Required=false)]
            public int? TcpClosedAndTimeWaitTimeout { get; set; }

            /// <summary>
            /// <para>The timeout period for established TCP connections. Unit: seconds. Valid values: [30, 60, 80, 100, 200, 300, 500, 700, 910].</para>
            /// 
            /// <b>Example:</b>
            /// <para>910</para>
            /// </summary>
            [NameInMap("TcpEstablishedTimeout")]
            [Validation(Required=false)]
            public int? TcpEstablishedTimeout { get; set; }

            /// <summary>
            /// <para>The timeout period for UDP flows. Unit: seconds. Valid values: [10, 20, 30, 60, 80, 100].</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeleteOnRelease")]
        [Validation(Required=false)]
        public bool? DeleteOnRelease { get; set; }

        /// <summary>
        /// <para>The description of the ENI. The description must be 2 to 255 characters in length and cannot start with http:// or https://.</para>
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
        /// <para>The ID of the ENI.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// <para>The name of the ENI. The name must be 2 to 128 characters in length and must start with a letter or a Chinese character. It cannot start with <c>http://</c> or <c>https://</c>. The name can contain characters under the letter categorization in Unicode, including English letters, Chinese characters, and digits. It can also contain colons (:), underscores (_), periods (.), or hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>eniTestName</para>
        /// </summary>
        [NameInMap("NetworkInterfaceName")]
        [Validation(Required=false)]
        public string NetworkInterfaceName { get; set; }

        /// <summary>
        /// <para>The communication parameters of the network interface controller (NIC).</para>
        /// </summary>
        [NameInMap("NetworkInterfaceTrafficConfig")]
        [Validation(Required=false)]
        public ModifyNetworkInterfaceAttributeRequestNetworkInterfaceTrafficConfig NetworkInterfaceTrafficConfig { get; set; }
        public class ModifyNetworkInterfaceAttributeRequestNetworkInterfaceTrafficConfig : TeaModel {
            /// <summary>
            /// <para>The communication mode of the network interface. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Standard: Uses TCP communication mode.</description></item>
            /// <item><description>HighPerformance: Enables the Elastic RDMA Interface (ERI) and uses RDMA communication mode.</description></item>
            /// </list>
            /// <para>When the ENI is in the attached state, note the following:</para>
            /// <list type="bullet">
            /// <item><description>The total number of RDMA network interfaces on an instance cannot exceed the RDMA network interface quota allowed by the instance type. You can query the EriQuantity field by calling the DescribeInstanceTypes operation to obtain the RDMA network interface quota allowed by the instance type.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not yet publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>HighPerformance</para>
            /// </summary>
            [NameInMap("NetworkInterfaceTrafficMode")]
            [Validation(Required=false)]
            public string NetworkInterfaceTrafficMode { get; set; }

            /// <summary>
            /// <para>The number of queues for the ENI.
            /// When the ENI is in the attached state, take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>The value cannot exceed the maximum number of queues allowed per ENI for the instance type.</description></item>
            /// <item><description>The total number of queues across all ENIs of the instance cannot exceed the total queue quota allowed for the instance type. You can call the DescribeInstanceTypes operation to query the MaximumQueueNumberPerEni and TotalEniQueueQuantity fields for the maximum number of queues per ENI and the total quota of the instance type.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not yet publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("QueueNumber")]
            [Validation(Required=false)]
            public int? QueueNumber { get; set; }

            /// <summary>
            /// <para>The number of queues on the RDMA network interface.
            /// When the ENI is in the attached state, take note of the following:</para>
            /// <list type="bullet">
            /// <item><description>The value cannot exceed the maximum number of queues allowed per RDMA network interface for the instance type. You can call the DescribeInstanceTypes operation to query the QueuePairNumber field for the maximum number of queues allowed per RDMA network interface for the instance type.</description></item>
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
            /// 
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("RxQueueSize")]
            [Validation(Required=false)]
            public int? RxQueueSize { get; set; }

            /// <summary>
            /// <para>The outbound queue depth of the network interface controller (NIC).</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("QueueNumber")]
        [Validation(Required=false)]
        public int? QueueNumber { get; set; }

        /// <summary>
        /// <para>The region ID of the ENI. You can invoke <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>8192</para>
        /// </summary>
        [NameInMap("RxQueueSize")]
        [Validation(Required=false)]
        public int? RxQueueSize { get; set; }

        /// <summary>
        /// <para>The IDs of security groups. The secondary ENI is added to the specified security groups and removed from the existing security groups.</para>
        /// <list type="bullet">
        /// <item><description><para>The valid values of N depend on the quota for the maximum number of security groups to which an ENI can belong. For more information, see <a href="~~25412#SecurityGroupQuota~~">Before you begin</a>.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SourceDestCheck")]
        [Validation(Required=false)]
        public bool? SourceDestCheck { get; set; }

        /// <summary>
        /// <para>The outbound queue depth of the network interface controller (NIC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>8192</para>
        /// </summary>
        [NameInMap("TxQueueSize")]
        [Validation(Required=false)]
        public int? TxQueueSize { get; set; }

    }

}
