/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class CreateContainerGroupRequest : TeaModel {
        [NameInMap("DnsConfig")]
        [Validation(Required=false)]
        public CreateContainerGroupRequestDnsConfig DnsConfig { get; set; }
        public class CreateContainerGroupRequestDnsConfig : TeaModel {
            [NameInMap("NameServer")]
            [Validation(Required=false)]
            public List<string> NameServer { get; set; }
            [NameInMap("Search")]
            [Validation(Required=false)]
            public List<string> Search { get; set; }
            [NameInMap("Option")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestDnsConfigOption> Option { get; set; }
            public class CreateContainerGroupRequestDnsConfigOption : TeaModel {
                public string Value { get; set; }
                public string Name { get; set; }
            }
        };

        [NameInMap("SecurityContext")]
        [Validation(Required=false)]
        public CreateContainerGroupRequestSecurityContext SecurityContext { get; set; }
        public class CreateContainerGroupRequestSecurityContext : TeaModel {
            [NameInMap("Sysctl")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestSecurityContextSysctl> Sysctl { get; set; }
            public class CreateContainerGroupRequestSecurityContextSysctl : TeaModel {
                public string Value { get; set; }
                public string Name { get; set; }
            }
        };

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("ContainerGroupName")]
        [Validation(Required=false)]
        public string ContainerGroupName { get; set; }

        [NameInMap("RestartPolicy")]
        [Validation(Required=false)]
        public string RestartPolicy { get; set; }

        [NameInMap("EipInstanceId")]
        [Validation(Required=false)]
        public string EipInstanceId { get; set; }

        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("DnsPolicy")]
        [Validation(Required=false)]
        public string DnsPolicy { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("SlsEnable")]
        [Validation(Required=false)]
        public bool? SlsEnable { get; set; }

        [NameInMap("ImageSnapshotId")]
        [Validation(Required=false)]
        public string ImageSnapshotId { get; set; }

        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        [NameInMap("TerminationGracePeriodSeconds")]
        [Validation(Required=false)]
        public long? TerminationGracePeriodSeconds { get; set; }

        [NameInMap("AutoMatchImageCache")]
        [Validation(Required=false)]
        public bool? AutoMatchImageCache { get; set; }

        [NameInMap("VkClientVersion")]
        [Validation(Required=false)]
        public string VkClientVersion { get; set; }

        [NameInMap("Ipv6AddressCount")]
        [Validation(Required=false)]
        public int? Ipv6AddressCount { get; set; }

        [NameInMap("ActiveDeadlineSeconds")]
        [Validation(Required=false)]
        public long? ActiveDeadlineSeconds { get; set; }

        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public float? SpotPriceLimit { get; set; }

        [NameInMap("ScheduleStrategy")]
        [Validation(Required=false)]
        public string ScheduleStrategy { get; set; }

        [NameInMap("TenantVSwitchId")]
        [Validation(Required=false)]
        public string TenantVSwitchId { get; set; }

        [NameInMap("TenantSecurityGroupId")]
        [Validation(Required=false)]
        public string TenantSecurityGroupId { get; set; }

        [NameInMap("CorePattern")]
        [Validation(Required=false)]
        public string CorePattern { get; set; }

        [NameInMap("ShareProcessNamespace")]
        [Validation(Required=false)]
        public bool? ShareProcessNamespace { get; set; }

        [NameInMap("ProductOnEciMode")]
        [Validation(Required=false)]
        public string ProductOnEciMode { get; set; }

        [NameInMap("SecondaryENIPolicy")]
        [Validation(Required=false)]
        public string SecondaryENIPolicy { get; set; }

        [NameInMap("AutoCreateEip")]
        [Validation(Required=false)]
        public bool? AutoCreateEip { get; set; }

        [NameInMap("EipBandwidth")]
        [Validation(Required=false)]
        public int? EipBandwidth { get; set; }

        [NameInMap("EipISP")]
        [Validation(Required=false)]
        public string EipISP { get; set; }

        [NameInMap("EipCommonBandwidthPackage")]
        [Validation(Required=false)]
        public string EipCommonBandwidthPackage { get; set; }

        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        [NameInMap("IngressBandwidth")]
        [Validation(Required=false)]
        public long? IngressBandwidth { get; set; }

        [NameInMap("EgressBandwidth")]
        [Validation(Required=false)]
        public long? EgressBandwidth { get; set; }

        [NameInMap("CpuOptionsCore")]
        [Validation(Required=false)]
        public int? CpuOptionsCore { get; set; }

        [NameInMap("CpuOptionsThreadsPerCore")]
        [Validation(Required=false)]
        public int? CpuOptionsThreadsPerCore { get; set; }

        [NameInMap("CpuOptionsNuma")]
        [Validation(Required=false)]
        public string CpuOptionsNuma { get; set; }

        [NameInMap("EphemeralStorage")]
        [Validation(Required=false)]
        public int? EphemeralStorage { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateContainerGroupRequestTag> Tag { get; set; }
        public class CreateContainerGroupRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("ImageRegistryCredential")]
        [Validation(Required=false)]
        public List<CreateContainerGroupRequestImageRegistryCredential> ImageRegistryCredential { get; set; }
        public class CreateContainerGroupRequestImageRegistryCredential : TeaModel {
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            [NameInMap("Server")]
            [Validation(Required=false)]
            public string Server { get; set; }

            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("Container")]
        [Validation(Required=false)]
        public List<CreateContainerGroupRequestContainer> Container { get; set; }
        public class CreateContainerGroupRequestContainer : TeaModel {
            [NameInMap("ReadinessProbe")]
            [Validation(Required=true)]
            public CreateContainerGroupRequestContainerReadinessProbe ReadinessProbe { get; set; }
            public class CreateContainerGroupRequestContainerReadinessProbe : TeaModel {
                [NameInMap("TimeoutSeconds")]
                [Validation(Required=false)]
                public int? TimeoutSeconds { get; set; }
                [NameInMap("SuccessThreshold")]
                [Validation(Required=false)]
                public int? SuccessThreshold { get; set; }
                [NameInMap("TcpSocket")]
                [Validation(Required=true)]
                public CreateContainerGroupRequestContainerReadinessProbeTcpSocket TcpSocket { get; set; }
                public class CreateContainerGroupRequestContainerReadinessProbeTcpSocket : TeaModel {
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                }
                [NameInMap("HttpGet")]
                [Validation(Required=true)]
                public CreateContainerGroupRequestContainerReadinessProbeHttpGet HttpGet { get; set; }
                public class CreateContainerGroupRequestContainerReadinessProbeHttpGet : TeaModel {
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
                [NameInMap("InitialDelaySeconds")]
                [Validation(Required=false)]
                public int? InitialDelaySeconds { get; set; }
                [NameInMap("Exec")]
                [Validation(Required=true)]
                public CreateContainerGroupRequestContainerReadinessProbeExec Exec { get; set; }
                public class CreateContainerGroupRequestContainerReadinessProbeExec : TeaModel {
                    [NameInMap("Command")]
                    [Validation(Required=false)]
                    public List<string> Command { get; set; }

                }
                [NameInMap("FailureThreshold")]
                [Validation(Required=false)]
                public int? FailureThreshold { get; set; }
            };

            [NameInMap("SecurityContext")]
            [Validation(Required=true)]
            public CreateContainerGroupRequestContainerSecurityContext SecurityContext { get; set; }
            public class CreateContainerGroupRequestContainerSecurityContext : TeaModel {
                [NameInMap("Capability")]
                [Validation(Required=true)]
                public CreateContainerGroupRequestContainerSecurityContextCapability Capability { get; set; }
                public class CreateContainerGroupRequestContainerSecurityContextCapability : TeaModel {
                    [NameInMap("Add")]
                    [Validation(Required=false)]
                    public List<string> Add { get; set; }

                }
                [NameInMap("ReadOnlyRootFilesystem")]
                [Validation(Required=false)]
                public bool? ReadOnlyRootFilesystem { get; set; }
                [NameInMap("RunAsUser")]
                [Validation(Required=false)]
                public long? RunAsUser { get; set; }
            };

            [NameInMap("LivenessProbe")]
            [Validation(Required=true)]
            public CreateContainerGroupRequestContainerLivenessProbe LivenessProbe { get; set; }
            public class CreateContainerGroupRequestContainerLivenessProbe : TeaModel {
                [NameInMap("PeriodSeconds")]
                [Validation(Required=false)]
                public int? PeriodSeconds { get; set; }
                [NameInMap("TcpSocket")]
                [Validation(Required=true)]
                public CreateContainerGroupRequestContainerLivenessProbeTcpSocket TcpSocket { get; set; }
                public class CreateContainerGroupRequestContainerLivenessProbeTcpSocket : TeaModel {
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                }
                [NameInMap("InitialDelaySeconds")]
                [Validation(Required=false)]
                public int? InitialDelaySeconds { get; set; }
                [NameInMap("SuccessThreshold")]
                [Validation(Required=false)]
                public int? SuccessThreshold { get; set; }
                [NameInMap("Exec")]
                [Validation(Required=true)]
                public CreateContainerGroupRequestContainerLivenessProbeExec Exec { get; set; }
                public class CreateContainerGroupRequestContainerLivenessProbeExec : TeaModel {
                    [NameInMap("Command")]
                    [Validation(Required=false)]
                    public List<string> Command { get; set; }

                }
                [NameInMap("HttpGet")]
                [Validation(Required=true)]
                public CreateContainerGroupRequestContainerLivenessProbeHttpGet HttpGet { get; set; }
                public class CreateContainerGroupRequestContainerLivenessProbeHttpGet : TeaModel {
                    [NameInMap("Scheme")]
                    [Validation(Required=false)]
                    public string Scheme { get; set; }

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                }
                [NameInMap("FailureThreshold")]
                [Validation(Required=false)]
                public int? FailureThreshold { get; set; }
                [NameInMap("TimeoutSeconds")]
                [Validation(Required=false)]
                public int? TimeoutSeconds { get; set; }
            };

            [NameInMap("EnvironmentVar")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestContainerEnvironmentVar> EnvironmentVar { get; set; }
            public class CreateContainerGroupRequestContainerEnvironmentVar : TeaModel {
                [NameInMap("FieldRef")]
                [Validation(Required=true)]
                public CreateContainerGroupRequestContainerEnvironmentVarFieldRef FieldRef { get; set; }
                public class CreateContainerGroupRequestContainerEnvironmentVarFieldRef : TeaModel {
                    [NameInMap("FieldPath")]
                    [Validation(Required=false)]
                    public string FieldPath { get; set; }
                };

                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Tty")]
            [Validation(Required=false)]
            public bool? Tty { get; set; }

            [NameInMap("WorkingDir")]
            [Validation(Required=false)]
            public string WorkingDir { get; set; }

            [NameInMap("Arg")]
            [Validation(Required=false)]
            public List<string> Arg { get; set; }

            [NameInMap("Stdin")]
            [Validation(Required=false)]
            public bool? Stdin { get; set; }

            [NameInMap("VolumeMount")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestContainerVolumeMount> VolumeMount { get; set; }
            public class CreateContainerGroupRequestContainerVolumeMount : TeaModel {
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

            [NameInMap("ImagePullPolicy")]
            [Validation(Required=false)]
            public string ImagePullPolicy { get; set; }

            [NameInMap("StdinOnce")]
            [Validation(Required=false)]
            public bool? StdinOnce { get; set; }

            [NameInMap("LifecyclePreStopHandlerTcpSocketPort")]
            [Validation(Required=false)]
            public int? LifecyclePreStopHandlerTcpSocketPort { get; set; }

            [NameInMap("LifecyclePostStartHandlerHttpGetScheme")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerHttpGetScheme { get; set; }

            [NameInMap("Command")]
            [Validation(Required=false)]
            public List<string> Command { get; set; }

            [NameInMap("LifecyclePostStartHandlerHttpGetHost")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerHttpGetHost { get; set; }

            [NameInMap("TerminationMessagePolicy")]
            [Validation(Required=false)]
            public string TerminationMessagePolicy { get; set; }

            [NameInMap("LifecyclePostStartHandlerTcpSocketPort")]
            [Validation(Required=false)]
            public int? LifecyclePostStartHandlerTcpSocketPort { get; set; }

            [NameInMap("LifecyclePostStartHandlerHttpGetPath")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerHttpGetPath { get; set; }

            [NameInMap("LifecyclePostStartHandlerExec")]
            [Validation(Required=false)]
            public List<string> LifecyclePostStartHandlerExec { get; set; }

            [NameInMap("LifecyclePreStopHandlerHttpGetPath")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerHttpGetPath { get; set; }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestContainerPort> Port { get; set; }
            public class CreateContainerGroupRequestContainerPort : TeaModel {
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

            }

            [NameInMap("TerminationMessagePath")]
            [Validation(Required=false)]
            public string TerminationMessagePath { get; set; }

            [NameInMap("LifecyclePreStopHandlerHttpGetScheme")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerHttpGetScheme { get; set; }

            [NameInMap("LifecyclePostStartHandlerTcpSocketHost")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerTcpSocketHost { get; set; }

            [NameInMap("Gpu")]
            [Validation(Required=false)]
            public int? Gpu { get; set; }

            [NameInMap("LifecyclePreStopHandlerExec")]
            [Validation(Required=false)]
            public List<string> LifecyclePreStopHandlerExec { get; set; }

            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("LifecyclePreStopHandlerHttpGetHost")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerHttpGetHost { get; set; }

            [NameInMap("LifecyclePreStopHandlerTcpSocketHost")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerTcpSocketHost { get; set; }

            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            [NameInMap("LifecyclePreStopHandlerHttpGetPort")]
            [Validation(Required=false)]
            public int? LifecyclePreStopHandlerHttpGetPort { get; set; }

            [NameInMap("LifecyclePreStopHandlerHttpGetHttpHeader")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestContainerLifecyclePreStopHandlerHttpGetHttpHeader> LifecyclePreStopHandlerHttpGetHttpHeader { get; set; }
            public class CreateContainerGroupRequestContainerLifecyclePreStopHandlerHttpGetHttpHeader : TeaModel {
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public float? Cpu { get; set; }

            [NameInMap("LifecyclePostStartHandlerHttpGetPort")]
            [Validation(Required=false)]
            public int? LifecyclePostStartHandlerHttpGetPort { get; set; }

            [NameInMap("LifecyclePostStartHandlerHttpGetHttpHeader")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestContainerLifecyclePostStartHandlerHttpGetHttpHeader> LifecyclePostStartHandlerHttpGetHttpHeader { get; set; }
            public class CreateContainerGroupRequestContainerLifecyclePostStartHandlerHttpGetHttpHeader : TeaModel {
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        [NameInMap("Volume")]
        [Validation(Required=false)]
        public List<CreateContainerGroupRequestVolume> Volume { get; set; }
        public class CreateContainerGroupRequestVolume : TeaModel {
            [NameInMap("DiskVolume")]
            [Validation(Required=true)]
            public CreateContainerGroupRequestVolumeDiskVolume DiskVolume { get; set; }
            public class CreateContainerGroupRequestVolumeDiskVolume : TeaModel {
                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public int? DiskSize { get; set; }
                [NameInMap("FsType")]
                [Validation(Required=false)]
                public string FsType { get; set; }
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }
            };

            [NameInMap("NFSVolume")]
            [Validation(Required=true)]
            public CreateContainerGroupRequestVolumeNFSVolume NFSVolume { get; set; }
            public class CreateContainerGroupRequestVolumeNFSVolume : TeaModel {
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }
                [NameInMap("ReadOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }
                [NameInMap("Server")]
                [Validation(Required=false)]
                public string Server { get; set; }
            };

            [NameInMap("FlexVolume")]
            [Validation(Required=true)]
            public CreateContainerGroupRequestVolumeFlexVolume FlexVolume { get; set; }
            public class CreateContainerGroupRequestVolumeFlexVolume : TeaModel {
                [NameInMap("FsType")]
                [Validation(Required=false)]
                public string FsType { get; set; }
                [NameInMap("Options")]
                [Validation(Required=false)]
                public string Options { get; set; }
                [NameInMap("Driver")]
                [Validation(Required=false)]
                public string Driver { get; set; }
            };

            [NameInMap("HostPathVolume")]
            [Validation(Required=true)]
            public CreateContainerGroupRequestVolumeHostPathVolume HostPathVolume { get; set; }
            public class CreateContainerGroupRequestVolumeHostPathVolume : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }
            };

            [NameInMap("ConfigFileVolume")]
            [Validation(Required=true)]
            public CreateContainerGroupRequestVolumeConfigFileVolume ConfigFileVolume { get; set; }
            public class CreateContainerGroupRequestVolumeConfigFileVolume : TeaModel {
                [NameInMap("DefaultMode")]
                [Validation(Required=false)]
                public int? DefaultMode { get; set; }
                [NameInMap("ConfigFileToPath")]
                [Validation(Required=false)]
                public List<CreateContainerGroupRequestVolumeConfigFileVolumeConfigFileToPath> ConfigFileToPath { get; set; }
                public class CreateContainerGroupRequestVolumeConfigFileVolumeConfigFileToPath : TeaModel {
                    public string Path { get; set; }
                    public int? Mode { get; set; }
                    public string Content { get; set; }
                }
            };

            [NameInMap("EmptyDirVolume")]
            [Validation(Required=true)]
            public CreateContainerGroupRequestVolumeEmptyDirVolume EmptyDirVolume { get; set; }
            public class CreateContainerGroupRequestVolumeEmptyDirVolume : TeaModel {
                [NameInMap("Medium")]
                [Validation(Required=false)]
                public string Medium { get; set; }
            };

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("InitContainer")]
        [Validation(Required=false)]
        public List<CreateContainerGroupRequestInitContainer> InitContainer { get; set; }
        public class CreateContainerGroupRequestInitContainer : TeaModel {
            [NameInMap("SecurityContext")]
            [Validation(Required=true)]
            public CreateContainerGroupRequestInitContainerSecurityContext SecurityContext { get; set; }
            public class CreateContainerGroupRequestInitContainerSecurityContext : TeaModel {
                [NameInMap("Capability")]
                [Validation(Required=true)]
                public CreateContainerGroupRequestInitContainerSecurityContextCapability Capability { get; set; }
                public class CreateContainerGroupRequestInitContainerSecurityContextCapability : TeaModel {
                    [NameInMap("Add")]
                    [Validation(Required=false)]
                    public List<string> Add { get; set; }

                }
                [NameInMap("ReadOnlyRootFilesystem")]
                [Validation(Required=false)]
                public bool? ReadOnlyRootFilesystem { get; set; }
                [NameInMap("RunAsUser")]
                [Validation(Required=false)]
                public long? RunAsUser { get; set; }
            };

            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            [NameInMap("VolumeMount")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestInitContainerVolumeMount> VolumeMount { get; set; }
            public class CreateContainerGroupRequestInitContainerVolumeMount : TeaModel {
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

            [NameInMap("Port")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestInitContainerPort> Port { get; set; }
            public class CreateContainerGroupRequestInitContainerPort : TeaModel {
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

            }

            [NameInMap("TerminationMessagePath")]
            [Validation(Required=false)]
            public string TerminationMessagePath { get; set; }

            [NameInMap("EnvironmentVar")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestInitContainerEnvironmentVar> EnvironmentVar { get; set; }
            public class CreateContainerGroupRequestInitContainerEnvironmentVar : TeaModel {
                [NameInMap("FieldRef")]
                [Validation(Required=true)]
                public CreateContainerGroupRequestInitContainerEnvironmentVarFieldRef FieldRef { get; set; }
                public class CreateContainerGroupRequestInitContainerEnvironmentVarFieldRef : TeaModel {
                    [NameInMap("FieldPath")]
                    [Validation(Required=false)]
                    public string FieldPath { get; set; }
                };

                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("ImagePullPolicy")]
            [Validation(Required=false)]
            public string ImagePullPolicy { get; set; }

            [NameInMap("WorkingDir")]
            [Validation(Required=false)]
            public string WorkingDir { get; set; }

            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public float? Cpu { get; set; }

            [NameInMap("Arg")]
            [Validation(Required=false)]
            public List<string> Arg { get; set; }

            [NameInMap("Command")]
            [Validation(Required=false)]
            public List<string> Command { get; set; }

            [NameInMap("Gpu")]
            [Validation(Required=false)]
            public int? Gpu { get; set; }

            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            [NameInMap("TerminationMessagePolicy")]
            [Validation(Required=false)]
            public string TerminationMessagePolicy { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("HostAliase")]
        [Validation(Required=false)]
        public List<CreateContainerGroupRequestHostAliase> HostAliase { get; set; }
        public class CreateContainerGroupRequestHostAliase : TeaModel {
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public List<string> Hostname { get; set; }

        }

        [NameInMap("Arn")]
        [Validation(Required=false)]
        public List<CreateContainerGroupRequestArn> Arn { get; set; }
        public class CreateContainerGroupRequestArn : TeaModel {
            [NameInMap("RoleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            [NameInMap("RoleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

            [NameInMap("AssumeRoleFor")]
            [Validation(Required=false)]
            public string AssumeRoleFor { get; set; }

        }

        [NameInMap("NtpServer")]
        [Validation(Required=false)]
        public List<string> NtpServer { get; set; }

        [NameInMap("AcrRegistryInfo")]
        [Validation(Required=false)]
        public List<CreateContainerGroupRequestAcrRegistryInfo> AcrRegistryInfo { get; set; }
        public class CreateContainerGroupRequestAcrRegistryInfo : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public List<string> Domain { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

    }

}
