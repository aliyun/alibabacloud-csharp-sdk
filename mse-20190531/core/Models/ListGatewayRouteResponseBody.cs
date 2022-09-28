// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewayRouteResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListGatewayRouteResponseBodyData Data { get; set; }
        public class ListGatewayRouteResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListGatewayRouteResponseBodyDataResult> Result { get; set; }
            public class ListGatewayRouteResponseBodyDataResult : TeaModel {
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public ListGatewayRouteResponseBodyDataResultComment Comment { get; set; }
                public class ListGatewayRouteResponseBodyDataResultComment : TeaModel {
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                [NameInMap("DefaultServiceId")]
                [Validation(Required=false)]
                public long? DefaultServiceId { get; set; }

                [NameInMap("DefaultServiceName")]
                [Validation(Required=false)]
                public string DefaultServiceName { get; set; }

                [NameInMap("DestinationType")]
                [Validation(Required=false)]
                public string DestinationType { get; set; }

                [NameInMap("DirectResponse")]
                [Validation(Required=false)]
                public ListGatewayRouteResponseBodyDataResultDirectResponse DirectResponse { get; set; }
                public class ListGatewayRouteResponseBodyDataResultDirectResponse : TeaModel {
                    [NameInMap("Body")]
                    [Validation(Required=false)]
                    public string Body { get; set; }

                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                }

                [NameInMap("DomainId")]
                [Validation(Required=false)]
                public long? DomainId { get; set; }

                [NameInMap("DomainIdList")]
                [Validation(Required=false)]
                public List<long?> DomainIdList { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("DomainNameList")]
                [Validation(Required=false)]
                public List<string> DomainNameList { get; set; }

                [NameInMap("EnableWaf")]
                [Validation(Required=false)]
                public string EnableWaf { get; set; }

                [NameInMap("Fallback")]
                [Validation(Required=false)]
                public bool? Fallback { get; set; }

                [NameInMap("FallbackServices")]
                [Validation(Required=false)]
                public List<ListGatewayRouteResponseBodyDataResultFallbackServices> FallbackServices { get; set; }
                public class ListGatewayRouteResponseBodyDataResultFallbackServices : TeaModel {
                    [NameInMap("AgreementType")]
                    [Validation(Required=false)]
                    public string AgreementType { get; set; }

                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    [NameInMap("Percent")]
                    [Validation(Required=false)]
                    public int? Percent { get; set; }

                    [NameInMap("ServiceId")]
                    [Validation(Required=false)]
                    public long? ServiceId { get; set; }

                    [NameInMap("ServiceName")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

                    [NameInMap("ServicePort")]
                    [Validation(Required=false)]
                    public int? ServicePort { get; set; }

                    [NameInMap("SourceType")]
                    [Validation(Required=false)]
                    public string SourceType { get; set; }

                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public long? GatewayId { get; set; }

                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Predicates")]
                [Validation(Required=false)]
                public string Predicates { get; set; }

                [NameInMap("Redirect")]
                [Validation(Required=false)]
                public ListGatewayRouteResponseBodyDataResultRedirect Redirect { get; set; }
                public class ListGatewayRouteResponseBodyDataResultRedirect : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                }

                [NameInMap("RouteOrder")]
                [Validation(Required=false)]
                public int? RouteOrder { get; set; }

                [NameInMap("RoutePredicates")]
                [Validation(Required=false)]
                public ListGatewayRouteResponseBodyDataResultRoutePredicates RoutePredicates { get; set; }
                public class ListGatewayRouteResponseBodyDataResultRoutePredicates : TeaModel {
                    [NameInMap("HeaderPredicates")]
                    [Validation(Required=false)]
                    public List<ListGatewayRouteResponseBodyDataResultRoutePredicatesHeaderPredicates> HeaderPredicates { get; set; }
                    public class ListGatewayRouteResponseBodyDataResultRoutePredicatesHeaderPredicates : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("MethodPredicates")]
                    [Validation(Required=false)]
                    public List<string> MethodPredicates { get; set; }

                    [NameInMap("PathPredicates")]
                    [Validation(Required=false)]
                    public ListGatewayRouteResponseBodyDataResultRoutePredicatesPathPredicates PathPredicates { get; set; }
                    public class ListGatewayRouteResponseBodyDataResultRoutePredicatesPathPredicates : TeaModel {
                        [NameInMap("IgnoreCase")]
                        [Validation(Required=false)]
                        public bool? IgnoreCase { get; set; }

                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("QueryPredicates")]
                    [Validation(Required=false)]
                    public List<ListGatewayRouteResponseBodyDataResultRoutePredicatesQueryPredicates> QueryPredicates { get; set; }
                    public class ListGatewayRouteResponseBodyDataResultRoutePredicatesQueryPredicates : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("RouteServices")]
                [Validation(Required=false)]
                public List<ListGatewayRouteResponseBodyDataResultRouteServices> RouteServices { get; set; }
                public class ListGatewayRouteResponseBodyDataResultRouteServices : TeaModel {
                    [NameInMap("AgreementType")]
                    [Validation(Required=false)]
                    public string AgreementType { get; set; }

                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    [NameInMap("HttpDubboTranscoder")]
                    [Validation(Required=false)]
                    public ListGatewayRouteResponseBodyDataResultRouteServicesHttpDubboTranscoder HttpDubboTranscoder { get; set; }
                    public class ListGatewayRouteResponseBodyDataResultRouteServicesHttpDubboTranscoder : TeaModel {
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
                        public List<ListGatewayRouteResponseBodyDataResultRouteServicesHttpDubboTranscoderMothedMapList> MothedMapList { get; set; }
                        public class ListGatewayRouteResponseBodyDataResultRouteServicesHttpDubboTranscoderMothedMapList : TeaModel {
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
                            public List<ListGatewayRouteResponseBodyDataResultRouteServicesHttpDubboTranscoderMothedMapListParamMapsList> ParamMapsList { get; set; }
                            public class ListGatewayRouteResponseBodyDataResultRouteServicesHttpDubboTranscoderMothedMapListParamMapsList : TeaModel {
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

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    [NameInMap("Percent")]
                    [Validation(Required=false)]
                    public int? Percent { get; set; }

                    [NameInMap("ServiceId")]
                    [Validation(Required=false)]
                    public long? ServiceId { get; set; }

                    [NameInMap("ServiceName")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

                    [NameInMap("ServicePort")]
                    [Validation(Required=false)]
                    public int? ServicePort { get; set; }

                    [NameInMap("SourceType")]
                    [Validation(Required=false)]
                    public string SourceType { get; set; }

                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                [NameInMap("Services")]
                [Validation(Required=false)]
                public string Services { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
