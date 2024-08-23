// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyNetworkInterfaceAttributeRequest : TeaModel {
        /// <summary>
        /// >  This parameter is in invitational preview and is not publicly available.
        /// </summary>
        [NameInMap("ConnectionTrackingConfiguration")]
        [Validation(Required=false)]
        public ModifyNetworkInterfaceAttributeRequestConnectionTrackingConfiguration ConnectionTrackingConfiguration { get; set; }
        public class ModifyNetworkInterfaceAttributeRequestConnectionTrackingConfiguration : TeaModel {
            /// <summary>
            /// >  This parameter is in invitational preview and is not publicly available.
            /// </summary>
            [NameInMap("TcpClosedAndTimeWaitTimeout")]
            [Validation(Required=false)]
            public int? TcpClosedAndTimeWaitTimeout { get; set; }

            /// <summary>
            /// >  This parameter is in invitational preview and is not publicly available.
            /// </summary>
            [NameInMap("TcpEstablishedTimeout")]
            [Validation(Required=false)]
            public int? TcpEstablishedTimeout { get; set; }

            /// <summary>
            /// >  This parameter is in invitational preview and is not publicly available.
            /// </summary>
            [NameInMap("UdpTimeout")]
            [Validation(Required=false)]
            public int? UdpTimeout { get; set; }

        }

        /// <summary>
        /// Specifies whether to release the ENI when the associated instance is released. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("DeleteOnRelease")]
        [Validation(Required=false)]
        public bool? DeleteOnRelease { get; set; }

        /// <summary>
        /// The description of the ENI. The description must be 2 to 255 characters in length and cannot start with [http:// or https://](http://https://。).
        /// 
        /// This parameter is left empty by default.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// This parameter is not publicly available.
        /// </summary>
        [NameInMap("EnhancedNetwork")]
        [Validation(Required=false)]
        public ModifyNetworkInterfaceAttributeRequestEnhancedNetwork EnhancedNetwork { get; set; }
        public class ModifyNetworkInterfaceAttributeRequestEnhancedNetwork : TeaModel {
            /// <summary>
            /// This parameter is not publicly available.
            /// </summary>
            [NameInMap("EnableSriov")]
            [Validation(Required=false)]
            public bool? EnableSriov { get; set; }

        }

        /// <summary>
        /// The ID of the ENI.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// The name of the ENI. The name must be 2 to 128 characters in length. The name must start with a letter and cannot start with `http://` or `https://`. The name can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).
        /// 
        /// This parameter is left empty by default.
        /// </summary>
        [NameInMap("NetworkInterfaceName")]
        [Validation(Required=false)]
        public string NetworkInterfaceName { get; set; }

        /// <summary>
        /// The communication parameters of the ENI.
        /// </summary>
        [NameInMap("NetworkInterfaceTrafficConfig")]
        [Validation(Required=false)]
        public ModifyNetworkInterfaceAttributeRequestNetworkInterfaceTrafficConfig NetworkInterfaceTrafficConfig { get; set; }
        public class ModifyNetworkInterfaceAttributeRequestNetworkInterfaceTrafficConfig : TeaModel {
            /// <summary>
            /// The communication mode of the ENI. Valid values:
            /// 
            /// *   Standard: uses the TCP communication mode.
            /// *   HighPerformance: uses the remote direct memory access (RDMA) communication mode with Elastic RDMA Interface (ERI) enabled.
            /// 
            /// When the ENI is in the InUse state, take note of the following items:
            /// 
            /// *   The total number of ERIs attached to the instance cannot exceed the ERI quota for the instance type. To query the ERI quota for an instance type, call the DescribeInstanceTypes operation and check the EriQuantity value in the response.
            /// 
            /// >  This parameter is in invitational preview and is not publicly available.
            /// </summary>
            [NameInMap("NetworkInterfaceTrafficMode")]
            [Validation(Required=false)]
            public string NetworkInterfaceTrafficMode { get; set; }

            /// <summary>
            /// The number of queues supported by the ENI. When the ENI is in the InUse state, take note of the following items:
            /// 
            /// *   The value of this parameter cannot exceed the maximum number of queues allowed per ENI for the instance type.
            /// *   The total number of queues for all ENIs on the instance cannot exceed the queue quota for the instance type. To query the maximum number of queues per ENI and the queue quota for an instance type, call the DescribeInstanceTypes operation and check the MaximumQueueNumberPerEnig and TotalEniQueueQuantity values in the response.
            /// 
            /// >  This parameter is in invitational preview and is not publicly available.
            /// </summary>
            [NameInMap("QueueNumber")]
            [Validation(Required=false)]
            public int? QueueNumber { get; set; }

            /// <summary>
            /// The number of queues supported by the ERI. When the ERI is in the InUse state, take note of the following items:
            /// 
            /// *   The value of this parameter cannot exceed the maximum number of queues allowed per ERI for the instance type. To query the maximum number of queues allowed per ERI for an instance type, call the DescribeInstanceTypes operation and check the QueuePairNumber value in the response.
            /// 
            /// >  This parameter is in invitational preview and is not publicly available.
            /// </summary>
            [NameInMap("QueuePairNumber")]
            [Validation(Required=false)]
            public int? QueuePairNumber { get; set; }

            /// <summary>
            /// The receive (Rx) queue depth of the ENI.
            /// 
            /// Take note of the following items:
            /// 
            /// *   The Rx queue depth of an ENI must be the same as the transmit (Tx) queue depth of the ENI. Valid values: powers of 2 in the range of 8192 to 16384.
            /// *   A larger Rx queue depth yields higher inbound throughput but consumes more memory.
            /// 
            /// >  This parameter is in invitational preview and is not publicly available.
            /// </summary>
            [NameInMap("RxQueueSize")]
            [Validation(Required=false)]
            public int? RxQueueSize { get; set; }

            /// <summary>
            /// The Tx queue depth of the ENI.
            /// 
            /// Take note of the following items:
            /// 
            /// *   The Tx queue depth of an ENI must be the same as the Rx queue depth of the ENI. Valid values: powers of 2 in the range of 8192 to 16384.
            /// *   A larger Tx queue depth yields higher outbound throughput but consumes more memory.
            /// 
            /// >  This parameter is in invitational preview and is not publicly available.
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
        /// The number of queues supported by the ENI. Valid values: 1 to 2048.
        /// 
        /// *   You can change only the number of queues supported by the secondary ENI.
        /// *   You can change the number of queues supported by the secondary ENI only when the ENI is in the `Available` state or the ENI is attached (`InUse`) to an instance that is in the `Stopped` state.
        /// *   The number of queues supported by the secondary ENI cannot exceed the maximum number of queues that the instance allows for each ENI. The total number of queues for all ENIs on the instance cannot exceed the queue quota that the instance allows. To query the maximum number of queues per ENI and the queue quota for an instance type, you can call the [DescribeInstanceTypes](https://help.aliyun.com/document_detail/25620.html) operation and check the values of `MaximumQueueNumberPerEni` and `TotalEniQueueQuantity` in the response.
        /// </summary>
        [NameInMap("QueueNumber")]
        [Validation(Required=false)]
        public int? QueueNumber { get; set; }

        /// <summary>
        /// The region ID of the ENI. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
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
        /// The receive (Rx) queue depth of the ENI.
        /// 
        /// Take note of the following items:
        /// 
        /// *   The Rx queue depth of an ENI must be the same as the transmit (Tx) queue depth of the ENI. Valid values: powers of 2 in the range of 8192 to 16384.
        /// *   A larger Rx queue depth yields higher inbound throughput but consumes more memory.
        /// </summary>
        [NameInMap("RxQueueSize")]
        [Validation(Required=false)]
        public int? RxQueueSize { get; set; }

        /// <summary>
        /// The IDs of the security groups to which to add the secondary ENI. The secondary ENI is added to the specified security groups and removed from the original security groups.
        /// 
        /// *   The valid values of N vary based on the maximum number of security groups to which an ENI can be added. For more information, see the [Security group limits](~~25412#SecurityGroupQuota~~) section of the "Limits and quotas" topic.
        /// *   The new security groups take effect after a short delay.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public List<string> SecurityGroupId { get; set; }

        /// <summary>
        /// The Tx queue depth of the ENI.
        /// 
        /// Take note of the following items:
        /// 
        /// *   The Tx queue depth of an ENI must be the same as the Rx queue depth of the ENI. Valid values: powers of 2 in the range of 8192 to 16384.
        /// *   A larger Tx queue depth yields higher outbound throughput but consumes more memory.
        /// </summary>
        [NameInMap("TxQueueSize")]
        [Validation(Required=false)]
        public int? TxQueueSize { get; set; }

    }

}
