// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class CreateIstioGatewayRoutesRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("GatewayRoute")]
        [Validation(Required=false)]
        public CreateIstioGatewayRoutesRequestGatewayRoute GatewayRoute { get; set; }
        public class CreateIstioGatewayRoutesRequestGatewayRoute : TeaModel {
            [NameInMap("HTTPAdvancedOptions")]
            [Validation(Required=false)]
            public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptions HTTPAdvancedOptions { get; set; }
            public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptions : TeaModel {
                [NameInMap("Delegate")]
                [Validation(Required=false)]
                public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsDelegate Delegate { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsDelegate : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }
                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }
                };

                [NameInMap("Fault")]
                [Validation(Required=false)]
                public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFault Fault { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFault : TeaModel {
                    [NameInMap("Abort")]
                    [Validation(Required=false)]
                    public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultAbort Abort { get; set; }
                    public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultAbort : TeaModel {
                        [NameInMap("HttpStatus")]
                        [Validation(Required=false)]
                        public int? HttpStatus { get; set; }

                        [NameInMap("Percentage")]
                        [Validation(Required=false)]
                        public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultAbortPercentage Percentage { get; set; }
                        public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultAbortPercentage : TeaModel {
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public float? Value { get; set; }
                        };

                    }
                    [NameInMap("Delay")]
                    [Validation(Required=false)]
                    public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultDelay Delay { get; set; }
                    public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultDelay : TeaModel {
                        [NameInMap("FixedDelay")]
                        [Validation(Required=false)]
                        public string FixedDelay { get; set; }

                        [NameInMap("Percentage")]
                        [Validation(Required=false)]
                        public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultDelayPercentage Percentage { get; set; }
                        public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsFaultDelayPercentage : TeaModel {
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public float? Value { get; set; }
                        };

                    }
                };

                [NameInMap("HTTPRedirect")]
                [Validation(Required=false)]
                public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsHTTPRedirect HTTPRedirect { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsHTTPRedirect : TeaModel {
                    [NameInMap("Authority")]
                    [Validation(Required=false)]
                    public string Authority { get; set; }
                    [NameInMap("RedirectCode")]
                    [Validation(Required=false)]
                    public int? RedirectCode { get; set; }
                    [NameInMap("Uri")]
                    [Validation(Required=false)]
                    public string Uri { get; set; }
                };

                [NameInMap("Mirror")]
                [Validation(Required=false)]
                public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsMirror Mirror { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsMirror : TeaModel {
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }
                    [NameInMap("Subset")]
                    [Validation(Required=false)]
                    public string Subset { get; set; }
                };

                [NameInMap("MirrorPercentage")]
                [Validation(Required=false)]
                public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsMirrorPercentage MirrorPercentage { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsMirrorPercentage : TeaModel {
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }
                };

                [NameInMap("Retries")]
                [Validation(Required=false)]
                public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsRetries Retries { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsRetries : TeaModel {
                    [NameInMap("Attempts")]
                    [Validation(Required=false)]
                    public int? Attempts { get; set; }
                    [NameInMap("PerTryTimeout")]
                    [Validation(Required=false)]
                    public string PerTryTimeout { get; set; }
                    [NameInMap("RetryOn")]
                    [Validation(Required=false)]
                    public string RetryOn { get; set; }
                    [NameInMap("RetryRemoteLocalities")]
                    [Validation(Required=false)]
                    public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsRetriesRetryRemoteLocalities RetryRemoteLocalities { get; set; }
                    public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsRetriesRetryRemoteLocalities : TeaModel {
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public bool? Value { get; set; }

                    }
                };

                [NameInMap("Rewrite")]
                [Validation(Required=false)]
                public CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsRewrite Rewrite { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteHTTPAdvancedOptionsRewrite : TeaModel {
                    [NameInMap("Authority")]
                    [Validation(Required=false)]
                    public string Authority { get; set; }
                    [NameInMap("Uri")]
                    [Validation(Required=false)]
                    public string Uri { get; set; }
                };

                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public string Timeout { get; set; }

            }
            [NameInMap("MatchRequest")]
            [Validation(Required=false)]
            public CreateIstioGatewayRoutesRequestGatewayRouteMatchRequest MatchRequest { get; set; }
            public class CreateIstioGatewayRoutesRequestGatewayRouteMatchRequest : TeaModel {
                [NameInMap("Headers")]
                [Validation(Required=false)]
                public List<CreateIstioGatewayRoutesRequestGatewayRouteMatchRequestHeaders> Headers { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteMatchRequestHeaders : TeaModel {
                    [NameInMap("MatchingContent")]
                    [Validation(Required=false)]
                    public string MatchingContent { get; set; }

                    [NameInMap("MatchingMode")]
                    [Validation(Required=false)]
                    public string MatchingMode { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("Ports")]
                [Validation(Required=false)]
                public List<int?> Ports { get; set; }

                [NameInMap("TLSMatchAttributes")]
                [Validation(Required=false)]
                public List<CreateIstioGatewayRoutesRequestGatewayRouteMatchRequestTLSMatchAttributes> TLSMatchAttributes { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteMatchRequestTLSMatchAttributes : TeaModel {
                    [NameInMap("SNIHosts")]
                    [Validation(Required=false)]
                    public List<string> SNIHosts { get; set; }

                    [NameInMap("TLSPort")]
                    [Validation(Required=false)]
                    public int? TLSPort { get; set; }

                }

                [NameInMap("URI")]
                [Validation(Required=false)]
                public CreateIstioGatewayRoutesRequestGatewayRouteMatchRequestURI URI { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteMatchRequestURI : TeaModel {
                    [NameInMap("MatchingContent")]
                    [Validation(Required=false)]
                    public string MatchingContent { get; set; }
                    [NameInMap("MatchingMode")]
                    [Validation(Required=false)]
                    public string MatchingMode { get; set; }
                };

            }
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }
            [NameInMap("RouteDestinations")]
            [Validation(Required=false)]
            public List<CreateIstioGatewayRoutesRequestGatewayRouteRouteDestinations> RouteDestinations { get; set; }
            public class CreateIstioGatewayRoutesRequestGatewayRouteRouteDestinations : TeaModel {
                public CreateIstioGatewayRoutesRequestGatewayRouteRouteDestinationsDestination Destination { get; set; }
                public class CreateIstioGatewayRoutesRequestGatewayRouteRouteDestinationsDestination : TeaModel {
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    [NameInMap("Subset")]
                    [Validation(Required=false)]
                    public string Subset { get; set; }

                }
                public int? Weight { get; set; }
            }
            [NameInMap("RouteName")]
            [Validation(Required=false)]
            public string RouteName { get; set; }
            [NameInMap("RouteType")]
            [Validation(Required=false)]
            public string RouteType { get; set; }
        };

        [NameInMap("IstioGatewayName")]
        [Validation(Required=false)]
        public string IstioGatewayName { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
