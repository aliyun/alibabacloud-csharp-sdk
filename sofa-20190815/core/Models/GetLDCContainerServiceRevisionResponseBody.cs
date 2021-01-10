// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLDCContainerServiceRevisionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Revision")]
        [Validation(Required=false)]
        public GetLDCContainerServiceRevisionResponseBodyRevision Revision { get; set; }
        public class GetLDCContainerServiceRevisionResponseBodyRevision : TeaModel {
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
            public GetLDCContainerServiceRevisionResponseBodyRevisionAppInfo AppInfo { get; set; }
            public class GetLDCContainerServiceRevisionResponseBodyRevisionAppInfo : TeaModel {
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

            }
            [NameInMap("ContainerServiceConfig")]
            [Validation(Required=false)]
            public GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfig ContainerServiceConfig { get; set; }
            public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfig : TeaModel {
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
                public List<GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigClusterIpServices> ClusterIpServices { get; set; }
                public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigClusterIpServices : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Ports")]
                    [Validation(Required=false)]
                    public List<GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigClusterIpServicesPorts> Ports { get; set; }
                    public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigClusterIpServicesPorts : TeaModel {
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public long? Port { get; set; }

                        [NameInMap("Protocol")]
                        [Validation(Required=false)]
                        public string Protocol { get; set; }

                        [NameInMap("TargetPort")]
                        [Validation(Required=false)]
                        public long? TargetPort { get; set; }

                    }

                }

                [NameInMap("ContainerSpecs")]
                [Validation(Required=false)]
                public List<GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecs> ContainerSpecs { get; set; }
                public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecs : TeaModel {
                    [NameInMap("CpuLimit")]
                    [Validation(Required=false)]
                    public string CpuLimit { get; set; }

                    [NameInMap("CpuRequest")]
                    [Validation(Required=false)]
                    public string CpuRequest { get; set; }

                    [NameInMap("Image")]
                    [Validation(Required=false)]
                    public string Image { get; set; }

                    [NameInMap("ImageBuildName")]
                    [Validation(Required=false)]
                    public string ImageBuildName { get; set; }

                    [NameInMap("ImagePullSecret")]
                    [Validation(Required=false)]
                    public string ImagePullSecret { get; set; }

                    [NameInMap("ImageSource")]
                    [Validation(Required=false)]
                    public string ImageSource { get; set; }

                    [NameInMap("MemoryLimit")]
                    [Validation(Required=false)]
                    public string MemoryLimit { get; set; }

                    [NameInMap("MemoryRequest")]
                    [Validation(Required=false)]
                    public string MemoryRequest { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("RestartPolicy")]
                    [Validation(Required=false)]
                    public string RestartPolicy { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("VolumesStr")]
                    [Validation(Required=false)]
                    public string VolumesStr { get; set; }

                    [NameInMap("VolumeMountsStr")]
                    [Validation(Required=false)]
                    public string VolumeMountsStr { get; set; }

                    [NameInMap("EntryPoints")]
                    [Validation(Required=false)]
                    public List<string> EntryPoints { get; set; }

                    [NameInMap("Envs")]
                    [Validation(Required=false)]
                    public List<GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsEnvs> Envs { get; set; }
                    public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsEnvs : TeaModel {
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                        [NameInMap("ValueFrom")]
                        [Validation(Required=false)]
                        public GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsEnvsValueFrom ValueFrom { get; set; }
                        public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsEnvsValueFrom : TeaModel {
                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }
                            [NameInMap("ObjectName")]
                            [Validation(Required=false)]
                            public string ObjectName { get; set; }
                            [NameInMap("ObjectType")]
                            [Validation(Required=false)]
                            public string ObjectType { get; set; }
                        };

                    }

                    [NameInMap("EnvOverrides")]
                    [Validation(Required=false)]
                    public List<GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsEnvOverrides> EnvOverrides { get; set; }
                    public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsEnvOverrides : TeaModel {
                        [NameInMap("Cell")]
                        [Validation(Required=false)]
                        public string Cell { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("LogConfigs")]
                    [Validation(Required=false)]
                    public List<GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLogConfigs> LogConfigs { get; set; }
                    public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLogConfigs : TeaModel {
                        [NameInMap("ConfigName")]
                        [Validation(Required=false)]
                        public string ConfigName { get; set; }

                        [NameInMap("InputType")]
                        [Validation(Required=false)]
                        public string InputType { get; set; }

                        [NameInMap("LogstoreName")]
                        [Validation(Required=false)]
                        public string LogstoreName { get; set; }

                        [NameInMap("LogPath")]
                        [Validation(Required=false)]
                        public string LogPath { get; set; }

                    }

                    [NameInMap("VolumeMounts")]
                    [Validation(Required=false)]
                    public List<GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsVolumeMounts> VolumeMounts { get; set; }
                    public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsVolumeMounts : TeaModel {
                        [NameInMap("MountPath")]
                        [Validation(Required=false)]
                        public string MountPath { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("ReadOnly")]
                        [Validation(Required=false)]
                        public bool? ReadOnly { get; set; }

                        [NameInMap("SubPath")]
                        [Validation(Required=false)]
                        public string SubPath { get; set; }

                        [NameInMap("VolumeSourceCategoryType")]
                        [Validation(Required=false)]
                        public string VolumeSourceCategoryType { get; set; }

                        [NameInMap("ConfigmapSecretVolumeSource")]
                        [Validation(Required=false)]
                        public GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsVolumeMountsConfigmapSecretVolumeSource ConfigmapSecretVolumeSource { get; set; }
                        public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsVolumeMountsConfigmapSecretVolumeSource : TeaModel {
                            [NameInMap("VolumeRefName")]
                            [Validation(Required=false)]
                            public string VolumeRefName { get; set; }
                        };

                        [NameInMap("EmptyDirVolumeSource")]
                        [Validation(Required=false)]
                        public GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsVolumeMountsEmptyDirVolumeSource EmptyDirVolumeSource { get; set; }
                        public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsVolumeMountsEmptyDirVolumeSource : TeaModel {
                            [NameInMap("Medium")]
                            [Validation(Required=false)]
                            public string Medium { get; set; }
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }
                            [NameInMap("SizeLimit")]
                            [Validation(Required=false)]
                            public string SizeLimit { get; set; }
                        };

                        [NameInMap("LocalDiskVolumeSource")]
                        [Validation(Required=false)]
                        public GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsVolumeMountsLocalDiskVolumeSource LocalDiskVolumeSource { get; set; }
                        public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsVolumeMountsLocalDiskVolumeSource : TeaModel {
                            [NameInMap("CreateIfNotPresent")]
                            [Validation(Required=false)]
                            public bool? CreateIfNotPresent { get; set; }
                            [NameInMap("HostDirectoryPath")]
                            [Validation(Required=false)]
                            public string HostDirectoryPath { get; set; }
                        };

                        [NameInMap("PvcSource")]
                        [Validation(Required=false)]
                        public GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsVolumeMountsPvcSource PvcSource { get; set; }
                        public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsVolumeMountsPvcSource : TeaModel {
                            [NameInMap("PvcName")]
                            [Validation(Required=false)]
                            public string PvcName { get; set; }
                        };

                    }

                    [NameInMap("HealthCheckConfig")]
                    [Validation(Required=false)]
                    public GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfig HealthCheckConfig { get; set; }
                    public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfig : TeaModel {
                        [NameInMap("LivenessProbe")]
                        [Validation(Required=false)]
                        public GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigLivenessProbe LivenessProbe { get; set; }
                        public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigLivenessProbe : TeaModel {
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
                            public GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigLivenessProbeExecAction ExecAction { get; set; }
                            public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigLivenessProbeExecAction : TeaModel {
                                [NameInMap("Command")]
                                [Validation(Required=false)]
                                public string Command { get; set; }
                            };

                            [NameInMap("HttpGetAction")]
                            [Validation(Required=false)]
                            public GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigLivenessProbeHttpGetAction HttpGetAction { get; set; }
                            public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigLivenessProbeHttpGetAction : TeaModel {
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

                            [NameInMap("TcpSocketAction")]
                            [Validation(Required=false)]
                            public GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigLivenessProbeTcpSocketAction TcpSocketAction { get; set; }
                            public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigLivenessProbeTcpSocketAction : TeaModel {
                                [NameInMap("Port")]
                                [Validation(Required=false)]
                                public string Port { get; set; }
                            };

                        }
                        [NameInMap("ReadinessProbe")]
                        [Validation(Required=false)]
                        public GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigReadinessProbe ReadinessProbe { get; set; }
                        public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigReadinessProbe : TeaModel {
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
                            public GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigReadinessProbeExecAction ExecAction { get; set; }
                            public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigReadinessProbeExecAction : TeaModel {
                                [NameInMap("Command")]
                                [Validation(Required=false)]
                                public string Command { get; set; }
                            };

                            [NameInMap("HttpGetAction")]
                            [Validation(Required=false)]
                            public GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigReadinessProbeHttpGetAction HttpGetAction { get; set; }
                            public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigReadinessProbeHttpGetAction : TeaModel {
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

                            [NameInMap("TcpSocketAction")]
                            [Validation(Required=false)]
                            public GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigReadinessProbeTcpSocketAction TcpSocketAction { get; set; }
                            public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigReadinessProbeTcpSocketAction : TeaModel {
                                [NameInMap("Port")]
                                [Validation(Required=false)]
                                public string Port { get; set; }
                            };

                        }
                    };

                    [NameInMap("LifecycleHook")]
                    [Validation(Required=false)]
                    public GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLifecycleHook LifecycleHook { get; set; }
                    public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLifecycleHook : TeaModel {
                        [NameInMap("PostStartExec")]
                        [Validation(Required=false)]
                        public GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLifecycleHookPostStartExec PostStartExec { get; set; }
                        public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLifecycleHookPostStartExec : TeaModel {
                            [NameInMap("Command")]
                            [Validation(Required=false)]
                            public string Command { get; set; }

                        }
                        [NameInMap("PostStartHttp")]
                        [Validation(Required=false)]
                        public GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLifecycleHookPostStartHttp PostStartHttp { get; set; }
                        public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLifecycleHookPostStartHttp : TeaModel {
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
                        [NameInMap("PostStartTcp")]
                        [Validation(Required=false)]
                        public GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLifecycleHookPostStartTcp PostStartTcp { get; set; }
                        public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLifecycleHookPostStartTcp : TeaModel {
                            [NameInMap("Port")]
                            [Validation(Required=false)]
                            public string Port { get; set; }

                        }
                        [NameInMap("PreStopExec")]
                        [Validation(Required=false)]
                        public GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLifecycleHookPreStopExec PreStopExec { get; set; }
                        public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLifecycleHookPreStopExec : TeaModel {
                            [NameInMap("Command")]
                            [Validation(Required=false)]
                            public string Command { get; set; }

                        }
                        [NameInMap("PreStopHttp")]
                        [Validation(Required=false)]
                        public GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLifecycleHookPreStopHttp PreStopHttp { get; set; }
                        public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLifecycleHookPreStopHttp : TeaModel {
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
                        [NameInMap("PreStopTcp")]
                        [Validation(Required=false)]
                        public GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLifecycleHookPreStopTcp PreStopTcp { get; set; }
                        public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLifecycleHookPreStopTcp : TeaModel {
                            [NameInMap("Port")]
                            [Validation(Required=false)]
                            public string Port { get; set; }

                        }
                    };

                }

                [NameInMap("Ingresses")]
                [Validation(Required=false)]
                public List<GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigIngresses> Ingresses { get; set; }
                public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigIngresses : TeaModel {
                    [NameInMap("Domain")]
                    [Validation(Required=false)]
                    public string Domain { get; set; }

                    [NameInMap("LoadBalancerIaasId")]
                    [Validation(Required=false)]
                    public string LoadBalancerIaasId { get; set; }

                    [NameInMap("LoadBalancerName")]
                    [Validation(Required=false)]
                    public string LoadBalancerName { get; set; }

                    [NameInMap("LoadBalancerType")]
                    [Validation(Required=false)]
                    public string LoadBalancerType { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("SpannerClusterId")]
                    [Validation(Required=false)]
                    public string SpannerClusterId { get; set; }

                    [NameInMap("UnifiedAccessInstanceName")]
                    [Validation(Required=false)]
                    public string UnifiedAccessInstanceName { get; set; }

                    [NameInMap("UnifiedAccessRouteRule")]
                    [Validation(Required=false)]
                    public string UnifiedAccessRouteRule { get; set; }

                    [NameInMap("UnifiedAccessEntries")]
                    [Validation(Required=false)]
                    public List<string> UnifiedAccessEntries { get; set; }

                    [NameInMap("Listeners")]
                    [Validation(Required=false)]
                    public List<GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigIngressesListeners> Listeners { get; set; }
                    public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigIngressesListeners : TeaModel {
                        [NameInMap("BackendServerPort")]
                        [Validation(Required=false)]
                        public long? BackendServerPort { get; set; }

                        [NameInMap("BandWidth")]
                        [Validation(Required=false)]
                        public long? BandWidth { get; set; }

                        [NameInMap("CaCertificateId")]
                        [Validation(Required=false)]
                        public string CaCertificateId { get; set; }

                        [NameInMap("Cookie")]
                        [Validation(Required=false)]
                        public string Cookie { get; set; }

                        [NameInMap("CookieTimeout")]
                        [Validation(Required=false)]
                        public long? CookieTimeout { get; set; }

                        [NameInMap("Domain")]
                        [Validation(Required=false)]
                        public string Domain { get; set; }

                        [NameInMap("EstablishedTimeout")]
                        [Validation(Required=false)]
                        public long? EstablishedTimeout { get; set; }

                        [NameInMap("HealthyThreshold")]
                        [Validation(Required=false)]
                        public long? HealthyThreshold { get; set; }

                        [NameInMap("HealthCheck")]
                        [Validation(Required=false)]
                        public string HealthCheck { get; set; }

                        [NameInMap("HealthCheckConnectPort")]
                        [Validation(Required=false)]
                        public long? HealthCheckConnectPort { get; set; }

                        [NameInMap("HealthCheckConnectTimeout")]
                        [Validation(Required=false)]
                        public long? HealthCheckConnectTimeout { get; set; }

                        [NameInMap("HealthCheckDomain")]
                        [Validation(Required=false)]
                        public string HealthCheckDomain { get; set; }

                        [NameInMap("HealthCheckHttpCode")]
                        [Validation(Required=false)]
                        public string HealthCheckHttpCode { get; set; }

                        [NameInMap("HealthCheckInterval")]
                        [Validation(Required=false)]
                        public long? HealthCheckInterval { get; set; }

                        [NameInMap("HealthCheckThreshold")]
                        [Validation(Required=false)]
                        public long? HealthCheckThreshold { get; set; }

                        [NameInMap("HealthCheckTimeout")]
                        [Validation(Required=false)]
                        public long? HealthCheckTimeout { get; set; }

                        [NameInMap("HealthCheckUri")]
                        [Validation(Required=false)]
                        public string HealthCheckUri { get; set; }

                        [NameInMap("ListenerPort")]
                        [Validation(Required=false)]
                        public long? ListenerPort { get; set; }

                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                        [NameInMap("PersistenceTimeout")]
                        [Validation(Required=false)]
                        public long? PersistenceTimeout { get; set; }

                        [NameInMap("Protocol")]
                        [Validation(Required=false)]
                        public string Protocol { get; set; }

                        [NameInMap("Scheduler")]
                        [Validation(Required=false)]
                        public string Scheduler { get; set; }

                        [NameInMap("SessionStickyType")]
                        [Validation(Required=false)]
                        public long? SessionStickyType { get; set; }

                        [NameInMap("UnhealthyThreshold")]
                        [Validation(Required=false)]
                        public long? UnhealthyThreshold { get; set; }

                        [NameInMap("XforwardFor")]
                        [Validation(Required=false)]
                        public bool? XforwardFor { get; set; }

                    }

                    [NameInMap("ListenersV2")]
                    [Validation(Required=false)]
                    public List<GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigIngressesListenersV2> ListenersV2 { get; set; }
                    public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigIngressesListenersV2 : TeaModel {
                        [NameInMap("BackendServerPort")]
                        [Validation(Required=false)]
                        public long? BackendServerPort { get; set; }

                        [NameInMap("BandWidth")]
                        [Validation(Required=false)]
                        public long? BandWidth { get; set; }

                        [NameInMap("CaCertificateId")]
                        [Validation(Required=false)]
                        public string CaCertificateId { get; set; }

                        [NameInMap("Cookie")]
                        [Validation(Required=false)]
                        public string Cookie { get; set; }

                        [NameInMap("CookieTimeout")]
                        [Validation(Required=false)]
                        public long? CookieTimeout { get; set; }

                        [NameInMap("Domain")]
                        [Validation(Required=false)]
                        public string Domain { get; set; }

                        [NameInMap("EstablishedTimeout")]
                        [Validation(Required=false)]
                        public long? EstablishedTimeout { get; set; }

                        [NameInMap("HealthyThreshold")]
                        [Validation(Required=false)]
                        public long? HealthyThreshold { get; set; }

                        [NameInMap("HealthCheck")]
                        [Validation(Required=false)]
                        public string HealthCheck { get; set; }

                        [NameInMap("HealthCheckConnectPort")]
                        [Validation(Required=false)]
                        public long? HealthCheckConnectPort { get; set; }

                        [NameInMap("HealthCheckConnectTimeout")]
                        [Validation(Required=false)]
                        public long? HealthCheckConnectTimeout { get; set; }

                        [NameInMap("HealthCheckDomain")]
                        [Validation(Required=false)]
                        public string HealthCheckDomain { get; set; }

                        [NameInMap("HealthCheckHttpCode")]
                        [Validation(Required=false)]
                        public string HealthCheckHttpCode { get; set; }

                        [NameInMap("HealthCheckInterval")]
                        [Validation(Required=false)]
                        public long? HealthCheckInterval { get; set; }

                        [NameInMap("HealthCheckThreshold")]
                        [Validation(Required=false)]
                        public long? HealthCheckThreshold { get; set; }

                        [NameInMap("HealthCheckTimeout")]
                        [Validation(Required=false)]
                        public long? HealthCheckTimeout { get; set; }

                        [NameInMap("HealthCheckUri")]
                        [Validation(Required=false)]
                        public string HealthCheckUri { get; set; }

                        [NameInMap("ListenerPort")]
                        [Validation(Required=false)]
                        public long? ListenerPort { get; set; }

                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                        [NameInMap("PersistenceTimeout")]
                        [Validation(Required=false)]
                        public long? PersistenceTimeout { get; set; }

                        [NameInMap("Protocol")]
                        [Validation(Required=false)]
                        public string Protocol { get; set; }

                        [NameInMap("Scheduler")]
                        [Validation(Required=false)]
                        public string Scheduler { get; set; }

                        [NameInMap("SessionStickyType")]
                        [Validation(Required=false)]
                        public long? SessionStickyType { get; set; }

                        [NameInMap("UnhealthyThreshold")]
                        [Validation(Required=false)]
                        public long? UnhealthyThreshold { get; set; }

                        [NameInMap("XforwardFor")]
                        [Validation(Required=false)]
                        public bool? XforwardFor { get; set; }

                    }

                }

                [NameInMap("InnerLoadBalancerServices")]
                [Validation(Required=false)]
                public List<GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigInnerLoadBalancerServices> InnerLoadBalancerServices { get; set; }
                public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigInnerLoadBalancerServices : TeaModel {
                    [NameInMap("AddressType")]
                    [Validation(Required=false)]
                    public string AddressType { get; set; }

                    [NameInMap("Domain")]
                    [Validation(Required=false)]
                    public string Domain { get; set; }

                    [NameInMap("LoadBalancerIaasId")]
                    [Validation(Required=false)]
                    public string LoadBalancerIaasId { get; set; }

                    [NameInMap("LoadBalancerName")]
                    [Validation(Required=false)]
                    public string LoadBalancerName { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("SpannerClusterId")]
                    [Validation(Required=false)]
                    public string SpannerClusterId { get; set; }

                    [NameInMap("CellSlbIaasIdMap")]
                    [Validation(Required=false)]
                    public List<GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigInnerLoadBalancerServicesCellSlbIaasIdMap> CellSlbIaasIdMap { get; set; }
                    public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigInnerLoadBalancerServicesCellSlbIaasIdMap : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("Listeners")]
                    [Validation(Required=false)]
                    public List<GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigInnerLoadBalancerServicesListeners> Listeners { get; set; }
                    public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigInnerLoadBalancerServicesListeners : TeaModel {
                        [NameInMap("BackendServerPort")]
                        [Validation(Required=false)]
                        public long? BackendServerPort { get; set; }

                        [NameInMap("BandWidth")]
                        [Validation(Required=false)]
                        public long? BandWidth { get; set; }

                        [NameInMap("CaCertificateId")]
                        [Validation(Required=false)]
                        public string CaCertificateId { get; set; }

                        [NameInMap("Cookie")]
                        [Validation(Required=false)]
                        public string Cookie { get; set; }

                        [NameInMap("CookieTimeout")]
                        [Validation(Required=false)]
                        public long? CookieTimeout { get; set; }

                        [NameInMap("Domain")]
                        [Validation(Required=false)]
                        public string Domain { get; set; }

                        [NameInMap("EstablishedTimeout")]
                        [Validation(Required=false)]
                        public long? EstablishedTimeout { get; set; }

                        [NameInMap("HealthyThreshold")]
                        [Validation(Required=false)]
                        public long? HealthyThreshold { get; set; }

                        [NameInMap("HealthCheck")]
                        [Validation(Required=false)]
                        public string HealthCheck { get; set; }

                        [NameInMap("HealthCheckConnectPort")]
                        [Validation(Required=false)]
                        public long? HealthCheckConnectPort { get; set; }

                        [NameInMap("HealthCheckConnectTimeout")]
                        [Validation(Required=false)]
                        public long? HealthCheckConnectTimeout { get; set; }

                        [NameInMap("HealthCheckDomain")]
                        [Validation(Required=false)]
                        public string HealthCheckDomain { get; set; }

                        [NameInMap("HealthCheckHttpCode")]
                        [Validation(Required=false)]
                        public string HealthCheckHttpCode { get; set; }

                        [NameInMap("HealthCheckInterval")]
                        [Validation(Required=false)]
                        public long? HealthCheckInterval { get; set; }

                        [NameInMap("HealthCheckThreshold")]
                        [Validation(Required=false)]
                        public long? HealthCheckThreshold { get; set; }

                        [NameInMap("HealthCheckTimeout")]
                        [Validation(Required=false)]
                        public long? HealthCheckTimeout { get; set; }

                        [NameInMap("HealthCheckUri")]
                        [Validation(Required=false)]
                        public string HealthCheckUri { get; set; }

                        [NameInMap("ListenerPort")]
                        [Validation(Required=false)]
                        public long? ListenerPort { get; set; }

                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                        [NameInMap("PersistenceTimeout")]
                        [Validation(Required=false)]
                        public long? PersistenceTimeout { get; set; }

                        [NameInMap("Protocol")]
                        [Validation(Required=false)]
                        public string Protocol { get; set; }

                        [NameInMap("Scheduler")]
                        [Validation(Required=false)]
                        public string Scheduler { get; set; }

                        [NameInMap("SessionStickyType")]
                        [Validation(Required=false)]
                        public long? SessionStickyType { get; set; }

                        [NameInMap("UnhealthyThreshold")]
                        [Validation(Required=false)]
                        public long? UnhealthyThreshold { get; set; }

                        [NameInMap("XforwardFor")]
                        [Validation(Required=false)]
                        public bool? XforwardFor { get; set; }

                    }

                }

                [NameInMap("LoadBalancerServices")]
                [Validation(Required=false)]
                public List<GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigLoadBalancerServices> LoadBalancerServices { get; set; }
                public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigLoadBalancerServices : TeaModel {
                    [NameInMap("AddressType")]
                    [Validation(Required=false)]
                    public string AddressType { get; set; }

                    [NameInMap("Domain")]
                    [Validation(Required=false)]
                    public string Domain { get; set; }

                    [NameInMap("LoadBalancerIaasId")]
                    [Validation(Required=false)]
                    public string LoadBalancerIaasId { get; set; }

                    [NameInMap("LoadBalancerName")]
                    [Validation(Required=false)]
                    public string LoadBalancerName { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("SpannerClusterId")]
                    [Validation(Required=false)]
                    public string SpannerClusterId { get; set; }

                    [NameInMap("CellSlbIaasIdMap")]
                    [Validation(Required=false)]
                    public List<GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigLoadBalancerServicesCellSlbIaasIdMap> CellSlbIaasIdMap { get; set; }
                    public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigLoadBalancerServicesCellSlbIaasIdMap : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("Listeners")]
                    [Validation(Required=false)]
                    public List<GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigLoadBalancerServicesListeners> Listeners { get; set; }
                    public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigLoadBalancerServicesListeners : TeaModel {
                        [NameInMap("BackendServerPort")]
                        [Validation(Required=false)]
                        public long? BackendServerPort { get; set; }

                        [NameInMap("BandWidth")]
                        [Validation(Required=false)]
                        public long? BandWidth { get; set; }

                        [NameInMap("CaCertificateId")]
                        [Validation(Required=false)]
                        public string CaCertificateId { get; set; }

                        [NameInMap("Cookie")]
                        [Validation(Required=false)]
                        public string Cookie { get; set; }

                        [NameInMap("CookieTimeout")]
                        [Validation(Required=false)]
                        public long? CookieTimeout { get; set; }

                        [NameInMap("Domain")]
                        [Validation(Required=false)]
                        public string Domain { get; set; }

                        [NameInMap("EstablishedTimeout")]
                        [Validation(Required=false)]
                        public long? EstablishedTimeout { get; set; }

                        [NameInMap("HealthyThreshold")]
                        [Validation(Required=false)]
                        public long? HealthyThreshold { get; set; }

                        [NameInMap("HealthCheck")]
                        [Validation(Required=false)]
                        public string HealthCheck { get; set; }

                        [NameInMap("HealthCheckConnectPort")]
                        [Validation(Required=false)]
                        public long? HealthCheckConnectPort { get; set; }

                        [NameInMap("HealthCheckConnectTimeout")]
                        [Validation(Required=false)]
                        public long? HealthCheckConnectTimeout { get; set; }

                        [NameInMap("HealthCheckDomain")]
                        [Validation(Required=false)]
                        public string HealthCheckDomain { get; set; }

                        [NameInMap("HealthCheckHttpCode")]
                        [Validation(Required=false)]
                        public string HealthCheckHttpCode { get; set; }

                        [NameInMap("HealthCheckInterval")]
                        [Validation(Required=false)]
                        public long? HealthCheckInterval { get; set; }

                        [NameInMap("HealthCheckThreshold")]
                        [Validation(Required=false)]
                        public long? HealthCheckThreshold { get; set; }

                        [NameInMap("HealthCheckTimeout")]
                        [Validation(Required=false)]
                        public long? HealthCheckTimeout { get; set; }

                        [NameInMap("HealthCheckUri")]
                        [Validation(Required=false)]
                        public string HealthCheckUri { get; set; }

                        [NameInMap("ListenerPort")]
                        [Validation(Required=false)]
                        public long? ListenerPort { get; set; }

                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                        [NameInMap("PersistenceTimeout")]
                        [Validation(Required=false)]
                        public long? PersistenceTimeout { get; set; }

                        [NameInMap("Protocol")]
                        [Validation(Required=false)]
                        public string Protocol { get; set; }

                        [NameInMap("Scheduler")]
                        [Validation(Required=false)]
                        public string Scheduler { get; set; }

                        [NameInMap("SessionStickyType")]
                        [Validation(Required=false)]
                        public long? SessionStickyType { get; set; }

                        [NameInMap("UnhealthyThreshold")]
                        [Validation(Required=false)]
                        public long? UnhealthyThreshold { get; set; }

                        [NameInMap("XforwardFor")]
                        [Validation(Required=false)]
                        public bool? XforwardFor { get; set; }

                    }

                }

                [NameInMap("PublicLoadBalancerServices")]
                [Validation(Required=false)]
                public List<GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigPublicLoadBalancerServices> PublicLoadBalancerServices { get; set; }
                public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigPublicLoadBalancerServices : TeaModel {
                    [NameInMap("AddressType")]
                    [Validation(Required=false)]
                    public string AddressType { get; set; }

                    [NameInMap("Domain")]
                    [Validation(Required=false)]
                    public string Domain { get; set; }

                    [NameInMap("LoadBalancerIaasId")]
                    [Validation(Required=false)]
                    public string LoadBalancerIaasId { get; set; }

                    [NameInMap("LoadBalancerName")]
                    [Validation(Required=false)]
                    public string LoadBalancerName { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("SpannerClusterId")]
                    [Validation(Required=false)]
                    public string SpannerClusterId { get; set; }

                    [NameInMap("CellSlbIaasIdMap")]
                    [Validation(Required=false)]
                    public List<GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigPublicLoadBalancerServicesCellSlbIaasIdMap> CellSlbIaasIdMap { get; set; }
                    public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigPublicLoadBalancerServicesCellSlbIaasIdMap : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("Listeners")]
                    [Validation(Required=false)]
                    public List<GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigPublicLoadBalancerServicesListeners> Listeners { get; set; }
                    public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigPublicLoadBalancerServicesListeners : TeaModel {
                        [NameInMap("BackendServerPort")]
                        [Validation(Required=false)]
                        public long? BackendServerPort { get; set; }

                        [NameInMap("BandWidth")]
                        [Validation(Required=false)]
                        public long? BandWidth { get; set; }

                        [NameInMap("CaCertificateId")]
                        [Validation(Required=false)]
                        public string CaCertificateId { get; set; }

                        [NameInMap("Cookie")]
                        [Validation(Required=false)]
                        public string Cookie { get; set; }

                        [NameInMap("CookieTimeout")]
                        [Validation(Required=false)]
                        public long? CookieTimeout { get; set; }

                        [NameInMap("Domain")]
                        [Validation(Required=false)]
                        public string Domain { get; set; }

                        [NameInMap("EstablishedTimeout")]
                        [Validation(Required=false)]
                        public long? EstablishedTimeout { get; set; }

                        [NameInMap("HealthyThreshold")]
                        [Validation(Required=false)]
                        public long? HealthyThreshold { get; set; }

                        [NameInMap("HealthCheck")]
                        [Validation(Required=false)]
                        public string HealthCheck { get; set; }

                        [NameInMap("HealthCheckConnectPort")]
                        [Validation(Required=false)]
                        public long? HealthCheckConnectPort { get; set; }

                        [NameInMap("HealthCheckConnectTimeout")]
                        [Validation(Required=false)]
                        public long? HealthCheckConnectTimeout { get; set; }

                        [NameInMap("HealthCheckDomain")]
                        [Validation(Required=false)]
                        public string HealthCheckDomain { get; set; }

                        [NameInMap("HealthCheckHttpCode")]
                        [Validation(Required=false)]
                        public string HealthCheckHttpCode { get; set; }

                        [NameInMap("HealthCheckInterval")]
                        [Validation(Required=false)]
                        public long? HealthCheckInterval { get; set; }

                        [NameInMap("HealthCheckThreshold")]
                        [Validation(Required=false)]
                        public long? HealthCheckThreshold { get; set; }

                        [NameInMap("HealthCheckTimeout")]
                        [Validation(Required=false)]
                        public long? HealthCheckTimeout { get; set; }

                        [NameInMap("HealthCheckUri")]
                        [Validation(Required=false)]
                        public string HealthCheckUri { get; set; }

                        [NameInMap("ListenerPort")]
                        [Validation(Required=false)]
                        public long? ListenerPort { get; set; }

                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                        [NameInMap("PersistenceTimeout")]
                        [Validation(Required=false)]
                        public long? PersistenceTimeout { get; set; }

                        [NameInMap("Protocol")]
                        [Validation(Required=false)]
                        public string Protocol { get; set; }

                        [NameInMap("Scheduler")]
                        [Validation(Required=false)]
                        public string Scheduler { get; set; }

                        [NameInMap("SessionStickyType")]
                        [Validation(Required=false)]
                        public long? SessionStickyType { get; set; }

                        [NameInMap("UnhealthyThreshold")]
                        [Validation(Required=false)]
                        public long? UnhealthyThreshold { get; set; }

                        [NameInMap("XforwardFor")]
                        [Validation(Required=false)]
                        public bool? XforwardFor { get; set; }

                    }

                }

                [NameInMap("SidecarConfigs")]
                [Validation(Required=false)]
                public List<GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigSidecarConfigs> SidecarConfigs { get; set; }
                public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigSidecarConfigs : TeaModel {
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    [NameInMap("Scope")]
                    [Validation(Required=false)]
                    public string Scope { get; set; }

                    [NameInMap("SidecarName")]
                    [Validation(Required=false)]
                    public string SidecarName { get; set; }

                    [NameInMap("SidecarVersion")]
                    [Validation(Required=false)]
                    public string SidecarVersion { get; set; }

                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("WorkspaceGroupId")]
                    [Validation(Required=false)]
                    public string WorkspaceGroupId { get; set; }

                    [NameInMap("WorkspaceId")]
                    [Validation(Required=false)]
                    public string WorkspaceId { get; set; }

                }

                [NameInMap("DeployConfig")]
                [Validation(Required=false)]
                public GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigDeployConfig DeployConfig { get; set; }
                public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigDeployConfig : TeaModel {
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
                    public GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigDeployConfigAffinity Affinity { get; set; }
                    public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigDeployConfigAffinity : TeaModel {
                        [NameInMap("NodeAffinity")]
                        [Validation(Required=false)]
                        public List<GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigDeployConfigAffinityNodeAffinity> NodeAffinity { get; set; }
                        public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigDeployConfigAffinityNodeAffinity : TeaModel {
                            [NameInMap("Requested")]
                            [Validation(Required=false)]
                            public bool? Requested { get; set; }

                            [NameInMap("Weight")]
                            [Validation(Required=false)]
                            public long? Weight { get; set; }

                            [NameInMap("MatchExpressions")]
                            [Validation(Required=false)]
                            public List<GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigDeployConfigAffinityNodeAffinityMatchExpressions> MatchExpressions { get; set; }
                            public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigDeployConfigAffinityNodeAffinityMatchExpressions : TeaModel {
                                [NameInMap("Key")]
                                [Validation(Required=false)]
                                public string Key { get; set; }

                                [NameInMap("Operator")]
                                [Validation(Required=false)]
                                public string Operator { get; set; }

                                [NameInMap("Values")]
                                [Validation(Required=false)]
                                public List<string> Values { get; set; }

                            }

                        }

                        [NameInMap("PodAffinity")]
                        [Validation(Required=false)]
                        public List<GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigDeployConfigAffinityPodAffinity> PodAffinity { get; set; }
                        public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigDeployConfigAffinityPodAffinity : TeaModel {
                            [NameInMap("AntiAffinity")]
                            [Validation(Required=false)]
                            public bool? AntiAffinity { get; set; }

                            [NameInMap("Requested")]
                            [Validation(Required=false)]
                            public bool? Requested { get; set; }

                            [NameInMap("Weight")]
                            [Validation(Required=false)]
                            public long? Weight { get; set; }

                            [NameInMap("PodAffinityTerm")]
                            [Validation(Required=false)]
                            public GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigDeployConfigAffinityPodAffinityPodAffinityTerm PodAffinityTerm { get; set; }
                            public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigDeployConfigAffinityPodAffinityPodAffinityTerm : TeaModel {
                                [NameInMap("TopologyKey")]
                                [Validation(Required=false)]
                                public string TopologyKey { get; set; }
                                [NameInMap("Namespaces")]
                                [Validation(Required=false)]
                                public List<string> Namespaces { get; set; }
                                [NameInMap("LabelSelector")]
                                [Validation(Required=false)]
                                public List<GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigDeployConfigAffinityPodAffinityPodAffinityTermLabelSelector> LabelSelector { get; set; }
                                public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigDeployConfigAffinityPodAffinityPodAffinityTermLabelSelector : TeaModel {
                                    public string Key { get; set; }
                                    public string Value { get; set; }
                                }
                            };

                        }

                    }
                };

                [NameInMap("ElasticConfig")]
                [Validation(Required=false)]
                public GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigElasticConfig ElasticConfig { get; set; }
                public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigElasticConfig : TeaModel {
                    [NameInMap("FixedReplica")]
                    [Validation(Required=false)]
                    public GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigElasticConfigFixedReplica FixedReplica { get; set; }
                    public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigElasticConfigFixedReplica : TeaModel {
                        [NameInMap("Replicas")]
                        [Validation(Required=false)]
                        public List<GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigElasticConfigFixedReplicaReplicas> Replicas { get; set; }
                        public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigElasticConfigFixedReplicaReplicas : TeaModel {
                            [NameInMap("Count")]
                            [Validation(Required=false)]
                            public long? Count { get; set; }

                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                    }
                };

            }
            [NameInMap("ContainerServiceReleaseInfo")]
            [Validation(Required=false)]
            public GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceReleaseInfo ContainerServiceReleaseInfo { get; set; }
            public class GetLDCContainerServiceRevisionResponseBodyRevisionContainerServiceReleaseInfo : TeaModel {
                [NameInMap("CreatedPlanId")]
                [Validation(Required=false)]
                public string CreatedPlanId { get; set; }

                [NameInMap("LatestDeploymentEndTime")]
                [Validation(Required=false)]
                public string LatestDeploymentEndTime { get; set; }

                [NameInMap("LatestDeploymentStartTime")]
                [Validation(Required=false)]
                public string LatestDeploymentStartTime { get; set; }

            }
        };

    }

}
