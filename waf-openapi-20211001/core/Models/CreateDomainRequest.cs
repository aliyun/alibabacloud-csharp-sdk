// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateDomainRequest : TeaModel {
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
        /// The domain name that you want to add to WAF.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The ID of the Web Application Firewall (WAF) instance.
        /// 
        /// > You can call the [DescribeInstance](~~433756~~) operation to obtain the ID of the WAF instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The configurations of the listeners.
        /// </summary>
        [NameInMap("Listen")]
        [Validation(Required=false)]
        public CreateDomainRequestListen Listen { get; set; }
        public class CreateDomainRequestListen : TeaModel {
            /// <summary>
            /// The ID of the certificate that you want to add. This parameter is available only if you specify **HttpsPorts**.
            /// </summary>
            [NameInMap("CertId")]
            [Validation(Required=false)]
            public string CertId { get; set; }

            /// <summary>
            /// The type of cipher suite that you want to add. This parameter is available only if you specify **HttpsPorts**. Valid values:
            /// 
            /// *   **1:** all cipher suites.
            /// *   **2:** strong cipher suites. You can select this value only if you set **TLSVersion** to **tlsv1.2**.
            /// *   **99:** custom cipher suites.
            /// </summary>
            [NameInMap("CipherSuite")]
            [Validation(Required=false)]
            public int? CipherSuite { get; set; }

            /// <summary>
            /// The custom cipher suite that you want to add.
            /// </summary>
            [NameInMap("CustomCiphers")]
            [Validation(Required=false)]
            public List<string> CustomCiphers { get; set; }

            /// <summary>
            /// Specifies whether to support TLS 1.3. This parameter is available only if you specify **HttpsPorts**. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("EnableTLSv3")]
            [Validation(Required=false)]
            public bool? EnableTLSv3 { get; set; }

            /// <summary>
            /// Specifies whether to enable an exclusive IP address. This parameter is available only if you set **IPv6Enabled** to **false** and **ProtectionResource** to **share**. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// </summary>
            [NameInMap("ExclusiveIp")]
            [Validation(Required=false)]
            public bool? ExclusiveIp { get; set; }

            /// <summary>
            /// Specifies whether to enable HTTP to HTTPS redirection. This parameter is available only if you specify HttpsPorts and leave HttpPorts empty. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("FocusHttps")]
            [Validation(Required=false)]
            public bool? FocusHttps { get; set; }

            /// <summary>
            /// Specifies whether to enable HTTP/2. This parameter is available only if you specify **HttpsPorts**. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// </summary>
            [NameInMap("Http2Enabled")]
            [Validation(Required=false)]
            public bool? Http2Enabled { get; set; }

            /// <summary>
            /// The HTTP listener port.
            /// </summary>
            [NameInMap("HttpPorts")]
            [Validation(Required=false)]
            public List<int?> HttpPorts { get; set; }

            /// <summary>
            /// The HTTPS listener port.
            /// </summary>
            [NameInMap("HttpsPorts")]
            [Validation(Required=false)]
            public List<int?> HttpsPorts { get; set; }

            /// <summary>
            /// Specifies whether to enable IPv6. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// </summary>
            [NameInMap("IPv6Enabled")]
            [Validation(Required=false)]
            public bool? IPv6Enabled { get; set; }

            /// <summary>
            /// The type of the protection resource. Valid values:
            /// 
            /// *   **share:** a shared cluster. This is the default value.
            /// *   **gslb:** shared cluster-based intelligent load balancing.
            /// </summary>
            [NameInMap("ProtectionResource")]
            [Validation(Required=false)]
            public string ProtectionResource { get; set; }

            /// <summary>
            /// Specifies whether to allow access only from SM certificate-based clients. This parameter is available only if you set SM2Enabled to true.
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("SM2AccessOnly")]
            [Validation(Required=false)]
            public bool? SM2AccessOnly { get; set; }

            /// <summary>
            /// The ID of the SM certificate that you want to add. This parameter is available only if you set SM2Enabled to true.
            /// </summary>
            [NameInMap("SM2CertId")]
            [Validation(Required=false)]
            public string SM2CertId { get; set; }

            /// <summary>
            /// Specifies whether to enable the ShangMi (SM) certificate.
            /// </summary>
            [NameInMap("SM2Enabled")]
            [Validation(Required=false)]
            public bool? SM2Enabled { get; set; }

            /// <summary>
            /// The version of the Transport Layer Security (TLS) protocol. This parameter is available only if you specify **HttpsPorts**. Valid values:
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
            /// *   **1:** WAF reads the first value of the X-Forwarded-For (XFF) header field as the IP address of the client.
            /// *   **2:** WAF reads the value of a custom header field as the IP address of the client.
            /// </summary>
            [NameInMap("XffHeaderMode")]
            [Validation(Required=false)]
            public int? XffHeaderMode { get; set; }

            /// <summary>
            /// The custom header field that you want WAF to use to obtain the actual IP address of a client.
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
        public CreateDomainRequestRedirect Redirect { get; set; }
        public class CreateDomainRequestRedirect : TeaModel {
            /// <summary>
            /// The IP addresses or domain names of the origin server.
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
            /// The timeout period of connections. Unit: seconds. Valid values: 1 to 3600.
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
            /// >  This parameter specifies the number of reused persistent connections after you enable the persistent connection feature.
            /// </summary>
            [NameInMap("KeepaliveRequests")]
            [Validation(Required=false)]
            public int? KeepaliveRequests { get; set; }

            /// <summary>
            /// The timeout period of idle persistent connections. Valid values: 1 to 60. Default value: 15. Unit: seconds.
            /// 
            /// >  This parameter specifies the period of time during which a reused persistent connection is allowed to remain in the Idle state before the persistent connection is released.
            /// </summary>
            [NameInMap("KeepaliveTimeout")]
            [Validation(Required=false)]
            public int? KeepaliveTimeout { get; set; }

            /// <summary>
            /// The load balancing algorithm that you want to use to forward requests to the origin server. Valid values:
            /// 
            /// *   **iphash**
            /// *   **roundRobin**
            /// *   **leastTime** You can set the parameter to this value only if you set **ProtectionResource** to **gslb**.
            /// </summary>
            [NameInMap("Loadbalance")]
            [Validation(Required=false)]
            public string Loadbalance { get; set; }

            /// <summary>
            /// The timeout period of read connections. Unit: seconds. Valid values: 1 to 3600.
            /// </summary>
            [NameInMap("ReadTimeout")]
            [Validation(Required=false)]
            public int? ReadTimeout { get; set; }

            /// <summary>
            /// The custom header field that you want to use to label requests that are processed by WAF.
            /// 
            /// When a request passes through WAF, the custom header field is automatically used to label the request. This way, the backend service can identify requests that are processed by WAF.
            /// </summary>
            [NameInMap("RequestHeaders")]
            [Validation(Required=false)]
            public List<CreateDomainRequestRedirectRequestHeaders> RequestHeaders { get; set; }
            public class CreateDomainRequestRedirectRequestHeaders : TeaModel {
                /// <summary>
                /// The custom header field.
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
            /// Specifies whether WAF retries forwarding requests to the origin server when the requests fail to be forwarded to the origin server. Valid values:
            /// 
            /// *   **true** (default)
            /// *   **false**
            /// </summary>
            [NameInMap("Retry")]
            [Validation(Required=false)]
            public bool? Retry { get; set; }

            /// <summary>
            /// The forwarding rules that you want to configure for the domain name that you want to add to WAF in hybrid cloud mode. This parameter is a string that consists of JSON arrays. Each element in a JSON array is a JSON struct that contains the following fields:
            /// 
            /// *   **rs**: the back-to-origin IP addresses or CNAMEs. The value must be of the ARRAY type.
            /// *   **location**: the name of the protection node. The value must be of the STRING type.
            /// *   **locationId**: the ID of the protection node. The value must be of the LONG type.
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
            /// The value of the SNI field. If you do not specify this parameter, the value of the **Host** field is automatically used. This parameter is optional. If you want WAF to use an SNI field value that is different from the Host field value in back-to-origin requests, you can specify a custom value for the SNI field.
            /// 
            /// >  This parameter is required only if you set **SniEnalbed** to **true**.
            /// </summary>
            [NameInMap("SniHost")]
            [Validation(Required=false)]
            public string SniHost { get; set; }

            /// <summary>
            /// The timeout period of write connections. Unit: seconds. Valid values: 1 to 3600.
            /// </summary>
            [NameInMap("WriteTimeout")]
            [Validation(Required=false)]
            public int? WriteTimeout { get; set; }

            /// <summary>
            /// Indicates whether the X-Forward-For-Proto header is used to identify the protocol used by WAF to forward requests to the origin server. Valid values:
            /// 
            /// *   **true** (default)
            /// *   **false**
            /// </summary>
            [NameInMap("XffProto")]
            [Validation(Required=false)]
            public bool? XffProto { get; set; }

        }

        /// <summary>
        /// The region where the WAF instance resides. Valid values:
        /// 
        /// *   **cn-hangzhou**: the Chinese mainland
        /// *   **ap-southeast-1**: outside the Chinese mainland
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

    }

}
