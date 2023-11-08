// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshProxyStatusResponseBody : TeaModel {
        /// <summary>
        /// The status code. Valid values:
        /// 
        /// `200`: The operation is successful.
        /// 
        /// *   `403`: You are not authorized to perform this operation.
        /// *   `503`: A backend server error occurs.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The information about the status of the proxies on the data plane.
        /// </summary>
        [NameInMap("ProxyStatus")]
        [Validation(Required=false)]
        public List<DescribeServiceMeshProxyStatusResponseBodyProxyStatus> ProxyStatus { get; set; }
        public class DescribeServiceMeshProxyStatusResponseBodyProxyStatus : TeaModel {
            /// <summary>
            /// The update status of the proxy. Valid values:
            /// 
            /// *   `SYNCED`: The status of the proxy is updated.
            /// *   `NOT SENT`: The status of the proxy is not updated.
            /// *   `STALE (Never Acknowledged)`: Istiod has sent multiple requests to the Envoy proxy to update the status of the proxy but receives no response.
            /// *   `STALE`: Istiod has sent a request to the Envoy proxy to update the status of the proxy but receives no response.
            /// </summary>
            [NameInMap("ClusterSynced")]
            [Validation(Required=false)]
            public string ClusterSynced { get; set; }

            /// <summary>
            /// The percentage of the updated endpoints.
            /// </summary>
            [NameInMap("EndpointPercent")]
            [Validation(Required=false)]
            public string EndpointPercent { get; set; }

            /// <summary>
            /// The update status of the endpoint. Valid values:
            /// 
            /// *   `SYNCED`: The status of the endpoint is updated.
            /// *   `NOT SENT`: The status of the endpoint is not updated.
            /// *   `STALE (Never Acknowledged)`: Istiod has sent multiple requests to the Envoy proxy to update the status of the endpoint but receives no response.
            /// *   `STALE`: Istiod has sent a request to the Envoy proxy to update the status of the endpoint but receives no response.
            /// </summary>
            [NameInMap("EndpointSynced")]
            [Validation(Required=false)]
            public string EndpointSynced { get; set; }

            /// <summary>
            /// The version of Istiod.
            /// </summary>
            [NameInMap("IstioVersion")]
            [Validation(Required=false)]
            public string IstioVersion { get; set; }

            /// <summary>
            /// The update status of the listener. Valid values:
            /// 
            /// *   `SYNCED`: The status of the listener is updated.
            /// *   `NOT SENT`: The status of the listener is not updated.
            /// *   `STALE (Never Acknowledged)`: Istiod has sent multiple requests to the Envoy proxy to update the status of the listener but receives no response.
            /// *   `STALE`: Istiod has sent a request to the Envoy proxy to update the status of the listener but receives no response.
            /// </summary>
            [NameInMap("ListenerSynced")]
            [Validation(Required=false)]
            public string ListenerSynced { get; set; }

            /// <summary>
            /// The ID of the proxy on the data plane.
            /// </summary>
            [NameInMap("ProxyId")]
            [Validation(Required=false)]
            public string ProxyId { get; set; }

            /// <summary>
            /// The version number of a proxy on the data plane.
            /// </summary>
            [NameInMap("ProxyVersion")]
            [Validation(Required=false)]
            public string ProxyVersion { get; set; }

            /// <summary>
            /// The update status of the route. Valid values:
            /// 
            /// *   `SYNCED`: The status of the route is updated.
            /// *   `NOT SENT`: The status of the route is not updated.
            /// *   `STALE (Never Acknowledged)`: Istiod has sent multiple requests to the Envoy proxy to update the status of the route but receives no response.
            /// *   `STALE`: Istiod has sent a request to the Envoy proxy to update the status of the route but receives no response.
            /// </summary>
            [NameInMap("RouteSynced")]
            [Validation(Required=false)]
            public string RouteSynced { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
