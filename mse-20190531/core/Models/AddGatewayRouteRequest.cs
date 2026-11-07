// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddGatewayRouteRequest : TeaModel {
        /// <summary>
        /// <para>The language of the returned information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The route description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a route for xxx</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination service type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Single: single service</description></item>
        /// <item><description>Multiple: multiple services</description></item>
        /// <item><description>VersionOriented: tag-based routing</description></item>
        /// <item><description>Mock: mock</description></item>
        /// <item><description>Redirect: redirect</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Multiple</para>
        /// </summary>
        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public string DestinationType { get; set; }

        /// <summary>
        /// <para>The mock response configuration.</para>
        /// </summary>
        [NameInMap("DirectResponseJSON")]
        [Validation(Required=false)]
        public AddGatewayRouteRequestDirectResponseJSON DirectResponseJSON { get; set; }
        public class AddGatewayRouteRequestDirectResponseJSON : TeaModel {
            /// <summary>
            /// <para>The mock response body.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hello</para>
            /// </summary>
            [NameInMap("Body")]
            [Validation(Required=false)]
            public string Body { get; set; }

            /// <summary>
            /// <para>The mock response code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>403</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public long? Code { get; set; }

        }

        /// <summary>
        /// <para>The domain name ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("DomainId")]
        [Validation(Required=false)]
        public long? DomainId { get; set; }

        /// <summary>
        /// <para>The domain name list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[0,94]</para>
        /// </summary>
        [NameInMap("DomainIdListJSON")]
        [Validation(Required=false)]
        public string DomainIdListJSON { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use UpdateGatewayRouteWafStatus to update the WAF status of the route.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableWaf")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? EnableWaf { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the fallback service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Fallback")]
        [Validation(Required=false)]
        public bool? Fallback { get; set; }

        /// <summary>
        /// <para>The fallback service.</para>
        /// </summary>
        [NameInMap("FallbackServices")]
        [Validation(Required=false)]
        public List<AddGatewayRouteRequestFallbackServices> FallbackServices { get; set; }
        public class AddGatewayRouteRequestFallbackServices : TeaModel {
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
            /// <para>The service group name.</para>
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
            /// <para>user</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The namespace where the service resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The weight percentage.</para>
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
            /// <para>353</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public long? ServiceId { get; set; }

            /// <summary>
            /// <para>The service port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>443</para>
            /// </summary>
            [NameInMap("ServicePort")]
            [Validation(Required=false)]
            public int? ServicePort { get; set; }

            /// <summary>
            /// <para>The source type.</para>
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
        /// <para>The gateway ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>526</para>
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public long? GatewayId { get; set; }

        /// <summary>
        /// <para>The unique ID of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-492af9b04bb4474cae9d645be8*****</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// <para>The route name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The JSON string of the route policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;CORS&quot;:&quot;{\&quot;allowMethods\&quot;:\&quot;GET,POST,PUT,DELETE,HEAD,OPTIONS,PATCH\&quot;,\&quot;allowHeaders\&quot;:\&quot;<em>\&quot;,\&quot;exposeHeaders\&quot;:\&quot;</em>\&quot;,\&quot;unitNum\&quot;:12,\&quot;allowCredentials\&quot;:true,\&quot;status\&quot;:\&quot;off\&quot;,\&quot;allowOrigins\&quot;:\&quot;*\&quot;,\&quot;timeUnit\&quot;:\&quot;h\&quot;}&quot;,&quot;Timeout&quot;:&quot;{\&quot;unitNum\&quot;:10,\&quot;timeUnit\&quot;:\&quot;s\&quot;,\&quot;status\&quot;:\&quot;off\&quot;}&quot;,&quot;Retry&quot;:&quot;{\&quot;attempts\&quot;:2,\&quot;retryOn\&quot;:[\&quot;5xx\&quot;],\&quot;status\&quot;:\&quot;off\&quot;}&quot;,&quot;HTTPRewrite&quot;:&quot;{\&quot;pathType\&quot;:\&quot;EQUAL\&quot;,\&quot;path\&quot;:\&quot;/o\&quot;,\&quot;status\&quot;:\&quot;off\&quot;}&quot;,&quot;Waf&quot;:&quot;{\&quot;enabled\&quot;:false}&quot;,&quot;HeaderOp&quot;:&quot;{\&quot;status\&quot;:\&quot;off\&quot;,\&quot;headerOpItems\&quot;:[{\&quot;directionType\&quot;:\&quot;Request\&quot;,\&quot;opType\&quot;:\&quot;Add\&quot;,\&quot;key\&quot;:\&quot;kkk\&quot;,\&quot;value\&quot;:\&quot;ll\&quot;}]}&quot;}</para>
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public string Policies { get; set; }

        /// <summary>
        /// <para>The matching rules.</para>
        /// </summary>
        [NameInMap("Predicates")]
        [Validation(Required=false)]
        public AddGatewayRouteRequestPredicates Predicates { get; set; }
        public class AddGatewayRouteRequestPredicates : TeaModel {
            /// <summary>
            /// <para>The request header matching rules.</para>
            /// </summary>
            [NameInMap("HeaderPredicates")]
            [Validation(Required=false)]
            public List<AddGatewayRouteRequestPredicatesHeaderPredicates> HeaderPredicates { get; set; }
            public class AddGatewayRouteRequestPredicatesHeaderPredicates : TeaModel {
                /// <summary>
                /// <para>The request header key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>debug</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The matching type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PRE</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The corresponding value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The method matching rules.</para>
            /// </summary>
            [NameInMap("MethodPredicates")]
            [Validation(Required=false)]
            public List<string> MethodPredicates { get; set; }

            /// <summary>
            /// <para>The path matching rules.</para>
            /// </summary>
            [NameInMap("PathPredicates")]
            [Validation(Required=false)]
            public AddGatewayRouteRequestPredicatesPathPredicates PathPredicates { get; set; }
            public class AddGatewayRouteRequestPredicatesPathPredicates : TeaModel {
                /// <summary>
                /// <para>Specifies whether to ignore case.</para>
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
                /// <para>/test</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The route matching type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PRE: prefix match</description></item>
                /// <item><description>EQUAL: exact match</description></item>
                /// <item><description>ERGULAR: regular expression match</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PRE</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The URL parameter matching rules.</para>
            /// </summary>
            [NameInMap("QueryPredicates")]
            [Validation(Required=false)]
            public List<AddGatewayRouteRequestPredicatesQueryPredicates> QueryPredicates { get; set; }
            public class AddGatewayRouteRequestPredicatesQueryPredicates : TeaModel {
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
                /// <para>The matching type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PRE</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The matching value.</para>
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
        /// <para>The redirect configuration.</para>
        /// </summary>
        [NameInMap("RedirectJSON")]
        [Validation(Required=false)]
        public AddGatewayRouteRequestRedirectJSON RedirectJSON { get; set; }
        public class AddGatewayRouteRequestRedirectJSON : TeaModel {
            /// <summary>
            /// <para>The response code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>302</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public int? Code { get; set; }

            /// <summary>
            /// <para>The redirect hostname.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.com</para>
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <para>The redirect path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/test</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

        /// <summary>
        /// <para>The route order. A smaller value indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RouteOrder")]
        [Validation(Required=false)]
        public int? RouteOrder { get; set; }

        /// <summary>
        /// <para>The route type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Op: management and control route</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Op</para>
        /// </summary>
        [NameInMap("RouteType")]
        [Validation(Required=false)]
        public string RouteType { get; set; }

        /// <summary>
        /// <para>The service list. This parameter is required when the route points to a single service, multiple services, or tag-based routing.</para>
        /// </summary>
        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<AddGatewayRouteRequestServices> Services { get; set; }
        public class AddGatewayRouteRequestServices : TeaModel {
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
            /// <para>The service group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The Dubbo protocol transcoding configuration.</para>
            /// </summary>
            [NameInMap("HttpDubboTranscoder")]
            [Validation(Required=false)]
            public AddGatewayRouteRequestServicesHttpDubboTranscoder HttpDubboTranscoder { get; set; }
            public class AddGatewayRouteRequestServicesHttpDubboTranscoder : TeaModel {
                /// <summary>
                /// <para>The service group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>group</para>
                /// </summary>
                [NameInMap("DubboServiceGroup")]
                [Validation(Required=false)]
                public string DubboServiceGroup { get; set; }

                /// <summary>
                /// <para>The Dubbo service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>org.apache.dubbo.samples.basic.api.DemoService</para>
                /// </summary>
                [NameInMap("DubboServiceName")]
                [Validation(Required=false)]
                public string DubboServiceName { get; set; }

                /// <summary>
                /// <para>The Dubbo service version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.0</para>
                /// </summary>
                [NameInMap("DubboServiceVersion")]
                [Validation(Required=false)]
                public string DubboServiceVersion { get; set; }

                /// <summary>
                /// <para>The list of Dubbo forwarding rules.</para>
                /// </summary>
                [NameInMap("MothedMapList")]
                [Validation(Required=false)]
                public List<AddGatewayRouteRequestServicesHttpDubboTranscoderMothedMapList> MothedMapList { get; set; }
                public class AddGatewayRouteRequestServicesHttpDubboTranscoderMothedMapList : TeaModel {
                    /// <summary>
                    /// <para>The Dubbo method name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sayHello</para>
                    /// </summary>
                    [NameInMap("DubboMothedName")]
                    [Validation(Required=false)]
                    public string DubboMothedName { get; set; }

                    /// <summary>
                    /// <para>The HTTP method. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ALL_GET: all GET methods</description></item>
                    /// <item><description>ALL_POST: all POST methods</description></item>
                    /// <item><description>ALL_PUT: all PUT methods</description></item>
                    /// <item><description>ALL_DELETE: all DELETE methods</description></item>
                    /// <item><description>ALL_PATCH: all PATCH methods</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ALL_GET</para>
                    /// </summary>
                    [NameInMap("HttpMothed")]
                    [Validation(Required=false)]
                    public string HttpMothed { get; set; }

                    /// <summary>
                    /// <para>The method matching path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/mytestzbk/sayhello</para>
                    /// </summary>
                    [NameInMap("Mothedpath")]
                    [Validation(Required=false)]
                    public string Mothedpath { get; set; }

                    /// <summary>
                    /// <para>The parameter mapping list.</para>
                    /// </summary>
                    [NameInMap("ParamMapsList")]
                    [Validation(Required=false)]
                    public List<AddGatewayRouteRequestServicesHttpDubboTranscoderMothedMapListParamMapsList> ParamMapsList { get; set; }
                    public class AddGatewayRouteRequestServicesHttpDubboTranscoderMothedMapListParamMapsList : TeaModel {
                        /// <summary>
                        /// <para>The key extracted from the input parameter location.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>name</para>
                        /// </summary>
                        [NameInMap("ExtractKey")]
                        [Validation(Required=false)]
                        public string ExtractKey { get; set; }

                        /// <summary>
                        /// <para>The input parameter location. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>ALL_QUERY_PARAMETER: request parameters</description></item>
                        /// <item><description>ALL_HEADER: request headers</description></item>
                        /// <item><description>ALL_PATH: URI of the request</description></item>
                        /// <item><description>ALL_BODY: request body</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ALL_QUERY_PARAMETER</para>
                        /// </summary>
                        [NameInMap("ExtractKeySpec")]
                        [Validation(Required=false)]
                        public string ExtractKeySpec { get; set; }

                        /// <summary>
                        /// <para>The backend parameter type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>java.lang.String</para>
                        /// </summary>
                        [NameInMap("MappingType")]
                        [Validation(Required=false)]
                        public string MappingType { get; set; }

                    }

                    /// <summary>
                    /// <para>The header pass-through type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>PASS_ALL: pass through all headers</description></item>
                    /// <item><description>PASS_NOT: do not pass through headers</description></item>
                    /// <item><description>PASS_ASSIGN: pass through specified headers</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PASS_NOT</para>
                    /// </summary>
                    [NameInMap("PassThroughAllHeaders")]
                    [Validation(Required=false)]
                    public string PassThroughAllHeaders { get; set; }

                    /// <summary>
                    /// <para>The list of specified headers to pass through.</para>
                    /// </summary>
                    [NameInMap("PassThroughList")]
                    [Validation(Required=false)]
                    public List<string> PassThroughList { get; set; }

                }

            }

            /// <summary>
            /// <para>The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The namespace where the service resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The traffic distribution percentage for the current service or service version. This parameter is required only when multiple services or tag-based routing is used.</para>
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
            /// <para>353</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public long? ServiceId { get; set; }

            /// <summary>
            /// <para>The service port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>443</para>
            /// </summary>
            [NameInMap("ServicePort")]
            [Validation(Required=false)]
            public int? ServicePort { get; set; }

            /// <summary>
            /// <para>The source type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MSE</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The service version. This parameter is required only when tag-based routing is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
