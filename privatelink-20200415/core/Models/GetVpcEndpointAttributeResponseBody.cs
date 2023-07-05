// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class GetVpcEndpointAttributeResponseBody : TeaModel {
        /// <summary>
        /// The description of the endpoint.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// The ID of the endpoint.
        /// </summary>
        [NameInMap("ConnectionStatus")]
        [Validation(Required=false)]
        public string ConnectionStatus { get; set; }

        /// <summary>
        /// The ID of the endpoint service with which the endpoint is associated.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The business status of the endpoint. Valid values:
        /// 
        /// *   **Normal**: normal
        /// *   **FinacialLocked**: locked due to overdue payments
        /// </summary>
        [NameInMap("EndpointBusinessStatus")]
        [Validation(Required=false)]
        public string EndpointBusinessStatus { get; set; }

        /// <summary>
        /// The name of the endpoint.
        /// </summary>
        [NameInMap("EndpointDescription")]
        [Validation(Required=false)]
        public string EndpointDescription { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) to which the endpoint belongs.
        /// </summary>
        [NameInMap("EndpointDomain")]
        [Validation(Required=false)]
        public string EndpointDomain { get; set; }

        /// <summary>
        /// The bandwidth of the endpoint connection. Unit: Mbit/s.
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// The time when the endpoint was created.
        /// </summary>
        [NameInMap("EndpointName")]
        [Validation(Required=false)]
        public string EndpointName { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **GetVpcEndpointAttribute**.
        /// </summary>
        [NameInMap("EndpointStatus")]
        [Validation(Required=false)]
        public string EndpointStatus { get; set; }

        /// <summary>
        /// The payer. Valid values:
        /// 
        /// *   **Endpoint**: the service consumer
        /// *   **EndpointService**: the service provider
        /// </summary>
        [NameInMap("EndpointType")]
        [Validation(Required=false)]
        public string EndpointType { get; set; }

        /// <summary>
        /// The name of the endpoint service that is associated with the endpoint.
        /// </summary>
        [NameInMap("Payer")]
        [Validation(Required=false)]
        public string Payer { get; set; }

        /// <summary>
        /// The number of private IP addresses that can be used by an elastic network interface (ENI) in each zone. The value is set to **1**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The type of the endpoint.
        /// 
        /// The value is set to **Interface**, which indicates that the resource type of **ServiceId** is Classic Load Balancer (CLB).
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Queries the details about a specified endpoint.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The region ID of the endpoint.
        /// </summary>
        [NameInMap("ResourceOwner")]
        [Validation(Required=false)]
        public bool? ResourceOwner { get; set; }

        /// <summary>
        /// Indicates whether zone affinity is enabled. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// The status of the endpoint connection. Valid values:
        /// 
        /// *   **Pending**: being modified
        /// *   **Connecting**: connecting
        /// *   **Connected**: connected
        /// *   **Disconnecting**: disconnecting
        /// *   **Disconnected**: disconnected
        /// *   **Deleting**: being deleted
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// The domain name of the endpoint.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("ZoneAffinityEnabled")]
        [Validation(Required=false)]
        public bool? ZoneAffinityEnabled { get; set; }

        /// <summary>
        /// The region ID of the endpoint.
        /// 
        /// You can call the [DescribeRegions](~~120468~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("ZonePrivateIpAddressCount")]
        [Validation(Required=false)]
        public long? ZonePrivateIpAddressCount { get; set; }

    }

}
