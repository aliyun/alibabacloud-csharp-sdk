// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class UpdateListenerAttributeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable Application-Layer Protocol Negotiation (ALPN). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables ALPN.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disables ALPN.</para>
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
        /// <para>You must configure this parameter after ALPN is enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP1Only</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("AlpnPolicy")]
        [Validation(Required=false)]
        public string AlpnPolicy { get; set; }

        /// <summary>
        /// <para>The CA certificates. You can add only one CA certificate.</para>
        /// <remarks>
        /// <para>This parameter takes effect only for TCPSSL listeners.</para>
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
        /// <para>The server certificates. You can add only one server certificate.</para>
        /// <remarks>
        /// <para>This parameter takes effect only for TCPSSL listeners.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("CertificateIds")]
        [Validation(Required=false)]
        public List<string> CertificateIds { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must ensure that it is unique among different requests. The client token can contain only ASCII characters.</para>
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
        /// <para>The maximum number of new connections per second that the listener can process in each zone (VIP). Valid values: <b>0</b> to <b>1000000</b>. A value of <b>0</b> indicates that no limit is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("Cps")]
        [Validation(Required=false)]
        public int? Cps { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: prechecks the request without updating the listener. The system checks whether required parameters are specified, the request format is valid, and the service limits are met. If the request fails the precheck, the corresponding error is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): sends the request. If the request passes the precheck, an HTTP 2xx status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The idle connection timeout period. Unit: seconds.</para>
        /// <list type="bullet">
        /// <item><description><para>If the listener is a <b>TCP</b> or <b>TCPSSL</b> listener, valid values are <b>10</b> to <b>900</b>. Default value: <b>900</b>.</para>
        /// </description></item>
        /// <item><description><para>If the listener is a <b>UDP</b> listener, valid values are <b>10</b> to <b>90</b>. Default value: <b>90</b>.</para>
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
        /// <para>The custom name of the listener.</para>
        /// <para>The name must be 2 to 256 characters in length, and can contain Chinese characters, English letters, digits, commas (,), periods (.), semicolons (;), forward slashes (/), at signs (@), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>tcpssl_443</para>
        /// </summary>
        [NameInMap("ListenerDescription")]
        [Validation(Required=false)]
        public string ListenerDescription { get; set; }

        /// <summary>
        /// <para>The listener instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsn-bp1bpn0kn908w4nbw****@443</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The maximum segment size (MSS) of a TCP packet. Unit: bytes. Valid values: <b>0</b> to <b>1500</b>. A value of <b>0</b> indicates that the MSS value of user TCP packets is not modified. This parameter is supported only by TCP and TCPSSL listeners.</para>
        /// 
        /// <b>Example:</b>
        /// <para>344</para>
        /// </summary>
        [NameInMap("Mss")]
        [Validation(Required=false)]
        public int? Mss { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the Proxy Protocol to pass the client source IP address to backend servers. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: yes.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: no.</para>
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
        public UpdateListenerAttributeRequestProxyProtocolV2Config ProxyProtocolV2Config { get; set; }
        public class UpdateListenerAttributeRequestProxyProtocolV2Config : TeaModel {
            /// <summary>
            /// <para>Specifies whether to use the Proxy Protocol to pass the CN-ID to backend servers. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: yes.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: no.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Ppv2CnIdEnabled")]
            [Validation(Required=false)]
            public bool? Ppv2CnIdEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the Proxy Protocol to pass the PrivateLinkEpId to backend servers. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: yes.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: no.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Ppv2PrivateLinkEpIdEnabled")]
            [Validation(Required=false)]
            public bool? Ppv2PrivateLinkEpIdEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the Proxy Protocol to pass the PrivateLinkEpsId to backend servers. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: yes.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: no.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Ppv2PrivateLinkEpsIdEnabled")]
            [Validation(Required=false)]
            public bool? Ppv2PrivateLinkEpsIdEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the Proxy Protocol to pass the VpcId to backend servers. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: yes.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: no.</para>
            /// </description></item>
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
        /// <para>The ID of the region where the Network Load Balancer (NLB) instance is deployed. </para>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/443657.html">DescribeRegions</a> operation to retrieve the region ID.</para>
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
        /// <item><description><para><b>false</b>: disables second-level monitoring.</para>
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
        /// <para>The ID of the security policy.</para>
        /// <remarks>
        /// <para>This parameter takes effect only for TCPSSL listeners.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>tls_cipher_policy_1_1</para>
        /// </summary>
        [NameInMap("SecurityPolicyId")]
        [Validation(Required=false)]
        public string SecurityPolicyId { get; set; }

        /// <summary>
        /// <para>The ID of the server group.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the listener is a <b>TCP</b> listener, you can select a server group whose backend protocol is <b>TCP</b> or <b>TCP_UDP</b>. You cannot select a server group whose backend protocol is <b>UDP</b>.</description></item>
        /// <item><description>If the listener is a <b>UDP</b> listener, you can select a server group whose backend protocol is <b>UDP</b> or <b>TCP_UDP</b>. You cannot select a server group whose backend protocol is <b>TCP</b>.</description></item>
        /// <item><description>If the listener is a <b>TCPSSL</b> listener, you can select a server group whose backend protocol is <b>TCP</b> and for which <b>client address preservation is disabled</b>. You cannot select a server group whose backend protocol is <b>TCP</b> and for which <b>client address preservation is enabled</b>, or a server group whose backend protocol is <b>UDP</b> or <b>TCP_UDP</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sgp-ppdpc14gdm3x4o****</para>
        /// </summary>
        [NameInMap("ServerGroupId")]
        [Validation(Required=false)]
        public string ServerGroupId { get; set; }

    }

}
