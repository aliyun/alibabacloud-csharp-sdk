// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class GetVpcEndpointAttributeResponseBody : TeaModel {
        /// <summary>
        /// The bandwidth of the endpoint connection. Unit: Mbit/s.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// The state of the endpoint connection. Valid values:
        /// 
        /// *   **Pending**: The connection is being modified.
        /// *   **Connecting**: The connection is being established.
        /// *   **Connected**: The connection is established.
        /// *   **Disconnecting**: The endpoint is being disconnected from the endpoint service.
        /// *   **Disconnected**: The endpoint is disconnected from the endpoint service.
        /// *   **Deleting**: The connection is being deleted.
        /// </summary>
        [NameInMap("ConnectionStatus")]
        [Validation(Required=false)]
        public string ConnectionStatus { get; set; }

        /// <summary>
        /// The time when the endpoint was created.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The service state of the endpoint. Valid values:
        /// 
        /// *   **Normal**: The endpoint runs as expected.
        /// *   **FinacialLocked**: The endpoint is locked due to overdue payments.
        /// </summary>
        [NameInMap("EndpointBusinessStatus")]
        [Validation(Required=false)]
        public string EndpointBusinessStatus { get; set; }

        /// <summary>
        /// The description of the endpoint.
        /// </summary>
        [NameInMap("EndpointDescription")]
        [Validation(Required=false)]
        public string EndpointDescription { get; set; }

        /// <summary>
        /// The domain name of the endpoint.
        /// </summary>
        [NameInMap("EndpointDomain")]
        [Validation(Required=false)]
        public string EndpointDomain { get; set; }

        /// <summary>
        /// The endpoint ID.
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// The name of the endpoint.
        /// </summary>
        [NameInMap("EndpointName")]
        [Validation(Required=false)]
        public string EndpointName { get; set; }

        /// <summary>
        /// The state of the endpoint. Valid values:
        /// 
        /// *   **Creating**: The endpoint is being created.
        /// *   **Active**: The endpoint is available.
        /// *   **Pending**: The endpoint is being modified.
        /// *   **Deleting**: The endpoint is being deleted.
        /// </summary>
        [NameInMap("EndpointStatus")]
        [Validation(Required=false)]
        public string EndpointStatus { get; set; }

        /// <summary>
        /// The type of the endpoint.
        /// 
        /// **Interface** is returned. The value indicates the interface endpoint with which the Classic Load Balancer (CLB) instances are associated.
        /// </summary>
        [NameInMap("EndpointType")]
        [Validation(Required=false)]
        public string EndpointType { get; set; }

        /// <summary>
        /// The payer. Valid values:
        /// 
        /// *   **Endpoint**: the service consumer.
        /// *   **EndpointService**: the service provider.
        /// </summary>
        [NameInMap("Payer")]
        [Validation(Required=false)]
        public string Payer { get; set; }

        /// <summary>
        /// The region ID of the endpoint.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The resource group ID.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// Indicates whether the endpoint and the endpoint service belong to the same Alibaba Cloud account. Valid values:
        /// 
        /// *   **true**: The endpoint and the endpoint service belong to the same Alibaba Cloud account.
        /// *   **false**: The endpoint and the endpoint service do not belong to the same Alibaba Cloud account.
        /// </summary>
        [NameInMap("ResourceOwner")]
        [Validation(Required=false)]
        public bool? ResourceOwner { get; set; }

        /// <summary>
        /// The ID of the endpoint service with which the endpoint is associated.
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// The name of the endpoint service with which the endpoint is associated.
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) to which the endpoint belongs.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// Indicates whether zone affinity is enabled. Valid values:
        /// 
        /// *   **true**: Zone affinity is enabled.
        /// *   **false**: Zone affinity is disabled.
        /// </summary>
        [NameInMap("ZoneAffinityEnabled")]
        [Validation(Required=false)]
        public bool? ZoneAffinityEnabled { get; set; }

        /// <summary>
        /// The number of private IP addresses that are assigned to an elastic network interface (ENI) in each zone. Only **1** is returned.
        /// </summary>
        [NameInMap("ZonePrivateIpAddressCount")]
        [Validation(Required=false)]
        public long? ZonePrivateIpAddressCount { get; set; }

    }

}
