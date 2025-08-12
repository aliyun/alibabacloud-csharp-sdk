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
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AlpnEnabled")]
        [Validation(Required=false)]
        public bool? AlpnEnabled { get; set; }

        /// <summary>
        /// <para>The name of the ALPN policy. The following are the possible values:</para>
        /// <list type="bullet">
        /// <item><description><b>HTTP1Only</b>: Negotiate only HTTP/1.\*. The ALPN preference list is HTTP/1.1, HTTP/1.0.</description></item>
        /// <item><description><b>HTTP2Only</b>: Negotiate only HTTP/2. The ALPN preference list is HTTP/2.</description></item>
        /// <item><description><b>HTTP2Optional</b>: Prefer HTTP/1.\* over HTTP/2. The ALPN preference list is HTTP/1.1, HTTP/1.0, HTTP/2.</description></item>
        /// <item><description><b>HTTP2Preferred</b>: Prefer HTTP/2 over HTTP/1.\*. The ALPN preference list is HTTP/2, HTTP/1.1, HTTP/1.0.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required if AlpnEnabled is set to true.</para>
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
        /// <para>The CA certificate. You can specify only one CA certificate.</para>
        /// <remarks>
        /// <para> This parameter takes effect only for listeners that use SSL over TCP.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("CaCertificateIds")]
        [Validation(Required=false)]
        public List<string> CaCertificateIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable mutual authentication. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CaEnabled")]
        [Validation(Required=false)]
        public bool? CaEnabled { get; set; }

        /// <summary>
        /// <para>The server certificate. Only one server certificate is supported.</para>
        /// <remarks>
        /// <para> This parameter takes effect only for listeners that use SSL over TCP.</para>
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
        /// <para>10000</para>
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
        /// <para>The timeout period for idle connections. Unit: seconds</para>
        /// <list type="bullet">
        /// <item><description>If the listener uses <b>TCP</b> or <b>TCPSSL</b>, you can set this parameter to a value ranging from <b>10</b> to <b>900</b>. Default value: <b>900</b></description></item>
        /// <item><description>If the listener uses <b>UDP</b>, you can set this parameter to a value ranging from <b>10</b> to <b>20</b>. Default value: <b>20</b></description></item>
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
        /// <para>tcpssl_443</para>
        /// </summary>
        [NameInMap("ListenerDescription")]
        [Validation(Required=false)]
        public string ListenerDescription { get; set; }

        /// <summary>
        /// <para>The listener ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsn-bp1bpn0kn908w4nbw****@443</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The size of the largest TCP packet segment. Unit: bytes. Valid values: <b>0</b> to <b>1500</b>. <b>0</b> indicates that the maximum segment size (MSS) remains unchanged. This parameter is supported only by TCP listeners and listeners that use SSL over TCP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>344</para>
        /// </summary>
        [NameInMap("Mss")]
        [Validation(Required=false)]
        public int? Mss { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the Proxy protocol to pass the client IP address to the backend server. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
        public UpdateListenerAttributeRequestProxyProtocolV2Config ProxyProtocolV2Config { get; set; }
        public class UpdateListenerAttributeRequestProxyProtocolV2Config : TeaModel {
            /// <summary>
            /// <para>Specifies whether to use the Proxy protocol to pass the PrivateLinkEpId parameter to backend servers. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
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
            /// <item><description><b>false</b></description></item>
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
            /// <item><description><b>false</b></description></item>
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
        /// <item><description><b>false</b></description></item>
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
        /// <para> This parameter takes effect only for listeners that use SSL over TCP.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>tls_cipher_policy_1_1</para>
        /// </summary>
        [NameInMap("SecurityPolicyId")]
        [Validation(Required=false)]
        public string SecurityPolicyId { get; set; }

        /// <summary>
        /// <para>The server group ID.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If the listener uses <b>TCP</b>, you can specify server groups whose protocol is <b>TCP</b> or <b>TCP_UDP</b>. <b>UDP</b> server groups are not supported.</para>
        /// </description></item>
        /// <item><description><para>If the listener uses <b>UDP</b>, you can specify server groups whose protocol is <b>UDP</b> or <b>TCP_UDP</b>. <b>TCP</b> server groups are not supported.</para>
        /// </description></item>
        /// <item><description><para>If the listener uses <b>TCPSSL</b>, you can specify server groups whose protocol is <b>TCP</b> and whose <b>client IP preservation is disabled</b>. <b>TCP</b> server groups for which <b>client IP preservation is enabled</b> and server groups whose protocol is <b>UDP</b> or <b>TCP_UDP</b> are not supported.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sgp-ppdpc14gdm3x4o****</para>
        /// </summary>
        [NameInMap("ServerGroupId")]
        [Validation(Required=false)]
        public string ServerGroupId { get; set; }

    }

}
