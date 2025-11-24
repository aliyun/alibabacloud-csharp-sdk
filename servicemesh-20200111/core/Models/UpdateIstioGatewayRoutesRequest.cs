// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpdateIstioGatewayRoutesRequest : TeaModel {
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
        /// <para>The information about the routing rule to be updated for the ASM gateway.</para>
        /// </summary>
        [NameInMap("GatewayRoute")]
        [Validation(Required=false)]
        public UpdateIstioGatewayRoutesRequestGatewayRoute GatewayRoute { get; set; }
        public class UpdateIstioGatewayRoutesRequestGatewayRoute : TeaModel {
            /// <summary>
            /// <para>The list of requested domain names.</para>
            /// </summary>
            [NameInMap("Domains")]
            [Validation(Required=false)]
            public List<string> Domains { get; set; }

            /// <summary>
            /// <para>The advanced settings for routing HTTP traffic.</para>
            /// </summary>
            [NameInMap("HTTPAdvancedOptions")]
            [Validation(Required=false)]
            public UpdateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptions HTTPAdvancedOptions { get; set; }
            public class UpdateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptions : TeaModel {
                /// <summary>
                /// <para>The virtual service that defines traffic routing.</para>
                /// </summary>
                [NameInMap("Delegate")]
                [Validation(Required=false)]
                public UpdateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsDelegate Delegate { get; set; }
                public class UpdateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsDelegate : TeaModel {
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
                public UpdateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFault Fault { get; set; }
                public class UpdateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFault : TeaModel {
                    /// <summary>
                    /// <para>The configurations for aborting requests with specified error codes.</para>
                    /// </summary>
                    [NameInMap("Abort")]
                    [Validation(Required=false)]
                    public UpdateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultAbort Abort { get; set; }
                    public class UpdateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultAbort : TeaModel {
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
                        public UpdateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultAbortPercentage Percentage { get; set; }
                        public class UpdateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultAbortPercentage : TeaModel {
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
                    public UpdateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultDelay Delay { get; set; }
                    public class UpdateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultDelay : TeaModel {
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
                        public UpdateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultDelayPercentage Percentage { get; set; }
                        public class UpdateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultDelayPercentage : TeaModel {
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
                public UpdateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsHTTPRedirect HTTPRedirect { get; set; }
                public class UpdateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsHTTPRedirect : TeaModel {
                    /// <summary>
                    /// <para>The value to be used to overwrite the value of the Authority or Host header during redirection.</para>
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
                public UpdateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsMirror Mirror { get; set; }
                public class UpdateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsMirror : TeaModel {
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
                public UpdateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsMirrorPercentage MirrorPercentage { get; set; }
                public class UpdateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsMirrorPercentage : TeaModel {
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
                public UpdateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsRetries Retries { get; set; }
                public class UpdateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsRetries : TeaModel {
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
                    /// <para>The timeout period for each retry.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2s</para>
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
                    public UpdateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsRetriesRetryRemoteLocalities RetryRemoteLocalities { get; set; }
                    public class UpdateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsRetriesRetryRemoteLocalities : TeaModel {
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
                public UpdateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsRewrite Rewrite { get; set; }
                public class UpdateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsRewrite : TeaModel {
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
            public UpdateIstioGatewayRoutesRequestGatewayRouteMatchRequest MatchRequest { get; set; }
            public class UpdateIstioGatewayRoutesRequestGatewayRouteMatchRequest : TeaModel {
                /// <summary>
                /// <para>The request headers to be matched.</para>
                /// </summary>
                [NameInMap("Headers")]
                [Validation(Required=false)]
                public List<UpdateIstioGatewayRoutesRequestGatewayRouteMatchRequestHeaders> Headers { get; set; }
                public class UpdateIstioGatewayRoutesRequestGatewayRouteMatchRequestHeaders : TeaModel {
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
                /// <para>The ports.</para>
                /// </summary>
                [NameInMap("Ports")]
                [Validation(Required=false)]
                public List<int?> Ports { get; set; }

                /// <summary>
                /// <para>The matching rule for Transport Layer Security (TLS) traffic.</para>
                /// </summary>
                [NameInMap("TLSMatchAttributes")]
                [Validation(Required=false)]
                public List<UpdateIstioGatewayRoutesRequestGatewayRouteMatchRequestTLSMatchAttributes> TLSMatchAttributes { get; set; }
                public class UpdateIstioGatewayRoutesRequestGatewayRouteMatchRequestTLSMatchAttributes : TeaModel {
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
                public UpdateIstioGatewayRoutesRequestGatewayRouteMatchRequestURI URI { get; set; }
                public class UpdateIstioGatewayRoutesRequestGatewayRouteMatchRequestURI : TeaModel {
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
            /// <para>The original YAML file of the virtual service that is serialized in a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("RawVSRoute")]
            [Validation(Required=false)]
            public object RawVSRoute { get; set; }

            /// <summary>
            /// <para>The endpoints of destination services for Layer 4 weighted routing.</para>
            /// </summary>
            [NameInMap("RouteDestinations")]
            [Validation(Required=false)]
            public List<UpdateIstioGatewayRoutesRequestGatewayRouteRouteDestinations> RouteDestinations { get; set; }
            public class UpdateIstioGatewayRoutesRequestGatewayRouteRouteDestinations : TeaModel {
                /// <summary>
                /// <para>The unique endpoint of the destination service to which the specified requests are sent.</para>
                /// </summary>
                [NameInMap("Destination")]
                [Validation(Required=false)]
                public UpdateIstioGatewayRoutesRequestGatewayRouteRouteDestinationsDestination Destination { get; set; }
                public class UpdateIstioGatewayRoutesRequestGatewayRouteRouteDestinationsDestination : TeaModel {
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
                    /// <para>The port of the destination service.</para>
                    /// <remarks>
                    /// <para> If the destination service of the route has only one port, this field can be left empty. If the destination service has multiple ports, you must specify the port number.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public UpdateIstioGatewayRoutesRequestGatewayRouteRouteDestinationsDestinationPort Port { get; set; }
                    public class UpdateIstioGatewayRoutesRequestGatewayRouteRouteDestinationsDestinationPort : TeaModel {
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
