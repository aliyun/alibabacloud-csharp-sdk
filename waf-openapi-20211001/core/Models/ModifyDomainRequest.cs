// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyDomainRequest : TeaModel {
        /// <summary>
        /// The mode in which you want to add the domain name to WAF. Set the value to share.
        /// 
        /// *   **share:** adds the domain name to WAF in CNAME record mode. This is the default value.
        /// </summary>
        [NameInMap("AccessType")]
        [Validation(Required=false)]
        public string AccessType { get; set; }

        /// <summary>
        /// The domain name whose access configurations you want to modify.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The ID of the WAF instance.
        /// 
        /// >  You can call the [DescribeInstance](~~433756~~) operation to obtain the ID of the WAF instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The configurations of the listeners.
        /// </summary>
        [NameInMap("Listen")]
        [Validation(Required=false)]
        public ModifyDomainRequestListen Listen { get; set; }
        public class ModifyDomainRequestListen : TeaModel {
            /// <summary>
            /// The ID of the certificate that you want to add.
            /// </summary>
            [NameInMap("CertId")]
            [Validation(Required=false)]
            public string CertId { get; set; }

            /// <summary>
            /// The type of cipher suite that you want to add. This parameter is available only when you specify the **HttpsPorts** parameter. Valid values:
            /// 
            /// *   **1:** all cipher suites.
            /// *   **2:** strong cipher suites. You can select this value only when you set the **TLSVersion** parameter to **tlsv1.2**.
            /// *   **99:** custom cipher suites.
            /// </summary>
            [NameInMap("CipherSuite")]
            [Validation(Required=false)]
            public int? CipherSuite { get; set; }

            /// <summary>
            /// The custom cipher suites that you want to add. This parameter is available only when you set the **CipherSuite** parameter to **99**.
            /// </summary>
            [NameInMap("CustomCiphers")]
            [Validation(Required=false)]
            public List<string> CustomCiphers { get; set; }

            /// <summary>
            /// Specifies whether to support TLS 1.3. This parameter is available only when you specify the **HttpsPorts** parameter. Valid values:
            /// 
            /// *   **true:** supports TLS 1.3.
            /// *   **false:** does not support TLS 1.3.
            /// </summary>
            [NameInMap("EnableTLSv3")]
            [Validation(Required=false)]
            public bool? EnableTLSv3 { get; set; }

            /// <summary>
            /// Specifies whether to enable an exclusive IP address for the domain name. This parameter is available only when you set the **IPv6Enabled** parameter to false and the **ProtectionResource** parameter to **share**. Valid values:
            /// 
            /// *   **true:** enables an exclusive IP address for the domain name.
            /// *   **false:** does not enable an exclusive IP address for the domain name. This is the default value.
            /// </summary>
            [NameInMap("ExclusiveIp")]
            [Validation(Required=false)]
            public bool? ExclusiveIp { get; set; }

            /// <summary>
            /// Specifies whether to enable HTTP to HTTPS redirection for the domain name. This parameter is available only when you specify the **HttpsPorts** parameter and leave the **HttpPorts** parameter empty. Valid values:
            /// 
            /// *   **true:** enables HTTP to HTTPS redirection.
            /// *   **false:** disables HTTP to HTTPS redirection.
            /// </summary>
            [NameInMap("FocusHttps")]
            [Validation(Required=false)]
            public bool? FocusHttps { get; set; }

            /// <summary>
            /// Specifies whether to enable HTTP/2. This parameter is available only when you specify the **HttpsPorts** parameter. Valid values:
            /// 
            /// *   **true:** enables HTTP/2.
            /// *   **false:** disables HTTP/2. This is the default value.
            /// </summary>
            [NameInMap("Http2Enabled")]
            [Validation(Required=false)]
            public bool? Http2Enabled { get; set; }

            /// <summary>
            /// An array of HTTP listener ports. Specify the value of this parameter in the \[port1,port2,...] format.
            /// </summary>
            [NameInMap("HttpPorts")]
            [Validation(Required=false)]
            public List<int?> HttpPorts { get; set; }

            /// <summary>
            /// An array of HTTPS listener ports. Specify the value of this parameter in the \[port1,port2,...] format.
            /// </summary>
            [NameInMap("HttpsPorts")]
            [Validation(Required=false)]
            public List<int?> HttpsPorts { get; set; }

            /// <summary>
            /// Specifies whether to enable IPv6. Valid values:
            /// 
            /// *   **true:** enables IPv6.
            /// *   **false:** disables IPv6. This is the default value.
            /// </summary>
            [NameInMap("IPv6Enabled")]
            [Validation(Required=false)]
            public bool? IPv6Enabled { get; set; }

            /// <summary>
            /// The type of the protection resource that you want to use. Valid values:
            /// 
            /// *   **share:** shared cluster. This is the default value.
            /// *   **gslb:** shared cluster-based intelligent load balancing.
            /// </summary>
            [NameInMap("ProtectionResource")]
            [Validation(Required=false)]
            public string ProtectionResource { get; set; }

            [NameInMap("SM2AccessOnly")]
            [Validation(Required=false)]
            public bool? SM2AccessOnly { get; set; }

            [NameInMap("SM2CertId")]
            [Validation(Required=false)]
            public string SM2CertId { get; set; }

            [NameInMap("SM2Enabled")]
            [Validation(Required=false)]
            public bool? SM2Enabled { get; set; }

            /// <summary>
            /// The version of the Transport Layer Security (TLS) protocol. This parameter is available only when you specify the **HttpsPorts** parameter. Valid values:
            /// 
            /// *   **tlsv1**
            /// *   **tlsv1.1**
            /// *   **tlsv1.2**
            /// </summary>
            [NameInMap("TLSVersion")]
            [Validation(Required=false)]
            public string TLSVersion { get; set; }

            /// <summary>
            /// The method that you want WAF to use to obtain the actual IP address of a client. Valid values:
            /// 
            /// *   **0:** No Layer 7 proxies are deployed in front of WAF. This is the default value.
            /// *   **1:** WAF reads the first value of the X-Forwarded-For (XFF) header field as the actual IP address of the client.
            /// *   **2:** WAF reads the value of a custom header field as the actual IP address of the client.
            /// </summary>
            [NameInMap("XffHeaderMode")]
            [Validation(Required=false)]
            public int? XffHeaderMode { get; set; }

            /// <summary>
            /// The custom header fields that you want to use to obtain the actual IP address of a client. Specify the value of this parameter in the \["header1","header2",...] format.
            /// 
            /// >  If you set the **XffHeaderMode** parameter to 2, this parameter is required.
            /// </summary>
            [NameInMap("XffHeaders")]
            [Validation(Required=false)]
            public List<string> XffHeaders { get; set; }

        }

        /// <summary>
        /// The configurations of the forwarding rule.
        /// </summary>
        [NameInMap("Redirect")]
        [Validation(Required=false)]
        public ModifyDomainRequestRedirect Redirect { get; set; }
        public class ModifyDomainRequestRedirect : TeaModel {
            /// <summary>
            /// An array of the IP addresses or domain names of the origin servers. You can specify only one type of address. If you use the domain name type, only IPv4 is supported.
            /// 
            /// *   If you use the IP address type, specify the value of this parameter in the \["ip1","ip2",...] format. You can add up to 20 IP addresses.
            /// *   If you use the domain name type, specify the value of this parameter in the \["domain"] format. You can add up to 20 domain names.
            /// </summary>
            [NameInMap("Backends")]
            [Validation(Required=false)]
            public List<string> Backends { get; set; }

            /// <summary>
            /// 是否开启公共云容灾。取值：
            /// 
            /// - **true**：表示开启公共云容灾。
            /// 
            /// - **false**（默认）：表示不开启公共云容灾。
            /// </summary>
            [NameInMap("CnameEnabled")]
            [Validation(Required=false)]
            public bool? CnameEnabled { get; set; }

            /// <summary>
            /// The connection timeout period. Unit: seconds. Valid values: 1 to 3600.
            /// </summary>
            [NameInMap("ConnectTimeout")]
            [Validation(Required=false)]
            public int? ConnectTimeout { get; set; }

            /// <summary>
            /// Specifies whether to enable HTTPS to HTTP redirection for back-to-origin requests of the domain name. This parameter is available only when you specify the **HttpsPorts** parameter. Valid values:
            /// 
            /// *   **true:** enables HTTPS to HTTP redirection for back-to-origin requests of the domain name.
            /// *   **false:** disables HTTPS to HTTP redirection for back-to-origin requests of the domain name.
            /// </summary>
            [NameInMap("FocusHttpBackend")]
            [Validation(Required=false)]
            public bool? FocusHttpBackend { get; set; }

            /// <summary>
            /// Specifies whether to enable the persistent connection feature. Valid values:
            /// 
            /// *   **true:** enables the persistent connection feature. This is the default value.
            /// *   **false:** disables the persistent connection feature.
            /// </summary>
            [NameInMap("Keepalive")]
            [Validation(Required=false)]
            public bool? Keepalive { get; set; }

            /// <summary>
            /// The number of reused persistent connections. Valid values: 60 to 1000.
            /// 
            /// >  This parameter specifies the number of reused persistent connections when you enable the persistent connection feature.
            /// </summary>
            [NameInMap("KeepaliveRequests")]
            [Validation(Required=false)]
            public int? KeepaliveRequests { get; set; }

            /// <summary>
            /// The timeout period of persistent connections that are in the Idle state. Unit: seconds. Valid values: 1 to 60. Default value: 15.
            /// 
            /// >  This parameter specifies the period of time during which a reused persistent connection is allowed to remain in the Idle state before the persistent connection is released.
            /// </summary>
            [NameInMap("KeepaliveTimeout")]
            [Validation(Required=false)]
            public int? KeepaliveTimeout { get; set; }

            /// <summary>
            /// The load balancing algorithm that you want to use when WAF forwards requests to the origin server. Valid values:
            /// 
            /// *   **ip_hash:** the IP hash algorithm.
            /// *   **roundRobin:** the round-robin algorithm.
            /// *   **leastTime:** the least response time algorithm. You can select this value only when you set the **ProtectionResource** parameter to **gslb**.
            /// </summary>
            [NameInMap("Loadbalance")]
            [Validation(Required=false)]
            public string Loadbalance { get; set; }

            /// <summary>
            /// The read timeout period. Unit: seconds. Valid values: 1 to 3600.
            /// </summary>
            [NameInMap("ReadTimeout")]
            [Validation(Required=false)]
            public int? ReadTimeout { get; set; }

            /// <summary>
            /// The key-value pairs that you want to use to mark the requests that pass through the WAF instance.
            /// 
            /// WAF automatically adds the key-value pairs to the request headers to identify the requests that pass through WAF.
            /// </summary>
            [NameInMap("RequestHeaders")]
            [Validation(Required=false)]
            public List<ModifyDomainRequestRedirectRequestHeaders> RequestHeaders { get; set; }
            public class ModifyDomainRequestRedirectRequestHeaders : TeaModel {
                /// <summary>
                /// The key of the custom header field.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of the custom header field.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// Specifies whether WAF retries to forward requests when requests fail to be forwarded to the origin server. Valid values:
            /// 
            /// *   **true:** WAF retries to forward requests. This is the default value.
            /// *   **false:** WAF does not retry to forward requests.
            /// </summary>
            [NameInMap("Retry")]
            [Validation(Required=false)]
            public bool? Retry { get; set; }

            /// <summary>
            /// 混合云转发规则。使用JSON数组转化的字符串格式表示。JSON数组中的每个元素是一个结构体，包含以下字段：
            /// - **rs**：Array类型 | 表示回源IP地址或者回源CNAME列表
            /// 
            /// - **location**：String类型 | 表示防护节点名称
            /// 
            /// - **locationId**：Long类型 | 表示防护节点ID
            /// </summary>
            [NameInMap("RoutingRules")]
            [Validation(Required=false)]
            public string RoutingRules { get; set; }

            /// <summary>
            /// Specifies whether to enable origin Server Name Indication (SNI). This parameter is available only when you specify the **HttpsPorts** parameter. Valid values:
            /// 
            /// *   **true:** enables origin SNI.
            /// *   **false:** disables origin SNI. This is the default value.
            /// </summary>
            [NameInMap("SniEnabled")]
            [Validation(Required=false)]
            public bool? SniEnabled { get; set; }

            /// <summary>
            /// The value of the custom SNI field. If you do not specify this parameter, the value of the **Host** field in the request header is automatically used. If you want WAF to use an SNI field value that is different from the value of the Host field in back-to-origin requests, you can specify a custom value for the SNI field.
            /// 
            /// >  If you set the **SniEnabled** parameter to true, this parameter is required.
            /// </summary>
            [NameInMap("SniHost")]
            [Validation(Required=false)]
            public string SniHost { get; set; }

            /// <summary>
            /// The write timeout period. Unit: seconds. Valid values: 1 to 3600.
            /// </summary>
            [NameInMap("WriteTimeout")]
            [Validation(Required=false)]
            public int? WriteTimeout { get; set; }

        }

        /// <summary>
        /// The region where the WAF instance resides. Valid values:
        /// 
        /// *   **cn-hangzhou:** the Chinese mainland.
        /// *   **ap-southeast-1:** outside the Chinese mainland.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The source IP address of the request. The value of this parameter is specified by the system.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
