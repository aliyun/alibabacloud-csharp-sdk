// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListListenersResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the listeners.</para>
        /// </summary>
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public List<ListListenersResponseBodyListeners> Listeners { get; set; }
        public class ListListenersResponseBodyListeners : TeaModel {
            /// <summary>
            /// <para>The ID of the GA instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ga-bp1odcab8tmno0hdq****</para>
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            /// <summary>
            /// <para>The range of ports that are used by backend servers.</para>
            /// </summary>
            [NameInMap("BackendPorts")]
            [Validation(Required=false)]
            public List<ListListenersResponseBodyListenersBackendPorts> BackendPorts { get; set; }
            public class ListListenersResponseBodyListenersBackendPorts : TeaModel {
                /// <summary>
                /// <para>The first port in the range of ports that are used by backend servers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("FromPort")]
                [Validation(Required=false)]
                public string FromPort { get; set; }

                /// <summary>
                /// <para>The last port in the range of ports that are used by backend servers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("ToPort")]
                [Validation(Required=false)]
                public string ToPort { get; set; }

            }

            /// <summary>
            /// <para>The information about the SSL certificates.</para>
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
                /// <para>The type of the SSL certificate.</para>
                /// <para>Only <b>Server</b> may be returned, which indicates a server certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Server</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether client affinity is enabled for the listener.</para>
            /// <list type="bullet">
            /// <item><description>If <b>NONE</b> is returned, client affinity is disabled. When client affinity is disabled, requests from the same client may be forwarded to different endpoints.</description></item>
            /// <item><description>If <b>SOURCE_IP</b> is returned, client affinity is enabled. When a client accesses stateful applications, requests from the same client are forwarded to the same endpoint regardless of the source port or protocol.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SOURCE_IP</para>
            /// </summary>
            [NameInMap("ClientAffinity")]
            [Validation(Required=false)]
            public string ClientAffinity { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates when the listener was created. Unit: milliseconds.</para>
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
            /// <item><description><b>http3</b></description></item>
            /// <item><description><b>http2</b></description></item>
            /// <item><description><b>http1.1</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is returned only for HTTPS listeners.</para>
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
            /// <para>The information about the listener ports.</para>
            /// </summary>
            [NameInMap("PortRanges")]
            [Validation(Required=false)]
            public List<ListListenersResponseBodyListenersPortRanges> PortRanges { get; set; }
            public class ListListenersResponseBodyListenersPortRanges : TeaModel {
                /// <summary>
                /// <para>The first port in the listener port range that is used to receive and forward requests to endpoints.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("FromPort")]
                [Validation(Required=false)]
                public int? FromPort { get; set; }

                /// <summary>
                /// <para>The last port in the listener port range that is used to receive and forward requests to endpoints.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("ToPort")]
                [Validation(Required=false)]
                public int? ToPort { get; set; }

            }

            /// <summary>
            /// <para>The network transmission protocol that is used by the listener. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>tcp</b></description></item>
            /// <item><description><b>udp</b></description></item>
            /// <item><description><b>http</b></description></item>
            /// <item><description><b>https</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>Indicates whether client IP address preservation is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Client IP address preservation is enabled. This feature allows you to view client IP addresses on backend servers.</description></item>
            /// <item><description><b>false</b>: Client IP address preservation is disabled.</description></item>
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
            /// <para>The timeout period of HTTP or HTTPS requests. Unit: seconds.</para>
            /// <remarks>
            /// <para> This parameter is returned only for HTTP and HTTPS listeners. If no responses are received from the backend server within the timeout period, GA returns an HTTP 504 error code to the client.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("RequestTimeout")]
            [Validation(Required=false)]
            public int? RequestTimeout { get; set; }

            /// <summary>
            /// <para>The ID of the security policy.</para>
            /// <list type="bullet">
            /// <item><description><para><b>tls_cipher_policy_1_0</b></para>
            /// <list type="bullet">
            /// <item><description>Supported Transport Layer Security (TLS) versions: TLS 1.0, TLS 1.1, and TLS 1.2.</description></item>
            /// <item><description>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>tls_cipher_policy_1_1</b></para>
            /// <list type="bullet">
            /// <item><description>Supported TLS versions: TLS 1.1 and TLS 1.2.</description></item>
            /// <item><description>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>tls_cipher_policy_1_2</b></para>
            /// <list type="bullet">
            /// <item><description>Supported TLS version: TLS 1.2.</description></item>
            /// <item><description>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>tls_cipher_policy_1_2_strict</b></para>
            /// <list type="bullet">
            /// <item><description>Supported TLS version: TLS 1.2.</description></item>
            /// <item><description>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>tls_cipher_policy_1_2_strict_with_1_3</b></para>
            /// <list type="bullet">
            /// <item><description>Supported TLS versions: TLS 1.2 and TLS 1.3.</description></item>
            /// <item><description>Supported cipher suites: TLS_AES_128_GCM_SHA256, TLS_AES_256_GCM_SHA384, TLS_CHACHA20_POLY1305_SHA256, TLS_AES_128_CCM_SHA256, TLS_AES_128_CCM_8_SHA256, ECDHE-ECDSA-AES128-GCM-SHA256, ECDHE-ECDSA-AES256-GCM-SHA384, ECDHE-ECDSA-AES128-SHA256, ECDHE-ECDSA-AES256-SHA384, ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-ECDSA-AES128-SHA, ECDHE-ECDSA-AES256-SHA, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is returned only for HTTPS listeners.</para>
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
            /// <para> This parameter is returned only if the value of <b>ServiceManaged</b> is <b>true</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ALB</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance is managed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ServiceManaged")]
            [Validation(Required=false)]
            public bool? ServiceManaged { get; set; }

            /// <summary>
            /// <para>The actions that users can perform on the managed instance.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is returned only if the value of <b>ServiceManaged</b> is <b>true</b>.</description></item>
            /// <item><description>Users can perform only specific actions on a managed instance.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ServiceManagedInfos")]
            [Validation(Required=false)]
            public List<ListListenersResponseBodyListenersServiceManagedInfos> ServiceManagedInfos { get; set; }
            public class ListListenersResponseBodyListenersServiceManagedInfos : TeaModel {
                /// <summary>
                /// <para>The name of the action on the managed instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Create</b></description></item>
                /// <item><description><b>Update</b></description></item>
                /// <item><description><b>Delete</b></description></item>
                /// <item><description><b>Associate</b></description></item>
                /// <item><description><b>UserUnmanaged</b></description></item>
                /// <item><description><b>CreateChild</b></description></item>
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
                /// <item><description><b>Listener</b>: listener.</description></item>
                /// <item><description><b>IpSet</b>: acceleration region.</description></item>
                /// <item><description><b>EndpointGroup</b>: endpoint group.</description></item>
                /// <item><description><b>ForwardingRule</b>: forwarding rule.</description></item>
                /// <item><description><b>Endpoint</b>: endpoint.</description></item>
                /// <item><description><b>EndpointGroupDestination</b>: protocol mapping of an endpoint group associated with a custom routing listener.</description></item>
                /// <item><description><b>EndpointPolicy</b>: traffic policy of an endpoint associated with a custom routing listener.</description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter takes effect only if the value of <b>Action</b> is <b>CreateChild</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Listener</para>
                /// </summary>
                [NameInMap("ChildType")]
                [Validation(Required=false)]
                public string ChildType { get; set; }

                /// <summary>
                /// <para>Indicates whether the specified actions are managed.</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The specified actions are managed, and users cannot perform the specified actions on the managed instance.</description></item>
                /// <item><description><b>false</b>: The specified actions are not managed, and users can perform the specified actions on the managed instance.</description></item>
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
            /// <para>The status of the listener. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>active</b></description></item>
            /// <item><description><b>init</b></description></item>
            /// <item><description><b>updating</b></description></item>
            /// <item><description><b>deleting</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The routing type of the listener. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Standard</b>: intelligent routing.</description></item>
            /// <item><description><b>CustomRouting</b>: custom routing.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The configurations of the <c>XForward</c> headers.</para>
            /// </summary>
            [NameInMap("XForwardedForConfig")]
            [Validation(Required=false)]
            public ListListenersResponseBodyListenersXForwardedForConfig XForwardedForConfig { get; set; }
            public class ListListenersResponseBodyListenersXForwardedForConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether the <c>GA-AP</c> header is used to retrieve the information about acceleration regions. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter is returned only for HTTP and HTTPS listeners.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("XForwardedForGaApEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForGaApEnabled { get; set; }

                /// <summary>
                /// <para>Indicates whether the <c>GA-ID</c> header is used to retrieve the ID of the GA instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter is returned only for HTTP and HTTPS listeners.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("XForwardedForGaIdEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForGaIdEnabled { get; set; }

                /// <summary>
                /// <para>Indicates whether the <c>GA-X-Forward-Port</c> header is used to retrieve the listener ports of the GA instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter is returned only for HTTP and HTTPS listeners.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("XForwardedForPortEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForPortEnabled { get; set; }

                /// <summary>
                /// <para>Indicates whether the <c>GA-X-Forward-Proto</c> header is used to retrieve the listener protocol of the GA instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter is returned only for HTTP and HTTPS listeners.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("XForwardedForProtoEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForProtoEnabled { get; set; }

                /// <summary>
                /// <para>Indicates whether the <c>X-Real-IP</c> header is used to retrieve client IP addresses. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter is returned only for HTTP and HTTPS listeners.</para>
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
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
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
