// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServiceMesh")]
        [Validation(Required=false)]
        public DescribeServiceMeshDetailResponseBodyServiceMesh ServiceMesh { get; set; }
        public class DescribeServiceMeshDetailResponseBodyServiceMesh : TeaModel {
            [NameInMap("ClusterSpec")]
            [Validation(Required=false)]
            public string ClusterSpec { get; set; }
            [NameInMap("Clusters")]
            [Validation(Required=false)]
            public List<string> Clusters { get; set; }
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public DescribeServiceMeshDetailResponseBodyServiceMeshEndpoints Endpoints { get; set; }
            public class DescribeServiceMeshDetailResponseBodyServiceMeshEndpoints : TeaModel {
                [NameInMap("IntranetApiServerEndpoint")]
                [Validation(Required=false)]
                public string IntranetApiServerEndpoint { get; set; }

                [NameInMap("IntranetPilotEndpoint")]
                [Validation(Required=false)]
                public string IntranetPilotEndpoint { get; set; }

                [NameInMap("PublicApiServerEndpoint")]
                [Validation(Required=false)]
                public string PublicApiServerEndpoint { get; set; }

                [NameInMap("PublicPilotEndpoint")]
                [Validation(Required=false)]
                public string PublicPilotEndpoint { get; set; }

            }
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }
            [NameInMap("OwnerType")]
            [Validation(Required=false)]
            public string OwnerType { get; set; }
            [NameInMap("ServiceMeshInfo")]
            [Validation(Required=false)]
            public DescribeServiceMeshDetailResponseBodyServiceMeshServiceMeshInfo ServiceMeshInfo { get; set; }
            public class DescribeServiceMeshDetailResponseBodyServiceMeshServiceMeshInfo : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ServiceMeshId")]
                [Validation(Required=false)]
                public string ServiceMeshId { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public DescribeServiceMeshDetailResponseBodyServiceMeshSpec Spec { get; set; }
            public class DescribeServiceMeshDetailResponseBodyServiceMeshSpec : TeaModel {
                [NameInMap("LoadBalancer")]
                [Validation(Required=false)]
                public DescribeServiceMeshDetailResponseBodyServiceMeshSpecLoadBalancer LoadBalancer { get; set; }
                public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecLoadBalancer : TeaModel {
                    [NameInMap("ApiServerLoadbalancerId")]
                    [Validation(Required=false)]
                    public string ApiServerLoadbalancerId { get; set; }
                    [NameInMap("ApiServerPublicEip")]
                    [Validation(Required=false)]
                    public bool? ApiServerPublicEip { get; set; }
                    [NameInMap("PilotPublicEip")]
                    [Validation(Required=false)]
                    public bool? PilotPublicEip { get; set; }
                    [NameInMap("PilotPublicLoadbalancerId")]
                    [Validation(Required=false)]
                    public string PilotPublicLoadbalancerId { get; set; }
                };

                [NameInMap("MeshConfig")]
                [Validation(Required=false)]
                public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfig MeshConfig { get; set; }
                public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfig : TeaModel {
                    [NameInMap("AccessLog")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigAccessLog AccessLog { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigAccessLog : TeaModel {
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        [NameInMap("Project")]
                        [Validation(Required=false)]
                        public string Project { get; set; }

                    }
                    [NameInMap("Audit")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigAudit Audit { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigAudit : TeaModel {
                        [NameInMap("AuditProjectStatus")]
                        [Validation(Required=false)]
                        public string AuditProjectStatus { get; set; }

                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        [NameInMap("Project")]
                        [Validation(Required=false)]
                        public string Project { get; set; }

                    }
                    [NameInMap("ControlPlaneLogInfo")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigControlPlaneLogInfo ControlPlaneLogInfo { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigControlPlaneLogInfo : TeaModel {
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        [NameInMap("Project")]
                        [Validation(Required=false)]
                        public string Project { get; set; }

                    }
                    [NameInMap("CustomizedZipkin")]
                    [Validation(Required=false)]
                    public bool? CustomizedZipkin { get; set; }
                    [NameInMap("Edition")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigEdition Edition { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigEdition : TeaModel {
                        [NameInMap("IstiodImageTag")]
                        [Validation(Required=false)]
                        public string IstiodImageTag { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("ProxyImageTag")]
                        [Validation(Required=false)]
                        public string ProxyImageTag { get; set; }

                    }
                    [NameInMap("EnableLocalityLB")]
                    [Validation(Required=false)]
                    public bool? EnableLocalityLB { get; set; }
                    [NameInMap("ExcludeIPRanges")]
                    [Validation(Required=false)]
                    public string ExcludeIPRanges { get; set; }
                    [NameInMap("ExcludeInboundPorts")]
                    [Validation(Required=false)]
                    public string ExcludeInboundPorts { get; set; }
                    [NameInMap("ExcludeOutboundPorts")]
                    [Validation(Required=false)]
                    public string ExcludeOutboundPorts { get; set; }
                    [NameInMap("ExtraConfiguration")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfiguration ExtraConfiguration { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfiguration : TeaModel {
                        [NameInMap("AccessLogExtraConf")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationAccessLogExtraConf AccessLogExtraConf { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationAccessLogExtraConf : TeaModel {
                            [NameInMap("GatewayLifecycle")]
                            [Validation(Required=false)]
                            public int? GatewayLifecycle { get; set; }
                            [NameInMap("SidecarLifecycle")]
                            [Validation(Required=false)]
                            public int? SidecarLifecycle { get; set; }
                        };

                        [NameInMap("AutoDiagnosis")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationAutoDiagnosis AutoDiagnosis { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationAutoDiagnosis : TeaModel {
                            [NameInMap("AutoDiagnosisEnabled")]
                            [Validation(Required=false)]
                            public bool? AutoDiagnosisEnabled { get; set; }
                        };

                        [NameInMap("CRAggregationConfiguration")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationCRAggregationConfiguration CRAggregationConfiguration { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationCRAggregationConfiguration : TeaModel {
                            [NameInMap("Enabled")]
                            [Validation(Required=false)]
                            public bool? Enabled { get; set; }
                        };

                        [NameInMap("CRAggregationEnabled")]
                        [Validation(Required=false)]
                        public bool? CRAggregationEnabled { get; set; }

                        [NameInMap("DiscoverySelectors")]
                        [Validation(Required=false)]
                        public List<Dictionary<string, object>> DiscoverySelectors { get; set; }

                        [NameInMap("IstioCRHistory")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationIstioCRHistory IstioCRHistory { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationIstioCRHistory : TeaModel {
                            [NameInMap("EnableHistory")]
                            [Validation(Required=false)]
                            public bool? EnableHistory { get; set; }
                        };

                        [NameInMap("Lifecycle")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecycle Lifecycle { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecycle : TeaModel {
                            [NameInMap("postStart")]
                            [Validation(Required=false)]
                            public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePostStart PostStart { get; set; }
                            public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePostStart : TeaModel {
                                [NameInMap("exec")]
                                [Validation(Required=false)]
                                public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePostStartExec Exec { get; set; }
                                public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePostStartExec : TeaModel {
                                    [NameInMap("command")]
                                    [Validation(Required=false)]
                                    public List<string> Command { get; set; }
                                };

                                [NameInMap("httpGet")]
                                [Validation(Required=false)]
                                public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePostStartHttpGet HttpGet { get; set; }
                                public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePostStartHttpGet : TeaModel {
                                    [NameInMap("host")]
                                    [Validation(Required=false)]
                                    public string Host { get; set; }
                                    [NameInMap("httpHeaders")]
                                    [Validation(Required=false)]
                                    public List<DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePostStartHttpGetHttpHeaders> HttpHeaders { get; set; }
                                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePostStartHttpGetHttpHeaders : TeaModel {
                                        public string Name { get; set; }
                                        public string Value { get; set; }
                                    }
                                    [NameInMap("port")]
                                    [Validation(Required=false)]
                                    public string Port { get; set; }
                                    [NameInMap("scheme")]
                                    [Validation(Required=false)]
                                    public string Scheme { get; set; }
                                };

                                [NameInMap("tcpSocket")]
                                [Validation(Required=false)]
                                public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePostStartTcpSocket TcpSocket { get; set; }
                                public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePostStartTcpSocket : TeaModel {
                                    [NameInMap("host")]
                                    [Validation(Required=false)]
                                    public string Host { get; set; }
                                    [NameInMap("port")]
                                    [Validation(Required=false)]
                                    public string Port { get; set; }
                                };

                            }
                            [NameInMap("preStop")]
                            [Validation(Required=false)]
                            public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePreStop PreStop { get; set; }
                            public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePreStop : TeaModel {
                                [NameInMap("exec")]
                                [Validation(Required=false)]
                                public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePreStopExec Exec { get; set; }
                                public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePreStopExec : TeaModel {
                                    [NameInMap("command")]
                                    [Validation(Required=false)]
                                    public List<string> Command { get; set; }
                                };

                                [NameInMap("httpGet")]
                                [Validation(Required=false)]
                                public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePreStopHttpGet HttpGet { get; set; }
                                public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePreStopHttpGet : TeaModel {
                                    [NameInMap("host")]
                                    [Validation(Required=false)]
                                    public string Host { get; set; }
                                    [NameInMap("httpHeaders")]
                                    [Validation(Required=false)]
                                    public List<DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePreStopHttpGetHttpHeaders> HttpHeaders { get; set; }
                                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePreStopHttpGetHttpHeaders : TeaModel {
                                        public string Name { get; set; }
                                        public string Value { get; set; }
                                    }
                                    [NameInMap("port")]
                                    [Validation(Required=false)]
                                    public string Port { get; set; }
                                    [NameInMap("scheme")]
                                    [Validation(Required=false)]
                                    public string Scheme { get; set; }
                                };

                                [NameInMap("tcpSocket")]
                                [Validation(Required=false)]
                                public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePreStopTcpSocket TcpSocket { get; set; }
                                public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationLifecyclePreStopTcpSocket : TeaModel {
                                    [NameInMap("host")]
                                    [Validation(Required=false)]
                                    public string Host { get; set; }
                                    [NameInMap("port")]
                                    [Validation(Required=false)]
                                    public string Port { get; set; }
                                };

                            }
                        };

                        [NameInMap("MultiBuffer")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationMultiBuffer MultiBuffer { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationMultiBuffer : TeaModel {
                            [NameInMap("Enabled")]
                            [Validation(Required=false)]
                            public bool? Enabled { get; set; }
                            [NameInMap("PollDelay")]
                            [Validation(Required=false)]
                            public string PollDelay { get; set; }
                        };

                        [NameInMap("NFDConfiguration")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationNFDConfiguration NFDConfiguration { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationNFDConfiguration : TeaModel {
                            [NameInMap("Enabled")]
                            [Validation(Required=false)]
                            public bool? Enabled { get; set; }
                            [NameInMap("NFDLabelPruned")]
                            [Validation(Required=false)]
                            public bool? NFDLabelPruned { get; set; }
                        };

                        [NameInMap("OPAScopeInjection")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationOPAScopeInjection OPAScopeInjection { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationOPAScopeInjection : TeaModel {
                            [NameInMap("OPAScopeInjected")]
                            [Validation(Required=false)]
                            public bool? OPAScopeInjected { get; set; }
                        };

                        [NameInMap("RateLimit")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationRateLimit RateLimit { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationRateLimit : TeaModel {
                            [NameInMap("EnableGlobalRateLimit")]
                            [Validation(Required=false)]
                            public bool? EnableGlobalRateLimit { get; set; }
                        };

                        [NameInMap("SidecarProxyInitResourceLimit")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationSidecarProxyInitResourceLimit SidecarProxyInitResourceLimit { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationSidecarProxyInitResourceLimit : TeaModel {
                            [NameInMap("ResourceCPULimit")]
                            [Validation(Required=false)]
                            public string ResourceCPULimit { get; set; }
                            [NameInMap("ResourceMemoryLimit")]
                            [Validation(Required=false)]
                            public string ResourceMemoryLimit { get; set; }
                        };

                        [NameInMap("SidecarProxyInitResourceRequest")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationSidecarProxyInitResourceRequest SidecarProxyInitResourceRequest { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigExtraConfigurationSidecarProxyInitResourceRequest : TeaModel {
                            [NameInMap("ResourceCPURequest")]
                            [Validation(Required=false)]
                            public string ResourceCPURequest { get; set; }
                            [NameInMap("ResourceMemoryRequest")]
                            [Validation(Required=false)]
                            public string ResourceMemoryRequest { get; set; }
                        };

                        [NameInMap("TerminationDrainDuration")]
                        [Validation(Required=false)]
                        public string TerminationDrainDuration { get; set; }

                    }
                    [NameInMap("IncludeIPRanges")]
                    [Validation(Required=false)]
                    public string IncludeIPRanges { get; set; }
                    [NameInMap("K8sNewAPIsSupport")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigK8sNewAPIsSupport K8sNewAPIsSupport { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigK8sNewAPIsSupport : TeaModel {
                        [NameInMap("GatewayAPIEnabled")]
                        [Validation(Required=false)]
                        public bool? GatewayAPIEnabled { get; set; }

                    }
                    [NameInMap("Kiali")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigKiali Kiali { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigKiali : TeaModel {
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }
                    [NameInMap("LocalityLB")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigLocalityLB LocalityLB { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigLocalityLB : TeaModel {
                        [NameInMap("Distribute")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> Distribute { get; set; }

                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        [NameInMap("Failover")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> Failover { get; set; }

                    }
                    [NameInMap("MSE")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigMSE MSE { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigMSE : TeaModel {
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                    }
                    [NameInMap("OPA")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigOPA OPA { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigOPA : TeaModel {
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        [NameInMap("LimitCPU")]
                        [Validation(Required=false)]
                        public string LimitCPU { get; set; }

                        [NameInMap("LimitMemory")]
                        [Validation(Required=false)]
                        public string LimitMemory { get; set; }

                        [NameInMap("LogLevel")]
                        [Validation(Required=false)]
                        public string LogLevel { get; set; }

                        [NameInMap("RequestCPU")]
                        [Validation(Required=false)]
                        public string RequestCPU { get; set; }

                        [NameInMap("RequestMemory")]
                        [Validation(Required=false)]
                        public string RequestMemory { get; set; }

                    }
                    [NameInMap("OutboundTrafficPolicy")]
                    [Validation(Required=false)]
                    public string OutboundTrafficPolicy { get; set; }
                    [NameInMap("Pilot")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigPilot Pilot { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigPilot : TeaModel {
                        [NameInMap("ConfigSource")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigPilotConfigSource ConfigSource { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigPilotConfigSource : TeaModel {
                            [NameInMap("Enabled")]
                            [Validation(Required=false)]
                            public bool? Enabled { get; set; }
                            [NameInMap("NacosID")]
                            [Validation(Required=false)]
                            public string NacosID { get; set; }
                        };

                        [NameInMap("Feature")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigPilotFeature Feature { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigPilotFeature : TeaModel {
                            [NameInMap("EnableSDSServer")]
                            [Validation(Required=false)]
                            public bool? EnableSDSServer { get; set; }
                            [NameInMap("FilterGatewayClusterConfig")]
                            [Validation(Required=false)]
                            public bool? FilterGatewayClusterConfig { get; set; }
                        };

                        [NameInMap("Http10Enabled")]
                        [Validation(Required=false)]
                        public bool? Http10Enabled { get; set; }

                        [NameInMap("TraceSampling")]
                        [Validation(Required=false)]
                        public float? TraceSampling { get; set; }

                    }
                    [NameInMap("Prometheus")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigPrometheus Prometheus { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigPrometheus : TeaModel {
                        [NameInMap("ExternalUrl")]
                        [Validation(Required=false)]
                        public string ExternalUrl { get; set; }

                        [NameInMap("UseExternal")]
                        [Validation(Required=false)]
                        public bool? UseExternal { get; set; }

                    }
                    [NameInMap("ProtocolSupport")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigProtocolSupport ProtocolSupport { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigProtocolSupport : TeaModel {
                        [NameInMap("DubboFilterEnabled")]
                        [Validation(Required=false)]
                        public bool? DubboFilterEnabled { get; set; }

                        [NameInMap("MysqlFilterEnabled")]
                        [Validation(Required=false)]
                        public bool? MysqlFilterEnabled { get; set; }

                        [NameInMap("RedisFilterEnabled")]
                        [Validation(Required=false)]
                        public bool? RedisFilterEnabled { get; set; }

                        [NameInMap("ThriftFilterEnabled")]
                        [Validation(Required=false)]
                        public bool? ThriftFilterEnabled { get; set; }

                    }
                    [NameInMap("Proxy")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigProxy Proxy { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigProxy : TeaModel {
                        [NameInMap("AccessLogFile")]
                        [Validation(Required=false)]
                        public string AccessLogFile { get; set; }

                        [NameInMap("AccessLogFormat")]
                        [Validation(Required=false)]
                        public string AccessLogFormat { get; set; }

                        [NameInMap("AccessLogServiceEnabled")]
                        [Validation(Required=false)]
                        public bool? AccessLogServiceEnabled { get; set; }

                        [NameInMap("AccessLogServiceHost")]
                        [Validation(Required=false)]
                        public string AccessLogServiceHost { get; set; }

                        [NameInMap("AccessLogServicePort")]
                        [Validation(Required=false)]
                        public int? AccessLogServicePort { get; set; }

                        [NameInMap("ClusterDomain")]
                        [Validation(Required=false)]
                        public string ClusterDomain { get; set; }

                        [NameInMap("EnableDNSProxying")]
                        [Validation(Required=false)]
                        public bool? EnableDNSProxying { get; set; }

                        [NameInMap("LimitCPU")]
                        [Validation(Required=false)]
                        public string LimitCPU { get; set; }

                        [NameInMap("LimitMemory")]
                        [Validation(Required=false)]
                        public string LimitMemory { get; set; }

                        [NameInMap("RequestCPU")]
                        [Validation(Required=false)]
                        public string RequestCPU { get; set; }

                        [NameInMap("RequestMemory")]
                        [Validation(Required=false)]
                        public string RequestMemory { get; set; }

                    }
                    [NameInMap("SidecarInjector")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigSidecarInjector SidecarInjector { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigSidecarInjector : TeaModel {
                        [NameInMap("AutoInjectionPolicyEnabled")]
                        [Validation(Required=false)]
                        public bool? AutoInjectionPolicyEnabled { get; set; }

                        [NameInMap("EnableNamespacesByDefault")]
                        [Validation(Required=false)]
                        public bool? EnableNamespacesByDefault { get; set; }

                        [NameInMap("InitCNIConfiguration")]
                        [Validation(Required=false)]
                        public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigSidecarInjectorInitCNIConfiguration InitCNIConfiguration { get; set; }
                        public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigSidecarInjectorInitCNIConfiguration : TeaModel {
                            [NameInMap("Enabled")]
                            [Validation(Required=false)]
                            public bool? Enabled { get; set; }
                            [NameInMap("ExcludeNamespaces")]
                            [Validation(Required=false)]
                            public string ExcludeNamespaces { get; set; }
                        };

                        [NameInMap("LimitCPU")]
                        [Validation(Required=false)]
                        public string LimitCPU { get; set; }

                        [NameInMap("LimitMemory")]
                        [Validation(Required=false)]
                        public string LimitMemory { get; set; }

                        [NameInMap("RequestCPU")]
                        [Validation(Required=false)]
                        public string RequestCPU { get; set; }

                        [NameInMap("RequestMemory")]
                        [Validation(Required=false)]
                        public string RequestMemory { get; set; }

                        [NameInMap("SidecarInjectorNum")]
                        [Validation(Required=false)]
                        public int? SidecarInjectorNum { get; set; }

                        [NameInMap("SidecarInjectorWebhookAsYaml")]
                        [Validation(Required=false)]
                        public string SidecarInjectorWebhookAsYaml { get; set; }

                    }
                    [NameInMap("Telemetry")]
                    [Validation(Required=false)]
                    public bool? Telemetry { get; set; }
                    [NameInMap("Tracing")]
                    [Validation(Required=false)]
                    public bool? Tracing { get; set; }
                    [NameInMap("WebAssemblyFilterDeployment")]
                    [Validation(Required=false)]
                    public DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigWebAssemblyFilterDeployment WebAssemblyFilterDeployment { get; set; }
                    public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecMeshConfigWebAssemblyFilterDeployment : TeaModel {
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                    }
                };

                [NameInMap("Network")]
                [Validation(Required=false)]
                public DescribeServiceMeshDetailResponseBodyServiceMeshSpecNetwork Network { get; set; }
                public class DescribeServiceMeshDetailResponseBodyServiceMeshSpecNetwork : TeaModel {
                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }
                    [NameInMap("VSwitches")]
                    [Validation(Required=false)]
                    public List<string> VSwitches { get; set; }
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }
                };

            }
        };

    }

}
