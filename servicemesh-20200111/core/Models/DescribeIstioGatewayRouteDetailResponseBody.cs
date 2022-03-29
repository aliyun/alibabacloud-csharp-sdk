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

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RouteDetail")]
        [Validation(Required=false)]
        public DescribeIstioGatewayRouteDetailResponseBodyRouteDetail RouteDetail { get; set; }
        public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetail : TeaModel {
            [NameInMap("HTTPAdvancedOptions")]
            [Validation(Required=false)]
            public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptions HTTPAdvancedOptions { get; set; }
            public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptions : TeaModel {
                [NameInMap("Delegate")]
                [Validation(Required=false)]
                public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsDelegate Delegate { get; set; }
                public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsDelegate : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }
                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }
                };

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
                        };

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
                        };

                    }
                };

                [NameInMap("HTTPRedirect")]
                [Validation(Required=false)]
                public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsHTTPRedirect HTTPRedirect { get; set; }
                public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsHTTPRedirect : TeaModel {
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
                public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsMirror Mirror { get; set; }
                public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsMirror : TeaModel {
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }
                    [NameInMap("Subset")]
                    [Validation(Required=false)]
                    public string Subset { get; set; }
                };

                [NameInMap("MirrorPercentage")]
                [Validation(Required=false)]
                public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsMirrorPercentage MirrorPercentage { get; set; }
                public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsMirrorPercentage : TeaModel {
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }
                };

                [NameInMap("Retries")]
                [Validation(Required=false)]
                public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsRetries Retries { get; set; }
                public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsRetries : TeaModel {
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
                    public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsRetriesRetryRemoteLocalities RetryRemoteLocalities { get; set; }
                    public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsRetriesRetryRemoteLocalities : TeaModel {
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public bool? Value { get; set; }

                    }
                };

                [NameInMap("Rewrite")]
                [Validation(Required=false)]
                public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsRewrite Rewrite { get; set; }
                public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailHTTPAdvancedOptionsRewrite : TeaModel {
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
            public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailMatchRequest MatchRequest { get; set; }
            public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailMatchRequest : TeaModel {
                [NameInMap("Headers")]
                [Validation(Required=false)]
                public List<DescribeIstioGatewayRouteDetailResponseBodyRouteDetailMatchRequestHeaders> Headers { get; set; }
                public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailMatchRequestHeaders : TeaModel {
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
                public List<DescribeIstioGatewayRouteDetailResponseBodyRouteDetailMatchRequestTLSMatchAttributes> TLSMatchAttributes { get; set; }
                public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailMatchRequestTLSMatchAttributes : TeaModel {
                    [NameInMap("SNIHosts")]
                    [Validation(Required=false)]
                    public List<string> SNIHosts { get; set; }

                    [NameInMap("TLSPort")]
                    [Validation(Required=false)]
                    public int? TLSPort { get; set; }

                }

                [NameInMap("URI")]
                [Validation(Required=false)]
                public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailMatchRequestURI URI { get; set; }
                public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailMatchRequestURI : TeaModel {
                    [NameInMap("MatchingContent")]
                    [Validation(Required=false)]
                    public string MatchingContent { get; set; }
                    [NameInMap("MatchingMode")]
                    [Validation(Required=false)]
                    public string MatchingMode { get; set; }
                };

            }
            [NameInMap("RouteDestinations")]
            [Validation(Required=false)]
            public List<DescribeIstioGatewayRouteDetailResponseBodyRouteDetailRouteDestinations> RouteDestinations { get; set; }
            public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailRouteDestinations : TeaModel {
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
                    };

                    [NameInMap("Subset")]
                    [Validation(Required=false)]
                    public string Subset { get; set; }

                }
                public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailRouteDestinationsHeaders Headers { get; set; }
                public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailRouteDestinationsHeaders : TeaModel {
                    [NameInMap("Request")]
                    [Validation(Required=false)]
                    public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailRouteDestinationsHeadersRequest Request { get; set; }
                    public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailRouteDestinationsHeadersRequest : TeaModel {
                        [NameInMap("Add")]
                        [Validation(Required=false)]
                        public Dictionary<string, string> Add { get; set; }
                        [NameInMap("Remove")]
                        [Validation(Required=false)]
                        public List<string> Remove { get; set; }
                        [NameInMap("Set")]
                        [Validation(Required=false)]
                        public Dictionary<string, string> Set { get; set; }
                    };

                    [NameInMap("Response")]
                    [Validation(Required=false)]
                    public DescribeIstioGatewayRouteDetailResponseBodyRouteDetailRouteDestinationsHeadersResponse Response { get; set; }
                    public class DescribeIstioGatewayRouteDetailResponseBodyRouteDetailRouteDestinationsHeadersResponse : TeaModel {
                        [NameInMap("Add")]
                        [Validation(Required=false)]
                        public Dictionary<string, string> Add { get; set; }
                        [NameInMap("Remove")]
                        [Validation(Required=false)]
                        public List<string> Remove { get; set; }
                        [NameInMap("Set")]
                        [Validation(Required=false)]
                        public Dictionary<string, string> Set { get; set; }
                    };

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

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
