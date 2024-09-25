// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetGatewayRouteDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned. A value of 200 indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGatewayRouteDetailResponseBodyData Data { get; set; }
        public class GetGatewayRouteDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The status of Application High Availability Service (AHAS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AhasStatus")]
            [Validation(Required=false)]
            public int? AhasStatus { get; set; }

            /// <summary>
            /// <para>The configuration for cross-origin resource sharing (CORS).</para>
            /// </summary>
            [NameInMap("Cors")]
            [Validation(Required=false)]
            public GetGatewayRouteDetailResponseBodyDataCors Cors { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataCors : TeaModel {
                /// <summary>
                /// <para>The credentials allowed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AllowCredentials")]
                [Validation(Required=false)]
                public bool? AllowCredentials { get; set; }

                /// <summary>
                /// <para>The headers allowed.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("AllowHeaders")]
                [Validation(Required=false)]
                public string AllowHeaders { get; set; }

                /// <summary>
                /// <para>The methods allowed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GET,POST,PUT,DELETE,HEAD,OPTIONS,PATCH</para>
                /// </summary>
                [NameInMap("AllowMethods")]
                [Validation(Required=false)]
                public string AllowMethods { get; set; }

                /// <summary>
                /// <para>The origins allowed.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("AllowOrigins")]
                [Validation(Required=false)]
                public string AllowOrigins { get; set; }

                /// <summary>
                /// <para>The response headers.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("ExposeHeaders")]
                [Validation(Required=false)]
                public string ExposeHeaders { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The time unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>h</para>
                /// </summary>
                [NameInMap("TimeUnit")]
                [Validation(Required=false)]
                public string TimeUnit { get; set; }

                /// <summary>
                /// <para>The unit number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>24</para>
                /// </summary>
                [NameInMap("UnitNum")]
                [Validation(Required=false)]
                public long? UnitNum { get; set; }

            }

            /// <summary>
            /// <para>The default service ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("DefaultServiceId")]
            [Validation(Required=false)]
            public long? DefaultServiceId { get; set; }

            /// <summary>
            /// <para>The default service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DefaultServiceName")]
            [Validation(Required=false)]
            public string DefaultServiceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>a route for xxx</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The destination service type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Single</para>
            /// </summary>
            [NameInMap("DestinationType")]
            [Validation(Required=false)]
            public string DestinationType { get; set; }

            /// <summary>
            /// <para>The information about service mocking.</para>
            /// </summary>
            [NameInMap("DirectResponse")]
            [Validation(Required=false)]
            public GetGatewayRouteDetailResponseBodyDataDirectResponse DirectResponse { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataDirectResponse : TeaModel {
                /// <summary>
                /// <para>The mock return value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public string Body { get; set; }

                /// <summary>
                /// <para>The response code returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

            }

            /// <summary>
            /// <para>The domain ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>235</para>
            /// </summary>
            [NameInMap("DomainId")]
            [Validation(Required=false)]
            public long? DomainId { get; set; }

            /// <summary>
            /// <para>The IDs of domains.</para>
            /// </summary>
            [NameInMap("DomainIdList")]
            [Validation(Required=false)]
            public List<long?> DomainIdList { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The list of domain names.</para>
            /// </summary>
            [NameInMap("DomainNameList")]
            [Validation(Required=false)]
            public List<string> DomainNameList { get; set; }

            /// <summary>
            /// <para>Indicates whether Web Application Firewall (WAF) is activated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableWaf")]
            [Validation(Required=false)]
            public bool? EnableWaf { get; set; }

            /// <summary>
            /// <para>Indicates whether the Fallback service is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Fallback")]
            [Validation(Required=false)]
            public bool? Fallback { get; set; }

            /// <summary>
            /// <para>The information of the Fallback service.</para>
            /// </summary>
            [NameInMap("FallbackServices")]
            [Validation(Required=false)]
            public List<GetGatewayRouteDetailResponseBodyDataFallbackServices> FallbackServices { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataFallbackServices : TeaModel {
                /// <summary>
                /// <para>The protocol type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DUBBO</para>
                /// </summary>
                [NameInMap("AgreementType")]
                [Validation(Required=false)]
                public string AgreementType { get; set; }

                /// <summary>
                /// <para>The name of the group to which the service belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The namespace to which the service belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>namespace</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The weight in the form of a percentage value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Percent")]
                [Validation(Required=false)]
                public int? Percent { get; set; }

                /// <summary>
                /// <para>The service ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ServiceId")]
                [Validation(Required=false)]
                public long? ServiceId { get; set; }

                /// <summary>
                /// <para>The service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                /// <summary>
                /// <para>The port number of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8848</para>
                /// </summary>
                [NameInMap("ServicePort")]
                [Validation(Required=false)]
                public int? ServicePort { get; set; }

                /// <summary>
                /// <para>The source type of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MSE</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The service version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>流量镜像配置。</para>
            /// </summary>
            [NameInMap("FlowMirror")]
            [Validation(Required=false)]
            public GetGatewayRouteDetailResponseBodyDataFlowMirror FlowMirror { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataFlowMirror : TeaModel {
                /// <summary>
                /// <para>流量复制比例（%），取值0-100。</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("Percentage")]
                [Validation(Required=false)]
                public int? Percentage { get; set; }

                /// <summary>
                /// <para>目标服务端口。</para>
                /// 
                /// <b>Example:</b>
                /// <para>8790</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>开启状态，取值：</para>
                /// <list type="bullet">
                /// <item><description>on：开启</description></item>
                /// <item><description>off：关闭</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>目标服务ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>21</para>
                /// </summary>
                [NameInMap("TargetServiceId")]
                [Validation(Required=false)]
                public long? TargetServiceId { get; set; }

                /// <summary>
                /// <para>目标服务名称。</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("TargetServiceName")]
                [Validation(Required=false)]
                public string TargetServiceName { get; set; }

            }

            /// <summary>
            /// <para>The ID of the gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public long? GatewayId { get; set; }

            /// <summary>
            /// <para>The unique ID of the gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-7ea3da97b96543e19f6c597c****</para>
            /// </summary>
            [NameInMap("GatewayUniqueId")]
            [Validation(Required=false)]
            public string GatewayUniqueId { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-07 18:07:57</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The last modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-07T10:07:57.000+0000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The information about the rewrite policy.</para>
            /// </summary>
            [NameInMap("HTTPRewrite")]
            [Validation(Required=false)]
            public GetGatewayRouteDetailResponseBodyDataHTTPRewrite HTTPRewrite { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataHTTPRewrite : TeaModel {
                /// <summary>
                /// <para>The hostname of the gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliyuncs.com</para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>The path of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/test/client</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The rewrite type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PRE</para>
                /// </summary>
                [NameInMap("PathType")]
                [Validation(Required=false)]
                public string PathType { get; set; }

                /// <summary>
                /// <para>The matching pattern.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/test</para>
                /// </summary>
                [NameInMap("Pattern")]
                [Validation(Required=false)]
                public string Pattern { get; set; }

                /// <summary>
                /// <para>The status of the policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The replacement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Substitution")]
                [Validation(Required=false)]
                public string Substitution { get; set; }

            }

            /// <summary>
            /// <para>The header settings.</para>
            /// </summary>
            [NameInMap("HeaderOp")]
            [Validation(Required=false)]
            public GetGatewayRouteDetailResponseBodyDataHeaderOp HeaderOp { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataHeaderOp : TeaModel {
                /// <summary>
                /// <para>The information about headers.</para>
                /// </summary>
                [NameInMap("HeaderOpItems")]
                [Validation(Required=false)]
                public List<GetGatewayRouteDetailResponseBodyDataHeaderOpHeaderOpItems> HeaderOpItems { get; set; }
                public class GetGatewayRouteDetailResponseBodyDataHeaderOpHeaderOpItems : TeaModel {
                    /// <summary>
                    /// <para>The request or response.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Response</para>
                    /// </summary>
                    [NameInMap("DirectionType")]
                    [Validation(Required=false)]
                    public string DirectionType { get; set; }

                    /// <summary>
                    /// <para>The header key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>debug</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The type of the operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Add</para>
                    /// </summary>
                    [NameInMap("OpType")]
                    [Validation(Required=false)]
                    public string OpType { get; set; }

                    /// <summary>
                    /// <para>The header value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1050</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The routing policy in a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;CORS&quot;: &quot;{\&quot;allowMethods\&quot;:\&quot;GET,POST,PUT,DELETE,HEAD,OPTIONS,PATCH\&quot;,\&quot;allowHeaders\&quot;:\&quot;<em>\&quot;,\&quot;exposeHeaders\&quot;:\&quot;</em>\&quot;,\&quot;unitNum\&quot;:12,\&quot;allowCredentials\&quot;:true,\&quot;status\&quot;:\&quot;off\&quot;,\&quot;allowOrigins\&quot;:\&quot;*\&quot;,\&quot;timeUnit\&quot;:\&quot;h\&quot;}&quot;,
            ///       &quot;Timeout&quot;: &quot;{\&quot;unitNum\&quot;:10,\&quot;timeUnit\&quot;:\&quot;s\&quot;,\&quot;status\&quot;:\&quot;off\&quot;}&quot;,
            ///       &quot;Retry&quot;: &quot;{\&quot;attempts\&quot;:2,\&quot;retryOn\&quot;:[\&quot;5xx\&quot;],\&quot;status\&quot;:\&quot;off\&quot;}&quot;,
            ///       &quot;HTTPRewrite&quot;: &quot;{\&quot;pathType\&quot;:\&quot;EQUAL\&quot;,\&quot;path\&quot;:\&quot;/o\&quot;,\&quot;status\&quot;:\&quot;off\&quot;}&quot;,
            ///       &quot;Waf&quot;: &quot;{\&quot;enabled\&quot;:false}&quot;,
            ///       &quot;HeaderOp&quot;: &quot;{\&quot;status\&quot;:\&quot;off\&quot;,\&quot;headerOpItems\&quot;:[{\&quot;directionType\&quot;:\&quot;Request\&quot;,\&quot;opType\&quot;:\&quot;Add\&quot;,\&quot;key\&quot;:\&quot;kkk\&quot;,\&quot;value\&quot;:\&quot;ll\&quot;}]}&quot;
            /// }</para>
            /// </summary>
            [NameInMap("Policies")]
            [Validation(Required=false)]
            public string Policies { get; set; }

            /// <summary>
            /// <para>The matching conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Predicates")]
            [Validation(Required=false)]
            public string Predicates { get; set; }

            /// <summary>
            /// <para>The configuration of the redirection.</para>
            /// </summary>
            [NameInMap("Redirect")]
            [Validation(Required=false)]
            public GetGatewayRouteDetailResponseBodyDataRedirect Redirect { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataRedirect : TeaModel {
                /// <summary>
                /// <para>The response code returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

                /// <summary>
                /// <para>The hostname.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>The path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10111</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

            /// <summary>
            /// <para>The retry configuration.</para>
            /// </summary>
            [NameInMap("Retry")]
            [Validation(Required=false)]
            public GetGatewayRouteDetailResponseBodyDataRetry Retry { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataRetry : TeaModel {
                /// <summary>
                /// <para>The number of retries allowed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Attempts")]
                [Validation(Required=false)]
                public int? Attempts { get; set; }

                /// <summary>
                /// <para>The HTTP status codes.</para>
                /// </summary>
                [NameInMap("HttpCodes")]
                [Validation(Required=false)]
                public List<string> HttpCodes { get; set; }

                /// <summary>
                /// <para>The retry condition.</para>
                /// </summary>
                [NameInMap("RetryOn")]
                [Validation(Required=false)]
                public List<string> RetryOn { get; set; }

                /// <summary>
                /// <para>The retry status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The sequence number of the route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RouteOrder")]
            [Validation(Required=false)]
            public int? RouteOrder { get; set; }

            /// <summary>
            /// <para>The information about route matching.</para>
            /// </summary>
            [NameInMap("RoutePredicates")]
            [Validation(Required=false)]
            public GetGatewayRouteDetailResponseBodyDataRoutePredicates RoutePredicates { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataRoutePredicates : TeaModel {
                /// <summary>
                /// <para>The information about header matching.</para>
                /// </summary>
                [NameInMap("HeaderPredicates")]
                [Validation(Required=false)]
                public List<GetGatewayRouteDetailResponseBodyDataRoutePredicatesHeaderPredicates> HeaderPredicates { get; set; }
                public class GetGatewayRouteDetailResponseBodyDataRoutePredicatesHeaderPredicates : TeaModel {
                    /// <summary>
                    /// <para>The key of the request header.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>id</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The route type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PRE</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The value of the request header.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The information about method matching.</para>
                /// </summary>
                [NameInMap("MethodPredicates")]
                [Validation(Required=false)]
                public List<string> MethodPredicates { get; set; }

                /// <summary>
                /// <para>The information about route matching.</para>
                /// </summary>
                [NameInMap("PathPredicates")]
                [Validation(Required=false)]
                public GetGatewayRouteDetailResponseBodyDataRoutePredicatesPathPredicates PathPredicates { get; set; }
                public class GetGatewayRouteDetailResponseBodyDataRoutePredicatesPathPredicates : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether case sensitivity is ignored.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("IgnoreCase")]
                    [Validation(Required=false)]
                    public bool? IgnoreCase { get; set; }

                    /// <summary>
                    /// <para>The path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/api</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The matching type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PRE</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The information about parameter matching.</para>
                /// </summary>
                [NameInMap("QueryPredicates")]
                [Validation(Required=false)]
                public List<GetGatewayRouteDetailResponseBodyDataRoutePredicatesQueryPredicates> QueryPredicates { get; set; }
                public class GetGatewayRouteDetailResponseBodyDataRoutePredicatesQueryPredicates : TeaModel {
                    /// <summary>
                    /// <para>The parameter name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>userid</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The route type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PRE</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The value of the parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The services.</para>
            /// </summary>
            [NameInMap("RouteServices")]
            [Validation(Required=false)]
            public List<GetGatewayRouteDetailResponseBodyDataRouteServices> RouteServices { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataRouteServices : TeaModel {
                /// <summary>
                /// <para>The protocol type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DUBBO</para>
                /// </summary>
                [NameInMap("AgreementType")]
                [Validation(Required=false)]
                public string AgreementType { get; set; }

                /// <summary>
                /// <para>The name of the group to which the service belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>api</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Health</para>
                /// </summary>
                [NameInMap("HealthStatus")]
                [Validation(Required=false)]
                public string HealthStatus { get; set; }

                [NameInMap("HttpDubboTranscoder")]
                [Validation(Required=false)]
                public GetGatewayRouteDetailResponseBodyDataRouteServicesHttpDubboTranscoder HttpDubboTranscoder { get; set; }
                public class GetGatewayRouteDetailResponseBodyDataRouteServicesHttpDubboTranscoder : TeaModel {
                    [NameInMap("DubboServiceGroup")]
                    [Validation(Required=false)]
                    public string DubboServiceGroup { get; set; }

                    [NameInMap("DubboServiceName")]
                    [Validation(Required=false)]
                    public string DubboServiceName { get; set; }

                    [NameInMap("DubboServiceVersion")]
                    [Validation(Required=false)]
                    public string DubboServiceVersion { get; set; }

                    [NameInMap("MothedMapList")]
                    [Validation(Required=false)]
                    public List<GetGatewayRouteDetailResponseBodyDataRouteServicesHttpDubboTranscoderMothedMapList> MothedMapList { get; set; }
                    public class GetGatewayRouteDetailResponseBodyDataRouteServicesHttpDubboTranscoderMothedMapList : TeaModel {
                        [NameInMap("DubboMothedName")]
                        [Validation(Required=false)]
                        public string DubboMothedName { get; set; }

                        [NameInMap("HttpMothed")]
                        [Validation(Required=false)]
                        public string HttpMothed { get; set; }

                        [NameInMap("Mothedpath")]
                        [Validation(Required=false)]
                        public string Mothedpath { get; set; }

                        [NameInMap("ParamMapsList")]
                        [Validation(Required=false)]
                        public List<GetGatewayRouteDetailResponseBodyDataRouteServicesHttpDubboTranscoderMothedMapListParamMapsList> ParamMapsList { get; set; }
                        public class GetGatewayRouteDetailResponseBodyDataRouteServicesHttpDubboTranscoderMothedMapListParamMapsList : TeaModel {
                            [NameInMap("ExtractKey")]
                            [Validation(Required=false)]
                            public string ExtractKey { get; set; }

                            [NameInMap("ExtractKeySpec")]
                            [Validation(Required=false)]
                            public string ExtractKeySpec { get; set; }

                            [NameInMap("MappingType")]
                            [Validation(Required=false)]
                            public string MappingType { get; set; }

                        }

                        [NameInMap("PassThroughAllHeaders")]
                        [Validation(Required=false)]
                        public string PassThroughAllHeaders { get; set; }

                        [NameInMap("PassThroughList")]
                        [Validation(Required=false)]
                        public List<string> PassThroughList { get; set; }

                    }

                }

                /// <summary>
                /// <para>The service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dubbo4</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs_ecs_dashboard</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The weight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Percent")]
                [Validation(Required=false)]
                public int? Percent { get; set; }

                /// <summary>
                /// <para>The service ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>782</para>
                /// </summary>
                [NameInMap("ServiceId")]
                [Validation(Required=false)]
                public long? ServiceId { get; set; }

                /// <summary>
                /// <para>The service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xkc-crm</para>
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                /// <summary>
                /// <para>The port number of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20880</para>
                /// </summary>
                [NameInMap("ServicePort")]
                [Validation(Required=false)]
                public int? ServicePort { get; set; }

                /// <summary>
                /// <para>The source type of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MSE</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("UnhealthyEndpoints")]
                [Validation(Required=false)]
                public List<string> UnhealthyEndpoints { get; set; }

                /// <summary>
                /// <para>The service version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The configurations of services.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;Percent\&quot;:100,\&quot;ServiceId\&quot;:126}]</para>
            /// </summary>
            [NameInMap("Services")]
            [Validation(Required=false)]
            public string Services { get; set; }

            /// <summary>
            /// <para>The status of the route. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: unpublished</description></item>
            /// <item><description>2: publishing</description></item>
            /// <item><description>3: published</description></item>
            /// <item><description>4: editing (updated but not published)</description></item>
            /// <item><description>5: unpublishing</description></item>
            /// <item><description>6: unavailable</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The timeout configuration.</para>
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public GetGatewayRouteDetailResponseBodyDataTimeout Timeout { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataTimeout : TeaModel {
                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The time unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>s</para>
                /// </summary>
                [NameInMap("TimeUnit")]
                [Validation(Required=false)]
                public string TimeUnit { get; set; }

                /// <summary>
                /// <para>The unit number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("UnitNum")]
                [Validation(Required=false)]
                public int? UnitNum { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You are not authorized to perform this operation.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FDF2D16C-5D28-5FAA-A56B-30BDE3559880</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request was successful.</description></item>
        /// <item><description><c>false</c>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
