// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeListenerResponseBody : TeaModel {
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
        /// <para>The type of the ACL.</para>
        /// <list type="bullet">
        /// <item><description><para><b>white</b>: a whitelist. Only requests from the IP addresses or CIDR blocks in the ACL are forwarded. Whitelists are suitable for applications that allow access only from specific IP addresses. If you enable a whitelist but do not add an IP address to the ACL, the GA listener does not forward requests.</para>
        /// </description></item>
        /// <item><description><para><b>black</b>: a blacklist. All requests from the IP addresses or CIDR blocks in the ACL are denied. Blacklists are suitable for applications that deny access from specific IP addresses. If you enable a blacklist but do not add an IP address to the ACL, the GA listener forwards all requests.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is returned when an ACL is associated with the listener.</para>
        /// 
        /// <b>Example:</b>
        /// <para>white</para>
        /// </summary>
        [NameInMap("AclType")]
        [Validation(Required=false)]
        public string AclType { get; set; }

        /// <summary>
        /// <para>The backend port information.</para>
        /// </summary>
        [NameInMap("BackendPorts")]
        [Validation(Required=false)]
        public List<DescribeListenerResponseBodyBackendPorts> BackendPorts { get; set; }
        public class DescribeListenerResponseBodyBackendPorts : TeaModel {
            /// <summary>
            /// <para>The start port of the backend server that is used to receive requests.</para>
            /// <para>This parameter is returned only when the listener protocol is HTTPS and the listener port is the same as the service port of the backend server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("FromPort")]
            [Validation(Required=false)]
            public string FromPort { get; set; }

            /// <summary>
            /// <para>The end port of the backend server that is used to receive requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("ToPort")]
            [Validation(Required=false)]
            public string ToPort { get; set; }

        }

        /// <summary>
        /// <para>The list of SSL certificates.</para>
        /// </summary>
        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<DescribeListenerResponseBodyCertificates> Certificates { get; set; }
        public class DescribeListenerResponseBodyCertificates : TeaModel {
            /// <summary>
            /// <para>The ID of the SSL certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>449****-cn-hangzhou</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The type of the certificate.</para>
            /// <para>Only <b>Server</b> is returned, which indicates a server-side certificate.</para>
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
        /// <item><description><para>If <b>NONE</b> is returned, client affinity is disabled. In this case, requests from the same client may be forwarded to different endpoints.</para>
        /// </description></item>
        /// <item><description><para>If <b>SOURCE_IP</b> is returned, client affinity is enabled. When a client accesses a stateful application, all requests from the same client are forwarded to the same endpoint regardless of the source port or protocol.</para>
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
        /// <para>The timestamp that indicates when the listener was created. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1577786252000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

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
        /// <para>The timeout period for idle connections. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>900</para>
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// <para>The listener ID.</para>
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
        /// <para>The listener port information.</para>
        /// </summary>
        [NameInMap("PortRanges")]
        [Validation(Required=false)]
        public List<DescribeListenerResponseBodyPortRanges> PortRanges { get; set; }
        public class DescribeListenerResponseBodyPortRanges : TeaModel {
            /// <summary>
            /// <para>The start of the listener port range that is used to receive and forward requests to endpoints.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("FromPort")]
            [Validation(Required=false)]
            public int? FromPort { get; set; }

            /// <summary>
            /// <para>The end of the listener port range that is used to receive and forward requests to endpoints.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("ToPort")]
            [Validation(Required=false)]
            public int? ToPort { get; set; }

        }

        /// <summary>
        /// <para>The network transport protocol that is used by the listener.</para>
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
        /// <item><description><para><b>true</b>: The proxy protocol is used to preserve client IP addresses. After this feature is enabled, you can view the original IP addresses of clients on the backend service.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The proxy protocol is not used to preserve client IP addresses.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ProxyProtocol")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? ProxyProtocol { get; set; }

        /// <summary>
        /// <para>The access control policy groups that are associated with the listener.</para>
        /// </summary>
        [NameInMap("RelatedAcls")]
        [Validation(Required=false)]
        public List<DescribeListenerResponseBodyRelatedAcls> RelatedAcls { get; set; }
        public class DescribeListenerResponseBodyRelatedAcls : TeaModel {
            /// <summary>
            /// <para>The ID of the access control list (ACL) that is associated with the listener.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("AclId")]
            [Validation(Required=false)]
            public string AclId { get; set; }

            /// <summary>
            /// <para>Indicates whether the access control feature is enabled.</para>
            /// <list type="bullet">
            /// <item><description><b>Associated</b>: The access control feature is enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Associated</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

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
        /// <para>The timeout period for HTTP or HTTPS requests. Unit: seconds.</para>
        /// <remarks>
        /// <para>This parameter is available only for HTTP and HTTPS listeners. If a backend server does not respond within the timeout period, GA returns an HTTP 504 error to the client.</para>
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
        /// <item><description><para>Supported TLS versions: TLS 1.0, TLS 1.1, and TLS 1.2.</para>
        /// </description></item>
        /// <item><description><para>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>tls_cipher_policy_1_1</b></para>
        /// <list type="bullet">
        /// <item><description><para>Supported TLS versions: TLS 1.1 and TLS 1.2.</para>
        /// </description></item>
        /// <item><description><para>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>tls_cipher_policy_1_2</b></para>
        /// <list type="bullet">
        /// <item><description><para>Supported TLS versions: TLS 1.2.</para>
        /// </description></item>
        /// <item><description><para>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>tls_cipher_policy_1_2_strict</b></para>
        /// <list type="bullet">
        /// <item><description><para>Supported TLS versions: TLS 1.2.</para>
        /// </description></item>
        /// <item><description><para>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>tls_cipher_policy_1_2_strict_with_1_3</b></para>
        /// <list type="bullet">
        /// <item><description><para>Supported TLS versions: TLS 1.2 and TLS 1.3.</para>
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
        /// <para>This parameter is returned only when <b>ServiceManaged</b> is set to <b>True</b>.</para>
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
        /// <item><description><para>This parameter is returned only when <b>ServiceManaged</b> is set to <b>True</b>.</para>
        /// </description></item>
        /// <item><description><para>When the instance is in a managed state, you cannot perform some operations on the instance.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("ServiceManagedInfos")]
        [Validation(Required=false)]
        public List<DescribeListenerResponseBodyServiceManagedInfos> ServiceManagedInfos { get; set; }
        public class DescribeListenerResponseBodyServiceManagedInfos : TeaModel {
            /// <summary>
            /// <para>The name of the action on the managed instance. Valid values:</para>
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
            /// <item><description><para><b>CreateChild</b>: Create a child resource in the instance.</para>
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
            /// <item><description><para><b>EndpointGroupDestination</b>: protocol mapping of an endpoint group associated with a custom routing listener.</para>
            /// </description></item>
            /// <item><description><para><b>EndpointPolicy</b>: traffic policy of an endpoint associated with a custom routing listener.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is returned only when <b>Action</b> is set to <b>CreateChild</b>.</para>
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
            /// <item><description><para><b>true</b>: The specified action is managed. You cannot perform the specified action on the managed instance.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The specified action is not managed. You can perform the specified action on the managed instance.</para>
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
        /// <item><description><para><b>configuring</b>: The listener is being configured.</para>
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
        /// <item><description><para><b>Standard</b>: intelligent routing.</para>
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
        /// <para>The configurations of the <c>X-Forwarded-For</c> headers.</para>
        /// </summary>
        [NameInMap("XForwardedForConfig")]
        [Validation(Required=false)]
        public DescribeListenerResponseBodyXForwardedForConfig XForwardedForConfig { get; set; }
        public class DescribeListenerResponseBodyXForwardedForConfig : TeaModel {
            /// <summary>
            /// <para>Indicates whether the <c>GA-AP</c> header is used to retrieve information about the acceleration region.</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: yes.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: no.</para>
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
            /// <item><description><para><b>true</b>: yes.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: no.</para>
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
            /// <item><description><para><b>true</b>: yes.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: no.</para>
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
            /// <item><description><para><b>true</b>: yes.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: no.</para>
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
            /// <para>Indicates whether the <c>X-Real-IP</c> header is used to retrieve the real IP addresses of clients.</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: yes.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: no.</para>
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

}
