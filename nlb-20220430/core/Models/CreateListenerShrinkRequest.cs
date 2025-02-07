// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class CreateListenerShrinkRequest : TeaModel {
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
        /// <item><description>HTTP1Only: uses only HTTP 1.x. The priority of HTTP 1.1 is higher than the priority of HTTP 1.0.</description></item>
        /// <item><description>HTTP2Only: uses only HTTP 2.0.</description></item>
        /// <item><description>HTTP2Preferred: preferentially uses HTTP 2.0 over HTTP 1.x. The priority of HTTP 2.0 is higher than the priority of HTTP 1.1, and the priority of HTTP 1.1 is higher than the priority of HTTP 1.0.
        /// Note</description></item>
        /// <item><description>HTTP2Optional: preferentially uses HTTP 1.x over HTTP 2.0. The priority of HTTP 1.1 is higher than the priority of HTTP 1.0, and the priority of HTTP 1.0 is higher than the priority of HTTP 2.0.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required if AlpnEnabled is set to true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP1Only</para>
        /// </summary>
        [NameInMap("AlpnPolicy")]
        [Validation(Required=false)]
        public string AlpnPolicy { get; set; }

        /// <summary>
        /// <para>The certificate authority (CA) certificates. This parameter takes effect only for listeners that use SSL over TCP.</para>
        /// <remarks>
        /// <para>You can specify only one CA certificate.</para>
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
        /// <para>The server certificates. This parameter takes effect only for listeners that use SSL over TCP.</para>
        /// <remarks>
        /// <para>You can specify only one server certificate.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("CertificateIds")]
        [Validation(Required=false)]
        public List<string> CertificateIds { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
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
        /// <para>Specifies whether to perform only a dry run without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b>(default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The last port in the listener port range. Valid values: <b>0</b> to <b>65535</b>. The number of the last port must be greater than the number of the first port.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>ListenerPort</b> is set to <b>0</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>566</para>
        /// </summary>
        [NameInMap("EndPort")]
        [Validation(Required=false)]
        public int? EndPort { get; set; }

        /// <summary>
        /// <para>The timeout period of idle connections. Unit: seconds</para>
        /// <list type="bullet">
        /// <item><description>If you set <b>ListenerProtocol</b> to <b>TCP</b> or <b>TCPSSL</b>, the timeout period of idle connections can be set to <b>10</b> to <b>900</b> seconds. Default value: <b>900</b>.</description></item>
        /// <item><description>If <b>ListenerProtocol</b> is set to <b>UDP</b>, the timeout period of idle connections can be set to <b>10</b> to <b>20</b> seconds. Default value: <b>20</b>.</description></item>
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
        /// <para>If you set the value to <b>0</b>, the listener listens by port range. If you set the value to <b>0</b>, you must specify <b>StartPort</b> and <b>EndPort</b>.</para>
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
        /// <para>The ID of the Network Load Balancer (NLB) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nlb-83ckzc8d4xlp8o****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The maximum size of a TCP segment. Unit: bytes. Valid values: <b>0</b> to <b>1500</b>. <b>0</b> specifies that the maximum segment size remains unchanged.</para>
        /// <remarks>
        /// <para>This parameter is supported only by TCP listeners and listeners that use SSL over TCP.</para>
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
        /// <para>Specifies that the Proxy protocol passes the VpcId, PrivateLinkEpId, and PrivateLinkEpsId parameters to backend servers.</para>
        /// </summary>
        [NameInMap("ProxyProtocolV2Config")]
        [Validation(Required=false)]
        public string ProxyProtocolV2ConfigShrink { get; set; }

        /// <summary>
        /// <para>The region ID of the NLB instance.</para>
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
        /// <para>The security policy ID. System security policies and custom security policies are supported.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values: <b>tls_cipher_policy_1_0</b> (default), <b>tls_cipher_policy_1_1</b>, <b>tls_cipher_policy_1_2</b>, <b>tls_cipher_policy_1_2_strict</b>, and <b>tls_cipher_policy_1_2_strict_with_1_3</b>.</para>
        /// </description></item>
        /// <item><description><para>Custom security policy: the ID of the custom security policy.</para>
        /// <list type="bullet">
        /// <item><description><para>For more information about how to create a custom security policy, see <a href="https://help.aliyun.com/document_detail/2399231.html">CreateSecurityPolicy</a> .</para>
        /// </description></item>
        /// <item><description><para>For more information about how to query security policies, see <a href="https://help.aliyun.com/document_detail/2399234.html">ListSecurityPolicy</a> .</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only for listeners that use SSL over TCP.</para>
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
        /// <para>This parameter is required when <b>ListenerPort</b> is set to <b>0</b>.</para>
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
        public List<CreateListenerShrinkRequestTag> Tag { get; set; }
        public class CreateListenerShrinkRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag. You can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 64 characters in length and cannot contain <c>http://</c> or <c>https://</c>. It cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KeyTest</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The tag value can be up to 128 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can add up to 20 tags in each call.</para>
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
