// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudResourcesResponseBody : TeaModel {
        /// <summary>
        /// The domain names.
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<DescribeHybridCloudResourcesResponseBodyDomains> Domains { get; set; }
        public class DescribeHybridCloudResourcesResponseBodyDomains : TeaModel {
            /// <summary>
            /// The CNAME that is assigned by WAF to the domain name.
            /// 
            /// > This parameter is returned only if you set **CnameEnabled** to true.
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// The domain name.
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The access ID.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The configurations of the listeners.
            /// </summary>
            [NameInMap("Listen")]
            [Validation(Required=false)]
            public DescribeHybridCloudResourcesResponseBodyDomainsListen Listen { get; set; }
            public class DescribeHybridCloudResourcesResponseBodyDomainsListen : TeaModel {
                /// <summary>
                /// The ID of the certificate.
                /// </summary>
                [NameInMap("CertId")]
                [Validation(Required=false)]
                public string CertId { get; set; }

                /// <summary>
                /// The types of cipher suites that are added. Valid values:
                /// 
                /// *   **1:** all cipher suites.
                /// *   **2:** strong cipher suites.
                /// *   **99:** custom cipher suites.
                /// </summary>
                [NameInMap("CipherSuite")]
                [Validation(Required=false)]
                public int? CipherSuite { get; set; }

                /// <summary>
                /// The custom cipher suites.
                /// 
                /// > This parameter is returned only if the value of **CipherSuite** is **99**.
                /// </summary>
                [NameInMap("CustomCiphers")]
                [Validation(Required=false)]
                public List<string> CustomCiphers { get; set; }

                /// <summary>
                /// Indicates whether TLS 1.3 is supported. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("EnableTLSv3")]
                [Validation(Required=false)]
                public bool? EnableTLSv3 { get; set; }

                /// <summary>
                /// Indicates whether exclusive IP addresses are supported. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("ExclusiveIp")]
                [Validation(Required=false)]
                public bool? ExclusiveIp { get; set; }

                /// <summary>
                /// Indicates whether the HTTP to HTTPS redirection feature is enabled for the domain name. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("FocusHttps")]
                [Validation(Required=false)]
                public bool? FocusHttps { get; set; }

                /// <summary>
                /// Indicates whether HTTP/2 is enabled. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("Http2Enabled")]
                [Validation(Required=false)]
                public bool? Http2Enabled { get; set; }

                /// <summary>
                /// The HTTP listener ports.
                /// </summary>
                [NameInMap("HttpPorts")]
                [Validation(Required=false)]
                public List<long?> HttpPorts { get; set; }

                /// <summary>
                /// The HTTPS listener ports.
                /// </summary>
                [NameInMap("HttpsPorts")]
                [Validation(Required=false)]
                public List<long?> HttpsPorts { get; set; }

                [NameInMap("IPv6Enabled")]
                [Validation(Required=false)]
                public bool? IPv6Enabled { get; set; }

                /// <summary>
                /// Indicates whether IPv6 is supported. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("Ipv6Enabled")]
                [Validation(Required=false)]
                public bool? Ipv6Enabled { get; set; }

                /// <summary>
                /// The type of the protection resource. Valid values:
                /// 
                /// *   **share:** shared cluster.
                /// *   **gslb:** shared cluster-based intelligent load balancing.
                /// </summary>
                [NameInMap("ProtectionResource")]
                [Validation(Required=false)]
                public string ProtectionResource { get; set; }

                /// <summary>
                /// The version of the Transport Layer Security (TLS) protocol. Valid values:
                /// 
                /// *   **tlsv1**
                /// *   **tlsv1.1**
                /// *   **tlsv1.2**
                /// </summary>
                [NameInMap("TLSVersion")]
                [Validation(Required=false)]
                public string TLSVersion { get; set; }

                /// <summary>
                /// The method that is used to obtain the actual IP address of a client. Valid values:
                /// 
                /// *   **0:** No Layer 7 proxies are deployed in front of WAF.
                /// *   **1:** WAF reads the first value of the X-Forwarded-For (XFF) header field as the actual IP address of the client.
                /// *   **2:** WAF reads the value of a custom header field as the actual IP address of the client.
                /// </summary>
                [NameInMap("XffHeaderMode")]
                [Validation(Required=false)]
                public int? XffHeaderMode { get; set; }

                /// <summary>
                /// The custom header fields that are used to obtain the actual IP address of a client. The value is in the \["header1","header2",...] format.
                /// 
                /// > This parameter is returned only if the value of **XffHeaderMode** is 2.
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
            public DescribeHybridCloudResourcesResponseBodyDomainsRedirect Redirect { get; set; }
            public class DescribeHybridCloudResourcesResponseBodyDomainsRedirect : TeaModel {
                /// <summary>
                /// The back-to-origin IP addresses or domain names.
                /// </summary>
                [NameInMap("Backends")]
                [Validation(Required=false)]
                public List<string> Backends { get; set; }

                /// <summary>
                /// Indicates whether the public cloud disaster recovery feature is enabled. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("CnameEnabled")]
                [Validation(Required=false)]
                public bool? CnameEnabled { get; set; }

                /// <summary>
                /// The connection timeout period. Unit: seconds. Valid values: 5 to 120.
                /// </summary>
                [NameInMap("ConnectTimeout")]
                [Validation(Required=false)]
                public long? ConnectTimeout { get; set; }

                /// <summary>
                /// Indicates whether the HTTPS to HTTP redirection feature is enabled for back-to-origin requests. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("FocusHttpBackend")]
                [Validation(Required=false)]
                public bool? FocusHttpBackend { get; set; }

                /// <summary>
                /// Indicates whether the persistent connection feature is enabled. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("Keepalive")]
                [Validation(Required=false)]
                public bool? Keepalive { get; set; }

                /// <summary>
                /// The number of reused persistent connections. Valid values: 60 to 1000.
                /// 
                /// > This parameter indicates the number of reused persistent connections after you enable the persistent connection feature.
                /// </summary>
                [NameInMap("KeepaliveRequests")]
                [Validation(Required=false)]
                public long? KeepaliveRequests { get; set; }

                /// <summary>
                /// The timeout period of persistent connections that are in the Idle state. Unit: seconds. Valid values: 1 to 60. Default value: 15.
                /// 
                /// > This parameter indicates the period of time during which a reused persistent connection is allowed to remain in the Idle state before the persistent connection is released.
                /// </summary>
                [NameInMap("KeepaliveTimeout")]
                [Validation(Required=false)]
                public long? KeepaliveTimeout { get; set; }

                /// <summary>
                /// The load balancing algorithm that WAF uses to forward requests to the origin server. Valid values:
                /// 
                /// *   **ip_hash**
                /// *   **roundRobin**
                /// *   **leastTime**
                /// </summary>
                [NameInMap("Loadbalance")]
                [Validation(Required=false)]
                public string Loadbalance { get; set; }

                /// <summary>
                /// The read timeout period. Unit: seconds. Valid values: 5 to 1800.
                /// </summary>
                [NameInMap("ReadTimeout")]
                [Validation(Required=false)]
                public long? ReadTimeout { get; set; }

                /// <summary>
                /// The key-value pair that is used to mark the requests that pass through the WAF instance.
                /// </summary>
                [NameInMap("RequestHeaders")]
                [Validation(Required=false)]
                public List<DescribeHybridCloudResourcesResponseBodyDomainsRedirectRequestHeaders> RequestHeaders { get; set; }
                public class DescribeHybridCloudResourcesResponseBodyDomainsRedirectRequestHeaders : TeaModel {
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
                /// Indicates whether WAF retries to forward requests when requests fail to be forwarded to the origin server. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("Retry")]
                [Validation(Required=false)]
                public bool? Retry { get; set; }

                /// <summary>
                /// The forwarding rules that you configured for the domain name that you added to WAF in hybrid cloud mode. The value is a string that consists of JSON arrays. Each element in a JSON array is a JSON struct that contains the following fields:
                /// 
                /// *   **rs:** The back-to-origin IP addresses or CNAMEs. The value is of the ARRAY type.
                /// *   **location:** The name of the protection node. The value is of the STRING type.
                /// *   **locationId:** The ID of the protection node. The value is of the LONG type.
                /// </summary>
                [NameInMap("RoutingRules")]
                [Validation(Required=false)]
                public string RoutingRules { get; set; }

                /// <summary>
                /// Indicates whether the origin Server Name Indication (SNI) feature is enabled. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("SniEnabled")]
                [Validation(Required=false)]
                public bool? SniEnabled { get; set; }

                /// <summary>
                /// The value of the custom Server Name Indication (SNI) field. If the parameter is left empty, the value of the **Host** field in the request header is automatically used as the value of the SNI field.
                /// 
                /// > This parameter is returned only if the value of **SniEnabled** is **true**.
                /// </summary>
                [NameInMap("SniHost")]
                [Validation(Required=false)]
                public string SniHost { get; set; }

                /// <summary>
                /// The write timeout period. Unit: seconds. Valid values: 5 to 1800.
                /// </summary>
                [NameInMap("WriteTimeout")]
                [Validation(Required=false)]
                public long? WriteTimeout { get; set; }

            }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("ResourceManagerResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceManagerResourceGroupId { get; set; }

            /// <summary>
            /// The status of the domain name. Valid values:
            /// 
            /// *   **1:** The domain name is normal.
            /// *   **2:** The domain name is being created.
            /// *   **3:** The domain name is being modified.
            /// *   **4:** The domain name is being released.
            /// *   **5:** WAF no longer forwards traffic of the domain name.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The user ID.
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries that are returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
