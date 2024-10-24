// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39499F01-19D9-4EA4-A0E9-C6014BA5CDBE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of forwarding rules.</para>
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
        public List<DescribeDomainResourceResponseBodyWebRules> WebRules { get; set; }
        public class DescribeDomainResourceResponseBodyWebRules : TeaModel {
            /// <summary>
            /// <para>The IP addresses that are included in the blacklist of the domain name.</para>
            /// </summary>
            [NameInMap("BlackList")]
            [Validation(Required=false)]
            public List<string> BlackList { get; set; }

            /// <summary>
            /// <para>Indicates whether Frequency Control is enabled. Valid values:</para>
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
            /// <para>Indicates whether the Custom Rules switch of Frequency Control is turned on. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CcRuleEnabled")]
            [Validation(Required=false)]
            public bool? CcRuleEnabled { get; set; }

            /// <summary>
            /// <para>The mode of Frequency Control. Valid values:</para>
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
            /// <para>The name of the SSL certificate used by the domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>49944XX.pem</para>
            /// </summary>
            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            /// <summary>
            /// <para>The CNAME provided by the instance to which the domain name is added.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0ekb69x3j9wvXXXX.aliyunddosXXXX.com</para>
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
            /// <para><a href="http://www.example.com">www.example.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>Indicates whether Enable HTTP/2 is turned on. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Http2Enable")]
            [Validation(Required=false)]
            public bool? Http2Enable { get; set; }

            /// <summary>
            /// <para>Indicates whether Enable HTTPS Redirection is turned on. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
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
            /// <para>false</para>
            /// </summary>
            [NameInMap("Https2HttpEnable")]
            [Validation(Required=false)]
            public bool? Https2HttpEnable { get; set; }

            /// <summary>
            /// <para>The advanced HTTPS settings. This parameter takes effect only when the value of the <b>ProxyType</b> parameter includes <b>https</b>. The value is a string that consists of a JSON struct. The JSON struct contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><b>Http2https</b>: indicates whether Enable HTTPS Redirection is turned on. Data type: integer. Valid values: <b>0</b> and <b>1</b>. The value 0 indicates that Enable HTTPS Redirection is turned on. The value 1 indicates that Enable HTTPS Redirection is turned off.</description></item>
            /// <item><description><b>Https2http</b>: indicates whether Enable HTTP Redirection of Back-to-origin Requests is turned on. Data type: integer. Valid values: <b>0</b> and <b>1</b>. The value 0 indicates that the feature is turned on. The value 1 indicates that the feature is turned off.</description></item>
            /// <item><description><b>Http2</b>: indicates whether Enable HTTP/2 is turned on. Data type: integer. Valid values: <b>0</b> and <b>1</b>. The value 0 indicates that Enable HTTP/2 is turned off. The value 1 indicates that Enable HTTP/2 is turned on.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Https2http&quot;:0,&quot;Http2&quot;:0,&quot;Http2https&quot;:0}</para>
            /// </summary>
            [NameInMap("HttpsExt")]
            [Validation(Required=false)]
            public string HttpsExt { get; set; }

            /// <summary>
            /// <para>The IDs of the instances to which the domain name is added.</para>
            /// </summary>
            [NameInMap("InstanceIds")]
            [Validation(Required=false)]
            public List<string> InstanceIds { get; set; }

            /// <summary>
            /// <para>Indicates whether the Online Certificate Status Protocol (OCSP) feature is turned on. Valid values:</para>
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
            /// <para>The scheduling algorithm for back-to-origin traffic. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ip_hash</b>: the IP hash algorithm. This algorithm is used to redirect the requests from the same IP address to the same origin server.</description></item>
            /// <item><description><b>rr</b>: the round-robin algorithm. This algorithm is used to redirect requests to origin servers in turn.</description></item>
            /// <item><description><b>least_time</b>: the least response time algorithm. This algorithm is used to minimize the latency when requests are forwarded from the instance to origin servers based on the intelligent DNS resolution feature.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ip_hash</para>
            /// </summary>
            [NameInMap("PolicyMode")]
            [Validation(Required=false)]
            public string PolicyMode { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance forwards the traffic that is destined for the website. Valid values:</para>
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
            /// <para>The details about the protocol type and port number.</para>
            /// </summary>
            [NameInMap("ProxyTypes")]
            [Validation(Required=false)]
            public List<DescribeDomainResourceResponseBodyWebRulesProxyTypes> ProxyTypes { get; set; }
            public class DescribeDomainResourceResponseBodyWebRulesProxyTypes : TeaModel {
                /// <summary>
                /// <para>The port numbers.</para>
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
                /// <para>http</para>
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
            /// <item><description><b>true</b>: The domain name is invalid. You can view the specific reasons from the <b>PunishReason</b> parameter.</description></item>
            /// <item><description><b>false</b>: The domain name is valid.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("PunishStatus")]
            [Validation(Required=false)]
            public bool? PunishStatus { get; set; }

            /// <summary>
            /// <para>The addresses of origin servers.</para>
            /// </summary>
            [NameInMap("RealServers")]
            [Validation(Required=false)]
            public List<string> RealServers { get; set; }

            /// <summary>
            /// <para>The address type of the origin server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: IP address</description></item>
            /// <item><description><b>1</b>: domain name</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RsType")]
            [Validation(Required=false)]
            public int? RsType { get; set; }

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
            /// <item><description><b>default</b>: custom cipher suite</description></item>
            /// <item><description><b>all</b>: all cipher suites</description></item>
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
            /// <para>The version of the TLS protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>tls1.0</b>: TLS 1.0 or later</description></item>
            /// <item><description><b>tls1.1</b>: TLS 1.1 or later</description></item>
            /// <item><description><b>tls1.2</b>: TLS 1.2 or later</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tls1.0</para>
            /// </summary>
            [NameInMap("SslProtocols")]
            [Validation(Required=false)]
            public string SslProtocols { get; set; }

            /// <summary>
            /// <para>The IP addresses that are included in the whitelist of the domain name.</para>
            /// </summary>
            [NameInMap("WhiteList")]
            [Validation(Required=false)]
            public List<string> WhiteList { get; set; }

        }

    }

}
