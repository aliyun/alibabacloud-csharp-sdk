// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewayServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The return value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListGatewayServiceResponseBodyData Data { get; set; }
        public class ListGatewayServiceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The maximum number of records per page. Default value: 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The returned collection.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListGatewayServiceResponseBodyDataResult> Result { get; set; }
            public class ListGatewayServiceResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The DNS server list (for DNS domain name service only).</para>
                /// </summary>
                [NameInMap("DnsServerList")]
                [Validation(Required=false)]
                public List<string> DnsServerList { get; set; }

                /// <summary>
                /// <para>The gateway ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public long? GatewayId { get; set; }

                /// <summary>
                /// <para>The traffic management policy.</para>
                /// </summary>
                [NameInMap("GatewayTrafficPolicy")]
                [Validation(Required=false)]
                public ListGatewayServiceResponseBodyDataResultGatewayTrafficPolicy GatewayTrafficPolicy { get; set; }
                public class ListGatewayServiceResponseBodyDataResultGatewayTrafficPolicy : TeaModel {
                    /// <summary>
                    /// <para>The load balancing settings.</para>
                    /// </summary>
                    [NameInMap("LoadBalancerSettings")]
                    [Validation(Required=false)]
                    public ListGatewayServiceResponseBodyDataResultGatewayTrafficPolicyLoadBalancerSettings LoadBalancerSettings { get; set; }
                    public class ListGatewayServiceResponseBodyDataResultGatewayTrafficPolicyLoadBalancerSettings : TeaModel {
                        /// <summary>
                        /// <para>The consistent hashing configuration.</para>
                        /// </summary>
                        [NameInMap("ConsistentHashLBConfig")]
                        [Validation(Required=false)]
                        public ListGatewayServiceResponseBodyDataResultGatewayTrafficPolicyLoadBalancerSettingsConsistentHashLBConfig ConsistentHashLBConfig { get; set; }
                        public class ListGatewayServiceResponseBodyDataResultGatewayTrafficPolicyLoadBalancerSettingsConsistentHashLBConfig : TeaModel {
                            /// <summary>
                            /// <para>The consistent hashing method. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><para>HEADER</para>
                            /// </description></item>
                            /// <item><description><para>COOKIE</para>
                            /// </description></item>
                            /// <item><description><para>SOURCE_IP</para>
                            /// </description></item>
                            /// <item><description><para>QUERY_PARAMETER</para>
                            /// </description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>HEADER</para>
                            /// </summary>
                            [NameInMap("ConsistentHashLBType")]
                            [Validation(Required=false)]
                            public string ConsistentHashLBType { get; set; }

                            /// <summary>
                            /// <para>The cookie-based parameter.</para>
                            /// </summary>
                            [NameInMap("HttpCookie")]
                            [Validation(Required=false)]
                            public ListGatewayServiceResponseBodyDataResultGatewayTrafficPolicyLoadBalancerSettingsConsistentHashLBConfigHttpCookie HttpCookie { get; set; }
                            public class ListGatewayServiceResponseBodyDataResultGatewayTrafficPolicyLoadBalancerSettingsConsistentHashLBConfigHttpCookie : TeaModel {
                                /// <summary>
                                /// <para>The cookie name.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>name</para>
                                /// </summary>
                                [NameInMap("Name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                                /// <summary>
                                /// <para>The cookie path.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>/path</para>
                                /// </summary>
                                [NameInMap("Path")]
                                [Validation(Required=false)]
                                public string Path { get; set; }

                                /// <summary>
                                /// <para>The time-to-live (TTL) of the cookie.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>360</para>
                                /// </summary>
                                [NameInMap("Ttl")]
                                [Validation(Required=false)]
                                public string Ttl { get; set; }

                            }

                            /// <summary>
                            /// <para>The minimum size of the hash ring.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10000</para>
                            /// </summary>
                            [NameInMap("MinimumRingSize")]
                            [Validation(Required=false)]
                            public long? MinimumRingSize { get; set; }

                            /// <summary>
                            /// <para>The parameter name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>param</para>
                            /// </summary>
                            [NameInMap("ParameterName")]
                            [Validation(Required=false)]
                            public string ParameterName { get; set; }

                        }

                        /// <summary>
                        /// <para>The load balancing policy. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para>ROUND_ROBIN</para>
                        /// </description></item>
                        /// <item><description><para>LEAST_CONN</para>
                        /// </description></item>
                        /// <item><description><para>RANDOM</para>
                        /// </description></item>
                        /// <item><description><para>CONSISTENT_HASH</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>RANDOM</para>
                        /// </summary>
                        [NameInMap("LoadbalancerType")]
                        [Validation(Required=false)]
                        public string LoadbalancerType { get; set; }

                        /// <summary>
                        /// <para>The warm-up duration for the minimum number of requests.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("WarmupDuration")]
                        [Validation(Required=false)]
                        public int? WarmupDuration { get; set; }

                    }

                    /// <summary>
                    /// <para>The TLS.</para>
                    /// </summary>
                    [NameInMap("Tls")]
                    [Validation(Required=false)]
                    public ListGatewayServiceResponseBodyDataResultGatewayTrafficPolicyTls Tls { get; set; }
                    public class ListGatewayServiceResponseBodyDataResultGatewayTrafficPolicyTls : TeaModel {
                        /// <summary>
                        /// <para>The public key of the CA certificate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>content</para>
                        /// </summary>
                        [NameInMap("CaCertContent")]
                        [Validation(Required=false)]
                        public string CaCertContent { get; set; }

                        /// <summary>
                        /// <para>The CA certificate ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5******-cn-hangzhou</para>
                        /// </summary>
                        [NameInMap("CaCertId")]
                        [Validation(Required=false)]
                        public string CaCertId { get; set; }

                        /// <summary>
                        /// <para>The certificate ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5******-cn-hangzhou</para>
                        /// </summary>
                        [NameInMap("CertId")]
                        [Validation(Required=false)]
                        public string CertId { get; set; }

                        /// <summary>
                        /// <para>The TLS mode. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para>DISABLE</para>
                        /// </description></item>
                        /// <item><description><para>SIMPLE</para>
                        /// </description></item>
                        /// <item><description><para>MUTUAL</para>
                        /// </description></item>
                        /// <item><description><para>ISTIO_MUTUAL</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SIMPLE</para>
                        /// </summary>
                        [NameInMap("Mode")]
                        [Validation(Required=false)]
                        public string Mode { get; set; }

                        /// <summary>
                        /// <para>The service name identity.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>name-sni</para>
                        /// </summary>
                        [NameInMap("Sni")]
                        [Validation(Required=false)]
                        public string Sni { get; set; }

                        /// <summary>
                        /// <para>The array of subject alternative names.</para>
                        /// </summary>
                        [NameInMap("SubjectAltNames")]
                        [Validation(Required=false)]
                        public List<string> SubjectAltNames { get; set; }

                    }

                }

                /// <summary>
                /// <para>The unique ID of the gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-5017305290e14centbrveca****</para>
                /// </summary>
                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                /// <summary>
                /// <para>The time when the record was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-07 18:07:57</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the record was modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-07 18:07:57</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The health status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Health</para>
                /// </description></item>
                /// <item><description><para>Unhealthy</para>
                /// </description></item>
                /// <item><description><para>Unknown</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Unhealthy</para>
                /// </summary>
                [NameInMap("HealehStatus")]
                [Validation(Required=false)]
                public string HealehStatus { get; set; }

                /// <summary>
                /// <para>Indicates whether health checks are performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HealthCheck")]
                [Validation(Required=false)]
                public bool? HealthCheck { get; set; }

                /// <summary>
                /// <para>The health check information.</para>
                /// </summary>
                [NameInMap("HealthCheckInfo")]
                [Validation(Required=false)]
                public ListGatewayServiceResponseBodyDataResultHealthCheckInfo HealthCheckInfo { get; set; }
                public class ListGatewayServiceResponseBodyDataResultHealthCheckInfo : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the check is performed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Check")]
                    [Validation(Required=false)]
                    public bool? Check { get; set; }

                    /// <summary>
                    /// <para>The expected HTTP status codes for health checks.</para>
                    /// </summary>
                    [NameInMap("ExpectedStatuses")]
                    [Validation(Required=false)]
                    public List<int?> ExpectedStatuses { get; set; }

                    /// <summary>
                    /// <para>The healthy threshold.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("HealthyThreshold")]
                    [Validation(Required=false)]
                    public int? HealthyThreshold { get; set; }

                    /// <summary>
                    /// <para>The HTTP request address for health checks.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://172.168.0.1">http://172.168.0.1</a></para>
                    /// </summary>
                    [NameInMap("HttpHost")]
                    [Validation(Required=false)]
                    public string HttpHost { get; set; }

                    /// <summary>
                    /// <para>The HTTP request path for health checks.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/health</para>
                    /// </summary>
                    [NameInMap("HttpPath")]
                    [Validation(Required=false)]
                    public string HttpPath { get; set; }

                    /// <summary>
                    /// <para>The health check interval.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public int? Interval { get; set; }

                    /// <summary>
                    /// <para>The network protocol.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TCP</para>
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// <para>The timeout period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Timeout")]
                    [Validation(Required=false)]
                    public int? Timeout { get; set; }

                    /// <summary>
                    /// <para>The unhealthy threshold.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("UnhealthyThreshold")]
                    [Validation(Required=false)]
                    public int? UnhealthyThreshold { get; set; }

                }

                /// <summary>
                /// <para>The health status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Health</para>
                /// </description></item>
                /// <item><description><para>Unhealthy</para>
                /// </description></item>
                /// <item><description><para>Unknown</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Unhealthy</para>
                /// </summary>
                [NameInMap("HealthStatus")]
                [Validation(Required=false)]
                public string HealthStatus { get; set; }

                /// <summary>
                /// <para>The ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The IP address list.</para>
                /// </summary>
                [NameInMap("Ips")]
                [Validation(Required=false)]
                public List<string> Ips { get; set; }

                /// <summary>
                /// <para>The metadata or IP address list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("MetaInfo")]
                [Validation(Required=false)]
                public string MetaInfo { get; set; }

                /// <summary>
                /// <para>The service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>public</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The array of ports.</para>
                /// </summary>
                [NameInMap("Ports")]
                [Validation(Required=false)]
                public List<int?> Ports { get; set; }

                /// <summary>
                /// <para>The fully qualified domain name (FQDN) of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo.default.svc.cluster.local</para>
                /// </summary>
                [NameInMap("ServiceFQDN")]
                [Validation(Required=false)]
                public string ServiceFQDN { get; set; }

                /// <summary>
                /// <para>The original service name in the registry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ServiceNameInRegistry")]
                [Validation(Required=false)]
                public string ServiceNameInRegistry { get; set; }

                /// <summary>
                /// <para>The service port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("ServicePort")]
                [Validation(Required=false)]
                public long? ServicePort { get; set; }

                /// <summary>
                /// <para>The service protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("ServiceProtocol")]
                [Validation(Required=false)]
                public string ServiceProtocol { get; set; }

                /// <summary>
                /// <para>The source ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("SourceId")]
                [Validation(Required=false)]
                public long? SourceId { get; set; }

                /// <summary>
                /// <para>The source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MSE</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The array of unhealthy endpoints.</para>
                /// </summary>
                [NameInMap("UnhealthyEndpoints")]
                [Validation(Required=false)]
                public List<string> UnhealthyEndpoints { get; set; }

                /// <summary>
                /// <para>The service versions.</para>
                /// </summary>
                [NameInMap("Versions")]
                [Validation(Required=false)]
                public List<ListGatewayServiceResponseBodyDataResultVersions> Versions { get; set; }
                public class ListGatewayServiceResponseBodyDataResultVersions : TeaModel {
                    /// <summary>
                    /// <para>The version name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>v1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You are not authorized to perform this operation.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F46CDBA4-B1EE-5C94-8A48-51C10177****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request is successful.</description></item>
        /// <item><description><c>false</c>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
