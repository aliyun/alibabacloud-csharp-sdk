// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListIngressesResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of the API call or a POP error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: The call was successful.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: The call was redirected.</para>
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
        /// <para>The result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListIngressesResponseBodyData Data { get; set; }
        public class ListIngressesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The current page.</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The list of routing rules.</para>
            /// </summary>
            [NameInMap("IngressList")]
            [Validation(Required=false)]
            public List<ListIngressesResponseBodyDataIngressList> IngressList { get; set; }
            public class ListIngressesResponseBodyDataIngressList : TeaModel {
                /// <summary>
                /// <para>The ID of the Classic Load Balancer (CLB) certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13624*<b><b>73809_16f8e549a20_1175189789_12</b></b>3210</para>
                /// </summary>
                [NameInMap("CertId")]
                [Validation(Required=false)]
                public string CertId { get; set; }

                /// <summary>
                /// <para>The IDs of the Application Load Balancer (ALB) certificates.</para>
                /// 
                /// <b>Example:</b>
                /// <para>87<em><b>35-cn-hangzhou,812</b></em>3-cn-hangzhou</para>
                /// </summary>
                [NameInMap("CertIds")]
                [Validation(Required=false)]
                public string CertIds { get; set; }

                /// <summary>
                /// <para>The cross-domain configuration.</para>
                /// </summary>
                [NameInMap("CorsConfig")]
                [Validation(Required=false)]
                public ListIngressesResponseBodyDataIngressListCorsConfig CorsConfig { get; set; }
                public class ListIngressesResponseBodyDataIngressListCorsConfig : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether credentials can be carried.</para>
                    /// </summary>
                    [NameInMap("AllowCredentials")]
                    [Validation(Required=false)]
                    public string AllowCredentials { get; set; }

                    /// <summary>
                    /// <para>The allowed headers.</para>
                    /// </summary>
                    [NameInMap("AllowHeaders")]
                    [Validation(Required=false)]
                    public string AllowHeaders { get; set; }

                    /// <summary>
                    /// <para>The allowed methods.</para>
                    /// </summary>
                    [NameInMap("AllowMethods")]
                    [Validation(Required=false)]
                    public string AllowMethods { get; set; }

                    /// <summary>
                    /// <para>The allowed origins.</para>
                    /// </summary>
                    [NameInMap("AllowOrigin")]
                    [Validation(Required=false)]
                    public string AllowOrigin { get; set; }

                    /// <summary>
                    /// <para>Indicates whether cross-domain access is enabled.</para>
                    /// </summary>
                    [NameInMap("Enable")]
                    [Validation(Required=false)]
                    public string Enable { get; set; }

                    /// <summary>
                    /// <para>The allowed exposed headers.</para>
                    /// </summary>
                    [NameInMap("ExposeHeaders")]
                    [Validation(Required=false)]
                    public string ExposeHeaders { get; set; }

                    /// <summary>
                    /// <para>The time-to-live (TTL).</para>
                    /// </summary>
                    [NameInMap("MaxAge")]
                    [Validation(Required=false)]
                    public string MaxAge { get; set; }

                }

                /// <summary>
                /// <para>The creation time.</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The default rule.</para>
                /// </summary>
                [NameInMap("DefaultRule")]
                [Validation(Required=false)]
                public ListIngressesResponseBodyDataIngressListDefaultRule DefaultRule { get; set; }
                public class ListIngressesResponseBodyDataIngressListDefaultRule : TeaModel {
                    /// <summary>
                    /// <para>The application ID.</para>
                    /// </summary>
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    /// <summary>
                    /// <para>The application name.</para>
                    /// </summary>
                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                    /// <summary>
                    /// <para>The backend protocol.</para>
                    /// </summary>
                    [NameInMap("BackendProtocol")]
                    [Validation(Required=false)]
                    public string BackendProtocol { get; set; }

                    /// <summary>
                    /// <para>The container port.</para>
                    /// </summary>
                    [NameInMap("ContainerPort")]
                    [Validation(Required=false)]
                    public int? ContainerPort { get; set; }

                }

                /// <summary>
                /// <para>The name of the Ingress rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the routing rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The connection idle timeout period.</para>
                /// </summary>
                [NameInMap("IdleTimeout")]
                [Validation(Required=false)]
                public long? IdleTimeout { get; set; }

                /// <summary>
                /// <para>The listening port of the SLB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public string ListenerPort { get; set; }

                /// <summary>
                /// <para>The forwarding protocol of the SLB instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>HTTP</b>: suitable for applications that need to identify data content.</para>
                /// </description></item>
                /// <item><description><para><b>HTTPS</b>: suitable for applications that require encrypted transmission.</para>
                /// </description></item>
                /// </list>
                /// <para>This parameter is optional for the <b>CreateIngress</b> and <b>UpdateIngress</b> operations. If you do not set this parameter when you create or update a gateway routing rule, this parameter is not returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("ListenerProtocol")]
                [Validation(Required=false)]
                public string ListenerProtocol { get; set; }

                /// <summary>
                /// <para>The type of the SLB instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>clb</b>: Classic Load Balancer.</para>
                /// </description></item>
                /// <item><description><para><b>alb</b>: Application Load Balancer.</para>
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
                /// <para>The ID of the MSE cloud-native gateway instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-d5df01a1bae748f1a7c4e325d2fd****</para>
                /// </summary>
                [NameInMap("MseGatewayId")]
                [Validation(Required=false)]
                public string MseGatewayId { get; set; }

                /// <summary>
                /// <para>The port that corresponds to the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("MseGatewayPort")]
                [Validation(Required=false)]
                public string MseGatewayPort { get; set; }

                /// <summary>
                /// <para>The forwarding protocol supported by the MSE cloud-native gateway. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>HTTP</b>: suitable for applications that need to identify data content.</para>
                /// </description></item>
                /// <item><description><para><b>HTTPS</b>: suitable for applications that require encrypted transmission.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("MseGatewayProtocol")]
                [Validation(Required=false)]
                public string MseGatewayProtocol { get; set; }

                /// <summary>
                /// <para>The name of the routing rule.</para>
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
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("NamespaceId")]
                [Validation(Required=false)]
                public string NamespaceId { get; set; }

                /// <summary>
                /// <para>The request timeout period.</para>
                /// </summary>
                [NameInMap("RequestTimeout")]
                [Validation(Required=false)]
                public long? RequestTimeout { get; set; }

                /// <summary>
                /// <para>The rules.</para>
                /// </summary>
                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<ListIngressesResponseBodyDataIngressListRules> Rules { get; set; }
                public class ListIngressesResponseBodyDataIngressListRules : TeaModel {
                    /// <summary>
                    /// <para>The application ID.</para>
                    /// </summary>
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    /// <summary>
                    /// <para>The application name.</para>
                    /// </summary>
                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                    /// <summary>
                    /// <para>The backend protocol.</para>
                    /// </summary>
                    [NameInMap("BackendProtocol")]
                    [Validation(Required=false)]
                    public string BackendProtocol { get; set; }

                    /// <summary>
                    /// <para>The container port.</para>
                    /// </summary>
                    [NameInMap("ContainerPort")]
                    [Validation(Required=false)]
                    public int? ContainerPort { get; set; }

                    /// <summary>
                    /// <para>The domain name.</para>
                    /// </summary>
                    [NameInMap("Domain")]
                    [Validation(Required=false)]
                    public string Domain { get; set; }

                    /// <summary>
                    /// <para>The path.</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The rewritten path.</para>
                    /// </summary>
                    [NameInMap("RewritePath")]
                    [Validation(Required=false)]
                    public string RewritePath { get; set; }

                    /// <summary>
                    /// <para>The list of rule actions.</para>
                    /// </summary>
                    [NameInMap("RuleActions")]
                    [Validation(Required=false)]
                    public List<ListIngressesResponseBodyDataIngressListRulesRuleActions> RuleActions { get; set; }
                    public class ListIngressesResponseBodyDataIngressListRulesRuleActions : TeaModel {
                        /// <summary>
                        /// <para>The action configuration.</para>
                        /// </summary>
                        [NameInMap("ActionConfig")]
                        [Validation(Required=false)]
                        public string ActionConfig { get; set; }

                        /// <summary>
                        /// <para>The action type.</para>
                        /// </summary>
                        [NameInMap("ActionType")]
                        [Validation(Required=false)]
                        public string ActionType { get; set; }

                    }

                }

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
                /// <item><description><para><b>internet</b>: public network.</para>
                /// </description></item>
                /// <item><description><para><b>intranet</b>: private network.</para>
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
            /// <para>The number of entries per page.</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries found.</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is not returned if the request is successful.</para>
        /// </description></item>
        /// <item><description><para>This parameter is returned if the request fails. For more information, see the <b>Error codes</b> section of this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// <list type="bullet">
        /// <item><description><para><b>success</b> is returned if the call is successful.</para>
        /// </description></item>
        /// <item><description><para>An error code is returned if the call fails.</para>
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
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The call was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The call failed.</para>
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
        /// <para>The trace ID. You can use it to query the details of a call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
