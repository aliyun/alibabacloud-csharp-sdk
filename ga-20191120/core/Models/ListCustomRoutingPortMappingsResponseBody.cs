// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListCustomRoutingPortMappingsResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Details about the port mapping table.
        /// </summary>
        [NameInMap("PortMappings")]
        [Validation(Required=false)]
        public List<ListCustomRoutingPortMappingsResponseBodyPortMappings> PortMappings { get; set; }
        public class ListCustomRoutingPortMappingsResponseBodyPortMappings : TeaModel {
            /// <summary>
            /// The ID of the GA instance.
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            /// <summary>
            /// The acceleration port.
            /// </summary>
            [NameInMap("AcceleratorPort")]
            [Validation(Required=false)]
            public int? AcceleratorPort { get; set; }

            /// <summary>
            /// The service IP address and port of the backend instance.
            /// </summary>
            [NameInMap("DestinationSocketAddress")]
            [Validation(Required=false)]
            public ListCustomRoutingPortMappingsResponseBodyPortMappingsDestinationSocketAddress DestinationSocketAddress { get; set; }
            public class ListCustomRoutingPortMappingsResponseBodyPortMappingsDestinationSocketAddress : TeaModel {
                /// <summary>
                /// The service IP address of the backend instance.
                /// </summary>
                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                /// <summary>
                /// The service port of the backend instance.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

            }

            /// <summary>
            /// The access policy of traffic for the backend instance. Valid values:
            /// 
            /// *   **allow**: allows traffic to the backend instance.
            /// *   **deny**: denies traffic to the backend instance.
            /// </summary>
            [NameInMap("DestinationTrafficState")]
            [Validation(Required=false)]
            public string DestinationTrafficState { get; set; }

            /// <summary>
            /// The ID of the endpoint group.
            /// </summary>
            [NameInMap("EndpointGroupId")]
            [Validation(Required=false)]
            public string EndpointGroupId { get; set; }

            /// <summary>
            /// The ID of the region in which the endpoint group resides.
            /// </summary>
            [NameInMap("EndpointGroupRegion")]
            [Validation(Required=false)]
            public string EndpointGroupRegion { get; set; }

            /// <summary>
            /// The ID of the endpoint.
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// The ID of the listener.
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// The protocol of the backend service.
            /// 
            /// *   **tcp**: TCP
            /// *   **udp**: UDP
            /// </summary>
            [NameInMap("Protocols")]
            [Validation(Required=false)]
            public List<string> Protocols { get; set; }

            /// <summary>
            /// The name of the endpoint (vSwitch).
            /// </summary>
            [NameInMap("Vswitch")]
            [Validation(Required=false)]
            public string Vswitch { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
