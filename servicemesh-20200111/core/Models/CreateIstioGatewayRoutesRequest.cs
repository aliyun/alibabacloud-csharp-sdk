// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class CreateIstioGatewayRoutesRequest : TeaModel {
        /// <summary>
        /// <para>The description of the routing rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo route</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The information about the routing rule to be created for the ASM gateway.</para>
        /// </summary>
        [NameInMap("GatewayRoute")]
        [Validation(Required=false)]
        public CreateIstioGatewayRoutesRequestGatewayRoute GatewayRoute { get; set; }
        public class CreateIstioGatewayRoutesRequestGatewayRoute : TeaModel {
            /// <summary>
            /// <para>The requested domain names.</para>
            /// </summary>
            [NameInMap("Domains")]
            [Validation(Required=false)]
            public List<string> Domains { get; set; }

            /// <summary>
            /// <para>The advanced settings for routing HTTP traffic.</para>
            /// </summary>
            [NameInMap("HTTPAdvancedOptions")]
            [Validation(Required=false)]
            public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptions HTTPAdvancedOptions { get; set; }
            public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptions : TeaModel {
                /// <summary>
                /// <para>The virtual service that defines traffic routing.</para>
                /// </summary>
                [NameInMap("Delegate")]
                [Validation(Required=false)]
                public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsDelegate Delegate { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsDelegate : TeaModel {
                    /// <summary>
                    /// <para>The name of the virtual service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>reviews</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The namespace to which the virtual service belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                }

                /// <summary>
                /// <para>The configurations of fault injection.</para>
                /// </summary>
                [NameInMap("Fault")]
                [Validation(Required=false)]
                public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFault Fault { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFault : TeaModel {
                    /// <summary>
                    /// <para>The configurations for aborting requests with specified error codes.</para>
                    /// </summary>
                    [NameInMap("Abort")]
                    [Validation(Required=false)]
                    public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultAbort Abort { get; set; }
                    public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultAbort : TeaModel {
                        /// <summary>
                        /// <para>The HTTP status code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>400</para>
                        /// </summary>
                        [NameInMap("HttpStatus")]
                        [Validation(Required=false)]
                        public int? HttpStatus { get; set; }

                        /// <summary>
                        /// <para>The percentage of requests that are aborted with the specified error code.</para>
                        /// </summary>
                        [NameInMap("Percentage")]
                        [Validation(Required=false)]
                        public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultAbortPercentage Percentage { get; set; }
                        public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultAbortPercentage : TeaModel {
                            /// <summary>
                            /// <para>The percentage of requests that are aborted with the specified error code, which is expressed as a decimal.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0.1</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public float? Value { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The duration to delay a request.</para>
                    /// </summary>
                    [NameInMap("Delay")]
                    [Validation(Required=false)]
                    public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultDelay Delay { get; set; }
                    public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultDelay : TeaModel {
                        /// <summary>
                        /// <para>The fixed duration for request delay.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5s</para>
                        /// </summary>
                        [NameInMap("FixedDelay")]
                        [Validation(Required=false)]
                        public string FixedDelay { get; set; }

                        /// <summary>
                        /// <para>The percentage of requests to which the delay fault is injected.</para>
                        /// </summary>
                        [NameInMap("Percentage")]
                        [Validation(Required=false)]
                        public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultDelayPercentage Percentage { get; set; }
                        public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultDelayPercentage : TeaModel {
                            /// <summary>
                            /// <para>The percentage of requests to which the delay fault is injected, which is expressed as a decimal.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0.1</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public float? Value { get; set; }

                        }

                    }

                }

                /// <summary>
                /// <para>The HTTP redirection rule.</para>
                /// </summary>
                [NameInMap("HTTPRedirect")]
                [Validation(Required=false)]
                public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsHTTPRedirect HTTPRedirect { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsHTTPRedirect : TeaModel {
                    /// <summary>
                    /// <para>The value to be used to overwrite the value of the Authority or Host header during redirection.``</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>newratings.default.svc.cluster.local</para>
                    /// </summary>
                    [NameInMap("Authority")]
                    [Validation(Required=false)]
                    public string Authority { get; set; }

                    /// <summary>
                    /// <para>The HTTP status code to be used to indicate URL redirection. Default value: 301.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>301</para>
                    /// </summary>
                    [NameInMap("RedirectCode")]
                    [Validation(Required=false)]
                    public int? RedirectCode { get; set; }

                    /// <summary>
                    /// <para>The value to be used to overwrite the URL path during redirection.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/v1/getProductRatings</para>
                    /// </summary>
                    [NameInMap("Uri")]
                    [Validation(Required=false)]
                    public string Uri { get; set; }

                }

                /// <summary>
                /// <para>The configurations for mirroring HTTP traffic to another destination in addition to forwarding requests to the specified destination.</para>
                /// </summary>
                [NameInMap("Mirror")]
                [Validation(Required=false)]
                public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsMirror Mirror { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsMirror : TeaModel {
                    /// <summary>
                    /// <para>The name of the service defined in the service registry.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>reviews.default.svc.cluster.local</para>
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// <para>The name of the service subset.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>v1</para>
                    /// </summary>
                    [NameInMap("Subset")]
                    [Validation(Required=false)]
                    public string Subset { get; set; }

                }

                /// <summary>
                /// <para>The percentage of requests that are mirrored to another destination except for the original destination.</para>
                /// </summary>
                [NameInMap("MirrorPercentage")]
                [Validation(Required=false)]
                public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsMirrorPercentage MirrorPercentage { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsMirrorPercentage : TeaModel {
                    /// <summary>
                    /// <para>The percentage of requests that are mirrored to another destination except for the original destination, which is expressed as a decimal.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.2</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// <para>The configurations of retries for failed requests.</para>
                /// </summary>
                [NameInMap("Retries")]
                [Validation(Required=false)]
                public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsRetries Retries { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsRetries : TeaModel {
                    /// <summary>
                    /// <para>The number of retries that are allowed for a request.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Attempts")]
                    [Validation(Required=false)]
                    public int? Attempts { get; set; }

                    /// <summary>
                    /// <para>The timeout period for each retry. Example: <c>5s</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5s</para>
                    /// </summary>
                    [NameInMap("PerTryTimeout")]
                    [Validation(Required=false)]
                    public string PerTryTimeout { get; set; }

                    /// <summary>
                    /// <para>The condition for retries. Example: <c>connect-failure,refused-stream,503</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>connect-failure,refused-stream,503</para>
                    /// </summary>
                    [NameInMap("RetryOn")]
                    [Validation(Required=false)]
                    public string RetryOn { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to allow retries to other localities.</para>
                    /// </summary>
                    [NameInMap("RetryRemoteLocalities")]
                    [Validation(Required=false)]
                    public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsRetriesRetryRemoteLocalities RetryRemoteLocalities { get; set; }
                    public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsRetriesRetryRemoteLocalities : TeaModel {
                        /// <summary>
                        /// <para>Specifies whether to allow retries to other localities. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>true</c></description></item>
                        /// <item><description><c>false</c></description></item>
                        /// </list>
                        /// <para>Default value: <c>false</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public bool? Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The configurations for rewriting the virtual service.</para>
                /// </summary>
                [NameInMap("Rewrite")]
                [Validation(Required=false)]
                public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsRewrite Rewrite { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsRewrite : TeaModel {
                    /// <summary>
                    /// <para>The value to be used to overwrite the value of the Authority or Host header.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>newratings.default.svc.cluster.local</para>
                    /// </summary>
                    [NameInMap("Authority")]
                    [Validation(Required=false)]
                    public string Authority { get; set; }

                    /// <summary>
                    /// <para>The value to be used to overwrite the path or prefix of the URI.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/v1/getProductRatings</para>
                    /// </summary>
                    [NameInMap("Uri")]
                    [Validation(Required=false)]
                    public string Uri { get; set; }

                }

                /// <summary>
                /// <para>The timeout period for requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5s</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public string Timeout { get; set; }

            }

            /// <summary>
            /// <para>The matching rules for traffic routing.</para>
            /// </summary>
            [NameInMap("MatchRequest")]
            [Validation(Required=false)]
            public CreateIstioGatewayRoutesRequestGatewayRouteMatchRequest MatchRequest { get; set; }
            public class CreateIstioGatewayRoutesRequestGatewayRouteMatchRequest : TeaModel {
                /// <summary>
                /// <para>The request headers to be matched.</para>
                /// </summary>
                [NameInMap("Headers")]
                [Validation(Required=false)]
                public List<CreateIstioGatewayRoutesRequestGatewayRouteMatchRequestHeaders> Headers { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteMatchRequestHeaders : TeaModel {
                    /// <summary>
                    /// <para>The header value to be matched.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>v1</para>
                    /// </summary>
                    [NameInMap("MatchingContent")]
                    [Validation(Required=false)]
                    public string MatchingContent { get; set; }

                    /// <summary>
                    /// <para>The matching mode for the header value. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>exact</c>: exact match</description></item>
                    /// <item><description><c>prefix</c>: match by prefix</description></item>
                    /// <item><description><c>regex</c>: match by regular expression</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>exact</para>
                    /// </summary>
                    [NameInMap("MatchingMode")]
                    [Validation(Required=false)]
                    public string MatchingMode { get; set; }

                    /// <summary>
                    /// <para>The header key to be matched.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>x-request-id</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The ports of destination services for Layer 4 weighted routing.</para>
                /// </summary>
                [NameInMap("Ports")]
                [Validation(Required=false)]
                public List<int?> Ports { get; set; }

                /// <summary>
                /// <para>The matching rule for Transport Layer Security (TLS) traffic.</para>
                /// </summary>
                [NameInMap("TLSMatchAttributes")]
                [Validation(Required=false)]
                public List<CreateIstioGatewayRoutesRequestGatewayRouteMatchRequestTLSMatchAttributes> TLSMatchAttributes { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteMatchRequestTLSMatchAttributes : TeaModel {
                    /// <summary>
                    /// <para>The Server Name Indication (SNI) values to be matched.</para>
                    /// </summary>
                    [NameInMap("SNIHosts")]
                    [Validation(Required=false)]
                    public List<string> SNIHosts { get; set; }

                    /// <summary>
                    /// <para>The TLS port.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>443</para>
                    /// </summary>
                    [NameInMap("TLSPort")]
                    [Validation(Required=false)]
                    public int? TLSPort { get; set; }

                }

                /// <summary>
                /// <para>The matching rule for URIs.</para>
                /// </summary>
                [NameInMap("URI")]
                [Validation(Required=false)]
                public CreateIstioGatewayRoutesRequestGatewayRouteMatchRequestURI URI { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteMatchRequestURI : TeaModel {
                    /// <summary>
                    /// <para>The content to be matched.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/ratings/v2/</para>
                    /// </summary>
                    [NameInMap("MatchingContent")]
                    [Validation(Required=false)]
                    public string MatchingContent { get; set; }

                    /// <summary>
                    /// <para>The matching mode for the routing rule. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>exact</c>: exact match</description></item>
                    /// <item><description><c>prefix</c>: match by prefix</description></item>
                    /// <item><description><c>regex</c>: match by regular expression</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>prefix</para>
                    /// </summary>
                    [NameInMap("MatchingMode")]
                    [Validation(Required=false)]
                    public string MatchingMode { get; set; }

                }

            }

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
            /// <para>A JSON string. This parameter corresponds to the three routing types in virtual services and provides configuration entries for advanced features. The value of this parameter overwrites the configurations in RouteName, RouteType, MatchRequest, and HTTPAdvancedOptions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;http&quot;: {
            ///     &quot;route&quot;: [
            ///       {
            ///         &quot;destination&quot;: {
            ///           &quot;host&quot;: &quot;httpbin&quot;
            ///         }
            ///       }
            ///     ],
            ///     &quot;name&quot;: &quot;httpbin&quot;,
            ///     &quot;match&quot;: [
            ///       {
            ///         &quot;uri&quot;: {
            ///           &quot;prefix&quot;: &quot;/&quot;
            ///         }
            ///       }
            ///     ],
            ///     &quot;fault&quot;: {
            ///       &quot;delay&quot;: {
            ///         &quot;fixedDelay&quot;: &quot;2s&quot;,
            ///         &quot;percentage&quot;: {
            ///           &quot;value&quot;: 70
            ///         }
            ///       }
            ///     }
            ///   }
            /// }</para>
            /// </summary>
            [NameInMap("RawVSRoute")]
            [Validation(Required=false)]
            public object RawVSRoute { get; set; }

            /// <summary>
            /// <para>The endpoints of destination services for Layer 4 weighted routing.</para>
            /// </summary>
            [NameInMap("RouteDestinations")]
            [Validation(Required=false)]
            public List<CreateIstioGatewayRoutesRequestGatewayRouteRouteDestinations> RouteDestinations { get; set; }
            public class CreateIstioGatewayRoutesRequestGatewayRouteRouteDestinations : TeaModel {
                /// <summary>
                /// <para>The unique endpoint of the destination service to which the specified requests are sent.</para>
                /// </summary>
                [NameInMap("Destination")]
                [Validation(Required=false)]
                public CreateIstioGatewayRoutesRequestGatewayRouteRouteDestinationsDestination Destination { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteRouteDestinationsDestination : TeaModel {
                    /// <summary>
                    /// <para>The name of the service defined in the service registry.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>reviews</para>
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// <para>The port.</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public CreateIstioGatewayRoutesRequestGatewayRouteRouteDestinationsDestinationPort Port { get; set; }
                    public class CreateIstioGatewayRoutesRequestGatewayRouteRouteDestinationsDestinationPort : TeaModel {
                        /// <summary>
                        /// <para>The port number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>80</para>
                        /// </summary>
                        [NameInMap("Number")]
                        [Validation(Required=false)]
                        public int? Number { get; set; }

                    }

                    /// <summary>
                    /// <para>The name of the service subset.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>v1</para>
                    /// </summary>
                    [NameInMap("Subset")]
                    [Validation(Required=false)]
                    public string Subset { get; set; }

                }

                /// <summary>
                /// <para>The weight of the service subset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The name of the routing rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>reviews-v2-routes</para>
            /// </summary>
            [NameInMap("RouteName")]
            [Validation(Required=false)]
            public string RouteName { get; set; }

            /// <summary>
            /// <para>The type of the traffic to be routed. Valid values: <c>HTTP</c>, <c>TLS</c>, and <c>TCP</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("RouteType")]
            [Validation(Required=false)]
            public string RouteType { get; set; }

        }

        /// <summary>
        /// <para>The name of the ASM gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ingressgateway</para>
        /// </summary>
        [NameInMap("IstioGatewayName")]
        [Validation(Required=false)]
        public string IstioGatewayName { get; set; }

        /// <summary>
        /// <para>The priority of the routing rule. The value of this parameter is an integer. A smaller value indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The ASM instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c08ba3fd1e6484b0f8cc1ad8fe10d****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        /// <summary>
        /// <para>The status of the routing rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>0</c>: The routing rule is valid.</description></item>
        /// <item><description><c>1</c>: The routing rule is invalid.</description></item>
        /// <item><description><c>2</c>: An error occurs during the creation or update of the routing rule.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
