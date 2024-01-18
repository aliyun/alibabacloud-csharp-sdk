// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetGatewayRouteDetailResponseBody : TeaModel {
        /// <summary>
        /// The status code returned. A value of 200 indicates that the request is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGatewayRouteDetailResponseBodyData Data { get; set; }
        public class GetGatewayRouteDetailResponseBodyData : TeaModel {
            /// <summary>
            /// The status of Application High Availability Service (AHAS).
            /// </summary>
            [NameInMap("AhasStatus")]
            [Validation(Required=false)]
            public int? AhasStatus { get; set; }

            /// <summary>
            /// The configuration for cross-origin resource sharing (CORS).
            /// </summary>
            [NameInMap("Cors")]
            [Validation(Required=false)]
            public GetGatewayRouteDetailResponseBodyDataCors Cors { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataCors : TeaModel {
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

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

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
            public GetGatewayRouteDetailResponseBodyDataDirectResponse DirectResponse { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataDirectResponse : TeaModel {
                /// <summary>
                /// The mock return value.
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
            /// The IDs of domains.
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
            /// The list of domain names.
            /// </summary>
            [NameInMap("DomainNameList")]
            [Validation(Required=false)]
            public List<string> DomainNameList { get; set; }

            /// <summary>
            /// Indicates whether Web Application Firewall (WAF) is activated.
            /// </summary>
            [NameInMap("EnableWaf")]
            [Validation(Required=false)]
            public bool? EnableWaf { get; set; }

            /// <summary>
            /// Indicates whether the Fallback service is enabled.
            /// </summary>
            [NameInMap("Fallback")]
            [Validation(Required=false)]
            public bool? Fallback { get; set; }

            /// <summary>
            /// The information of the Fallback service.
            /// </summary>
            [NameInMap("FallbackServices")]
            [Validation(Required=false)]
            public List<GetGatewayRouteDetailResponseBodyDataFallbackServices> FallbackServices { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataFallbackServices : TeaModel {
                /// <summary>
                /// The protocol type.
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
                /// The service ID.
                /// </summary>
                [NameInMap("ServiceId")]
                [Validation(Required=false)]
                public long? ServiceId { get; set; }

                /// <summary>
                /// The service name.
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                /// <summary>
                /// The port number of the service.
                /// </summary>
                [NameInMap("ServicePort")]
                [Validation(Required=false)]
                public int? ServicePort { get; set; }

                /// <summary>
                /// The source type of the service.
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// The service version.
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// 流量镜像配置。
            /// </summary>
            [NameInMap("FlowMirror")]
            [Validation(Required=false)]
            public GetGatewayRouteDetailResponseBodyDataFlowMirror FlowMirror { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataFlowMirror : TeaModel {
                /// <summary>
                /// 流量复制比例（%），取值0-100。
                /// </summary>
                [NameInMap("Percentage")]
                [Validation(Required=false)]
                public int? Percentage { get; set; }

                /// <summary>
                /// 目标服务端口。
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// 开启状态，取值：
                /// 
                /// - on：开启
                /// - off：关闭
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// 目标服务ID。
                /// </summary>
                [NameInMap("TargetServiceId")]
                [Validation(Required=false)]
                public long? TargetServiceId { get; set; }

                /// <summary>
                /// 目标服务名称。
                /// </summary>
                [NameInMap("TargetServiceName")]
                [Validation(Required=false)]
                public string TargetServiceName { get; set; }

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
            /// The last modification time.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// The information about the rewrite policy.
            /// </summary>
            [NameInMap("HTTPRewrite")]
            [Validation(Required=false)]
            public GetGatewayRouteDetailResponseBodyDataHTTPRewrite HTTPRewrite { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataHTTPRewrite : TeaModel {
                /// <summary>
                /// The hostname of the gateway.
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// The path of the node.
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// The rewrite type.
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
                /// The status of the policy.
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
            public GetGatewayRouteDetailResponseBodyDataHeaderOp HeaderOp { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataHeaderOp : TeaModel {
                /// <summary>
                /// The information about headers.
                /// </summary>
                [NameInMap("HeaderOpItems")]
                [Validation(Required=false)]
                public List<GetGatewayRouteDetailResponseBodyDataHeaderOpHeaderOpItems> HeaderOpItems { get; set; }
                public class GetGatewayRouteDetailResponseBodyDataHeaderOpHeaderOpItems : TeaModel {
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
                    /// The type of the operation.
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
            /// The routing policy in a JSON string.
            /// </summary>
            [NameInMap("Policies")]
            [Validation(Required=false)]
            public string Policies { get; set; }

            /// <summary>
            /// The matching conditions.
            /// </summary>
            [NameInMap("Predicates")]
            [Validation(Required=false)]
            public string Predicates { get; set; }

            /// <summary>
            /// The configuration of the redirection.
            /// </summary>
            [NameInMap("Redirect")]
            [Validation(Required=false)]
            public GetGatewayRouteDetailResponseBodyDataRedirect Redirect { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataRedirect : TeaModel {
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
            public GetGatewayRouteDetailResponseBodyDataRetry Retry { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataRetry : TeaModel {
                /// <summary>
                /// The number of retries allowed.
                /// </summary>
                [NameInMap("Attempts")]
                [Validation(Required=false)]
                public int? Attempts { get; set; }

                /// <summary>
                /// The HTTP status codes.
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
            public GetGatewayRouteDetailResponseBodyDataRoutePredicates RoutePredicates { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataRoutePredicates : TeaModel {
                /// <summary>
                /// The information about header matching.
                /// </summary>
                [NameInMap("HeaderPredicates")]
                [Validation(Required=false)]
                public List<GetGatewayRouteDetailResponseBodyDataRoutePredicatesHeaderPredicates> HeaderPredicates { get; set; }
                public class GetGatewayRouteDetailResponseBodyDataRoutePredicatesHeaderPredicates : TeaModel {
                    /// <summary>
                    /// The key of the request header.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The route type.
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
                public GetGatewayRouteDetailResponseBodyDataRoutePredicatesPathPredicates PathPredicates { get; set; }
                public class GetGatewayRouteDetailResponseBodyDataRoutePredicatesPathPredicates : TeaModel {
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
                /// The information about parameter matching.
                /// </summary>
                [NameInMap("QueryPredicates")]
                [Validation(Required=false)]
                public List<GetGatewayRouteDetailResponseBodyDataRoutePredicatesQueryPredicates> QueryPredicates { get; set; }
                public class GetGatewayRouteDetailResponseBodyDataRoutePredicatesQueryPredicates : TeaModel {
                    /// <summary>
                    /// The parameter name.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The route type.
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
            /// The services.
            /// </summary>
            [NameInMap("RouteServices")]
            [Validation(Required=false)]
            public List<GetGatewayRouteDetailResponseBodyDataRouteServices> RouteServices { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataRouteServices : TeaModel {
                /// <summary>
                /// The protocol type.
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
                /// The service name.
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
                /// The service ID.
                /// </summary>
                [NameInMap("ServiceId")]
                [Validation(Required=false)]
                public long? ServiceId { get; set; }

                /// <summary>
                /// The service name.
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                /// <summary>
                /// The port number of the service.
                /// </summary>
                [NameInMap("ServicePort")]
                [Validation(Required=false)]
                public int? ServicePort { get; set; }

                /// <summary>
                /// The source type of the service.
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("UnhealthyEndpoints")]
                [Validation(Required=false)]
                public List<string> UnhealthyEndpoints { get; set; }

                /// <summary>
                /// The service version.
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// The configurations of services.
            /// </summary>
            [NameInMap("Services")]
            [Validation(Required=false)]
            public string Services { get; set; }

            /// <summary>
            /// The status of the route. Valid values:
            /// 
            /// *   0: unpublished
            /// *   2: publishing
            /// *   3: published
            /// *   4: editing (updated but not published)
            /// *   5: unpublishing
            /// *   6: unavailable
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The timeout configuration.
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public GetGatewayRouteDetailResponseBodyDataTimeout Timeout { get; set; }
            public class GetGatewayRouteDetailResponseBodyDataTimeout : TeaModel {
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
