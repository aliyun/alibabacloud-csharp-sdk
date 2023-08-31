// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class CreateIstioGatewayRoutesRequest : TeaModel {
        /// <summary>
        /// The description of the routing rule.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The information about the routing rule to be created for the ASM gateway.
        /// </summary>
        [NameInMap("GatewayRoute")]
        [Validation(Required=false)]
        public CreateIstioGatewayRoutesRequestGatewayRoute GatewayRoute { get; set; }
        public class CreateIstioGatewayRoutesRequestGatewayRoute : TeaModel {
            /// <summary>
            /// The requested domain names.
            /// </summary>
            [NameInMap("Domains")]
            [Validation(Required=false)]
            public List<string> Domains { get; set; }

            /// <summary>
            /// The advanced settings for routing HTTP traffic.
            /// </summary>
            [NameInMap("HTTPAdvancedOptions")]
            [Validation(Required=false)]
            public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptions HTTPAdvancedOptions { get; set; }
            public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptions : TeaModel {
                /// <summary>
                /// The virtual service that defines traffic routing.
                /// </summary>
                [NameInMap("Delegate")]
                [Validation(Required=false)]
                public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsDelegate Delegate { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsDelegate : TeaModel {
                    /// <summary>
                    /// The name of the virtual service.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The namespace to which the virtual service belongs.
                    /// </summary>
                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                }

                /// <summary>
                /// The configurations of fault injection.
                /// </summary>
                [NameInMap("Fault")]
                [Validation(Required=false)]
                public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFault Fault { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFault : TeaModel {
                    /// <summary>
                    /// The configurations for aborting requests with specified error codes.
                    /// </summary>
                    [NameInMap("Abort")]
                    [Validation(Required=false)]
                    public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultAbort Abort { get; set; }
                    public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultAbort : TeaModel {
                        /// <summary>
                        /// The HTTP status code.
                        /// </summary>
                        [NameInMap("HttpStatus")]
                        [Validation(Required=false)]
                        public int? HttpStatus { get; set; }

                        /// <summary>
                        /// The percentage of requests that are aborted with the specified error code.
                        /// </summary>
                        [NameInMap("Percentage")]
                        [Validation(Required=false)]
                        public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultAbortPercentage Percentage { get; set; }
                        public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultAbortPercentage : TeaModel {
                            /// <summary>
                            /// The percentage of requests that are aborted with the specified error code, which is expressed as a decimal.
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public float? Value { get; set; }

                        }

                    }

                    /// <summary>
                    /// The duration to delay a request.
                    /// </summary>
                    [NameInMap("Delay")]
                    [Validation(Required=false)]
                    public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultDelay Delay { get; set; }
                    public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultDelay : TeaModel {
                        /// <summary>
                        /// The fixed duration for request delay.
                        /// </summary>
                        [NameInMap("FixedDelay")]
                        [Validation(Required=false)]
                        public string FixedDelay { get; set; }

                        /// <summary>
                        /// The percentage of requests to which the delay fault is injected.
                        /// </summary>
                        [NameInMap("Percentage")]
                        [Validation(Required=false)]
                        public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultDelayPercentage Percentage { get; set; }
                        public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultDelayPercentage : TeaModel {
                            /// <summary>
                            /// The percentage of requests to which the delay fault is injected, which is expressed as a decimal.
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public float? Value { get; set; }

                        }

                    }

                }

                /// <summary>
                /// The HTTP redirection rule.
                /// </summary>
                [NameInMap("HTTPRedirect")]
                [Validation(Required=false)]
                public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsHTTPRedirect HTTPRedirect { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsHTTPRedirect : TeaModel {
                    /// <summary>
                    /// The value to be used to overwrite the value of the Authority or Host header during redirection.``
                    /// </summary>
                    [NameInMap("Authority")]
                    [Validation(Required=false)]
                    public string Authority { get; set; }

                    /// <summary>
                    /// The HTTP status code to be used to indicate URL redirection. Default value: 301.
                    /// </summary>
                    [NameInMap("RedirectCode")]
                    [Validation(Required=false)]
                    public int? RedirectCode { get; set; }

                    /// <summary>
                    /// The value to be used to overwrite the URL path during redirection.
                    /// </summary>
                    [NameInMap("Uri")]
                    [Validation(Required=false)]
                    public string Uri { get; set; }

                }

                /// <summary>
                /// The configurations for mirroring HTTP traffic to another destination in addition to forwarding requests to the specified destination.
                /// </summary>
                [NameInMap("Mirror")]
                [Validation(Required=false)]
                public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsMirror Mirror { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsMirror : TeaModel {
                    /// <summary>
                    /// The name of the service defined in the service registry.
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// The name of the service subset.
                    /// </summary>
                    [NameInMap("Subset")]
                    [Validation(Required=false)]
                    public string Subset { get; set; }

                }

                /// <summary>
                /// The percentage of requests that are mirrored to another destination except for the original destination.
                /// </summary>
                [NameInMap("MirrorPercentage")]
                [Validation(Required=false)]
                public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsMirrorPercentage MirrorPercentage { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsMirrorPercentage : TeaModel {
                    /// <summary>
                    /// The percentage of requests that are mirrored to another destination except for the original destination, which is expressed as a decimal.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// The configurations of retries for failed requests.
                /// </summary>
                [NameInMap("Retries")]
                [Validation(Required=false)]
                public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsRetries Retries { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsRetries : TeaModel {
                    /// <summary>
                    /// The number of retries that are allowed for a request.
                    /// </summary>
                    [NameInMap("Attempts")]
                    [Validation(Required=false)]
                    public int? Attempts { get; set; }

                    /// <summary>
                    /// The timeout period for each retry. Example: `5s`.
                    /// </summary>
                    [NameInMap("PerTryTimeout")]
                    [Validation(Required=false)]
                    public string PerTryTimeout { get; set; }

                    /// <summary>
                    /// The condition for retries. Example: `connect-failure,refused-stream,503`.
                    /// </summary>
                    [NameInMap("RetryOn")]
                    [Validation(Required=false)]
                    public string RetryOn { get; set; }

                    /// <summary>
                    /// Specifies whether to allow retries to other localities.
                    /// </summary>
                    [NameInMap("RetryRemoteLocalities")]
                    [Validation(Required=false)]
                    public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsRetriesRetryRemoteLocalities RetryRemoteLocalities { get; set; }
                    public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsRetriesRetryRemoteLocalities : TeaModel {
                        /// <summary>
                        /// Specifies whether to allow retries to other localities. Valid values:
                        /// 
                        /// *   `true`
                        /// *   `false`
                        /// 
                        /// Default value: `false`.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public bool? Value { get; set; }

                    }

                }

                /// <summary>
                /// The configurations for rewriting the virtual service.
                /// </summary>
                [NameInMap("Rewrite")]
                [Validation(Required=false)]
                public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsRewrite Rewrite { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsRewrite : TeaModel {
                    /// <summary>
                    /// The value to be used to overwrite the value of the Authority or Host header.
                    /// </summary>
                    [NameInMap("Authority")]
                    [Validation(Required=false)]
                    public string Authority { get; set; }

                    /// <summary>
                    /// The value to be used to overwrite the path or prefix of the URI.
                    /// </summary>
                    [NameInMap("Uri")]
                    [Validation(Required=false)]
                    public string Uri { get; set; }

                }

                /// <summary>
                /// The timeout period for requests.
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public string Timeout { get; set; }

            }

            /// <summary>
            /// The matching rules for traffic routing.
            /// </summary>
            [NameInMap("MatchRequest")]
            [Validation(Required=false)]
            public CreateIstioGatewayRoutesRequestGatewayRouteMatchRequest MatchRequest { get; set; }
            public class CreateIstioGatewayRoutesRequestGatewayRouteMatchRequest : TeaModel {
                /// <summary>
                /// The request headers to be matched.
                /// </summary>
                [NameInMap("Headers")]
                [Validation(Required=false)]
                public List<CreateIstioGatewayRoutesRequestGatewayRouteMatchRequestHeaders> Headers { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteMatchRequestHeaders : TeaModel {
                    /// <summary>
                    /// The header value to be matched.
                    /// </summary>
                    [NameInMap("MatchingContent")]
                    [Validation(Required=false)]
                    public string MatchingContent { get; set; }

                    /// <summary>
                    /// The matching mode for the header value. Valid values:
                    /// 
                    /// *   `exact`: exact match
                    /// *   `prefix`: match by prefix
                    /// *   `regex`: match by regular expression
                    /// </summary>
                    [NameInMap("MatchingMode")]
                    [Validation(Required=false)]
                    public string MatchingMode { get; set; }

                    /// <summary>
                    /// The header key to be matched.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// The ports of destination services for Layer 4 weighted routing.
                /// </summary>
                [NameInMap("Ports")]
                [Validation(Required=false)]
                public List<int?> Ports { get; set; }

                /// <summary>
                /// The matching rule for Transport Layer Security (TLS) traffic.
                /// </summary>
                [NameInMap("TLSMatchAttributes")]
                [Validation(Required=false)]
                public List<CreateIstioGatewayRoutesRequestGatewayRouteMatchRequestTLSMatchAttributes> TLSMatchAttributes { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteMatchRequestTLSMatchAttributes : TeaModel {
                    /// <summary>
                    /// The Server Name Indication (SNI) values to be matched.
                    /// </summary>
                    [NameInMap("SNIHosts")]
                    [Validation(Required=false)]
                    public List<string> SNIHosts { get; set; }

                    /// <summary>
                    /// The TLS port.
                    /// </summary>
                    [NameInMap("TLSPort")]
                    [Validation(Required=false)]
                    public int? TLSPort { get; set; }

                }

                /// <summary>
                /// The matching rule for URIs.
                /// </summary>
                [NameInMap("URI")]
                [Validation(Required=false)]
                public CreateIstioGatewayRoutesRequestGatewayRouteMatchRequestURI URI { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteMatchRequestURI : TeaModel {
                    /// <summary>
                    /// The content to be matched.
                    /// </summary>
                    [NameInMap("MatchingContent")]
                    [Validation(Required=false)]
                    public string MatchingContent { get; set; }

                    /// <summary>
                    /// The matching mode for the routing rule. Valid values:
                    /// 
                    /// *   `exact`: exact match
                    /// *   `prefix`: match by prefix
                    /// *   `regex`: match by regular expression
                    /// </summary>
                    [NameInMap("MatchingMode")]
                    [Validation(Required=false)]
                    public string MatchingMode { get; set; }

                }

            }

            /// <summary>
            /// The namespace.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// A JSON string. This parameter corresponds to the three routing types in virtual services and provides configuration entries for advanced features. The value of this parameter overwrites the configurations in RouteName, RouteType, MatchRequest, and HTTPAdvancedOptions.
            /// </summary>
            [NameInMap("RawVSRoute")]
            [Validation(Required=false)]
            public object RawVSRoute { get; set; }

            /// <summary>
            /// The endpoints of destination services for Layer 4 weighted routing.
            /// </summary>
            [NameInMap("RouteDestinations")]
            [Validation(Required=false)]
            public List<CreateIstioGatewayRoutesRequestGatewayRouteRouteDestinations> RouteDestinations { get; set; }
            public class CreateIstioGatewayRoutesRequestGatewayRouteRouteDestinations : TeaModel {
                /// <summary>
                /// The unique endpoint of the destination service to which the specified requests are sent.
                /// </summary>
                [NameInMap("Destination")]
                [Validation(Required=false)]
                public CreateIstioGatewayRoutesRequestGatewayRouteRouteDestinationsDestination Destination { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteRouteDestinationsDestination : TeaModel {
                    /// <summary>
                    /// The name of the service defined in the service registry.
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// The port.
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public CreateIstioGatewayRoutesRequestGatewayRouteRouteDestinationsDestinationPort Port { get; set; }
                    public class CreateIstioGatewayRoutesRequestGatewayRouteRouteDestinationsDestinationPort : TeaModel {
                        /// <summary>
                        /// The port number.
                        /// </summary>
                        [NameInMap("Number")]
                        [Validation(Required=false)]
                        public int? Number { get; set; }

                    }

                    /// <summary>
                    /// The name of the service subset.
                    /// </summary>
                    [NameInMap("Subset")]
                    [Validation(Required=false)]
                    public string Subset { get; set; }

                }

                /// <summary>
                /// The weight of the service subset.
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// The name of the routing rule.
            /// </summary>
            [NameInMap("RouteName")]
            [Validation(Required=false)]
            public string RouteName { get; set; }

            /// <summary>
            /// The type of the traffic to be routed. Valid values: `HTTP`, `TLS`, and `TCP`.
            /// </summary>
            [NameInMap("RouteType")]
            [Validation(Required=false)]
            public string RouteType { get; set; }

        }

        /// <summary>
        /// The name of the ASM gateway.
        /// </summary>
        [NameInMap("IstioGatewayName")]
        [Validation(Required=false)]
        public string IstioGatewayName { get; set; }

        /// <summary>
        /// The priority of the routing rule. The value of this parameter is an integer. A smaller value indicates a higher priority.
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// The ASM instance ID.
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        /// <summary>
        /// The status of the routing rule. Valid values:
        /// 
        /// *   `0`: The routing rule is valid.
        /// *   `1`: The routing rule is invalid.
        /// *   `2`: An error occurs during the creation or update of the routing rule.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
