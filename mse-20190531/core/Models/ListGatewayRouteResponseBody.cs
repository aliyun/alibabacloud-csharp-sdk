// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewayRouteResponseBody : TeaModel {
        /// <summary>
        /// <para>Code.</para>
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
        public ListGatewayRouteResponseBodyData Data { get; set; }
        public class ListGatewayRouteResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>Page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Data structure.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListGatewayRouteResponseBodyDataResult> Result { get; set; }
            public class ListGatewayRouteResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>Route comment (ingress)</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public ListGatewayRouteResponseBodyDataResultComment Comment { get; set; }
                public class ListGatewayRouteResponseBodyDataResultComment : TeaModel {
                    /// <summary>
                    /// <para>Status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>error</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>Default service ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
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
                /// <para>Destination type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Single</para>
                /// </summary>
                [NameInMap("DestinationType")]
                [Validation(Required=false)]
                public string DestinationType { get; set; }

                /// <summary>
                /// <para>Mock configuration</para>
                /// </summary>
                [NameInMap("DirectResponse")]
                [Validation(Required=false)]
                public ListGatewayRouteResponseBodyDataResultDirectResponse DirectResponse { get; set; }
                public class ListGatewayRouteResponseBodyDataResultDirectResponse : TeaModel {
                    /// <summary>
                    /// <para>Mock return value</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hello</para>
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
                /// <para>265</para>
                /// </summary>
                [NameInMap("DomainId")]
                [Validation(Required=false)]
                public long? DomainId { get; set; }

                /// <summary>
                /// <para>Domain list.</para>
                /// </summary>
                [NameInMap("DomainIdList")]
                [Validation(Required=false)]
                public List<long?> DomainIdList { get; set; }

                /// <summary>
                /// <para>Domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>y.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>Domain name list.</para>
                /// </summary>
                [NameInMap("DomainNameList")]
                [Validation(Required=false)]
                public List<string> DomainNameList { get; set; }

                /// <summary>
                /// <para>Whether to enable dynamic routing</para>
                /// </summary>
                [NameInMap("DynamicRoute")]
                [Validation(Required=false)]
                public bool? DynamicRoute { get; set; }

                /// <summary>
                /// <para>Whether to enable WAF</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EnableWaf")]
                [Validation(Required=false)]
                public string EnableWaf { get; set; }

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
                /// <para>Fallback service.</para>
                /// </summary>
                [NameInMap("FallbackServices")]
                [Validation(Required=false)]
                public List<ListGatewayRouteResponseBodyDataResultFallbackServices> FallbackServices { get; set; }
                public class ListGatewayRouteResponseBodyDataResultFallbackServices : TeaModel {
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
                    /// <para>Namespace</para>
                    /// </summary>
                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// <para>Weight percentage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Percent")]
                    [Validation(Required=false)]
                    public int? Percent { get; set; }

                    /// <summary>
                    /// <para>Service ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>353</para>
                    /// </summary>
                    [NameInMap("ServiceId")]
                    [Validation(Required=false)]
                    public long? ServiceId { get; set; }

                    /// <summary>
                    /// <para>Service name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>service name</para>
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
                /// <para>Gateway ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>496</para>
                /// </summary>
                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public long? GatewayId { get; set; }

                /// <summary>
                /// <para>Gateway unique identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-cf0e7f52ecc7429dbc7ba4d5e3656100</para>
                /// </summary>
                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                /// <summary>
                /// <para>Creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-25T07:14:01.817+0000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>Modification time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-07 18:07:57</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>Route ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47</para>
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
                /// <para>Matching rules</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;PathPredicates\&quot;:{\&quot;Path\&quot;:\&quot;/rpc/compute \&quot;,\&quot;Type\&quot;:\&quot;PRE\&quot;,\&quot;IgnoreCase\&quot;:true}}</para>
                /// </summary>
                [NameInMap("Predicates")]
                [Validation(Required=false)]
                public string Predicates { get; set; }

                /// <summary>
                /// <para>Redirection</para>
                /// </summary>
                [NameInMap("Redirect")]
                [Validation(Required=false)]
                public ListGatewayRouteResponseBodyDataResultRedirect Redirect { get; set; }
                public class ListGatewayRouteResponseBodyDataResultRedirect : TeaModel {
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
                    /// <para>Redirect hostname</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test.com</para>
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// <para>Path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/test</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                }

                /// <summary>
                /// <para>Order</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RouteOrder")]
                [Validation(Required=false)]
                public int? RouteOrder { get; set; }

                /// <summary>
                /// <para>Matching rules</para>
                /// </summary>
                [NameInMap("RoutePredicates")]
                [Validation(Required=false)]
                public ListGatewayRouteResponseBodyDataResultRoutePredicates RoutePredicates { get; set; }
                public class ListGatewayRouteResponseBodyDataResultRoutePredicates : TeaModel {
                    /// <summary>
                    /// <para>Header matching</para>
                    /// </summary>
                    [NameInMap("HeaderPredicates")]
                    [Validation(Required=false)]
                    public List<ListGatewayRouteResponseBodyDataResultRoutePredicatesHeaderPredicates> HeaderPredicates { get; set; }
                    public class ListGatewayRouteResponseBodyDataResultRoutePredicatesHeaderPredicates : TeaModel {
                        /// <summary>
                        /// <para>Header KEY</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>userid</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>Matching type</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PRE</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>Matching value</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>HTTP method matching</para>
                    /// </summary>
                    [NameInMap("MethodPredicates")]
                    [Validation(Required=false)]
                    public List<string> MethodPredicates { get; set; }

                    /// <summary>
                    /// <para>Route Path matching.</para>
                    /// </summary>
                    [NameInMap("PathPredicates")]
                    [Validation(Required=false)]
                    public ListGatewayRouteResponseBodyDataResultRoutePredicatesPathPredicates PathPredicates { get; set; }
                    public class ListGatewayRouteResponseBodyDataResultRoutePredicatesPathPredicates : TeaModel {
                        /// <summary>
                        /// <para>Case insensitive</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("IgnoreCase")]
                        [Validation(Required=false)]
                        public bool? IgnoreCase { get; set; }

                        /// <summary>
                        /// <para>Node path.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/getIp</para>
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
                    /// <para>Parameter matching</para>
                    /// </summary>
                    [NameInMap("QueryPredicates")]
                    [Validation(Required=false)]
                    public List<ListGatewayRouteResponseBodyDataResultRoutePredicatesQueryPredicates> QueryPredicates { get; set; }
                    public class ListGatewayRouteResponseBodyDataResultRoutePredicatesQueryPredicates : TeaModel {
                        /// <summary>
                        /// <para>Parameter name</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>userid</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>Matching type</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PRE</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>Matching value</para>
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
                /// <para>Service.</para>
                /// </summary>
                [NameInMap("RouteServices")]
                [Validation(Required=false)]
                public List<ListGatewayRouteResponseBodyDataResultRouteServices> RouteServices { get; set; }
                public class ListGatewayRouteResponseBodyDataResultRouteServices : TeaModel {
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
                    public ListGatewayRouteResponseBodyDataResultRouteServicesHttpDubboTranscoder HttpDubboTranscoder { get; set; }
                    public class ListGatewayRouteResponseBodyDataResultRouteServicesHttpDubboTranscoder : TeaModel {
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
                        public List<ListGatewayRouteResponseBodyDataResultRouteServicesHttpDubboTranscoderMothedMapList> MothedMapList { get; set; }
                        public class ListGatewayRouteResponseBodyDataResultRouteServicesHttpDubboTranscoderMothedMapList : TeaModel {
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
                            /// <para>Supported HTTP method parameter values.</para>
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
                            public List<ListGatewayRouteResponseBodyDataResultRouteServicesHttpDubboTranscoderMothedMapListParamMapsList> ParamMapsList { get; set; }
                            public class ListGatewayRouteResponseBodyDataResultRouteServicesHttpDubboTranscoderMothedMapListParamMapsList : TeaModel {
                                /// <summary>
                                /// <para>Extract key from input.</para>
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
                                /// <item><description><para>Request path: <c>ALL_PATH</c></para>
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
                            /// <para>Specified pass-through Header list.</para>
                            /// </summary>
                            [NameInMap("PassThroughList")]
                            [Validation(Required=false)]
                            public List<string> PassThroughList { get; set; }

                        }

                    }

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
                    /// <para>Namespace.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// <para>Weight percentage</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>11</para>
                    /// </summary>
                    [NameInMap("Percent")]
                    [Validation(Required=false)]
                    public int? Percent { get; set; }

                    /// <summary>
                    /// <para>Service ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1563</para>
                    /// </summary>
                    [NameInMap("ServiceId")]
                    [Validation(Required=false)]
                    public long? ServiceId { get; set; }

                    /// <summary>
                    /// <para>Service name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hu</para>
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
                    /// <para>Source type</para>
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
                /// <para>Service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("Services")]
                [Validation(Required=false)]
                public string Services { get; set; }

                /// <summary>
                /// <para>Status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>Route type</para>
                /// 
                /// <b>Example:</b>
                /// <para>Op</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>36</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

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
        /// <para>83F02EAB-ECDF-55C6-B332-8649E5E7AF2C</para>
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
