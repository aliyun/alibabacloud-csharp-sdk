// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshProxyStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. Valid values:</para>
        /// <para><c>200</c>: The operation is successful.</para>
        /// <list type="bullet">
        /// <item><description><c>403</c>: You are not authorized to perform this operation.</description></item>
        /// <item><description><c>503</c>: A backend server error occurs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The information about the status of the proxies on the data plane.</para>
        /// </summary>
        [NameInMap("ProxyStatus")]
        [Validation(Required=false)]
        public List<DescribeServiceMeshProxyStatusResponseBodyProxyStatus> ProxyStatus { get; set; }
        public class DescribeServiceMeshProxyStatusResponseBodyProxyStatus : TeaModel {
            /// <summary>
            /// <para>The update status of the proxy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>SYNCED</c>: The status of the proxy is updated.</description></item>
            /// <item><description><c>NOT SENT</c>: The status of the proxy is not updated.</description></item>
            /// <item><description><c>STALE (Never Acknowledged)</c>: Istiod has sent multiple requests to the Envoy proxy to update the status of the proxy but receives no response.</description></item>
            /// <item><description><c>STALE</c>: Istiod has sent a request to the Envoy proxy to update the status of the proxy but receives no response.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SYNCED</para>
            /// </summary>
            [NameInMap("ClusterSynced")]
            [Validation(Required=false)]
            public string ClusterSynced { get; set; }

            /// <summary>
            /// <para>The percentage of the updated endpoints.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EndpointPercent")]
            [Validation(Required=false)]
            public string EndpointPercent { get; set; }

            /// <summary>
            /// <para>The update status of the endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>SYNCED</c>: The status of the endpoint is updated.</description></item>
            /// <item><description><c>NOT SENT</c>: The status of the endpoint is not updated.</description></item>
            /// <item><description><c>STALE (Never Acknowledged)</c>: Istiod has sent multiple requests to the Envoy proxy to update the status of the endpoint but receives no response.</description></item>
            /// <item><description><c>STALE</c>: Istiod has sent a request to the Envoy proxy to update the status of the endpoint but receives no response.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SYNCED</para>
            /// </summary>
            [NameInMap("EndpointSynced")]
            [Validation(Required=false)]
            public string EndpointSynced { get; set; }

            /// <summary>
            /// <para>The version of Istiod.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.9.7</para>
            /// </summary>
            [NameInMap("IstioVersion")]
            [Validation(Required=false)]
            public string IstioVersion { get; set; }

            /// <summary>
            /// <para>The update status of the listener. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>SYNCED</c>: The status of the listener is updated.</description></item>
            /// <item><description><c>NOT SENT</c>: The status of the listener is not updated.</description></item>
            /// <item><description><c>STALE (Never Acknowledged)</c>: Istiod has sent multiple requests to the Envoy proxy to update the status of the listener but receives no response.</description></item>
            /// <item><description><c>STALE</c>: Istiod has sent a request to the Envoy proxy to update the status of the listener but receives no response.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SYNCED</para>
            /// </summary>
            [NameInMap("ListenerSynced")]
            [Validation(Required=false)]
            public string ListenerSynced { get; set; }

            /// <summary>
            /// <para>The ID of the proxy on the data plane.</para>
            /// 
            /// <b>Example:</b>
            /// <para>119q****</para>
            /// </summary>
            [NameInMap("ProxyId")]
            [Validation(Required=false)]
            public string ProxyId { get; set; }

            /// <summary>
            /// <para>The version number of a proxy on the data plane.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.9.7</para>
            /// </summary>
            [NameInMap("ProxyVersion")]
            [Validation(Required=false)]
            public string ProxyVersion { get; set; }

            /// <summary>
            /// <para>The update status of the route. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>SYNCED</c>: The status of the route is updated.</description></item>
            /// <item><description><c>NOT SENT</c>: The status of the route is not updated.</description></item>
            /// <item><description><c>STALE (Never Acknowledged)</c>: Istiod has sent multiple requests to the Envoy proxy to update the status of the route but receives no response.</description></item>
            /// <item><description><c>STALE</c>: Istiod has sent a request to the Envoy proxy to update the status of the route but receives no response.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SYNCED</para>
            /// </summary>
            [NameInMap("RouteSynced")]
            [Validation(Required=false)]
            public string RouteSynced { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31d3a0f0-07ed-4f6e-9004-1804498c****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
