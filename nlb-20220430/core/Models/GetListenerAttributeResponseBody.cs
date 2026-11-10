// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class GetListenerAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>Specifies whether Application-Layer Protocol Negotiation (ALPN) is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disabled.</para>
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
        /// <item><description><b>HTTP1Only</b></description></item>
        /// <item><description><b>HTTP2Only</b></description></item>
        /// <item><description><b>HTTP2Preferred</b></description></item>
        /// <item><description><b>HTTP2Optional</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP1Only</para>
        /// </summary>
        [NameInMap("AlpnPolicy")]
        [Validation(Required=false)]
        public string AlpnPolicy { get; set; }

        /// <summary>
        /// <para>The CA certificate list. Currently, you can add only one CA certificate.</para>
        /// <remarks>
        /// <para>This parameter takes effect only for TCPSSL listeners.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("CaCertificateIds")]
        [Validation(Required=false)]
        public List<string> CaCertificateIds { get; set; }

        /// <summary>
        /// <para>Specifies whether mutual authentication is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disabled.</para>
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
        /// <para>The server certificate list. Currently, you can add only one server certificate.</para>
        /// <remarks>
        /// <para>This parameter takes effect only for TCPSSL listeners.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("CertificateIds")]
        [Validation(Required=false)]
        public List<string> CertificateIds { get; set; }

        /// <summary>
        /// <para>The maximum number of new connections per second that the listener can process in each zone (VIP). Valid values: <b>0</b> to <b>1000000</b>. <b>0</b> indicates that no limit is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Cps")]
        [Validation(Required=false)]
        public int? Cps { get; set; }

        /// <summary>
        /// <para>The end port of the all-port listener. Valid values: <b>0</b> to <b>65535</b>. The end port must be less than the start port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>455</para>
        /// </summary>
        [NameInMap("EndPort")]
        [Validation(Required=false)]
        public string EndPort { get; set; }

        /// <summary>
        /// <para>The idle timeout period for connections. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>900</para>
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// <para>The custom listener name.</para>
        /// <para>The name must be 2 to 256 characters in length, and can contain Chinese characters and English letters. It can also contain digits, commas (,), periods (.), semicolons (;), forward slashes (/), at signs (@), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>tcpssl_443</para>
        /// </summary>
        [NameInMap("ListenerDescription")]
        [Validation(Required=false)]
        public string ListenerDescription { get; set; }

        /// <summary>
        /// <para>The listener ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsn-bp1bpn0kn908w4nbw****@233</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The listener port. Valid values: <b>0</b> to <b>65535</b>. <b>0</b> indicates that all-port listening is used. If you set this parameter to <b>0</b>, you must configure <b>StartPort</b> and <b>EndPort</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>233</para>
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// <para>The listener protocol. Valid values: <b>TCP</b>, <b>UDP</b>, and <b>TCPSSL</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TCPSSL</para>
        /// </summary>
        [NameInMap("ListenerProtocol")]
        [Validation(Required=false)]
        public string ListenerProtocol { get; set; }

        /// <summary>
        /// <para>The current status of the listener. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Provisioning</b>: The listener is being created.</para>
        /// </description></item>
        /// <item><description><para><b>Running</b>: The listener is running.</para>
        /// </description></item>
        /// <item><description><para><b>Configuring</b>: The listener is being configured.</para>
        /// </description></item>
        /// <item><description><para><b>Stopping</b>: The listener is being stopped.</para>
        /// </description></item>
        /// <item><description><para><b>Stopped</b>: The listener is stopped.</para>
        /// </description></item>
        /// <item><description><para><b>Starting</b>: The listener is being started.</para>
        /// </description></item>
        /// <item><description><para><b>Deleting</b>: The listener is being deleted.</para>
        /// </description></item>
        /// <item><description><para><b>Deleted</b>: The listener is deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("ListenerStatus")]
        [Validation(Required=false)]
        public string ListenerStatus { get; set; }

        /// <summary>
        /// <para>The Network Load Balancer (NLB) instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nlb-83ckzc8d4xlp8o****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The maximum segment size (MSS) of a TCP packet. Unit: bytes. Valid values: <b>0</b> to <b>1500</b>. <b>0</b> indicates that the MSS value of user TCP packets is not modified.</para>
        /// <remarks>
        /// <para>This field is supported only by TCP and TCPSSL listeners.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>166</para>
        /// </summary>
        [NameInMap("Mss")]
        [Validation(Required=false)]
        public int? Mss { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the Proxy Protocol to pass the client source IP address to backend servers. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disabled.</para>
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
        public GetListenerAttributeResponseBodyProxyProtocolV2Config ProxyProtocolV2Config { get; set; }
        public class GetListenerAttributeResponseBodyProxyProtocolV2Config : TeaModel {
            /// <summary>
            /// <para>Specifies whether to use the Proxy Protocol to pass the CN-ID to backend servers. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: disabled.</para>
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
            /// <item><description><para><b>true</b>: enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: disabled.</para>
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
            /// <item><description><para><b>true</b>: enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: disabled.</para>
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
            /// <item><description><para><b>true</b>: enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: disabled.</para>
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
        /// <para>The region ID of the Network Load Balancer (NLB) instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BA984</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the second-level monitoring feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disabled.</para>
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
        /// <para>The security policy ID. System security policies and custom security policies are supported.</para>
        /// <list type="bullet">
        /// <item><description>System policies: <b>tls_cipher_policy_1_0</b> (default), <b>tls_cipher_policy_1_1</b>, <b>tls_cipher_policy_1_2</b>, <b>tls_cipher_policy_1_2_strict</b>, and <b>tls_cipher_policy_1_2_strict_with_1_3</b>.</description></item>
        /// <item><description>Custom security policies: Enter the ID of the custom security policy.<list type="bullet">
        /// <item><description>To create a custom policy, see <a href="https://help.aliyun.com/document_detail/445901.html">CreateSecurityPolicy</a>.</description></item>
        /// <item><description>To query security policies, see <a href="https://help.aliyun.com/document_detail/445900.html">ListSecurityPolicy</a>.</description></item>
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
        /// <para>The server group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sgp-ppdpc14gdm3x4o****</para>
        /// </summary>
        [NameInMap("ServerGroupId")]
        [Validation(Required=false)]
        public string ServerGroupId { get; set; }

        /// <summary>
        /// <para>The start port of the all-port listener. Valid values: <b>0</b> to <b>65535</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>233</para>
        /// </summary>
        [NameInMap("StartPort")]
        [Validation(Required=false)]
        public string StartPort { get; set; }

        /// <summary>
        /// <para>The tag list.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetListenerAttributeResponseBodyTags> Tags { get; set; }
        public class GetListenerAttributeResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ac-cus-tag-4</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

    }

}
