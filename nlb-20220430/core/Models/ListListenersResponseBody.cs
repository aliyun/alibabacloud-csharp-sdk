// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class ListListenersResponseBody : TeaModel {
        /// <summary>
        /// <para>The listeners.</para>
        /// </summary>
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public List<ListListenersResponseBodyListeners> Listeners { get; set; }
        public class ListListenersResponseBodyListeners : TeaModel {
            /// <summary>
            /// <para>Indicates whether Application-Layer Protocol Negotiation (ALPN) is enabled. Valid values:</para>
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
            /// <para>A list of CA certificates.</para>
            /// <remarks>
            /// <para> This parameter takes effect only for listeners that use SSL over TCP.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("CaCertificateIds")]
            [Validation(Required=false)]
            public List<string> CaCertificateIds { get; set; }

            /// <summary>
            /// <para>Indicates whether mutual authentication is enabled. Valid values:</para>
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
            /// <para>The server certificate.</para>
            /// <remarks>
            /// <para> This parameter takes effect only for listeners that use SSL over TCP.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("CertificateIds")]
            [Validation(Required=false)]
            public List<string> CertificateIds { get; set; }

            /// <summary>
            /// <para>The maximum number of new connections per second supported by the listener in each zone (virtual IP address). Valid values: <b>0</b> to <b>1000000</b>. <b>0</b> indicates that the number of connections is unlimited.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Cps")]
            [Validation(Required=false)]
            public int? Cps { get; set; }

            /// <summary>
            /// <para>The last port in the listener port range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>455</para>
            /// </summary>
            [NameInMap("EndPort")]
            [Validation(Required=false)]
            public string EndPort { get; set; }

            /// <summary>
            /// <para>The timeout period of idle connections. Unit: seconds. Valid values: <b>1</b> to <b>900</b>. Default value: <b>900</b>.</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>lsn-ga6sjjcll6ou34l1et****</para>
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// <para>The information about the listener port of your server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>443</para>
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
            /// <para>The status of the listener. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Provisioning</b>: The listener is being created.</description></item>
            /// <item><description><b>Running</b>: The listener is running.</description></item>
            /// <item><description><b>Configuring</b>: The listener is being configured.</description></item>
            /// <item><description><b>Stopping</b>: The listener is being stopped.</description></item>
            /// <item><description><b>Stopped</b>: The listener is stopped.</description></item>
            /// <item><description><b>Starting</b>: The listener is being started.</description></item>
            /// <item><description><b>Deleting</b>: The listener is being deleted.</description></item>
            /// <item><description><b>Deleted</b>: The listener is deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("ListenerStatus")]
            [Validation(Required=false)]
            public string ListenerStatus { get; set; }

            /// <summary>
            /// <para>The CLB instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nlb-83ckzc8d4xlp8o****</para>
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <para>The size of the largest TCP packet segment. Unit: bytes. Valid values: <b>0</b> to <b>1500</b>. <b>0</b> indicates that the Mss value of TCP packets remains unchanged.</para>
            /// <remarks>
            /// <para> This parameter takes effect only for listeners that use SSL over TCP.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Mss")]
            [Validation(Required=false)]
            public int? Mss { get; set; }

            /// <summary>
            /// <para>Indicates whether the Proxy protocol passes source client IP addresses to backend servers. Valid values:</para>
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
            /// <para>Indicates whether the Proxy protocol passes the VpcId, PrivateLinkEpId, and PrivateLinkEpsId parameters to backend servers.</para>
            /// </summary>
            [NameInMap("ProxyProtocolV2Config")]
            [Validation(Required=false)]
            public ListListenersResponseBodyListenersProxyProtocolV2Config ProxyProtocolV2Config { get; set; }
            public class ListListenersResponseBodyListenersProxyProtocolV2Config : TeaModel {
                /// <summary>
                /// <para>Indicates whether the Proxy protocol passes the PrivateLinkEpId parameter to backend servers. Valid values:</para>
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
                /// <para>Indicates whether the Proxy protocol passes the PrivateLinkEpsId parameter to backend servers. Valid values:</para>
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
                /// <para>Indicates whether the Proxy protocol passes the VpcId parameter to backend servers. Valid values:</para>
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
            /// <para>The region ID of the NLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Indicates whether fine-grained monitoring is enabled. Valid values:</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>sgp-ppdpc14gdm3x4o****</para>
            /// </summary>
            [NameInMap("ServerGroupId")]
            [Validation(Required=false)]
            public string ServerGroupId { get; set; }

            /// <summary>
            /// <para>The first port in the listener port range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>233</para>
            /// </summary>
            [NameInMap("StartPort")]
            [Validation(Required=false)]
            public string StartPort { get; set; }

            /// <summary>
            /// <para>A list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListListenersResponseBodyListenersTags> Tags { get; set; }
            public class ListListenersResponseBodyListenersTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Created</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TF</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, it indicates that no next query is to be sent.</description></item>
        /// <item><description>If a value of <b>NextToken</b> is returned, the value is the token used for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BA984</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
