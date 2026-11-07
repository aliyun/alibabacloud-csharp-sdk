// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetGatewayRouteDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code. Note that 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGatewayRouteDetailResponseBodyData Data { get; set; }
        public class GetGatewayRouteDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Ahas status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AhasStatus")]
            [Validation(Required=false)]
            public int? AhasStatus { get; set; }

            /// <summary>
            /// <para>Cross-domain configuration.</para>
            /// </summary>
            [NameInMap("Cors")]
            [Validation(Required=false)]
            public GetGatewayRouteDetailResponseBodyDataCors Cors { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataCors : TeaModel {
                /// <summary>
                /// <para>Allow credentials.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AllowCredentials")]
                [Validation(Required=false)]
                public bool? AllowCredentials { get; set; }

                /// <summary>
                /// <para>Cross-domain Header.</para>
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
                /// <para>Cross-domain methods.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GET,POST,PUT,DELETE,HEAD,OPTIONS,PATCH</para>
                /// </summary>
                [NameInMap("AllowMethods")]
                [Validation(Required=false)]
                public string AllowMethods { get; set; }

                /// <summary>
                /// <para>Cross-domain.</para>
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
                /// <para>Response header.</para>
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
                /// <para>Status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Time unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>h</para>
                /// </summary>
                [NameInMap("TimeUnit")]
                [Validation(Required=false)]
                public string TimeUnit { get; set; }

                /// <summary>
                /// <para>Time number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>24</para>
                /// </summary>
                [NameInMap("UnitNum")]
                [Validation(Required=false)]
                public long? UnitNum { get; set; }

            }

            /// <summary>
            /// <para>Default service ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("DefaultServiceId")]
            [Validation(Required=false)]
            public long? DefaultServiceId { get; set; }

            /// <summary>
            /// <para>Default service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DefaultServiceName")]
            [Validation(Required=false)]
            public string DefaultServiceName { get; set; }

            /// <summary>
            /// <para>Route description</para>
            /// 
            /// <b>Example:</b>
            /// <para>a route for xxx</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Target service type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Single</para>
            /// </summary>
            [NameInMap("DestinationType")]
            [Validation(Required=false)]
            public string DestinationType { get; set; }

            /// <summary>
            /// <para>Mock information.</para>
            /// </summary>
            [NameInMap("DirectResponse")]
            [Validation(Required=false)]
            public GetGatewayRouteDetailResponseBodyDataDirectResponse DirectResponse { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataDirectResponse : TeaModel {
                /// <summary>
                /// <para>Mock return value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public string Body { get; set; }

                /// <summary>
                /// <para>Response code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

            }

            /// <summary>
            /// <para>Domain ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>235</para>
            /// </summary>
            [NameInMap("DomainId")]
            [Validation(Required=false)]
            public long? DomainId { get; set; }

            /// <summary>
            /// <para>Domain list</para>
            /// </summary>
            [NameInMap("DomainIdList")]
            [Validation(Required=false)]
            public List<long?> DomainIdList { get; set; }

            /// <summary>
            /// <para>Domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>Domain name list</para>
            /// </summary>
            [NameInMap("DomainNameList")]
            [Validation(Required=false)]
            public List<string> DomainNameList { get; set; }

            /// <summary>
            /// <para>Whether to enable Waf.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableWaf")]
            [Validation(Required=false)]
            public bool? EnableWaf { get; set; }

            /// <summary>
            /// <para>Whether to enable Fallback service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Fallback")]
            [Validation(Required=false)]
            public bool? Fallback { get; set; }

            /// <summary>
            /// <para>Fallback services.</para>
            /// </summary>
            [NameInMap("FallbackServices")]
            [Validation(Required=false)]
            public List<GetGatewayRouteDetailResponseBodyDataFallbackServices> FallbackServices { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataFallbackServices : TeaModel {
                /// <summary>
                /// <para>Protocol Type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DUBBO</para>
                /// </summary>
                [NameInMap("AgreementType")]
                [Validation(Required=false)]
                public string AgreementType { get; set; }

                /// <summary>
                /// <para>Service group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>Name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Service namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>namespace</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>Weight percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Percent")]
                [Validation(Required=false)]
                public int? Percent { get; set; }

                /// <summary>
                /// <para>Service ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ServiceId")]
                [Validation(Required=false)]
                public long? ServiceId { get; set; }

                /// <summary>
                /// <para>Service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                /// <summary>
                /// <para>Service port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8848</para>
                /// </summary>
                [NameInMap("ServicePort")]
                [Validation(Required=false)]
                public int? ServicePort { get; set; }

                /// <summary>
                /// <para>Source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MSE</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>Service version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>Traffic mirroring configuration.</para>
            /// </summary>
            [NameInMap("FlowMirror")]
            [Validation(Required=false)]
            public GetGatewayRouteDetailResponseBodyDataFlowMirror FlowMirror { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataFlowMirror : TeaModel {
                /// <summary>
                /// <para>Traffic replication percentage (%), value range 0-100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("Percentage")]
                [Validation(Required=false)]
                public int? Percentage { get; set; }

                /// <summary>
                /// <para>Target service port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8790</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>Enabling status, values:</para>
                /// <list type="bullet">
                /// <item><description><para>on: enabled</para>
                /// </description></item>
                /// <item><description><para>off: disabled</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Target service ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>21</para>
                /// </summary>
                [NameInMap("TargetServiceId")]
                [Validation(Required=false)]
                public long? TargetServiceId { get; set; }

                /// <summary>
                /// <para>Target service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("TargetServiceName")]
                [Validation(Required=false)]
                public string TargetServiceName { get; set; }

            }

            /// <summary>
            /// <para>Gateway ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public long? GatewayId { get; set; }

            /// <summary>
            /// <para>Gateway unique identifier ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-7ea3da97b96543e19f6c597c****</para>
            /// </summary>
            [NameInMap("GatewayUniqueId")]
            [Validation(Required=false)]
            public string GatewayUniqueId { get; set; }

            /// <summary>
            /// <para>Creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-07 18:07:57</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>Last modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-07T10:07:57.000+0000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>Rewrite policy information.</para>
            /// </summary>
            [NameInMap("HTTPRewrite")]
            [Validation(Required=false)]
            public GetGatewayRouteDetailResponseBodyDataHTTPRewrite HTTPRewrite { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataHTTPRewrite : TeaModel {
                /// <summary>
                /// <para>Instance address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliyuncs.com</para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>Node path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/test/client</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>Rewrite type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PRE</para>
                /// </summary>
                [NameInMap("PathType")]
                [Validation(Required=false)]
                public string PathType { get; set; }

                /// <summary>
                /// <para>Matching Pattern.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/test</para>
                /// </summary>
                [NameInMap("Pattern")]
                [Validation(Required=false)]
                public string Pattern { get; set; }

                /// <summary>
                /// <para>Enabling status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Replacement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Substitution")]
                [Validation(Required=false)]
                public string Substitution { get; set; }

            }

            /// <summary>
            /// <para>Header settings information.</para>
            /// </summary>
            [NameInMap("HeaderOp")]
            [Validation(Required=false)]
            public GetGatewayRouteDetailResponseBodyDataHeaderOp HeaderOp { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataHeaderOp : TeaModel {
                /// <summary>
                /// <para>Header field objects.</para>
                /// </summary>
                [NameInMap("HeaderOpItems")]
                [Validation(Required=false)]
                public List<GetGatewayRouteDetailResponseBodyDataHeaderOpHeaderOpItems> HeaderOpItems { get; set; }
                public class GetGatewayRouteDetailResponseBodyDataHeaderOpHeaderOpItems : TeaModel {
                    /// <summary>
                    /// <para>Request or response.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Response</para>
                    /// </summary>
                    [NameInMap("DirectionType")]
                    [Validation(Required=false)]
                    public string DirectionType { get; set; }

                    /// <summary>
                    /// <para>Header Key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>debug</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>Operation type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Add</para>
                    /// </summary>
                    [NameInMap("OpType")]
                    [Validation(Required=false)]
                    public string OpType { get; set; }

                    /// <summary>
                    /// <para>Setting value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>Status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1050</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Routing policy Json string.</para>
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
            /// <para>Matching conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Predicates")]
            [Validation(Required=false)]
            public string Predicates { get; set; }

            /// <summary>
            /// <para>Redirection configuration</para>
            /// </summary>
            [NameInMap("Redirect")]
            [Validation(Required=false)]
            public GetGatewayRouteDetailResponseBodyDataRedirect Redirect { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataRedirect : TeaModel {
                /// <summary>
                /// <para>Response code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

                /// <summary>
                /// <para>Host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>Path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10111</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

            /// <summary>
            /// <para>Retry configuration.</para>
            /// </summary>
            [NameInMap("Retry")]
            [Validation(Required=false)]
            public GetGatewayRouteDetailResponseBodyDataRetry Retry { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataRetry : TeaModel {
                /// <summary>
                /// <para>Number of retry attempts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Attempts")]
                [Validation(Required=false)]
                public int? Attempts { get; set; }

                /// <summary>
                /// <para>HTTP status codes.</para>
                /// </summary>
                [NameInMap("HttpCodes")]
                [Validation(Required=false)]
                public List<string> HttpCodes { get; set; }

                /// <summary>
                /// <para>Retry conditions.</para>
                /// </summary>
                [NameInMap("RetryOn")]
                [Validation(Required=false)]
                public List<string> RetryOn { get; set; }

                /// <summary>
                /// <para>Retry status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>Route order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RouteOrder")]
            [Validation(Required=false)]
            public int? RouteOrder { get; set; }

            /// <summary>
            /// <para>Route matching.</para>
            /// </summary>
            [NameInMap("RoutePredicates")]
            [Validation(Required=false)]
            public GetGatewayRouteDetailResponseBodyDataRoutePredicates RoutePredicates { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataRoutePredicates : TeaModel {
                /// <summary>
                /// <para>Header matching.</para>
                /// </summary>
                [NameInMap("HeaderPredicates")]
                [Validation(Required=false)]
                public List<GetGatewayRouteDetailResponseBodyDataRoutePredicatesHeaderPredicates> HeaderPredicates { get; set; }
                public class GetGatewayRouteDetailResponseBodyDataRoutePredicatesHeaderPredicates : TeaModel {
                    /// <summary>
                    /// <para>Request header KEY.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>id</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>Type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PRE</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>Matching value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>Method matching.</para>
                /// </summary>
                [NameInMap("MethodPredicates")]
                [Validation(Required=false)]
                public List<string> MethodPredicates { get; set; }

                /// <summary>
                /// <para>Route matching.</para>
                /// </summary>
                [NameInMap("PathPredicates")]
                [Validation(Required=false)]
                public GetGatewayRouteDetailResponseBodyDataRoutePredicatesPathPredicates PathPredicates { get; set; }
                public class GetGatewayRouteDetailResponseBodyDataRoutePredicatesPathPredicates : TeaModel {
                    /// <summary>
                    /// <para>Whether to ignore case.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("IgnoreCase")]
                    [Validation(Required=false)]
                    public bool? IgnoreCase { get; set; }

                    /// <summary>
                    /// <para>Path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/api</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>Matching type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PRE</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>Parameter matching.</para>
                /// </summary>
                [NameInMap("QueryPredicates")]
                [Validation(Required=false)]
                public List<GetGatewayRouteDetailResponseBodyDataRoutePredicatesQueryPredicates> QueryPredicates { get; set; }
                public class GetGatewayRouteDetailResponseBodyDataRoutePredicatesQueryPredicates : TeaModel {
                    /// <summary>
                    /// <para>Parameter name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>userid</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>Type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PRE</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>Matching value.</para>
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
            /// <para>Services.</para>
            /// </summary>
            [NameInMap("RouteServices")]
            [Validation(Required=false)]
            public List<GetGatewayRouteDetailResponseBodyDataRouteServices> RouteServices { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataRouteServices : TeaModel {
                /// <summary>
                /// <para>Protocol Type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DUBBO</para>
                /// </summary>
                [NameInMap("AgreementType")]
                [Validation(Required=false)]
                public string AgreementType { get; set; }

                /// <summary>
                /// <para>Service group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>api</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>Health status</para>
                /// <list type="bullet">
                /// <item><description><para>Health</para>
                /// </description></item>
                /// <item><description><para>Unhealthy</para>
                /// </description></item>
                /// <item><description><para>Checking</para>
                /// </description></item>
                /// <item><description><para>Unknown</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Health</para>
                /// </summary>
                [NameInMap("HealthStatus")]
                [Validation(Required=false)]
                public string HealthStatus { get; set; }

                /// <summary>
                /// <para>Dubbo protocol conversion body.</para>
                /// </summary>
                [NameInMap("HttpDubboTranscoder")]
                [Validation(Required=false)]
                public GetGatewayRouteDetailResponseBodyDataRouteServicesHttpDubboTranscoder HttpDubboTranscoder { get; set; }
                public class GetGatewayRouteDetailResponseBodyDataRouteServicesHttpDubboTranscoder : TeaModel {
                    /// <summary>
                    /// <para>Dubbo service group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>service group</para>
                    /// </summary>
                    [NameInMap("DubboServiceGroup")]
                    [Validation(Required=false)]
                    public string DubboServiceGroup { get; set; }

                    /// <summary>
                    /// <para>Dubbo service name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>org.apache.dubbo.samples.basic.api.DemoService</para>
                    /// </summary>
                    [NameInMap("DubboServiceName")]
                    [Validation(Required=false)]
                    public string DubboServiceName { get; set; }

                    /// <summary>
                    /// <para>Dubbo service version.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0.0</para>
                    /// </summary>
                    [NameInMap("DubboServiceVersion")]
                    [Validation(Required=false)]
                    public string DubboServiceVersion { get; set; }

                    /// <summary>
                    /// <para>Dubbo forwarding rule list.</para>
                    /// </summary>
                    [NameInMap("MothedMapList")]
                    [Validation(Required=false)]
                    public List<GetGatewayRouteDetailResponseBodyDataRouteServicesHttpDubboTranscoderMothedMapList> MothedMapList { get; set; }
                    public class GetGatewayRouteDetailResponseBodyDataRouteServicesHttpDubboTranscoderMothedMapList : TeaModel {
                        /// <summary>
                        /// <para>Dubbo method name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>sayHello</para>
                        /// </summary>
                        [NameInMap("DubboMothedName")]
                        [Validation(Required=false)]
                        public string DubboMothedName { get; set; }

                        /// <summary>
                        /// <para>Http method.</para>
                        /// <remarks>
                        /// <para>Supported http method parameter values.</para>
                        /// <list type="bullet">
                        /// <item><description><para>ALL_GET</para>
                        /// </description></item>
                        /// <item><description><para>ALL_POST</para>
                        /// </description></item>
                        /// <item><description><para>ALL_PUT</para>
                        /// </description></item>
                        /// <item><description><para>ALL_DELETE</para>
                        /// </description></item>
                        /// <item><description><para>ALL_PATCH</para>
                        /// </description></item>
                        /// </list>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ALL_GET</para>
                        /// </summary>
                        [NameInMap("HttpMothed")]
                        [Validation(Required=false)]
                        public string HttpMothed { get; set; }

                        /// <summary>
                        /// <para>Method matching path.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/mytestzbk/sayhello</para>
                        /// </summary>
                        [NameInMap("Mothedpath")]
                        [Validation(Required=false)]
                        public string Mothedpath { get; set; }

                        /// <summary>
                        /// <para>Parameter mapping list.</para>
                        /// </summary>
                        [NameInMap("ParamMapsList")]
                        [Validation(Required=false)]
                        public List<GetGatewayRouteDetailResponseBodyDataRouteServicesHttpDubboTranscoderMothedMapListParamMapsList> ParamMapsList { get; set; }
                        public class GetGatewayRouteDetailResponseBodyDataRouteServicesHttpDubboTranscoderMothedMapListParamMapsList : TeaModel {
                            /// <summary>
                            /// <para>Input parameter extraction Key.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>name</para>
                            /// </summary>
                            [NameInMap("ExtractKey")]
                            [Validation(Required=false)]
                            public string ExtractKey { get; set; }

                            /// <summary>
                            /// <para>Input parameter position.</para>
                            /// <remarks>
                            /// <para>Input parameter position enumeration values.</para>
                            /// <list type="bullet">
                            /// <item><description><para>Request parameter: <c>ALL_QUERY_PARAMETER</c></para>
                            /// </description></item>
                            /// <item><description><para>Request header: <c>ALL_HEADER</c></para>
                            /// </description></item>
                            /// <item><description><para>URI of the request: <c>ALL_PATH</c></para>
                            /// </description></item>
                            /// <item><description><para>Request body: <c>ALL_BODY</c></para>
                            /// </description></item>
                            /// </list>
                            /// </remarks>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ALL_QUERY_PARAMETER</para>
                            /// </summary>
                            [NameInMap("ExtractKeySpec")]
                            [Validation(Required=false)]
                            public string ExtractKeySpec { get; set; }

                            /// <summary>
                            /// <para>Backend parameter type.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>java.lang.String</para>
                            /// </summary>
                            [NameInMap("MappingType")]
                            [Validation(Required=false)]
                            public string MappingType { get; set; }

                        }

                        /// <summary>
                        /// <para>Header pass-through type.</para>
                        /// <remarks>
                        /// <para>Pass-through type enumeration values.</para>
                        /// <list type="bullet">
                        /// <item><description><para>Pass through all: PASS_ALL</para>
                        /// </description></item>
                        /// <item><description><para>No pass-through: PASS_NOT</para>
                        /// </description></item>
                        /// <item><description><para>Specified parameters: PASS_ASSIGN</para>
                        /// </description></item>
                        /// </list>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PASS_NOT</para>
                        /// </summary>
                        [NameInMap("PassThroughAllHeaders")]
                        [Validation(Required=false)]
                        public string PassThroughAllHeaders { get; set; }

                        /// <summary>
                        /// <para>Specified Header pass-through list.</para>
                        /// </summary>
                        [NameInMap("PassThroughList")]
                        [Validation(Required=false)]
                        public List<string> PassThroughList { get; set; }

                    }

                }

                /// <summary>
                /// <para>Service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dubbo4</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs_ecs_dashboard</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>Weight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Percent")]
                [Validation(Required=false)]
                public int? Percent { get; set; }

                /// <summary>
                /// <para>Service ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>782</para>
                /// </summary>
                [NameInMap("ServiceId")]
                [Validation(Required=false)]
                public long? ServiceId { get; set; }

                /// <summary>
                /// <para>Service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xkc-crm</para>
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                /// <summary>
                /// <para>Service port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20880</para>
                /// </summary>
                [NameInMap("ServicePort")]
                [Validation(Required=false)]
                public int? ServicePort { get; set; }

                /// <summary>
                /// <para>Service source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MSE</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>Unhealthy Endpoint list</para>
                /// </summary>
                [NameInMap("UnhealthyEndpoints")]
                [Validation(Required=false)]
                public List<string> UnhealthyEndpoints { get; set; }

                /// <summary>
                /// <para>Service version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>Service configuration information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;Percent\&quot;:100,\&quot;ServiceId\&quot;:126}]</para>
            /// </summary>
            [NameInMap("Services")]
            [Validation(Required=false)]
            public string Services { get; set; }

            /// <summary>
            /// <para>Route status.</para>
            /// <list type="bullet">
            /// <item><description><para>Not published: 0</para>
            /// </description></item>
            /// <item><description><para>Publishing: 2</para>
            /// </description></item>
            /// <item><description><para>Published: 3</para>
            /// </description></item>
            /// <item><description><para>Editing (updates not published): 4</para>
            /// </description></item>
            /// <item><description><para>Unpublishing: 5</para>
            /// </description></item>
            /// <item><description><para>Unavailable: 6</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Timeout configuration.</para>
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public GetGatewayRouteDetailResponseBodyDataTimeout Timeout { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataTimeout : TeaModel {
                /// <summary>
                /// <para>Status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Time unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>s</para>
                /// </summary>
                [NameInMap("TimeUnit")]
                [Validation(Required=false)]
                public string TimeUnit { get; set; }

                /// <summary>
                /// <para>Unit number.</para>
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
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You are not authorized to perform this operation.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FDF2D16C-5D28-5FAA-A56B-30BDE3559880</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Request result, with the following values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The request is successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The request failed.</para>
        /// </description></item>
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
