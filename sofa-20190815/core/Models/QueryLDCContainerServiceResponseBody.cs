// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLDCContainerServiceResponseBody : TeaModel {
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

        [NameInMap("ContainerServiceList")]
        [Validation(Required=false)]
        public List<QueryLDCContainerServiceResponseBodyContainerServiceList> ContainerServiceList { get; set; }
        public class QueryLDCContainerServiceResponseBodyContainerServiceList : TeaModel {
            [NameInMap("AppBuild")]
            [Validation(Required=false)]
            public string AppBuild { get; set; }

            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            [NameInMap("CurrentImage")]
            [Validation(Required=false)]
            public string CurrentImage { get; set; }

            [NameInMap("DeployingRevision")]
            [Validation(Required=false)]
            public string DeployingRevision { get; set; }

            [NameInMap("DeploymentStatus")]
            [Validation(Required=false)]
            public string DeploymentStatus { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DraftedRevision")]
            [Validation(Required=false)]
            public string DraftedRevision { get; set; }

            [NameInMap("DraftedTime")]
            [Validation(Required=false)]
            public string DraftedTime { get; set; }

            [NameInMap("LastDeployedRevision")]
            [Validation(Required=false)]
            public string LastDeployedRevision { get; set; }

            [NameInMap("LastDeployEndTime")]
            [Validation(Required=false)]
            public string LastDeployEndTime { get; set; }

            [NameInMap("LastDeployPlanId")]
            [Validation(Required=false)]
            public string LastDeployPlanId { get; set; }

            [NameInMap("LastDeployStartTime")]
            [Validation(Required=false)]
            public string LastDeployStartTime { get; set; }

            [NameInMap("MetadataStatus")]
            [Validation(Required=false)]
            public string MetadataStatus { get; set; }

            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("ProcessingCount")]
            [Validation(Required=false)]
            public string ProcessingCount { get; set; }

            [NameInMap("Replicas")]
            [Validation(Required=false)]
            public string Replicas { get; set; }

            [NameInMap("RunningCount")]
            [Validation(Required=false)]
            public string RunningCount { get; set; }

            [NameInMap("RuntimeRevision")]
            [Validation(Required=false)]
            public string RuntimeRevision { get; set; }

            [NameInMap("WorkspaceGroup")]
            [Validation(Required=false)]
            public string WorkspaceGroup { get; set; }

            [NameInMap("PodList")]
            [Validation(Required=false)]
            public List<QueryLDCContainerServiceResponseBodyContainerServiceListPodList> PodList { get; set; }
            public class QueryLDCContainerServiceResponseBodyContainerServiceListPodList : TeaModel {
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
                public List<QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainers> Containers { get; set; }
                public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainers : TeaModel {
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
                    public QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpec Spec { get; set; }
                    public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpec : TeaModel {
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
                        public List<QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecEnvs> Envs { get; set; }
                        public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecEnvs : TeaModel {
                            public string Name { get; set; }
                            public string Type { get; set; }
                            public string Value { get; set; }
                            public QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecEnvsValueFrom ValueFrom { get; set; }
                            public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecEnvsValueFrom : TeaModel {
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
                        public List<QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecEnvOverrides> EnvOverrides { get; set; }
                        public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecEnvOverrides : TeaModel {
                            public string Cell { get; set; }
                            public string Name { get; set; }
                            public string Value { get; set; }
                        }
                        [NameInMap("LogConfigs")]
                        [Validation(Required=false)]
                        public List<QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecLogConfigs> LogConfigs { get; set; }
                        public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecLogConfigs : TeaModel {
                            public string ConfigName { get; set; }
                            public string InputType { get; set; }
                            public string LogstoreName { get; set; }
                            public string LogPath { get; set; }
                        }
                        [NameInMap("VolumeMounts")]
                        [Validation(Required=false)]
                        public List<QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecVolumeMounts> VolumeMounts { get; set; }
                        public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecVolumeMounts : TeaModel {
                            public string MountPath { get; set; }
                            public string Name { get; set; }
                            public bool? ReadOnly { get; set; }
                            public string SubPath { get; set; }
                            public string VolumeSourceCategoryType { get; set; }
                            public QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecVolumeMountsConfigmapSecretVolumeSource ConfigmapSecretVolumeSource { get; set; }
                            public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecVolumeMountsConfigmapSecretVolumeSource : TeaModel {
                                [NameInMap("VolumeRefName")]
                                [Validation(Required=false)]
                                public string VolumeRefName { get; set; }

                            }
                            public QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecVolumeMountsEmptyDirVolumeSource EmptyDirVolumeSource { get; set; }
                            public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecVolumeMountsEmptyDirVolumeSource : TeaModel {
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
                            public QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecVolumeMountsLocalDiskVolumeSource LocalDiskVolumeSource { get; set; }
                            public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecVolumeMountsLocalDiskVolumeSource : TeaModel {
                                [NameInMap("CreateIfNotPresent")]
                                [Validation(Required=false)]
                                public bool? CreateIfNotPresent { get; set; }

                                [NameInMap("HostDirectoryPath")]
                                [Validation(Required=false)]
                                public string HostDirectoryPath { get; set; }

                            }
                            public QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecVolumeMountsPvcSource PvcSource { get; set; }
                            public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecVolumeMountsPvcSource : TeaModel {
                                [NameInMap("PvcName")]
                                [Validation(Required=false)]
                                public string PvcName { get; set; }

                            }
                        }
                        [NameInMap("HealthCheckConfig")]
                        [Validation(Required=false)]
                        public QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecHealthCheckConfig HealthCheckConfig { get; set; }
                        public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecHealthCheckConfig : TeaModel {
                            [NameInMap("LivenessProbe")]
                            [Validation(Required=false)]
                            public QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecHealthCheckConfigLivenessProbe LivenessProbe { get; set; }
                            public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecHealthCheckConfigLivenessProbe : TeaModel {
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
                                public QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecHealthCheckConfigLivenessProbeExecAction ExecAction { get; set; }
                                public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecHealthCheckConfigLivenessProbeExecAction : TeaModel {
                                    [NameInMap("Command")]
                                    [Validation(Required=false)]
                                    public string Command { get; set; }

                                }
                                [NameInMap("HttpGetAction")]
                                [Validation(Required=false)]
                                public QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecHealthCheckConfigLivenessProbeHttpGetAction HttpGetAction { get; set; }
                                public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecHealthCheckConfigLivenessProbeHttpGetAction : TeaModel {
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
                                public QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecHealthCheckConfigLivenessProbeTcpSocketAction TcpSocketAction { get; set; }
                                public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecHealthCheckConfigLivenessProbeTcpSocketAction : TeaModel {
                                    [NameInMap("Port")]
                                    [Validation(Required=false)]
                                    public string Port { get; set; }

                                }
                            };

                            [NameInMap("ReadinessProbe")]
                            [Validation(Required=false)]
                            public QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecHealthCheckConfigReadinessProbe ReadinessProbe { get; set; }
                            public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecHealthCheckConfigReadinessProbe : TeaModel {
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
                                public QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecHealthCheckConfigReadinessProbeExecAction ExecAction { get; set; }
                                public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecHealthCheckConfigReadinessProbeExecAction : TeaModel {
                                    [NameInMap("Command")]
                                    [Validation(Required=false)]
                                    public string Command { get; set; }

                                }
                                [NameInMap("HttpGetAction")]
                                [Validation(Required=false)]
                                public QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecHealthCheckConfigReadinessProbeHttpGetAction HttpGetAction { get; set; }
                                public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecHealthCheckConfigReadinessProbeHttpGetAction : TeaModel {
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
                                public QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecHealthCheckConfigReadinessProbeTcpSocketAction TcpSocketAction { get; set; }
                                public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecHealthCheckConfigReadinessProbeTcpSocketAction : TeaModel {
                                    [NameInMap("Port")]
                                    [Validation(Required=false)]
                                    public string Port { get; set; }

                                }
                            };

                        }
                        [NameInMap("LifecycleHook")]
                        [Validation(Required=false)]
                        public QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecLifecycleHook LifecycleHook { get; set; }
                        public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecLifecycleHook : TeaModel {
                            [NameInMap("PostStartExec")]
                            [Validation(Required=false)]
                            public QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecLifecycleHookPostStartExec PostStartExec { get; set; }
                            public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecLifecycleHookPostStartExec : TeaModel {
                                [NameInMap("Command")]
                                [Validation(Required=false)]
                                public string Command { get; set; }
                            };

                            [NameInMap("PostStartHttp")]
                            [Validation(Required=false)]
                            public QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecLifecycleHookPostStartHttp PostStartHttp { get; set; }
                            public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecLifecycleHookPostStartHttp : TeaModel {
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
                            public QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecLifecycleHookPostStartTcp PostStartTcp { get; set; }
                            public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecLifecycleHookPostStartTcp : TeaModel {
                                [NameInMap("Port")]
                                [Validation(Required=false)]
                                public string Port { get; set; }
                            };

                            [NameInMap("PreStopExec")]
                            [Validation(Required=false)]
                            public QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecLifecycleHookPreStopExec PreStopExec { get; set; }
                            public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecLifecycleHookPreStopExec : TeaModel {
                                [NameInMap("Command")]
                                [Validation(Required=false)]
                                public string Command { get; set; }
                            };

                            [NameInMap("PreStopHttp")]
                            [Validation(Required=false)]
                            public QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecLifecycleHookPreStopHttp PreStopHttp { get; set; }
                            public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecLifecycleHookPreStopHttp : TeaModel {
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
                            public QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecLifecycleHookPreStopTcp PreStopTcp { get; set; }
                            public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListContainersSpecLifecycleHookPreStopTcp : TeaModel {
                                [NameInMap("Port")]
                                [Validation(Required=false)]
                                public string Port { get; set; }
                            };

                        }
                    };

                }

                [NameInMap("Volumes")]
                [Validation(Required=false)]
                public List<QueryLDCContainerServiceResponseBodyContainerServiceListPodListVolumes> Volumes { get; set; }
                public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListVolumes : TeaModel {
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
                public QueryLDCContainerServiceResponseBodyContainerServiceListPodListStatus Status { get; set; }
                public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListStatus : TeaModel {
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
                    public List<QueryLDCContainerServiceResponseBodyContainerServiceListPodListStatusContainerStatuses> ContainerStatuses { get; set; }
                    public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListStatusContainerStatuses : TeaModel {
                        public string ContainerId { get; set; }
                        public string Image { get; set; }
                        public string LastStartTime { get; set; }
                        public string Name { get; set; }
                        public bool? Ready { get; set; }
                        public long? RestartCount { get; set; }
                        public QueryLDCContainerServiceResponseBodyContainerServiceListPodListStatusContainerStatusesState State { get; set; }
                        public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListStatusContainerStatusesState : TeaModel {
                            [NameInMap("Running")]
                            [Validation(Required=false)]
                            public QueryLDCContainerServiceResponseBodyContainerServiceListPodListStatusContainerStatusesStateRunning Running { get; set; }
                            public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListStatusContainerStatusesStateRunning : TeaModel {
                                [NameInMap("StartedAt")]
                                [Validation(Required=false)]
                                public string StartedAt { get; set; }
                            };

                            [NameInMap("Terminated")]
                            [Validation(Required=false)]
                            public QueryLDCContainerServiceResponseBodyContainerServiceListPodListStatusContainerStatusesStateTerminated Terminated { get; set; }
                            public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListStatusContainerStatusesStateTerminated : TeaModel {
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
                            public QueryLDCContainerServiceResponseBodyContainerServiceListPodListStatusContainerStatusesStateWaiting Waiting { get; set; }
                            public class QueryLDCContainerServiceResponseBodyContainerServiceListPodListStatusContainerStatusesStateWaiting : TeaModel {
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

            [NameInMap("ServiceList")]
            [Validation(Required=false)]
            public List<QueryLDCContainerServiceResponseBodyContainerServiceListServiceList> ServiceList { get; set; }
            public class QueryLDCContainerServiceResponseBodyContainerServiceListServiceList : TeaModel {
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
                public List<QueryLDCContainerServiceResponseBodyContainerServiceListServiceListCellSlbIaasIdMap> CellSlbIaasIdMap { get; set; }
                public class QueryLDCContainerServiceResponseBodyContainerServiceListServiceListCellSlbIaasIdMap : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Listeners")]
                [Validation(Required=false)]
                public List<QueryLDCContainerServiceResponseBodyContainerServiceListServiceListListeners> Listeners { get; set; }
                public class QueryLDCContainerServiceResponseBodyContainerServiceListServiceListListeners : TeaModel {
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

        }

    }

}
