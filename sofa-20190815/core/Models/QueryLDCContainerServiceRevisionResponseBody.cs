// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLDCContainerServiceRevisionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("RevisionList")]
        [Validation(Required=false)]
        public List<QueryLDCContainerServiceRevisionResponseBodyRevisionList> RevisionList { get; set; }
        public class QueryLDCContainerServiceRevisionResponseBodyRevisionList : TeaModel {
            [NameInMap("ContainerServiceName")]
            [Validation(Required=false)]
            public string ContainerServiceName { get; set; }

            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            [NameInMap("DeployStatus")]
            [Validation(Required=false)]
            public string DeployStatus { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("LastPlanId")]
            [Validation(Required=false)]
            public string LastPlanId { get; set; }

            [NameInMap("MetaStatus")]
            [Validation(Required=false)]
            public string MetaStatus { get; set; }

            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("Remarks")]
            [Validation(Required=false)]
            public string Remarks { get; set; }

            [NameInMap("Revision")]
            [Validation(Required=false)]
            public string Revision { get; set; }

            [NameInMap("AppInfo")]
            [Validation(Required=false)]
            public QueryLDCContainerServiceRevisionResponseBodyRevisionListAppInfo AppInfo { get; set; }
            public class QueryLDCContainerServiceRevisionResponseBodyRevisionListAppInfo : TeaModel {
                [NameInMap("BuildpackVersion")]
                [Validation(Required=false)]
                public string BuildpackVersion { get; set; }
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }
                [NameInMap("TechstackIdentity")]
                [Validation(Required=false)]
                public string TechstackIdentity { get; set; }
            };

            [NameInMap("ContainerServiceConfig")]
            [Validation(Required=false)]
            public QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfig ContainerServiceConfig { get; set; }
            public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfig : TeaModel {
                [NameInMap("EnableBizMonitor")]
                [Validation(Required=false)]
                public bool? EnableBizMonitor { get; set; }
                [NameInMap("EnableLogConfig")]
                [Validation(Required=false)]
                public bool? EnableLogConfig { get; set; }
                [NameInMap("EnableSofaMesh")]
                [Validation(Required=false)]
                public bool? EnableSofaMesh { get; set; }
                [NameInMap("UseHostNetwork")]
                [Validation(Required=false)]
                public bool? UseHostNetwork { get; set; }
                [NameInMap("BizMonitorPaths")]
                [Validation(Required=false)]
                public List<string> BizMonitorPaths { get; set; }
                [NameInMap("ClusterIpServices")]
                [Validation(Required=false)]
                public List<QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigClusterIpServices> ClusterIpServices { get; set; }
                public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigClusterIpServices : TeaModel {
                    public string Name { get; set; }
                    public List<QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigClusterIpServicesPorts> Ports { get; set; }
                    public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigClusterIpServicesPorts : TeaModel {
                        public long? Port { get; set; }
                        public string Protocol { get; set; }
                        public long? TargetPort { get; set; }
                    }
                }
                [NameInMap("ContainerSpecs")]
                [Validation(Required=false)]
                public List<QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecs> ContainerSpecs { get; set; }
                public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecs : TeaModel {
                    public string CpuLimit { get; set; }
                    public string CpuRequest { get; set; }
                    public string Image { get; set; }
                    public string ImageBuildName { get; set; }
                    public string ImagePullSecret { get; set; }
                    public string ImageSource { get; set; }
                    public string MemoryLimit { get; set; }
                    public string MemoryRequest { get; set; }
                    public string Name { get; set; }
                    public string RestartPolicy { get; set; }
                    public string Type { get; set; }
                    public string VolumesStr { get; set; }
                    public string VolumeMountsStr { get; set; }
                    public List<string> EntryPoints { get; set; }
                    public List<QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsEnvs> Envs { get; set; }
                    public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsEnvs : TeaModel {
                        public string Name { get; set; }
                        public string Type { get; set; }
                        public string Value { get; set; }
                        public QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsEnvsValueFrom ValueFrom { get; set; }
                        public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsEnvsValueFrom : TeaModel {
                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            [NameInMap("ObjectName")]
                            [Validation(Required=false)]
                            public string ObjectName { get; set; }

                            [NameInMap("ObjectType")]
                            [Validation(Required=false)]
                            public string ObjectType { get; set; }

                        }
                    }
                    public List<QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsEnvOverrides> EnvOverrides { get; set; }
                    public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsEnvOverrides : TeaModel {
                        public string Cell { get; set; }
                        public string Name { get; set; }
                        public string Value { get; set; }
                    }
                    public List<QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsLogConfigs> LogConfigs { get; set; }
                    public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsLogConfigs : TeaModel {
                        public string ConfigName { get; set; }
                        public string InputType { get; set; }
                        public string LogstoreName { get; set; }
                        public string LogPath { get; set; }
                    }
                    public List<QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsVolumeMounts> VolumeMounts { get; set; }
                    public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsVolumeMounts : TeaModel {
                        public string MountPath { get; set; }
                        public string Name { get; set; }
                        public bool? ReadOnly { get; set; }
                        public string SubPath { get; set; }
                        public string VolumeSourceCategoryType { get; set; }
                        public QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsVolumeMountsConfigmapSecretVolumeSource ConfigmapSecretVolumeSource { get; set; }
                        public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsVolumeMountsConfigmapSecretVolumeSource : TeaModel {
                            [NameInMap("VolumeRefName")]
                            [Validation(Required=false)]
                            public string VolumeRefName { get; set; }

                        }
                        public QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsVolumeMountsEmptyDirVolumeSource EmptyDirVolumeSource { get; set; }
                        public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsVolumeMountsEmptyDirVolumeSource : TeaModel {
                            [NameInMap("Medium")]
                            [Validation(Required=false)]
                            public string Medium { get; set; }

                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            [NameInMap("SizeLimit")]
                            [Validation(Required=false)]
                            public string SizeLimit { get; set; }

                        }
                        public QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsVolumeMountsLocalDiskVolumeSource LocalDiskVolumeSource { get; set; }
                        public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsVolumeMountsLocalDiskVolumeSource : TeaModel {
                            [NameInMap("CreateIfNotPresent")]
                            [Validation(Required=false)]
                            public bool? CreateIfNotPresent { get; set; }

                            [NameInMap("HostDirectoryPath")]
                            [Validation(Required=false)]
                            public string HostDirectoryPath { get; set; }

                        }
                        public QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsVolumeMountsPvcSource PvcSource { get; set; }
                        public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsVolumeMountsPvcSource : TeaModel {
                            [NameInMap("PvcName")]
                            [Validation(Required=false)]
                            public string PvcName { get; set; }

                        }
                    }
                    public QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsHealthCheckConfig HealthCheckConfig { get; set; }
                    public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsHealthCheckConfig : TeaModel {
                        [NameInMap("LivenessProbe")]
                        [Validation(Required=false)]
                        public QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsHealthCheckConfigLivenessProbe LivenessProbe { get; set; }
                        public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsHealthCheckConfigLivenessProbe : TeaModel {
                            [NameInMap("FailureThreshold")]
                            [Validation(Required=false)]
                            public long? FailureThreshold { get; set; }
                            [NameInMap("InitialDelaySeconds")]
                            [Validation(Required=false)]
                            public long? InitialDelaySeconds { get; set; }
                            [NameInMap("PeriodSeconds")]
                            [Validation(Required=false)]
                            public long? PeriodSeconds { get; set; }
                            [NameInMap("SuccessThreshold")]
                            [Validation(Required=false)]
                            public long? SuccessThreshold { get; set; }
                            [NameInMap("TimeOutSeconds")]
                            [Validation(Required=false)]
                            public long? TimeOutSeconds { get; set; }
                            [NameInMap("ExecAction")]
                            [Validation(Required=false)]
                            public QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsHealthCheckConfigLivenessProbeExecAction ExecAction { get; set; }
                            public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsHealthCheckConfigLivenessProbeExecAction : TeaModel {
                                [NameInMap("Command")]
                                [Validation(Required=false)]
                                public string Command { get; set; }

                            }
                            [NameInMap("HttpGetAction")]
                            [Validation(Required=false)]
                            public QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsHealthCheckConfigLivenessProbeHttpGetAction HttpGetAction { get; set; }
                            public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsHealthCheckConfigLivenessProbeHttpGetAction : TeaModel {
                                [NameInMap("Path")]
                                [Validation(Required=false)]
                                public string Path { get; set; }

                                [NameInMap("Port")]
                                [Validation(Required=false)]
                                public string Port { get; set; }

                                [NameInMap("Scheme")]
                                [Validation(Required=false)]
                                public string Scheme { get; set; }

                            }
                            [NameInMap("TcpSocketAction")]
                            [Validation(Required=false)]
                            public QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsHealthCheckConfigLivenessProbeTcpSocketAction TcpSocketAction { get; set; }
                            public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsHealthCheckConfigLivenessProbeTcpSocketAction : TeaModel {
                                [NameInMap("Port")]
                                [Validation(Required=false)]
                                public string Port { get; set; }

                            }
                        };

                        [NameInMap("ReadinessProbe")]
                        [Validation(Required=false)]
                        public QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsHealthCheckConfigReadinessProbe ReadinessProbe { get; set; }
                        public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsHealthCheckConfigReadinessProbe : TeaModel {
                            [NameInMap("FailureThreshold")]
                            [Validation(Required=false)]
                            public long? FailureThreshold { get; set; }
                            [NameInMap("InitialDelaySeconds")]
                            [Validation(Required=false)]
                            public long? InitialDelaySeconds { get; set; }
                            [NameInMap("PeriodSeconds")]
                            [Validation(Required=false)]
                            public long? PeriodSeconds { get; set; }
                            [NameInMap("SuccessThreshold")]
                            [Validation(Required=false)]
                            public long? SuccessThreshold { get; set; }
                            [NameInMap("TimeOutSeconds")]
                            [Validation(Required=false)]
                            public long? TimeOutSeconds { get; set; }
                            [NameInMap("ExecAction")]
                            [Validation(Required=false)]
                            public QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsHealthCheckConfigReadinessProbeExecAction ExecAction { get; set; }
                            public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsHealthCheckConfigReadinessProbeExecAction : TeaModel {
                                [NameInMap("Command")]
                                [Validation(Required=false)]
                                public string Command { get; set; }

                            }
                            [NameInMap("HttpGetAction")]
                            [Validation(Required=false)]
                            public QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsHealthCheckConfigReadinessProbeHttpGetAction HttpGetAction { get; set; }
                            public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsHealthCheckConfigReadinessProbeHttpGetAction : TeaModel {
                                [NameInMap("Path")]
                                [Validation(Required=false)]
                                public string Path { get; set; }

                                [NameInMap("Port")]
                                [Validation(Required=false)]
                                public string Port { get; set; }

                                [NameInMap("Scheme")]
                                [Validation(Required=false)]
                                public string Scheme { get; set; }

                            }
                            [NameInMap("TcpSocketAction")]
                            [Validation(Required=false)]
                            public QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsHealthCheckConfigReadinessProbeTcpSocketAction TcpSocketAction { get; set; }
                            public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsHealthCheckConfigReadinessProbeTcpSocketAction : TeaModel {
                                [NameInMap("Port")]
                                [Validation(Required=false)]
                                public string Port { get; set; }

                            }
                        };

                    }
                    public QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsLifecycleHook LifecycleHook { get; set; }
                    public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsLifecycleHook : TeaModel {
                        [NameInMap("PostStartExec")]
                        [Validation(Required=false)]
                        public QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsLifecycleHookPostStartExec PostStartExec { get; set; }
                        public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsLifecycleHookPostStartExec : TeaModel {
                            [NameInMap("Command")]
                            [Validation(Required=false)]
                            public string Command { get; set; }
                        };

                        [NameInMap("PostStartHttp")]
                        [Validation(Required=false)]
                        public QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsLifecycleHookPostStartHttp PostStartHttp { get; set; }
                        public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsLifecycleHookPostStartHttp : TeaModel {
                            [NameInMap("Path")]
                            [Validation(Required=false)]
                            public string Path { get; set; }
                            [NameInMap("Port")]
                            [Validation(Required=false)]
                            public string Port { get; set; }
                            [NameInMap("Scheme")]
                            [Validation(Required=false)]
                            public string Scheme { get; set; }
                        };

                        [NameInMap("PostStartTcp")]
                        [Validation(Required=false)]
                        public QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsLifecycleHookPostStartTcp PostStartTcp { get; set; }
                        public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsLifecycleHookPostStartTcp : TeaModel {
                            [NameInMap("Port")]
                            [Validation(Required=false)]
                            public string Port { get; set; }
                        };

                        [NameInMap("PreStopExec")]
                        [Validation(Required=false)]
                        public QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsLifecycleHookPreStopExec PreStopExec { get; set; }
                        public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsLifecycleHookPreStopExec : TeaModel {
                            [NameInMap("Command")]
                            [Validation(Required=false)]
                            public string Command { get; set; }
                        };

                        [NameInMap("PreStopHttp")]
                        [Validation(Required=false)]
                        public QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsLifecycleHookPreStopHttp PreStopHttp { get; set; }
                        public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsLifecycleHookPreStopHttp : TeaModel {
                            [NameInMap("Path")]
                            [Validation(Required=false)]
                            public string Path { get; set; }
                            [NameInMap("Port")]
                            [Validation(Required=false)]
                            public string Port { get; set; }
                            [NameInMap("Scheme")]
                            [Validation(Required=false)]
                            public string Scheme { get; set; }
                        };

                        [NameInMap("PreStopTcp")]
                        [Validation(Required=false)]
                        public QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsLifecycleHookPreStopTcp PreStopTcp { get; set; }
                        public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigContainerSpecsLifecycleHookPreStopTcp : TeaModel {
                            [NameInMap("Port")]
                            [Validation(Required=false)]
                            public string Port { get; set; }
                        };

                    }
                }
                [NameInMap("Ingresses")]
                [Validation(Required=false)]
                public List<QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigIngresses> Ingresses { get; set; }
                public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigIngresses : TeaModel {
                    public string Domain { get; set; }
                    public string LoadBalancerIaasId { get; set; }
                    public string LoadBalancerName { get; set; }
                    public string LoadBalancerType { get; set; }
                    public string Name { get; set; }
                    public string SpannerClusterId { get; set; }
                    public string UnifiedAccessInstanceName { get; set; }
                    public string UnifiedAccessRouteRule { get; set; }
                    public List<string> UnifiedAccessEntries { get; set; }
                    public List<QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigIngressesListeners> Listeners { get; set; }
                    public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigIngressesListeners : TeaModel {
                        public long? BackendServerPort { get; set; }
                        public long? BandWidth { get; set; }
                        public string CaCertificateId { get; set; }
                        public string Cookie { get; set; }
                        public long? CookieTimeout { get; set; }
                        public string Domain { get; set; }
                        public long? EstablishedTimeout { get; set; }
                        public long? HealthyThreshold { get; set; }
                        public string HealthCheck { get; set; }
                        public long? HealthCheckConnectPort { get; set; }
                        public long? HealthCheckConnectTimeout { get; set; }
                        public string HealthCheckDomain { get; set; }
                        public string HealthCheckHttpCode { get; set; }
                        public long? HealthCheckInterval { get; set; }
                        public long? HealthCheckThreshold { get; set; }
                        public long? HealthCheckTimeout { get; set; }
                        public string HealthCheckUri { get; set; }
                        public long? ListenerPort { get; set; }
                        public string Path { get; set; }
                        public long? PersistenceTimeout { get; set; }
                        public string Protocol { get; set; }
                        public string Scheduler { get; set; }
                        public long? SessionStickyType { get; set; }
                        public long? UnhealthyThreshold { get; set; }
                        public bool? XforwardFor { get; set; }
                    }
                    public List<QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigIngressesListenersV2> ListenersV2 { get; set; }
                    public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigIngressesListenersV2 : TeaModel {
                        public long? BackendServerPort { get; set; }
                        public long? BandWidth { get; set; }
                        public string CaCertificateId { get; set; }
                        public string Cookie { get; set; }
                        public long? CookieTimeout { get; set; }
                        public string Domain { get; set; }
                        public long? EstablishedTimeout { get; set; }
                        public long? HealthyThreshold { get; set; }
                        public string HealthCheck { get; set; }
                        public long? HealthCheckConnectPort { get; set; }
                        public long? HealthCheckConnectTimeout { get; set; }
                        public string HealthCheckDomain { get; set; }
                        public string HealthCheckHttpCode { get; set; }
                        public long? HealthCheckInterval { get; set; }
                        public long? HealthCheckThreshold { get; set; }
                        public long? HealthCheckTimeout { get; set; }
                        public string HealthCheckUri { get; set; }
                        public long? ListenerPort { get; set; }
                        public string Path { get; set; }
                        public long? PersistenceTimeout { get; set; }
                        public string Protocol { get; set; }
                        public string Scheduler { get; set; }
                        public long? SessionStickyType { get; set; }
                        public long? UnhealthyThreshold { get; set; }
                        public bool? XforwardFor { get; set; }
                    }
                }
                [NameInMap("InnerLoadBalancerServices")]
                [Validation(Required=false)]
                public List<QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigInnerLoadBalancerServices> InnerLoadBalancerServices { get; set; }
                public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigInnerLoadBalancerServices : TeaModel {
                    public string AddressType { get; set; }
                    public string Domain { get; set; }
                    public string LoadBalancerIaasId { get; set; }
                    public string LoadBalancerName { get; set; }
                    public string Name { get; set; }
                    public string SpannerClusterId { get; set; }
                    public List<QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigInnerLoadBalancerServicesCellSlbIaasIdMap> CellSlbIaasIdMap { get; set; }
                    public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigInnerLoadBalancerServicesCellSlbIaasIdMap : TeaModel {
                        public string Key { get; set; }
                        public string Value { get; set; }
                    }
                    public List<QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigInnerLoadBalancerServicesListeners> Listeners { get; set; }
                    public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigInnerLoadBalancerServicesListeners : TeaModel {
                        public long? BackendServerPort { get; set; }
                        public long? BandWidth { get; set; }
                        public string CaCertificateId { get; set; }
                        public string Cookie { get; set; }
                        public long? CookieTimeout { get; set; }
                        public string Domain { get; set; }
                        public long? EstablishedTimeout { get; set; }
                        public long? HealthyThreshold { get; set; }
                        public string HealthCheck { get; set; }
                        public long? HealthCheckConnectPort { get; set; }
                        public long? HealthCheckConnectTimeout { get; set; }
                        public string HealthCheckDomain { get; set; }
                        public string HealthCheckHttpCode { get; set; }
                        public long? HealthCheckInterval { get; set; }
                        public long? HealthCheckThreshold { get; set; }
                        public long? HealthCheckTimeout { get; set; }
                        public string HealthCheckUri { get; set; }
                        public long? ListenerPort { get; set; }
                        public string Path { get; set; }
                        public long? PersistenceTimeout { get; set; }
                        public string Protocol { get; set; }
                        public string Scheduler { get; set; }
                        public long? SessionStickyType { get; set; }
                        public long? UnhealthyThreshold { get; set; }
                        public bool? XforwardFor { get; set; }
                    }
                }
                [NameInMap("LoadBalancerServices")]
                [Validation(Required=false)]
                public List<QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigLoadBalancerServices> LoadBalancerServices { get; set; }
                public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigLoadBalancerServices : TeaModel {
                    public string AddressType { get; set; }
                    public string Domain { get; set; }
                    public string LoadBalancerIaasId { get; set; }
                    public string LoadBalancerName { get; set; }
                    public string Name { get; set; }
                    public string SpannerClusterId { get; set; }
                    public List<QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigLoadBalancerServicesCellSlbIaasIdMap> CellSlbIaasIdMap { get; set; }
                    public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigLoadBalancerServicesCellSlbIaasIdMap : TeaModel {
                        public string Key { get; set; }
                        public string Value { get; set; }
                    }
                    public List<QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigLoadBalancerServicesListeners> Listeners { get; set; }
                    public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigLoadBalancerServicesListeners : TeaModel {
                        public long? BackendServerPort { get; set; }
                        public long? BandWidth { get; set; }
                        public string CaCertificateId { get; set; }
                        public string Cookie { get; set; }
                        public long? CookieTimeout { get; set; }
                        public string Domain { get; set; }
                        public long? EstablishedTimeout { get; set; }
                        public long? HealthyThreshold { get; set; }
                        public string HealthCheck { get; set; }
                        public long? HealthCheckConnectPort { get; set; }
                        public long? HealthCheckConnectTimeout { get; set; }
                        public string HealthCheckDomain { get; set; }
                        public string HealthCheckHttpCode { get; set; }
                        public long? HealthCheckInterval { get; set; }
                        public long? HealthCheckThreshold { get; set; }
                        public long? HealthCheckTimeout { get; set; }
                        public string HealthCheckUri { get; set; }
                        public long? ListenerPort { get; set; }
                        public string Path { get; set; }
                        public long? PersistenceTimeout { get; set; }
                        public string Protocol { get; set; }
                        public string Scheduler { get; set; }
                        public long? SessionStickyType { get; set; }
                        public long? UnhealthyThreshold { get; set; }
                        public bool? XforwardFor { get; set; }
                    }
                }
                [NameInMap("PublicLoadBalancerServices")]
                [Validation(Required=false)]
                public List<QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigPublicLoadBalancerServices> PublicLoadBalancerServices { get; set; }
                public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigPublicLoadBalancerServices : TeaModel {
                    public string AddressType { get; set; }
                    public string Domain { get; set; }
                    public string LoadBalancerIaasId { get; set; }
                    public string LoadBalancerName { get; set; }
                    public string Name { get; set; }
                    public string SpannerClusterId { get; set; }
                    public List<QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigPublicLoadBalancerServicesCellSlbIaasIdMap> CellSlbIaasIdMap { get; set; }
                    public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigPublicLoadBalancerServicesCellSlbIaasIdMap : TeaModel {
                        public string Key { get; set; }
                        public string Value { get; set; }
                    }
                    public List<QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigPublicLoadBalancerServicesListeners> Listeners { get; set; }
                    public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigPublicLoadBalancerServicesListeners : TeaModel {
                        public long? BackendServerPort { get; set; }
                        public long? BandWidth { get; set; }
                        public string CaCertificateId { get; set; }
                        public string Cookie { get; set; }
                        public long? CookieTimeout { get; set; }
                        public string Domain { get; set; }
                        public long? EstablishedTimeout { get; set; }
                        public long? HealthyThreshold { get; set; }
                        public string HealthCheck { get; set; }
                        public long? HealthCheckConnectPort { get; set; }
                        public long? HealthCheckConnectTimeout { get; set; }
                        public string HealthCheckDomain { get; set; }
                        public string HealthCheckHttpCode { get; set; }
                        public long? HealthCheckInterval { get; set; }
                        public long? HealthCheckThreshold { get; set; }
                        public long? HealthCheckTimeout { get; set; }
                        public string HealthCheckUri { get; set; }
                        public long? ListenerPort { get; set; }
                        public string Path { get; set; }
                        public long? PersistenceTimeout { get; set; }
                        public string Protocol { get; set; }
                        public string Scheduler { get; set; }
                        public long? SessionStickyType { get; set; }
                        public long? UnhealthyThreshold { get; set; }
                        public bool? XforwardFor { get; set; }
                    }
                }
                [NameInMap("SidecarConfigs")]
                [Validation(Required=false)]
                public List<QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigSidecarConfigs> SidecarConfigs { get; set; }
                public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigSidecarConfigs : TeaModel {
                    public string Id { get; set; }
                    public string RegionId { get; set; }
                    public string Scope { get; set; }
                    public string SidecarName { get; set; }
                    public string SidecarVersion { get; set; }
                    public string Template { get; set; }
                    public string Type { get; set; }
                    public string WorkspaceGroupId { get; set; }
                    public string WorkspaceId { get; set; }
                }
                [NameInMap("DeployConfig")]
                [Validation(Required=false)]
                public QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigDeployConfig DeployConfig { get; set; }
                public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigDeployConfig : TeaModel {
                    [NameInMap("Annotations")]
                    [Validation(Required=false)]
                    public string Annotations { get; set; }

                    [NameInMap("CustomLabels")]
                    [Validation(Required=false)]
                    public string CustomLabels { get; set; }

                    [NameInMap("EnableSofaMesh")]
                    [Validation(Required=false)]
                    public bool? EnableSofaMesh { get; set; }

                    [NameInMap("GroupCount")]
                    [Validation(Required=false)]
                    public long? GroupCount { get; set; }

                    [NameInMap("GroupStrategy")]
                    [Validation(Required=false)]
                    public string GroupStrategy { get; set; }

                    [NameInMap("Labels")]
                    [Validation(Required=false)]
                    public string Labels { get; set; }

                    [NameInMap("MaxGroupCapacity")]
                    [Validation(Required=false)]
                    public long? MaxGroupCapacity { get; set; }

                    [NameInMap("NeedBeta")]
                    [Validation(Required=false)]
                    public bool? NeedBeta { get; set; }

                    [NameInMap("NeedConfirm")]
                    [Validation(Required=false)]
                    public bool? NeedConfirm { get; set; }

                    [NameInMap("Affinity")]
                    [Validation(Required=false)]
                    public QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigDeployConfigAffinity Affinity { get; set; }
                    public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigDeployConfigAffinity : TeaModel {
                        [NameInMap("NodeAffinity")]
                        [Validation(Required=false)]
                        public List<QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigDeployConfigAffinityNodeAffinity> NodeAffinity { get; set; }
                        public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigDeployConfigAffinityNodeAffinity : TeaModel {
                            public bool? Requested { get; set; }
                            public long? Weight { get; set; }
                            public List<QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigDeployConfigAffinityNodeAffinityMatchExpressions> MatchExpressions { get; set; }
                            public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigDeployConfigAffinityNodeAffinityMatchExpressions : TeaModel {
                                public string Key { get; set; }
                                public string Operator { get; set; }
                                public List<string> Values { get; set; }
                            }
                        }
                        [NameInMap("PodAffinity")]
                        [Validation(Required=false)]
                        public List<QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigDeployConfigAffinityPodAffinity> PodAffinity { get; set; }
                        public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigDeployConfigAffinityPodAffinity : TeaModel {
                            public bool? AntiAffinity { get; set; }
                            public bool? Requested { get; set; }
                            public long? Weight { get; set; }
                            public QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigDeployConfigAffinityPodAffinityPodAffinityTerm PodAffinityTerm { get; set; }
                            public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigDeployConfigAffinityPodAffinityPodAffinityTerm : TeaModel {
                                [NameInMap("TopologyKey")]
                                [Validation(Required=false)]
                                public string TopologyKey { get; set; }

                                [NameInMap("Namespaces")]
                                [Validation(Required=false)]
                                public List<string> Namespaces { get; set; }

                                [NameInMap("LabelSelector")]
                                [Validation(Required=false)]
                                public List<QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigDeployConfigAffinityPodAffinityPodAffinityTermLabelSelector> LabelSelector { get; set; }
                                public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigDeployConfigAffinityPodAffinityPodAffinityTermLabelSelector : TeaModel {
                                    [NameInMap("Key")]
                                    [Validation(Required=false)]
                                    public string Key { get; set; }

                                    [NameInMap("Value")]
                                    [Validation(Required=false)]
                                    public string Value { get; set; }

                                }

                            }
                        }
                    };

                }
                [NameInMap("ElasticConfig")]
                [Validation(Required=false)]
                public QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigElasticConfig ElasticConfig { get; set; }
                public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigElasticConfig : TeaModel {
                    [NameInMap("FixedReplica")]
                    [Validation(Required=false)]
                    public QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigElasticConfigFixedReplica FixedReplica { get; set; }
                    public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigElasticConfigFixedReplica : TeaModel {
                        [NameInMap("Replicas")]
                        [Validation(Required=false)]
                        public List<QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigElasticConfigFixedReplicaReplicas> Replicas { get; set; }
                        public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceConfigElasticConfigFixedReplicaReplicas : TeaModel {
                            public long? Count { get; set; }
                            public string Name { get; set; }
                            public string Type { get; set; }
                        }
                    };

                }
            };

            [NameInMap("ContainerServiceReleaseInfo")]
            [Validation(Required=false)]
            public QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceReleaseInfo ContainerServiceReleaseInfo { get; set; }
            public class QueryLDCContainerServiceRevisionResponseBodyRevisionListContainerServiceReleaseInfo : TeaModel {
                [NameInMap("CreatedPlanId")]
                [Validation(Required=false)]
                public string CreatedPlanId { get; set; }
                [NameInMap("LatestDeploymentEndTime")]
                [Validation(Required=false)]
                public string LatestDeploymentEndTime { get; set; }
                [NameInMap("LatestDeploymentStartTime")]
                [Validation(Required=false)]
                public string LatestDeploymentStartTime { get; set; }
            };

        }

    }

}
