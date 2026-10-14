// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39499F01-19D9-4EA4-A0E9-C6014BA5CDBE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of web rules returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>An array of web rule configurations.</para>
        /// </summary>
        [NameInMap("WebRules")]
        [Validation(Required=false)]
        public List<DescribeDomainResourceResponseBodyWebRules> WebRules { get; set; }
        public class DescribeDomainResourceResponseBodyWebRules : TeaModel {
            /// <summary>
            /// <para>An array of IP addresses on the blocklist for the domain.</para>
            /// </summary>
            [NameInMap("BlackList")]
            [Validation(Required=false)]
            public List<string> BlackList { get; set; }

            /// <summary>
            /// <para>Whether CC protection is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CcEnabled")]
            [Validation(Required=false)]
            public bool? CcEnabled { get; set; }

            /// <summary>
            /// <para>Whether custom CC protection rules are enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CcRuleEnabled")]
            [Validation(Required=false)]
            public bool? CcRuleEnabled { get; set; }

            /// <summary>
            /// <para>The CC protection mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>default</b>: normal mode</para>
            /// </description></item>
            /// <item><description><para><b>gf_under_attack</b>: Emergency mode</para>
            /// </description></item>
            /// <item><description><para><b>gf_sos_verify</b>: Strict mode</para>
            /// </description></item>
            /// <item><description><para><b>gf_sos_enhance</b>: Super Strict mode</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("CcTemplate")]
            [Validation(Required=false)]
            public string CcTemplate { get; set; }

            /// <summary>
            /// <para>The name of the SSL certificate used by the domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>49944XX.pem</para>
            /// </summary>
            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            /// <summary>
            /// <para>The CNAME assigned to the domain by Anti-DDoS Pro.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0ekb69x3j9wvXXXX.aliyunddosXXXX.com</para>
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// <para>An array of custom cipher suites.</para>
            /// </summary>
            [NameInMap("CustomCiphers")]
            [Validation(Required=false)]
            public List<string> CustomCiphers { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">www.example.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>Whether HTTP/2 is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Http2Enable")]
            [Validation(Required=false)]
            public bool? Http2Enable { get; set; }

            /// <summary>
            /// <para>Whether forced HTTPS redirect is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Http2HttpsEnable")]
            [Validation(Required=false)]
            public bool? Http2HttpsEnable { get; set; }

            /// <summary>
            /// <para>Whether HTTP back-to-source is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Https2HttpEnable")]
            [Validation(Required=false)]
            public bool? Https2HttpEnable { get; set; }

            /// <summary>
            /// <para>The advanced HTTPS settings, formatted as a JSON string. These settings apply only when the domain uses HTTPS (the <c>ProxyType</c> value includes <c>https</c>). The string contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Http2https</b>: integer. Specifies whether to enable forced HTTPS redirect. Valid values: <b>0</b> (disabled) and <b>1</b> (enabled).</para>
            /// </description></item>
            /// <item><description><para><b>Https2http</b>: integer. Specifies whether to enable HTTP back-to-source. Valid values: <b>0</b> (disabled) and <b>1</b> (enabled).</para>
            /// </description></item>
            /// <item><description><para><b>Http2</b>: integer. Specifies whether to enable HTTP/2. Valid values: <b>0</b> (disabled) and <b>1</b> (enabled).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Https2http&quot;:0,&quot;Http2&quot;:0,&quot;Http2https&quot;:0}</para>
            /// </summary>
            [NameInMap("HttpsExt")]
            [Validation(Required=false)]
            public string HttpsExt { get; set; }

            /// <summary>
            /// <para>An array of IDs for the Anti-DDoS Pro instances associated with the domain.</para>
            /// </summary>
            [NameInMap("InstanceIds")]
            [Validation(Required=false)]
            public List<string> InstanceIds { get; set; }

            /// <summary>
            /// <para>Whether Online Certificate Status Protocol (OCSP) is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("OcspEnabled")]
            [Validation(Required=false)]
            public bool? OcspEnabled { get; set; }

            /// <summary>
            /// <para>The back-to-source load balancing algorithm. This algorithm determines how traffic is distributed to origin servers. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ip_hash</b>: IP Hash. This algorithm hashes the source IP address and routes all requests from the same IP address to the same origin server.</para>
            /// </description></item>
            /// <item><description><para><b>rr</b>: Round Robin. This algorithm distributes requests across origin servers in turn.</para>
            /// </description></item>
            /// <item><description><para><b>least_time</b>: Least Time. This algorithm uses intelligent DNS resolution to minimize end-to-end latency from the protection node to the origin server.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ip_hash</para>
            /// </summary>
            [NameInMap("PolicyMode")]
            [Validation(Required=false)]
            public string PolicyMode { get; set; }

            /// <summary>
            /// <para>Whether Anti-DDoS Pro forwards traffic for the domain. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Forwarding is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Forwarding is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ProxyEnabled")]
            [Validation(Required=false)]
            public bool? ProxyEnabled { get; set; }

            /// <summary>
            /// <para>An array of proxy configurations for the domain, each specifying a protocol and its associated ports.</para>
            /// </summary>
            [NameInMap("ProxyTypes")]
            [Validation(Required=false)]
            public List<DescribeDomainResourceResponseBodyWebRulesProxyTypes> ProxyTypes { get; set; }
            public class DescribeDomainResourceResponseBodyWebRulesProxyTypes : TeaModel {
                /// <summary>
                /// <para>The array of ports associated with the protocol.</para>
                /// </summary>
                [NameInMap("ProxyPorts")]
                [Validation(Required=false)]
                public List<string> ProxyPorts { get; set; }

                /// <summary>
                /// <para>The proxy protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>http</b>: HTTP</para>
                /// </description></item>
                /// <item><description><para><b>https</b>: HTTPS</para>
                /// </description></item>
                /// <item><description><para><b>websocket</b>: WebSocket</para>
                /// </description></item>
                /// <item><description><para><b>websockets</b>: WebSockets</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>http</para>
                /// </summary>
                [NameInMap("ProxyType")]
                [Validation(Required=false)]
                public string ProxyType { get; set; }

            }

            /// <summary>
            /// <para>The reason the domain is penalized. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: The domain does not have an ICP filing.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: The business hosted on the domain does not meet regulatory requirements.</para>
            /// </description></item>
            /// </list>
            /// <para>If both reasons apply, this parameter returns <b>2</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PunishReason")]
            [Validation(Required=false)]
            public int? PunishReason { get; set; }

            /// <summary>
            /// <para>Whether the domain is penalized. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The domain is penalized. For more information, see the <c>PunishReason</c> parameter.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The domain is not penalized.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("PunishStatus")]
            [Validation(Required=false)]
            public bool? PunishStatus { get; set; }

            /// <summary>
            /// <para>An array of origin server addresses.</para>
            /// </summary>
            [NameInMap("RealServers")]
            [Validation(Required=false)]
            public List<string> RealServers { get; set; }

            /// <summary>
            /// <para>The address type of the origin server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: IP address</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: domain</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RsType")]
            [Validation(Required=false)]
            public int? RsType { get; set; }

            /// <summary>
            /// <para>Whether TLS 1.3 is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Ssl13Enabled")]
            [Validation(Required=false)]
            public bool? Ssl13Enabled { get; set; }

            /// <summary>
            /// <para>The cipher suite configuration type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>default</b>: Custom</para>
            /// </description></item>
            /// <item><description><para><b>all</b>: All</para>
            /// </description></item>
            /// <item><description><para><b>strong</b>: Strong</para>
            /// </description></item>
            /// <item><description><para><b>improved</b>: Improved</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("SslCiphers")]
            [Validation(Required=false)]
            public string SslCiphers { get; set; }

            /// <summary>
            /// <para>The minimum TLS protocol version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>tls1.0</b>: TLS 1.0 and later versions.</para>
            /// </description></item>
            /// <item><description><para><b>tls1.1</b>: TLS 1.1 and later versions.</para>
            /// </description></item>
            /// <item><description><para><b>tls1.2</b>: TLS 1.2 and later versions.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tls1.0</para>
            /// </summary>
            [NameInMap("SslProtocols")]
            [Validation(Required=false)]
            public string SslProtocols { get; set; }

            /// <summary>
            /// <para>An array of IP addresses on the allowlist for the domain.</para>
            /// </summary>
            [NameInMap("WhiteList")]
            [Validation(Required=false)]
            public List<string> WhiteList { get; set; }

        }

    }

}
