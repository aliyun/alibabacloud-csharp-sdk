// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeCustomRoutingEndpointResponseBody : TeaModel {
        /// <summary>
        /// The ID of the GA instance with which the endpoint is associated.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The name of the endpoint (vSwitch).
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// The ID of the endpoint group to which the endpoint belongs.
        /// </summary>
        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        /// <summary>
        /// The ID of the endpoint.
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// The ID of the listener with which the endpoint is associated.
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// The access policy of traffic for the specified endpoint. Valid values:
        /// 
        /// *   **AllowAll**: allows all traffic to the endpoint.
        /// *   **DenyAll**: denies all traffic to the endpoint.
        /// *   **AllowCustom**: allows traffic only to specified destinations.
        /// </summary>
        [NameInMap("TrafficToEndpointPolicy")]
        [Validation(Required=false)]
        public string TrafficToEndpointPolicy { get; set; }

        /// <summary>
        /// The backend service type of the endpoint.
        /// 
        /// Set the value to **PrivateSubNet**, which indicates private CIDR blocks.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
