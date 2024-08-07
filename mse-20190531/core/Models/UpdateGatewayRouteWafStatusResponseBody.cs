// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayRouteWafStatusResponseBody : TeaModel {
        /// <summary>
        /// The status code returned. A value of 200 indicates that the request is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateGatewayRouteWafStatusResponseBodyData Data { get; set; }
        public class UpdateGatewayRouteWafStatusResponseBodyData : TeaModel {
            /// <summary>
            /// The configuration for cross-origin resource sharing (CORS).
            /// </summary>
            [NameInMap("Cors")]
            [Validation(Required=false)]
            public UpdateGatewayRouteWafStatusResponseBodyDataCors Cors { get; set; }
            public class UpdateGatewayRouteWafStatusResponseBodyDataCors : TeaModel {
                /// <summary>
                /// The credentials allowed.
                /// </summary>
                [NameInMap("AllowCredentials")]
                [Validation(Required=false)]
                public bool? AllowCredentials { get; set; }

                /// <summary>
                /// The headers allowed.
                /// </summary>
                [NameInMap("AllowHeaders")]
                [Validation(Required=false)]
                public string AllowHeaders { get; set; }

                /// <summary>
                /// The methods allowed.
                /// </summary>
                [NameInMap("AllowMethods")]
                [Validation(Required=false)]
                public string AllowMethods { get; set; }

                /// <summary>
                /// The origins allowed.
                /// </summary>
                [NameInMap("AllowOrigins")]
                [Validation(Required=false)]
                public string AllowOrigins { get; set; }

                /// <summary>
                /// The response headers.
                /// </summary>
                [NameInMap("ExposeHeaders")]
                [Validation(Required=false)]
                public string ExposeHeaders { get; set; }

                /// <summary>
                /// The status.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The time unit.
                /// </summary>
                [NameInMap("TimeUnit")]
                [Validation(Required=false)]
                public string TimeUnit { get; set; }

                /// <summary>
                /// The unit number.
                /// </summary>
                [NameInMap("UnitNum")]
                [Validation(Required=false)]
                public long? UnitNum { get; set; }

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
            public UpdateGatewayRouteWafStatusResponseBodyDataDirectResponse DirectResponse { get; set; }
            public class UpdateGatewayRouteWafStatusResponseBodyDataDirectResponse : TeaModel {
                /// <summary>
                /// The mock return value.
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public string Body { get; set; }

                /// <summary>
                /// The return value.
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
            /// The list of domain IDs.
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

            /// <summary>
            /// Indicates whether WAF is activated.
            /// </summary>
            [NameInMap("EnableWaf")]
            [Validation(Required=false)]
            public bool? EnableWaf { get; set; }

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
            /// The information about the rewrite policy.
            /// </summary>
            [NameInMap("HTTPRewrite")]
            [Validation(Required=false)]
            public UpdateGatewayRouteWafStatusResponseBodyDataHTTPRewrite HTTPRewrite { get; set; }
            public class UpdateGatewayRouteWafStatusResponseBodyDataHTTPRewrite : TeaModel {
                /// <summary>
                /// The domain name.
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// The HTTP request path.
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// The path type of the HTTP request.
                /// </summary>
                [NameInMap("PathType")]
                [Validation(Required=false)]
                public string PathType { get; set; }

                /// <summary>
                /// The matching pattern.
                /// </summary>
                [NameInMap("Pattern")]
                [Validation(Required=false)]
                public string Pattern { get; set; }

                /// <summary>
                /// The HTTP status.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The replacement.
                /// </summary>
                [NameInMap("Substitution")]
                [Validation(Required=false)]
                public string Substitution { get; set; }

            }

            /// <summary>
            /// The header settings.
            /// </summary>
            [NameInMap("HeaderOp")]
            [Validation(Required=false)]
            public UpdateGatewayRouteWafStatusResponseBodyDataHeaderOp HeaderOp { get; set; }
            public class UpdateGatewayRouteWafStatusResponseBodyDataHeaderOp : TeaModel {
                /// <summary>
                /// The policy.
                /// </summary>
                [NameInMap("HeaderOpItems")]
                [Validation(Required=false)]
                public List<UpdateGatewayRouteWafStatusResponseBodyDataHeaderOpHeaderOpItems> HeaderOpItems { get; set; }
                public class UpdateGatewayRouteWafStatusResponseBodyDataHeaderOpHeaderOpItems : TeaModel {
                    /// <summary>
                    /// The request or response.
                    /// </summary>
                    [NameInMap("DirectionType")]
                    [Validation(Required=false)]
                    public string DirectionType { get; set; }

                    /// <summary>
                    /// The header key.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The operation type.
                    /// </summary>
                    [NameInMap("OpType")]
                    [Validation(Required=false)]
                    public string OpType { get; set; }

                    /// <summary>
                    /// The header value.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The status.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The ID of the route.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The name of the route.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The matching rule.
            /// </summary>
            [NameInMap("Predicates")]
            [Validation(Required=false)]
            public string Predicates { get; set; }

            /// <summary>
            /// The configuration of the redirection.
            /// </summary>
            [NameInMap("Redirect")]
            [Validation(Required=false)]
            public UpdateGatewayRouteWafStatusResponseBodyDataRedirect Redirect { get; set; }
            public class UpdateGatewayRouteWafStatusResponseBodyDataRedirect : TeaModel {
                /// <summary>
                /// The response code returned.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

                /// <summary>
                /// The hostname.
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
            /// The retry configuration.
            /// </summary>
            [NameInMap("Retry")]
            [Validation(Required=false)]
            public UpdateGatewayRouteWafStatusResponseBodyDataRetry Retry { get; set; }
            public class UpdateGatewayRouteWafStatusResponseBodyDataRetry : TeaModel {
                /// <summary>
                /// The number of retries allowed for a request.
                /// </summary>
                [NameInMap("Attempts")]
                [Validation(Required=false)]
                public int? Attempts { get; set; }

                /// <summary>
                /// The HTTP status code.
                /// </summary>
                [NameInMap("HttpCodes")]
                [Validation(Required=false)]
                public List<string> HttpCodes { get; set; }

                /// <summary>
                /// The retry condition.
                /// </summary>
                [NameInMap("RetryOn")]
                [Validation(Required=false)]
                public List<string> RetryOn { get; set; }

                /// <summary>
                /// The retry status.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The sequence number of the route.
            /// </summary>
            [NameInMap("RouteOrder")]
            [Validation(Required=false)]
            public int? RouteOrder { get; set; }

            /// <summary>
            /// The information about route matching.
            /// </summary>
            [NameInMap("RoutePredicates")]
            [Validation(Required=false)]
            public UpdateGatewayRouteWafStatusResponseBodyDataRoutePredicates RoutePredicates { get; set; }
            public class UpdateGatewayRouteWafStatusResponseBodyDataRoutePredicates : TeaModel {
                /// <summary>
                /// The information about matching based on request headers.
                /// </summary>
                [NameInMap("HeaderPredicates")]
                [Validation(Required=false)]
                public List<UpdateGatewayRouteWafStatusResponseBodyDataRoutePredicatesHeaderPredicates> HeaderPredicates { get; set; }
                public class UpdateGatewayRouteWafStatusResponseBodyDataRoutePredicatesHeaderPredicates : TeaModel {
                    /// <summary>
                    /// The key of the request header.
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
                    /// The value of the request header.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about method matching.
                /// </summary>
                [NameInMap("MethodPredicates")]
                [Validation(Required=false)]
                public List<string> MethodPredicates { get; set; }

                /// <summary>
                /// The information about route matching.
                /// </summary>
                [NameInMap("PathPredicates")]
                [Validation(Required=false)]
                public UpdateGatewayRouteWafStatusResponseBodyDataRoutePredicatesPathPredicates PathPredicates { get; set; }
                public class UpdateGatewayRouteWafStatusResponseBodyDataRoutePredicatesPathPredicates : TeaModel {
                    /// <summary>
                    /// Indicates whether case sensitivity is ignored.
                    /// </summary>
                    [NameInMap("IgnoreCase")]
                    [Validation(Required=false)]
                    public bool? IgnoreCase { get; set; }

                    /// <summary>
                    /// The path.
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
                /// The parameter matching rules.
                /// </summary>
                [NameInMap("QueryPredicates")]
                [Validation(Required=false)]
                public List<UpdateGatewayRouteWafStatusResponseBodyDataRoutePredicatesQueryPredicates> QueryPredicates { get; set; }
                public class UpdateGatewayRouteWafStatusResponseBodyDataRoutePredicatesQueryPredicates : TeaModel {
                    /// <summary>
                    /// The name of the parameter.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The type.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// The value of the parameter.
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
            public List<UpdateGatewayRouteWafStatusResponseBodyDataRouteServices> RouteServices { get; set; }
            public class UpdateGatewayRouteWafStatusResponseBodyDataRouteServices : TeaModel {
                /// <summary>
                /// The name of the group to which the service belongs.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// The name of the service.
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
                /// The weight.
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
                /// The source type of the service.
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
            /// The information about services.
            /// </summary>
            [NameInMap("Services")]
            [Validation(Required=false)]
            public string Services { get; set; }

            /// <summary>
            /// The status of the route.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The timeout configuration.
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public UpdateGatewayRouteWafStatusResponseBodyDataTimeout Timeout { get; set; }
            public class UpdateGatewayRouteWafStatusResponseBodyDataTimeout : TeaModel {
                /// <summary>
                /// The status.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The time unit.
                /// </summary>
                [NameInMap("TimeUnit")]
                [Validation(Required=false)]
                public string TimeUnit { get; set; }

                /// <summary>
                /// The unit number.
                /// </summary>
                [NameInMap("UnitNum")]
                [Validation(Required=false)]
                public int? UnitNum { get; set; }

            }

        }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The message returned.
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
