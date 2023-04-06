// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeCustomRoutingEndPointTrafficPolicyResponseBody : TeaModel {
        /// <summary>
        /// The ID of the GA instance with which the endpoint is associated.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The IP address of the traffic destination.
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// The name of the vSwitch to which the traffic destination belongs.
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
        /// The ID of the endpoint to which the traffic destination belongs.
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
        /// The ID of the traffic destination.
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// The port range of the traffic destination.
        /// </summary>
        [NameInMap("PortRanges")]
        [Validation(Required=false)]
        public List<DescribeCustomRoutingEndPointTrafficPolicyResponseBodyPortRanges> PortRanges { get; set; }
        public class DescribeCustomRoutingEndPointTrafficPolicyResponseBodyPortRanges : TeaModel {
            /// <summary>
            /// The first port of the port range used by the traffic destination to process requests.
            /// </summary>
            [NameInMap("FromPort")]
            [Validation(Required=false)]
            public int? FromPort { get; set; }

            /// <summary>
            /// The last port of the port range used by the traffic destination to process requests.
            /// </summary>
            [NameInMap("ToPort")]
            [Validation(Required=false)]
            public int? ToPort { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the traffic destination.
        /// 
        /// *   **init**: being initialized.
        /// *   **active**: running as expected.
        /// *   **updating**: being updated.
        /// *   **deleting**: being deleted.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
