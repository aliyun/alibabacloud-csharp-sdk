// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyDomainRequest : TeaModel {
        /// <summary>
        /// The mode in which you want to add the domain name to WAF. Valid values:
        /// 
        /// *   **share:** adds the domain name to WAF in CNAME record mode. This is the default value.
        /// *   **hybrid_cloud_cname:** adds the domain name to WAF in hybrid cloud reverse proxy mode.
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

            /// <summary>
            /// 是否仅客端访问。仅SM2Enable取值为true时，使用该参数。
            /// 
            /// - true：仅国密客户端才可以访问。
            /// 
            /// - false：国密和非国密均可以访问。
            /// </summary>
            [NameInMap("SM2AccessOnly")]
            [Validation(Required=false)]
            public bool? SM2AccessOnly { get; set; }

            /// <summary>
            /// 要添加的国密证书的ID。仅SM2Enable取值为true时，使用该参数。
            /// </summary>
            [NameInMap("SM2CertId")]
            [Validation(Required=false)]
            public string SM2CertId { get; set; }

            /// <summary>
            /// 是否开启国密证书
            /// </summary>
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
            /// The back-to-origin IP addresses or domain names. You can specify only one type of address. If you use the domain name type, only IPv4 is supported.
            /// 
            /// *   If you use the IP address type, specify the value of this parameter in the \["ip1","ip2",...] format. You can specify up to 20 IP addresses.
            /// *   If you use the domain name type, specify the value of this parameter in the \["domain"] format. You can specify up to 20 domain names.
            /// </summary>
            [NameInMap("Backends")]
            [Validation(Required=false)]
            public List<string> Backends { get; set; }

            /// <summary>
            /// Specifies whether to enable the public cloud disaster recovery feature. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
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
            /// Specifies whether to enable HTTPS to HTTP redirection for back-to-origin requests. This parameter is available only if you specify **HttpsPorts**. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("FocusHttpBackend")]
            [Validation(Required=false)]
            public bool? FocusHttpBackend { get; set; }

            /// <summary>
            /// Specifies whether to enable the persistent connection feature. Valid values:
            /// 
            /// *   **true** (default)
            /// *   **false**
            /// </summary>
            [NameInMap("Keepalive")]
            [Validation(Required=false)]
            public bool? Keepalive { get; set; }

            /// <summary>
            /// The number of reused persistent connections. Valid values: 60 to 1000.
            /// 
            /// > This parameter specifies the number of reused persistent connections after you enable the persistent connection feature.
            /// </summary>
            [NameInMap("KeepaliveRequests")]
            [Validation(Required=false)]
            public int? KeepaliveRequests { get; set; }

            /// <summary>
            /// The timeout period of persistent connections that are in the Idle state. Valid values: 1 to 60. Default value: 15. Unit: seconds.
            /// 
            /// > This parameter specifies the period of time during which a reused persistent connection remains in the Idle state before the persistent connection is released.
            /// </summary>
            [NameInMap("KeepaliveTimeout")]
            [Validation(Required=false)]
            public int? KeepaliveTimeout { get; set; }

            /// <summary>
            /// The load balancing algorithm that you want WAF to use to forward requests to the origin server. Valid values:
            /// 
            /// *   **ip_hash**
            /// *   **roundRobin**
            /// *   **leastTime**. You can select this value only if you set **ProtectionResource** to **gslb**.
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
            /// The key-value pairs that you want to use to mark the requests that are processed by WAF.
            /// 
            /// WAF automatically adds the key-value pairs to the request headers. This way, the backend service can identify the requests that are processed by WAF.
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
            /// *   **true** (default)
            /// *   **false**
            /// </summary>
            [NameInMap("Retry")]
            [Validation(Required=false)]
            public bool? Retry { get; set; }

            /// <summary>
            /// The forwarding rules that you want to configure for the domain name that you want to add to WAF in hybrid cloud mode. Set the value to a string that consists of JSON arrays. Each element in a JSON array must be a JSON struct that contains the following fields:
            /// 
            /// *   **rs:** The back-to-origin IP addresses or CNAMEs. The value must be of the ARRAY type.
            /// *   **location:** The name of the protection node. The value must be of the STRING type.
            /// *   **locationId:** The ID of the protection node. The value must be of the LONG type.
            /// </summary>
            [NameInMap("RoutingRules")]
            [Validation(Required=false)]
            public string RoutingRules { get; set; }

            /// <summary>
            /// Specifies whether to enable origin Server Name Indication (SNI). This parameter is available only if you specify **HttpsPorts**. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// </summary>
            [NameInMap("SniEnabled")]
            [Validation(Required=false)]
            public bool? SniEnabled { get; set; }

            /// <summary>
            /// The value of the custom SNI field. If you do not specify this parameter, the value of the **Host** field in the request header is automatically used. If you want WAF to use an SNI field value that is different from the value of the Host field in back-to-origin requests, you can specify a custom value for the SNI field.
            /// 
            /// > This parameter is required only if you set **SniEnabled** to true.
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

            [NameInMap("XffProto")]
            [Validation(Required=false)]
            public bool? XffProto { get; set; }

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
