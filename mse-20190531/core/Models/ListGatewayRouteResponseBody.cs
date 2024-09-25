// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewayRouteResponseBody : TeaModel {
        /// <summary>
        /// <para>The code returned.</para>
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
        public ListGatewayRouteResponseBodyData Data { get; set; }
        public class ListGatewayRouteResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The data structure.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListGatewayRouteResponseBodyDataResult> Result { get; set; }
            public class ListGatewayRouteResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The route comment (ingress).</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public ListGatewayRouteResponseBodyDataResultComment Comment { get; set; }
                public class ListGatewayRouteResponseBodyDataResultComment : TeaModel {
                    /// <summary>
                    /// <para>The status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>error</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>The default service ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
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
                public ListGatewayRouteResponseBodyDataResultDirectResponse DirectResponse { get; set; }
                public class ListGatewayRouteResponseBodyDataResultDirectResponse : TeaModel {
                    /// <summary>
                    /// <para>The return value for service mocking.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hello</para>
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
                /// <para>265</para>
                /// </summary>
                [NameInMap("DomainId")]
                [Validation(Required=false)]
                public long? DomainId { get; set; }

                /// <summary>
                /// <para>The domain IDs.</para>
                /// </summary>
                [NameInMap("DomainIdList")]
                [Validation(Required=false)]
                public List<long?> DomainIdList { get; set; }

                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>y.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The domain names.</para>
                /// </summary>
                [NameInMap("DomainNameList")]
                [Validation(Required=false)]
                public List<string> DomainNameList { get; set; }

                [NameInMap("DynamicRoute")]
                [Validation(Required=false)]
                public bool? DynamicRoute { get; set; }

                /// <summary>
                /// <para>Indicates whether Web Application Firewall (WAF) is activated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EnableWaf")]
                [Validation(Required=false)]
                public string EnableWaf { get; set; }

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
                /// <para>The information about the Fallback service.</para>
                /// </summary>
                [NameInMap("FallbackServices")]
                [Validation(Required=false)]
                public List<ListGatewayRouteResponseBodyDataResultFallbackServices> FallbackServices { get; set; }
                public class ListGatewayRouteResponseBodyDataResultFallbackServices : TeaModel {
                    /// <summary>
                    /// <para>The type of the protocol.</para>
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
                    /// <para>Namespace</para>
                    /// </summary>
                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// <para>The weight in the form of a percentage value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Percent")]
                    [Validation(Required=false)]
                    public int? Percent { get; set; }

                    /// <summary>
                    /// <para>The ID of the service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>353</para>
                    /// </summary>
                    [NameInMap("ServiceId")]
                    [Validation(Required=false)]
                    public long? ServiceId { get; set; }

                    /// <summary>
                    /// <para>The name of the service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>service name</para>
                    /// </summary>
                    [NameInMap("ServiceName")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

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
                /// <para>496</para>
                /// </summary>
                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public long? GatewayId { get; set; }

                /// <summary>
                /// <para>The unique ID of the gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-cf0e7f52ecc7429dbc7ba4d5e3656100</para>
                /// </summary>
                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-25T07:14:01.817+0000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-07 18:07:57</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47</para>
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
                /// <para>The matching rules.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;PathPredicates\&quot;:{\&quot;Path\&quot;:\&quot;/rpc/compute \&quot;,\&quot;Type\&quot;:\&quot;PRE\&quot;,\&quot;IgnoreCase\&quot;:true}}</para>
                /// </summary>
                [NameInMap("Predicates")]
                [Validation(Required=false)]
                public string Predicates { get; set; }

                /// <summary>
                /// <para>The information about redirection.</para>
                /// </summary>
                [NameInMap("Redirect")]
                [Validation(Required=false)]
                public ListGatewayRouteResponseBodyDataResultRedirect Redirect { get; set; }
                public class ListGatewayRouteResponseBodyDataResultRedirect : TeaModel {
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
                    /// <para>The hostname to be redirected to.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test.com</para>
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// <para>The path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/test</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                }

                /// <summary>
                /// <para>The order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RouteOrder")]
                [Validation(Required=false)]
                public int? RouteOrder { get; set; }

                /// <summary>
                /// <para>The matching rules.</para>
                /// </summary>
                [NameInMap("RoutePredicates")]
                [Validation(Required=false)]
                public ListGatewayRouteResponseBodyDataResultRoutePredicates RoutePredicates { get; set; }
                public class ListGatewayRouteResponseBodyDataResultRoutePredicates : TeaModel {
                    /// <summary>
                    /// <para>The headers used for route matching.</para>
                    /// </summary>
                    [NameInMap("HeaderPredicates")]
                    [Validation(Required=false)]
                    public List<ListGatewayRouteResponseBodyDataResultRoutePredicatesHeaderPredicates> HeaderPredicates { get; set; }
                    public class ListGatewayRouteResponseBodyDataResultRoutePredicatesHeaderPredicates : TeaModel {
                        /// <summary>
                        /// <para>The header key.</para>
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
                        /// <para>The value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The HTTP methods used for route matching.</para>
                    /// </summary>
                    [NameInMap("MethodPredicates")]
                    [Validation(Required=false)]
                    public List<string> MethodPredicates { get; set; }

                    /// <summary>
                    /// <para>The path used for route matching.</para>
                    /// </summary>
                    [NameInMap("PathPredicates")]
                    [Validation(Required=false)]
                    public ListGatewayRouteResponseBodyDataResultRoutePredicatesPathPredicates PathPredicates { get; set; }
                    public class ListGatewayRouteResponseBodyDataResultRoutePredicatesPathPredicates : TeaModel {
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
                        /// <para>The path of the node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/getIp</para>
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
                    /// <para>The parameters used for route matching.</para>
                    /// </summary>
                    [NameInMap("QueryPredicates")]
                    [Validation(Required=false)]
                    public List<ListGatewayRouteResponseBodyDataResultRoutePredicatesQueryPredicates> QueryPredicates { get; set; }
                    public class ListGatewayRouteResponseBodyDataResultRoutePredicatesQueryPredicates : TeaModel {
                        /// <summary>
                        /// <para>The key.</para>
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
                        /// <para>The value.</para>
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
                /// <para>The information about services.</para>
                /// </summary>
                [NameInMap("RouteServices")]
                [Validation(Required=false)]
                public List<ListGatewayRouteResponseBodyDataResultRouteServices> RouteServices { get; set; }
                public class ListGatewayRouteResponseBodyDataResultRouteServices : TeaModel {
                    /// <summary>
                    /// <para>The type of the protocol.</para>
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

                    /// <summary>
                    /// <para>The transcoder of the Dubbo protocol.</para>
                    /// </summary>
                    [NameInMap("HttpDubboTranscoder")]
                    [Validation(Required=false)]
                    public ListGatewayRouteResponseBodyDataResultRouteServicesHttpDubboTranscoder HttpDubboTranscoder { get; set; }
                    public class ListGatewayRouteResponseBodyDataResultRouteServicesHttpDubboTranscoder : TeaModel {
                        /// <summary>
                        /// <para>The Dubbo service group.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>service group</para>
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
                        public List<ListGatewayRouteResponseBodyDataResultRouteServicesHttpDubboTranscoderMothedMapList> MothedMapList { get; set; }
                        public class ListGatewayRouteResponseBodyDataResultRouteServicesHttpDubboTranscoderMothedMapList : TeaModel {
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
                            /// <para>The path used for method matching.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>/mytestzbk/sayhello</para>
                            /// </summary>
                            [NameInMap("Mothedpath")]
                            [Validation(Required=false)]
                            public string Mothedpath { get; set; }

                            /// <summary>
                            /// <para>The information about parameter mappings.</para>
                            /// </summary>
                            [NameInMap("ParamMapsList")]
                            [Validation(Required=false)]
                            public List<ListGatewayRouteResponseBodyDataResultRouteServicesHttpDubboTranscoderMothedMapListParamMapsList> ParamMapsList { get; set; }
                            public class ListGatewayRouteResponseBodyDataResultRouteServicesHttpDubboTranscoderMothedMapListParamMapsList : TeaModel {
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
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The namespace.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// <para>The weight in the form of a percentage value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>11</para>
                    /// </summary>
                    [NameInMap("Percent")]
                    [Validation(Required=false)]
                    public int? Percent { get; set; }

                    /// <summary>
                    /// <para>The ID of the service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1563</para>
                    /// </summary>
                    [NameInMap("ServiceId")]
                    [Validation(Required=false)]
                    public long? ServiceId { get; set; }

                    /// <summary>
                    /// <para>The name of the service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hu</para>
                    /// </summary>
                    [NameInMap("ServiceName")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

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

                    [NameInMap("UnhealthyEndpoints")]
                    [Validation(Required=false)]
                    public List<string> UnhealthyEndpoints { get; set; }

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
                /// <para>The information about services.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("Services")]
                [Validation(Required=false)]
                public string Services { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The route type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Op</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>36</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

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
        /// <para>83F02EAB-ECDF-55C6-B332-8649E5E7AF2C</para>
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
