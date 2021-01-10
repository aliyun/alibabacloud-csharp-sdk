// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class UpdateContainerGroupRequest : TeaModel {
        [NameInMap("DnsConfig")]
        [Validation(Required=false)]
        public UpdateContainerGroupRequestDnsConfig DnsConfig { get; set; }
        public class UpdateContainerGroupRequestDnsConfig : TeaModel {
            [NameInMap("NameServer")]
            [Validation(Required=false)]
            public List<string> NameServer { get; set; }
            [NameInMap("Search")]
            [Validation(Required=false)]
            public List<string> Search { get; set; }
            [NameInMap("Option")]
            [Validation(Required=false)]
            public List<UpdateContainerGroupRequestDnsConfigOption> Option { get; set; }
            public class UpdateContainerGroupRequestDnsConfigOption : TeaModel {
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

        [NameInMap("ContainerGroupId")]
        [Validation(Required=false)]
        public string ContainerGroupId { get; set; }

        [NameInMap("RestartPolicy")]
        [Validation(Required=false)]
        public string RestartPolicy { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<UpdateContainerGroupRequestTag> Tag { get; set; }
        public class UpdateContainerGroupRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Volume")]
        [Validation(Required=false)]
        public List<UpdateContainerGroupRequestVolume> Volume { get; set; }
        public class UpdateContainerGroupRequestVolume : TeaModel {
            [NameInMap("NFSVolume")]
            [Validation(Required=true)]
            public UpdateContainerGroupRequestVolumeNFSVolume NFSVolume { get; set; }
            public class UpdateContainerGroupRequestVolumeNFSVolume : TeaModel {
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }
                [NameInMap("Server")]
                [Validation(Required=false)]
                public string Server { get; set; }
                [NameInMap("ReadOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }
            };

            [NameInMap("ConfigFileVolume")]
            [Validation(Required=true)]
            public UpdateContainerGroupRequestVolumeConfigFileVolume ConfigFileVolume { get; set; }
            public class UpdateContainerGroupRequestVolumeConfigFileVolume : TeaModel {
                [NameInMap("ConfigFileToPath")]
                [Validation(Required=false)]
                public List<UpdateContainerGroupRequestVolumeConfigFileVolumeConfigFileToPath> ConfigFileToPath { get; set; }
                public class UpdateContainerGroupRequestVolumeConfigFileVolumeConfigFileToPath : TeaModel {
                    public string Path { get; set; }
                    public string Content { get; set; }
                }
            };

            [NameInMap("EmptyDirVolume")]
            [Validation(Required=true)]
            public UpdateContainerGroupRequestVolumeEmptyDirVolume EmptyDirVolume { get; set; }
            public class UpdateContainerGroupRequestVolumeEmptyDirVolume : TeaModel {
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

        [NameInMap("Container")]
        [Validation(Required=false)]
        public List<UpdateContainerGroupRequestContainer> Container { get; set; }
        public class UpdateContainerGroupRequestContainer : TeaModel {
            [NameInMap("ReadinessProbe")]
            [Validation(Required=true)]
            public UpdateContainerGroupRequestContainerReadinessProbe ReadinessProbe { get; set; }
            public class UpdateContainerGroupRequestContainerReadinessProbe : TeaModel {
                [NameInMap("TimeoutSeconds")]
                [Validation(Required=false)]
                public int? TimeoutSeconds { get; set; }
                [NameInMap("SuccessThreshold")]
                [Validation(Required=false)]
                public int? SuccessThreshold { get; set; }
                [NameInMap("TcpSocket")]
                [Validation(Required=true)]
                public UpdateContainerGroupRequestContainerReadinessProbeTcpSocket TcpSocket { get; set; }
                public class UpdateContainerGroupRequestContainerReadinessProbeTcpSocket : TeaModel {
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                }
                [NameInMap("HttpGet")]
                [Validation(Required=true)]
                public UpdateContainerGroupRequestContainerReadinessProbeHttpGet HttpGet { get; set; }
                public class UpdateContainerGroupRequestContainerReadinessProbeHttpGet : TeaModel {
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
                public UpdateContainerGroupRequestContainerReadinessProbeExec Exec { get; set; }
                public class UpdateContainerGroupRequestContainerReadinessProbeExec : TeaModel {
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
            public UpdateContainerGroupRequestContainerSecurityContext SecurityContext { get; set; }
            public class UpdateContainerGroupRequestContainerSecurityContext : TeaModel {
                [NameInMap("Capability")]
                [Validation(Required=true)]
                public UpdateContainerGroupRequestContainerSecurityContextCapability Capability { get; set; }
                public class UpdateContainerGroupRequestContainerSecurityContextCapability : TeaModel {
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
            public UpdateContainerGroupRequestContainerLivenessProbe LivenessProbe { get; set; }
            public class UpdateContainerGroupRequestContainerLivenessProbe : TeaModel {
                [NameInMap("PeriodSeconds")]
                [Validation(Required=false)]
                public int? PeriodSeconds { get; set; }
                [NameInMap("TcpSocket")]
                [Validation(Required=true)]
                public UpdateContainerGroupRequestContainerLivenessProbeTcpSocket TcpSocket { get; set; }
                public class UpdateContainerGroupRequestContainerLivenessProbeTcpSocket : TeaModel {
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
                public UpdateContainerGroupRequestContainerLivenessProbeExec Exec { get; set; }
                public class UpdateContainerGroupRequestContainerLivenessProbeExec : TeaModel {
                    [NameInMap("Command")]
                    [Validation(Required=false)]
                    public List<string> Command { get; set; }

                }
                [NameInMap("HttpGet")]
                [Validation(Required=true)]
                public UpdateContainerGroupRequestContainerLivenessProbeHttpGet HttpGet { get; set; }
                public class UpdateContainerGroupRequestContainerLivenessProbeHttpGet : TeaModel {
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
            public List<UpdateContainerGroupRequestContainerEnvironmentVar> EnvironmentVar { get; set; }
            public class UpdateContainerGroupRequestContainerEnvironmentVar : TeaModel {
                [NameInMap("FieldRef")]
                [Validation(Required=true)]
                public UpdateContainerGroupRequestContainerEnvironmentVarFieldRef FieldRef { get; set; }
                public class UpdateContainerGroupRequestContainerEnvironmentVarFieldRef : TeaModel {
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
            public List<UpdateContainerGroupRequestContainerVolumeMount> VolumeMount { get; set; }
            public class UpdateContainerGroupRequestContainerVolumeMount : TeaModel {
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
            public List<UpdateContainerGroupRequestContainerPort> Port { get; set; }
            public class UpdateContainerGroupRequestContainerPort : TeaModel {
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

            }

            [NameInMap("LifecyclePreStopHandlerHttpGetScheme")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerHttpGetScheme { get; set; }

            [NameInMap("LifecyclePostStartHandlerHttpGetHttpHeaders")]
            [Validation(Required=false)]
            public List<UpdateContainerGroupRequestContainerLifecyclePostStartHandlerHttpGetHttpHeaders> LifecyclePostStartHandlerHttpGetHttpHeaders { get; set; }
            public class UpdateContainerGroupRequestContainerLifecyclePostStartHandlerHttpGetHttpHeaders : TeaModel {
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

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
            public List<UpdateContainerGroupRequestContainerLifecyclePreStopHandlerHttpGetHttpHeader> LifecyclePreStopHandlerHttpGetHttpHeader { get; set; }
            public class UpdateContainerGroupRequestContainerLifecyclePreStopHandlerHttpGetHttpHeader : TeaModel {
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

        }

        [NameInMap("InitContainer")]
        [Validation(Required=false)]
        public List<UpdateContainerGroupRequestInitContainer> InitContainer { get; set; }
        public class UpdateContainerGroupRequestInitContainer : TeaModel {
            [NameInMap("SecurityContext")]
            [Validation(Required=true)]
            public UpdateContainerGroupRequestInitContainerSecurityContext SecurityContext { get; set; }
            public class UpdateContainerGroupRequestInitContainerSecurityContext : TeaModel {
                [NameInMap("Capability")]
                [Validation(Required=true)]
                public UpdateContainerGroupRequestInitContainerSecurityContextCapability Capability { get; set; }
                public class UpdateContainerGroupRequestInitContainerSecurityContextCapability : TeaModel {
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
            public List<UpdateContainerGroupRequestInitContainerVolumeMount> VolumeMount { get; set; }
            public class UpdateContainerGroupRequestInitContainerVolumeMount : TeaModel {
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
            public List<UpdateContainerGroupRequestInitContainerPort> Port { get; set; }
            public class UpdateContainerGroupRequestInitContainerPort : TeaModel {
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

            }

            [NameInMap("EnvironmentVar")]
            [Validation(Required=false)]
            public List<UpdateContainerGroupRequestInitContainerEnvironmentVar> EnvironmentVar { get; set; }
            public class UpdateContainerGroupRequestInitContainerEnvironmentVar : TeaModel {
                [NameInMap("FieldRef")]
                [Validation(Required=true)]
                public UpdateContainerGroupRequestInitContainerEnvironmentVarFieldRef FieldRef { get; set; }
                public class UpdateContainerGroupRequestInitContainerEnvironmentVarFieldRef : TeaModel {
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

            [NameInMap("StdinOnce")]
            [Validation(Required=false)]
            public bool? StdinOnce { get; set; }

            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public float? Cpu { get; set; }

            [NameInMap("Tty")]
            [Validation(Required=false)]
            public bool? Tty { get; set; }

            [NameInMap("WorkingDir")]
            [Validation(Required=false)]
            public string WorkingDir { get; set; }

            [NameInMap("Command")]
            [Validation(Required=false)]
            public List<string> Command { get; set; }

            [NameInMap("Arg")]
            [Validation(Required=false)]
            public List<string> Arg { get; set; }

            [NameInMap("Gpu")]
            [Validation(Required=false)]
            public int? Gpu { get; set; }

            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            [NameInMap("Stdin")]
            [Validation(Required=false)]
            public bool? Stdin { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("ImageRegistryCredential")]
        [Validation(Required=false)]
        public List<UpdateContainerGroupRequestImageRegistryCredential> ImageRegistryCredential { get; set; }
        public class UpdateContainerGroupRequestImageRegistryCredential : TeaModel {
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

    }

}
