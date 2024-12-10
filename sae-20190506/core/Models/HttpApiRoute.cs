// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class HttpApiRoute : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>intranet/internet</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Deploying/NotDeployed/Undeploying/Deployed</para>
        /// </summary>
        [NameInMap("DeployStatus")]
        [Validation(Required=false)]
        public string DeployStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Single/Multiple/VersionOriented</para>
        /// </summary>
        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public string DestinationType { get; set; }

        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<HttpApiRouteDomains> Domains { get; set; }
        public class HttpApiRouteDomains : TeaModel {
            [NameInMap("DomainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

        }

        [NameInMap("EnvironmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        [NameInMap("HttpApiId")]
        [Validation(Required=false)]
        public string HttpApiId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Http</para>
        /// </summary>
        [NameInMap("HttpApiName")]
        [Validation(Required=false)]
        public string HttpApiName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Http</para>
        /// </summary>
        [NameInMap("HttpApiType")]
        [Validation(Required=false)]
        public string HttpApiType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IngressId")]
        [Validation(Required=false)]
        public long? IngressId { get; set; }

        [NameInMap("NacosInstanceId")]
        [Validation(Required=false)]
        public string NacosInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("NacosNamespaceId")]
        [Validation(Required=false)]
        public string NacosNamespaceId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        [NameInMap("Policies")]
        [Validation(Required=false)]
        public HttpApiRoutePolicies Policies { get; set; }
        public class HttpApiRoutePolicies : TeaModel {
            [NameInMap("Fallback")]
            [Validation(Required=false)]
            public HttpApiRoutePoliciesFallback Fallback { get; set; }
            public class HttpApiRoutePoliciesFallback : TeaModel {
                [NameInMap("Destinations")]
                [Validation(Required=false)]
                public List<HttpApiRoutePoliciesFallbackDestinations> Destinations { get; set; }
                public class HttpApiRoutePoliciesFallbackDestinations : TeaModel {
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                    [NameInMap("ServiceId")]
                    [Validation(Required=false)]
                    public string ServiceId { get; set; }

                    [NameInMap("ServiceName")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

                    [NameInMap("ServicePort")]
                    [Validation(Required=false)]
                    public long? ServicePort { get; set; }

                    [NameInMap("ServiceProtocol")]
                    [Validation(Required=false)]
                    public string ServiceProtocol { get; set; }

                }

                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

            }

            [NameInMap("Retry")]
            [Validation(Required=false)]
            public HttpApiRoutePoliciesRetry Retry { get; set; }
            public class HttpApiRoutePoliciesRetry : TeaModel {
                [NameInMap("Attempts")]
                [Validation(Required=false)]
                public long? Attempts { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true/false</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                [NameInMap("HttpCodes")]
                [Validation(Required=false)]
                public List<string> HttpCodes { get; set; }

                [NameInMap("RetryOn")]
                [Validation(Required=false)]
                public List<string> RetryOn { get; set; }

            }

            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public HttpApiRoutePoliciesTimeout Timeout { get; set; }
            public class HttpApiRoutePoliciesTimeout : TeaModel {
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>s</para>
                /// </summary>
                [NameInMap("TimeUnit")]
                [Validation(Required=false)]
                public string TimeUnit { get; set; }

                [NameInMap("UnitNum")]
                [Validation(Required=false)]
                public long? UnitNum { get; set; }

            }

        }

        [NameInMap("Predicates")]
        [Validation(Required=false)]
        public HttpApiRoutePredicates Predicates { get; set; }
        public class HttpApiRoutePredicates : TeaModel {
            [NameInMap("HeaderPredicates")]
            [Validation(Required=false)]
            public List<HttpApiRoutePredicatesHeaderPredicates> HeaderPredicates { get; set; }
            public class HttpApiRoutePredicatesHeaderPredicates : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Prefix/Exact/Regex</para>
                /// </summary>
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
            public HttpApiRoutePredicatesPathPredicates PathPredicates { get; set; }
            public class HttpApiRoutePredicatesPathPredicates : TeaModel {
                [NameInMap("IgnoreCase")]
                [Validation(Required=false)]
                public bool? IgnoreCase { get; set; }

                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Prefix/Exact/Regex</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("QueryPredicates")]
            [Validation(Required=false)]
            public List<HttpApiRoutePredicatesQueryPredicates> QueryPredicates { get; set; }
            public class HttpApiRoutePredicatesQueryPredicates : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Prefix/Exact/Regex</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("RouteId")]
        [Validation(Required=false)]
        public string RouteId { get; set; }

        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<HttpApiRouteServices> Services { get; set; }
        public class HttpApiRouteServices : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("ServicePort")]
            [Validation(Required=false)]
            public long? ServicePort { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("ServiceProtocol")]
            [Validation(Required=false)]
            public string ServiceProtocol { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("ServiceWeight")]
            [Validation(Required=false)]
            public long? ServiceWeight { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SAE_NACOS/SAE_K8S_SERVICE/MSE_NACOS</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
