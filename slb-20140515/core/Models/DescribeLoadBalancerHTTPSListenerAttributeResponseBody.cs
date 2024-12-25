// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeLoadBalancerHTTPSListenerAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the network ACL that is associated with a listener.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>AclStatus</b> is set to <b>on</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>nacl-a2do9e413e0spzasx****</para>
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
        /// <para>Indicates whether access control is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("AclStatus")]
        [Validation(Required=false)]
        public string AclStatus { get; set; }

        /// <summary>
        /// <para>The type of the access control list (ACL). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>white</b>: a whitelist. Only requests from the IP addresses or CIDR blocks in the ACL are forwarded. Whitelists apply to scenarios where you want to allow only specific IP addresses to access an application. Your service may be adversely affected if the whitelist is not properly configured. If a whitelist is configured, only requests from IP addresses that are added to the whitelist are forwarded by the listener.</description></item>
        /// </list>
        /// <para>If you enable a whitelist but do not add an IP address to the ACL, the listener forwards all requests.</para>
        /// <list type="bullet">
        /// <item><description><b>black</b>: a blacklist. All requests from the IP addresses or CIDR blocks in the network ACL are rejected. Blacklists apply to scenarios where you want to block access from specified IP addresses to an application.</description></item>
        /// </list>
        /// <para>If a blacklist is configured for a listener but no IP address is added to the blacklist, the listener forwards all requests.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>AclStatus</b> is set to <b>on</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>white</para>
        /// </summary>
        [NameInMap("AclType")]
        [Validation(Required=false)]
        public string AclType { get; set; }

        /// <summary>
        /// <para>The backend port that is used by the CLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("BackendServerPort")]
        [Validation(Required=false)]
        public int? BackendServerPort { get; set; }

        /// <summary>
        /// <para>The maximum bandwidth of the listener. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The ID of the certification authority (CA) certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idkp-234-cn-test-0**</para>
        /// </summary>
        [NameInMap("CACertificateId")]
        [Validation(Required=false)]
        public string CACertificateId { get; set; }

        /// <summary>
        /// <para>The cookie that is configured on the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B490B5EBF6F3CD402E515D22BCDA1598</para>
        /// </summary>
        [NameInMap("Cookie")]
        [Validation(Required=false)]
        public string Cookie { get; set; }

        /// <summary>
        /// <para>The timeout period of a cookie.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("CookieTimeout")]
        [Validation(Required=false)]
        public int? CookieTimeout { get; set; }

        /// <summary>
        /// <para>The name of the listener.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>A list of additional certificates.</para>
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
                /// <para>The endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">www.example.com</a></para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The ID of the additional domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("DomainExtensionId")]
                [Validation(Required=false)]
                public string DomainExtensionId { get; set; }

                /// <summary>
                /// <para>The ID of the server certificate that is associated with the domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13344444****</para>
                /// </summary>
                [NameInMap("ServerCertificateId")]
                [Validation(Required=false)]
                public string ServerCertificateId { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether <c>HTTP/2</c> is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("EnableHttp2")]
        [Validation(Required=false)]
        public string EnableHttp2 { get; set; }

        /// <summary>
        /// <para>Indicates whether <c>Gzip</c> compression is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Gzip")]
        [Validation(Required=false)]
        public string Gzip { get; set; }

        /// <summary>
        /// <para>Indicates whether the health check feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("HealthCheck")]
        [Validation(Required=false)]
        public string HealthCheck { get; set; }

        /// <summary>
        /// <para>The port that is used for health checks.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>HealthCheck</b> is set to <b>on</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// <para>The domain name that you want to use for health checks.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.test.com">www.test.com</a></para>
        /// </summary>
        [NameInMap("HealthCheckDomain")]
        [Validation(Required=false)]
        public string HealthCheckDomain { get; set; }

        /// <summary>
        /// <para>The HTTP status code for a successful health check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http_2xx,http_3xx</para>
        /// </summary>
        [NameInMap("HealthCheckHttpCode")]
        [Validation(Required=false)]
        public string HealthCheckHttpCode { get; set; }

        /// <summary>
        /// <para>The interval at which health checks are performed. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// <para>The health check method used by HTTP listeners. Valid values: <b>head</b> and <b>get</b>.</para>
        /// <remarks>
        /// <para>This parameter is available only when <b>HealthCheck</b> is set to <b>on</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>get</para>
        /// </summary>
        [NameInMap("HealthCheckMethod")]
        [Validation(Required=false)]
        public string HealthCheckMethod { get; set; }

        /// <summary>
        /// <para>The maximum timeout period of a health check. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("HealthCheckTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckTimeout { get; set; }

        /// <summary>
        /// <para>The URL path that is used for health checks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/test/index.html</para>
        /// </summary>
        [NameInMap("HealthCheckURI")]
        [Validation(Required=false)]
        public string HealthCheckURI { get; set; }

        /// <summary>
        /// <para>The healthy threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// <para>The timeout period of an idle connection. Valid values: <b>1</b> to <b>60</b>. Default value: <b>15</b>. Unit: seconds.</para>
        /// <para>If no request is received within the specified timeout period, CLB closes the connection. When a request is received, CLB establishes a new connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// <para>The frontend port that is used by the CLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// <para>The CLB instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp1mxu5r8lau****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365F4154-92F6-4AE4-92F8-7FF3********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The timeout period of a request. Valid values: <b>1</b> to <b>180</b>. Default value: <b>60</b>. Unit: seconds.</para>
        /// <para>If no response is received from a backend server within the specified timeout period, CLB returns the HTTP 504 status code to the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>43</para>
        /// </summary>
        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// <para>The list of forwarding rules that are associated with the listener.</para>
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
                /// <para>The endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">www.example.com</a></para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The ID of the forwarding rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>The name of the forwarding rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The request path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/example</para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <para>The ID of the server group that is associated with the forwarding rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("VServerGroupId")]
                [Validation(Required=false)]
                public string VServerGroupId { get; set; }

            }

        }

        /// <summary>
        /// <para>The routing algorithm. Valid values: <b>wrr</b> and <b>rr</b>.</para>
        /// <list type="bullet">
        /// <item><description><b>wrr</b>: Backend servers that have higher weights receive more requests than backend servers that have lower weights.</description></item>
        /// <item><description><b>rr</b>: Requests are distributed to backend servers in sequence.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>wrr</para>
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// <para>Indicates whether the listener is in the Secure state. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("SecurityStatus")]
        [Validation(Required=false)]
        public string SecurityStatus { get; set; }

        /// <summary>
        /// <para>The ID of the server certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idkp-123-cn-test-0**</para>
        /// </summary>
        [NameInMap("ServerCertificateId")]
        [Validation(Required=false)]
        public string ServerCertificateId { get; set; }

        /// <summary>
        /// <para>The status of the listener. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>running</b></description></item>
        /// <item><description><b>stopped</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>stopped</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether session persistence is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("StickySession")]
        [Validation(Required=false)]
        public string StickySession { get; set; }

        /// <summary>
        /// <para>The method that is used to handle a cookie.</para>
        /// <para>Valid values: <b>insert</b> and <b>server</b>.</para>
        /// <list type="bullet">
        /// <item><description><para><b>insert</b>: inserts a cookie.</para>
        /// <para>CLB inserts a cookie (SERVERID) into the first HTTP or HTTPS response packet that is sent to a client. The next request from the client will contain this cookie, and the listener will distribute this request to the recorded backend server.</para>
        /// </description></item>
        /// <item><description><para><b>server</b>: rewrites a cookie.</para>
        /// <para>When CLB detects a user-defined cookie, it overwrites the original cookie with the user-defined cookie. The next request from the client carries the user-defined cookie, and the listener will distribute the request to the recorded backend server.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>insert</para>
        /// </summary>
        [NameInMap("StickySessionType")]
        [Validation(Required=false)]
        public string StickySessionType { get; set; }

        /// <summary>
        /// <para>The Transport Layer Security (TLS) security policy for a high-performance CLB instance.</para>
        /// <para>Each security policy contains TLS protocol versions and cipher suites available for HTTPS. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>tls_cipher_policy_1_0</b>:</para>
        /// <para>Supported TLS versions: TLS 1.0, TLS 1.1, and TLS 1.2</para>
        /// <para>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA</para>
        /// </description></item>
        /// <item><description><para><b>tls_cipher_policy_1_1</b>:</para>
        /// <para>Supported TLS versions: TLS 1.1 and TLS 1.2</para>
        /// <para>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA</para>
        /// </description></item>
        /// <item><description><para><b>tls_cipher_policy_1_2</b></para>
        /// <para>Supported TLS version: TLS 1.2</para>
        /// <para>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA</para>
        /// </description></item>
        /// <item><description><para><b>tls_cipher_policy_1_2_strict</b></para>
        /// <para>Supported TLS version: TLS 1.2</para>
        /// <para>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA</para>
        /// </description></item>
        /// <item><description><para><b>tls_cipher_policy_1_2_strict_with_1_3</b></para>
        /// <para>Supported TLS versions: TLS 1.2 and TLS 1.3</para>
        /// <para>Supported cipher suites: TLS_AES_128_GCM_SHA256, TLS_AES_256_GCM_SHA384, TLS_CHACHA20_POLY1305_SHA256, TLS_AES_128_CCM_SHA256, TLS_AES_128_CCM_8_SHA256, ECDHE-ECDSA-AES128-GCM-SHA256, ECDHE-ECDSA-AES256-GCM-SHA384, ECDHE-ECDSA-AES128-SHA256, ECDHE-ECDSA-AES256-SHA384, ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-ECDSA-AES128-SHA, ECDHE-ECDSA-AES256-SHA, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tls_cipher_policy_1_0</para>
        /// </summary>
        [NameInMap("TLSCipherPolicy")]
        [Validation(Required=false)]
        public string TLSCipherPolicy { get; set; }

        /// <summary>
        /// <para>The tags.</para>
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
                /// <para>The key of tag N. Valid values of N: <b>1</b> to <b>20</b>. The tag key cannot be an empty string. The tag key can be up to 64 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>. The tag key cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The value of tag N. Valid values of N: <b>1</b> to <b>20</b>. The tag value can be an empty string. The tag value can be up to 128 characters in length, and cannot start with <c>acs:</c>. The tag value cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The unhealthy threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

        /// <summary>
        /// <para>The ID of the associated server group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rsp-cige6j5e********</para>
        /// </summary>
        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

        /// <summary>
        /// <para>Indicates whether the <c>X-Forwarded-For</c> header is used to retrieve client IP addresses. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("XForwardedFor")]
        [Validation(Required=false)]
        public string XForwardedFor { get; set; }

        /// <summary>
        /// <para>Indicates whether the <c>XForwardedFor_ClientCertClientVerify</c> header is used to retrieve the verification result of the client certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("XForwardedFor_ClientCertClientVerify")]
        [Validation(Required=false)]
        public string XForwardedFor_ClientCertClientVerify { get; set; }

        /// <summary>
        /// <para>Indicates whether the <c>XForwardedFor_ClientCertFingerprint</c> header is used to retrieve the fingerprint of the client certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("XForwardedFor_ClientCertFingerprint")]
        [Validation(Required=false)]
        public string XForwardedFor_ClientCertFingerprint { get; set; }

        /// <summary>
        /// <para>Indicates whether the <c>XForwardedFor_ClientCertIssuerDN</c> header is used to retrieve information about the authority that issues the client certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("XForwardedFor_ClientCertIssuerDN")]
        [Validation(Required=false)]
        public string XForwardedFor_ClientCertIssuerDN { get; set; }

        /// <summary>
        /// <para>Indicates whether the <c>XForwardedFor_ClientCertSubjectDN</c> header is used to retrieve information about the owner of the client certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("XForwardedFor_ClientCertSubjectDN")]
        [Validation(Required=false)]
        public string XForwardedFor_ClientCertSubjectDN { get; set; }

        /// <summary>
        /// <para>Indicates whether the <c>XForwardedFor_ClientSrcPort</c> header is used to retrieve the client port. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("XForwardedFor_ClientSrcPort")]
        [Validation(Required=false)]
        public string XForwardedFor_ClientSrcPort { get; set; }

        /// <summary>
        /// <para>Indicates whether the <c>SLB-ID</c> header is used to retrieve the ID of the ALB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("XForwardedFor_SLBID")]
        [Validation(Required=false)]
        public string XForwardedFor_SLBID { get; set; }

        /// <summary>
        /// <para>Indicates whether the <c>SLB-IP</c> header is used to retrieve the virtual IP address requested by the client. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("XForwardedFor_SLBIP")]
        [Validation(Required=false)]
        public string XForwardedFor_SLBIP { get; set; }

        /// <summary>
        /// <para>Indicates whether the <c>XForwardedFor_SLBPORT</c> header is used to retrieve the listening port. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("XForwardedFor_SLBPORT")]
        [Validation(Required=false)]
        public string XForwardedFor_SLBPORT { get; set; }

        /// <summary>
        /// <para>Indicates whether the <c>X-Forwarded-Proto</c> header is used to retrieve the listener protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("XForwardedFor_proto")]
        [Validation(Required=false)]
        public string XForwardedFor_proto { get; set; }

    }

}
