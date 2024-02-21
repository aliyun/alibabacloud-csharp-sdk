// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class CreateVpcEndpointResponseBody : TeaModel {
        /// <summary>
        /// The bandwidth of the endpoint connection. Unit: Mbit/s.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public long? Bandwidth { get; set; }

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
        /// *   **FinancialLocked**: The endpoint is locked due to overdue payments.
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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
        /// The ID of the VPC to which the endpoint belongs.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
