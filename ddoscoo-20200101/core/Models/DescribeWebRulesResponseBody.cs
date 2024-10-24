// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0F5B72DD-96F4-423A-B12B-A5151DD746B8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of queried website business forwarding rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The configurations of the forwarding rule.</para>
        /// </summary>
        [NameInMap("WebRules")]
        [Validation(Required=false)]
        public List<DescribeWebRulesResponseBodyWebRules> WebRules { get; set; }
        public class DescribeWebRulesResponseBodyWebRules : TeaModel {
            /// <summary>
            /// <para>The IP addresses in the blacklist for the domain name.</para>
            /// </summary>
            [NameInMap("BlackList")]
            [Validation(Required=false)]
            public List<string> BlackList { get; set; }

            /// <summary>
            /// <para>Indicates whether the Frequency Control policy is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CcEnabled")]
            [Validation(Required=false)]
            public bool? CcEnabled { get; set; }

            /// <summary>
            /// <para>Indicates whether the Custom Rule switch of the Frequency Control policy is turned on. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("CcRuleEnabled")]
            [Validation(Required=false)]
            public bool? CcRuleEnabled { get; set; }

            /// <summary>
            /// <para>The mode of the Frequency Control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>default</b>: the Normal mode</description></item>
            /// <item><description><b>gf_under_attack</b>: the Emergency mode</description></item>
            /// <item><description><b>gf_sos_verify</b>: the Strict mode</description></item>
            /// <item><description><b>gf_sos_verify</b>: the Super Strict mode</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("CcTemplate")]
            [Validation(Required=false)]
            public string CcTemplate { get; set; }

            /// <summary>
            /// <para>The name of the SSL certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testcert</para>
            /// </summary>
            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            /// <summary>
            /// <para>The region where the certificate is used. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cn-hangzhou (default): the Chinese mainland</description></item>
            /// <item><description>ap-southeast-1: outside the Chinese mainland</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("CertRegion")]
            [Validation(Required=false)]
            public string CertRegion { get; set; }

            /// <summary>
            /// <para>The CNAME provided by the Anti-DDoS Pro or Anti-DDoS Premium instance to which the domain name is added.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kzmk7b8tt351****.aliyunddos1014****</para>
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// <para>The custom cipher suites.</para>
            /// </summary>
            [NameInMap("CustomCiphers")]
            [Validation(Required=false)]
            public List<string> CustomCiphers { get; set; }

            /// <summary>
            /// <para>The domain name of the website.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The SM certificate settings.</para>
            /// </summary>
            [NameInMap("GmCert")]
            [Validation(Required=false)]
            public DescribeWebRulesResponseBodyWebRulesGmCert GmCert { get; set; }
            public class DescribeWebRulesResponseBodyWebRulesGmCert : TeaModel {
                /// <summary>
                /// <para>The ID of the SM certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>725****</para>
                /// </summary>
                [NameInMap("CertId")]
                [Validation(Required=false)]
                public string CertId { get; set; }

                /// <summary>
                /// <para>Indicates whether Enable SM Certificate-based Verification is turned on.</para>
                /// <list type="bullet">
                /// <item><description>0: no</description></item>
                /// <item><description>1: yes</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("GmEnable")]
                [Validation(Required=false)]
                public long? GmEnable { get; set; }

                /// <summary>
                /// <para>Indicates whether Allow Access Only from SM Certificates-based Clients is turned on.</para>
                /// <list type="bullet">
                /// <item><description>0: no</description></item>
                /// <item><description>1: yes</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("GmOnly")]
                [Validation(Required=false)]
                public long? GmOnly { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether Enable HTTP/2 is turned on. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Http2Enable")]
            [Validation(Required=false)]
            public bool? Http2Enable { get; set; }

            /// <summary>
            /// <para>Indicates whether Enable HTTPS Redirection was turned on. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Http2HttpsEnable")]
            [Validation(Required=false)]
            public bool? Http2HttpsEnable { get; set; }

            /// <summary>
            /// <para>Indicates whether Enable HTTP Redirection of Back-to-origin Requests is turned on. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Https2HttpEnable")]
            [Validation(Required=false)]
            public bool? Https2HttpEnable { get; set; }

            /// <summary>
            /// <para>Indicates whether the Online Certificate Status Protocol (OCSP) feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("OcspEnabled")]
            [Validation(Required=false)]
            public bool? OcspEnabled { get; set; }

            /// <summary>
            /// <para>The load balancing algorithm for back-to-origin traffic. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ip_hash</b>: the IP hash algorithm. This algorithm is used to redirect the requests from the same IP address to the same origin server.</description></item>
            /// <item><description><b>rr</b>: the round-robin algorithm. This algorithm is used to redirect requests to origin servers in turn.</description></item>
            /// <item><description><b>least_time</b>: the least response time algorithm. This algorithm is used to minimize the latency when requests are forwarded from Anti-DDoS Pro or Anti-DDoS Premium instances to origin servers based on the intelligent DNS resolution feature.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ip_hash</para>
            /// </summary>
            [NameInMap("PolicyMode")]
            [Validation(Required=false)]
            public string PolicyMode { get; set; }

            /// <summary>
            /// <para>Indicates whether the forwarding rule is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ProxyEnabled")]
            [Validation(Required=false)]
            public bool? ProxyEnabled { get; set; }

            /// <summary>
            /// <para>The details of the protocol type and port number.</para>
            /// </summary>
            [NameInMap("ProxyTypes")]
            [Validation(Required=false)]
            public List<DescribeWebRulesResponseBodyWebRulesProxyTypes> ProxyTypes { get; set; }
            public class DescribeWebRulesResponseBodyWebRulesProxyTypes : TeaModel {
                /// <summary>
                /// <para>The ports.</para>
                /// </summary>
                [NameInMap("ProxyPorts")]
                [Validation(Required=false)]
                public List<string> ProxyPorts { get; set; }

                /// <summary>
                /// <para>The type of the protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>http</b></description></item>
                /// <item><description><b>https</b></description></item>
                /// <item><description><b>websocket</b></description></item>
                /// <item><description><b>websockets</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>https</para>
                /// </summary>
                [NameInMap("ProxyType")]
                [Validation(Required=false)]
                public string ProxyType { get; set; }

            }

            /// <summary>
            /// <para>The reason why the domain name is invalid. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: No Content Provider (ICP) filing is completed for the domain name.</description></item>
            /// <item><description><b>2</b>: The business for which you registered the domain name does not meet regulatory requirements.</description></item>
            /// </list>
            /// <para>If the two reasons are both involved, the value <b>2</b> is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PunishReason")]
            [Validation(Required=false)]
            public int? PunishReason { get; set; }

            /// <summary>
            /// <para>Indicates whether the domain name is invalid. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: You can view the specific reasons from the <b>PunishReason</b> parameter.</description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PunishStatus")]
            [Validation(Required=false)]
            public bool? PunishStatus { get; set; }

            /// <summary>
            /// <para>The details of the origin server address.</para>
            /// </summary>
            [NameInMap("RealServers")]
            [Validation(Required=false)]
            public List<DescribeWebRulesResponseBodyWebRulesRealServers> RealServers { get; set; }
            public class DescribeWebRulesResponseBodyWebRulesRealServers : TeaModel {
                /// <summary>
                /// <para>The address of the origin server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.0.XX.XX</para>
                /// </summary>
                [NameInMap("RealServer")]
                [Validation(Required=false)]
                public string RealServer { get; set; }

                /// <summary>
                /// <para>The type of the origin server address. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: IP address</description></item>
                /// <item><description><b>1</b>: domain name The domain name of the origin server is returned if you deploy proxies, such as Web Application Firewall (WAF), between the origin server and the instance. In this case, the address of the proxy, such as the CNAME provided by WAF, is returned.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RsType")]
                [Validation(Required=false)]
                public int? RsType { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether TLS 1.3 is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Ssl13Enabled")]
            [Validation(Required=false)]
            public bool? Ssl13Enabled { get; set; }

            /// <summary>
            /// <para>The type of the cipher suite. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>default</b>: custom cipher suites</description></item>
            /// <item><description><b>all</b>: all cipher suites, which contain strong and weak cipher suites</description></item>
            /// <item><description><b>strong</b>: strong cipher suites</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("SslCiphers")]
            [Validation(Required=false)]
            public string SslCiphers { get; set; }

            /// <summary>
            /// <para>The version of the Transport Layer Security (TLS) protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>tls1.0</b>: TLS 1.0 or later</description></item>
            /// <item><description><b>tls1.1</b>: TLS 1.1 or later</description></item>
            /// <item><description><b>tls1.2</b>: TLS 1.2 or later</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tls1.1</para>
            /// </summary>
            [NameInMap("SslProtocols")]
            [Validation(Required=false)]
            public string SslProtocols { get; set; }

            /// <summary>
            /// <para>The name of the certificate uploaded by the user to the certificate center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("UserCertName")]
            [Validation(Required=false)]
            public string UserCertName { get; set; }

            /// <summary>
            /// <para>The IP addresses in the whitelist for the domain name.</para>
            /// </summary>
            [NameInMap("WhiteList")]
            [Validation(Required=false)]
            public List<string> WhiteList { get; set; }

        }

    }

}
