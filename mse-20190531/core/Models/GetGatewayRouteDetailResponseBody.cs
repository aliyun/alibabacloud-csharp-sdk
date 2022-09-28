// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetGatewayRouteDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGatewayRouteDetailResponseBodyData Data { get; set; }
        public class GetGatewayRouteDetailResponseBodyData : TeaModel {
            [NameInMap("AhasStatus")]
            [Validation(Required=false)]
            public int? AhasStatus { get; set; }

            [NameInMap("Cors")]
            [Validation(Required=false)]
            public GetGatewayRouteDetailResponseBodyDataCors Cors { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataCors : TeaModel {
                [NameInMap("AllowCredentials")]
                [Validation(Required=false)]
                public bool? AllowCredentials { get; set; }

                [NameInMap("AllowHeaders")]
                [Validation(Required=false)]
                public string AllowHeaders { get; set; }

                [NameInMap("AllowMethods")]
                [Validation(Required=false)]
                public string AllowMethods { get; set; }

                [NameInMap("AllowOrigins")]
                [Validation(Required=false)]
                public string AllowOrigins { get; set; }

                [NameInMap("ExposeHeaders")]
                [Validation(Required=false)]
                public string ExposeHeaders { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TimeUnit")]
                [Validation(Required=false)]
                public string TimeUnit { get; set; }

                [NameInMap("UnitNum")]
                [Validation(Required=false)]
                public long? UnitNum { get; set; }

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
            public GetGatewayRouteDetailResponseBodyDataDirectResponse DirectResponse { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataDirectResponse : TeaModel {
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
            public bool? EnableWaf { get; set; }

            [NameInMap("Fallback")]
            [Validation(Required=false)]
            public bool? Fallback { get; set; }

            [NameInMap("FallbackServices")]
            [Validation(Required=false)]
            public List<GetGatewayRouteDetailResponseBodyDataFallbackServices> FallbackServices { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataFallbackServices : TeaModel {
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

            [NameInMap("HTTPRewrite")]
            [Validation(Required=false)]
            public GetGatewayRouteDetailResponseBodyDataHTTPRewrite HTTPRewrite { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataHTTPRewrite : TeaModel {
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("PathType")]
                [Validation(Required=false)]
                public string PathType { get; set; }

                [NameInMap("Pattern")]
                [Validation(Required=false)]
                public string Pattern { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Substitution")]
                [Validation(Required=false)]
                public string Substitution { get; set; }

            }

            [NameInMap("HeaderOp")]
            [Validation(Required=false)]
            public GetGatewayRouteDetailResponseBodyDataHeaderOp HeaderOp { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataHeaderOp : TeaModel {
                [NameInMap("HeaderOpItems")]
                [Validation(Required=false)]
                public List<GetGatewayRouteDetailResponseBodyDataHeaderOpHeaderOpItems> HeaderOpItems { get; set; }
                public class GetGatewayRouteDetailResponseBodyDataHeaderOpHeaderOpItems : TeaModel {
                    [NameInMap("DirectionType")]
                    [Validation(Required=false)]
                    public string DirectionType { get; set; }

                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("OpType")]
                    [Validation(Required=false)]
                    public string OpType { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

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
            public GetGatewayRouteDetailResponseBodyDataRedirect Redirect { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataRedirect : TeaModel {
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

            [NameInMap("Retry")]
            [Validation(Required=false)]
            public GetGatewayRouteDetailResponseBodyDataRetry Retry { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataRetry : TeaModel {
                [NameInMap("Attempts")]
                [Validation(Required=false)]
                public int? Attempts { get; set; }

                [NameInMap("HttpCodes")]
                [Validation(Required=false)]
                public List<string> HttpCodes { get; set; }

                [NameInMap("RetryOn")]
                [Validation(Required=false)]
                public List<string> RetryOn { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("RouteOrder")]
            [Validation(Required=false)]
            public int? RouteOrder { get; set; }

            [NameInMap("RoutePredicates")]
            [Validation(Required=false)]
            public GetGatewayRouteDetailResponseBodyDataRoutePredicates RoutePredicates { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataRoutePredicates : TeaModel {
                [NameInMap("HeaderPredicates")]
                [Validation(Required=false)]
                public List<GetGatewayRouteDetailResponseBodyDataRoutePredicatesHeaderPredicates> HeaderPredicates { get; set; }
                public class GetGatewayRouteDetailResponseBodyDataRoutePredicatesHeaderPredicates : TeaModel {
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
                public GetGatewayRouteDetailResponseBodyDataRoutePredicatesPathPredicates PathPredicates { get; set; }
                public class GetGatewayRouteDetailResponseBodyDataRoutePredicatesPathPredicates : TeaModel {
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
                public List<GetGatewayRouteDetailResponseBodyDataRoutePredicatesQueryPredicates> QueryPredicates { get; set; }
                public class GetGatewayRouteDetailResponseBodyDataRoutePredicatesQueryPredicates : TeaModel {
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
            public List<GetGatewayRouteDetailResponseBodyDataRouteServices> RouteServices { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataRouteServices : TeaModel {
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

            [NameInMap("Services")]
            [Validation(Required=false)]
            public string Services { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public GetGatewayRouteDetailResponseBodyDataTimeout Timeout { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataTimeout : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TimeUnit")]
                [Validation(Required=false)]
                public string TimeUnit { get; set; }

                [NameInMap("UnitNum")]
                [Validation(Required=false)]
                public int? UnitNum { get; set; }

            }

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
