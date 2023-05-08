// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetRegisteredServiceEndpointsResponseBody : TeaModel {
        /// <summary>
        /// The name of the registered service.
        /// </summary>
        [NameInMap("EndPointSlice")]
        [Validation(Required=false)]
        public GetRegisteredServiceEndpointsResponseBodyEndPointSlice EndPointSlice { get; set; }
        public class GetRegisteredServiceEndpointsResponseBodyEndPointSlice : TeaModel {
            /// <summary>
            /// The name of the pod.
            /// </summary>
            [NameInMap("EndpointsDetails")]
            [Validation(Required=false)]
            public List<GetRegisteredServiceEndpointsResponseBodyEndPointSliceEndpointsDetails> EndpointsDetails { get; set; }
            public class GetRegisteredServiceEndpointsResponseBodyEndPointSliceEndpointsDetails : TeaModel {
                /// <summary>
                /// The port of the registered service.
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// The ID of the region in which the registered service resides.
                /// </summary>
                [NameInMap("Hostname")]
                [Validation(Required=false)]
                public string Hostname { get; set; }

                /// <summary>
                /// The IP address of the registered service.
                /// </summary>
                [NameInMap("PodName")]
                [Validation(Required=false)]
                public string PodName { get; set; }

                /// <summary>
                /// The host name of the registered service.
                /// </summary>
                [NameInMap("Ports")]
                [Validation(Required=false)]
                public List<int?> Ports { get; set; }

                /// <summary>
                /// Indicates whether sidecar proxies are injected. Valid values:
                /// 
                /// *   `true`: yes
                /// *   `false`: no
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("SidecarInjected")]
                [Validation(Required=false)]
                public bool? SidecarInjected { get; set; }

            }

            /// <summary>
            /// The details of the endpoint of the registered service.
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// The location of the registered service. Valid values:
            /// 
            /// *   `MESH_INTERNAL`: The service is deployed inside the ASM instance.
            /// *   `MESH_EXTERNAL`: The service is deployed outside the ASM instance.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The name of the namespace.
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The IP address of the registered service.
        /// </summary>
        [NameInMap("ServiceEndpoints")]
        [Validation(Required=false)]
        public List<GetRegisteredServiceEndpointsResponseBodyServiceEndpoints> ServiceEndpoints { get; set; }
        public class GetRegisteredServiceEndpointsResponseBodyServiceEndpoints : TeaModel {
            /// <summary>
            /// The ID of the cluster on the data plane.
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// The details of the endpoints of the registered service.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

        }

    }

}
