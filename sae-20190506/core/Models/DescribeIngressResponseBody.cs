// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeIngressResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: The request was successful.</description></item>
        /// <item><description><b>3xx</b>: The request was redirected.</description></item>
        /// <item><description><b>4xx</b>: The request failed.</description></item>
        /// <item><description><b>5xx</b>: A server error occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The result returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeIngressResponseBodyData Data { get; set; }
        public class DescribeIngressResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the certificate that is associated with a Classic Load Balancer (<b>CLB</b>) instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13623****809_16cad216b32_845_-419427029</para>
            /// </summary>
            [NameInMap("CertId")]
            [Validation(Required=false)]
            public string CertId { get; set; }

            /// <summary>
            /// <para>The ID of the certificate that is associated with an Application Load Balancer <b>ALB</b> instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>87<em><b>35-cn-hangzhou,812</b></em>3-cn-hangzhou</para>
            /// </summary>
            [NameInMap("CertIds")]
            [Validation(Required=false)]
            public string CertIds { get; set; }

            [NameInMap("CorsConfig")]
            [Validation(Required=false)]
            public DescribeIngressResponseBodyDataCorsConfig CorsConfig { get; set; }
            public class DescribeIngressResponseBodyDataCorsConfig : TeaModel {
                [NameInMap("AllowCredentials")]
                [Validation(Required=false)]
                public string AllowCredentials { get; set; }

                [NameInMap("AllowHeaders")]
                [Validation(Required=false)]
                public string AllowHeaders { get; set; }

                [NameInMap("AllowMethods")]
                [Validation(Required=false)]
                public string AllowMethods { get; set; }

                [NameInMap("AllowOrigin")]
                [Validation(Required=false)]
                public string AllowOrigin { get; set; }

                [NameInMap("Enable")]
                [Validation(Required=false)]
                public string Enable { get; set; }

                [NameInMap("ExposeHeaders")]
                [Validation(Required=false)]
                public string ExposeHeaders { get; set; }

                [NameInMap("MaxAge")]
                [Validation(Required=false)]
                public string MaxAge { get; set; }

            }

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
                /// <para>The ID of the application that is specified in the default rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>395b60e4-0550-458d-9c54-a265d036****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The name of the application that is specified in the default rule.</para>
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
                /// <item><description><b>http</b>: HTTP is suitable for applications that need to identify the transmitted data.</description></item>
                /// <item><description><b>https</b>: HTTP is suitable for applications that require encrypted data transmission.</description></item>
                /// <item><description><b>grpc</b>: GRPC is suitable for load balancing scenarios in which you want to deploy services in multi-language frameworks, such as the .NET framework.</description></item>
                /// </list>
                /// <para>This parameter is returned only if the<b>LoadBalanceType</b> parameter is set to <b>ALB</b> and the <b>ListenerProtocol</b> parameter <b>is set to HTTPS</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("BackendProtocol")]
                [Validation(Required=false)]
                public string BackendProtocol { get; set; }

                /// <summary>
                /// <para>The container port of the application that is specified in the default rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("ContainerPort")]
                [Validation(Required=false)]
                public int? ContainerPort { get; set; }

            }

            /// <summary>
            /// <para>The name of a routing rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ingress-sae-test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EnableGzip")]
            [Validation(Required=false)]
            public bool? EnableGzip { get; set; }

            [NameInMap("EnableXForwardedFor")]
            [Validation(Required=false)]
            public bool? EnableXForwardedFor { get; set; }

            [NameInMap("EnableXForwardedForClientSrcPort")]
            [Validation(Required=false)]
            public bool? EnableXForwardedForClientSrcPort { get; set; }

            [NameInMap("EnableXForwardedForProto")]
            [Validation(Required=false)]
            public bool? EnableXForwardedForProto { get; set; }

            [NameInMap("EnableXForwardedForSlbId")]
            [Validation(Required=false)]
            public bool? EnableXForwardedForSlbId { get; set; }

            [NameInMap("EnableXForwardedForSlbPort")]
            [Validation(Required=false)]
            public bool? EnableXForwardedForSlbPort { get; set; }

            /// <summary>
            /// <para>The ID of a routing rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>87</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("IdleTimeout")]
            [Validation(Required=false)]
            public int? IdleTimeout { get; set; }

            /// <summary>
            /// <para>The listener ports for an SLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>443</para>
            /// </summary>
            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public int? ListenerPort { get; set; }

            /// <summary>
            /// <para>The protocol used to forward requests. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>HTTP</b>: HTTP is suitable for applications that need to identify the transmitted data.</description></item>
            /// <item><description><b>HTTPS</b>: HTTPS is suitable for applications that require encrypted data transmission.</description></item>
            /// </list>
            /// <para>This parameter is optional in the <b>CreateIngress</b> and <b>UpadateIngress</b> operations. If you do not configure this parameter when you call the CreateIngress or UpdateIngress operation to create or update a gateway routing rule, this parameter is not returned for the corresponding response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("ListenerProtocol")]
            [Validation(Required=false)]
            public string ListenerProtocol { get; set; }

            /// <summary>
            /// <para>The type of SLB instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>clb</b>: Classic Load Balancer (formerly known as SLB).</description></item>
            /// <item><description><b>alb</b>: Application Load Balancer.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>clb</para>
            /// </summary>
            [NameInMap("LoadBalanceType")]
            [Validation(Required=false)]
            public string LoadBalanceType { get; set; }

            /// <summary>
            /// <para>The name of a routing rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-uf6jt0nu4z6ior943****-80-f5****</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of a namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing:sae-test</para>
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
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
                /// <para>The ID of the application specified in the forwarding rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>395b60e4-0550-458d-9c54-a265d036****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The name of the application specified in the forwarding rules.</para>
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
                /// <item><description><b>http</b>: HTTP is suitable for applications that need to identify the transmitted data.</description></item>
                /// <item><description><b>https</b>: HTTPS is suitable for applications that require encrypted data transmission.</description></item>
                /// <item><description><b>grpc</b>: GRPC is suitable for load balancing scenarios in which you want to deploy services in multi-language frameworks, such as the .NET framework.</description></item>
                /// </list>
                /// <para>This parameter is returned only if the <b>LoadBalanceType</b> parameter is set to <b>ALB</b> and the <b>ListenerProtocol</b> parameter is set to <b>HTTPS</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("BackendProtocol")]
                [Validation(Required=false)]
                public string BackendProtocol { get; set; }

                /// <summary>
                /// <para>Tthe container port of the application specified in the forwarding rules.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("ContainerPort")]
                [Validation(Required=false)]
                public int? ContainerPort { get; set; }

                /// <summary>
                /// <para>The domain name of the application specified in the forwarding rules.</para>
                /// 
                /// <b>Example:</b>
                /// <para>edas.site</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The path of a URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/path1</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The path that is used to rewrite the original path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/${1}</para>
                /// </summary>
                [NameInMap("RewritePath")]
                [Validation(Required=false)]
                public string RewritePath { get; set; }

                [NameInMap("RuleActions")]
                [Validation(Required=false)]
                public List<DescribeIngressResponseBodyDataRulesRuleActions> RuleActions { get; set; }
                public class DescribeIngressResponseBodyDataRulesRuleActions : TeaModel {
                    [NameInMap("ActionConfig")]
                    [Validation(Required=false)]
                    public string ActionConfig { get; set; }

                    [NameInMap("ActionType")]
                    [Validation(Required=false)]
                    public string ActionType { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sp-n0kn923****</para>
            /// </summary>
            [NameInMap("SecurityPolicyId")]
            [Validation(Required=false)]
            public string SecurityPolicyId { get; set; }

            /// <summary>
            /// <para>The ID of a Server Load Balancer (SLB) instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-uf62****6d13tq2u5</para>
            /// </summary>
            [NameInMap("SlbId")]
            [Validation(Required=false)]
            public string SlbId { get; set; }

            /// <summary>
            /// <para>The type of an SLB instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>internet</b>: an Internet-facing SLB instance</description></item>
            /// <item><description><b>intranet</b>: an Intranet-facing SLB instance</description></item>
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
        /// <para>The error codes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ErrorCode</b> is not returned if a request is successful.</description></item>
        /// <item><description><b>ErrorCode</b> is returned if a request failed. For more information, see <b>Error code</b> section of this topic.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The message returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>success</b> is returned when a request is successful.</description></item>
        /// <item><description>An error code is returned when the request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91F93257-7A4A-4BD3-9A7E-2F6EAE6D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the configurations of Ingresses were queried successfully. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The information was queried.</description></item>
        /// <item><description><b>false</b>: The information failed to be queried.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The ID of a trace. The ID is used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a981dd515966966104121683d****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
