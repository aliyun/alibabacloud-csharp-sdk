// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateListenerRequest : TeaModel {
        /// <summary>
        /// <para>The range of ports that are used by backend servers to receive requests.</para>
        /// </summary>
        [NameInMap("BackendPorts")]
        [Validation(Required=false)]
        public List<UpdateListenerRequestBackendPorts> BackendPorts { get; set; }
        public class UpdateListenerRequestBackendPorts : TeaModel {
            /// <summary>
            /// <para>The first port in the range of ports that are used by backend servers to receive requests.</para>
            /// <remarks>
            /// <para>This parameter is required only when you configure an HTTPS or HTTP listener and the listener port is different from the service port of the backend servers. In this case, the first port that is used by the backend servers to receive requests must be the same as the last port.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("FromPort")]
            [Validation(Required=false)]
            public int? FromPort { get; set; }

            /// <summary>
            /// <para>The last port in the range of ports that are used by backend servers to receive requests.</para>
            /// <remarks>
            /// <para>This parameter is required only when you configure an HTTPS or HTTP listener and the listener port is different from the service port of the backend servers. In this case, the first port that is used by the backend servers to receive requests must be the same as the last port.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("ToPort")]
            [Validation(Required=false)]
            public int? ToPort { get; set; }

        }

        /// <summary>
        /// <para>The SSL certificate.</para>
        /// </summary>
        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<UpdateListenerRequestCertificates> Certificates { get; set; }
        public class UpdateListenerRequestCertificates : TeaModel {
            /// <summary>
            /// <para>The ID of the SSL certificate.</para>
            /// <remarks>
            /// <para>This parameter is required only when you configure an HTTPS listener.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>449****-cn-hangzhou</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether client affinity is enabled for the listener. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NONE</b>: Client affinity is disabled. Requests from the same client may be forwarded to different endpoints.</description></item>
        /// <item><description><b>SOURCE_IP</b>: Client affinity is enabled. When a client accesses stateful applications, requests from the same client are forwarded to the same endpoint regardless of the source port or protocol.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SOURCE_IP</para>
        /// </summary>
        [NameInMap("ClientAffinity")]
        [Validation(Required=false)]
        public string ClientAffinity { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the listener.</para>
        /// <para>The description can be up to 200 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
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
        /// <para> Only HTTPS listeners support this parameter.</para>
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
        /// <list type="bullet">
        /// <item><description>TCP: 10-900. Default value: 900. Unit: seconds.</description></item>
        /// <item><description>UDP: 10-20. Default value: 20. Unit: seconds.</description></item>
        /// <item><description>HTTP/HTTPS: 1-60. Default value: 15. Unit: seconds.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>900</para>
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// <para>The ID of the listener.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsr-bp1bpn0kn908w4nbw****</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The name of the listener.</para>
        /// <para>The name must be 1 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Listener</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The listener ports that are used to receive requests and forward the requests to endpoints.</para>
        /// <para>Valid values: <b>1</b> to <b>65499</b>.</para>
        /// <para>The maximum number of ports that can be configured varies based on the routing type and protocol of the listener. For more information, see <a href="https://help.aliyun.com/document_detail/153216.html">Listener overview</a>.</para>
        /// </summary>
        [NameInMap("PortRanges")]
        [Validation(Required=false)]
        public List<UpdateListenerRequestPortRanges> PortRanges { get; set; }
        public class UpdateListenerRequestPortRanges : TeaModel {
            /// <summary>
            /// <para>The first port of the listener port range that is used to receive and forward requests to endpoints.</para>
            /// <para>Valid values: <b>1</b> to <b>65499</b>. The <b>FromPort</b> value must be smaller than or equal to the <b>ToPort</b> value.</para>
            /// <para>The maximum number of ports that can be configured varies based on the routing type and protocol of the listener. For more information, see <a href="https://help.aliyun.com/document_detail/153216.html">Listener overview</a>.</para>
            /// <remarks>
            /// <para>You can configure only one listener port for an HTTP or HTTPS listener. In this case, the first port is the same as the last port.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("FromPort")]
            [Validation(Required=false)]
            public int? FromPort { get; set; }

            /// <summary>
            /// <para>The last port of the listener port range that is used to receive and forward requests to endpoints.</para>
            /// <para>Valid values: <b>1</b> to <b>65499</b>. The <b>FromPort</b> value must be smaller than or equal to the <b>ToPort</b> value.</para>
            /// <para>The maximum number of ports that can be configured varies based on the routing type and protocol of the listener. For more information, see <a href="https://help.aliyun.com/document_detail/153216.html">Listener overview</a>.</para>
            /// <remarks>
            /// <para>You can configure only one listener port for an HTTP or HTTPS listener. In this case, the first port is the same as the last port.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21</para>
            /// </summary>
            [NameInMap("ToPort")]
            [Validation(Required=false)]
            public int? ToPort { get; set; }

        }

        /// <summary>
        /// <para>The network transmission protocol that is used by the listener. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>tcp</b>: TCP</description></item>
        /// <item><description><b>udp</b>: UDP</description></item>
        /// <item><description><b>http</b>: HTTP</description></item>
        /// <item><description><b>https</b>: HTTPS</description></item>
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
        /// <para>Specifies whether to preserve source IP addresses of clients.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> This feature allows you to view client IP addresses on backend servers.</description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter will be discontinued in the API operations that are used to configure listeners. We recommend that you set this parameter when you call API operations to configure endpoint groups. For more information about the <b>ProxyProtocol</b> parameter, see <a href="https://help.aliyun.com/document_detail/153259.html">CreateEndpointGroup</a> and <a href="https://help.aliyun.com/document_detail/153262.html">UpdateEndpointGroup</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ProxyProtocol")]
        [Validation(Required=false)]
        [Obsolete]
        public string ProxyProtocol { get; set; }

        /// <summary>
        /// <para>The ID of the region where the Global Accelerator (GA) instance is deployed. Set the value to <b>cn-hangzhou</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The timeout period for HTTP or HTTPS requests.</para>
        /// <para>Valid values: 1 to 180. Default value: 60. Unit: seconds.</para>
        /// <remarks>
        /// <para> This parameter takes effect only for HTTP or HTTPS listeners. If the backend server does not respond within the timeout period, GA returns an HTTP 504 error code to the client.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// <para>The ID of the security policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>tls_cipher_policy_1_0</b></para>
        /// <list type="bullet">
        /// <item><description>Supported Transport Layer Security (TLS) versions: TLS 1.0, TLS 1.1, and TLS 1.2</description></item>
        /// <item><description>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>tls_cipher_policy_1_1</b></para>
        /// <list type="bullet">
        /// <item><description>Supported TLS versions: TLS 1.1 and TLS 1.2</description></item>
        /// <item><description>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>tls_cipher_policy_1_2</b></para>
        /// <list type="bullet">
        /// <item><description>Supported TLS version: TLS 1.2</description></item>
        /// <item><description>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>tls_cipher_policy_1_2_strict</b></para>
        /// <list type="bullet">
        /// <item><description>Supported TLS version: TLS 1.2</description></item>
        /// <item><description>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>tls_cipher_policy_1_2_strict_with_1_3</b></para>
        /// <list type="bullet">
        /// <item><description>Supported TLS versions: TLS 1.2 and TLS 1.3</description></item>
        /// <item><description>Supported cipher suites: TLS_AES_128_GCM_SHA256, TLS_AES_256_GCM_SHA384, TLS_CHACHA20_POLY1305_SHA256, TLS_AES_128_CCM_SHA256, TLS_AES_128_CCM_8_SHA256, ECDHE-ECDSA-AES128-GCM-SHA256, ECDHE-ECDSA-AES256-GCM-SHA384, ECDHE-ECDSA-AES128-SHA256, ECDHE-ECDSA-AES256-SHA384, ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-ECDSA-AES128-SHA, ECDHE-ECDSA-AES256-SHA, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available only when you create an HTTPS listener.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>tls_cipher_policy_1_0</para>
        /// </summary>
        [NameInMap("SecurityPolicyId")]
        [Validation(Required=false)]
        public string SecurityPolicyId { get; set; }

        /// <summary>
        /// <para>The <c>XForward</c> headers.</para>
        /// </summary>
        [NameInMap("XForwardedForConfig")]
        [Validation(Required=false)]
        public UpdateListenerRequestXForwardedForConfig XForwardedForConfig { get; set; }
        public class UpdateListenerRequestXForwardedForConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to use the <c>GA-AP</c> header to retrieve information about acceleration regions. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b> (default): no</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is available only when you create an HTTPS or HTTP listener.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForGaApEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForGaApEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>GA-ID</c> header to retrieve the ID of the GA instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b> (default): no</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is available only when you create an HTTPS or HTTP listener.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForGaIdEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForGaIdEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>GA-X-Forward-Port</c> header to retrieve the listener ports of the GA instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b> (default): no</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is available only when you create an HTTPS or HTTP listener.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForPortEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForPortEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>GA-X-Forward-Proto</c> header to retrieve the listener protocol of the GA instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b> (default): no</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is available only when you create an HTTPS or HTTP listener.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XForwardedForProtoEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForProtoEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Real-IP</c> header to retrieve client IP addresses. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b> (default): no</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is available only when you create an HTTPS or HTTP listener.</para>
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
