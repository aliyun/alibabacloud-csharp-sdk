// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayRouteRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
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
        /// <para>Mock</para>
        /// </summary>
        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public string DestinationType { get; set; }

        /// <summary>
        /// <para>The information about service mocking.</para>
        /// </summary>
        [NameInMap("DirectResponseJSON")]
        [Validation(Required=false)]
        public UpdateGatewayRouteRequestDirectResponseJSON DirectResponseJSON { get; set; }
        public class UpdateGatewayRouteRequestDirectResponseJSON : TeaModel {
            /// <summary>
            /// <para>The mock return value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hello</para>
            /// </summary>
            [NameInMap("Body")]
            [Validation(Required=false)]
            public string Body { get; set; }

            /// <summary>
            /// <para>The mock return code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public long? Code { get; set; }

        }

        /// <summary>
        /// <para>The associated domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[90]</para>
        /// </summary>
        [NameInMap("DomainIdListJSON")]
        [Validation(Required=false)]
        public string DomainIdListJSON { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Specifies whether to activate Web Application Firewall (WAF).</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableWaf")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? EnableWaf { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Fallback service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Fallback")]
        [Validation(Required=false)]
        public bool? Fallback { get; set; }

        /// <summary>
        /// <para>The information about the Fallback service.</para>
        /// </summary>
        [NameInMap("FallbackServices")]
        [Validation(Required=false)]
        public List<UpdateGatewayRouteRequestFallbackServices> FallbackServices { get; set; }
        public class UpdateGatewayRouteRequestFallbackServices : TeaModel {
            /// <summary>
            /// <para>The type of the protocol. Valid values:</para>
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
            /// <para>The namespace in which the service resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Namespace</para>
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
            /// <para>The ID of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public long? ServiceId { get; set; }

            /// <summary>
            /// <para>The service port number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8848</para>
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
            /// <para>The version of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The ID of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>501</para>
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public long? GatewayId { get; set; }

        /// <summary>
        /// <para>The unique ID of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-86575c0bc9f04ecfbacb92b8e392a2c4</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// <para>The ID of the route.</para>
        /// 
        /// <b>Example:</b>
        /// <para>139</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The name of the route.</para>
        /// 
        /// <b>Example:</b>
        /// <para>route-web</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        [Obsolete]
        public string Name { get; set; }

        /// <summary>
        /// <para>The route matching conditions.</para>
        /// </summary>
        [NameInMap("Predicates")]
        [Validation(Required=false)]
        public UpdateGatewayRouteRequestPredicates Predicates { get; set; }
        public class UpdateGatewayRouteRequestPredicates : TeaModel {
            /// <summary>
            /// <para>The information about header matching.</para>
            /// </summary>
            [NameInMap("HeaderPredicates")]
            [Validation(Required=false)]
            public List<UpdateGatewayRouteRequestPredicatesHeaderPredicates> HeaderPredicates { get; set; }
            public class UpdateGatewayRouteRequestPredicatesHeaderPredicates : TeaModel {
                /// <summary>
                /// <para>The key of the request header.</para>
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
                /// <para>The value of the request header.</para>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
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
            /// <para>The information about path matching.</para>
            /// </summary>
            [NameInMap("PathPredicates")]
            [Validation(Required=false)]
            public UpdateGatewayRouteRequestPredicatesPathPredicates PathPredicates { get; set; }
            public class UpdateGatewayRouteRequestPredicatesPathPredicates : TeaModel {
                /// <summary>
                /// <para>Specifies whether to perform case-insensitive matching.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IgnoreCase")]
                [Validation(Required=false)]
                public bool? IgnoreCase { get; set; }

                /// <summary>
                /// <para>The path used for route matching.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/test</para>
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
            public List<UpdateGatewayRouteRequestPredicatesQueryPredicates> QueryPredicates { get; set; }
            public class UpdateGatewayRouteRequestPredicatesQueryPredicates : TeaModel {
                /// <summary>
                /// <para>The name of the parameter.</para>
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
        /// <para>The information about redirection.</para>
        /// </summary>
        [NameInMap("RedirectJSON")]
        [Validation(Required=false)]
        public UpdateGatewayRouteRequestRedirectJSON RedirectJSON { get; set; }
        public class UpdateGatewayRouteRequestRedirectJSON : TeaModel {
            /// <summary>
            /// <para>The status code returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>302</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public int? Code { get; set; }

            /// <summary>
            /// <para>The hostname to be redirected to.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.com</para>
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <para>The path to be redirected to.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/test</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

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
        /// <para>The information about destination services.</para>
        /// </summary>
        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<UpdateGatewayRouteRequestServices> Services { get; set; }
        public class UpdateGatewayRouteRequestServices : TeaModel {
            /// <summary>
            /// <para>The type of the protocol. Valid values:</para>
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
            /// <para>The transcoder of the Dubbo protocol.</para>
            /// </summary>
            [NameInMap("HttpDubboTranscoder")]
            [Validation(Required=false)]
            public UpdateGatewayRouteRequestServicesHttpDubboTranscoder HttpDubboTranscoder { get; set; }
            public class UpdateGatewayRouteRequestServicesHttpDubboTranscoder : TeaModel {
                /// <summary>
                /// <para>The Dubbo service group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>service name</para>
                /// </summary>
                [NameInMap("DubboServiceGroup")]
                [Validation(Required=false)]
                public string DubboServiceGroup { get; set; }

                /// <summary>
                /// <para>The name of the Dubbo service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>org.apache.dubbo.samples.basic.api.DemoService</para>
                /// </summary>
                [NameInMap("DubboServiceName")]
                [Validation(Required=false)]
                public string DubboServiceName { get; set; }

                /// <summary>
                /// <para>The version of the Dubbo service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.0</para>
                /// </summary>
                [NameInMap("DubboServiceVersion")]
                [Validation(Required=false)]
                public string DubboServiceVersion { get; set; }

                /// <summary>
                /// <para>The forwarding rules of the Dubbo service.</para>
                /// </summary>
                [NameInMap("MothedMapList")]
                [Validation(Required=false)]
                public List<UpdateGatewayRouteRequestServicesHttpDubboTranscoderMothedMapList> MothedMapList { get; set; }
                public class UpdateGatewayRouteRequestServicesHttpDubboTranscoderMothedMapList : TeaModel {
                    /// <summary>
                    /// <para>The method name of the Dubbo service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sayHello</para>
                    /// </summary>
                    [NameInMap("DubboMothedName")]
                    [Validation(Required=false)]
                    public string DubboMothedName { get; set; }

                    /// <summary>
                    /// <para>The HTTP method.</para>
                    /// <remarks>
                    /// <para>Valid values:</para>
                    /// </remarks>
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
                    /// 
                    /// <b>Example:</b>
                    /// <para>ALL_GET</para>
                    /// </summary>
                    [NameInMap("HttpMothed")]
                    [Validation(Required=false)]
                    public string HttpMothed { get; set; }

                    /// <summary>
                    /// <para>The path that is used to match a method.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/mytestzbk/sayhello</para>
                    /// </summary>
                    [NameInMap("Mothedpath")]
                    [Validation(Required=false)]
                    public string Mothedpath { get; set; }

                    /// <summary>
                    /// <para>The information of parameter mappings.</para>
                    /// </summary>
                    [NameInMap("ParamMapsList")]
                    [Validation(Required=false)]
                    public List<UpdateGatewayRouteRequestServicesHttpDubboTranscoderMothedMapListParamMapsList> ParamMapsList { get; set; }
                    public class UpdateGatewayRouteRequestServicesHttpDubboTranscoderMothedMapListParamMapsList : TeaModel {
                        /// <summary>
                        /// <para>The key extracted from the input parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>name</para>
                        /// </summary>
                        [NameInMap("ExtractKey")]
                        [Validation(Required=false)]
                        public string ExtractKey { get; set; }

                        /// <summary>
                        /// <para>The position of the input parameter.</para>
                        /// <remarks>
                        /// <para>Valid values:</para>
                        /// </remarks>
                        /// <list type="bullet">
                        /// <item><description><para><c>ALL_QUERY_PARAMETER</c>: request parameter</para>
                        /// </description></item>
                        /// <item><description><para><c>ALL_HEADER</c>: request header</para>
                        /// </description></item>
                        /// <item><description><para><c>ALL_PATH</c>: request path</para>
                        /// </description></item>
                        /// <item><description><para><c>ALL_BODY</c>: request body</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ALL_QUERY_PARAMETER</para>
                        /// </summary>
                        [NameInMap("ExtractKeySpec")]
                        [Validation(Required=false)]
                        public string ExtractKeySpec { get; set; }

                        /// <summary>
                        /// <para>The type of the backend service parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>java.lang.String</para>
                        /// </summary>
                        [NameInMap("MappingType")]
                        [Validation(Required=false)]
                        public string MappingType { get; set; }

                    }

                    /// <summary>
                    /// <para>The pass-through type of the header.</para>
                    /// <remarks>
                    /// <para>Valid values:</para>
                    /// </remarks>
                    /// <list type="bullet">
                    /// <item><description><para>PASS_ALL: All headers are passed through.</para>
                    /// </description></item>
                    /// <item><description><para>PASS_NOT: All headers are not passed through.</para>
                    /// </description></item>
                    /// <item><description><para>PASS_ASSIGN: Specified headers are passed through.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PASS_NOT</para>
                    /// </summary>
                    [NameInMap("PassThroughAllHeaders")]
                    [Validation(Required=false)]
                    public string PassThroughAllHeaders { get; set; }

                    /// <summary>
                    /// <para>The list of headers to be passed through.</para>
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
            /// <para>web</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The namespace in which the service resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public int? Percent { get; set; }

            /// <summary>
            /// <para>The ID of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public long? ServiceId { get; set; }

            /// <summary>
            /// <para>The Dubbo port number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20880</para>
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
            /// <para>The version of the service.</para>
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
