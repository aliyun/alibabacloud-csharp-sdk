// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainResourceResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of forwarding rules.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// The configurations of the forwarding rule.
        /// </summary>
        [NameInMap("WebRules")]
        [Validation(Required=false)]
        public List<DescribeDomainResourceResponseBodyWebRules> WebRules { get; set; }
        public class DescribeDomainResourceResponseBodyWebRules : TeaModel {
            /// <summary>
            /// The IP addresses that are included in the blacklist of the domain name.
            /// </summary>
            [NameInMap("BlackList")]
            [Validation(Required=false)]
            public List<string> BlackList { get; set; }

            /// <summary>
            /// Indicates whether Frequency Control is enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("CcEnabled")]
            [Validation(Required=false)]
            public bool? CcEnabled { get; set; }

            /// <summary>
            /// Indicates whether the Custom Rules switch of Frequency Control is turned on. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("CcRuleEnabled")]
            [Validation(Required=false)]
            public bool? CcRuleEnabled { get; set; }

            /// <summary>
            /// The mode of Frequency Control. Valid values:
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
            /// The name of the SSL certificate used by the domain name.
            /// </summary>
            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            /// <summary>
            /// The CNAME provided by the instance to which the domain name is added.
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
            /// Indicates whether Enable HTTP/2 is turned on. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Http2Enable")]
            [Validation(Required=false)]
            public bool? Http2Enable { get; set; }

            /// <summary>
            /// Indicates whether Enable HTTPS Redirection is turned on. Valid values:
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
            /// The advanced HTTPS settings. This parameter takes effect only when the value of the **ProxyType** parameter includes **https**. The value is a string that consists of a JSON struct. The JSON struct contains the following fields:
            /// 
            /// *   **Http2https**: indicates whether Enable HTTPS Redirection is turned on. Data type: integer. Valid values: **0** and **1**. The value 0 indicates that Enable HTTPS Redirection is turned on. The value 1 indicates that Enable HTTPS Redirection is turned off.
            /// *   **Https2http**: indicates whether Enable HTTP Redirection of Back-to-origin Requests is turned on. Data type: integer. Valid values: **0** and **1**. The value 0 indicates that the feature is turned on. The value 1 indicates that the feature is turned off.
            /// *   **Http2**: indicates whether Enable HTTP/2 is turned on. Data type: integer. Valid values: **0** and **1**. The value 0 indicates that Enable HTTP/2 is turned off. The value 1 indicates that Enable HTTP/2 is turned on.
            /// </summary>
            [NameInMap("HttpsExt")]
            [Validation(Required=false)]
            public string HttpsExt { get; set; }

            /// <summary>
            /// The IDs of the instances to which the domain name is added.
            /// </summary>
            [NameInMap("InstanceIds")]
            [Validation(Required=false)]
            public List<string> InstanceIds { get; set; }

            /// <summary>
            /// Indicates whether the Online Certificate Status Protocol (OCSP) feature is turned on. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("OcspEnabled")]
            [Validation(Required=false)]
            public bool? OcspEnabled { get; set; }

            /// <summary>
            /// The scheduling algorithm for back-to-origin traffic. Valid values:
            /// 
            /// *   **ip_hash**: the IP hash algorithm. This algorithm is used to redirect the requests from the same IP address to the same origin server.
            /// *   **rr**: the round-robin algorithm. This algorithm is used to redirect requests to origin servers in turn.
            /// *   **least_time**: the least response time algorithm. This algorithm is used to minimize the latency when requests are forwarded from the instance to origin servers based on the intelligent DNS resolution feature.
            /// </summary>
            [NameInMap("PolicyMode")]
            [Validation(Required=false)]
            public string PolicyMode { get; set; }

            /// <summary>
            /// Indicates whether the instance forwards the traffic that is destined for the website. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("ProxyEnabled")]
            [Validation(Required=false)]
            public bool? ProxyEnabled { get; set; }

            /// <summary>
            /// The details about the protocol type and port number.
            /// </summary>
            [NameInMap("ProxyTypes")]
            [Validation(Required=false)]
            public List<DescribeDomainResourceResponseBodyWebRulesProxyTypes> ProxyTypes { get; set; }
            public class DescribeDomainResourceResponseBodyWebRulesProxyTypes : TeaModel {
                /// <summary>
                /// The port numbers.
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
            /// *   **true**: The domain name is invalid. You can view the specific reasons from the **PunishReason** parameter.
            /// *   **false**: The domain name is valid.
            /// </summary>
            [NameInMap("PunishStatus")]
            [Validation(Required=false)]
            public bool? PunishStatus { get; set; }

            /// <summary>
            /// The addresses of origin servers.
            /// </summary>
            [NameInMap("RealServers")]
            [Validation(Required=false)]
            public List<string> RealServers { get; set; }

            /// <summary>
            /// The address type of the origin server. Valid values:
            /// 
            /// *   **0**: IP address
            /// *   **1**: domain name
            /// </summary>
            [NameInMap("RsType")]
            [Validation(Required=false)]
            public int? RsType { get; set; }

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
            /// *   **default**: custom cipher suite
            /// *   **all**: all cipher suites
            /// *   **strong**: strong cipher suites
            /// </summary>
            [NameInMap("SslCiphers")]
            [Validation(Required=false)]
            public string SslCiphers { get; set; }

            /// <summary>
            /// The version of the TLS protocol. Valid values:
            /// 
            /// *   **tls1.0**: TLS 1.0 or later
            /// *   **tls1.1**: TLS 1.1 or later
            /// *   **tls1.2**: TLS 1.2 or later
            /// </summary>
            [NameInMap("SslProtocols")]
            [Validation(Required=false)]
            public string SslProtocols { get; set; }

            /// <summary>
            /// The IP addresses that are included in the whitelist of the domain name.
            /// </summary>
            [NameInMap("WhiteList")]
            [Validation(Required=false)]
            public List<string> WhiteList { get; set; }

        }

    }

}
