// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeCustomRoutingEndpointGroupDestinationsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the GA instance.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The ID of the endpoint group mapping configuration.
        /// </summary>
        [NameInMap("DestinationId")]
        [Validation(Required=false)]
        public string DestinationId { get; set; }

        /// <summary>
        /// The ID of the endpoint group.
        /// </summary>
        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        /// <summary>
        /// The start port of the backend service port range of the endpoint group.
        /// </summary>
        [NameInMap("FromPort")]
        [Validation(Required=false)]
        public int? FromPort { get; set; }

        /// <summary>
        /// The ID of the listener.
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// The backend service protocol of the endpoint group.
        /// 
        /// *   **tcp**: TCP
        /// *   **udp**: UDP
        /// *   **tcp,udp**: TCP and UDP
        /// </summary>
        [NameInMap("Protocols")]
        [Validation(Required=false)]
        public List<string> Protocols { get; set; }

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
        /// The end port of the backend service port range of the endpoint group.
        /// </summary>
        [NameInMap("ToPort")]
        [Validation(Required=false)]
        public int? ToPort { get; set; }

    }

}
