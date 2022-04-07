// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayRouteWafStatusResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateGatewayRouteWafStatusResponseBodyData Data { get; set; }
        public class UpdateGatewayRouteWafStatusResponseBodyData : TeaModel {
            [NameInMap("Cors")]
            [Validation(Required=false)]
            public UpdateGatewayRouteWafStatusResponseBodyDataCors Cors { get; set; }
            public class UpdateGatewayRouteWafStatusResponseBodyDataCors : TeaModel {
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
            public UpdateGatewayRouteWafStatusResponseBodyDataDirectResponse DirectResponse { get; set; }
            public class UpdateGatewayRouteWafStatusResponseBodyDataDirectResponse : TeaModel {
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
            public List<string> DomainIdList { get; set; }
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }
            [NameInMap("DomainNameList")]
            [Validation(Required=false)]
            public List<string> DomainNameList { get; set; }
            [NameInMap("EnableWaf")]
            [Validation(Required=false)]
            public bool? EnableWaf { get; set; }
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
            public UpdateGatewayRouteWafStatusResponseBodyDataHTTPRewrite HTTPRewrite { get; set; }
            public class UpdateGatewayRouteWafStatusResponseBodyDataHTTPRewrite : TeaModel {
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
            public UpdateGatewayRouteWafStatusResponseBodyDataHeaderOp HeaderOp { get; set; }
            public class UpdateGatewayRouteWafStatusResponseBodyDataHeaderOp : TeaModel {
                [NameInMap("HeaderOpItems")]
                [Validation(Required=false)]
                public List<UpdateGatewayRouteWafStatusResponseBodyDataHeaderOpHeaderOpItems> HeaderOpItems { get; set; }
                public class UpdateGatewayRouteWafStatusResponseBodyDataHeaderOpHeaderOpItems : TeaModel {
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
            public UpdateGatewayRouteWafStatusResponseBodyDataRedirect Redirect { get; set; }
            public class UpdateGatewayRouteWafStatusResponseBodyDataRedirect : TeaModel {
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
            public UpdateGatewayRouteWafStatusResponseBodyDataRetry Retry { get; set; }
            public class UpdateGatewayRouteWafStatusResponseBodyDataRetry : TeaModel {
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
            public UpdateGatewayRouteWafStatusResponseBodyDataRoutePredicates RoutePredicates { get; set; }
            public class UpdateGatewayRouteWafStatusResponseBodyDataRoutePredicates : TeaModel {
                [NameInMap("HeaderPredicates")]
                [Validation(Required=false)]
                public List<UpdateGatewayRouteWafStatusResponseBodyDataRoutePredicatesHeaderPredicates> HeaderPredicates { get; set; }
                public class UpdateGatewayRouteWafStatusResponseBodyDataRoutePredicatesHeaderPredicates : TeaModel {
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
                public UpdateGatewayRouteWafStatusResponseBodyDataRoutePredicatesPathPredicates PathPredicates { get; set; }
                public class UpdateGatewayRouteWafStatusResponseBodyDataRoutePredicatesPathPredicates : TeaModel {
                    [NameInMap("IgnoreCase")]
                    [Validation(Required=false)]
                    public bool? IgnoreCase { get; set; }
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }
                };

                [NameInMap("QueryPredicates")]
                [Validation(Required=false)]
                public List<UpdateGatewayRouteWafStatusResponseBodyDataRoutePredicatesQueryPredicates> QueryPredicates { get; set; }
                public class UpdateGatewayRouteWafStatusResponseBodyDataRoutePredicatesQueryPredicates : TeaModel {
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
            public List<UpdateGatewayRouteWafStatusResponseBodyDataRouteServices> RouteServices { get; set; }
            public class UpdateGatewayRouteWafStatusResponseBodyDataRouteServices : TeaModel {
                public string GroupName { get; set; }
                public string Name { get; set; }
                public string Namespace { get; set; }
                public int? Percent { get; set; }
                public long? ServiceId { get; set; }
                public string ServiceName { get; set; }
                public string SourceType { get; set; }
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
            public UpdateGatewayRouteWafStatusResponseBodyDataTimeout Timeout { get; set; }
            public class UpdateGatewayRouteWafStatusResponseBodyDataTimeout : TeaModel {
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
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
