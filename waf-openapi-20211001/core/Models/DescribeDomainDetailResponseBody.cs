// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDomainDetailResponseBody : TeaModel {
        /// <summary>
        /// The details of the SSL certificate.
        /// </summary>
        [NameInMap("CertDetail")]
        [Validation(Required=false)]
        public DescribeDomainDetailResponseBodyCertDetail CertDetail { get; set; }
        public class DescribeDomainDetailResponseBodyCertDetail : TeaModel {
            /// <summary>
            /// The domain name of your website.
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// The end of the validity period of the SSL certificate. The value is in the UNIX timestamp format. Unit: milliseconds.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The ID of the SSL certificate.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The name of the SSL certificate.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// All domain names that are bound to the certificate.
            /// </summary>
            [NameInMap("Sans")]
            [Validation(Required=false)]
            public List<string> Sans { get; set; }

            /// <summary>
            /// The beginning of the validity period of the SSL certificate. The value is in the UNIX timestamp format. Unit: milliseconds.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// The CNAME that is assigned by WAF to the domain name.
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
        /// The configurations of the listeners.
        /// </summary>
        [NameInMap("Listen")]
        [Validation(Required=false)]
        public DescribeDomainDetailResponseBodyListen Listen { get; set; }
        public class DescribeDomainDetailResponseBodyListen : TeaModel {
            /// <summary>
            /// The ID of the certificate.
            /// </summary>
            [NameInMap("CertId")]
            [Validation(Required=false)]
            public long? CertId { get; set; }

            /// <summary>
            /// The type of the cipher suites. Valid values:
            /// 
            /// *   **1:** all cipher suites.
            /// *   **2:** strong cipher suites.
            /// *   **99:** custom cipher suites.
            /// </summary>
            [NameInMap("CipherSuite")]
            [Validation(Required=false)]
            public long? CipherSuite { get; set; }

            /// <summary>
            /// An array of custom cipher suites.
            /// </summary>
            [NameInMap("CustomCiphers")]
            [Validation(Required=false)]
            public List<string> CustomCiphers { get; set; }

            /// <summary>
            /// Indicates whether TLS 1.3 is supported. Valid values:
            /// 
            /// *   **true:** TLS 1.3 is supported.
            /// *   **false:** TLS 1.3 is not supported.
            /// </summary>
            [NameInMap("EnableTLSv3")]
            [Validation(Required=false)]
            public bool? EnableTLSv3 { get; set; }

            /// <summary>
            /// Indicates whether an exclusive IP address is enabled. Valid values:
            /// 
            /// *   **true:** An exclusive IP address is enabled for the domain name.
            /// *   **false:** No exclusive IP addresses are enabled for the domain name.
            /// </summary>
            [NameInMap("ExclusiveIp")]
            [Validation(Required=false)]
            public bool? ExclusiveIp { get; set; }

            /// <summary>
            /// Indicates whether HTTP to HTTPS redirection is enabled for the domain name. Valid values:
            /// 
            /// *   **true:** HTTP to HTTPS redirection is enabled.
            /// *   **false:** HTTP to HTTPS redirection is disabled.
            /// </summary>
            [NameInMap("FocusHttps")]
            [Validation(Required=false)]
            public bool? FocusHttps { get; set; }

            /// <summary>
            /// Indicates whether HTTP/2 is enabled. Valid values:
            /// 
            /// *   **true:** HTTP/2 is enabled.
            /// *   **false:** HTTP/2 is disabled.
            /// </summary>
            [NameInMap("Http2Enabled")]
            [Validation(Required=false)]
            public bool? Http2Enabled { get; set; }

            /// <summary>
            /// An array of HTTP listener ports.
            /// </summary>
            [NameInMap("HttpPorts")]
            [Validation(Required=false)]
            public List<long?> HttpPorts { get; set; }

            /// <summary>
            /// An array of HTTPS listener ports.
            /// </summary>
            [NameInMap("HttpsPorts")]
            [Validation(Required=false)]
            public List<long?> HttpsPorts { get; set; }

            /// <summary>
            /// Indicates whether IPv6 is enabled. Valid values:
            /// 
            /// *   **true:** IPv6 is enabled.
            /// *   **false:** IPv6 is disabled.
            /// </summary>
            [NameInMap("IPv6Enabled")]
            [Validation(Required=false)]
            public bool? IPv6Enabled { get; set; }

            /// <summary>
            /// The type of protection resource that is used. Valid values:
            /// 
            /// *   **share:** shared cluster.
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
            public bool? SM2CertId { get; set; }

            [NameInMap("SM2Enabled")]
            [Validation(Required=false)]
            public bool? SM2Enabled { get; set; }

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
            /// The method that WAF uses to obtain the actual IP address of a client. Valid values:
            /// 
            /// *   **0:** No Layer 7 proxies are deployed in front of WAF.
            /// *   **1:** WAF reads the first value of the X-Forwarded-For (XFF) header field as the actual IP address of the client.
            /// *   **2:** WAF reads the value of a custom header field as the actual IP address of the client.
            /// </summary>
            [NameInMap("XffHeaderMode")]
            [Validation(Required=false)]
            public long? XffHeaderMode { get; set; }

            /// <summary>
            /// An array of custom header fields that are used to obtain the actual IP address of a client.
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
        public DescribeDomainDetailResponseBodyRedirect Redirect { get; set; }
        public class DescribeDomainDetailResponseBodyRedirect : TeaModel {
            /// <summary>
            /// An array of addresses of origin servers.
            /// </summary>
            [NameInMap("Backends")]
            [Validation(Required=false)]
            public List<DescribeDomainDetailResponseBodyRedirectBackends> Backends { get; set; }
            public class DescribeDomainDetailResponseBodyRedirectBackends : TeaModel {
                /// <summary>
                /// The IP address or domain name of the origin server.
                /// </summary>
                [NameInMap("Backend")]
                [Validation(Required=false)]
                public string Backend { get; set; }

            }

            /// <summary>
            /// The timeout period of the connection. Unit: seconds. Valid values: 5 to 120.
            /// </summary>
            [NameInMap("ConnectTimeout")]
            [Validation(Required=false)]
            public int? ConnectTimeout { get; set; }

            /// <summary>
            /// Indicates whether HTTPS to HTTP redirection is enabled for back-to-origin requests of the domain name. Valid values:
            /// 
            /// *   **true:** HTTPS to HTTP redirection for back-to-origin requests of the domain name is enabled.
            /// *   **false:** HTTPS to HTTP redirection for back-to-origin requests of the domain name is disabled.
            /// </summary>
            [NameInMap("FocusHttpBackend")]
            [Validation(Required=false)]
            public bool? FocusHttpBackend { get; set; }

            /// <summary>
            /// Indicates whether the persistent connection feature is enabled. Valid values:
            /// 
            /// *   **true:** The persistent connection feature is enabled. This is the default value.
            /// *   **false:** The persistent connection feature is disabled.
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
            /// The timeout period of persistent connections that are in the Idle state. Valid values: 1 to 60. Default value: 15. Unit: seconds.
            /// 
            /// >  This parameter specifies the period of time during which a reused persistent connection is allowed to remain in the Idle state before the persistent connection is released.
            /// </summary>
            [NameInMap("KeepaliveTimeout")]
            [Validation(Required=false)]
            public int? KeepaliveTimeout { get; set; }

            /// <summary>
            /// The load balancing algorithm that is used when WAF forwards requests to the origin server. Valid values:
            /// 
            /// *   **ip_hash:** the IP hash algorithm.
            /// *   **roundRobin:** the round-robin algorithm.
            /// *   **leastTime:** the least response time algorithm.
            /// </summary>
            [NameInMap("Loadbalance")]
            [Validation(Required=false)]
            public string Loadbalance { get; set; }

            /// <summary>
            /// The read timeout period. Unit: seconds. Valid values: 5 to 1800.
            /// </summary>
            [NameInMap("ReadTimeout")]
            [Validation(Required=false)]
            public int? ReadTimeout { get; set; }

            /// <summary>
            /// An array of key-value pairs that are used to mark the requests that pass through the WAF instance.
            /// </summary>
            [NameInMap("RequestHeaders")]
            [Validation(Required=false)]
            public List<DescribeDomainDetailResponseBodyRedirectRequestHeaders> RequestHeaders { get; set; }
            public class DescribeDomainDetailResponseBodyRedirectRequestHeaders : TeaModel {
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
            /// *   **true:** WAF retries to forward requests. This is the default value.
            /// *   **false:** WAF does not retry to forward requests.
            /// </summary>
            [NameInMap("Retry")]
            [Validation(Required=false)]
            public bool? Retry { get; set; }

            /// <summary>
            /// Indicates whether origin Server Name Indication (SNI) is enabled. Valid values:
            /// 
            /// *   **true:** Origin SNI is enabled.
            /// *   **false:** Origin SNI is disabled. This is the default value.
            /// </summary>
            [NameInMap("SniEnabled")]
            [Validation(Required=false)]
            public bool? SniEnabled { get; set; }

            /// <summary>
            /// The value of the custom SNI field.
            /// </summary>
            [NameInMap("SniHost")]
            [Validation(Required=false)]
            public string SniHost { get; set; }

            /// <summary>
            /// The write timeout period. Unit: seconds. Valid values: 5 to 1800.
            /// </summary>
            [NameInMap("WriteTimeout")]
            [Validation(Required=false)]
            public int? WriteTimeout { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// The information about the SM certificate.
        /// </summary>
        [NameInMap("SM2CertDetail")]
        [Validation(Required=false)]
        public DescribeDomainDetailResponseBodySM2CertDetail SM2CertDetail { get; set; }
        public class DescribeDomainDetailResponseBodySM2CertDetail : TeaModel {
            /// <summary>
            /// The domain name of your website.
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// The end of the validity period of the SSL certificate. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The ID of the SSL certificate.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The name of the SSL certificate.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// All domain names that are bound to the certificate.
            /// </summary>
            [NameInMap("Sans")]
            [Validation(Required=false)]
            public List<string> Sans { get; set; }

            /// <summary>
            /// The beginning of the validity period of the SSL certificate. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// The status of the domain name. Valid values:
        /// 
        /// *   **1:** The domain name is in a normal state.
        /// *   **2:** The domain name is being created.
        /// *   **3:** The domain name is being modified.
        /// *   **4:** The domain name is being released.
        /// *   **5:** WAF no longer forwards traffic of the domain name.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

    }

}
