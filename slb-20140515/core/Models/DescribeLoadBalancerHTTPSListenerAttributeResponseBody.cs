// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeLoadBalancerHTTPSListenerAttributeResponseBody : TeaModel {
        /// <summary>
        /// The ID of the network ACL that is associated with a listener.
        /// 
        /// > This parameter is required when **AclStatus** is set to **on**.
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        [NameInMap("AclIds")]
        [Validation(Required=false)]
        public DescribeLoadBalancerHTTPSListenerAttributeResponseBodyAclIds AclIds { get; set; }
        public class DescribeLoadBalancerHTTPSListenerAttributeResponseBodyAclIds : TeaModel {
            [NameInMap("AclId")]
            [Validation(Required=false)]
            public List<string> AclId { get; set; }

        }

        /// <summary>
        /// Indicates whether access control is enabled. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("AclStatus")]
        [Validation(Required=false)]
        public string AclStatus { get; set; }

        /// <summary>
        /// The type of the access control list (ACL). Valid values:
        /// 
        /// *   **white**: a whitelist. Only requests from the IP addresses or CIDR blocks in the ACL are forwarded. Whitelists apply to scenarios where you want to allow only specific IP addresses to access an application. Your service may be adversely affected if the whitelist is not properly configured. If a whitelist is configured, only requests from IP addresses that are added to the whitelist are forwarded by the listener.
        /// 
        /// If you enable a whitelist but do not add an IP address to the ACL, the listener forwards all requests.
        /// 
        /// *   **black**: a blacklist. All requests from the IP addresses or CIDR blocks in the network ACL are rejected. Blacklists apply to scenarios where you want to block access from specified IP addresses to an application.
        /// 
        /// If a blacklist is configured for a listener but no IP address is added to the blacklist, the listener forwards all requests.
        /// 
        /// > This parameter is required when **AclStatus** is set to **on**.
        /// </summary>
        [NameInMap("AclType")]
        [Validation(Required=false)]
        public string AclType { get; set; }

        /// <summary>
        /// The backend port that is used by the CLB instance.
        /// </summary>
        [NameInMap("BackendServerPort")]
        [Validation(Required=false)]
        public int? BackendServerPort { get; set; }

        /// <summary>
        /// The maximum bandwidth of the listener. Unit: Mbit/s.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// The ID of the certification authority (CA) certificate.
        /// </summary>
        [NameInMap("CACertificateId")]
        [Validation(Required=false)]
        public string CACertificateId { get; set; }

        /// <summary>
        /// The cookie that is configured on the server.
        /// </summary>
        [NameInMap("Cookie")]
        [Validation(Required=false)]
        public string Cookie { get; set; }

        /// <summary>
        /// The timeout period of a cookie.
        /// </summary>
        [NameInMap("CookieTimeout")]
        [Validation(Required=false)]
        public int? CookieTimeout { get; set; }

        /// <summary>
        /// The name of the listener.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// A list of additional certificates.
        /// </summary>
        [NameInMap("DomainExtensions")]
        [Validation(Required=false)]
        public DescribeLoadBalancerHTTPSListenerAttributeResponseBodyDomainExtensions DomainExtensions { get; set; }
        public class DescribeLoadBalancerHTTPSListenerAttributeResponseBodyDomainExtensions : TeaModel {
            [NameInMap("DomainExtension")]
            [Validation(Required=false)]
            public List<DescribeLoadBalancerHTTPSListenerAttributeResponseBodyDomainExtensionsDomainExtension> DomainExtension { get; set; }
            public class DescribeLoadBalancerHTTPSListenerAttributeResponseBodyDomainExtensionsDomainExtension : TeaModel {
                /// <summary>
                /// The endpoint.
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// The ID of the additional domain name.
                /// </summary>
                [NameInMap("DomainExtensionId")]
                [Validation(Required=false)]
                public string DomainExtensionId { get; set; }

                /// <summary>
                /// The ID of the server certificate that is associated with the domain name.
                /// </summary>
                [NameInMap("ServerCertificateId")]
                [Validation(Required=false)]
                public string ServerCertificateId { get; set; }

            }

        }

        /// <summary>
        /// Indicates whether `HTTP/2` is used. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("EnableHttp2")]
        [Validation(Required=false)]
        public string EnableHttp2 { get; set; }

        /// <summary>
        /// Indicates whether `Gzip` compression is enabled. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("Gzip")]
        [Validation(Required=false)]
        public string Gzip { get; set; }

        /// <summary>
        /// Indicates whether the health check feature is enabled. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("HealthCheck")]
        [Validation(Required=false)]
        public string HealthCheck { get; set; }

        /// <summary>
        /// The port that is used for health checks.
        /// 
        /// > This parameter is required when **HealthCheck** is set to **on**.
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// The domain name that you want to use for health checks.
        /// </summary>
        [NameInMap("HealthCheckDomain")]
        [Validation(Required=false)]
        public string HealthCheckDomain { get; set; }

        /// <summary>
        /// The HTTP status code for a successful health check.
        /// </summary>
        [NameInMap("HealthCheckHttpCode")]
        [Validation(Required=false)]
        public string HealthCheckHttpCode { get; set; }

        /// <summary>
        /// The interval at which health checks are performed. Unit: seconds.
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// The health check method used by HTTP listeners. Valid values: **head** and **get**.
        /// 
        /// > This parameter is available only when **HealthCheck** is set to **on**.
        /// </summary>
        [NameInMap("HealthCheckMethod")]
        [Validation(Required=false)]
        public string HealthCheckMethod { get; set; }

        /// <summary>
        /// The maximum timeout period of a health check. Unit: seconds.
        /// </summary>
        [NameInMap("HealthCheckTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckTimeout { get; set; }

        /// <summary>
        /// The URL path that is used for health checks.
        /// </summary>
        [NameInMap("HealthCheckURI")]
        [Validation(Required=false)]
        public string HealthCheckURI { get; set; }

        /// <summary>
        /// The healthy threshold.
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// The timeout period of an idle connection. Valid values: **1** to **60**. Default value: **15**. Unit: seconds.
        /// 
        /// If no request is received within the specified timeout period, CLB closes the connection. When a request is received, CLB establishes a new connection.
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// The frontend port that is used by the CLB instance.
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// The CLB instance ID.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The timeout period of a request. Valid values: **1** to **180**. Default value: **60**. Unit: seconds.
        /// 
        /// If no response is received from a backend server within the specified timeout period, CLB returns the HTTP 504 status code to the client.
        /// </summary>
        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// The list of forwarding rules that are associated with the listener.
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public DescribeLoadBalancerHTTPSListenerAttributeResponseBodyRules Rules { get; set; }
        public class DescribeLoadBalancerHTTPSListenerAttributeResponseBodyRules : TeaModel {
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public List<DescribeLoadBalancerHTTPSListenerAttributeResponseBodyRulesRule> Rule { get; set; }
            public class DescribeLoadBalancerHTTPSListenerAttributeResponseBodyRulesRule : TeaModel {
                /// <summary>
                /// The endpoint.
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// The ID of the forwarding rule.
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// The name of the forwarding rule.
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// The request path.
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// The ID of the server group that is associated with the forwarding rule.
                /// </summary>
                [NameInMap("VServerGroupId")]
                [Validation(Required=false)]
                public string VServerGroupId { get; set; }

            }

        }

        /// <summary>
        /// The routing algorithm. Valid values: **wrr** and **rr**.
        /// 
        /// *   **wrr**: Backend servers that have higher weights receive more requests than backend servers that have lower weights.
        /// *   **rr**: Requests are distributed to backend servers in sequence.
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// Indicates whether the listener is in the Secure state. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("SecurityStatus")]
        [Validation(Required=false)]
        public string SecurityStatus { get; set; }

        /// <summary>
        /// The ID of the server certificate.
        /// </summary>
        [NameInMap("ServerCertificateId")]
        [Validation(Required=false)]
        public string ServerCertificateId { get; set; }

        /// <summary>
        /// The status of the listener. Valid values:
        /// 
        /// *   **running**
        /// *   **stopped**
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// Indicates whether session persistence is enabled. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("StickySession")]
        [Validation(Required=false)]
        public string StickySession { get; set; }

        /// <summary>
        /// The method that is used to handle a cookie.
        /// 
        /// Valid values: **insert** and **server**.
        /// 
        /// *   **insert**: inserts a cookie.
        /// 
        ///     CLB inserts a cookie (SERVERID) into the first HTTP or HTTPS response packet that is sent to a client. The next request from the client will contain this cookie, and the listener will distribute this request to the recorded backend server.
        /// 
        /// *   **server**: rewrites a cookie.
        /// 
        ///     When CLB detects a user-defined cookie, it overwrites the original cookie with the user-defined cookie. The next request from the client carries the user-defined cookie, and the listener will distribute the request to the recorded backend server.
        /// </summary>
        [NameInMap("StickySessionType")]
        [Validation(Required=false)]
        public string StickySessionType { get; set; }

        /// <summary>
        /// The Transport Layer Security (TLS) security policy for a high-performance CLB instance.
        /// 
        /// Each security policy contains TLS protocol versions and cipher suites available for HTTPS. Valid values:
        /// 
        /// *   **tls_cipher_policy_1_0**:
        /// 
        ///     Supported TLS versions: TLS 1.0, TLS 1.1, and TLS 1.2
        /// 
        ///     Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA
        /// 
        /// *   **tls_cipher_policy_1_1**:
        /// 
        ///     Supported TLS versions: TLS 1.1 and TLS 1.2
        /// 
        ///     Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA
        /// 
        /// *   **tls_cipher_policy_1_2**
        /// 
        ///     Supported TLS version: TLS 1.2
        /// 
        ///     Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA
        /// 
        /// *   **tls_cipher_policy_1_2_strict**
        /// 
        ///     Supported TLS version: TLS 1.2
        /// 
        ///     Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA
        /// 
        /// *   **tls_cipher_policy_1_2_strict_with_1_3**
        /// 
        ///     Supported TLS versions: TLS 1.2 and TLS 1.3
        /// 
        ///     Supported cipher suites: TLS_AES_128_GCM_SHA256, TLS_AES_256_GCM_SHA384, TLS_CHACHA20_POLY1305_SHA256, TLS_AES_128_CCM_SHA256, TLS_AES_128_CCM_8_SHA256, ECDHE-ECDSA-AES128-GCM-SHA256, ECDHE-ECDSA-AES256-GCM-SHA384, ECDHE-ECDSA-AES128-SHA256, ECDHE-ECDSA-AES256-SHA384, ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-ECDSA-AES128-SHA, ECDHE-ECDSA-AES256-SHA, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA
        /// </summary>
        [NameInMap("TLSCipherPolicy")]
        [Validation(Required=false)]
        public string TLSCipherPolicy { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeLoadBalancerHTTPSListenerAttributeResponseBodyTags Tags { get; set; }
        public class DescribeLoadBalancerHTTPSListenerAttributeResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeLoadBalancerHTTPSListenerAttributeResponseBodyTagsTag> Tag { get; set; }
            public class DescribeLoadBalancerHTTPSListenerAttributeResponseBodyTagsTag : TeaModel {
                /// <summary>
                /// The key of tag N. Valid values of N: **1** to **20**. The tag key cannot be an empty string. The tag key can be up to 64 characters in length, and cannot start with `aliyun` or `acs:`. The tag key cannot contain `http://` or `https://`.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The value of tag N. Valid values of N: **1** to **20**. The tag value can be an empty string. The tag value can be up to 128 characters in length, and cannot start with `acs:`. The tag value cannot contain `http://` or `https://`.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// The unhealthy threshold.
        /// </summary>
        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

        /// <summary>
        /// The ID of the associated server group.
        /// </summary>
        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

        /// <summary>
        /// Indicates whether the `X-Forwarded-For` header is used to retrieve client IP addresses. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("XForwardedFor")]
        [Validation(Required=false)]
        public string XForwardedFor { get; set; }

        /// <summary>
        /// Indicates whether the `XForwardedFor_ClientCertClientVerify` header is used to retrieve the verification result of the client certificate. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("XForwardedFor_ClientCertClientVerify")]
        [Validation(Required=false)]
        public string XForwardedFor_ClientCertClientVerify { get; set; }

        /// <summary>
        /// Indicates whether the `XForwardedFor_ClientCertFingerprint` header is used to retrieve the fingerprint of the client certificate. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("XForwardedFor_ClientCertFingerprint")]
        [Validation(Required=false)]
        public string XForwardedFor_ClientCertFingerprint { get; set; }

        /// <summary>
        /// Indicates whether the `XForwardedFor_ClientCertIssuerDN` header is used to retrieve information about the authority that issues the client certificate. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("XForwardedFor_ClientCertIssuerDN")]
        [Validation(Required=false)]
        public string XForwardedFor_ClientCertIssuerDN { get; set; }

        /// <summary>
        /// Indicates whether the `XForwardedFor_ClientCertSubjectDN` header is used to retrieve information about the owner of the client certificate. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("XForwardedFor_ClientCertSubjectDN")]
        [Validation(Required=false)]
        public string XForwardedFor_ClientCertSubjectDN { get; set; }

        /// <summary>
        /// Indicates whether the `XForwardedFor_ClientSrcPort` header is used to retrieve the client port. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("XForwardedFor_ClientSrcPort")]
        [Validation(Required=false)]
        public string XForwardedFor_ClientSrcPort { get; set; }

        /// <summary>
        /// Indicates whether the `SLB-ID` header is used to retrieve the ID of the ALB instance. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("XForwardedFor_SLBID")]
        [Validation(Required=false)]
        public string XForwardedFor_SLBID { get; set; }

        /// <summary>
        /// Indicates whether the `SLB-IP` header is used to retrieve the virtual IP address requested by the client. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("XForwardedFor_SLBIP")]
        [Validation(Required=false)]
        public string XForwardedFor_SLBIP { get; set; }

        /// <summary>
        /// Indicates whether the `XForwardedFor_SLBPORT` header is used to retrieve the listening port. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("XForwardedFor_SLBPORT")]
        [Validation(Required=false)]
        public string XForwardedFor_SLBPORT { get; set; }

        /// <summary>
        /// Indicates whether the `X-Forwarded-Proto` header is used to retrieve the listener protocol. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("XForwardedFor_proto")]
        [Validation(Required=false)]
        public string XForwardedFor_proto { get; set; }

    }

}
