// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebRulesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of queried website business forwarding rules.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// The configurations of the forwarding rule.
        /// </summary>
        [NameInMap("WebRules")]
        [Validation(Required=false)]
        public List<DescribeWebRulesResponseBodyWebRules> WebRules { get; set; }
        public class DescribeWebRulesResponseBodyWebRules : TeaModel {
            /// <summary>
            /// The IP addresses in the blacklist for the domain name.
            /// </summary>
            [NameInMap("BlackList")]
            [Validation(Required=false)]
            public List<string> BlackList { get; set; }

            /// <summary>
            /// Indicates whether the Frequency Control policy is enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("CcEnabled")]
            [Validation(Required=false)]
            public bool? CcEnabled { get; set; }

            /// <summary>
            /// Indicates whether the Custom Rule switch of the Frequency Control policy is turned on. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("CcRuleEnabled")]
            [Validation(Required=false)]
            public bool? CcRuleEnabled { get; set; }

            /// <summary>
            /// The mode of the Frequency Control policy. Valid values:
            /// 
            /// *   **default**: the Normal mode
            /// *   **gf_under_attack**: the Emergency mode
            /// *   **gf_sos_verify**: the Strict mode
            /// *   **gf_sos_verify**: the Super Strict mode
            /// </summary>
            [NameInMap("CcTemplate")]
            [Validation(Required=false)]
            public string CcTemplate { get; set; }

            /// <summary>
            /// The name of the SSL certificate.
            /// </summary>
            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            /// <summary>
            /// The region where the certificate is used. Valid values:
            /// 
            /// *   cn-hangzhou (default): the Chinese mainland
            /// *   ap-southeast-1: outside the Chinese mainland
            /// </summary>
            [NameInMap("CertRegion")]
            [Validation(Required=false)]
            public string CertRegion { get; set; }

            /// <summary>
            /// The CNAME provided by the Anti-DDoS Pro or Anti-DDoS Premium instance to which the domain name is added.
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// The custom cipher suites.
            /// </summary>
            [NameInMap("CustomCiphers")]
            [Validation(Required=false)]
            public List<string> CustomCiphers { get; set; }

            /// <summary>
            /// The domain name of the website.
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The SM certificate settings.
            /// </summary>
            [NameInMap("GmCert")]
            [Validation(Required=false)]
            public DescribeWebRulesResponseBodyWebRulesGmCert GmCert { get; set; }
            public class DescribeWebRulesResponseBodyWebRulesGmCert : TeaModel {
                /// <summary>
                /// The ID of the SM certificate.
                /// </summary>
                [NameInMap("CertId")]
                [Validation(Required=false)]
                public string CertId { get; set; }

                /// <summary>
                /// Indicates whether Enable SM Certificate-based Verification is turned on.
                /// 
                /// *   0: no
                /// *   1: yes
                /// </summary>
                [NameInMap("GmEnable")]
                [Validation(Required=false)]
                public long? GmEnable { get; set; }

                /// <summary>
                /// Indicates whether Allow Access Only from SM Certificates-based Clients is turned on.
                /// 
                /// *   0: no
                /// *   1: yes
                /// </summary>
                [NameInMap("GmOnly")]
                [Validation(Required=false)]
                public long? GmOnly { get; set; }

            }

            /// <summary>
            /// Indicates whether Enable HTTP/2 is turned on. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Http2Enable")]
            [Validation(Required=false)]
            public bool? Http2Enable { get; set; }

            /// <summary>
            /// Indicates whether Enable HTTPS Redirection was turned on. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Http2HttpsEnable")]
            [Validation(Required=false)]
            public bool? Http2HttpsEnable { get; set; }

            /// <summary>
            /// Indicates whether Enable HTTP Redirection of Back-to-origin Requests is turned on. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Https2HttpEnable")]
            [Validation(Required=false)]
            public bool? Https2HttpEnable { get; set; }

            /// <summary>
            /// Indicates whether the Online Certificate Status Protocol (OCSP) feature is enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("OcspEnabled")]
            [Validation(Required=false)]
            public bool? OcspEnabled { get; set; }

            /// <summary>
            /// The load balancing algorithm for back-to-origin traffic. Valid values:
            /// 
            /// *   **ip_hash**: the IP hash algorithm. This algorithm is used to redirect the requests from the same IP address to the same origin server.
            /// *   **rr**: the round-robin algorithm. This algorithm is used to redirect requests to origin servers in turn.
            /// *   **least_time**: the least response time algorithm. This algorithm is used to minimize the latency when requests are forwarded from Anti-DDoS Pro or Anti-DDoS Premium instances to origin servers based on the intelligent DNS resolution feature.
            /// </summary>
            [NameInMap("PolicyMode")]
            [Validation(Required=false)]
            public string PolicyMode { get; set; }

            /// <summary>
            /// Indicates whether the forwarding rule is enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("ProxyEnabled")]
            [Validation(Required=false)]
            public bool? ProxyEnabled { get; set; }

            /// <summary>
            /// The details of the protocol type and port number.
            /// </summary>
            [NameInMap("ProxyTypes")]
            [Validation(Required=false)]
            public List<DescribeWebRulesResponseBodyWebRulesProxyTypes> ProxyTypes { get; set; }
            public class DescribeWebRulesResponseBodyWebRulesProxyTypes : TeaModel {
                /// <summary>
                /// The ports.
                /// </summary>
                [NameInMap("ProxyPorts")]
                [Validation(Required=false)]
                public List<string> ProxyPorts { get; set; }

                /// <summary>
                /// The type of the protocol. Valid values:
                /// 
                /// *   **http**
                /// *   **https**
                /// *   **websocket**
                /// *   **websockets**
                /// </summary>
                [NameInMap("ProxyType")]
                [Validation(Required=false)]
                public string ProxyType { get; set; }

            }

            /// <summary>
            /// The reason why the domain name is invalid. Valid values:
            /// 
            /// *   **1**: No Content Provider (ICP) filing is completed for the domain name.
            /// *   **2**: The business for which you registered the domain name does not meet regulatory requirements.
            /// 
            /// If the two reasons are both involved, the value **2** is returned.
            /// </summary>
            [NameInMap("PunishReason")]
            [Validation(Required=false)]
            public int? PunishReason { get; set; }

            /// <summary>
            /// Indicates whether the domain name is invalid. Valid values:
            /// 
            /// *   **true**: You can view the specific reasons from the **PunishReason** parameter.
            /// *   **false**
            /// </summary>
            [NameInMap("PunishStatus")]
            [Validation(Required=false)]
            public bool? PunishStatus { get; set; }

            /// <summary>
            /// The details of the origin server address.
            /// </summary>
            [NameInMap("RealServers")]
            [Validation(Required=false)]
            public List<DescribeWebRulesResponseBodyWebRulesRealServers> RealServers { get; set; }
            public class DescribeWebRulesResponseBodyWebRulesRealServers : TeaModel {
                /// <summary>
                /// The address of the origin server.
                /// </summary>
                [NameInMap("RealServer")]
                [Validation(Required=false)]
                public string RealServer { get; set; }

                /// <summary>
                /// The type of the origin server address. Valid values:
                /// 
                /// *   **0**: IP address
                /// *   **1**: domain name The domain name of the origin server is returned if you deploy proxies, such as Web Application Firewall (WAF), between the origin server and the instance. In this case, the address of the proxy, such as the CNAME provided by WAF, is returned.
                /// </summary>
                [NameInMap("RsType")]
                [Validation(Required=false)]
                public int? RsType { get; set; }

            }

            /// <summary>
            /// Indicates whether TLS 1.3 is supported. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Ssl13Enabled")]
            [Validation(Required=false)]
            public bool? Ssl13Enabled { get; set; }

            /// <summary>
            /// The type of the cipher suite. Valid values:
            /// 
            /// *   **default**: custom cipher suites
            /// *   **all**: all cipher suites, which contain strong and weak cipher suites
            /// *   **strong**: strong cipher suites
            /// </summary>
            [NameInMap("SslCiphers")]
            [Validation(Required=false)]
            public string SslCiphers { get; set; }

            /// <summary>
            /// The version of the Transport Layer Security (TLS) protocol. Valid values:
            /// 
            /// *   **tls1.0**: TLS 1.0 or later
            /// *   **tls1.1**: TLS 1.1 or later
            /// *   **tls1.2**: TLS 1.2 or later
            /// </summary>
            [NameInMap("SslProtocols")]
            [Validation(Required=false)]
            public string SslProtocols { get; set; }

            /// <summary>
            /// The name of the certificate uploaded by the user to the certificate center.
            /// </summary>
            [NameInMap("UserCertName")]
            [Validation(Required=false)]
            public string UserCertName { get; set; }

            /// <summary>
            /// The IP addresses in the whitelist for the domain name.
            /// </summary>
            [NameInMap("WhiteList")]
            [Validation(Required=false)]
            public List<string> WhiteList { get; set; }

        }

    }

}
