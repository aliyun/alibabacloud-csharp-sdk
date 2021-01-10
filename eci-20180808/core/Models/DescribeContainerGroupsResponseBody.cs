// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeContainerGroupsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ContainerGroups")]
        [Validation(Required=false)]
        public List<DescribeContainerGroupsResponseBodyContainerGroups> ContainerGroups { get; set; }
        public class DescribeContainerGroupsResponseBodyContainerGroups : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            [NameInMap("TenantSecurityGroupId")]
            [Validation(Required=false)]
            public string TenantSecurityGroupId { get; set; }

            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            [NameInMap("HostAliases")]
            [Validation(Required=false)]
            public List<DescribeContainerGroupsResponseBodyContainerGroupsHostAliases> HostAliases { get; set; }
            public class DescribeContainerGroupsResponseBodyContainerGroupsHostAliases : TeaModel {
                [NameInMap("Hostnames")]
                [Validation(Required=false)]
                public List<string> Hostnames { get; set; }

                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

            }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeContainerGroupsResponseBodyContainerGroupsTags> Tags { get; set; }
            public class DescribeContainerGroupsResponseBodyContainerGroupsTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Events")]
            [Validation(Required=false)]
            public List<DescribeContainerGroupsResponseBodyContainerGroupsEvents> Events { get; set; }
            public class DescribeContainerGroupsResponseBodyContainerGroupsEvents : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("LastTimestamp")]
                [Validation(Required=false)]
                public string LastTimestamp { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("FirstTimestamp")]
                [Validation(Required=false)]
                public string FirstTimestamp { get; set; }

            }

            [NameInMap("SucceededTime")]
            [Validation(Required=false)]
            public string SucceededTime { get; set; }

            [NameInMap("SpotStrategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            [NameInMap("EphemeralStorage")]
            [Validation(Required=false)]
            public int? EphemeralStorage { get; set; }

            [NameInMap("TenantEniInstanceId")]
            [Validation(Required=false)]
            public string TenantEniInstanceId { get; set; }

            [NameInMap("Discount")]
            [Validation(Required=false)]
            public int? Discount { get; set; }

            [NameInMap("RestartPolicy")]
            [Validation(Required=false)]
            public string RestartPolicy { get; set; }

            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            [NameInMap("TenantVSwitchId")]
            [Validation(Required=false)]
            public string TenantVSwitchId { get; set; }

            [NameInMap("Containers")]
            [Validation(Required=false)]
            public List<DescribeContainerGroupsResponseBodyContainerGroupsContainers> Containers { get; set; }
            public class DescribeContainerGroupsResponseBodyContainerGroupsContainers : TeaModel {
                [NameInMap("LivenessProbe")]
                [Validation(Required=false)]
                public DescribeContainerGroupsResponseBodyContainerGroupsContainersLivenessProbe LivenessProbe { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsContainersLivenessProbe : TeaModel {
                    [NameInMap("SuccessThreshold")]
                    [Validation(Required=false)]
                    public int? SuccessThreshold { get; set; }
                    [NameInMap("InitialDelaySeconds")]
                    [Validation(Required=false)]
                    public int? InitialDelaySeconds { get; set; }
                    [NameInMap("FailureThreshold")]
                    [Validation(Required=false)]
                    public int? FailureThreshold { get; set; }
                    [NameInMap("TimeoutSeconds")]
                    [Validation(Required=false)]
                    public int? TimeoutSeconds { get; set; }
                    [NameInMap("TcpSocket")]
                    [Validation(Required=false)]
                    public DescribeContainerGroupsResponseBodyContainerGroupsContainersLivenessProbeTcpSocket TcpSocket { get; set; }
                    public class DescribeContainerGroupsResponseBodyContainerGroupsContainersLivenessProbeTcpSocket : TeaModel {
                        [NameInMap("Host")]
                        [Validation(Required=false)]
                        public string Host { get; set; }

                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                    }
                    [NameInMap("Execs")]
                    [Validation(Required=false)]
                    public List<string> Execs { get; set; }
                    [NameInMap("HttpGet")]
                    [Validation(Required=false)]
                    public DescribeContainerGroupsResponseBodyContainerGroupsContainersLivenessProbeHttpGet HttpGet { get; set; }
                    public class DescribeContainerGroupsResponseBodyContainerGroupsContainersLivenessProbeHttpGet : TeaModel {
                        [NameInMap("Scheme")]
                        [Validation(Required=false)]
                        public string Scheme { get; set; }

                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                    }
                    [NameInMap("PeriodSeconds")]
                    [Validation(Required=false)]
                    public int? PeriodSeconds { get; set; }
                };

                [NameInMap("Commands")]
                [Validation(Required=false)]
                public List<string> Commands { get; set; }

                [NameInMap("VolumeMounts")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupsResponseBodyContainerGroupsContainersVolumeMounts> VolumeMounts { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsContainersVolumeMounts : TeaModel {
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                    [NameInMap("ReadOnly")]
                    [Validation(Required=false)]
                    public bool? ReadOnly { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("Args")]
                [Validation(Required=false)]
                public List<string> Args { get; set; }

                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                [NameInMap("Ports")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupsResponseBodyContainerGroupsContainersPorts> Ports { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsContainersPorts : TeaModel {
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                }

                [NameInMap("RestartCount")]
                [Validation(Required=false)]
                public int? RestartCount { get; set; }

                [NameInMap("ImagePullPolicy")]
                [Validation(Required=false)]
                public string ImagePullPolicy { get; set; }

                [NameInMap("StdinOnce")]
                [Validation(Required=false)]
                public bool? StdinOnce { get; set; }

                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                [NameInMap("PreviousState")]
                [Validation(Required=false)]
                public DescribeContainerGroupsResponseBodyContainerGroupsContainersPreviousState PreviousState { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsContainersPreviousState : TeaModel {
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }
                    [NameInMap("FinishTime")]
                    [Validation(Required=false)]
                    public string FinishTime { get; set; }
                    [NameInMap("DetailStatus")]
                    [Validation(Required=false)]
                    public string DetailStatus { get; set; }
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }
                    [NameInMap("Signal")]
                    [Validation(Required=false)]
                    public int? Signal { get; set; }
                    [NameInMap("ExitCode")]
                    [Validation(Required=false)]
                    public int? ExitCode { get; set; }
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }
                };

                [NameInMap("Tty")]
                [Validation(Required=false)]
                public bool? Tty { get; set; }

                [NameInMap("WorkingDir")]
                [Validation(Required=false)]
                public string WorkingDir { get; set; }

                [NameInMap("CurrentState")]
                [Validation(Required=false)]
                public DescribeContainerGroupsResponseBodyContainerGroupsContainersCurrentState CurrentState { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsContainersCurrentState : TeaModel {
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }
                    [NameInMap("FinishTime")]
                    [Validation(Required=false)]
                    public string FinishTime { get; set; }
                    [NameInMap("DetailStatus")]
                    [Validation(Required=false)]
                    public string DetailStatus { get; set; }
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }
                    [NameInMap("Signal")]
                    [Validation(Required=false)]
                    public int? Signal { get; set; }
                    [NameInMap("ExitCode")]
                    [Validation(Required=false)]
                    public int? ExitCode { get; set; }
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }
                };

                [NameInMap("Ready")]
                [Validation(Required=false)]
                public bool? Ready { get; set; }

                [NameInMap("Gpu")]
                [Validation(Required=false)]
                public int? Gpu { get; set; }

                [NameInMap("SecurityContext")]
                [Validation(Required=false)]
                public DescribeContainerGroupsResponseBodyContainerGroupsContainersSecurityContext SecurityContext { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsContainersSecurityContext : TeaModel {
                    [NameInMap("ReadOnlyRootFilesystem")]
                    [Validation(Required=false)]
                    public bool? ReadOnlyRootFilesystem { get; set; }
                    [NameInMap("RunAsUser")]
                    [Validation(Required=false)]
                    public long? RunAsUser { get; set; }
                    [NameInMap("Capability")]
                    [Validation(Required=false)]
                    public DescribeContainerGroupsResponseBodyContainerGroupsContainersSecurityContextCapability Capability { get; set; }
                    public class DescribeContainerGroupsResponseBodyContainerGroupsContainersSecurityContextCapability : TeaModel {
                        [NameInMap("Adds")]
                        [Validation(Required=false)]
                        public List<string> Adds { get; set; }

                    }
                };

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public float? Memory { get; set; }

                [NameInMap("Stdin")]
                [Validation(Required=false)]
                public bool? Stdin { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("EnvironmentVars")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupsResponseBodyContainerGroupsContainersEnvironmentVars> EnvironmentVars { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsContainersEnvironmentVars : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    [NameInMap("ValueFrom")]
                    [Validation(Required=false)]
                    public DescribeContainerGroupsResponseBodyContainerGroupsContainersEnvironmentVarsValueFrom ValueFrom { get; set; }
                    public class DescribeContainerGroupsResponseBodyContainerGroupsContainersEnvironmentVarsValueFrom : TeaModel {
                        [NameInMap("FieldRef")]
                        [Validation(Required=false)]
                        public DescribeContainerGroupsResponseBodyContainerGroupsContainersEnvironmentVarsValueFromFieldRef FieldRef { get; set; }
                        public class DescribeContainerGroupsResponseBodyContainerGroupsContainersEnvironmentVarsValueFromFieldRef : TeaModel {
                            [NameInMap("FieldPath")]
                            [Validation(Required=false)]
                            public string FieldPath { get; set; }

                        }
                    };

                }

                [NameInMap("ReadinessProbe")]
                [Validation(Required=false)]
                public DescribeContainerGroupsResponseBodyContainerGroupsContainersReadinessProbe ReadinessProbe { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsContainersReadinessProbe : TeaModel {
                    [NameInMap("SuccessThreshold")]
                    [Validation(Required=false)]
                    public int? SuccessThreshold { get; set; }
                    [NameInMap("InitialDelaySeconds")]
                    [Validation(Required=false)]
                    public int? InitialDelaySeconds { get; set; }
                    [NameInMap("FailureThreshold")]
                    [Validation(Required=false)]
                    public int? FailureThreshold { get; set; }
                    [NameInMap("TimeoutSeconds")]
                    [Validation(Required=false)]
                    public int? TimeoutSeconds { get; set; }
                    [NameInMap("TcpSocket")]
                    [Validation(Required=false)]
                    public DescribeContainerGroupsResponseBodyContainerGroupsContainersReadinessProbeTcpSocket TcpSocket { get; set; }
                    public class DescribeContainerGroupsResponseBodyContainerGroupsContainersReadinessProbeTcpSocket : TeaModel {
                        [NameInMap("Host")]
                        [Validation(Required=false)]
                        public string Host { get; set; }

                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                    }
                    [NameInMap("Execs")]
                    [Validation(Required=false)]
                    public List<string> Execs { get; set; }
                    [NameInMap("HttpGet")]
                    [Validation(Required=false)]
                    public DescribeContainerGroupsResponseBodyContainerGroupsContainersReadinessProbeHttpGet HttpGet { get; set; }
                    public class DescribeContainerGroupsResponseBodyContainerGroupsContainersReadinessProbeHttpGet : TeaModel {
                        [NameInMap("Scheme")]
                        [Validation(Required=false)]
                        public string Scheme { get; set; }

                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                    }
                    [NameInMap("PeriodSeconds")]
                    [Validation(Required=false)]
                    public int? PeriodSeconds { get; set; }
                };

            }

            [NameInMap("EniInstanceId")]
            [Validation(Required=false)]
            public string EniInstanceId { get; set; }

            [NameInMap("InitContainers")]
            [Validation(Required=false)]
            public List<DescribeContainerGroupsResponseBodyContainerGroupsInitContainers> InitContainers { get; set; }
            public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainers : TeaModel {
                [NameInMap("VolumeMounts")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupsResponseBodyContainerGroupsInitContainersVolumeMounts> VolumeMounts { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainersVolumeMounts : TeaModel {
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                    [NameInMap("ReadOnly")]
                    [Validation(Required=false)]
                    public bool? ReadOnly { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("Args")]
                [Validation(Required=false)]
                public List<string> Args { get; set; }

                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                [NameInMap("Ports")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupsResponseBodyContainerGroupsInitContainersPorts> Ports { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainersPorts : TeaModel {
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                }

                [NameInMap("RestartCount")]
                [Validation(Required=false)]
                public int? RestartCount { get; set; }

                [NameInMap("ImagePullPolicy")]
                [Validation(Required=false)]
                public string ImagePullPolicy { get; set; }

                [NameInMap("PreviousState")]
                [Validation(Required=false)]
                public DescribeContainerGroupsResponseBodyContainerGroupsInitContainersPreviousState PreviousState { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainersPreviousState : TeaModel {
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }
                    [NameInMap("FinishTime")]
                    [Validation(Required=false)]
                    public string FinishTime { get; set; }
                    [NameInMap("DetailStatus")]
                    [Validation(Required=false)]
                    public string DetailStatus { get; set; }
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }
                    [NameInMap("Signal")]
                    [Validation(Required=false)]
                    public int? Signal { get; set; }
                    [NameInMap("ExitCode")]
                    [Validation(Required=false)]
                    public int? ExitCode { get; set; }
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }
                };

                [NameInMap("WorkingDir")]
                [Validation(Required=false)]
                public string WorkingDir { get; set; }

                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                [NameInMap("CurrentState")]
                [Validation(Required=false)]
                public DescribeContainerGroupsResponseBodyContainerGroupsInitContainersCurrentState CurrentState { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainersCurrentState : TeaModel {
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }
                    [NameInMap("FinishTime")]
                    [Validation(Required=false)]
                    public string FinishTime { get; set; }
                    [NameInMap("DetailStatus")]
                    [Validation(Required=false)]
                    public string DetailStatus { get; set; }
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }
                    [NameInMap("Signal")]
                    [Validation(Required=false)]
                    public int? Signal { get; set; }
                    [NameInMap("ExitCode")]
                    [Validation(Required=false)]
                    public int? ExitCode { get; set; }
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }
                };

                [NameInMap("Command")]
                [Validation(Required=false)]
                public List<string> Command { get; set; }

                [NameInMap("Ready")]
                [Validation(Required=false)]
                public bool? Ready { get; set; }

                [NameInMap("Gpu")]
                [Validation(Required=false)]
                public int? Gpu { get; set; }

                [NameInMap("SecurityContext")]
                [Validation(Required=false)]
                public DescribeContainerGroupsResponseBodyContainerGroupsInitContainersSecurityContext SecurityContext { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainersSecurityContext : TeaModel {
                    [NameInMap("ReadOnlyRootFilesystem")]
                    [Validation(Required=false)]
                    public bool? ReadOnlyRootFilesystem { get; set; }
                    [NameInMap("RunAsUser")]
                    [Validation(Required=false)]
                    public long? RunAsUser { get; set; }
                    [NameInMap("Capability")]
                    [Validation(Required=false)]
                    public DescribeContainerGroupsResponseBodyContainerGroupsInitContainersSecurityContextCapability Capability { get; set; }
                    public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainersSecurityContextCapability : TeaModel {
                        [NameInMap("Adds")]
                        [Validation(Required=false)]
                        public List<string> Adds { get; set; }

                    }
                };

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public float? Memory { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("EnvironmentVars")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupsResponseBodyContainerGroupsInitContainersEnvironmentVars> EnvironmentVars { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainersEnvironmentVars : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    [NameInMap("ValueFrom")]
                    [Validation(Required=false)]
                    public DescribeContainerGroupsResponseBodyContainerGroupsInitContainersEnvironmentVarsValueFrom ValueFrom { get; set; }
                    public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainersEnvironmentVarsValueFrom : TeaModel {
                        [NameInMap("FieldRef")]
                        [Validation(Required=false)]
                        public DescribeContainerGroupsResponseBodyContainerGroupsInitContainersEnvironmentVarsValueFromFieldRef FieldRef { get; set; }
                        public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainersEnvironmentVarsValueFromFieldRef : TeaModel {
                            [NameInMap("FieldPath")]
                            [Validation(Required=false)]
                            public string FieldPath { get; set; }

                        }
                    };

                }

            }

            [NameInMap("ContainerGroupId")]
            [Validation(Required=false)]
            public string ContainerGroupId { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("Ipv6Address")]
            [Validation(Required=false)]
            public string Ipv6Address { get; set; }

            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("DnsConfig")]
            [Validation(Required=false)]
            public DescribeContainerGroupsResponseBodyContainerGroupsDnsConfig DnsConfig { get; set; }
            public class DescribeContainerGroupsResponseBodyContainerGroupsDnsConfig : TeaModel {
                [NameInMap("Searches")]
                [Validation(Required=false)]
                public List<string> Searches { get; set; }
                [NameInMap("Options")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupsResponseBodyContainerGroupsDnsConfigOptions> Options { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsDnsConfigOptions : TeaModel {
                    public string Value { get; set; }
                    public string Name { get; set; }
                }
                [NameInMap("NameServers")]
                [Validation(Required=false)]
                public List<string> NameServers { get; set; }
            };

            [NameInMap("Volumes")]
            [Validation(Required=false)]
            public List<DescribeContainerGroupsResponseBodyContainerGroupsVolumes> Volumes { get; set; }
            public class DescribeContainerGroupsResponseBodyContainerGroupsVolumes : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("DiskVolumeDiskId")]
                [Validation(Required=false)]
                public string DiskVolumeDiskId { get; set; }

                [NameInMap("NFSVolumeReadOnly")]
                [Validation(Required=false)]
                public bool? NFSVolumeReadOnly { get; set; }

                [NameInMap("ConfigFileVolumeConfigFileToPaths")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupsResponseBodyContainerGroupsVolumesConfigFileVolumeConfigFileToPaths> ConfigFileVolumeConfigFileToPaths { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsVolumesConfigFileVolumeConfigFileToPaths : TeaModel {
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                }

                [NameInMap("FlexVolumeFsType")]
                [Validation(Required=false)]
                public string FlexVolumeFsType { get; set; }

                [NameInMap("FlexVolumeDriver")]
                [Validation(Required=false)]
                public string FlexVolumeDriver { get; set; }

                [NameInMap("DiskVolumeFsType")]
                [Validation(Required=false)]
                public string DiskVolumeFsType { get; set; }

                [NameInMap("FlexVolumeOptions")]
                [Validation(Required=false)]
                public string FlexVolumeOptions { get; set; }

                [NameInMap("NFSVolumeServer")]
                [Validation(Required=false)]
                public string NFSVolumeServer { get; set; }

                [NameInMap("NFSVolumePath")]
                [Validation(Required=false)]
                public string NFSVolumePath { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("RamRoleName")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public float? Cpu { get; set; }

            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("ContainerGroupName")]
            [Validation(Required=false)]
            public string ContainerGroupName { get; set; }

            [NameInMap("EciSecurityContext")]
            [Validation(Required=false)]
            public DescribeContainerGroupsResponseBodyContainerGroupsEciSecurityContext EciSecurityContext { get; set; }
            public class DescribeContainerGroupsResponseBodyContainerGroupsEciSecurityContext : TeaModel {
                [NameInMap("Sysctls")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupsResponseBodyContainerGroupsEciSecurityContextSysctls> Sysctls { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsEciSecurityContextSysctls : TeaModel {
                    public string Value { get; set; }
                    public string Name { get; set; }
                }
            };

            [NameInMap("FailedTime")]
            [Validation(Required=false)]
            public string FailedTime { get; set; }

        }

    }

}
