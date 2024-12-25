// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeLoadBalancerListenersResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of listeners of the CLB instance.</para>
        /// <remarks>
        /// <para> This parameter is not returned if the CLB instance does not have a listener.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public List<DescribeLoadBalancerListenersResponseBodyListeners> Listeners { get; set; }
        public class DescribeLoadBalancerListenersResponseBodyListeners : TeaModel {
            /// <summary>
            /// <para>The ID of the access control list (ACL).</para>
            /// 
            /// <b>Example:</b>
            /// <para>nacl-a2do9e413e0spzasx****</para>
            /// </summary>
            [NameInMap("AclId")]
            [Validation(Required=false)]
            public string AclId { get; set; }

            /// <summary>
            /// <para>The IDs of the ACLs.</para>
            /// </summary>
            [NameInMap("AclIds")]
            [Validation(Required=false)]
            public List<string> AclIds { get; set; }

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
            /// <para>The type of access control. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>white</b>: The listener forwards requests only from IP addresses and CIDR blocks on the whitelist. Your service may be adversely affected if the whitelist is not properly configured. If a whitelist is configured, the listener forwards requests only from IP addresses that are added to the whitelist.</description></item>
            /// </list>
            /// <para>If you configure a whitelist but no IP address is added to the whitelist, the listener forwards all requests.</para>
            /// <list type="bullet">
            /// <item><description><b>black</b>: The listener blocks requests from IP addresses and CIDR blocks on the blacklist.</description></item>
            /// </list>
            /// <para>If you configure a blacklist but no IP address is added to the blacklist, the listener forwards all requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>white</para>
            /// </summary>
            [NameInMap("AclType")]
            [Validation(Required=false)]
            public string AclType { get; set; }

            /// <summary>
            /// <para>The port of the backend server.</para>
            /// <remarks>
            /// <para> This parameter takes effect only when the <c>VServerGroupId</c> and <c>MasterSlaveServerGroupId</c> parameters are both empty.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
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
            /// <para>The description of the listener.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The configurations of the HTTP listener.</para>
            /// </summary>
            [NameInMap("HTTPListenerConfig")]
            [Validation(Required=false)]
            public DescribeLoadBalancerListenersResponseBodyListenersHTTPListenerConfig HTTPListenerConfig { get; set; }
            public class DescribeLoadBalancerListenersResponseBodyListenersHTTPListenerConfig : TeaModel {
                /// <summary>
                /// <para>The cookie configures for the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>B490B5EBF6F3CD402E515D22BCDA****</para>
                /// </summary>
                [NameInMap("Cookie")]
                [Validation(Required=false)]
                public string Cookie { get; set; }

                /// <summary>
                /// <para>The maximum amount of time to wait before the session cookie expires. Unit: seconds.</para>
                /// <para>Valid values: <b>1</b> to <b>86400</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("CookieTimeout")]
                [Validation(Required=false)]
                public int? CookieTimeout { get; set; }

                /// <summary>
                /// <para>The listener port that is used for HTTP-to-HTTPS redirection.</para>
                /// <remarks>
                /// <para> If the <b>ListenerForward</b> parameter is set to <b>off</b>, this parameter is not returned.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("ForwardPort")]
                [Validation(Required=false)]
                public int? ForwardPort { get; set; }

                /// <summary>
                /// <para>Indicates whether GZIP compression is enabled. Valid values:</para>
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
                /// <para> This parameter takes effect only when <b>HealthCheck</b> is set to <b>on</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("HealthCheckConnectPort")]
                [Validation(Required=false)]
                public int? HealthCheckConnectPort { get; set; }

                /// <summary>
                /// <para>The domain name that is used for health checks.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">www.example.com</a></para>
                /// </summary>
                [NameInMap("HealthCheckDomain")]
                [Validation(Required=false)]
                public string HealthCheckDomain { get; set; }

                /// <summary>
                /// <para>The HTTP status code that indicates a healthy backend server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http_2xx,http_3xx</para>
                /// </summary>
                [NameInMap("HealthCheckHttpCode")]
                [Validation(Required=false)]
                public string HealthCheckHttpCode { get; set; }

                /// <summary>
                /// <para>The HTTP version for health checks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP 1.0</para>
                /// </summary>
                [NameInMap("HealthCheckHttpVersion")]
                [Validation(Required=false)]
                public string HealthCheckHttpVersion { get; set; }

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
                /// <para>The health check method. Valid values: <b>head</b> and <b>get</b>.</para>
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
                /// <para>The protocol that you want to use for health checks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tcp</para>
                /// </summary>
                [NameInMap("HealthCheckType")]
                [Validation(Required=false)]
                public string HealthCheckType { get; set; }

                /// <summary>
                /// <para>The URI that is used for health checks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/test/index.html</para>
                /// </summary>
                [NameInMap("HealthCheckURI")]
                [Validation(Required=false)]
                public string HealthCheckURI { get; set; }

                /// <summary>
                /// <para>The number of times that an unhealthy backend server must consecutively pass health checks before it is declared healthy. In this case, the health check status of the backend server changes from <b>fail</b> to <b>success</b>.</para>
                /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("HealthyThreshold")]
                [Validation(Required=false)]
                public int? HealthyThreshold { get; set; }

                /// <summary>
                /// <para>The timeout period of an idle connection. Unit: seconds. Valid values: <b>1</b> to <b>60</b>.</para>
                /// <para>If no request is received within the specified timeout period, CLB closes the connection. When a request is received, CLB establishes a new connection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("IdleTimeout")]
                [Validation(Required=false)]
                public int? IdleTimeout { get; set; }

                /// <summary>
                /// <para>Indicates whether HTTP-to-HTTPS redirection is enabled for the listener. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>on</b></description></item>
                /// <item><description><b>off</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("ListenerForward")]
                [Validation(Required=false)]
                public string ListenerForward { get; set; }

                /// <summary>
                /// <para>The timeout period of a request. Unit: seconds. Valid values: <b>1</b> to <b>180</b>.</para>
                /// <para>If no response is received from a backend server during the request timeout period, CLB sends the <c>HTTP 504</c> status code to the client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("RequestTimeout")]
                [Validation(Required=false)]
                public int? RequestTimeout { get; set; }

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
                /// <para>The method used to handle the cookie. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>insert</b>: inserts a cookie. CLB inserts the SERVERID cookie to the HTTP or HTTPS response to the first request from a client. Subsequent requests that carry the SERVERID cookie from the client are forwarded to the same backend server as the first request.</description></item>
                /// <item><description><b>server</b>: rewrites the original cookie. CLB rewrites the custom cookies in requests from a client. Subsequent requests from the client that carry the new cookie are forwarded to the same backend server as the first request.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>insert</para>
                /// </summary>
                [NameInMap("StickySessionType")]
                [Validation(Required=false)]
                public string StickySessionType { get; set; }

                /// <summary>
                /// <para>The number of times that a healthy backend server must consecutively fail health checks before it is declared unhealthy. In this case, the health check status of the backend server changes from <b>success</b> to <b>fail</b>.</para>
                /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("UnhealthyThreshold")]
                [Validation(Required=false)]
                public int? UnhealthyThreshold { get; set; }

                /// <summary>
                /// <para>Indicates whether the <c>X-Forwarded-For</c> header is used to preserve client IP addresses. Valid values:</para>
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
                /// <para>Indicates whether the <c>XForwardedFor_ClientSrcPort</c> header is used to retrieve the client port. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>on</b></description></item>
                /// <item><description><b>off</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("XForwardedFor_ClientSrcPort")]
                [Validation(Required=false)]
                public string XForwardedFor_ClientSrcPort { get; set; }

                /// <summary>
                /// <para>Indicates whether the <c>SLB-ID</c> header is used to retrieve the ID of the CLB instance. Valid values:</para>
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
                /// <para>Indicates whether the <c>SLB-IP</c> header is used to retrieve the VIP of the client. Valid values:</para>
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
                /// <para>Indicates whether the <c>XForwardedFor_SLBPORT</c> header is used to retrieve the listener port of the CLB instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>on</b></description></item>
                /// <item><description><b>off</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("XForwardedFor_SLBPORT")]
                [Validation(Required=false)]
                public string XForwardedFor_SLBPORT { get; set; }

                /// <summary>
                /// <para>Indicates whether the <c>X-Forwarded-Proto</c> header is used to obtain the listener protocol. Valid values:</para>
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

            /// <summary>
            /// <para>The configurations of the HTTPS listener.</para>
            /// </summary>
            [NameInMap("HTTPSListenerConfig")]
            [Validation(Required=false)]
            public DescribeLoadBalancerListenersResponseBodyListenersHTTPSListenerConfig HTTPSListenerConfig { get; set; }
            public class DescribeLoadBalancerListenersResponseBodyListenersHTTPSListenerConfig : TeaModel {
                /// <summary>
                /// <para>The ID of the CA certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>idkp-234-cn-test-0****</para>
                /// </summary>
                [NameInMap("CACertificateId")]
                [Validation(Required=false)]
                public string CACertificateId { get; set; }

                /// <summary>
                /// <para>The cookie configures for the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>B490B5EBF6F3CD402E515D22BCDA****</para>
                /// </summary>
                [NameInMap("Cookie")]
                [Validation(Required=false)]
                public string Cookie { get; set; }

                /// <summary>
                /// <para>The maximum amount of time to wait before the session cookie expires. Unit: seconds.</para>
                /// <para>Valid values: <b>1</b> to <b>86400</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("CookieTimeout")]
                [Validation(Required=false)]
                public int? CookieTimeout { get; set; }

                /// <summary>
                /// <para>Indicates whether <c>HTTP 2.0</c> is enabled. Valid values:</para>
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
                /// <para>Indicates whether GZIP compression is enabled. Valid values:</para>
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
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("HealthCheckConnectPort")]
                [Validation(Required=false)]
                public int? HealthCheckConnectPort { get; set; }

                /// <summary>
                /// <para>The domain name that is used for health checks.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">www.example.com</a></para>
                /// </summary>
                [NameInMap("HealthCheckDomain")]
                [Validation(Required=false)]
                public string HealthCheckDomain { get; set; }

                /// <summary>
                /// <para>The HTTP status code that indicates a healthy backend server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http_2xx,http_3xx</para>
                /// </summary>
                [NameInMap("HealthCheckHttpCode")]
                [Validation(Required=false)]
                public string HealthCheckHttpCode { get; set; }

                /// <summary>
                /// <para>The HTTP version for health checks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP 1.0</para>
                /// </summary>
                [NameInMap("HealthCheckHttpVersion")]
                [Validation(Required=false)]
                public string HealthCheckHttpVersion { get; set; }

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
                /// <para>The health check method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>get</para>
                /// </summary>
                [NameInMap("HealthCheckMethod")]
                [Validation(Required=false)]
                public string HealthCheckMethod { get; set; }

                /// <summary>
                /// <para>The timeout period of a health check response. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("HealthCheckTimeout")]
                [Validation(Required=false)]
                public int? HealthCheckTimeout { get; set; }

                /// <summary>
                /// <para>The protocol that you want to use for health checks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tcp</para>
                /// </summary>
                [NameInMap("HealthCheckType")]
                [Validation(Required=false)]
                public string HealthCheckType { get; set; }

                /// <summary>
                /// <para>The URI that is used for health checks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/test/index.html</para>
                /// </summary>
                [NameInMap("HealthCheckURI")]
                [Validation(Required=false)]
                public string HealthCheckURI { get; set; }

                /// <summary>
                /// <para>The number of times that an unhealthy backend server must consecutively pass health checks before it is declared healthy. In this case, the health check status of the backend server changes from <b>fail</b> to <b>success</b>.</para>
                /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("HealthyThreshold")]
                [Validation(Required=false)]
                public int? HealthyThreshold { get; set; }

                /// <summary>
                /// <para>The timeout period of an idle connection. Unit: seconds. Valid values: <b>1</b> to <b>60</b>.</para>
                /// <para>If no request is received within the specified timeout period, CLB closes the connection. When a request is received, CLB establishes a new connection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("IdleTimeout")]
                [Validation(Required=false)]
                public int? IdleTimeout { get; set; }

                /// <summary>
                /// <para>The request timeout period. Unit: seconds. Valid values: <b>1</b> to <b>180</b>.</para>
                /// <para>If no response is received from a backend server during the request timeout period, CLB sends the <c>HTTP 504</c> status code to the client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("RequestTimeout")]
                [Validation(Required=false)]
                public int? RequestTimeout { get; set; }

                /// <summary>
                /// <para>The ID of the server certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>idkp-123-cn-test-0****</para>
                /// </summary>
                [NameInMap("ServerCertificateId")]
                [Validation(Required=false)]
                public string ServerCertificateId { get; set; }

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
                /// <para>The method used to handle the cookie.</para>
                /// <list type="bullet">
                /// <item><description><b>insert</b>: inserts a cookie. CLB inserts the SERVERID cookie to the HTTP or HTTPS response to the first request from a client. Subsequent requests that carry the SERVERID cookie from the client are forwarded to the same backend server as the first request.</description></item>
                /// <item><description><b>server</b>: rewrites the original cookie. CLB rewrites the custom cookies in requests from a client. Subsequent requests from the client that carry the new cookie are forwarded to the same backend server as the first request.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>insert</para>
                /// </summary>
                [NameInMap("StickySessionType")]
                [Validation(Required=false)]
                public string StickySessionType { get; set; }

                /// <summary>
                /// <para>A TLS security policy contains TLS protocols and cipher suites available for HTTPS.</para>
                /// <list type="bullet">
                /// <item><description><para><b>tls_cipher_policy_1_0</b>:</para>
                /// <para>Supported TLS versions: TLSv1.0, TLSv1.1, and TLSv1.2.</para>
                /// <para>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA.</para>
                /// </description></item>
                /// <item><description><para><b>tls_cipher_policy_1_1</b>:</para>
                /// <para>Supported TLS versions: TLSv1.1 and TLSv1.2.</para>
                /// <para>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA.</para>
                /// </description></item>
                /// <item><description><para><b>tls_cipher_policy_1_2</b></para>
                /// <para>Supported TLS versions: TLSv1.2.</para>
                /// <para>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA.</para>
                /// </description></item>
                /// <item><description><para><b>tls_cipher_policy_1_2_strict</b></para>
                /// <para>Supported TLS versions: TLSv1.2.</para>
                /// <para>Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA.</para>
                /// </description></item>
                /// <item><description><para><b>tls_cipher_policy_1_2_strict_with_1_3</b></para>
                /// <para>Supported TLS versions: TLSv1.2 and TLSv1.3.</para>
                /// <para>Supported cipher suites: TLS_AES_128_GCM_SHA256, TLS_AES_256_GCM_SHA384, TLS_CHACHA20_POLY1305_SHA256, TLS_AES_128_CCM_SHA256, TLS_AES_128_CCM_8_SHA256, ECDHE-ECDSA-AES128-GCM-SHA256, ECDHE-ECDSA-AES256-GCM-SHA384, ECDHE-ECDSA-AES128-SHA256, ECDHE-ECDSA-AES256-SHA384, ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-ECDSA-AES128-SHA, ECDHE-ECDSA-AES256-SHA, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA.</para>
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
                /// <para>The number of times that a healthy backend server must consecutively fail health checks before it is declared unhealthy. In this case, the health check status of the backend server changes from <b>success</b> to <b>fail</b>.</para>
                /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("UnhealthyThreshold")]
                [Validation(Required=false)]
                public int? UnhealthyThreshold { get; set; }

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
                /// <para>Indicates whether the <c>XForwardedFor_ClientCertClientVerify</c> header is used to obtain the verification result of the client certificate. Valid values:</para>
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
                /// <para>Indicates whether the <c>XForwardedFor_ClientCertFingerprint</c> header is used to obtain the fingerprint of the client certificate. Valid values:</para>
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
                /// <para>Indicates whether the <c>XForwardedFor_ClientCertIssuerDN</c> header is used to obtain information about the authority that issues the client certificate. Valid values:</para>
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
                /// <para>Indicates whether the <c>XForwardedFor_ClientCertSubjectDN</c> header is used to obtain information about the owner of the client certificate. Valid values:</para>
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
                /// <para>Indicates whether the <c>SLB-ID</c> header is used to retrieve the ID of the CLB instance. Valid values:</para>
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
                /// <para>Indicates whether the <c>SLB-IP</c> header is used to retrieve the VIP of the client. Valid values:</para>
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
                /// <para>Indicates whether the <c>XForwardedFor_SLBPORT</c> header is used to retrieve the listener port of the CLB instance. Valid values:</para>
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
                /// <para>Indicates whether the <c>X-Forwarded-Proto</c> header is used to obtain the listener protocol. Valid values:</para>
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

            /// <summary>
            /// <para>The listener port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public int? ListenerPort { get; set; }

            /// <summary>
            /// <para>The protocol used by the listener.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http</para>
            /// </summary>
            [NameInMap("ListenerProtocol")]
            [Validation(Required=false)]
            public string ListenerProtocol { get; set; }

            /// <summary>
            /// <para>The ID of the CLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-bp1b6c719dfa****</para>
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <para>The scheduling algorithm. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>wrr</b>: Backend servers with higher weights receive more requests than those with lower weights.</description></item>
            /// <item><description><b>rr</b>: Requests are distributed to backend servers in sequence.</description></item>
            /// <item><description><b>sch</b>: consistent hashing that is based on source IP addresses. Requests from the same source IP address are distributed to the same backend server.</description></item>
            /// <item><description><b>tch</b>: specifies consistent hashing based on the source IP address, destination IP address, source port, and destination port. Requests that have the same four factors are distributed to the same backend server.</description></item>
            /// <item><description><b>qch</b>: specifies consistent hashing based on Quick UDP Internet Connection (QUIC) IDs. Requests that contain the same QUIC ID are scheduled to the same backend server.</description></item>
            /// </list>
            /// <remarks>
            /// <para> Only high-performance CLB instances support the <b>sch</b>, <b>tch</b>, and <b>qch</b> consistent hashing algorithms.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>wrr</para>
            /// </summary>
            [NameInMap("Scheduler")]
            [Validation(Required=false)]
            public string Scheduler { get; set; }

            /// <summary>
            /// <para>The status of the listener. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>running</b></description></item>
            /// <item><description><b>stopped</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The configurations of the TCP listener.</para>
            /// </summary>
            [NameInMap("TCPListenerConfig")]
            [Validation(Required=false)]
            public DescribeLoadBalancerListenersResponseBodyListenersTCPListenerConfig TCPListenerConfig { get; set; }
            public class DescribeLoadBalancerListenersResponseBodyListenersTCPListenerConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether connection draining is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>on</b></description></item>
                /// <item><description><b>off</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("ConnectionDrain")]
                [Validation(Required=false)]
                public string ConnectionDrain { get; set; }

                /// <summary>
                /// <para>The timeout period of connection draining. Unit: seconds.</para>
                /// <para>Value values: <b>10 to 900</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("ConnectionDrainTimeout")]
                [Validation(Required=false)]
                public int? ConnectionDrainTimeout { get; set; }

                /// <summary>
                /// <para>The timeout period of a connection. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("EstablishedTimeout")]
                [Validation(Required=false)]
                public int? EstablishedTimeout { get; set; }

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
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("HealthCheckConnectPort")]
                [Validation(Required=false)]
                public int? HealthCheckConnectPort { get; set; }

                /// <summary>
                /// <para>The timeout period of health checks. Unit: seconds.</para>
                /// <para>Valid values: <b>1</b> to <b>300</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("HealthCheckConnectTimeout")]
                [Validation(Required=false)]
                public int? HealthCheckConnectTimeout { get; set; }

                /// <summary>
                /// <para>The domain name that is used for health checks.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">www.example.com</a></para>
                /// </summary>
                [NameInMap("HealthCheckDomain")]
                [Validation(Required=false)]
                public string HealthCheckDomain { get; set; }

                /// <summary>
                /// <para>The HTTP status code that indicates a healthy backend server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http_2xx,http_3xx</para>
                /// </summary>
                [NameInMap("HealthCheckHttpCode")]
                [Validation(Required=false)]
                public string HealthCheckHttpCode { get; set; }

                /// <summary>
                /// <para>The interval between two consecutive health checks. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("HealthCheckInterval")]
                [Validation(Required=false)]
                public int? HealthCheckInterval { get; set; }

                /// <summary>
                /// <para>The health check method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>get</para>
                /// </summary>
                [NameInMap("HealthCheckMethod")]
                [Validation(Required=false)]
                public string HealthCheckMethod { get; set; }

                /// <summary>
                /// <para>The protocol that you want to use for health checks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tcp</para>
                /// </summary>
                [NameInMap("HealthCheckType")]
                [Validation(Required=false)]
                public string HealthCheckType { get; set; }

                /// <summary>
                /// <para>The URI that is used for health checks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/test/index.html</para>
                /// </summary>
                [NameInMap("HealthCheckURI")]
                [Validation(Required=false)]
                public string HealthCheckURI { get; set; }

                /// <summary>
                /// <para>The number of times that an unhealthy backend server must consecutively pass health checks before it is declared healthy. In this case, the health check status of the backend server changes from <b>fail</b> to <b>success</b>.</para>
                /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("HealthyThreshold")]
                [Validation(Required=false)]
                public int? HealthyThreshold { get; set; }

                /// <summary>
                /// <para>The ID of the primary/secondary server group associated with the listener.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rsp-0bfucw*****</para>
                /// </summary>
                [NameInMap("MasterSlaveServerGroupId")]
                [Validation(Required=false)]
                public string MasterSlaveServerGroupId { get; set; }

                /// <summary>
                /// <para>Indicates whether session persistence is enabled. Unit: seconds.</para>
                /// <para>Valid values: <b>0</b> to <b>3600</b>.</para>
                /// <para><b>0</b> indicates that session persistence is disabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PersistenceTimeout")]
                [Validation(Required=false)]
                public int? PersistenceTimeout { get; set; }

                /// <summary>
                /// <para>Indicates whether the Proxy protocol is used to pass source client IP addresses to backend servers. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: enables the burst feature for the data disk.</description></item>
                /// <item><description><b>false</b>: The task is not being retried.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ProxyProtocolV2Enabled")]
                [Validation(Required=false)]
                public string ProxyProtocolV2Enabled { get; set; }

                /// <summary>
                /// <para>The number of times that a healthy backend server must consecutively fail health checks before it is declared unhealthy. In this case, the health check status of the backend server changes from <b>success</b> to <b>fail</b>.</para>
                /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("UnhealthyThreshold")]
                [Validation(Required=false)]
                public int? UnhealthyThreshold { get; set; }

            }

            /// <summary>
            /// <para>A list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeLoadBalancerListenersResponseBodyListenersTags> Tags { get; set; }
            public class DescribeLoadBalancerListenersResponseBodyListenersTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The configurations of the UDP listener.</para>
            /// </summary>
            [NameInMap("UDPListenerConfig")]
            [Validation(Required=false)]
            public DescribeLoadBalancerListenersResponseBodyListenersUDPListenerConfig UDPListenerConfig { get; set; }
            public class DescribeLoadBalancerListenersResponseBodyListenersUDPListenerConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether connection draining is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>on</b></description></item>
                /// <item><description><b>off</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("ConnectionDrain")]
                [Validation(Required=false)]
                public string ConnectionDrain { get; set; }

                /// <summary>
                /// <para>The timeout period of connection draining. Unit: seconds.</para>
                /// <para>Value values: <b>10 to 900</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("ConnectionDrainTimeout")]
                [Validation(Required=false)]
                public int? ConnectionDrainTimeout { get; set; }

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
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("HealthCheckConnectPort")]
                [Validation(Required=false)]
                public int? HealthCheckConnectPort { get; set; }

                /// <summary>
                /// <para>The timeout period for a health check response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("HealthCheckConnectTimeout")]
                [Validation(Required=false)]
                public int? HealthCheckConnectTimeout { get; set; }

                /// <summary>
                /// <para>The response string of UDP health checks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ok</para>
                /// </summary>
                [NameInMap("HealthCheckExp")]
                [Validation(Required=false)]
                public string HealthCheckExp { get; set; }

                /// <summary>
                /// <para>The interval between two consecutive health checks. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("HealthCheckInterval")]
                [Validation(Required=false)]
                public int? HealthCheckInterval { get; set; }

                /// <summary>
                /// <para>The request string of UDP health checks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hello</para>
                /// </summary>
                [NameInMap("HealthCheckReq")]
                [Validation(Required=false)]
                public string HealthCheckReq { get; set; }

                /// <summary>
                /// <para>The number of times that a backend server must consecutively pass health checks before it is declared healthy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("HealthyThreshold")]
                [Validation(Required=false)]
                public int? HealthyThreshold { get; set; }

                /// <summary>
                /// <para>The ID of the primary/secondary server group that is associated with the listener.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rsp-0bfucw****</para>
                /// </summary>
                [NameInMap("MasterSlaveServerGroupId")]
                [Validation(Required=false)]
                public string MasterSlaveServerGroupId { get; set; }

                /// <summary>
                /// <para>Indicates whether the Proxy protocol is used to pass source client IP addresses to backend servers. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: enables the burst feature for the data disk.</description></item>
                /// <item><description><b>false</b>: The task is not being retried.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ProxyProtocolV2Enabled")]
                [Validation(Required=false)]
                public string ProxyProtocolV2Enabled { get; set; }

                /// <summary>
                /// <para>The number of times that a backend server must consecutively fail health checks before it is declared unhealthy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("UnhealthyThreshold")]
                [Validation(Required=false)]
                public int? UnhealthyThreshold { get; set; }

            }

            /// <summary>
            /// <para>The ID of the vServer group associated with the listener.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rsp-cige6j****</para>
            /// </summary>
            [NameInMap("VServerGroupId")]
            [Validation(Required=false)]
            public string VServerGroupId { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that determines the start point of the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, it indicates that no subsequent query is to be sent.</description></item>
        /// <item><description>If a value is returned for <b>NextToken</b>, the value is the token that determines the start point of the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365F4154-92F6-4AE4-92F8-7FF34B540710</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
