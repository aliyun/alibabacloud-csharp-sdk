// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListListenersResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the listeners.</para>
        /// </summary>
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public List<ListListenersResponseBodyListeners> Listeners { get; set; }
        public class ListListenersResponseBodyListeners : TeaModel {
            /// <summary>
            /// <para>The ID of the Global Accelerator instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ga-bp1odcab8tmno0hdq****</para>
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            /// <summary>
            /// <para>The port mapping of the backend server.</para>
            /// </summary>
            [NameInMap("BackendPorts")]
            [Validation(Required=false)]
            public List<ListListenersResponseBodyListenersBackendPorts> BackendPorts { get; set; }
            public class ListListenersResponseBodyListenersBackendPorts : TeaModel {
                /// <summary>
                /// <para>The start port of the backend server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("FromPort")]
                [Validation(Required=false)]
                public string FromPort { get; set; }

                /// <summary>
                /// <para>The end port of the backend server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("ToPort")]
                [Validation(Required=false)]
                public string ToPort { get; set; }

            }

            /// <summary>
            /// <para>The details of the SSL certificate.</para>
            /// </summary>
            [NameInMap("Certificates")]
            [Validation(Required=false)]
            public List<ListListenersResponseBodyListenersCertificates> Certificates { get; set; }
            public class ListListenersResponseBodyListenersCertificates : TeaModel {
                /// <summary>
                /// <para>The ID of the SSL certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>44983xxxx-cn-hangzhou</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The type of the certificate.</para>
                /// <para>Only <b>Server</b>, which indicates a server-side certificate, is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Server</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Client affinity.</para>
            /// <list type="bullet">
            /// <item><description><para><b>NONE</b>: Client affinity is disabled. Requests from the same client are not always routed to the same endpoint.</para>
            /// </description></item>
            /// <item><description><para><b>SOURCE_IP</b>: Client affinity is enabled. When a client accesses a stateful application, all requests from the same client are routed to the same endpoint regardless of the source port or protocol.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SOURCE_IP</para>
            /// </summary>
            [NameInMap("ClientAffinity")]
            [Validation(Required=false)]
            public string ClientAffinity { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp that indicates when the listener was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1577786252000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the listener.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Listener</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The maximum version of the HTTP protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>http3</b>: HTTP/3.</para>
            /// </description></item>
            /// <item><description><para><b>http2</b>: HTTP/2.</para>
            /// </description></item>
            /// <item><description><para><b>http1.1</b>: HTTP/1.1.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is available only for HTTPS listeners.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>http2</para>
            /// </summary>
            [NameInMap("HttpVersion")]
            [Validation(Required=false)]
            public string HttpVersion { get; set; }

            /// <summary>
            /// <para>The timeout period of idle connections. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>900</para>
            /// </summary>
            [NameInMap("IdleTimeout")]
            [Validation(Required=false)]
            public int? IdleTimeout { get; set; }

            /// <summary>
            /// <para>The ID of the listener.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lsr-bp1bpn0kn908w4nbw****</para>
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// <para>The name of the listener.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Listener</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The listener port range.</para>
            /// </summary>
            [NameInMap("PortRanges")]
            [Validation(Required=false)]
            public List<ListListenersResponseBodyListenersPortRanges> PortRanges { get; set; }
            public class ListListenersResponseBodyListenersPortRanges : TeaModel {
                /// <summary>
                /// <para>The start port used to receive and forward requests to endpoints.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("FromPort")]
                [Validation(Required=false)]
                public int? FromPort { get; set; }

                /// <summary>
                /// <para>The end port used to receive and forward requests to endpoints.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("ToPort")]
                [Validation(Required=false)]
                public int? ToPort { get; set; }

            }

            /// <summary>
            /// <para>The transport layer protocol used by the listener.</para>
            /// <list type="bullet">
            /// <item><description><para><b>TCP</b>: TCP.</para>
            /// </description></item>
            /// <item><description><para><b>UDP</b>: UDP.</para>
            /// </description></item>
            /// <item><description><para><b>HTTP</b>: HTTP.</para>
            /// </description></item>
            /// <item><description><para><b>HTTPS</b>: HTTPS.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>Indicates whether the proxy protocol is used to preserve client IP addresses.</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The proxy protocol is used to preserve client IP addresses. After you enable the proxy protocol, you can retrieve the source IP addresses of clients from the backend servers.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The proxy protocol is not used to preserve client IP addresses.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ProxyProtocol")]
            [Validation(Required=false)]
            [Obsolete]
            public bool? ProxyProtocol { get; set; }

            /// <summary>
            /// <para>The timeout period for HTTP or HTTPS requests. Unit: seconds.</para>
            /// <remarks>
            /// <para>This parameter is available only for HTTP and HTTPS listeners. If a backend server does not respond within the timeout period, Global Accelerator returns an HTTP 504 error to the client.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("RequestTimeout")]
            [Validation(Required=false)]
            public int? RequestTimeout { get; set; }

            /// <summary>
            /// <para>The ID of the security policy instance.</para>
            /// <list type="bullet">
            /// <item><description><para><b>tls_cipher_policy_1_0</b></para>
            /// <list type="bullet">
            /// <item><description><para>Supported TLS versions: TLSv1.0, TLSv1.1, and TLSv1.2.</para>
            /// </description></item>
            /// <item><description><para>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>tls_cipher_policy_1_1</b></para>
            /// <list type="bullet">
            /// <item><description><para>Supported TLS versions: TLSv1.1 and TLSv1.2.</para>
            /// </description></item>
            /// <item><description><para>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>tls_cipher_policy_1_2</b></para>
            /// <list type="bullet">
            /// <item><description><para>Supported TLS version: TLSv1.2.</para>
            /// </description></item>
            /// <item><description><para>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>tls_cipher_policy_1_2_strict</b></para>
            /// <list type="bullet">
            /// <item><description><para>Supported TLS version: TLSv1.2.</para>
            /// </description></item>
            /// <item><description><para>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>tls_cipher_policy_1_2_strict_with_1_3</b></para>
            /// <list type="bullet">
            /// <item><description><para>Supported TLS versions: TLSv1.2 and TLSv1.3.</para>
            /// </description></item>
            /// <item><description><para>Supported cipher suites: TLS_AES_128_GCM_SHA256, TLS_AES_256_GCM_SHA384, TLS_CHACHA20_POLY1305_SHA256, TLS_AES_128_CCM_SHA256, TLS_AES_128_CCM_8_SHA256, ECDHE-ECDSA-AES128-GCM-SHA256, ECDHE-ECDSA-AES256-GCM-SHA384, ECDHE-ECDSA-AES128-SHA256, ECDHE-ECDSA-AES256-SHA384, ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-ECDSA-AES128-SHA, ECDHE-ECDSA-AES256-SHA, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is available only for HTTPS listeners.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>tls_cipher_policy_1_0</para>
            /// </summary>
            [NameInMap("SecurityPolicyId")]
            [Validation(Required=false)]
            public string SecurityPolicyId { get; set; }

            /// <summary>
            /// <para>The ID of the service that manages the instance.</para>
            /// <remarks>
            /// <para>This parameter is returned only if <b>ServiceManaged</b> is set to <b>True</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ALB</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance is a managed instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The instance is a managed instance.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The instance is not a managed instance.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ServiceManaged")]
            [Validation(Required=false)]
            public bool? ServiceManaged { get; set; }

            /// <summary>
            /// <para>The actions that you can perform on the managed instance.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>This parameter is returned only if <b>ServiceManaged</b> is set to <b>True</b>.</para>
            /// </description></item>
            /// <item><description><para>When an instance is managed, you cannot perform some operations on the instance.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ServiceManagedInfos")]
            [Validation(Required=false)]
            public List<ListListenersResponseBodyListenersServiceManagedInfos> ServiceManagedInfos { get; set; }
            public class ListListenersResponseBodyListenersServiceManagedInfos : TeaModel {
                /// <summary>
                /// <para>The name of the managed policy action. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Create</b>: Create an instance.</para>
                /// </description></item>
                /// <item><description><para><b>Update</b>: Update the current instance.</para>
                /// </description></item>
                /// <item><description><para><b>Delete</b>: Delete the current instance.</para>
                /// </description></item>
                /// <item><description><para><b>Associate</b>: Associate the instance with other resources.</para>
                /// </description></item>
                /// <item><description><para><b>UserUnmanaged</b>: Unmanage the instance.</para>
                /// </description></item>
                /// <item><description><para><b>CreateChild</b>: Create a child resource in the current instance.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Update</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The type of the child resource. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Listener</b>: listener.</para>
                /// </description></item>
                /// <item><description><para><b>IpSet</b>: acceleration region.</para>
                /// </description></item>
                /// <item><description><para><b>EndpointGroup</b>: endpoint group.</para>
                /// </description></item>
                /// <item><description><para><b>ForwardingRule</b>: forwarding rule.</para>
                /// </description></item>
                /// <item><description><para><b>Endpoint</b>: endpoint.</para>
                /// </description></item>
                /// <item><description><para><b>EndpointGroupDestination</b>: protocol mapping of an endpoint group that is associated with a custom routing listener.</para>
                /// </description></item>
                /// <item><description><para><b>EndpointPolicy</b>: traffic policy for an endpoint that is associated with a custom routing listener.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter is returned only if the value of <b>Action</b> is <b>CreateChild</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Listener</para>
                /// </summary>
                [NameInMap("ChildType")]
                [Validation(Required=false)]
                public string ChildType { get; set; }

                /// <summary>
                /// <para>Indicates whether the specified action is managed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: The action is managed. You cannot perform the specified action on the managed instance.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: The action is not managed. You can perform the specified action on the managed instance.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsManaged")]
                [Validation(Required=false)]
                public bool? IsManaged { get; set; }

            }

            /// <summary>
            /// <para>The status of the listener.</para>
            /// <list type="bullet">
            /// <item><description><para><b>active</b>: The listener is running.</para>
            /// </description></item>
            /// <item><description><para><b>init</b>: The listener is being initialized.</para>
            /// </description></item>
            /// <item><description><para><b>updating</b>: The listener is being updated.</para>
            /// </description></item>
            /// <item><description><para><b>deleting</b>: The listener is being deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The routing type of the listener.</para>
            /// <list type="bullet">
            /// <item><description><para><b>Standard</b>: smart routing.</para>
            /// </description></item>
            /// <item><description><para><b>CustomRouting</b>: custom routing.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The configuration of the <c>XForward</c> fields.</para>
            /// </summary>
            [NameInMap("XForwardedForConfig")]
            [Validation(Required=false)]
            public ListListenersResponseBodyListenersXForwardedForConfig XForwardedForConfig { get; set; }
            public class ListListenersResponseBodyListenersXForwardedForConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether the <c>GA-AP</c> header is used to retrieve the acceleration region information.</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b></para>
                /// </description></item>
                /// <item><description><para><b>false</b></para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter is available only for HTTP and HTTPS listeners.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("XForwardedForGaApEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForGaApEnabled { get; set; }

                /// <summary>
                /// <para>Indicates whether the <c>GA-ID</c> header is used to retrieve the ID of the GA instance.</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b></para>
                /// </description></item>
                /// <item><description><para><b>false</b></para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter is available only for HTTP and HTTPS listeners.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("XForwardedForGaIdEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForGaIdEnabled { get; set; }

                /// <summary>
                /// <para>Indicates whether the <c>GA-X-Forward-Port</c> header is used to retrieve the listener port of the GA instance.</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b></para>
                /// </description></item>
                /// <item><description><para><b>false</b></para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter is available only for HTTP and HTTPS listeners.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("XForwardedForPortEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForPortEnabled { get; set; }

                /// <summary>
                /// <para>Indicates whether the <c>GA-X-Forward-Proto</c> header is used to retrieve the listener protocol of the GA instance.</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b></para>
                /// </description></item>
                /// <item><description><para><b>false</b></para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter is available only for HTTP and HTTPS listeners.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("XForwardedForProtoEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForProtoEnabled { get; set; }

                /// <summary>
                /// <para>Indicates whether the <c>X-Real-IP</c> header is used to retrieve the real IP address of the client.</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b></para>
                /// </description></item>
                /// <item><description><para><b>false</b></para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter is available only for HTTP and HTTPS listeners.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("XRealIpEnabled")]
                [Validation(Required=false)]
                public bool? XRealIpEnabled { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6FEA0CF3-D3B9-43E5-A304-D217037876A8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
