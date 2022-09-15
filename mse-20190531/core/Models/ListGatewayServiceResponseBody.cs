// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewayServiceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListGatewayServiceResponseBodyData Data { get; set; }
        public class ListGatewayServiceResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListGatewayServiceResponseBodyDataResult> Result { get; set; }
            public class ListGatewayServiceResponseBodyDataResult : TeaModel {
                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public long? GatewayId { get; set; }

                [NameInMap("GatewayTrafficPolicy")]
                [Validation(Required=false)]
                public ListGatewayServiceResponseBodyDataResultGatewayTrafficPolicy GatewayTrafficPolicy { get; set; }
                public class ListGatewayServiceResponseBodyDataResultGatewayTrafficPolicy : TeaModel {
                    [NameInMap("LoadBalancerSettings")]
                    [Validation(Required=false)]
                    public ListGatewayServiceResponseBodyDataResultGatewayTrafficPolicyLoadBalancerSettings LoadBalancerSettings { get; set; }
                    public class ListGatewayServiceResponseBodyDataResultGatewayTrafficPolicyLoadBalancerSettings : TeaModel {
                        [NameInMap("ConsistentHashLBConfig")]
                        [Validation(Required=false)]
                        public ListGatewayServiceResponseBodyDataResultGatewayTrafficPolicyLoadBalancerSettingsConsistentHashLBConfig ConsistentHashLBConfig { get; set; }
                        public class ListGatewayServiceResponseBodyDataResultGatewayTrafficPolicyLoadBalancerSettingsConsistentHashLBConfig : TeaModel {
                            [NameInMap("ConsistentHashLBType")]
                            [Validation(Required=false)]
                            public string ConsistentHashLBType { get; set; }

                            [NameInMap("HttpCookie")]
                            [Validation(Required=false)]
                            public ListGatewayServiceResponseBodyDataResultGatewayTrafficPolicyLoadBalancerSettingsConsistentHashLBConfigHttpCookie HttpCookie { get; set; }
                            public class ListGatewayServiceResponseBodyDataResultGatewayTrafficPolicyLoadBalancerSettingsConsistentHashLBConfigHttpCookie : TeaModel {
                                [NameInMap("Name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                                [NameInMap("Path")]
                                [Validation(Required=false)]
                                public string Path { get; set; }

                                [NameInMap("Ttl")]
                                [Validation(Required=false)]
                                public string Ttl { get; set; }

                            }

                            [NameInMap("MinimumRingSize")]
                            [Validation(Required=false)]
                            public long? MinimumRingSize { get; set; }

                            [NameInMap("ParameterName")]
                            [Validation(Required=false)]
                            public string ParameterName { get; set; }

                        }

                        [NameInMap("LoadbalancerType")]
                        [Validation(Required=false)]
                        public string LoadbalancerType { get; set; }

                        [NameInMap("WarmupDuration")]
                        [Validation(Required=false)]
                        public int? WarmupDuration { get; set; }

                    }

                    [NameInMap("Tls")]
                    [Validation(Required=false)]
                    public ListGatewayServiceResponseBodyDataResultGatewayTrafficPolicyTls Tls { get; set; }
                    public class ListGatewayServiceResponseBodyDataResultGatewayTrafficPolicyTls : TeaModel {
                        [NameInMap("CaCertContent")]
                        [Validation(Required=false)]
                        public string CaCertContent { get; set; }

                        [NameInMap("CaCertId")]
                        [Validation(Required=false)]
                        public string CaCertId { get; set; }

                        [NameInMap("CertId")]
                        [Validation(Required=false)]
                        public string CertId { get; set; }

                        [NameInMap("Mode")]
                        [Validation(Required=false)]
                        public string Mode { get; set; }

                        [NameInMap("Sni")]
                        [Validation(Required=false)]
                        public string Sni { get; set; }

                        [NameInMap("SubjectAltNames")]
                        [Validation(Required=false)]
                        public List<string> SubjectAltNames { get; set; }

                    }

                }

                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("HealehStatus")]
                [Validation(Required=false)]
                public string HealehStatus { get; set; }

                [NameInMap("HealthCheck")]
                [Validation(Required=false)]
                public bool? HealthCheck { get; set; }

                [NameInMap("HealthCheckInfo")]
                [Validation(Required=false)]
                public ListGatewayServiceResponseBodyDataResultHealthCheckInfo HealthCheckInfo { get; set; }
                public class ListGatewayServiceResponseBodyDataResultHealthCheckInfo : TeaModel {
                    [NameInMap("Check")]
                    [Validation(Required=false)]
                    public bool? Check { get; set; }

                    [NameInMap("ExpectedStatuses")]
                    [Validation(Required=false)]
                    public List<int?> ExpectedStatuses { get; set; }

                    [NameInMap("HealthyThreshold")]
                    [Validation(Required=false)]
                    public int? HealthyThreshold { get; set; }

                    [NameInMap("HttpHost")]
                    [Validation(Required=false)]
                    public string HttpHost { get; set; }

                    [NameInMap("HttpPath")]
                    [Validation(Required=false)]
                    public string HttpPath { get; set; }

                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public int? Interval { get; set; }

                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    [NameInMap("Timeout")]
                    [Validation(Required=false)]
                    public int? Timeout { get; set; }

                    [NameInMap("UnhealthyThreshold")]
                    [Validation(Required=false)]
                    public int? UnhealthyThreshold { get; set; }

                }

                [NameInMap("HealthStatus")]
                [Validation(Required=false)]
                public string HealthStatus { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Ips")]
                [Validation(Required=false)]
                public List<string> Ips { get; set; }

                [NameInMap("MetaInfo")]
                [Validation(Required=false)]
                public string MetaInfo { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("ServiceNameInRegistry")]
                [Validation(Required=false)]
                public string ServiceNameInRegistry { get; set; }

                [NameInMap("ServicePort")]
                [Validation(Required=false)]
                public long? ServicePort { get; set; }

                [NameInMap("ServiceProtocol")]
                [Validation(Required=false)]
                public string ServiceProtocol { get; set; }

                [NameInMap("SourceId")]
                [Validation(Required=false)]
                public long? SourceId { get; set; }

                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("UnhealthyEndpoints")]
                [Validation(Required=false)]
                public List<string> UnhealthyEndpoints { get; set; }

                [NameInMap("Versions")]
                [Validation(Required=false)]
                public List<ListGatewayServiceResponseBodyDataResultVersions> Versions { get; set; }
                public class ListGatewayServiceResponseBodyDataResultVersions : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
