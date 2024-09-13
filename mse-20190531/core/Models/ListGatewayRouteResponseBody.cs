// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewayRouteResponseBody : TeaModel {
        /// <summary>
        /// The code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListGatewayRouteResponseBodyData Data { get; set; }
        public class ListGatewayRouteResponseBodyData : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The data structure.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListGatewayRouteResponseBodyDataResult> Result { get; set; }
            public class ListGatewayRouteResponseBodyDataResult : TeaModel {
                /// <summary>
                /// The route comment (ingress).
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public ListGatewayRouteResponseBodyDataResultComment Comment { get; set; }
                public class ListGatewayRouteResponseBodyDataResultComment : TeaModel {
                    /// <summary>
                    /// The status.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// The default service ID.
                /// </summary>
                [NameInMap("DefaultServiceId")]
                [Validation(Required=false)]
                public long? DefaultServiceId { get; set; }

                /// <summary>
                /// The default service name.
                /// </summary>
                [NameInMap("DefaultServiceName")]
                [Validation(Required=false)]
                public string DefaultServiceName { get; set; }

                /// <summary>
                /// The destination service type.
                /// </summary>
                [NameInMap("DestinationType")]
                [Validation(Required=false)]
                public string DestinationType { get; set; }

                /// <summary>
                /// The information about service mocking.
                /// </summary>
                [NameInMap("DirectResponse")]
                [Validation(Required=false)]
                public ListGatewayRouteResponseBodyDataResultDirectResponse DirectResponse { get; set; }
                public class ListGatewayRouteResponseBodyDataResultDirectResponse : TeaModel {
                    /// <summary>
                    /// The return value for service mocking.
                    /// </summary>
                    [NameInMap("Body")]
                    [Validation(Required=false)]
                    public string Body { get; set; }

                    /// <summary>
                    /// The response code returned.
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                }

                /// <summary>
                /// The domain ID.
                /// </summary>
                [NameInMap("DomainId")]
                [Validation(Required=false)]
                public long? DomainId { get; set; }

                /// <summary>
                /// The domain IDs.
                /// </summary>
                [NameInMap("DomainIdList")]
                [Validation(Required=false)]
                public List<long?> DomainIdList { get; set; }

                /// <summary>
                /// The domain name.
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// The domain names.
                /// </summary>
                [NameInMap("DomainNameList")]
                [Validation(Required=false)]
                public List<string> DomainNameList { get; set; }

                [NameInMap("DynamicRoute")]
                [Validation(Required=false)]
                public bool? DynamicRoute { get; set; }

                /// <summary>
                /// Indicates whether Web Application Firewall (WAF) is activated.
                /// </summary>
                [NameInMap("EnableWaf")]
                [Validation(Required=false)]
                public string EnableWaf { get; set; }

                /// <summary>
                /// Indicates whether the Fallback service is enabled.
                /// </summary>
                [NameInMap("Fallback")]
                [Validation(Required=false)]
                public bool? Fallback { get; set; }

                /// <summary>
                /// The information about the Fallback service.
                /// </summary>
                [NameInMap("FallbackServices")]
                [Validation(Required=false)]
                public List<ListGatewayRouteResponseBodyDataResultFallbackServices> FallbackServices { get; set; }
                public class ListGatewayRouteResponseBodyDataResultFallbackServices : TeaModel {
                    /// <summary>
                    /// The type of the protocol.
                    /// </summary>
                    [NameInMap("AgreementType")]
                    [Validation(Required=false)]
                    public string AgreementType { get; set; }

                    /// <summary>
                    /// The name of the group to which the service belongs.
                    /// </summary>
                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    /// <summary>
                    /// The name.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The namespace to which the service belongs.
                    /// </summary>
                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// The weight in the form of a percentage value.
                    /// </summary>
                    [NameInMap("Percent")]
                    [Validation(Required=false)]
                    public int? Percent { get; set; }

                    /// <summary>
                    /// The ID of the service.
                    /// </summary>
                    [NameInMap("ServiceId")]
                    [Validation(Required=false)]
                    public long? ServiceId { get; set; }

                    /// <summary>
                    /// The name of the service.
                    /// </summary>
                    [NameInMap("ServiceName")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

                    /// <summary>
                    /// The service port number.
                    /// </summary>
                    [NameInMap("ServicePort")]
                    [Validation(Required=false)]
                    public int? ServicePort { get; set; }

                    /// <summary>
                    /// The source type.
                    /// </summary>
                    [NameInMap("SourceType")]
                    [Validation(Required=false)]
                    public string SourceType { get; set; }

                    /// <summary>
                    /// The version of the service.
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                /// <summary>
                /// The ID of the gateway.
                /// </summary>
                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public long? GatewayId { get; set; }

                /// <summary>
                /// The unique ID of the gateway.
                /// </summary>
                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                /// <summary>
                /// The creation time.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The modification time.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The ID.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The matching rules.
                /// </summary>
                [NameInMap("Predicates")]
                [Validation(Required=false)]
                public string Predicates { get; set; }

                /// <summary>
                /// The information about redirection.
                /// </summary>
                [NameInMap("Redirect")]
                [Validation(Required=false)]
                public ListGatewayRouteResponseBodyDataResultRedirect Redirect { get; set; }
                public class ListGatewayRouteResponseBodyDataResultRedirect : TeaModel {
                    /// <summary>
                    /// The response code returned.
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    /// <summary>
                    /// The hostname to be redirected to.
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// The path.
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                }

                /// <summary>
                /// The order.
                /// </summary>
                [NameInMap("RouteOrder")]
                [Validation(Required=false)]
                public int? RouteOrder { get; set; }

                /// <summary>
                /// The matching rules.
                /// </summary>
                [NameInMap("RoutePredicates")]
                [Validation(Required=false)]
                public ListGatewayRouteResponseBodyDataResultRoutePredicates RoutePredicates { get; set; }
                public class ListGatewayRouteResponseBodyDataResultRoutePredicates : TeaModel {
                    /// <summary>
                    /// The headers used for route matching.
                    /// </summary>
                    [NameInMap("HeaderPredicates")]
                    [Validation(Required=false)]
                    public List<ListGatewayRouteResponseBodyDataResultRoutePredicatesHeaderPredicates> HeaderPredicates { get; set; }
                    public class ListGatewayRouteResponseBodyDataResultRoutePredicatesHeaderPredicates : TeaModel {
                        /// <summary>
                        /// The header key.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The matching type.
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// The value.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The HTTP methods used for route matching.
                    /// </summary>
                    [NameInMap("MethodPredicates")]
                    [Validation(Required=false)]
                    public List<string> MethodPredicates { get; set; }

                    /// <summary>
                    /// The path used for route matching.
                    /// </summary>
                    [NameInMap("PathPredicates")]
                    [Validation(Required=false)]
                    public ListGatewayRouteResponseBodyDataResultRoutePredicatesPathPredicates PathPredicates { get; set; }
                    public class ListGatewayRouteResponseBodyDataResultRoutePredicatesPathPredicates : TeaModel {
                        /// <summary>
                        /// Indicates whether case sensitivity is ignored.
                        /// </summary>
                        [NameInMap("IgnoreCase")]
                        [Validation(Required=false)]
                        public bool? IgnoreCase { get; set; }

                        /// <summary>
                        /// The path of the node.
                        /// </summary>
                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                        /// <summary>
                        /// The matching type.
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// The parameters used for route matching.
                    /// </summary>
                    [NameInMap("QueryPredicates")]
                    [Validation(Required=false)]
                    public List<ListGatewayRouteResponseBodyDataResultRoutePredicatesQueryPredicates> QueryPredicates { get; set; }
                    public class ListGatewayRouteResponseBodyDataResultRoutePredicatesQueryPredicates : TeaModel {
                        /// <summary>
                        /// The key.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The matching type.
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// The value.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The information about services.
                /// </summary>
                [NameInMap("RouteServices")]
                [Validation(Required=false)]
                public List<ListGatewayRouteResponseBodyDataResultRouteServices> RouteServices { get; set; }
                public class ListGatewayRouteResponseBodyDataResultRouteServices : TeaModel {
                    /// <summary>
                    /// The type of the protocol.
                    /// </summary>
                    [NameInMap("AgreementType")]
                    [Validation(Required=false)]
                    public string AgreementType { get; set; }

                    /// <summary>
                    /// The name of the group to which the service belongs.
                    /// </summary>
                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    [NameInMap("HealthStatus")]
                    [Validation(Required=false)]
                    public string HealthStatus { get; set; }

                    /// <summary>
                    /// The transcoder of the Dubbo protocol.
                    /// </summary>
                    [NameInMap("HttpDubboTranscoder")]
                    [Validation(Required=false)]
                    public ListGatewayRouteResponseBodyDataResultRouteServicesHttpDubboTranscoder HttpDubboTranscoder { get; set; }
                    public class ListGatewayRouteResponseBodyDataResultRouteServicesHttpDubboTranscoder : TeaModel {
                        /// <summary>
                        /// The Dubbo service group.
                        /// </summary>
                        [NameInMap("DubboServiceGroup")]
                        [Validation(Required=false)]
                        public string DubboServiceGroup { get; set; }

                        /// <summary>
                        /// The name of the Dubbo service.
                        /// </summary>
                        [NameInMap("DubboServiceName")]
                        [Validation(Required=false)]
                        public string DubboServiceName { get; set; }

                        /// <summary>
                        /// The version of the Dubbo service.
                        /// </summary>
                        [NameInMap("DubboServiceVersion")]
                        [Validation(Required=false)]
                        public string DubboServiceVersion { get; set; }

                        /// <summary>
                        /// The forwarding rules of the Dubbo service.
                        /// </summary>
                        [NameInMap("MothedMapList")]
                        [Validation(Required=false)]
                        public List<ListGatewayRouteResponseBodyDataResultRouteServicesHttpDubboTranscoderMothedMapList> MothedMapList { get; set; }
                        public class ListGatewayRouteResponseBodyDataResultRouteServicesHttpDubboTranscoderMothedMapList : TeaModel {
                            /// <summary>
                            /// The method name of the Dubbo service.
                            /// </summary>
                            [NameInMap("DubboMothedName")]
                            [Validation(Required=false)]
                            public string DubboMothedName { get; set; }

                            /// <summary>
                            /// The HTTP method.
                            /// 
                            /// > Valid values:
                            /// 
                            /// *   ALL_GET
                            /// 
                            /// *   ALL_POST
                            /// 
                            /// *   ALL_PUT
                            /// 
                            /// *   ALL_DELETE
                            /// 
                            /// *   ALL_PATCH
                            /// </summary>
                            [NameInMap("HttpMothed")]
                            [Validation(Required=false)]
                            public string HttpMothed { get; set; }

                            /// <summary>
                            /// The path used for method matching.
                            /// </summary>
                            [NameInMap("Mothedpath")]
                            [Validation(Required=false)]
                            public string Mothedpath { get; set; }

                            /// <summary>
                            /// The information about parameter mappings.
                            /// </summary>
                            [NameInMap("ParamMapsList")]
                            [Validation(Required=false)]
                            public List<ListGatewayRouteResponseBodyDataResultRouteServicesHttpDubboTranscoderMothedMapListParamMapsList> ParamMapsList { get; set; }
                            public class ListGatewayRouteResponseBodyDataResultRouteServicesHttpDubboTranscoderMothedMapListParamMapsList : TeaModel {
                                /// <summary>
                                /// The key extracted from the input parameter.
                                /// </summary>
                                [NameInMap("ExtractKey")]
                                [Validation(Required=false)]
                                public string ExtractKey { get; set; }

                                /// <summary>
                                /// The position of the input parameter.
                                /// 
                                /// > Valid values:
                                /// 
                                /// *   `ALL_QUERY_PARAMETER`: request parameter
                                /// 
                                /// *   `ALL_HEADER`: request header
                                /// 
                                /// *   `ALL_PATH`: request path
                                /// 
                                /// *   `ALL_BODY`: request body
                                /// </summary>
                                [NameInMap("ExtractKeySpec")]
                                [Validation(Required=false)]
                                public string ExtractKeySpec { get; set; }

                                /// <summary>
                                /// The type of the backend service parameter.
                                /// </summary>
                                [NameInMap("MappingType")]
                                [Validation(Required=false)]
                                public string MappingType { get; set; }

                            }

                            /// <summary>
                            /// The pass-through type of the header.
                            /// 
                            /// > Valid values:
                            /// 
                            /// *   PASS_ALL: All headers are passed through.
                            /// 
                            /// *   PASS_NOT: All headers are not passed through.
                            /// 
                            /// *   PASS_ASSIGN: Specified headers are passed through.
                            /// </summary>
                            [NameInMap("PassThroughAllHeaders")]
                            [Validation(Required=false)]
                            public string PassThroughAllHeaders { get; set; }

                            /// <summary>
                            /// The list of headers to be passed through.
                            /// </summary>
                            [NameInMap("PassThroughList")]
                            [Validation(Required=false)]
                            public List<string> PassThroughList { get; set; }

                        }

                    }

                    /// <summary>
                    /// The name.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The namespace.
                    /// </summary>
                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// The weight in the form of a percentage value.
                    /// </summary>
                    [NameInMap("Percent")]
                    [Validation(Required=false)]
                    public int? Percent { get; set; }

                    /// <summary>
                    /// The ID of the service.
                    /// </summary>
                    [NameInMap("ServiceId")]
                    [Validation(Required=false)]
                    public long? ServiceId { get; set; }

                    /// <summary>
                    /// The name of the service.
                    /// </summary>
                    [NameInMap("ServiceName")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

                    /// <summary>
                    /// The Dubbo port number.
                    /// </summary>
                    [NameInMap("ServicePort")]
                    [Validation(Required=false)]
                    public int? ServicePort { get; set; }

                    /// <summary>
                    /// The source type.
                    /// </summary>
                    [NameInMap("SourceType")]
                    [Validation(Required=false)]
                    public string SourceType { get; set; }

                    [NameInMap("UnhealthyEndpoints")]
                    [Validation(Required=false)]
                    public List<string> UnhealthyEndpoints { get; set; }

                    /// <summary>
                    /// The version of the service.
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                /// <summary>
                /// The information about services.
                /// </summary>
                [NameInMap("Services")]
                [Validation(Required=false)]
                public string Services { get; set; }

                /// <summary>
                /// The status.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// The route type.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`: The request was successful.
        /// *   `false`: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
