// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListLDCContainerservicePodResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("PodList")]
        [Validation(Required=false)]
        public List<ListLDCContainerservicePodResponseBodyPodList> PodList { get; set; }
        public class ListLDCContainerservicePodResponseBodyPodList : TeaModel {
            [NameInMap("CellDisplayName")]
            [Validation(Required=false)]
            public string CellDisplayName { get; set; }

            [NameInMap("Cluster")]
            [Validation(Required=false)]
            public string Cluster { get; set; }

            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            [NameInMap("Containers")]
            [Validation(Required=false)]
            public List<ListLDCContainerservicePodResponseBodyPodListContainers> Containers { get; set; }
            public class ListLDCContainerservicePodResponseBodyPodListContainers : TeaModel {
                [NameInMap("ContainerId")]
                [Validation(Required=false)]
                public string ContainerId { get; set; }

                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                [NameInMap("LastStartTime")]
                [Validation(Required=false)]
                public string LastStartTime { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RestartCount")]
                [Validation(Required=false)]
                public long? RestartCount { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("Spec")]
                [Validation(Required=false)]
                public ListLDCContainerservicePodResponseBodyPodListContainersSpec Spec { get; set; }
                public class ListLDCContainerservicePodResponseBodyPodListContainersSpec : TeaModel {
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
                    public List<ListLDCContainerservicePodResponseBodyPodListContainersSpecEnvs> Envs { get; set; }
                    public class ListLDCContainerservicePodResponseBodyPodListContainersSpecEnvs : TeaModel {
                        public string Name { get; set; }
                        public string Type { get; set; }
                        public string Value { get; set; }
                        public ListLDCContainerservicePodResponseBodyPodListContainersSpecEnvsValueFrom ValueFrom { get; set; }
                        public class ListLDCContainerservicePodResponseBodyPodListContainersSpecEnvsValueFrom : TeaModel {
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
                    [NameInMap("EnvOverrides")]
                    [Validation(Required=false)]
                    public List<ListLDCContainerservicePodResponseBodyPodListContainersSpecEnvOverrides> EnvOverrides { get; set; }
                    public class ListLDCContainerservicePodResponseBodyPodListContainersSpecEnvOverrides : TeaModel {
                        public string Cell { get; set; }
                        public string Name { get; set; }
                        public string Value { get; set; }
                    }
                    [NameInMap("LogConfigs")]
                    [Validation(Required=false)]
                    public List<ListLDCContainerservicePodResponseBodyPodListContainersSpecLogConfigs> LogConfigs { get; set; }
                    public class ListLDCContainerservicePodResponseBodyPodListContainersSpecLogConfigs : TeaModel {
                        public string ConfigName { get; set; }
                        public string InputType { get; set; }
                        public string LogstoreName { get; set; }
                        public string LogPath { get; set; }
                    }
                    [NameInMap("VolumeMounts")]
                    [Validation(Required=false)]
                    public List<ListLDCContainerservicePodResponseBodyPodListContainersSpecVolumeMounts> VolumeMounts { get; set; }
                    public class ListLDCContainerservicePodResponseBodyPodListContainersSpecVolumeMounts : TeaModel {
                        public string MountPath { get; set; }
                        public string Name { get; set; }
                        public bool? ReadOnly { get; set; }
                        public string SubPath { get; set; }
                        public string VolumeSourceCategoryType { get; set; }
                        public ListLDCContainerservicePodResponseBodyPodListContainersSpecVolumeMountsConfigmapSecretVolumeSource ConfigmapSecretVolumeSource { get; set; }
                        public class ListLDCContainerservicePodResponseBodyPodListContainersSpecVolumeMountsConfigmapSecretVolumeSource : TeaModel {
                            [NameInMap("VolumeRefName")]
                            [Validation(Required=false)]
                            public string VolumeRefName { get; set; }

                        }
                        public ListLDCContainerservicePodResponseBodyPodListContainersSpecVolumeMountsEmptyDirVolumeSource EmptyDirVolumeSource { get; set; }
                        public class ListLDCContainerservicePodResponseBodyPodListContainersSpecVolumeMountsEmptyDirVolumeSource : TeaModel {
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
                        public ListLDCContainerservicePodResponseBodyPodListContainersSpecVolumeMountsLocalDiskVolumeSource LocalDiskVolumeSource { get; set; }
                        public class ListLDCContainerservicePodResponseBodyPodListContainersSpecVolumeMountsLocalDiskVolumeSource : TeaModel {
                            [NameInMap("CreateIfNotPresent")]
                            [Validation(Required=false)]
                            public bool? CreateIfNotPresent { get; set; }

                            [NameInMap("HostDirectoryPath")]
                            [Validation(Required=false)]
                            public string HostDirectoryPath { get; set; }

                        }
                        public ListLDCContainerservicePodResponseBodyPodListContainersSpecVolumeMountsPvcSource PvcSource { get; set; }
                        public class ListLDCContainerservicePodResponseBodyPodListContainersSpecVolumeMountsPvcSource : TeaModel {
                            [NameInMap("PvcName")]
                            [Validation(Required=false)]
                            public string PvcName { get; set; }

                        }
                    }
                    [NameInMap("HealthCheckConfig")]
                    [Validation(Required=false)]
                    public ListLDCContainerservicePodResponseBodyPodListContainersSpecHealthCheckConfig HealthCheckConfig { get; set; }
                    public class ListLDCContainerservicePodResponseBodyPodListContainersSpecHealthCheckConfig : TeaModel {
                        [NameInMap("LivenessProbe")]
                        [Validation(Required=false)]
                        public ListLDCContainerservicePodResponseBodyPodListContainersSpecHealthCheckConfigLivenessProbe LivenessProbe { get; set; }
                        public class ListLDCContainerservicePodResponseBodyPodListContainersSpecHealthCheckConfigLivenessProbe : TeaModel {
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
                            public ListLDCContainerservicePodResponseBodyPodListContainersSpecHealthCheckConfigLivenessProbeExecAction ExecAction { get; set; }
                            public class ListLDCContainerservicePodResponseBodyPodListContainersSpecHealthCheckConfigLivenessProbeExecAction : TeaModel {
                                [NameInMap("Command")]
                                [Validation(Required=false)]
                                public string Command { get; set; }

                            }
                            [NameInMap("HttpGetAction")]
                            [Validation(Required=false)]
                            public ListLDCContainerservicePodResponseBodyPodListContainersSpecHealthCheckConfigLivenessProbeHttpGetAction HttpGetAction { get; set; }
                            public class ListLDCContainerservicePodResponseBodyPodListContainersSpecHealthCheckConfigLivenessProbeHttpGetAction : TeaModel {
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
                            public ListLDCContainerservicePodResponseBodyPodListContainersSpecHealthCheckConfigLivenessProbeTcpSocketAction TcpSocketAction { get; set; }
                            public class ListLDCContainerservicePodResponseBodyPodListContainersSpecHealthCheckConfigLivenessProbeTcpSocketAction : TeaModel {
                                [NameInMap("Port")]
                                [Validation(Required=false)]
                                public string Port { get; set; }

                            }
                        };

                        [NameInMap("ReadinessProbe")]
                        [Validation(Required=false)]
                        public ListLDCContainerservicePodResponseBodyPodListContainersSpecHealthCheckConfigReadinessProbe ReadinessProbe { get; set; }
                        public class ListLDCContainerservicePodResponseBodyPodListContainersSpecHealthCheckConfigReadinessProbe : TeaModel {
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
                            public ListLDCContainerservicePodResponseBodyPodListContainersSpecHealthCheckConfigReadinessProbeExecAction ExecAction { get; set; }
                            public class ListLDCContainerservicePodResponseBodyPodListContainersSpecHealthCheckConfigReadinessProbeExecAction : TeaModel {
                                [NameInMap("Command")]
                                [Validation(Required=false)]
                                public string Command { get; set; }

                            }
                            [NameInMap("HttpGetAction")]
                            [Validation(Required=false)]
                            public ListLDCContainerservicePodResponseBodyPodListContainersSpecHealthCheckConfigReadinessProbeHttpGetAction HttpGetAction { get; set; }
                            public class ListLDCContainerservicePodResponseBodyPodListContainersSpecHealthCheckConfigReadinessProbeHttpGetAction : TeaModel {
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
                            public ListLDCContainerservicePodResponseBodyPodListContainersSpecHealthCheckConfigReadinessProbeTcpSocketAction TcpSocketAction { get; set; }
                            public class ListLDCContainerservicePodResponseBodyPodListContainersSpecHealthCheckConfigReadinessProbeTcpSocketAction : TeaModel {
                                [NameInMap("Port")]
                                [Validation(Required=false)]
                                public string Port { get; set; }

                            }
                        };

                    }
                    [NameInMap("LifecycleHook")]
                    [Validation(Required=false)]
                    public ListLDCContainerservicePodResponseBodyPodListContainersSpecLifecycleHook LifecycleHook { get; set; }
                    public class ListLDCContainerservicePodResponseBodyPodListContainersSpecLifecycleHook : TeaModel {
                        [NameInMap("PostStartExec")]
                        [Validation(Required=false)]
                        public ListLDCContainerservicePodResponseBodyPodListContainersSpecLifecycleHookPostStartExec PostStartExec { get; set; }
                        public class ListLDCContainerservicePodResponseBodyPodListContainersSpecLifecycleHookPostStartExec : TeaModel {
                            [NameInMap("Command")]
                            [Validation(Required=false)]
                            public string Command { get; set; }
                        };

                        [NameInMap("PostStartHttp")]
                        [Validation(Required=false)]
                        public ListLDCContainerservicePodResponseBodyPodListContainersSpecLifecycleHookPostStartHttp PostStartHttp { get; set; }
                        public class ListLDCContainerservicePodResponseBodyPodListContainersSpecLifecycleHookPostStartHttp : TeaModel {
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
                        public ListLDCContainerservicePodResponseBodyPodListContainersSpecLifecycleHookPostStartTcp PostStartTcp { get; set; }
                        public class ListLDCContainerservicePodResponseBodyPodListContainersSpecLifecycleHookPostStartTcp : TeaModel {
                            [NameInMap("Port")]
                            [Validation(Required=false)]
                            public string Port { get; set; }
                        };

                        [NameInMap("PreStopExec")]
                        [Validation(Required=false)]
                        public ListLDCContainerservicePodResponseBodyPodListContainersSpecLifecycleHookPreStopExec PreStopExec { get; set; }
                        public class ListLDCContainerservicePodResponseBodyPodListContainersSpecLifecycleHookPreStopExec : TeaModel {
                            [NameInMap("Command")]
                            [Validation(Required=false)]
                            public string Command { get; set; }
                        };

                        [NameInMap("PreStopHttp")]
                        [Validation(Required=false)]
                        public ListLDCContainerservicePodResponseBodyPodListContainersSpecLifecycleHookPreStopHttp PreStopHttp { get; set; }
                        public class ListLDCContainerservicePodResponseBodyPodListContainersSpecLifecycleHookPreStopHttp : TeaModel {
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
                        public ListLDCContainerservicePodResponseBodyPodListContainersSpecLifecycleHookPreStopTcp PreStopTcp { get; set; }
                        public class ListLDCContainerservicePodResponseBodyPodListContainersSpecLifecycleHookPreStopTcp : TeaModel {
                            [NameInMap("Port")]
                            [Validation(Required=false)]
                            public string Port { get; set; }
                        };

                    }
                };

            }

            [NameInMap("Volumes")]
            [Validation(Required=false)]
            public List<ListLDCContainerservicePodResponseBodyPodListVolumes> Volumes { get; set; }
            public class ListLDCContainerservicePodResponseBodyPodListVolumes : TeaModel {
                [NameInMap("HostPath")]
                [Validation(Required=false)]
                public string HostPath { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ReadOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                [NameInMap("RefResourceName")]
                [Validation(Required=false)]
                public string RefResourceName { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public ListLDCContainerservicePodResponseBodyPodListStatus Status { get; set; }
            public class ListLDCContainerservicePodResponseBodyPodListStatus : TeaModel {
                [NameInMap("HostIp")]
                [Validation(Required=false)]
                public string HostIp { get; set; }
                [NameInMap("Phase")]
                [Validation(Required=false)]
                public string Phase { get; set; }
                [NameInMap("PodIp")]
                [Validation(Required=false)]
                public string PodIp { get; set; }
                [NameInMap("ContainerStatuses")]
                [Validation(Required=false)]
                public List<ListLDCContainerservicePodResponseBodyPodListStatusContainerStatuses> ContainerStatuses { get; set; }
                public class ListLDCContainerservicePodResponseBodyPodListStatusContainerStatuses : TeaModel {
                    public string ContainerId { get; set; }
                    public string Image { get; set; }
                    public string LastStartTime { get; set; }
                    public string Name { get; set; }
                    public bool? Ready { get; set; }
                    public long? RestartCount { get; set; }
                    public ListLDCContainerservicePodResponseBodyPodListStatusContainerStatusesState State { get; set; }
                    public class ListLDCContainerservicePodResponseBodyPodListStatusContainerStatusesState : TeaModel {
                        [NameInMap("Running")]
                        [Validation(Required=false)]
                        public ListLDCContainerservicePodResponseBodyPodListStatusContainerStatusesStateRunning Running { get; set; }
                        public class ListLDCContainerservicePodResponseBodyPodListStatusContainerStatusesStateRunning : TeaModel {
                            [NameInMap("StartedAt")]
                            [Validation(Required=false)]
                            public string StartedAt { get; set; }
                        };

                        [NameInMap("Terminated")]
                        [Validation(Required=false)]
                        public ListLDCContainerservicePodResponseBodyPodListStatusContainerStatusesStateTerminated Terminated { get; set; }
                        public class ListLDCContainerservicePodResponseBodyPodListStatusContainerStatusesStateTerminated : TeaModel {
                            [NameInMap("ContainerId")]
                            [Validation(Required=false)]
                            public string ContainerId { get; set; }
                            [NameInMap("ExitCode")]
                            [Validation(Required=false)]
                            public long? ExitCode { get; set; }
                            [NameInMap("FinishedAt")]
                            [Validation(Required=false)]
                            public string FinishedAt { get; set; }
                            [NameInMap("Message")]
                            [Validation(Required=false)]
                            public string Message { get; set; }
                            [NameInMap("Reason")]
                            [Validation(Required=false)]
                            public string Reason { get; set; }
                            [NameInMap("Signal")]
                            [Validation(Required=false)]
                            public string Signal { get; set; }
                            [NameInMap("StartedAt")]
                            [Validation(Required=false)]
                            public string StartedAt { get; set; }
                        };

                        [NameInMap("Waiting")]
                        [Validation(Required=false)]
                        public ListLDCContainerservicePodResponseBodyPodListStatusContainerStatusesStateWaiting Waiting { get; set; }
                        public class ListLDCContainerservicePodResponseBodyPodListStatusContainerStatusesStateWaiting : TeaModel {
                            [NameInMap("Message")]
                            [Validation(Required=false)]
                            public string Message { get; set; }
                            [NameInMap("Reason")]
                            [Validation(Required=false)]
                            public string Reason { get; set; }
                        };

                    }
                }
            };

        }

    }

}
