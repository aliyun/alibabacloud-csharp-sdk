// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeIngressResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned for the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: The request was redirected.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: A client error occurred.</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: A server error occurred.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeIngressResponseBodyData Data { get; set; }
        public class DescribeIngressResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the <b>Classic Load Balancer (CLB)</b> certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13623****809_16cad216b32_845_-419427029</para>
            /// </summary>
            [NameInMap("CertId")]
            [Validation(Required=false)]
            public string CertId { get; set; }

            /// <summary>
            /// <para>The comma-separated IDs of the <b>Application Load Balancer (ALB)</b> certificates.</para>
            /// 
            /// <b>Example:</b>
            /// <para>87<em><b>35-cn-hangzhou,812</b></em>3-cn-hangzhou</para>
            /// </summary>
            [NameInMap("CertIds")]
            [Validation(Required=false)]
            public string CertIds { get; set; }

            /// <summary>
            /// <para>The configurations for Cross-Origin Resource Sharing (CORS). Valid HTTP methods:</para>
            /// <list type="bullet">
            /// <item><description><para><b>GET</b></para>
            /// </description></item>
            /// <item><description><para><b>POST</b></para>
            /// </description></item>
            /// <item><description><para><b>PUT</b></para>
            /// </description></item>
            /// <item><description><para><b>DELETE</b></para>
            /// </description></item>
            /// <item><description><para><b>HEAD</b></para>
            /// </description></item>
            /// <item><description><para><b>OPTIONS</b></para>
            /// </description></item>
            /// <item><description><para><b>PATCH</b></para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("CorsConfig")]
            [Validation(Required=false)]
            public DescribeIngressResponseBodyDataCorsConfig CorsConfig { get; set; }
            public class DescribeIngressResponseBodyDataCorsConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether to allow credentials in cross-origin requests. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>on</b>: yes</para>
                /// </description></item>
                /// <item><description><para><b>off</b>: no</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("AllowCredentials")]
                [Validation(Required=false)]
                public string AllowCredentials { get; set; }

                /// <summary>
                /// <para>The headers that are allowed in cross-origin requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_123</para>
                /// </summary>
                [NameInMap("AllowHeaders")]
                [Validation(Required=false)]
                public string AllowHeaders { get; set; }

                /// <summary>
                /// <para>The HTTP methods that are allowed for cross-origin requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GET</para>
                /// </summary>
                [NameInMap("AllowMethods")]
                [Validation(Required=false)]
                public string AllowMethods { get; set; }

                /// <summary>
                /// <para>The origins that are allowed to access the resource. You can specify a single asterisk (<c>*</c>) or one or more specific origins.</para>
                /// <list type="bullet">
                /// <item><description><para>A specific origin must start with <c>http://</c> or <c>https://</c> and be a valid domain name or a first-level wildcard domain name. Example: <c>http://*.test.abc.example.com</c>.</para>
                /// </description></item>
                /// <item><description><para>You can optionally specify a port. The valid port range is <b>1</b> to <b>65535</b>.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("AllowOrigin")]
                [Validation(Required=false)]
                public string AllowOrigin { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable CORS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public string Enable { get; set; }

                /// <summary>
                /// <para>The headers that are exposed to clients.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_123</para>
                /// </summary>
                [NameInMap("ExposeHeaders")]
                [Validation(Required=false)]
                public string ExposeHeaders { get; set; }

                /// <summary>
                /// <para>The maximum cache duration of preflight requests in the browser, in seconds.</para>
                /// <para>Valid values: <b>-1</b> to <b>172800</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("MaxAge")]
                [Validation(Required=false)]
                public string MaxAge { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the Application Load Balancer (ALB) instance was provisioned by SAE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CreatedBySae")]
            [Validation(Required=false)]
            public bool? CreatedBySae { get; set; }

            /// <summary>
            /// <para>The default rule.</para>
            /// </summary>
            [NameInMap("DefaultRule")]
            [Validation(Required=false)]
            public DescribeIngressResponseBodyDataDefaultRule DefaultRule { get; set; }
            public class DescribeIngressResponseBodyDataDefaultRule : TeaModel {
                /// <summary>
                /// <para>The ID of the application for the default rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>395b60e4-0550-458d-9c54-a265d036****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The name of the application for the default rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app1</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The backend protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>http</b>: Suitable for applications that need to identify data content.</para>
                /// </description></item>
                /// <item><description><para><b>https</b>: Suitable for applications that require encrypted transmission.</para>
                /// </description></item>
                /// <item><description><para><b>grpc</b>: Suitable for load balancing gRPC services developed in multiple languages, such as .NET.</para>
                /// </description></item>
                /// </list>
                /// <para>This parameter is valid only when the <c>LoadBalanceType</c> parameter is set to <c>alb</c> and the <c>ListenerProtocol</c> parameter is set to <c>HTTPS</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http</para>
                /// </summary>
                [NameInMap("BackendProtocol")]
                [Validation(Required=false)]
                public string BackendProtocol { get; set; }

                /// <summary>
                /// <para>The backend port for the default rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("ContainerPort")]
                [Validation(Required=false)]
                public int? ContainerPort { get; set; }

            }

            /// <summary>
            /// <para>The description of the Ingress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ingress-sae-test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable Gzip compression.</para>
            /// </summary>
            [NameInMap("EnableGzip")]
            [Validation(Required=false)]
            public bool? EnableGzip { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Forwarded-For</c> header to retrieve client IP addresses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableXForwardedFor")]
            [Validation(Required=false)]
            public bool? EnableXForwardedFor { get; set; }

            /// <summary>
            /// <para>Specifies whether to use a header to retrieve the source port of the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableXForwardedForClientSrcPort")]
            [Validation(Required=false)]
            public bool? EnableXForwardedForClientSrcPort { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Forwarded-Proto</c> header to retrieve the listener protocol of the SLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableXForwardedForProto")]
            [Validation(Required=false)]
            public bool? EnableXForwardedForProto { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>SLB-ID</c> header to retrieve the ID of the SLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableXForwardedForSlbId")]
            [Validation(Required=false)]
            public bool? EnableXForwardedForSlbId { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the <c>X-Forwarded-Port</c> header to retrieve the listener port of the SLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableXForwardedForSlbPort")]
            [Validation(Required=false)]
            public bool? EnableXForwardedForSlbPort { get; set; }

            /// <summary>
            /// <para>The ID of the Ingress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>87</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The connection idle timeout, in seconds.</para>
            /// <para>Valid values: 1 to 60.</para>
            /// <para>Default value: 15.</para>
            /// <para>If no request is received within the timeout period, the load balancer closes the connection. A new connection is established when the next request is received.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("IdleTimeout")]
            [Validation(Required=false)]
            public int? IdleTimeout { get; set; }

            /// <summary>
            /// <para>The listener port of the SLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>443</para>
            /// </summary>
            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public int? ListenerPort { get; set; }

            /// <summary>
            /// <para>The request forwarding protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>HTTP</b>: Suitable for applications that need to identify data content.</para>
            /// </description></item>
            /// <item><description><para><b>HTTPS</b>: Suitable for applications that require encrypted transmission.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is optional for the <c>CreateIngress</c> and <c>UpdateIngress</c> operations. It is not returned if it was not specified when the Ingress was created or updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("ListenerProtocol")]
            [Validation(Required=false)]
            public string ListenerProtocol { get; set; }

            /// <summary>
            /// <para>The type of the Server Load Balancer (SLB) instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>clb</b>: Classic Load Balancer (CLB), formerly known as SLB.</para>
            /// </description></item>
            /// <item><description><para><b>alb</b>: Application Load Balancer (ALB).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>clb</para>
            /// </summary>
            [NameInMap("LoadBalanceType")]
            [Validation(Required=false)]
            public string LoadBalanceType { get; set; }

            /// <summary>
            /// <para>The name of the Ingress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-uf6jt0nu4z6ior943****-80-f5****</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The namespace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing:sae-test</para>
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// <para>The request timeout, in seconds.</para>
            /// <para>Valid values: 1 to 180.</para>
            /// <para>Default value: 60.</para>
            /// <para>If a backend server does not respond within the specified timeout period, the load balancer terminates the request and returns an HTTP 504 error to the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("RequestTimeout")]
            [Validation(Required=false)]
            public int? RequestTimeout { get; set; }

            /// <summary>
            /// <para>The forwarding rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeIngressResponseBodyDataRules> Rules { get; set; }
            public class DescribeIngressResponseBodyDataRules : TeaModel {
                /// <summary>
                /// <para>The ID of the destination application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>395b60e4-0550-458d-9c54-a265d036****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The name of the destination application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app1</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The backend protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>http</b>: Suitable for applications that need to identify data content.</para>
                /// </description></item>
                /// <item><description><para><b>https</b>: Suitable for applications that require encrypted transmission.</para>
                /// </description></item>
                /// <item><description><para><b>grpc</b>: Suitable for load balancing gRPC services developed in multiple languages, such as .NET.</para>
                /// </description></item>
                /// </list>
                /// <para>This parameter is valid only when the <c>LoadBalanceType</c> parameter is set to <c>alb</c> and the <c>ListenerProtocol</c> parameter is set to <c>HTTPS</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http</para>
                /// </summary>
                [NameInMap("BackendProtocol")]
                [Validation(Required=false)]
                public string BackendProtocol { get; set; }

                /// <summary>
                /// <para>The backend port of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("ContainerPort")]
                [Validation(Required=false)]
                public int? ContainerPort { get; set; }

                /// <summary>
                /// <para>The domain name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>edas.site</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The URL path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/path1</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The rewritten path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/${1}</para>
                /// </summary>
                [NameInMap("RewritePath")]
                [Validation(Required=false)]
                public string RewritePath { get; set; }

                /// <summary>
                /// <para>The actions of the forwarding rule.</para>
                /// </summary>
                [NameInMap("RuleActions")]
                [Validation(Required=false)]
                public List<DescribeIngressResponseBodyDataRulesRuleActions> RuleActions { get; set; }
                public class DescribeIngressResponseBodyDataRulesRuleActions : TeaModel {
                    /// <summary>
                    /// <para>The configuration of the action.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{\&quot;host\&quot;:\&quot;<a href="http://www.example.com%5C%5C%22,%5C%5C%22path%5C%5C%22:%5C%5C%22/example/text%5C%5C%22,%5C%5C%22query%5C%5C%22:%5C%5C%22x=1%5C%5C%22%7D">www.example.com\\&quot;,\\&quot;path\\&quot;:\\&quot;/example/text\\&quot;,\\&quot;query\\&quot;:\\&quot;x=1\\&quot;}</a></para>
                    /// </summary>
                    [NameInMap("ActionConfig")]
                    [Validation(Required=false)]
                    public string ActionConfig { get; set; }

                    /// <summary>
                    /// <para>The type of the action. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>rewrite: a rewrite policy</para>
                    /// </description></item>
                    /// <item><description><para>redirect: a redirection policy</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rewrite</para>
                    /// </summary>
                    [NameInMap("ActionType")]
                    [Validation(Required=false)]
                    public string ActionType { get; set; }

                }

            }

            /// <summary>
            /// <para>The ID of the security policy instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-n0kn923****</para>
            /// </summary>
            [NameInMap("SecurityPolicyId")]
            [Validation(Required=false)]
            public string SecurityPolicyId { get; set; }

            /// <summary>
            /// <para>The ID of the Server Load Balancer (SLB) instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-uf62****6d13tq2u5</para>
            /// </summary>
            [NameInMap("SlbId")]
            [Validation(Required=false)]
            public string SlbId { get; set; }

            /// <summary>
            /// <para>The type of the SLB instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>internet</b>: An internet-facing instance.</para>
            /// </description></item>
            /// <item><description><para><b>intranet</b>: An internal-facing instance.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>internet</para>
            /// </summary>
            [NameInMap("SlbType")]
            [Validation(Required=false)]
            public string SlbType { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is returned only if the request fails.</para>
        /// </description></item>
        /// <item><description><para>For more information, see the <b>Error codes</b> section in this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// <list type="bullet">
        /// <item><description><para>If the request is successful, <b>success</b> is returned.</para>
        /// </description></item>
        /// <item><description><para>If the request fails, a specific error code is returned.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91F93257-7A4A-4BD3-9A7E-2F6EAE6D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request succeeded.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID used to query the details of a call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a981dd515966966104121683d****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
