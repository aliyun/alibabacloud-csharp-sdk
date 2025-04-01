// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListIngressesResponseBody : TeaModel {
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
        public ListIngressesResponseBodyData Data { get; set; }
        public class ListIngressesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of routing rules.</para>
            /// </summary>
            [NameInMap("IngressList")]
            [Validation(Required=false)]
            public List<ListIngressesResponseBodyDataIngressList> IngressList { get; set; }
            public class ListIngressesResponseBodyDataIngressList : TeaModel {
                /// <summary>
                /// <para>The ID of the certificate that is associated with a Classic Load Balancer (<b>CLB</b>) instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13624*<b><b>73809_16f8e549a20_1175189789_12</b></b>3210</para>
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
                public ListIngressesResponseBodyDataIngressListCorsConfig CorsConfig { get; set; }
                public class ListIngressesResponseBodyDataIngressListCorsConfig : TeaModel {
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

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("DefaultRule")]
                [Validation(Required=false)]
                public ListIngressesResponseBodyDataIngressListDefaultRule DefaultRule { get; set; }
                public class ListIngressesResponseBodyDataIngressListDefaultRule : TeaModel {
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                    [NameInMap("BackendProtocol")]
                    [Validation(Required=false)]
                    public string BackendProtocol { get; set; }

                    [NameInMap("ContainerPort")]
                    [Validation(Required=false)]
                    public int? ContainerPort { get; set; }

                }

                /// <summary>
                /// <para>The name of a routing rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of a routing rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("IdleTimeout")]
                [Validation(Required=false)]
                public long? IdleTimeout { get; set; }

                /// <summary>
                /// <para>The listener ports for an SLB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public string ListenerPort { get; set; }

                /// <summary>
                /// <para>The protocol that is supported by SLB to forward requests. Valid values:</para>
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
                /// <para>The ID of an MSE cloud-native gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-d5df01a1bae748f1a7c4e325d2fd****</para>
                /// </summary>
                [NameInMap("MseGatewayId")]
                [Validation(Required=false)]
                public string MseGatewayId { get; set; }

                /// <summary>
                /// <para>The port of a service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("MseGatewayPort")]
                [Validation(Required=false)]
                public string MseGatewayPort { get; set; }

                /// <summary>
                /// <para>The protocol that is supported by an MSE cloud-native gateway to forward requests. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>HTTP</b>: HTTP is suitable for applications that need to identify transmitted data.</description></item>
                /// <item><description><b>HTTPS</b>: HTTPS is suitable for applications that require encrypted data transmission.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("MseGatewayProtocol")]
                [Validation(Required=false)]
                public string MseGatewayProtocol { get; set; }

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
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("NamespaceId")]
                [Validation(Required=false)]
                public string NamespaceId { get; set; }

                [NameInMap("RequestTimeout")]
                [Validation(Required=false)]
                public long? RequestTimeout { get; set; }

                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<ListIngressesResponseBodyDataIngressListRules> Rules { get; set; }
                public class ListIngressesResponseBodyDataIngressListRules : TeaModel {
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                    [NameInMap("BackendProtocol")]
                    [Validation(Required=false)]
                    public string BackendProtocol { get; set; }

                    [NameInMap("ContainerPort")]
                    [Validation(Required=false)]
                    public int? ContainerPort { get; set; }

                    [NameInMap("Domain")]
                    [Validation(Required=false)]
                    public string Domain { get; set; }

                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    [NameInMap("RewritePath")]
                    [Validation(Required=false)]
                    public string RewritePath { get; set; }

                    [NameInMap("RuleActions")]
                    [Validation(Required=false)]
                    public List<ListIngressesResponseBodyDataIngressListRulesRuleActions> RuleActions { get; set; }
                    public class ListIngressesResponseBodyDataIngressListRulesRuleActions : TeaModel {
                        [NameInMap("ActionConfig")]
                        [Validation(Required=false)]
                        public string ActionConfig { get; set; }

                        [NameInMap("ActionType")]
                        [Validation(Required=false)]
                        public string ActionType { get; set; }

                    }

                }

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
                /// <para>The type of SLB instances. Valid values:</para>
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

        }

        /// <summary>
        /// <para>The error code returned if the request failed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ErrorCode</b> is not returned if a request is successful.</description></item>
        /// <item><description><b>ErrorCode</b> is returned if a request failed. For more information, see <b>Error codes</b>.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The message returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>success</b> is returned when a request is successful.</description></item>
        /// <item><description>An error code is returned when a request failed.</description></item>
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
        /// <para>Indicates whether the list of Ingresses was obtained. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The list were obtained.</description></item>
        /// <item><description><b>false</b>: The list failed to be queried.</description></item>
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
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
