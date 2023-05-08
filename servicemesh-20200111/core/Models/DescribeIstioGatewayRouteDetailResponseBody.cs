// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeIstioGatewayRouteDetailResponseBody : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The percentage of requests to which the delay fault is injected.
        /// </summary>
        [NameInMap("RouteDetail")]
        [Validation(Required=false)]
        public DescribeIstioGatewayRouteDetailResponseBodyRouteDetail RouteDetail { get; set; }
        public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetail : TeaModel {
            [NameInMap("Domains")]
            [Validation(Required=false)]
            public List<string> Domains { get; set; }

            /// <summary>
            /// The ports of the specified hosts from which the traffic is routed.
            /// </summary>
            [NameInMap("HTTPAdvancedOptions")]
            [Validation(Required=false)]
            public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptions HTTPAdvancedOptions { get; set; }
            public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptions : TeaModel {
                /// <summary>
                /// The header key to be used to overwrite the original header key.
                /// </summary>
                [NameInMap("Delegate")]
                [Validation(Required=false)]
                public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsDelegate Delegate { get; set; }
                public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsDelegate : TeaModel {
                    /// <summary>
                    /// The values to be added to the header key.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The key to be deleted.
                    /// </summary>
                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                }

                [NameInMap("Fault")]
                [Validation(Required=false)]
                public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsFault Fault { get; set; }
                public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsFault : TeaModel {
                    [NameInMap("Abort")]
                    [Validation(Required=false)]
                    public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsFaultAbort Abort { get; set; }
                    public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsFaultAbort : TeaModel {
                        [NameInMap("HttpStatus")]
                        [Validation(Required=false)]
                        public int? HttpStatus { get; set; }

                        [NameInMap("Percentage")]
                        [Validation(Required=false)]
                        public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsFaultAbortPercentage Percentage { get; set; }
                        public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsFaultAbortPercentage : TeaModel {
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public float? Value { get; set; }

                        }

                    }

                    [NameInMap("Delay")]
                    [Validation(Required=false)]
                    public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsFaultDelay Delay { get; set; }
                    public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsFaultDelay : TeaModel {
                        [NameInMap("ExponentialDelay")]
                        [Validation(Required=false)]
                        public string ExponentialDelay { get; set; }

                        [NameInMap("FixedDelay")]
                        [Validation(Required=false)]
                        public string FixedDelay { get; set; }

                        [NameInMap("Percentage")]
                        [Validation(Required=false)]
                        public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsFaultDelayPercentage Percentage { get; set; }
                        public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsFaultDelayPercentage : TeaModel {
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public float? Value { get; set; }

                        }

                    }

                }

                /// <summary>
                /// The port of the specified host to which the traffic is routed.
                /// </summary>
                [NameInMap("HTTPRedirect")]
                [Validation(Required=false)]
                public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsHTTPRedirect HTTPRedirect { get; set; }
                public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsHTTPRedirect : TeaModel {
                    /// <summary>
                    /// The request headers to be matched.
                    /// </summary>
                    [NameInMap("Authority")]
                    [Validation(Required=false)]
                    public string Authority { get; set; }

                    /// <summary>
                    /// The request header to be matched.
                    /// </summary>
                    [NameInMap("RedirectCode")]
                    [Validation(Required=false)]
                    public int? RedirectCode { get; set; }

                    /// <summary>
                    /// The traffic weight. Valid values: 1 to 100.
                    /// </summary>
                    [NameInMap("Uri")]
                    [Validation(Required=false)]
                    public string Uri { get; set; }

                }

                [NameInMap("Mirror")]
                [Validation(Required=false)]
                public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsMirror Mirror { get; set; }
                public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsMirror : TeaModel {
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    [NameInMap("Subset")]
                    [Validation(Required=false)]
                    public string Subset { get; set; }

                }

                [NameInMap("MirrorPercentage")]
                [Validation(Required=false)]
                public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsMirrorPercentage MirrorPercentage { get; set; }
                public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsMirrorPercentage : TeaModel {
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("Retries")]
                [Validation(Required=false)]
                public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsRetries Retries { get; set; }
                public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsRetries : TeaModel {
                    /// <summary>
                    /// The priority of the routing rule. The value of this parameter is an integer. A smaller value indicates a higher priority.
                    /// </summary>
                    [NameInMap("Attempts")]
                    [Validation(Required=false)]
                    public int? Attempts { get; set; }

                    /// <summary>
                    /// The status of the routing rule. Valid values:
                    /// 
                    /// - `0`: The routing rule is valid.
                    /// - `1`: The routing rule is invalid.
                    /// - `2`: An error occurs during the creation or update of the routing rule.
                    /// </summary>
                    [NameInMap("PerTryTimeout")]
                    [Validation(Required=false)]
                    public string PerTryTimeout { get; set; }

                    /// <summary>
                    /// The description of the routing rule.
                    /// </summary>
                    [NameInMap("RetryOn")]
                    [Validation(Required=false)]
                    public string RetryOn { get; set; }

                    [NameInMap("RetryRemoteLocalities")]
                    [Validation(Required=false)]
                    public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsRetriesRetryRemoteLocalities RetryRemoteLocalities { get; set; }
                    public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsRetriesRetryRemoteLocalities : TeaModel {
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public bool? Value { get; set; }

                    }

                }

                /// <summary>
                /// The processing of the headers of the response that is to be returned.
                /// </summary>
                [NameInMap("Rewrite")]
                [Validation(Required=false)]
                public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsRewrite Rewrite { get; set; }
                public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsRewrite : TeaModel {
                    /// <summary>
                    /// The values to be added to the header key.
                    /// </summary>
                    [NameInMap("Authority")]
                    [Validation(Required=false)]
                    public string Authority { get; set; }

                    /// <summary>
                    /// The header key to be used to overwrite the original header key.
                    /// </summary>
                    [NameInMap("Uri")]
                    [Validation(Required=false)]
                    public string Uri { get; set; }

                }

                /// <summary>
                /// The key to be deleted.
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public string Timeout { get; set; }

            }

            /// <summary>
            /// The specified HTTP error code.
            /// </summary>
            [NameInMap("MatchRequest")]
            [Validation(Required=false)]
            public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailMatchRequest MatchRequest { get; set; }
            public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailMatchRequest : TeaModel {
                /// <summary>
                /// The name of the service defined in the service registry.
                /// </summary>
                [NameInMap("Headers")]
                [Validation(Required=false)]
                public List<DescribeIstioGatewayRouteDetailResponseBodyRouteDetailMatchRequestHeaders> Headers { get; set; }
                public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailMatchRequestHeaders : TeaModel {
                    /// <summary>
                    /// The percentage of requests that are mirrored to another destination except for the original destination, expressed as a decimal.
                    /// </summary>
                    [NameInMap("MatchingContent")]
                    [Validation(Required=false)]
                    public string MatchingContent { get; set; }

                    /// <summary>
                    /// The percentage of requests that are mirrored to another destination except for the original destination.
                    /// </summary>
                    [NameInMap("MatchingMode")]
                    [Validation(Required=false)]
                    public string MatchingMode { get; set; }

                    /// <summary>
                    /// The name of the service subset.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// The name of the service subset.
                /// </summary>
                [NameInMap("Ports")]
                [Validation(Required=false)]
                public List<int?> Ports { get; set; }

                /// <summary>
                /// The endpoints of service instances for Layer 4 weighted routing.
                /// </summary>
                [NameInMap("TLSMatchAttributes")]
                [Validation(Required=false)]
                public List<DescribeIstioGatewayRouteDetailResponseBodyRouteDetailMatchRequestTLSMatchAttributes> TLSMatchAttributes { get; set; }
                public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailMatchRequestTLSMatchAttributes : TeaModel {
                    /// <summary>
                    /// The name of the service defined in the service registry.
                    /// </summary>
                    [NameInMap("SNIHosts")]
                    [Validation(Required=false)]
                    public List<string> SNIHosts { get; set; }

                    /// <summary>
                    /// The unique endpoint of the service instance to which the specified requests are sent.
                    /// </summary>
                    [NameInMap("TLSPort")]
                    [Validation(Required=false)]
                    public int? TLSPort { get; set; }

                }

                /// <summary>
                /// The percentage of requests that are aborted with the specified error code.
                /// </summary>
                [NameInMap("URI")]
                [Validation(Required=false)]
                public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailMatchRequestURI URI { get; set; }
                public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailMatchRequestURI : TeaModel {
                    /// <summary>
                    /// The configurations for mirroring HTTP traffic to another destination in addition to forwarding requests to the specified destination.
                    /// </summary>
                    [NameInMap("MatchingContent")]
                    [Validation(Required=false)]
                    public string MatchingContent { get; set; }

                    /// <summary>
                    /// The percentage of requests that are aborted with the specified error code, expressed as a decimal.
                    /// </summary>
                    [NameInMap("MatchingMode")]
                    [Validation(Required=false)]
                    public string MatchingMode { get; set; }

                }

            }

            [NameInMap("RouteDestinations")]
            [Validation(Required=false)]
            public List<DescribeIstioGatewayRouteDetailResponseBodyRouteDetailRouteDestinations> RouteDestinations { get; set; }
            public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailRouteDestinations : TeaModel {
                [NameInMap("Destination")]
                [Validation(Required=false)]
                public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailRouteDestinationsDestination Destination { get; set; }
                public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailRouteDestinationsDestination : TeaModel {
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailRouteDestinationsDestinationPort Port { get; set; }
                    public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailRouteDestinationsDestinationPort : TeaModel {
                        [NameInMap("Number")]
                        [Validation(Required=false)]
                        public int? Number { get; set; }

                    }

                    [NameInMap("Subset")]
                    [Validation(Required=false)]
                    public string Subset { get; set; }

                }

                [NameInMap("Headers")]
                [Validation(Required=false)]
                public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailRouteDestinationsHeaders Headers { get; set; }
                public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailRouteDestinationsHeaders : TeaModel {
                    [NameInMap("Request")]
                    [Validation(Required=false)]
                    public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailRouteDestinationsHeadersRequest Request { get; set; }
                    public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailRouteDestinationsHeadersRequest : TeaModel {
                        [NameInMap("Add")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> Add { get; set; }

                        [NameInMap("Remove")]
                        [Validation(Required=false)]
                        public List<string> Remove { get; set; }

                        [NameInMap("Set")]
                        [Validation(Required=false)]
                        public Dictionary<string, string> Set { get; set; }

                    }

                    [NameInMap("Response")]
                    [Validation(Required=false)]
                    public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailRouteDestinationsHeadersResponse Response { get; set; }
                    public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailRouteDestinationsHeadersResponse : TeaModel {
                        [NameInMap("Add")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> Add { get; set; }

                        [NameInMap("Remove")]
                        [Validation(Required=false)]
                        public List<string> Remove { get; set; }

                        [NameInMap("Set")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> Set { get; set; }

                    }

                }

                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// The percentage of requests that are aborted with specified error codes, expressed as a decimal.
            /// </summary>
            [NameInMap("RouteName")]
            [Validation(Required=false)]
            public string RouteName { get; set; }

            /// <summary>
            /// The configurations for aborting requests with specified error codes.
            /// </summary>
            [NameInMap("RouteType")]
            [Validation(Required=false)]
            public string RouteType { get; set; }

        }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
