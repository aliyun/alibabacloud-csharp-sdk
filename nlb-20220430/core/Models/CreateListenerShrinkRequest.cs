// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class CreateListenerShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable ALPN. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables ALPN.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): disables ALPN.</para>
        /// </description></item>
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
        /// <item><description><b>HTTP1Only</b>: negotiates only HTTP/1.x. The priority is HTTP/1.1 &gt; HTTP/1.0.</description></item>
        /// <item><description><b>HTTP2Only</b>: negotiates only HTTP/2.</description></item>
        /// <item><description><b>HTTP2Optional</b>: prefers HTTP/1.x but also accepts HTTP/2. The priority is HTTP/1.1 &gt; HTTP/1.0 &gt; HTTP/2.</description></item>
        /// <item><description><b>HTTP2Preferred</b>: prefers HTTP/2 but also accepts HTTP/1.x. The priority is HTTP/2 &gt; HTTP/1.1 &gt; HTTP/1.0.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You must configure this parameter after <b>AlpnEnabled</b> is enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP1Only</para>
        /// </summary>
        [NameInMap("AlpnPolicy")]
        [Validation(Required=false)]
        public string AlpnPolicy { get; set; }

        /// <summary>
        /// <para>The CA certificate list. This parameter takes effect only for TCPSSL listeners.</para>
        /// <remarks>
        /// <para>Currently, you can add only one CA certificate.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("CaCertificateIds")]
        [Validation(Required=false)]
        public List<string> CaCertificateIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable mutual authentication. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables mutual authentication.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): disables mutual authentication.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CaEnabled")]
        [Validation(Required=false)]
        public bool? CaEnabled { get; set; }

        /// <summary>
        /// <para>The server certificate list. This parameter takes effect only for TCPSSL listeners.</para>
        /// <remarks>
        /// <para>Currently, you can add only one server certificate.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("CertificateIds")]
        [Validation(Required=false)]
        public List<string> CertificateIds { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate a parameter value on your client to ensure that the value is unique across different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The limit on the number of new connections processed per second by the listener in each zone (VIP). Valid values: <b>0</b> to <b>1000000</b>. <b>0</b> indicates that no limit is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Cps")]
        [Validation(Required=false)]
        public int? Cps { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: sends a precheck request without creating the listener. The system checks whether required parameters are specified, the request format, and service limits. If the request fails the precheck, the corresponding error is returned. If the request passes the precheck, the DryRunOperation error code is returned.</description></item>
        /// <item><description><b>false</b> (default): sends a regular request. If the request passes the precheck, an HTTP 2xx status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The end port for all-port listening. Valid values: <b>1</b> to <b>65535</b>.
        /// The end port must be greater than the start port.</para>
        /// <remarks>
        /// <para>You must configure this parameter when <b>ListenerPort</b> is set to <b>0</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>566</para>
        /// </summary>
        [NameInMap("EndPort")]
        [Validation(Required=false)]
        public int? EndPort { get; set; }

        /// <summary>
        /// <para>The idle timeout period for connections. Unit: seconds.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>ListenerProtocol</b> is set to <b>TCP</b> or <b>TCPSSL</b>, the valid values are <b>10</b> to <b>900</b>. Default value: <b>900</b>.</para>
        /// </description></item>
        /// <item><description><para>If <b>ListenerProtocol</b> is set to <b>UDP</b>, the valid values are <b>10</b> to <b>90</b>. Default value: <b>90</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>900</para>
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// <para>The custom listener name.</para>
        /// <para>The name must be 2 to 256 characters in length, and can contain Chinese characters, English letters, digits, commas (,), periods (.), semicolons (;), forward slashes (/), at signs (@), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>tcp_80</para>
        /// </summary>
        [NameInMap("ListenerDescription")]
        [Validation(Required=false)]
        public string ListenerDescription { get; set; }

        /// <summary>
        /// <para>The listener port. Valid values: <b>0</b> to <b>65535</b>.</para>
        /// <para><b>0</b>: indicates that the all-port feature is used. If you set this parameter to <b>0</b>, you must configure <b>StartPort</b> and <b>EndPort</b>.</para>
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
        /// <para>The Network Load Balancer (NLB) instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nlb-83ckzc8d4xlp8o****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The maximum segment size (MSS) of TCP packets. Unit: bytes. Valid values: <b>0</b> to <b>1500</b>.
        /// <b>0</b>: indicates that the MSS value of user TCP packets is not modified.</para>
        /// <remarks>
        /// <para>This parameter is supported only by TCP and TCPSSL listeners.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>43</para>
        /// </summary>
        [NameInMap("Mss")]
        [Validation(Required=false)]
        public int? Mss { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the Proxy Protocol to pass the client source IP address to backend servers. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables the feature.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): disables the feature.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ProxyProtocolEnabled")]
        [Validation(Required=false)]
        public bool? ProxyProtocolEnabled { get; set; }

        /// <summary>
        /// <para>The configuration for passing the VpcId, PrivateLinkEpId, and PrivateLinkEpsId information to backend servers by using the Proxy Protocol.</para>
        /// </summary>
        [NameInMap("ProxyProtocolV2Config")]
        [Validation(Required=false)]
        public string ProxyProtocolV2ConfigShrink { get; set; }

        /// <summary>
        /// <para>The region ID of the Network Load Balancer (NLB) instance. </para>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/443657.html">DescribeRegions</a> operation to query region IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable second-level monitoring. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables second-level monitoring.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): disables second-level monitoring.</para>
        /// </description></item>
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
        /// <item><description>System policies: <b>tls_cipher_policy_1_0</b> (default), <b>tls_cipher_policy_1_1</b>, <b>tls_cipher_policy_1_2</b>, <b>tls_cipher_policy_1_2_strict</b>, and <b>tls_cipher_policy_1_2_strict_with_1_3</b>.</description></item>
        /// <item><description>Custom security policies: Enter the ID of a custom security policy.<list type="bullet">
        /// <item><description>To create a custom policy, refer to <a href="https://help.aliyun.com/document_detail/445901.html">CreateSecurityPolicy</a>.</description></item>
        /// <item><description>To query security policies, refer to <a href="https://help.aliyun.com/document_detail/445900.html">ListSecurityPolicy</a>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only for TCPSSL listeners.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>tls_cipher_policy_1_0</para>
        /// </summary>
        [NameInMap("SecurityPolicyId")]
        [Validation(Required=false)]
        public string SecurityPolicyId { get; set; }

        /// <summary>
        /// <para>The ID of the server group.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If <b>ListenerProtocol</b> is set to <b>TCP</b>, the listener supports server groups whose backend protocol is <b>TCP</b> or <b>TCP_UDP</b>, but does not support server groups whose backend protocol is <b>UDP</b>.</description></item>
        /// <item><description>If <b>ListenerProtocol</b> is set to <b>UDP</b>, the listener supports server groups whose backend protocol is <b>UDP</b> or <b>TCP_UDP</b>, but does not support server groups whose backend protocol is <b>TCP</b>.</description></item>
        /// <item><description>If <b>ListenerProtocol</b> is set to <b>TCPSSL</b>, the listener supports server groups whose backend protocol is <b>TCP</b> and for which <b>client address preservation is disabled</b>. It does not support server groups whose backend protocol is <b>TCP</b> and for which <b>client address preservation is enabled</b>, or server groups whose backend protocol is <b>UDP</b> or <b>TCP_UDP</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sgp-ppdpc14gdm3x4o****</para>
        /// </summary>
        [NameInMap("ServerGroupId")]
        [Validation(Required=false)]
        public string ServerGroupId { get; set; }

        /// <summary>
        /// <para>The start port for all-port listening. Valid values: <b>1</b> to <b>65535</b>.</para>
        /// <remarks>
        /// <para>You must configure this parameter when <b>ListenerPort</b> is set to <b>0</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>244</para>
        /// </summary>
        [NameInMap("StartPort")]
        [Validation(Required=false)]
        public int? StartPort { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateListenerShrinkRequestTag> Tag { get; set; }
        public class CreateListenerShrinkRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. The key can be up to 64 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>, or contain <c>http://</c> or <c>https://</c>. Supported characters include letters, digits, underscores (_), periods (.), colons (:), forward slashes (/), equal signs (=), plus signs (+), hyphens (-), and at signs (@).</para>
            /// <para>You can add up to 20 tags in a single call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KeyTest</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The value can be up to 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>, or contain <c>http://</c> or <c>https://</c>. Supported characters include letters, digits, underscores (_), periods (.), colons (:), forward slashes (/), equal signs (=), plus signs (+), hyphens (-), and at signs (@).</para>
            /// <para>You can add up to 20 tags in a single call.</para>
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
