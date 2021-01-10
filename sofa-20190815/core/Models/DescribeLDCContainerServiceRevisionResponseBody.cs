// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DescribeLDCContainerServiceRevisionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Revision")]
        [Validation(Required=false)]
        public DescribeLDCContainerServiceRevisionResponseBodyRevision Revision { get; set; }
        public class DescribeLDCContainerServiceRevisionResponseBodyRevision : TeaModel {
            [NameInMap("AppInfo")]
            [Validation(Required=false)]
            public DescribeLDCContainerServiceRevisionResponseBodyRevisionAppInfo AppInfo { get; set; }
            public class DescribeLDCContainerServiceRevisionResponseBodyRevisionAppInfo : TeaModel {
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("BuildpackVersion")]
                [Validation(Required=false)]
                public string BuildpackVersion { get; set; }

                [NameInMap("TechstackIdentity")]
                [Validation(Required=false)]
                public string TechstackIdentity { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

            }
            [NameInMap("DeployStatus")]
            [Validation(Required=false)]
            public string DeployStatus { get; set; }
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }
            [NameInMap("MetaStatus")]
            [Validation(Required=false)]
            public string MetaStatus { get; set; }
            [NameInMap("ContainerServiceName")]
            [Validation(Required=false)]
            public string ContainerServiceName { get; set; }
            [NameInMap("ContainerServiceConfig")]
            [Validation(Required=false)]
            public DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfig ContainerServiceConfig { get; set; }
            public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfig : TeaModel {
                [NameInMap("EnableLogConfig")]
                [Validation(Required=false)]
                public bool? EnableLogConfig { get; set; }

                [NameInMap("ContainerSpecs")]
                [Validation(Required=false)]
                public List<DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecs> ContainerSpecs { get; set; }
                public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecs : TeaModel {
                    [NameInMap("LogConfigs")]
                    [Validation(Required=false)]
                    public List<DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLogConfigs> LogConfigs { get; set; }
                    public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLogConfigs : TeaModel {
                        [NameInMap("ConfigName")]
                        [Validation(Required=false)]
                        public string ConfigName { get; set; }

                        [NameInMap("InputType")]
                        [Validation(Required=false)]
                        public string InputType { get; set; }

                        [NameInMap("LogPath")]
                        [Validation(Required=false)]
                        public string LogPath { get; set; }

                        [NameInMap("LogstoreName")]
                        [Validation(Required=false)]
                        public string LogstoreName { get; set; }

                    }

                    [NameInMap("VolumeMounts")]
                    [Validation(Required=false)]
                    public List<DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsVolumeMounts> VolumeMounts { get; set; }
                    public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsVolumeMounts : TeaModel {
                        [NameInMap("VolumeSourceCategoryType")]
                        [Validation(Required=false)]
                        public string VolumeSourceCategoryType { get; set; }

                        [NameInMap("LocalDiskVolumeSource")]
                        [Validation(Required=false)]
                        public DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsVolumeMountsLocalDiskVolumeSource LocalDiskVolumeSource { get; set; }
                        public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsVolumeMountsLocalDiskVolumeSource : TeaModel {
                            [NameInMap("HostDirectoryPath")]
                            [Validation(Required=false)]
                            public string HostDirectoryPath { get; set; }
                            [NameInMap("CreateIfNotPresent")]
                            [Validation(Required=false)]
                            public bool? CreateIfNotPresent { get; set; }
                        };

                        [NameInMap("ConfigmapSecretVolumeSource")]
                        [Validation(Required=false)]
                        public DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsVolumeMountsConfigmapSecretVolumeSource ConfigmapSecretVolumeSource { get; set; }
                        public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsVolumeMountsConfigmapSecretVolumeSource : TeaModel {
                            [NameInMap("VolumeRefName")]
                            [Validation(Required=false)]
                            public string VolumeRefName { get; set; }
                        };

                        [NameInMap("PvcSource")]
                        [Validation(Required=false)]
                        public DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsVolumeMountsPvcSource PvcSource { get; set; }
                        public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsVolumeMountsPvcSource : TeaModel {
                            [NameInMap("PvcName")]
                            [Validation(Required=false)]
                            public string PvcName { get; set; }
                        };

                        [NameInMap("EmptyDirVolumeSource")]
                        [Validation(Required=false)]
                        public DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsVolumeMountsEmptyDirVolumeSource EmptyDirVolumeSource { get; set; }
                        public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsVolumeMountsEmptyDirVolumeSource : TeaModel {
                            [NameInMap("Medium")]
                            [Validation(Required=false)]
                            public string Medium { get; set; }
                            [NameInMap("SizeLimit")]
                            [Validation(Required=false)]
                            public string SizeLimit { get; set; }
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }
                        };

                        [NameInMap("MountPath")]
                        [Validation(Required=false)]
                        public string MountPath { get; set; }

                        [NameInMap("ReadOnly")]
                        [Validation(Required=false)]
                        public bool? ReadOnly { get; set; }

                        [NameInMap("SubPath")]
                        [Validation(Required=false)]
                        public string SubPath { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("VolumesStr")]
                    [Validation(Required=false)]
                    public string VolumesStr { get; set; }

                    [NameInMap("ImageSource")]
                    [Validation(Required=false)]
                    public string ImageSource { get; set; }

                    [NameInMap("CpuRequest")]
                    [Validation(Required=false)]
                    public string CpuRequest { get; set; }

                    [NameInMap("HealthCheckConfig")]
                    [Validation(Required=false)]
                    public DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfig HealthCheckConfig { get; set; }
                    public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfig : TeaModel {
                        [NameInMap("LivenessProbe")]
                        [Validation(Required=false)]
                        public DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigLivenessProbe LivenessProbe { get; set; }
                        public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigLivenessProbe : TeaModel {
                            [NameInMap("SuccessThreshold")]
                            [Validation(Required=false)]
                            public long? SuccessThreshold { get; set; }

                            [NameInMap("TimeOutSeconds")]
                            [Validation(Required=false)]
                            public long? TimeOutSeconds { get; set; }

                            [NameInMap("InitialDelaySeconds")]
                            [Validation(Required=false)]
                            public long? InitialDelaySeconds { get; set; }

                            [NameInMap("FailureThreshold")]
                            [Validation(Required=false)]
                            public long? FailureThreshold { get; set; }

                            [NameInMap("HttpGetAction")]
                            [Validation(Required=false)]
                            public DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigLivenessProbeHttpGetAction HttpGetAction { get; set; }
                            public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigLivenessProbeHttpGetAction : TeaModel {
                                [NameInMap("Scheme")]
                                [Validation(Required=false)]
                                public string Scheme { get; set; }
                                [NameInMap("Path")]
                                [Validation(Required=false)]
                                public string Path { get; set; }
                                [NameInMap("Port")]
                                [Validation(Required=false)]
                                public string Port { get; set; }
                            };

                            [NameInMap("TcpSocketAction")]
                            [Validation(Required=false)]
                            public DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigLivenessProbeTcpSocketAction TcpSocketAction { get; set; }
                            public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigLivenessProbeTcpSocketAction : TeaModel {
                                [NameInMap("Port")]
                                [Validation(Required=false)]
                                public string Port { get; set; }
                            };

                            [NameInMap("PeriodSeconds")]
                            [Validation(Required=false)]
                            public long? PeriodSeconds { get; set; }

                            [NameInMap("ExecAction")]
                            [Validation(Required=false)]
                            public DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigLivenessProbeExecAction ExecAction { get; set; }
                            public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigLivenessProbeExecAction : TeaModel {
                                [NameInMap("Command")]
                                [Validation(Required=false)]
                                public string Command { get; set; }
                            };

                        }
                        [NameInMap("ReadinessProbe")]
                        [Validation(Required=false)]
                        public DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigReadinessProbe ReadinessProbe { get; set; }
                        public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigReadinessProbe : TeaModel {
                            [NameInMap("SuccessThreshold")]
                            [Validation(Required=false)]
                            public long? SuccessThreshold { get; set; }

                            [NameInMap("TimeOutSeconds")]
                            [Validation(Required=false)]
                            public long? TimeOutSeconds { get; set; }

                            [NameInMap("InitialDelaySeconds")]
                            [Validation(Required=false)]
                            public long? InitialDelaySeconds { get; set; }

                            [NameInMap("FailureThreshold")]
                            [Validation(Required=false)]
                            public long? FailureThreshold { get; set; }

                            [NameInMap("HttpGetAction")]
                            [Validation(Required=false)]
                            public DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigReadinessProbeHttpGetAction HttpGetAction { get; set; }
                            public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigReadinessProbeHttpGetAction : TeaModel {
                                [NameInMap("Scheme")]
                                [Validation(Required=false)]
                                public string Scheme { get; set; }
                                [NameInMap("Path")]
                                [Validation(Required=false)]
                                public string Path { get; set; }
                                [NameInMap("Port")]
                                [Validation(Required=false)]
                                public string Port { get; set; }
                            };

                            [NameInMap("TcpSocketAction")]
                            [Validation(Required=false)]
                            public DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigReadinessProbeTcpSocketAction TcpSocketAction { get; set; }
                            public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigReadinessProbeTcpSocketAction : TeaModel {
                                [NameInMap("Port")]
                                [Validation(Required=false)]
                                public string Port { get; set; }
                            };

                            [NameInMap("PeriodSeconds")]
                            [Validation(Required=false)]
                            public long? PeriodSeconds { get; set; }

                            [NameInMap("ExecAction")]
                            [Validation(Required=false)]
                            public DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigReadinessProbeExecAction ExecAction { get; set; }
                            public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsHealthCheckConfigReadinessProbeExecAction : TeaModel {
                                [NameInMap("Command")]
                                [Validation(Required=false)]
                                public string Command { get; set; }
                            };

                        }
                    };

                    [NameInMap("MemoryRequest")]
                    [Validation(Required=false)]
                    public string MemoryRequest { get; set; }

                    [NameInMap("Image")]
                    [Validation(Required=false)]
                    public string Image { get; set; }

                    [NameInMap("LifecycleHook")]
                    [Validation(Required=false)]
                    public DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLifecycleHook LifecycleHook { get; set; }
                    public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLifecycleHook : TeaModel {
                        [NameInMap("PostStartExec")]
                        [Validation(Required=false)]
                        public DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLifecycleHookPostStartExec PostStartExec { get; set; }
                        public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLifecycleHookPostStartExec : TeaModel {
                            [NameInMap("Command")]
                            [Validation(Required=false)]
                            public string Command { get; set; }

                        }
                        [NameInMap("PreStopTcp")]
                        [Validation(Required=false)]
                        public DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLifecycleHookPreStopTcp PreStopTcp { get; set; }
                        public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLifecycleHookPreStopTcp : TeaModel {
                            [NameInMap("Port")]
                            [Validation(Required=false)]
                            public string Port { get; set; }

                        }
                        [NameInMap("PreStopHttp")]
                        [Validation(Required=false)]
                        public DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLifecycleHookPreStopHttp PreStopHttp { get; set; }
                        public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLifecycleHookPreStopHttp : TeaModel {
                            [NameInMap("Scheme")]
                            [Validation(Required=false)]
                            public string Scheme { get; set; }

                            [NameInMap("Path")]
                            [Validation(Required=false)]
                            public string Path { get; set; }

                            [NameInMap("Port")]
                            [Validation(Required=false)]
                            public string Port { get; set; }

                        }
                        [NameInMap("PostStartTcp")]
                        [Validation(Required=false)]
                        public DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLifecycleHookPostStartTcp PostStartTcp { get; set; }
                        public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLifecycleHookPostStartTcp : TeaModel {
                            [NameInMap("Port")]
                            [Validation(Required=false)]
                            public string Port { get; set; }

                        }
                        [NameInMap("PostStartHttp")]
                        [Validation(Required=false)]
                        public DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLifecycleHookPostStartHttp PostStartHttp { get; set; }
                        public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLifecycleHookPostStartHttp : TeaModel {
                            [NameInMap("Scheme")]
                            [Validation(Required=false)]
                            public string Scheme { get; set; }

                            [NameInMap("Path")]
                            [Validation(Required=false)]
                            public string Path { get; set; }

                            [NameInMap("Port")]
                            [Validation(Required=false)]
                            public string Port { get; set; }

                        }
                        [NameInMap("PreStopExec")]
                        [Validation(Required=false)]
                        public DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLifecycleHookPreStopExec PreStopExec { get; set; }
                        public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsLifecycleHookPreStopExec : TeaModel {
                            [NameInMap("Command")]
                            [Validation(Required=false)]
                            public string Command { get; set; }

                        }
                    };

                    [NameInMap("ImagePullSecret")]
                    [Validation(Required=false)]
                    public string ImagePullSecret { get; set; }

                    [NameInMap("VolumeMountsStr")]
                    [Validation(Required=false)]
                    public string VolumeMountsStr { get; set; }

                    [NameInMap("MemoryLimit")]
                    [Validation(Required=false)]
                    public string MemoryLimit { get; set; }

                    [NameInMap("ImageBuildName")]
                    [Validation(Required=false)]
                    public string ImageBuildName { get; set; }

                    [NameInMap("EntryPoints")]
                    [Validation(Required=false)]
                    public List<string> EntryPoints { get; set; }

                    [NameInMap("Envs")]
                    [Validation(Required=false)]
                    public List<DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsEnvs> Envs { get; set; }
                    public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsEnvs : TeaModel {
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("ValueFrom")]
                        [Validation(Required=false)]
                        public DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsEnvsValueFrom ValueFrom { get; set; }
                        public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsEnvsValueFrom : TeaModel {
                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }
                            [NameInMap("ObjectType")]
                            [Validation(Required=false)]
                            public string ObjectType { get; set; }
                            [NameInMap("ObjectName")]
                            [Validation(Required=false)]
                            public string ObjectName { get; set; }
                        };

                    }

                    [NameInMap("RestartPolicy")]
                    [Validation(Required=false)]
                    public string RestartPolicy { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("CpuLimit")]
                    [Validation(Required=false)]
                    public string CpuLimit { get; set; }

                    [NameInMap("EnvOverrides")]
                    [Validation(Required=false)]
                    public List<DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsEnvOverrides> EnvOverrides { get; set; }
                    public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigContainerSpecsEnvOverrides : TeaModel {
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Cell")]
                        [Validation(Required=false)]
                        public string Cell { get; set; }

                    }

                }

                [NameInMap("EnableBizMonitor")]
                [Validation(Required=false)]
                public bool? EnableBizMonitor { get; set; }

                [NameInMap("BizMonitorPaths")]
                [Validation(Required=false)]
                public List<string> BizMonitorPaths { get; set; }

                [NameInMap("DeployConfig")]
                [Validation(Required=false)]
                public DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigDeployConfig DeployConfig { get; set; }
                public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigDeployConfig : TeaModel {
                    [NameInMap("Affinity")]
                    [Validation(Required=false)]
                    public DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigDeployConfigAffinity Affinity { get; set; }
                    public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigDeployConfigAffinity : TeaModel {
                        [NameInMap("NodeAffinity")]
                        [Validation(Required=false)]
                        public List<DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigDeployConfigAffinityNodeAffinity> NodeAffinity { get; set; }
                        public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigDeployConfigAffinityNodeAffinity : TeaModel {
                            [NameInMap("Weight")]
                            [Validation(Required=false)]
                            public long? Weight { get; set; }

                            [NameInMap("Requested")]
                            [Validation(Required=false)]
                            public bool? Requested { get; set; }

                            [NameInMap("MatchExpressions")]
                            [Validation(Required=false)]
                            public List<DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigDeployConfigAffinityNodeAffinityMatchExpressions> MatchExpressions { get; set; }
                            public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigDeployConfigAffinityNodeAffinityMatchExpressions : TeaModel {
                                [NameInMap("Key")]
                                [Validation(Required=false)]
                                public string Key { get; set; }

                                [NameInMap("Values")]
                                [Validation(Required=false)]
                                public List<string> Values { get; set; }

                                [NameInMap("Operator")]
                                [Validation(Required=false)]
                                public string Operator { get; set; }

                            }

                        }

                        [NameInMap("PodAffinity")]
                        [Validation(Required=false)]
                        public List<DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigDeployConfigAffinityPodAffinity> PodAffinity { get; set; }
                        public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigDeployConfigAffinityPodAffinity : TeaModel {
                            [NameInMap("PodAffinityTerm")]
                            [Validation(Required=false)]
                            public DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigDeployConfigAffinityPodAffinityPodAffinityTerm PodAffinityTerm { get; set; }
                            public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigDeployConfigAffinityPodAffinityPodAffinityTerm : TeaModel {
                                [NameInMap("TopologyKey")]
                                [Validation(Required=false)]
                                public string TopologyKey { get; set; }
                                [NameInMap("LabelSelector")]
                                [Validation(Required=false)]
                                public List<DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigDeployConfigAffinityPodAffinityPodAffinityTermLabelSelector> LabelSelector { get; set; }
                                public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigDeployConfigAffinityPodAffinityPodAffinityTermLabelSelector : TeaModel {
                                    public string Key { get; set; }
                                    public string Value { get; set; }
                                }
                                [NameInMap("Namespaces")]
                                [Validation(Required=false)]
                                public List<string> Namespaces { get; set; }
                            };

                            [NameInMap("Weight")]
                            [Validation(Required=false)]
                            public long? Weight { get; set; }

                            [NameInMap("Requested")]
                            [Validation(Required=false)]
                            public bool? Requested { get; set; }

                            [NameInMap("AntiAffinity")]
                            [Validation(Required=false)]
                            public bool? AntiAffinity { get; set; }

                        }

                    }
                    [NameInMap("MaxGroupCapacity")]
                    [Validation(Required=false)]
                    public long? MaxGroupCapacity { get; set; }
                    [NameInMap("Labels")]
                    [Validation(Required=false)]
                    public string Labels { get; set; }
                    [NameInMap("GroupCount")]
                    [Validation(Required=false)]
                    public long? GroupCount { get; set; }
                    [NameInMap("CustomLabels")]
                    [Validation(Required=false)]
                    public string CustomLabels { get; set; }
                    [NameInMap("Annotations")]
                    [Validation(Required=false)]
                    public string Annotations { get; set; }
                    [NameInMap("GroupStrategy")]
                    [Validation(Required=false)]
                    public string GroupStrategy { get; set; }
                    [NameInMap("EnableSofaMesh")]
                    [Validation(Required=false)]
                    public bool? EnableSofaMesh { get; set; }
                    [NameInMap("NeedConfirm")]
                    [Validation(Required=false)]
                    public bool? NeedConfirm { get; set; }
                    [NameInMap("NeedBeta")]
                    [Validation(Required=false)]
                    public bool? NeedBeta { get; set; }
                };

                [NameInMap("EnableSofaMesh")]
                [Validation(Required=false)]
                public bool? EnableSofaMesh { get; set; }

                [NameInMap("SidecarConfigs")]
                [Validation(Required=false)]
                public List<DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigSidecarConfigs> SidecarConfigs { get; set; }
                public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigSidecarConfigs : TeaModel {
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("WorkspaceId")]
                    [Validation(Required=false)]
                    public string WorkspaceId { get; set; }

                    [NameInMap("SidecarName")]
                    [Validation(Required=false)]
                    public string SidecarName { get; set; }

                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    [NameInMap("SidecarVersion")]
                    [Validation(Required=false)]
                    public string SidecarVersion { get; set; }

                    [NameInMap("WorkspaceGroupId")]
                    [Validation(Required=false)]
                    public string WorkspaceGroupId { get; set; }

                    [NameInMap("Scope")]
                    [Validation(Required=false)]
                    public string Scope { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                }

                [NameInMap("Ingresses")]
                [Validation(Required=false)]
                public List<DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigIngresses> Ingresses { get; set; }
                public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigIngresses : TeaModel {
                    [NameInMap("ListenersV2")]
                    [Validation(Required=false)]
                    public List<DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigIngressesListenersV2> ListenersV2 { get; set; }
                    public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigIngressesListenersV2 : TeaModel {
                        [NameInMap("HealthCheckThreshold")]
                        [Validation(Required=false)]
                        public long? HealthCheckThreshold { get; set; }

                        [NameInMap("Cookie")]
                        [Validation(Required=false)]
                        public string Cookie { get; set; }

                        [NameInMap("SessionStickyType")]
                        [Validation(Required=false)]
                        public long? SessionStickyType { get; set; }

                        [NameInMap("HealthCheckConnectPort")]
                        [Validation(Required=false)]
                        public long? HealthCheckConnectPort { get; set; }

                        [NameInMap("HealthCheckTimeout")]
                        [Validation(Required=false)]
                        public long? HealthCheckTimeout { get; set; }

                        [NameInMap("HealthCheckUri")]
                        [Validation(Required=false)]
                        public string HealthCheckUri { get; set; }

                        [NameInMap("BackendServerPort")]
                        [Validation(Required=false)]
                        public long? BackendServerPort { get; set; }

                        [NameInMap("CookieTimeout")]
                        [Validation(Required=false)]
                        public long? CookieTimeout { get; set; }

                        [NameInMap("HealthCheckDomain")]
                        [Validation(Required=false)]
                        public string HealthCheckDomain { get; set; }

                        [NameInMap("UnhealthyThreshold")]
                        [Validation(Required=false)]
                        public long? UnhealthyThreshold { get; set; }

                        [NameInMap("HealthCheckHttpCode")]
                        [Validation(Required=false)]
                        public string HealthCheckHttpCode { get; set; }

                        [NameInMap("Domain")]
                        [Validation(Required=false)]
                        public string Domain { get; set; }

                        [NameInMap("Protocol")]
                        [Validation(Required=false)]
                        public string Protocol { get; set; }

                        [NameInMap("PersistenceTimeout")]
                        [Validation(Required=false)]
                        public long? PersistenceTimeout { get; set; }

                        [NameInMap("ListenerPort")]
                        [Validation(Required=false)]
                        public long? ListenerPort { get; set; }

                        [NameInMap("HealthCheckInterval")]
                        [Validation(Required=false)]
                        public long? HealthCheckInterval { get; set; }

                        [NameInMap("BandWidth")]
                        [Validation(Required=false)]
                        public long? BandWidth { get; set; }

                        [NameInMap("Scheduler")]
                        [Validation(Required=false)]
                        public string Scheduler { get; set; }

                        [NameInMap("XforwardFor")]
                        [Validation(Required=false)]
                        public bool? XforwardFor { get; set; }

                        [NameInMap("EstablishedTimeout")]
                        [Validation(Required=false)]
                        public long? EstablishedTimeout { get; set; }

                        [NameInMap("HealthCheckConnectTimeout")]
                        [Validation(Required=false)]
                        public long? HealthCheckConnectTimeout { get; set; }

                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                        [NameInMap("CaCertificateId")]
                        [Validation(Required=false)]
                        public string CaCertificateId { get; set; }

                        [NameInMap("HealthyThreshold")]
                        [Validation(Required=false)]
                        public long? HealthyThreshold { get; set; }

                        [NameInMap("HealthCheck")]
                        [Validation(Required=false)]
                        public string HealthCheck { get; set; }

                    }

                    [NameInMap("Domain")]
                    [Validation(Required=false)]
                    public string Domain { get; set; }

                    [NameInMap("LoadBalancerName")]
                    [Validation(Required=false)]
                    public string LoadBalancerName { get; set; }

                    [NameInMap("LoadBalancerType")]
                    [Validation(Required=false)]
                    public string LoadBalancerType { get; set; }

                    [NameInMap("UnifiedAccessRouteRule")]
                    [Validation(Required=false)]
                    public string UnifiedAccessRouteRule { get; set; }

                    [NameInMap("LoadBalancerIaasId")]
                    [Validation(Required=false)]
                    public string LoadBalancerIaasId { get; set; }

                    [NameInMap("Listeners")]
                    [Validation(Required=false)]
                    public List<DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigIngressesListeners> Listeners { get; set; }
                    public class DescribeLDCContainerServiceRevisionResponseBodyRevisionContainerServiceConfigIngressesListeners : TeaModel {
                        [NameInMap("HealthCheckThreshold")]
                        [Validation(Required=false)]
                        public long? HealthCheckThreshold { get; set; }

                        [NameInMap("Cookie")]
                        [Validation(Required=false)]
                        public string Cookie { get; set; }

                        [NameInMap("SessionStickyType")]
                        [Validation(Required=false)]
                        public long? SessionStickyType { get; set; }

                        [NameInMap("HealthCheckConnectPort")]
                        [Validation(Required=false)]
                        public long? HealthCheckConnectPort { get; set; }

                        [NameInMap("HealthCheckTimeout")]
                        [Validation(Required=false)]
                        public long? HealthCheckTimeout { get; set; }

                        [NameInMap("HealthCheckUri")]
                        [Validation(Required=false)]
                        public string HealthCheckUri { get; set; }

                        [NameInMap("BackendServerPort")]
                        [Validation(Required=false)]
                        public long? BackendServerPort { get; set; }

                        [NameInMap("CookieTimeout")]
                        [Validation(Required=false)]
                        public long? CookieTimeout { get; set; }

                        [NameInMap("HealthCheckDomain")]
                        [Validation(Required=false)]
                        public string HealthCheckDomain { get; set; }

                        [NameInMap("UnhealthyThreshold")]
                        [Validation(Required=false)]
                        public long? UnhealthyThreshold { get; set; }

                        [NameInMap("HealthCheckHttpCode")]
                        [Validation(Required=false)]
                        public string HealthCheckHttpCode { get; set; }

                        [NameInMap("Domain")]
                        [Validation(Required=false)]
                        public string Domain { get; set; }

                        [NameInMap("Protocol")]
                        [Validation(Required=false)]
                        public string Protocol { get; set; }

                        [NameInMap("PersistenceTimeout")]
                        [Validation(Required=false)]
                        public long? PersistenceTimeout { get; set; }

                        [NameInMap("ListenerPort")]
                        [Validation(Required=false)]
                        public long? ListenerPort { get; set; }

                        [NameInMap("HealthCheckInterval")]
                        [Validation(Required=false)]
                        public long? HealthCheckInterval { get; set; }

                        [NameInMap("BandWidth")]
                        [Validation(Required=false)]
                        public long? BandWidth { get; set; }

                        [NameInMap("Scheduler")]
                        [Validation(Required=false)]
                        public string Scheduler { get; set; }

                        [NameInMap("XforwardFor")]
                        [Validation(Required=false)]
                        public bool? XforwardFor { get; set; }

                        [NameInMap("EstablishedTimeout")]
                        [Validation(Required=false)]
                        public long? EstablishedTimeout { get; set; }

                        [NameInMap("HealthCheckConnectTimeout")]
                        [Validation(Required=false)]
                        public long? HealthCheckConnectTimeout { get; set; }

                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                        [NameInMap("CaCertificateId")]
                        [Validation(Required=false)]
                        public string CaCertificateId { get; set; }

                        [NameInMap("HealthyThreshold")]
                        [Validation(Required=false)]
                        public long? HealthyThreshold { get; set; }

                        [NameInMap("HealthCheck")]
                        [Validation(Required=false)]
                        public string HealthCheck { get; set; }

                    }

                    [NameInMap("UnifiedAccessEntries")]
                    [Validation(Required=false)]
                    public List<string> UnifiedAccessEntries { get; set; }

                    [NameInMap("UnifiedAccessInstanceName")]
                    [Validation(Required=false)]
                    public string UnifiedAccessInstanceName { get; set; }

                }

            }
        };

    }

}
