// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewayServiceResponseBody : TeaModel {
        /// <summary>
        /// The return value.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListGatewayServiceResponseBodyData Data { get; set; }
        public class ListGatewayServiceResponseBodyData : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page. Default value: 10.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The returned information.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListGatewayServiceResponseBodyDataResult> Result { get; set; }
            public class ListGatewayServiceResponseBodyDataResult : TeaModel {
                /// <summary>
                /// The ID of the gateway.
                /// </summary>
                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public long? GatewayId { get; set; }

                /// <summary>
                /// The traffic management policy.
                /// </summary>
                [NameInMap("GatewayTrafficPolicy")]
                [Validation(Required=false)]
                public ListGatewayServiceResponseBodyDataResultGatewayTrafficPolicy GatewayTrafficPolicy { get; set; }
                public class ListGatewayServiceResponseBodyDataResultGatewayTrafficPolicy : TeaModel {
                    /// <summary>
                    /// The load balancing settings.
                    /// </summary>
                    [NameInMap("LoadBalancerSettings")]
                    [Validation(Required=false)]
                    public ListGatewayServiceResponseBodyDataResultGatewayTrafficPolicyLoadBalancerSettings LoadBalancerSettings { get; set; }
                    public class ListGatewayServiceResponseBodyDataResultGatewayTrafficPolicyLoadBalancerSettings : TeaModel {
                        /// <summary>
                        /// The consistent hashing settings.
                        /// </summary>
                        [NameInMap("ConsistentHashLBConfig")]
                        [Validation(Required=false)]
                        public ListGatewayServiceResponseBodyDataResultGatewayTrafficPolicyLoadBalancerSettingsConsistentHashLBConfig ConsistentHashLBConfig { get; set; }
                        public class ListGatewayServiceResponseBodyDataResultGatewayTrafficPolicyLoadBalancerSettingsConsistentHashLBConfig : TeaModel {
                            /// <summary>
                            /// The type based on which consistent hashing load balancing is performed.
                            /// 
                            /// *   HEADER
                            /// *   COOKIE
                            /// *   SOURCE_IP
                            /// *   QUERY_PARAMETER
                            /// </summary>
                            [NameInMap("ConsistentHashLBType")]
                            [Validation(Required=false)]
                            public string ConsistentHashLBType { get; set; }

                            /// <summary>
                            /// The cookie-based load balancing parameters.
                            /// </summary>
                            [NameInMap("HttpCookie")]
                            [Validation(Required=false)]
                            public ListGatewayServiceResponseBodyDataResultGatewayTrafficPolicyLoadBalancerSettingsConsistentHashLBConfigHttpCookie HttpCookie { get; set; }
                            public class ListGatewayServiceResponseBodyDataResultGatewayTrafficPolicyLoadBalancerSettingsConsistentHashLBConfigHttpCookie : TeaModel {
                                /// <summary>
                                /// The name of the cookie.
                                /// </summary>
                                [NameInMap("Name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                                /// <summary>
                                /// The path of the cookie.
                                /// </summary>
                                [NameInMap("Path")]
                                [Validation(Required=false)]
                                public string Path { get; set; }

                                /// <summary>
                                /// The lifecycle of the cookie.
                                /// </summary>
                                [NameInMap("Ttl")]
                                [Validation(Required=false)]
                                public string Ttl { get; set; }

                            }

                            /// <summary>
                            /// The minimum value of the hash ring.
                            /// </summary>
                            [NameInMap("MinimumRingSize")]
                            [Validation(Required=false)]
                            public long? MinimumRingSize { get; set; }

                            /// <summary>
                            /// The name of the parameter.
                            /// </summary>
                            [NameInMap("ParameterName")]
                            [Validation(Required=false)]
                            public string ParameterName { get; set; }

                        }

                        /// <summary>
                        /// The load balancing type.
                        /// 
                        /// *   ROUND_ROBIN
                        /// *   LEAST_CONN
                        /// *   RANDOM
                        /// *   CONSISTENT_HASH
                        /// </summary>
                        [NameInMap("LoadbalancerType")]
                        [Validation(Required=false)]
                        public string LoadbalancerType { get; set; }

                        /// <summary>
                        /// The prefetch time of the least connection load balancing.
                        /// </summary>
                        [NameInMap("WarmupDuration")]
                        [Validation(Required=false)]
                        public int? WarmupDuration { get; set; }

                    }

                    /// <summary>
                    /// The Transport Layer Security (TLS).
                    /// </summary>
                    [NameInMap("Tls")]
                    [Validation(Required=false)]
                    public ListGatewayServiceResponseBodyDataResultGatewayTrafficPolicyTls Tls { get; set; }
                    public class ListGatewayServiceResponseBodyDataResultGatewayTrafficPolicyTls : TeaModel {
                        /// <summary>
                        /// The public key of the CA certificate .
                        /// </summary>
                        [NameInMap("CaCertContent")]
                        [Validation(Required=false)]
                        public string CaCertContent { get; set; }

                        /// <summary>
                        /// The ID of the certification authority (CA) certificate.
                        /// </summary>
                        [NameInMap("CaCertId")]
                        [Validation(Required=false)]
                        public string CaCertId { get; set; }

                        /// <summary>
                        /// The ID of the certificate.
                        /// </summary>
                        [NameInMap("CertId")]
                        [Validation(Required=false)]
                        public string CertId { get; set; }

                        /// <summary>
                        /// The TLS mode.
                        /// 
                        /// *   DISABLE
                        /// *   SIMPLE
                        /// *   MUTUAL
                        /// *   ISTIO_MUTUAL
                        /// </summary>
                        [NameInMap("Mode")]
                        [Validation(Required=false)]
                        public string Mode { get; set; }

                        /// <summary>
                        /// The Server Name Indication (SNI) value.
                        /// </summary>
                        [NameInMap("Sni")]
                        [Validation(Required=false)]
                        public string Sni { get; set; }

                        /// <summary>
                        /// The array of subject aliases.
                        /// </summary>
                        [NameInMap("SubjectAltNames")]
                        [Validation(Required=false)]
                        public List<string> SubjectAltNames { get; set; }

                    }

                }

                /// <summary>
                /// The unique ID of the gateway.
                /// </summary>
                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                /// <summary>
                /// The time when the service was created.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The time when the service was last modified.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The group.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// The health status.
                /// 
                /// *   Health
                /// *   Unhealthy
                /// *   Unknown
                /// </summary>
                [NameInMap("HealehStatus")]
                [Validation(Required=false)]
                public string HealehStatus { get; set; }

                /// <summary>
                /// Indicates whether health checks are performed.
                /// </summary>
                [NameInMap("HealthCheck")]
                [Validation(Required=false)]
                public bool? HealthCheck { get; set; }

                /// <summary>
                /// The information about health checks.
                /// </summary>
                [NameInMap("HealthCheckInfo")]
                [Validation(Required=false)]
                public ListGatewayServiceResponseBodyDataResultHealthCheckInfo HealthCheckInfo { get; set; }
                public class ListGatewayServiceResponseBodyDataResultHealthCheckInfo : TeaModel {
                    /// <summary>
                    /// Indicates whether checks are performed.
                    /// </summary>
                    [NameInMap("Check")]
                    [Validation(Required=false)]
                    public bool? Check { get; set; }

                    /// <summary>
                    /// The expected status of the health check.
                    /// </summary>
                    [NameInMap("ExpectedStatuses")]
                    [Validation(Required=false)]
                    public List<int?> ExpectedStatuses { get; set; }

                    /// <summary>
                    /// The threshold for healthy instances.
                    /// </summary>
                    [NameInMap("HealthyThreshold")]
                    [Validation(Required=false)]
                    public int? HealthyThreshold { get; set; }

                    /// <summary>
                    /// The URL of the HTTP request for the health check.
                    /// </summary>
                    [NameInMap("HttpHost")]
                    [Validation(Required=false)]
                    public string HttpHost { get; set; }

                    /// <summary>
                    /// The path to which the HTTP request for the health check is sent.
                    /// </summary>
                    [NameInMap("HttpPath")]
                    [Validation(Required=false)]
                    public string HttpPath { get; set; }

                    /// <summary>
                    /// The health check interval.
                    /// </summary>
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public int? Interval { get; set; }

                    /// <summary>
                    /// The network protocol.
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// The timeout period.
                    /// </summary>
                    [NameInMap("Timeout")]
                    [Validation(Required=false)]
                    public int? Timeout { get; set; }

                    /// <summary>
                    /// The threshold for unhealthy instances.
                    /// </summary>
                    [NameInMap("UnhealthyThreshold")]
                    [Validation(Required=false)]
                    public int? UnhealthyThreshold { get; set; }

                }

                /// <summary>
                /// The health status.
                /// 
                /// *   Health
                /// *   Unhealthy
                /// *   Unknown
                /// </summary>
                [NameInMap("HealthStatus")]
                [Validation(Required=false)]
                public string HealthStatus { get; set; }

                /// <summary>
                /// The ID.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The IP addresses of the service.
                /// </summary>
                [NameInMap("Ips")]
                [Validation(Required=false)]
                public List<string> Ips { get; set; }

                /// <summary>
                /// The metadata or IP addresses of the service.
                /// </summary>
                [NameInMap("MetaInfo")]
                [Validation(Required=false)]
                public string MetaInfo { get; set; }

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
                /// The port array.
                /// </summary>
                [NameInMap("Ports")]
                [Validation(Required=false)]
                public List<int?> Ports { get; set; }

                /// <summary>
                /// The name of the service registered with the service registry.
                /// </summary>
                [NameInMap("ServiceNameInRegistry")]
                [Validation(Required=false)]
                public string ServiceNameInRegistry { get; set; }

                /// <summary>
                /// The service port.
                /// </summary>
                [NameInMap("ServicePort")]
                [Validation(Required=false)]
                public long? ServicePort { get; set; }

                /// <summary>
                /// The protocol of the service.
                /// </summary>
                [NameInMap("ServiceProtocol")]
                [Validation(Required=false)]
                public string ServiceProtocol { get; set; }

                /// <summary>
                /// The ID of the service source.
                /// </summary>
                [NameInMap("SourceId")]
                [Validation(Required=false)]
                public long? SourceId { get; set; }

                /// <summary>
                /// The type of the service source.
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// The array of unhealthy endpoints.
                /// </summary>
                [NameInMap("UnhealthyEndpoints")]
                [Validation(Required=false)]
                public List<string> UnhealthyEndpoints { get; set; }

                /// <summary>
                /// The version of the service.
                /// </summary>
                [NameInMap("Versions")]
                [Validation(Required=false)]
                public List<ListGatewayServiceResponseBodyDataResultVersions> Versions { get; set; }
                public class ListGatewayServiceResponseBodyDataResultVersions : TeaModel {
                    /// <summary>
                    /// The version number.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The error message.
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
