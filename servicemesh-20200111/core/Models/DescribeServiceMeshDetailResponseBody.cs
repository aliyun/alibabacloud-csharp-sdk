// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshDetailResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the ASM instance.
        /// </summary>
        [NameInMap("ServiceMesh")]
        [Validation(Required=false)]
        public DescribeServiceMeshDetailResponseBodyServiceMesh ServiceMesh { get; set; }
        public class DescribeServiceMeshDetailResponseBodyServiceMesh : TeaModel {
            /// <summary>
            /// The specification of the ASM instance. Valid values:
            /// 
            /// *   `standard`: Standard Edition
            /// *   `enterprise`: Enterprise Edition
            /// *   `ultimate`: Ultimate Edition
            /// </summary>
            [NameInMap("ClusterSpec")]
            [Validation(Required=false)]
            public string ClusterSpec { get; set; }

            /// <summary>
            /// The clusters.
            /// </summary>
            [NameInMap("Clusters")]
            [Validation(Required=false)]
            public List<string> Clusters { get; set; }

            /// <summary>
            /// The endpoints of the ASM instance.
            /// </summary>
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public DescribeServiceMeshDetailResponseBodyServiceMeshEndpoints Endpoints { get; set; }
            public class DescribeServiceMeshDetailResponseBodyServiceMeshEndpoints : TeaModel {
                /// <summary>
                /// The endpoint that is used to access the API server from the internal network.
                /// </summary>
                [NameInMap("IntranetApiServerEndpoint")]
                [Validation(Required=false)]
                public string IntranetApiServerEndpoint { get; set; }

                /// <summary>
                /// The endpoint that is used to access Istio Pilot from the internal network.
                /// </summary>
                [NameInMap("IntranetPilotEndpoint")]
                [Validation(Required=false)]
                public string IntranetPilotEndpoint { get; set; }

                /// <summary>
                /// The endpoint that is used to access the API server over the Internet.
                /// </summary>
                [NameInMap("PublicApiServerEndpoint")]
                [Validation(Required=false)]
                public string PublicApiServerEndpoint { get; set; }

                /// <summary>
                /// The endpoint that is used to expose Istio Pilot to the Internet.
                /// </summary>
                [NameInMap("PublicPilotEndpoint")]
                [Validation(Required=false)]
                public string PublicPilotEndpoint { get; set; }

            }

            /// <summary>
            /// The ID of the Alibaba Cloud service instance for which the ASM instance is created.
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// The Alibaba Cloud service for which the ASM instance is created. Valid values:
            /// 
            /// *   `ackone`: The ASM instance is created for Alibaba Cloud Distributed Cloud Container Platform (ACK One).
            /// *   An empty value indicates that the ASM instance is created by the user.
            /// </summary>
            [NameInMap("OwnerType")]
            [Validation(Required=false)]
            public string OwnerType { get; set; }

            /// <summary>
            /// The basic information about the ASM instance.
            /// </summary>
            [NameInMap("ServiceMeshInfo")]
            [Validation(Required=false)]
            public DescribeServiceMeshDetailResponseBodyServiceMeshServiceMeshInfo ServiceMeshInfo { get; set; }
            public class DescribeServiceMeshDetailResponseBodyServiceMeshServiceMeshInfo : TeaModel {
                /// <summary>
                /// The time when the ASM instance was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The returned error message.
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// The name of the ASM instance.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The edition of the ASM instance. Valid values:
                /// 
                /// *   `Default`: Standard Edition
                /// *   `Pro`: Enterprise Edition and Ultimate Edition
                /// </summary>
                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                /// <summary>
                /// The ID of the region in which the ASM instance resides.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ASM instance ID.
                /// </summary>
                [NameInMap("ServiceMeshId")]
                [Validation(Required=false)]
                public string ServiceMeshId { get; set; }

                /// <summary>
                /// The state of the ASM instance.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// The time when the ASM instance was last modified.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// The version of the ASM instance.
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// The specifications of the ASM instance.
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public DescribeServiceMeshDetailResponseBodyServiceMeshSpec Spec { get; set; }
            public class DescribeServiceMeshDetailResponseBodyServiceMeshSpec : TeaModel {
                /// <summary>
                /// The information about load balancing.
                /// </summary>
                [NameInMap("LoadBalancer")]
                [Validation(Required=false)]
                public DescribeServiceMeshDetailResponseBodyServiceMeshSpecLoadBalancer LoadBalancer { get; set; }
                public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecLoadBalancer : TeaModel {
                    /// <summary>
                    /// The ID of the CLB instance that is used when the API server is exposed to the Internet.
                    /// </summary>
                    [NameInMap("ApiServerLoadbalancerId")]
                    [Validation(Required=false)]
                    public string ApiServerLoadbalancerId { get; set; }

                    /// <summary>
                    /// Indicates whether the API server is exposed to the Internet. Valid values:
                    /// 
                    /// *   `true`
                    /// *   `false`
                    /// </summary>
                    [NameInMap("ApiServerPublicEip")]
                    [Validation(Required=false)]
                    public bool? ApiServerPublicEip { get; set; }

                    /// <summary>
                    /// Indicates whether Istio Pilot is exposed to the Internet. Valid values:
                    /// 
                    /// *   `true`
                    /// *   `false`
                    /// </summary>
                    [NameInMap("PilotPublicEip")]
                    [Validation(Required=false)]
                    public bool? PilotPublicEip { get; set; }

                    /// <summary>
                    /// The ID of the Classic Load Balancer (CLB) instance that is used when Istio Pilot is exposed to the Internet.
                    /// </summary>
                    [NameInMap("PilotPublicLoadbalancerId")]
                    [Validation(Required=false)]
                    public string PilotPublicLoadbalancerId { get; set; }

                }

                /// <summary>
                /// The configurations of the ASM instance.
                /// </summary>
                [NameInMap("MeshConfig")]
                [Validation(Required=false)]
                public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfig MeshConfig { get; set; }
                public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfig : TeaModel {
                    /// <summary>
                    /// The configurations of access log collection.
                    /// </summary>
                    [NameInMap("AccessLog")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigAccessLog AccessLog { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigAccessLog : TeaModel {
                        /// <summary>
                        /// Indicates whether access log collection is enabled. Valid values:
                        /// 
                        /// *   `true`
                        /// *   `false`
                        /// </summary>
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        /// <summary>
                        /// The name of the Simple Log Service project that stores access logs.
                        /// </summary>
                        [NameInMap("Project")]
                        [Validation(Required=false)]
                        public string Project { get; set; }

                    }

                    /// <summary>
                    /// The information about mesh audit.
                    /// </summary>
                    [NameInMap("Audit")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigAudit Audit { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigAudit : TeaModel {
                        /// <summary>
                        /// Indicates whether an audit project exists in the ASM instance. Valid values:
                        /// 
                        /// *   `audit_project_exist`: An audit project exists.
                        /// *   `audit_project_not_exist`: No audit project exists.
                        /// </summary>
                        [NameInMap("AuditProjectStatus")]
                        [Validation(Required=false)]
                        public string AuditProjectStatus { get; set; }

                        /// <summary>
                        /// Indicates whether mesh audit is enabled. Valid values:
                        /// 
                        /// *   `true`
                        /// *   `false`
                        /// </summary>
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        /// <summary>
                        /// The name of the Simple Log Service project that is used for mesh audit.
                        /// </summary>
                        [NameInMap("Project")]
                        [Validation(Required=false)]
                        public string Project { get; set; }

                    }

                    /// <summary>
                    /// The configurations of control plane log collection.
                    /// </summary>
                    [NameInMap("ControlPlaneLogInfo")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigControlPlaneLogInfo ControlPlaneLogInfo { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigControlPlaneLogInfo : TeaModel {
                        /// <summary>
                        /// Indicates whether the collection of control plane logs is enabled. Valid values:
                        /// 
                        /// *   `true`
                        /// *   `false`
                        /// </summary>
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        [NameInMap("LogTTL")]
                        [Validation(Required=false)]
                        public int? LogTTL { get; set; }

                        /// <summary>
                        /// The name of the Simple Log Service project that stores control plane logs.
                        /// </summary>
                        [NameInMap("Project")]
                        [Validation(Required=false)]
                        public string Project { get; set; }

                    }

                    /// <summary>
                    /// Indicates whether a custom Zipkin system is used. Valid values:
                    /// 
                    /// *   `true`
                    /// *   `false`
                    /// </summary>
                    [NameInMap("CustomizedZipkin")]
                    [Validation(Required=false)]
                    public bool? CustomizedZipkin { get; set; }

                    /// <summary>
                    /// The information about the edition.
                    /// </summary>
                    [NameInMap("Edition")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigEdition Edition { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigEdition : TeaModel {
                        /// <summary>
                        /// The version of the Istiod image.
                        /// </summary>
                        [NameInMap("IstiodImageTag")]
                        [Validation(Required=false)]
                        public string IstiodImageTag { get; set; }

                        /// <summary>
                        /// The name of the edition.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// The version of the Istio Proxy image.
                        /// </summary>
                        [NameInMap("ProxyImageTag")]
                        [Validation(Required=false)]
                        public string ProxyImageTag { get; set; }

                    }

                    /// <summary>
                    /// Indicates whether the feature that routes traffic to the nearest instance is enabled. Valid values:
                    /// 
                    /// *   `true`
                    /// *   `false`
                    /// </summary>
                    [NameInMap("EnableLocalityLB")]
                    [Validation(Required=false)]
                    public bool? EnableLocalityLB { get; set; }

                    /// <summary>
                    /// The IP ranges in CIDR form to be excluded from redirection to sidecar proxies in the ASM instance.
                    /// </summary>
                    [NameInMap("ExcludeIPRanges")]
                    [Validation(Required=false)]
                    public string ExcludeIPRanges { get; set; }

                    /// <summary>
                    /// The inbound ports to be excluded from redirection to sidecar proxies in the ASM instance.
                    /// </summary>
                    [NameInMap("ExcludeInboundPorts")]
                    [Validation(Required=false)]
                    public string ExcludeInboundPorts { get; set; }

                    /// <summary>
                    /// The outbound ports to be excluded from redirection to sidecar proxies in the ASM instance.
                    /// </summary>
                    [NameInMap("ExcludeOutboundPorts")]
                    [Validation(Required=false)]
                    public string ExcludeOutboundPorts { get; set; }

                    /// <summary>
                    /// The configurations of additional features for the ASM instance.
                    /// </summary>
                    [NameInMap("ExtraConfiguration")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfiguration ExtraConfiguration { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfiguration : TeaModel {
                        /// <summary>
                        /// The configurations of additional features for access log collection.
                        /// </summary>
                        [NameInMap("AccessLogExtraConf")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationAccessLogExtraConf AccessLogExtraConf { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationAccessLogExtraConf : TeaModel {
                            [NameInMap("GatewayEnabled")]
                            [Validation(Required=false)]
                            public bool? GatewayEnabled { get; set; }

                            /// <summary>
                            /// The retention period for the access logs of the ingress gateway. Unit: day. The logs are collected by using Simple Log Service. For example, the value 30 indicates that the logs are retained for 30 days.
                            /// </summary>
                            [NameInMap("GatewayLifecycle")]
                            [Validation(Required=false)]
                            public int? GatewayLifecycle { get; set; }

                            [NameInMap("SidecarEnabled")]
                            [Validation(Required=false)]
                            public bool? SidecarEnabled { get; set; }

                            /// <summary>
                            /// The retention period for the access logs of sidecar proxies. Unit: day. The logs are collected by using Simple Log Service. For example, the value 30 indicates that the logs are retained for 30 days.
                            /// </summary>
                            [NameInMap("SidecarLifecycle")]
                            [Validation(Required=false)]
                            public int? SidecarLifecycle { get; set; }

                        }

                        /// <summary>
                        /// The configurations of adaptive xDS optimization.
                        /// </summary>
                        [NameInMap("AdaptiveXdsConfiguration")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationAdaptiveXdsConfiguration AdaptiveXdsConfiguration { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationAdaptiveXdsConfiguration : TeaModel {
                            /// <summary>
                            /// Indicates whether Horizontal Pod Autoscaling (HPA) is enabled for the egress gateway.
                            /// </summary>
                            [NameInMap("EgressAutoscaleEnabled")]
                            [Validation(Required=false)]
                            public bool? EgressAutoscaleEnabled { get; set; }

                            /// <summary>
                            /// The CPU resource configurations of the egress gateway when HPA is enabled.
                            /// </summary>
                            [NameInMap("EgressHpaCpu")]
                            [Validation(Required=false)]
                            public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationAdaptiveXdsConfigurationEgressHpaCpu EgressHpaCpu { get; set; }
                            public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationAdaptiveXdsConfigurationEgressHpaCpu : TeaModel {
                                /// <summary>
                                /// The expected CPU utilization when HPA is enabled. Valid values: 1 to 100. If the CPU utilization exceeds this value, the number of pod replicas increases. If the CPU utilization is less than this value, the number of pod replicas decreases.
                                /// </summary>
                                [NameInMap("TargetAverageUtilization")]
                                [Validation(Required=false)]
                                public int? TargetAverageUtilization { get; set; }

                            }

                            /// <summary>
                            /// The memory resource configurations of the egress gateway when HPA is enabled.
                            /// </summary>
                            [NameInMap("EgressHpaMemory")]
                            [Validation(Required=false)]
                            public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationAdaptiveXdsConfigurationEgressHpaMemory EgressHpaMemory { get; set; }
                            public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationAdaptiveXdsConfigurationEgressHpaMemory : TeaModel {
                                /// <summary>
                                /// The expected memory usage when HPA is enabled. Valid values: 1 to 100. If the memory usage exceeds this value, the number of pod replicas increases. If the memory usage is less than this value, the number of pod replicas decreases.
                                /// </summary>
                                [NameInMap("TargetAverageUtilization")]
                                [Validation(Required=false)]
                                public int? TargetAverageUtilization { get; set; }

                            }

                            /// <summary>
                            /// The maximum number of egress gateway pod replicas when HPA is enabled.
                            /// </summary>
                            [NameInMap("EgressMaxReplica")]
                            [Validation(Required=false)]
                            public int? EgressMaxReplica { get; set; }

                            /// <summary>
                            /// The minimum number of egress gateway pod replicas when HPA is enabled.
                            /// </summary>
                            [NameInMap("EgressMinReplica")]
                            [Validation(Required=false)]
                            public int? EgressMinReplica { get; set; }

                            /// <summary>
                            /// The number of the egress gateway pod replicas.
                            /// </summary>
                            [NameInMap("EgressReplicaCount")]
                            [Validation(Required=false)]
                            public int? EgressReplicaCount { get; set; }

                            /// <summary>
                            /// The resource configurations of the egress gateway that is used by adaptive xDS optimization.
                            /// </summary>
                            [NameInMap("EgressResources")]
                            [Validation(Required=false)]
                            public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationAdaptiveXdsConfigurationEgressResources EgressResources { get; set; }
                            public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationAdaptiveXdsConfigurationEgressResources : TeaModel {
                                /// <summary>
                                /// The resources that are available to the egress gateway.
                                /// </summary>
                                [NameInMap("Limits")]
                                [Validation(Required=false)]
                                public Dictionary<string, object> Limits { get; set; }

                                /// <summary>
                                /// The resources that are requested by the egress gateway.
                                /// </summary>
                                [NameInMap("Requests")]
                                [Validation(Required=false)]
                                public Dictionary<string, object> Requests { get; set; }

                            }

                            /// <summary>
                            /// Indicates whether adaptive xDS optimization is enabled.
                            /// </summary>
                            [NameInMap("Enabled")]
                            [Validation(Required=false)]
                            public bool? Enabled { get; set; }

                        }

                        /// <summary>
                        /// The configurations of automatic diagnostics for the ASM instance.
                        /// </summary>
                        [NameInMap("AutoDiagnosis")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationAutoDiagnosis AutoDiagnosis { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationAutoDiagnosis : TeaModel {
                            /// <summary>
                            /// Indicates whether automatic diagnostics is enabled for the ASM instance. If you enable this feature, the ASM instance is automatically diagnosed 5 minutes after you modify an Istio resource.
                            /// </summary>
                            [NameInMap("AutoDiagnosisEnabled")]
                            [Validation(Required=false)]
                            public bool? AutoDiagnosisEnabled { get; set; }

                        }

                        /// <summary>
                        /// Access to Istio resources by using the Kubernetes API on the data plane.
                        /// </summary>
                        [NameInMap("CRAggregationConfiguration")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationCRAggregationConfiguration CRAggregationConfiguration { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationCRAggregationConfiguration : TeaModel {
                            /// <summary>
                            /// Indicates whether Istio resources can be accessed by using the Kubernetes API on the data plane.
                            /// </summary>
                            [NameInMap("Enabled")]
                            [Validation(Required=false)]
                            public bool? Enabled { get; set; }

                        }

                        /// <summary>
                        /// Indicates whether the Kubernetes API of clusters on the data plane can be used to access Istio resources. Valid values:
                        /// 
                        /// *   `true`
                        /// *   `false`
                        /// </summary>
                        [NameInMap("CRAggregationEnabled")]
                        [Validation(Required=false)]
                        public bool? CRAggregationEnabled { get; set; }

                        /// <summary>
                        /// The label selectors used to specify the namespaces of the clusters on the data plane. The control plane discovers and processes only application services in the specified namespaces.
                        /// </summary>
                        [NameInMap("DiscoverySelectors")]
                        [Validation(Required=false)]
                        public List<Dictionary<string, object>> DiscoverySelectors { get; set; }

                        /// <summary>
                        /// The configurations of the rollback feature for Istio resources.
                        /// </summary>
                        [NameInMap("IstioCRHistory")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationIstioCRHistory IstioCRHistory { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationIstioCRHistory : TeaModel {
                            /// <summary>
                            /// Indicates whether the rollback feature for Istio resources is enabled. Valid values:
                            /// 
                            /// *   `true`
                            /// *   `false`
                            /// </summary>
                            [NameInMap("EnableHistory")]
                            [Validation(Required=false)]
                            public bool? EnableHistory { get; set; }

                        }

                        /// <summary>
                        /// The lifecycle of Istio Proxy.
                        /// </summary>
                        [NameInMap("Lifecycle")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecycle Lifecycle { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecycle : TeaModel {
                            /// <summary>
                            /// The post-start parameters.
                            /// </summary>
                            [NameInMap("postStart")]
                            [Validation(Required=false)]
                            public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePostStart PostStart { get; set; }
                            public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePostStart : TeaModel {
                                /// <summary>
                                /// The post-start script.
                                /// </summary>
                                [NameInMap("exec")]
                                [Validation(Required=false)]
                                public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePostStartExec Exec { get; set; }
                                public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePostStartExec : TeaModel {
                                    /// <summary>
                                    /// The executed commands. The value is a string that consists of JSON arrays.
                                    /// </summary>
                                    [NameInMap("command")]
                                    [Validation(Required=false)]
                                    public List<string> Command { get; set; }

                                }

                                /// <summary>
                                /// The HTTP GET request that is sent before the instance stops.
                                /// </summary>
                                [NameInMap("httpGet")]
                                [Validation(Required=false)]
                                public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePostStartHttpGet HttpGet { get; set; }
                                public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePostStartHttpGet : TeaModel {
                                    /// <summary>
                                    /// The URL of the request.
                                    /// </summary>
                                    [NameInMap("host")]
                                    [Validation(Required=false)]
                                    public string Host { get; set; }

                                    /// <summary>
                                    /// The HTTP request headers.
                                    /// </summary>
                                    [NameInMap("httpHeaders")]
                                    [Validation(Required=false)]
                                    public List<DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePostStartHttpGetHttpHeaders> HttpHeaders { get; set; }
                                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePostStartHttpGetHttpHeaders : TeaModel {
                                        /// <summary>
                                        /// The name of the HTTP request header.
                                        /// </summary>
                                        [NameInMap("name")]
                                        [Validation(Required=false)]
                                        public string Name { get; set; }

                                        /// <summary>
                                        /// The value of the HTTP request header field.
                                        /// </summary>
                                        [NameInMap("value")]
                                        [Validation(Required=false)]
                                        public string Value { get; set; }

                                    }

                                    /// <summary>
                                    /// The port number of the request.
                                    /// </summary>
                                    [NameInMap("port")]
                                    [Validation(Required=false)]
                                    public string Port { get; set; }

                                    /// <summary>
                                    /// The request method. Valid values: `http` and `https`.
                                    /// </summary>
                                    [NameInMap("scheme")]
                                    [Validation(Required=false)]
                                    public string Scheme { get; set; }

                                }

                                /// <summary>
                                /// The TCP socket request that is sent.
                                /// </summary>
                                [NameInMap("tcpSocket")]
                                [Validation(Required=false)]
                                public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePostStartTcpSocket TcpSocket { get; set; }
                                public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePostStartTcpSocket : TeaModel {
                                    /// <summary>
                                    /// The URL of the TCP socket request.
                                    /// </summary>
                                    [NameInMap("host")]
                                    [Validation(Required=false)]
                                    public string Host { get; set; }

                                    /// <summary>
                                    /// The port number of the TCP socket request.
                                    /// </summary>
                                    [NameInMap("port")]
                                    [Validation(Required=false)]
                                    public string Port { get; set; }

                                }

                            }

                            /// <summary>
                            /// The pre-close parameters.
                            /// </summary>
                            [NameInMap("preStop")]
                            [Validation(Required=false)]
                            public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePreStop PreStop { get; set; }
                            public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePreStop : TeaModel {
                                /// <summary>
                                /// The pre-close script.
                                /// </summary>
                                [NameInMap("exec")]
                                [Validation(Required=false)]
                                public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePreStopExec Exec { get; set; }
                                public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePreStopExec : TeaModel {
                                    /// <summary>
                                    /// The executed commands. The value is a string that consists of JSON arrays.
                                    /// </summary>
                                    [NameInMap("command")]
                                    [Validation(Required=false)]
                                    public List<string> Command { get; set; }

                                }

                                /// <summary>
                                /// The HTTP GET request that is sent before the instance stops.
                                /// </summary>
                                [NameInMap("httpGet")]
                                [Validation(Required=false)]
                                public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePreStopHttpGet HttpGet { get; set; }
                                public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePreStopHttpGet : TeaModel {
                                    /// <summary>
                                    /// The URL of the request.
                                    /// </summary>
                                    [NameInMap("host")]
                                    [Validation(Required=false)]
                                    public string Host { get; set; }

                                    /// <summary>
                                    /// The HTTP request headers.
                                    /// </summary>
                                    [NameInMap("httpHeaders")]
                                    [Validation(Required=false)]
                                    public List<DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePreStopHttpGetHttpHeaders> HttpHeaders { get; set; }
                                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePreStopHttpGetHttpHeaders : TeaModel {
                                        /// <summary>
                                        /// The name of the HTTP request header.
                                        /// </summary>
                                        [NameInMap("name")]
                                        [Validation(Required=false)]
                                        public string Name { get; set; }

                                        /// <summary>
                                        /// The value of the HTTP request header field.
                                        /// </summary>
                                        [NameInMap("value")]
                                        [Validation(Required=false)]
                                        public string Value { get; set; }

                                    }

                                    /// <summary>
                                    /// The port number of the request.
                                    /// </summary>
                                    [NameInMap("port")]
                                    [Validation(Required=false)]
                                    public string Port { get; set; }

                                    /// <summary>
                                    /// The request method. Valid values: `http` and `https`.
                                    /// </summary>
                                    [NameInMap("scheme")]
                                    [Validation(Required=false)]
                                    public string Scheme { get; set; }

                                }

                                /// <summary>
                                /// The TCP socket request that is sent.
                                /// </summary>
                                [NameInMap("tcpSocket")]
                                [Validation(Required=false)]
                                public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePreStopTcpSocket TcpSocket { get; set; }
                                public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePreStopTcpSocket : TeaModel {
                                    /// <summary>
                                    /// The URL of the request.
                                    /// </summary>
                                    [NameInMap("host")]
                                    [Validation(Required=false)]
                                    public string Host { get; set; }

                                    /// <summary>
                                    /// The port number of the request.
                                    /// </summary>
                                    [NameInMap("port")]
                                    [Validation(Required=false)]
                                    public string Port { get; set; }

                                }

                            }

                        }

                        /// <summary>
                        /// The information about Transport Layer Security (TLS) acceleration based on MulitiBuffer.
                        /// </summary>
                        [NameInMap("MultiBuffer")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationMultiBuffer MultiBuffer { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationMultiBuffer : TeaModel {
                            /// <summary>
                            /// Indicates whether MulitiBuffer-based TLS acceleration is enabled. Valid values:
                            /// 
                            /// *   `true`
                            /// *   `false`
                            /// </summary>
                            [NameInMap("Enabled")]
                            [Validation(Required=false)]
                            public bool? Enabled { get; set; }

                            /// <summary>
                            /// The pull-request latency.
                            /// </summary>
                            [NameInMap("PollDelay")]
                            [Validation(Required=false)]
                            public string PollDelay { get; set; }

                        }

                        /// <summary>
                        /// The configurations of Node Feature Discovery (NFD).
                        /// </summary>
                        [NameInMap("NFDConfiguration")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationNFDConfiguration NFDConfiguration { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationNFDConfiguration : TeaModel {
                            /// <summary>
                            /// Indicates whether NFD is enabled.
                            /// </summary>
                            [NameInMap("Enabled")]
                            [Validation(Required=false)]
                            public bool? Enabled { get; set; }

                            /// <summary>
                            /// Indicates whether feature labels on nodes are cleared when NFD is disabled.
                            /// </summary>
                            [NameInMap("NFDLabelPruned")]
                            [Validation(Required=false)]
                            public bool? NFDLabelPruned { get; set; }

                        }

                        /// <summary>
                        /// The configurations of the feature of controlling the OPA injection scope.
                        /// </summary>
                        [NameInMap("OPAScopeInjection")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationOPAScopeInjection OPAScopeInjection { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationOPAScopeInjection : TeaModel {
                            /// <summary>
                            /// Indicates whether the feature of controlling the OPA injection scope is enabled. Valid values:
                            /// 
                            /// *   `true`
                            /// *   `false`
                            /// </summary>
                            [NameInMap("OPAScopeInjected")]
                            [Validation(Required=false)]
                            public bool? OPAScopeInjected { get; set; }

                        }

                        /// <summary>
                        /// The resource limits on the istio-init container.
                        /// </summary>
                        [NameInMap("SidecarProxyInitResourceLimit")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationSidecarProxyInitResourceLimit SidecarProxyInitResourceLimit { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationSidecarProxyInitResourceLimit : TeaModel {
                            /// <summary>
                            /// The maximum number of CPU cores that are available to the istio-init container.
                            /// </summary>
                            [NameInMap("ResourceCPULimit")]
                            [Validation(Required=false)]
                            public string ResourceCPULimit { get; set; }

                            /// <summary>
                            /// The maximum size of the memory that is available to the istio-init container.
                            /// </summary>
                            [NameInMap("ResourceMemoryLimit")]
                            [Validation(Required=false)]
                            public string ResourceMemoryLimit { get; set; }

                        }

                        /// <summary>
                        /// The resources that are required by the istio-init container.
                        /// </summary>
                        [NameInMap("SidecarProxyInitResourceRequest")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationSidecarProxyInitResourceRequest SidecarProxyInitResourceRequest { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationSidecarProxyInitResourceRequest : TeaModel {
                            /// <summary>
                            /// The number of CPU cores that are requested by the istio-init container.
                            /// </summary>
                            [NameInMap("ResourceCPURequest")]
                            [Validation(Required=false)]
                            public string ResourceCPURequest { get; set; }

                            /// <summary>
                            /// The size of the memory that is requested by the istio-init container.
                            /// </summary>
                            [NameInMap("ResourceMemoryRequest")]
                            [Validation(Required=false)]
                            public string ResourceMemoryRequest { get; set; }

                        }

                        /// <summary>
                        /// The maximum period of time that Istio Proxy waits for a request to end.
                        /// </summary>
                        [NameInMap("TerminationDrainDuration")]
                        [Validation(Required=false)]
                        public string TerminationDrainDuration { get; set; }

                    }

                    /// <summary>
                    /// The IP ranges in CIDR form to redirect to the sidecar proxies in the ASM instance.
                    /// </summary>
                    [NameInMap("IncludeIPRanges")]
                    [Validation(Required=false)]
                    public string IncludeIPRanges { get; set; }

                    /// <summary>
                    /// The information about the Kubernetes API.
                    /// </summary>
                    [NameInMap("K8sNewAPIsSupport")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigK8sNewAPIsSupport K8sNewAPIsSupport { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigK8sNewAPIsSupport : TeaModel {
                        /// <summary>
                        /// Indicates whether Gateway API is enabled. Valid values:
                        /// 
                        /// *   `true`
                        /// *   `false`
                        /// </summary>
                        [NameInMap("GatewayAPIEnabled")]
                        [Validation(Required=false)]
                        public bool? GatewayAPIEnabled { get; set; }

                    }

                    /// <summary>
                    /// The configurations of mesh topology.
                    /// </summary>
                    [NameInMap("Kiali")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigKiali Kiali { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigKiali : TeaModel {
                        /// <summary>
                        /// Indicates whether mesh topology is enabled. Mesh topology can be enabled only when Prometheus monitoring is enabled. If Prometheus monitoring is disabled, you must set this parameter to `false`.`` Valid values:
                        /// 
                        /// *   `true`
                        /// *   `false`
                        /// </summary>
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        /// <summary>
                        /// The endpoint of the mesh topology service.
                        /// </summary>
                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                    /// <summary>
                    /// The configurations of cross-region load balancing.
                    /// </summary>
                    [NameInMap("LocalityLB")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigLocalityLB LocalityLB { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigLocalityLB : TeaModel {
                        /// <summary>
                        /// The configurations of cross-region traffic distribution.
                        /// 
                        /// >  Either `Failover` or Distribute can be set. If you set `Distribute`, you cannot set Failover.
                        /// </summary>
                        [NameInMap("Distribute")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> Distribute { get; set; }

                        /// <summary>
                        /// Indicates whether cross-region load balancing is enabled. Valid values:
                        /// 
                        /// *   `true`
                        /// *   `false`
                        /// </summary>
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        /// <summary>
                        /// The configurations of cross-region failover.
                        /// 
                        /// >  Either Failover or `Distribute` can be set. If you set `Failover`, you cannot set `Distribute`.
                        /// </summary>
                        [NameInMap("Failover")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> Failover { get; set; }

                    }

                    /// <summary>
                    /// The configurations of Microservices Engine (MSE).
                    /// </summary>
                    [NameInMap("MSE")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigMSE MSE { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigMSE : TeaModel {
                        /// <summary>
                        /// Indicates whether MSE is enabled. Valid values:
                        /// 
                        /// *   `true`
                        /// *   `false`
                        /// </summary>
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                    }

                    /// <summary>
                    /// The information about the Open Policy Agent (OPA) plug-in.
                    /// </summary>
                    [NameInMap("OPA")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigOPA OPA { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigOPA : TeaModel {
                        /// <summary>
                        /// Indicates whether the OPA plug-in is installed. Valid values:
                        /// 
                        /// *   `true`
                        /// *   `false`
                        /// </summary>
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        /// <summary>
                        /// The maximum number of CPU cores that are available to the OPA proxy container.
                        /// </summary>
                        [NameInMap("LimitCPU")]
                        [Validation(Required=false)]
                        public string LimitCPU { get; set; }

                        /// <summary>
                        /// The maximum size of the memory that is available to the OPA proxy container.
                        /// </summary>
                        [NameInMap("LimitMemory")]
                        [Validation(Required=false)]
                        public string LimitMemory { get; set; }

                        /// <summary>
                        /// The level of the logs to be generated for OPA.
                        /// </summary>
                        [NameInMap("LogLevel")]
                        [Validation(Required=false)]
                        public string LogLevel { get; set; }

                        /// <summary>
                        /// The number of CPU cores that are requested by the OPA proxy container.
                        /// </summary>
                        [NameInMap("RequestCPU")]
                        [Validation(Required=false)]
                        public string RequestCPU { get; set; }

                        /// <summary>
                        /// The size of the memory that is requested by OPA.
                        /// </summary>
                        [NameInMap("RequestMemory")]
                        [Validation(Required=false)]
                        public string RequestMemory { get; set; }

                    }

                    /// <summary>
                    /// The outbound traffic policy. Valid values:
                    /// 
                    /// *   `ALLOW_ANY`: Outbound traffic to all external services is allowed.
                    /// *   `REGISTRY_ONLY`: Outbound traffic is allowed to only external services that are defined in the service registry of the ASM instance.
                    /// </summary>
                    [NameInMap("OutboundTrafficPolicy")]
                    [Validation(Required=false)]
                    public string OutboundTrafficPolicy { get; set; }

                    /// <summary>
                    /// The Pilot configurations.
                    /// </summary>
                    [NameInMap("Pilot")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigPilot Pilot { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigPilot : TeaModel {
                        /// <summary>
                        /// The configurations of communication between external services and services in the mesh.
                        /// </summary>
                        [NameInMap("ConfigSource")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigPilotConfigSource ConfigSource { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigPilotConfigSource : TeaModel {
                            /// <summary>
                            /// Indicates whether communication is allowed between external services and services in the mesh. Valid values:
                            /// 
                            /// *   `true`
                            /// *   `false`
                            /// </summary>
                            [NameInMap("Enabled")]
                            [Validation(Required=false)]
                            public bool? Enabled { get; set; }

                            /// <summary>
                            /// The ID of the Nacos instance that provides external service information.
                            /// </summary>
                            [NameInMap("NacosID")]
                            [Validation(Required=false)]
                            public string NacosID { get; set; }

                        }

                        /// <summary>
                        /// The configurations of Pilot features.
                        /// </summary>
                        [NameInMap("Feature")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigPilotFeature Feature { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigPilotFeature : TeaModel {
                            /// <summary>
                            /// Indicates whether Secret Discovery Service (SDS) is enabled. Valid values:
                            /// 
                            /// *   `true`
                            /// *   `false`
                            /// </summary>
                            [NameInMap("EnableSDSServer")]
                            [Validation(Required=false)]
                            public bool? EnableSDSServer { get; set; }

                            /// <summary>
                            /// Indicates whether gateway configuration filtering is enabled. Valid values:
                            /// 
                            /// *   `true`
                            /// *   `false`
                            /// </summary>
                            [NameInMap("FilterGatewayClusterConfig")]
                            [Validation(Required=false)]
                            public bool? FilterGatewayClusterConfig { get; set; }

                        }

                        /// <summary>
                        /// Indicates whether HTTP/1.0 is supported. Valid values:
                        /// 
                        /// *   `true`
                        /// *   `false`
                        /// </summary>
                        [NameInMap("Http10Enabled")]
                        [Validation(Required=false)]
                        public bool? Http10Enabled { get; set; }

                        /// <summary>
                        /// The sampling percentage of tracing analysis.
                        /// </summary>
                        [NameInMap("TraceSampling")]
                        [Validation(Required=false)]
                        public float? TraceSampling { get; set; }

                    }

                    /// <summary>
                    /// The configurations of Prometheus monitoring.
                    /// </summary>
                    [NameInMap("Prometheus")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigPrometheus Prometheus { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigPrometheus : TeaModel {
                        /// <summary>
                        /// The endpoint of Prometheus monitoring. If you use a custom Prometheus instance, this parameter is populated by the system.
                        /// </summary>
                        [NameInMap("ExternalUrl")]
                        [Validation(Required=false)]
                        public string ExternalUrl { get; set; }

                        /// <summary>
                        /// Indicates whether a custom Prometheus instance is used. Valid values:
                        /// 
                        /// *   `true`
                        /// *   `false`
                        /// </summary>
                        [NameInMap("UseExternal")]
                        [Validation(Required=false)]
                        public bool? UseExternal { get; set; }

                    }

                    /// <summary>
                    /// The configurations of protocol support.
                    /// </summary>
                    [NameInMap("ProtocolSupport")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigProtocolSupport ProtocolSupport { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigProtocolSupport : TeaModel {
                        /// <summary>
                        /// Indicates whether Dubbo Filter is enabled. Valid values:
                        /// 
                        /// *   `true`
                        /// *   `false`
                        /// </summary>
                        [NameInMap("DubboFilterEnabled")]
                        [Validation(Required=false)]
                        public bool? DubboFilterEnabled { get; set; }

                        /// <summary>
                        /// Indicates whether MySQL Filter is enabled. Valid values:
                        /// 
                        /// *   `true`
                        /// *   `false`
                        /// </summary>
                        [NameInMap("MysqlFilterEnabled")]
                        [Validation(Required=false)]
                        public bool? MysqlFilterEnabled { get; set; }

                        /// <summary>
                        /// Indicates whether Redis Filter is enabled. Valid values:
                        /// 
                        /// *   `true`
                        /// *   `false`
                        /// </summary>
                        [NameInMap("RedisFilterEnabled")]
                        [Validation(Required=false)]
                        public bool? RedisFilterEnabled { get; set; }

                        /// <summary>
                        /// Indicates whether Thrift Filter is enabled. Valid values:
                        /// 
                        /// *   `true`
                        /// *   `false`
                        /// </summary>
                        [NameInMap("ThriftFilterEnabled")]
                        [Validation(Required=false)]
                        public bool? ThriftFilterEnabled { get; set; }

                    }

                    /// <summary>
                    /// The proxy configurations.
                    /// </summary>
                    [NameInMap("Proxy")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigProxy Proxy { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigProxy : TeaModel {
                        /// <summary>
                        /// The path to the file that stores the access logs of sidecar proxies.
                        /// </summary>
                        [NameInMap("AccessLogFile")]
                        [Validation(Required=false)]
                        public string AccessLogFile { get; set; }

                        /// <summary>
                        /// The format of the access logs of sidecar proxies.
                        /// </summary>
                        [NameInMap("AccessLogFormat")]
                        [Validation(Required=false)]
                        public string AccessLogFormat { get; set; }

                        /// <summary>
                        /// Indicates whether gRPC Access Log Service (ALS) for Envoy is enabled. Valid values:
                        /// 
                        /// *   `true`
                        /// *   `false`
                        /// </summary>
                        [NameInMap("AccessLogServiceEnabled")]
                        [Validation(Required=false)]
                        public bool? AccessLogServiceEnabled { get; set; }

                        /// <summary>
                        /// The endpoint of gRPC ALS for Envoy.
                        /// </summary>
                        [NameInMap("AccessLogServiceHost")]
                        [Validation(Required=false)]
                        public string AccessLogServiceHost { get; set; }

                        /// <summary>
                        /// The port of gRPC ALS for Envoy.
                        /// </summary>
                        [NameInMap("AccessLogServicePort")]
                        [Validation(Required=false)]
                        public int? AccessLogServicePort { get; set; }

                        /// <summary>
                        /// The trusted domain.
                        /// </summary>
                        [NameInMap("ClusterDomain")]
                        [Validation(Required=false)]
                        public string ClusterDomain { get; set; }

                        /// <summary>
                        /// Indicates whether the Domain Name System (DNS) proxy feature is enabled. Valid values:
                        /// 
                        /// *   `true`
                        /// *   `false`
                        /// </summary>
                        [NameInMap("EnableDNSProxying")]
                        [Validation(Required=false)]
                        public bool? EnableDNSProxying { get; set; }

                        /// <summary>
                        /// The maximum number of CPU cores.
                        /// </summary>
                        [NameInMap("LimitCPU")]
                        [Validation(Required=false)]
                        public string LimitCPU { get; set; }

                        /// <summary>
                        /// The maximum size of the memory.
                        /// </summary>
                        [NameInMap("LimitMemory")]
                        [Validation(Required=false)]
                        public string LimitMemory { get; set; }

                        /// <summary>
                        /// The number of CPU cores that are requested.
                        /// </summary>
                        [NameInMap("RequestCPU")]
                        [Validation(Required=false)]
                        public string RequestCPU { get; set; }

                        /// <summary>
                        /// The size of the memory that is requested.
                        /// </summary>
                        [NameInMap("RequestMemory")]
                        [Validation(Required=false)]
                        public string RequestMemory { get; set; }

                    }

                    /// <summary>
                    /// The configurations of the sidecar injector.
                    /// </summary>
                    [NameInMap("SidecarInjector")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigSidecarInjector SidecarInjector { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigSidecarInjector : TeaModel {
                        /// <summary>
                        /// Indicates whether automatic sidecar proxy injection can be enabled by using pod annotations. Valid values:
                        /// 
                        /// *   `true`
                        /// *   `false`
                        /// </summary>
                        [NameInMap("AutoInjectionPolicyEnabled")]
                        [Validation(Required=false)]
                        public bool? AutoInjectionPolicyEnabled { get; set; }

                        /// <summary>
                        /// Indicates whether automatic sidecar proxy injection is enabled for all namespaces. Valid values:
                        /// 
                        /// *   `true`
                        /// *   `false`
                        /// </summary>
                        [NameInMap("EnableNamespacesByDefault")]
                        [Validation(Required=false)]
                        public bool? EnableNamespacesByDefault { get; set; }

                        /// <summary>
                        /// The configurations of Container Network Interface (CNI).
                        /// </summary>
                        [NameInMap("InitCNIConfiguration")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigSidecarInjectorInitCNIConfiguration InitCNIConfiguration { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigSidecarInjectorInitCNIConfiguration : TeaModel {
                            /// <summary>
                            /// Indicates whether the CNI plug-in is enabled. Valid values:
                            /// 
                            /// *   `true`
                            /// *   `false`
                            /// </summary>
                            [NameInMap("Enabled")]
                            [Validation(Required=false)]
                            public bool? Enabled { get; set; }

                            /// <summary>
                            /// The namespaces to exclude. The CNI plug-in ignores pods in the excluded namespaces.
                            /// </summary>
                            [NameInMap("ExcludeNamespaces")]
                            [Validation(Required=false)]
                            public string ExcludeNamespaces { get; set; }

                        }

                        /// <summary>
                        /// The maximum number of CPU cores that are available to the pod where the sidecar injector resides.
                        /// </summary>
                        [NameInMap("LimitCPU")]
                        [Validation(Required=false)]
                        public string LimitCPU { get; set; }

                        /// <summary>
                        /// The maximum size of the memory that is available to the pod where the sidecar injector resides.
                        /// </summary>
                        [NameInMap("LimitMemory")]
                        [Validation(Required=false)]
                        public string LimitMemory { get; set; }

                        /// <summary>
                        /// The number of CPU cores that are requested by the pod where the sidecar injector resides.
                        /// </summary>
                        [NameInMap("RequestCPU")]
                        [Validation(Required=false)]
                        public string RequestCPU { get; set; }

                        /// <summary>
                        /// The size of the memory that is requested by the pod where the sidecar injector resides.
                        /// </summary>
                        [NameInMap("RequestMemory")]
                        [Validation(Required=false)]
                        public string RequestMemory { get; set; }

                        /// <summary>
                        /// The number of component replicas that are used for sidecar proxy injection. Default value: `1`.
                        /// </summary>
                        [NameInMap("SidecarInjectorNum")]
                        [Validation(Required=false)]
                        public int? SidecarInjectorNum { get; set; }

                        /// <summary>
                        /// Other configurations of automatic sidecar proxy injection, in the YAML format. For more information, see [Enable automatic sidecar proxy injection](~~186136~~).
                        /// </summary>
                        [NameInMap("SidecarInjectorWebhookAsYaml")]
                        [Validation(Required=false)]
                        public string SidecarInjectorWebhookAsYaml { get; set; }

                    }

                    /// <summary>
                    /// Indicates whether Prometheus monitoring is enabled. We recommend that you use [Managed Service for Prometheus](https://arms.console.aliyun.com/). Valid values:
                    /// 
                    /// *   `true`
                    /// *   `false`
                    /// </summary>
                    [NameInMap("Telemetry")]
                    [Validation(Required=false)]
                    public bool? Telemetry { get; set; }

                    /// <summary>
                    /// Indicates whether tracing analysis is enabled. This feature can be enabled only after [Managed Service for OpenTelemetry](https://tracing-analysis.console.aliyun.com/) is activated. Valid values:
                    /// 
                    /// *   `true`
                    /// *   `false`
                    /// </summary>
                    [NameInMap("Tracing")]
                    [Validation(Required=false)]
                    public bool? Tracing { get; set; }

                    /// <summary>
                    /// The configurations of WebAssembly Filter.
                    /// </summary>
                    [NameInMap("WebAssemblyFilterDeployment")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigWebAssemblyFilterDeployment WebAssemblyFilterDeployment { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigWebAssemblyFilterDeployment : TeaModel {
                        /// <summary>
                        /// Indicates whether WebAssembly Filter is enabled. Valid values:
                        /// 
                        /// *   `true`
                        /// *   `false`
                        /// </summary>
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                    }

                }

                /// <summary>
                /// The network configurations of the ASM instance.
                /// </summary>
                [NameInMap("Network")]
                [Validation(Required=false)]
                public DescribeServiceMeshDetailResponseBodyServiceMeshSpecNetwork Network { get; set; }
                public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecNetwork : TeaModel {
                    /// <summary>
                    /// The security group ID.
                    /// </summary>
                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    /// <summary>
                    /// The virtual switches (vSwitches).
                    /// </summary>
                    [NameInMap("VSwitches")]
                    [Validation(Required=false)]
                    public List<string> VSwitches { get; set; }

                    /// <summary>
                    /// The ID of the virtual private cloud (VPC).
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

            }

        }

    }

}
