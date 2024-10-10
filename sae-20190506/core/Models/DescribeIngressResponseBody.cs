// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeIngressResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The port specified for the SLB listener.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeIngressResponseBodyData Data { get; set; }
        public class DescribeIngressResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the application specified in the default rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13623****809_16cad216b32_845_-419427029</para>
            /// </summary>
            [NameInMap("CertId")]
            [Validation(Required=false)]
            public string CertId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>87<em><b>35-cn-hangzhou,812</b></em>3-cn-hangzhou</para>
            /// </summary>
            [NameInMap("CertIds")]
            [Validation(Required=false)]
            public string CertIds { get; set; }

            /// <summary>
            /// <para>The forwarding rules.</para>
            /// </summary>
            [NameInMap("DefaultRule")]
            [Validation(Required=false)]
            public DescribeIngressResponseBodyDataDefaultRule DefaultRule { get; set; }
            public class DescribeIngressResponseBodyDataDefaultRule : TeaModel {
                /// <summary>
                /// <para>The domain name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>395b60e4-0550-458d-9c54-a265d036****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The container port of the application specified in the forwarding rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app1</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("BackendProtocol")]
                [Validation(Required=false)]
                public string BackendProtocol { get; set; }

                /// <summary>
                /// <para>The name of the application specified in the forwarding rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("ContainerPort")]
                [Validation(Required=false)]
                public int? ContainerPort { get; set; }

            }

            /// <summary>
            /// <para>The name of the routing rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ingress-sae-test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The HTTP status code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>2xx</b>: indicates that the request was successful.</description></item>
            /// <item><description><b>3xx</b>: indicates that the request was redirected.</description></item>
            /// <item><description><b>4xx</b>: indicates that the request was invalid.</description></item>
            /// <item><description><b>5xx</b>: indicates that a server error occurred.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>87</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("IdleTimeout")]
            [Validation(Required=false)]
            public int? IdleTimeout { get; set; }

            /// <summary>
            /// <para>The default rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>443</para>
            /// </summary>
            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public int? ListenerPort { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("ListenerProtocol")]
            [Validation(Required=false)]
            public string ListenerProtocol { get; set; }

            /// <summary>
            /// <para>Indicates whether the configurations of the routing rule were queried successfully. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: indicates that the query was successful.</description></item>
            /// <item><description><b>false</b>: indicates that the query failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>clb</para>
            /// </summary>
            [NameInMap("LoadBalanceType")]
            [Validation(Required=false)]
            public string LoadBalanceType { get; set; }

            /// <summary>
            /// <para>The ID of the application specified in the default rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-uf6jt0nu4z6ior943****-80-f5****</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing:sae-test</para>
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            [NameInMap("RequestTimeout")]
            [Validation(Required=false)]
            public int? RequestTimeout { get; set; }

            /// <summary>
            /// <para>The ID of the application specified in the forwarding rule.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeIngressResponseBodyDataRules> Rules { get; set; }
            public class DescribeIngressResponseBodyDataRules : TeaModel {
                /// <summary>
                /// <para>The protocol used to forward requests. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>HTTP</b>: used when the application needs to identify the transmitted data.</description></item>
                /// <item><description><b>HTTPS</b>: used when the application requires encrypted data transmission.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>395b60e4-0550-458d-9c54-a265d036****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The path of the URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app1</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("BackendProtocol")]
                [Validation(Required=false)]
                public string BackendProtocol { get; set; }

                /// <summary>
                /// <para>The ID of the routing rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("ContainerPort")]
                [Validation(Required=false)]
                public int? ContainerPort { get; set; }

                /// <summary>
                /// <para>The type of the SLB instance based on the processing capabilities. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>clb</b>: the Classic Load Balancer (CLB) instance.</description></item>
                /// <item><description><b>alb</b>: the Application Load Balancer (ALB) instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>edas.site</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The error code.</para>
                /// <list type="bullet">
                /// <item><description>The <b>ErrorCode</b> parameter is not returned when the request succeeds.</description></item>
                /// <item><description>The <b>ErrorCode</b> parameter is returned when the request fails. For more information, see <b>Error codes</b> in this topic.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>/path1</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("RewritePath")]
                [Validation(Required=false)]
                public string RewritePath { get; set; }

            }

            [NameInMap("SecurityPolicyId")]
            [Validation(Required=false)]
            public string SecurityPolicyId { get; set; }

            /// <summary>
            /// <para>The type of the SLB instance based on the IP address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>internet</b>: the Internet-facing SLB instance.</description></item>
            /// <item><description><b>intranet</b>: the internal-facing SLB instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>lb-uf62****6d13tq2u5</para>
            /// </summary>
            [NameInMap("SlbId")]
            [Validation(Required=false)]
            public string SlbId { get; set; }

            /// <summary>
            /// <para>The container port of the application specified in the default rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>internet</para>
            /// </summary>
            [NameInMap("SlbType")]
            [Validation(Required=false)]
            public string SlbType { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The ID of the namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the SLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91F93257-7A4A-4BD3-9A7E-2F6EAE6D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The name of the routing rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a981dd515966966104121683d****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
