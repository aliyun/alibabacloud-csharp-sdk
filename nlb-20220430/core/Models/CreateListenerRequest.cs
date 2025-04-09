// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class CreateListenerRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable Application-Layer Protocol Negotiation (ALPN). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AlpnEnabled")]
        [Validation(Required=false)]
        public bool? AlpnEnabled { get; set; }

        /// <summary>
        /// <para>The ALPN policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HTTP1Only</b>: uses only HTTP 1.x. The priority of HTTP 1.1 is higher than the priority of HTTP 1.0.</description></item>
        /// <item><description><b>HTTP2Only</b>: uses only HTTP 2.0.</description></item>
        /// <item><description><b>HTTP2Optional</b>: preferentially uses HTTP 1.x over HTTP 2.0. The priority of HTTP 1.1 is higher than the priority of HTTP 1.0, and the priority of HTTP 1.0 is higher than the priority of HTTP 2.0.</description></item>
        /// <item><description><b>HTTP2Preferred</b>: preferentially uses HTTP 2.0 over HTTP 1.x. The priority of HTTP 2.0 is higher than the priority of HTTP 1.1, and the priority of HTTP 1.1 is higher than the priority of HTTP 1.0.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required if <b>AlpnEnabled</b> is set to true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP1Only</para>
        /// </summary>
        [NameInMap("AlpnPolicy")]
        [Validation(Required=false)]
        public string AlpnPolicy { get; set; }

        /// <summary>
        /// <para>The certificate authority (CA) certificate. This parameter is supported only by TCLSSL listeners.</para>
        /// <remarks>
        /// <para> You can specify only one CA certificate.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("CaCertificateIds")]
        [Validation(Required=false)]
        public List<string> CaCertificateIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable mutual authentication. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CaEnabled")]
        [Validation(Required=false)]
        public bool? CaEnabled { get; set; }

        /// <summary>
        /// <para>The server certificate. This parameter is supported only by TCLSSL listeners.</para>
        /// <remarks>
        /// <para> You can specify only one server certificate.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("CertificateIds")]
        [Validation(Required=false)]
        public List<string> CertificateIds { get; set; }

        /// <summary>
        /// <para>The client token used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token. Ensure that the token is unique among different requests. Only ASCII characters are allowed.</para>
        /// <remarks>
        /// <para> If you do not set this parameter, the value of <b>RequestId</b> is used.**** The value of <b>RequestId</b> is different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The maximum number of new connections per second supported by the listener in each zone (virtual IP address). Valid values: <b>0</b> to <b>1000000</b>. <b>0</b> indicates that the number of connections is unlimited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Cps")]
        [Validation(Required=false)]
        public int? Cps { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: validates the request without performing the operation. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the validation, the corresponding error message is returned. If the request passes the validation, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): validates the request and performs the operation. If the request passes the validation, a 2xx HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The last port in the listener port range. Valid values: <b>0</b> to <b>65535</b>. The port number of the last port must be greater than the port number of the first port.</para>
        /// <remarks>
        /// <para> This parameter is required when <b>ListenerPort</b> is set to <b>0</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>566</para>
        /// </summary>
        [NameInMap("EndPort")]
        [Validation(Required=false)]
        public int? EndPort { get; set; }

        /// <summary>
        /// <para>The timeout period for idle connections. Unit: seconds.</para>
        /// <list type="bullet">
        /// <item><description>If you set <b>ListenerProtocol</b> to <b>TCP</b> or <b>TCPSSL</b>, this parameter can be set to a value ranging from <b>10</b> to <b>900</b>. Default value: <b>900</b>.</description></item>
        /// <item><description>If <b>ListenerProtocol</b> is set to <b>UDP</b>, this parameter can be set to a value ranging from <b>10</b> to <b>20</b>. Default value: <b>20</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>900</para>
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// <para>The name of the listener.</para>
        /// <para>The name must be 2 to 256 characters in length, and can contain letters, digits, commas (,), periods (.), semicolons (;), forward slashes (/), at signs (@), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>tcp_80</para>
        /// </summary>
        [NameInMap("ListenerDescription")]
        [Validation(Required=false)]
        public string ListenerDescription { get; set; }

        /// <summary>
        /// <para>The listener port. Valid values: <b>0</b> to <b>65535</b>.</para>
        /// <para>If you set this parameter to <b>0</b>, the listener listens by port range. If you set this parameter to <b>0</b>, you must also set the <b>StartPort</b> and <b>EndPort</b> parameters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// <para>The listener protocol. Valid values: <b>TCP</b>, <b>UDP</b>, and <b>TCPSSL</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("ListenerProtocol")]
        [Validation(Required=false)]
        public string ListenerProtocol { get; set; }

        /// <summary>
        /// <para>The ID of the NLB instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nlb-83ckzc8d4xlp8o****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The size of the largest TCP packet segment. Unit: bytes. Valid values: <b>0</b> to <b>1500</b>. <b>0</b> indicates that the maximum segment size (MSS) value of TCP packets remains unchanged.</para>
        /// <remarks>
        /// <para> This parameter takes effect only for TCP and TCPSSL listeners.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>43</para>
        /// </summary>
        [NameInMap("Mss")]
        [Validation(Required=false)]
        public int? Mss { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the Proxy protocol to pass client IP addresses to backend servers. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ProxyProtocolEnabled")]
        [Validation(Required=false)]
        public bool? ProxyProtocolEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the Proxy protocol to pass the VpcId, PrivateLinkEpId, and PrivateLinkEpsId parameters to backend servers.</para>
        /// </summary>
        [NameInMap("ProxyProtocolV2Config")]
        [Validation(Required=false)]
        public CreateListenerRequestProxyProtocolV2Config ProxyProtocolV2Config { get; set; }
        public class CreateListenerRequestProxyProtocolV2Config : TeaModel {
            /// <summary>
            /// <para>Specifies whether to use the Proxy protocol to pass the Ppv2PrivateLinkEpId parameter to backend servers. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b> (default)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Ppv2PrivateLinkEpIdEnabled")]
            [Validation(Required=false)]
            public bool? Ppv2PrivateLinkEpIdEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the Proxy protocol to pass the PrivateLinkEpsId parameter to backend servers. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b> (default)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Ppv2PrivateLinkEpsIdEnabled")]
            [Validation(Required=false)]
            public bool? Ppv2PrivateLinkEpsIdEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the Proxy protocol to pass the VpcId parameter to backend servers. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b> (default)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Ppv2VpcIdEnabled")]
            [Validation(Required=false)]
            public bool? Ppv2VpcIdEnabled { get; set; }

        }

        /// <summary>
        /// <para>The ID of the region where the NLB instance is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/443657.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable fine-grained monitoring. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SecSensorEnabled")]
        [Validation(Required=false)]
        public bool? SecSensorEnabled { get; set; }

        /// <summary>
        /// <para>The ID of the security policy. System security policies and custom security policies are supported.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values for system security policies: <b>tls_cipher_policy_1_0</b> (default), <b>tls_cipher_policy_1_1</b>, <b>tls_cipher_policy_1_2</b>, <b>tls_cipher_policy_1_2_strict</b>, and <b>tls_cipher_policy_1_2_strict_with_1_3</b>.</para>
        /// </description></item>
        /// <item><description><para>For a custom security policy, enter the policy ID.</para>
        /// <list type="bullet">
        /// <item><description>For information about creating a custom security policy, see <a href="https://help.aliyun.com/document_detail/445901.html">CreateSecurityPolicy</a>.</description></item>
        /// <item><description>For information about querying security policies, see <a href="https://help.aliyun.com/document_detail/445900.html">ListSecurityPolicy</a>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect only for TCPSSL listeners.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>tls_cipher_policy_1_0</para>
        /// </summary>
        [NameInMap("SecurityPolicyId")]
        [Validation(Required=false)]
        public string SecurityPolicyId { get; set; }

        /// <summary>
        /// <para>The server group ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you set <b>ListenerProtocol</b> to <b>TCP</b>, you can associate the listener with server groups whose backend protocol is <b>TCP</b> or <b>TCP_UDP</b>. You cannot associate the listener with server groups whose backend protocol is <b>UDP</b>.</description></item>
        /// <item><description>If you set <b>ListenerProtocol</b> to <b>UDP</b>, you can associate the listener with server groups whose backend protocol is <b>UDP</b> or <b>TCP_UDP</b>. You cannot associate the listener with server groups whose backend protocol is <b>TCP</b>.</description></item>
        /// <item><description>If you set <b>ListenerProtocol</b> to <b>TCPSSL</b>, you can associate the listener with server groups whose backend protocol is <b>TCP</b> and have <b>client IP preservation disabled</b>. You cannot associate the listener with server groups whose backend protocol is <b>TCP</b> and have <b>client IP preservation enabled</b> or server groups whose backend protocol is <b>UDP</b> or <b>TCP_UDP</b>.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sgp-ppdpc14gdm3x4o****</para>
        /// </summary>
        [NameInMap("ServerGroupId")]
        [Validation(Required=false)]
        public string ServerGroupId { get; set; }

        /// <summary>
        /// <para>The first port in the listener port range. Valid values: <b>0</b> to <b>65535</b>.</para>
        /// <remarks>
        /// <para> This parameter is required when <b>ListenerPort</b> is set to <b>0</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>244</para>
        /// </summary>
        [NameInMap("StartPort")]
        [Validation(Required=false)]
        public int? StartPort { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateListenerRequestTag> Tag { get; set; }
        public class CreateListenerRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag. The tag key can be up to 64 characters in length, cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>. The tag value can contain letters, digits, and the following special characters: _ . : / = + - @</para>
            /// <para>You can specify up to 20 tags in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KeyTest</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag. The tag value can be up to 128 characters in length, cannot start with <c>acs:</c> or <c>aliyun</c>, and cannot contain <c>http://</c> or <c>https://</c>. The tag value can contain letters, digits, and the following special characters: _ . : / = + - @</para>
            /// <para>You can specify up to 20 tags in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
