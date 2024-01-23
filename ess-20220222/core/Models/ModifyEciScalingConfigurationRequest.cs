// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ModifyEciScalingConfigurationRequest : TeaModel {
        /// <summary>
        /// Information about the Container Registry Enterprise Edition instance.
        /// </summary>
        [NameInMap("AcrRegistryInfos")]
        [Validation(Required=false)]
        public List<ModifyEciScalingConfigurationRequestAcrRegistryInfos> AcrRegistryInfos { get; set; }
        public class ModifyEciScalingConfigurationRequestAcrRegistryInfos : TeaModel {
            /// <summary>
            /// The domain names of the Container Registry Enterprise Edition instances. By default, all domain names of the Container Registry Enterprise Edition instances are displayed. You can specify one or more domain names. Separate multiple domain names with commas (,).
            /// </summary>
            [NameInMap("Domains")]
            [Validation(Required=false)]
            public List<string> Domains { get; set; }

            /// <summary>
            /// The ID of the Container Registry Enterprise Edition instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the Container Registry Enterprise Edition instance.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The region ID of the Container Registry Enterprise Edition instance.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// The validity period. Unit: seconds.
        /// </summary>
        [NameInMap("ActiveDeadlineSeconds")]
        [Validation(Required=false)]
        public long? ActiveDeadlineSeconds { get; set; }

        /// <summary>
        /// Specifies whether to automatically create an elastic IP address (EIP) and bind the EIP to the elastic container instance.
        /// </summary>
        [NameInMap("AutoCreateEip")]
        [Validation(Required=false)]
        public bool? AutoCreateEip { get; set; }

        /// <summary>
        /// Specifies whether to automatically match the image cache.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("AutoMatchImageCache")]
        [Validation(Required=false)]
        public bool? AutoMatchImageCache { get; set; }

        /// <summary>
        /// The name of the elastic container instance. The name must meet the following requirements:
        /// 
        /// *   The name must be 2 to 128 characters in length
        /// *   The name can contain only lowercase letters, digits, and hyphens (-). It cannot start or end with a hyphen (-).
        /// </summary>
        [NameInMap("ContainerGroupName")]
        [Validation(Required=false)]
        public string ContainerGroupName { get; set; }

        /// <summary>
        /// The containers.
        /// </summary>
        [NameInMap("Containers")]
        [Validation(Required=false)]
        public List<ModifyEciScalingConfigurationRequestContainers> Containers { get; set; }
        public class ModifyEciScalingConfigurationRequestContainers : TeaModel {
            [NameInMap("LivenessProbe")]
            [Validation(Required=false)]
            public ModifyEciScalingConfigurationRequestContainersLivenessProbe LivenessProbe { get; set; }
            public class ModifyEciScalingConfigurationRequestContainersLivenessProbe : TeaModel {
                [NameInMap("Exec")]
                [Validation(Required=false)]
                public ModifyEciScalingConfigurationRequestContainersLivenessProbeExec Exec { get; set; }
                public class ModifyEciScalingConfigurationRequestContainersLivenessProbeExec : TeaModel {
                    [NameInMap("Commands")]
                    [Validation(Required=false)]
                    public List<string> Commands { get; set; }

                }

                [NameInMap("FailureThreshold")]
                [Validation(Required=false)]
                public int? FailureThreshold { get; set; }

                [NameInMap("HttpGet")]
                [Validation(Required=false)]
                public ModifyEciScalingConfigurationRequestContainersLivenessProbeHttpGet HttpGet { get; set; }
                public class ModifyEciScalingConfigurationRequestContainersLivenessProbeHttpGet : TeaModel {
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    [NameInMap("Scheme")]
                    [Validation(Required=false)]
                    public string Scheme { get; set; }

                }

                [NameInMap("InitialDelaySeconds")]
                [Validation(Required=false)]
                public int? InitialDelaySeconds { get; set; }

                [NameInMap("PeriodSeconds")]
                [Validation(Required=false)]
                public int? PeriodSeconds { get; set; }

                [NameInMap("SuccessThreshold")]
                [Validation(Required=false)]
                public int? SuccessThreshold { get; set; }

                [NameInMap("TcpSocket")]
                [Validation(Required=false)]
                public ModifyEciScalingConfigurationRequestContainersLivenessProbeTcpSocket TcpSocket { get; set; }
                public class ModifyEciScalingConfigurationRequestContainersLivenessProbeTcpSocket : TeaModel {
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                }

                [NameInMap("TimeoutSeconds")]
                [Validation(Required=false)]
                public int? TimeoutSeconds { get; set; }

            }

            [NameInMap("ReadinessProbe")]
            [Validation(Required=false)]
            public ModifyEciScalingConfigurationRequestContainersReadinessProbe ReadinessProbe { get; set; }
            public class ModifyEciScalingConfigurationRequestContainersReadinessProbe : TeaModel {
                [NameInMap("Exec")]
                [Validation(Required=false)]
                public ModifyEciScalingConfigurationRequestContainersReadinessProbeExec Exec { get; set; }
                public class ModifyEciScalingConfigurationRequestContainersReadinessProbeExec : TeaModel {
                    [NameInMap("Commands")]
                    [Validation(Required=false)]
                    public List<string> Commands { get; set; }

                }

                [NameInMap("FailureThreshold")]
                [Validation(Required=false)]
                public int? FailureThreshold { get; set; }

                [NameInMap("HttpGet")]
                [Validation(Required=false)]
                public ModifyEciScalingConfigurationRequestContainersReadinessProbeHttpGet HttpGet { get; set; }
                public class ModifyEciScalingConfigurationRequestContainersReadinessProbeHttpGet : TeaModel {
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    [NameInMap("Scheme")]
                    [Validation(Required=false)]
                    public string Scheme { get; set; }

                }

                [NameInMap("InitialDelaySeconds")]
                [Validation(Required=false)]
                public int? InitialDelaySeconds { get; set; }

                [NameInMap("PeriodSeconds")]
                [Validation(Required=false)]
                public int? PeriodSeconds { get; set; }

                [NameInMap("SuccessThreshold")]
                [Validation(Required=false)]
                public int? SuccessThreshold { get; set; }

                [NameInMap("TcpSocket")]
                [Validation(Required=false)]
                public ModifyEciScalingConfigurationRequestContainersReadinessProbeTcpSocket TcpSocket { get; set; }
                public class ModifyEciScalingConfigurationRequestContainersReadinessProbeTcpSocket : TeaModel {
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                }

                [NameInMap("TimeoutSeconds")]
                [Validation(Required=false)]
                public int? TimeoutSeconds { get; set; }

            }

            [NameInMap("SecurityContext")]
            [Validation(Required=false)]
            public ModifyEciScalingConfigurationRequestContainersSecurityContext SecurityContext { get; set; }
            public class ModifyEciScalingConfigurationRequestContainersSecurityContext : TeaModel {
                [NameInMap("Capability")]
                [Validation(Required=false)]
                public ModifyEciScalingConfigurationRequestContainersSecurityContextCapability Capability { get; set; }
                public class ModifyEciScalingConfigurationRequestContainersSecurityContextCapability : TeaModel {
                    [NameInMap("Adds")]
                    [Validation(Required=false)]
                    public List<string> Adds { get; set; }

                }

                [NameInMap("ReadOnlyRootFilesystem")]
                [Validation(Required=false)]
                public bool? ReadOnlyRootFilesystem { get; set; }

                [NameInMap("RunAsUser")]
                [Validation(Required=false)]
                public long? RunAsUser { get; set; }

            }

            /// <summary>
            /// The arguments that correspond to the startup commands of the container. You can specify up to 10 arguments.
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public List<string> Args { get; set; }

            /// <summary>
            /// The commands that you want to execute in the container when you use the command line interface (CLI) to perform probes.
            /// </summary>
            [NameInMap("Commands")]
            [Validation(Required=false)]
            public List<string> Commands { get; set; }

            /// <summary>
            /// The number of vCPUs that you want to allocate to the container.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public float? Cpu { get; set; }

            /// <summary>
            /// Information about the environment variables.
            /// </summary>
            [NameInMap("EnvironmentVars")]
            [Validation(Required=false)]
            public List<ModifyEciScalingConfigurationRequestContainersEnvironmentVars> EnvironmentVars { get; set; }
            public class ModifyEciScalingConfigurationRequestContainersEnvironmentVars : TeaModel {
                [NameInMap("FieldRef")]
                [Validation(Required=false)]
                public ModifyEciScalingConfigurationRequestContainersEnvironmentVarsFieldRef FieldRef { get; set; }
                public class ModifyEciScalingConfigurationRequestContainersEnvironmentVarsFieldRef : TeaModel {
                    [NameInMap("FieldPath")]
                    [Validation(Required=false)]
                    public string FieldPath { get; set; }

                }

                /// <summary>
                /// The key of the environment variable. Specify the name in the `[0-9a-zA-Z]` format. The name must be 1 to 128 characters in length, and can contain underscores (\_). It cannot start with a digit.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of the environment variable. The value must be 0 to 256 characters in length.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The number of GPUs that you want to allocate to the container.
            /// </summary>
            [NameInMap("Gpu")]
            [Validation(Required=false)]
            public int? Gpu { get; set; }

            /// <summary>
            /// The image of the container.
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// The image pulling policy. Valid values:
            /// 
            /// *   Always: pulls images each time.
            /// *   IfNotPresent: pulls images only if no on-premises images are available. On-premises images are preferentially used. If no on-premises images are available, image pulling is performed.
            /// *   Never: never pulls images. On-premises images are always used.
            /// </summary>
            [NameInMap("ImagePullPolicy")]
            [Validation(Required=false)]
            public string ImagePullPolicy { get; set; }

            [NameInMap("LifecyclePostStartHandlerExecs")]
            [Validation(Required=false)]
            public List<string> LifecyclePostStartHandlerExecs { get; set; }

            [NameInMap("LifecyclePostStartHandlerHttpGetHost")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerHttpGetHost { get; set; }

            [NameInMap("LifecyclePostStartHandlerHttpGetPath")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerHttpGetPath { get; set; }

            [NameInMap("LifecyclePostStartHandlerHttpGetPort")]
            [Validation(Required=false)]
            public int? LifecyclePostStartHandlerHttpGetPort { get; set; }

            [NameInMap("LifecyclePostStartHandlerHttpGetScheme")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerHttpGetScheme { get; set; }

            [NameInMap("LifecyclePostStartHandlerTcpSocketHost")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerTcpSocketHost { get; set; }

            [NameInMap("LifecyclePostStartHandlerTcpSocketPort")]
            [Validation(Required=false)]
            public int? LifecyclePostStartHandlerTcpSocketPort { get; set; }

            [NameInMap("LifecyclePreStopHandlerExecs")]
            [Validation(Required=false)]
            public List<string> LifecyclePreStopHandlerExecs { get; set; }

            [NameInMap("LifecyclePreStopHandlerHttpGetHost")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerHttpGetHost { get; set; }

            [NameInMap("LifecyclePreStopHandlerHttpGetPath")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerHttpGetPath { get; set; }

            [NameInMap("LifecyclePreStopHandlerHttpGetPort")]
            [Validation(Required=false)]
            public int? LifecyclePreStopHandlerHttpGetPort { get; set; }

            [NameInMap("LifecyclePreStopHandlerHttpGetScheme")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerHttpGetScheme { get; set; }

            [NameInMap("LifecyclePreStopHandlerTcpSocketHost")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerTcpSocketHost { get; set; }

            [NameInMap("LifecyclePreStopHandlerTcpSocketPort")]
            [Validation(Required=false)]
            public int? LifecyclePreStopHandlerTcpSocketPort { get; set; }

            /// <summary>
            /// The memory size of the container. Unit: GiB.
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// The name of the container image.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Information about the ports.
            /// </summary>
            [NameInMap("Ports")]
            [Validation(Required=false)]
            public List<ModifyEciScalingConfigurationRequestContainersPorts> Ports { get; set; }
            public class ModifyEciScalingConfigurationRequestContainersPorts : TeaModel {
                /// <summary>
                /// The port number. Valid values: 1 to 65535.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The type of the protocol. Valid values:
                /// 
                /// *   TCP
                /// *   UDP
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            /// <summary>
            /// Specifies whether the container allocates buffer resources to standard input streams when the container is running. If you do not specify this parameter, an end-of-file (EOF) error may occur.
            /// 
            /// Default value: false.
            /// </summary>
            [NameInMap("Stdin")]
            [Validation(Required=false)]
            public bool? Stdin { get; set; }

            /// <summary>
            /// Specifies whether standard input streams are disconnected after a client is disconnected.
            /// 
            /// If you set the StdinOnce parameter to true, standard input streams are connected after the container is started, and remain idle until a client is connected to receive data. After the client is disconnected, streams are also disconnected, and remain disconnected until the container is started again.
            /// </summary>
            [NameInMap("StdinOnce")]
            [Validation(Required=false)]
            public bool? StdinOnce { get; set; }

            /// <summary>
            /// Specifies whether to enable interaction. Default value: false.
            /// 
            /// If the command is a /bin/bash command, set the value to true.
            /// </summary>
            [NameInMap("Tty")]
            [Validation(Required=false)]
            public bool? Tty { get; set; }

            /// <summary>
            /// Information about the volume mount of the container.
            /// </summary>
            [NameInMap("VolumeMounts")]
            [Validation(Required=false)]
            public List<ModifyEciScalingConfigurationRequestContainersVolumeMounts> VolumeMounts { get; set; }
            public class ModifyEciScalingConfigurationRequestContainersVolumeMounts : TeaModel {
                /// <summary>
                /// The path where the container mounts the volume.
                /// 
                /// >  Data stored in the path of the container is directly overwritten by the content of the volume.
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// The mount propagation setting of the volume. Mount propagation allows the sharing of volumes that are mounted on one container with other containers in the same pod, or even with other pods on the same node. Valid values:
                /// 
                /// *   None: The volume mount does not receive subsequent mounts that are mounted to this volume or its subdirectories.
                /// *   HostToCotainer: The volume mount receives all subsequent mounts that are mounted to this volume or its subdirectories.
                /// *   Bidirectional: This value is similar to HostToCotainer. The volume mount receives all subsequent mounts that are mounted to this volume or its subdirectories. In addition, all volume mounts that are created by the container are propagated back to the instance and to all containers of all pods that use the same volume.
                /// </summary>
                [NameInMap("MountPropagation")]
                [Validation(Required=false)]
                public string MountPropagation { get; set; }

                /// <summary>
                /// The name of the volume. The value of this parameter is the same as the value of the Volumes.Name parameter.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Specifies whether the volume is read-only.
                /// 
                /// Default value: false.
                /// </summary>
                [NameInMap("ReadOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                /// <summary>
                /// The subdirectory of the volume.
                /// </summary>
                [NameInMap("SubPath")]
                [Validation(Required=false)]
                public string SubPath { get; set; }

            }

            /// <summary>
            /// The working directory of the container.
            /// </summary>
            [NameInMap("WorkingDir")]
            [Validation(Required=false)]
            public string WorkingDir { get; set; }

        }

        [NameInMap("ContainersUpdateType")]
        [Validation(Required=false)]
        public string ContainersUpdateType { get; set; }

        /// <summary>
        /// Specifies whether to enable the cost optimization feature. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("CostOptimization")]
        [Validation(Required=false)]
        public bool? CostOptimization { get; set; }

        /// <summary>
        /// The number of vCPUs of the elastic container instance.
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// The number of physical CPU cores. This parameter is not available for all instance types. For more information, see [Specify custom CPU options](~~197781~~).
        /// </summary>
        [NameInMap("CpuOptionsCore")]
        [Validation(Required=false)]
        public int? CpuOptionsCore { get; set; }

        /// <summary>
        /// The number of threads per core. This parameter is not available for all instance types. A value of 1 indicates that Hyper-Threading is disabled. For more information, see [Specify custom CPU options](~~197781~~).
        /// </summary>
        [NameInMap("CpuOptionsThreadsPerCore")]
        [Validation(Required=false)]
        public int? CpuOptionsThreadsPerCore { get; set; }

        [NameInMap("DataCacheBucket")]
        [Validation(Required=false)]
        public string DataCacheBucket { get; set; }

        [NameInMap("DataCacheBurstingEnabled")]
        [Validation(Required=false)]
        public bool? DataCacheBurstingEnabled { get; set; }

        [NameInMap("DataCachePL")]
        [Validation(Required=false)]
        public string DataCachePL { get; set; }

        [NameInMap("DataCacheProvisionedIops")]
        [Validation(Required=false)]
        public int? DataCacheProvisionedIops { get; set; }

        /// <summary>
        /// > This parameter is unavailable.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The IP addresses of the DNS servers.
        /// </summary>
        [NameInMap("DnsConfigNameServers")]
        [Validation(Required=false)]
        public List<string> DnsConfigNameServers { get; set; }

        /// <summary>
        /// The options. Each option is a name-value pair. The value in the name-value pair is optional.
        /// </summary>
        [NameInMap("DnsConfigOptions")]
        [Validation(Required=false)]
        public List<ModifyEciScalingConfigurationRequestDnsConfigOptions> DnsConfigOptions { get; set; }
        public class ModifyEciScalingConfigurationRequestDnsConfigOptions : TeaModel {
            /// <summary>
            /// The variable name of the option.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The variable value of the option.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The DNS lookup domains.
        /// </summary>
        [NameInMap("DnsConfigSearchs")]
        [Validation(Required=false)]
        public List<string> DnsConfigSearchs { get; set; }

        /// <summary>
        /// The Domain Name System (DNS) policy. Valid values:
        /// 
        /// *   None: uses the DNS that is set for the DnsConfig field.
        /// *   Default: use the DNS that is set for the runtime environment.
        /// </summary>
        [NameInMap("DnsPolicy")]
        [Validation(Required=false)]
        public string DnsPolicy { get; set; }

        /// <summary>
        /// The maximum outbound bandwidth. Unit: bit/s.
        /// </summary>
        [NameInMap("EgressBandwidth")]
        [Validation(Required=false)]
        public long? EgressBandwidth { get; set; }

        /// <summary>
        /// The bandwidth of the EIP.
        /// 
        /// Default value: 5. Unit: Mbit/s.
        /// </summary>
        [NameInMap("EipBandwidth")]
        [Validation(Required=false)]
        public int? EipBandwidth { get; set; }

        /// <summary>
        /// > This parameter is unavailable.
        /// </summary>
        [NameInMap("EnableSls")]
        [Validation(Required=false)]
        public bool? EnableSls { get; set; }

        /// <summary>
        /// The size of the temporary storage space. By default, an enhanced SSD (ESSD) of the PL1 level is used. Unit: GiB.
        /// </summary>
        [NameInMap("EphemeralStorage")]
        [Validation(Required=false)]
        public int? EphemeralStorage { get; set; }

        /// <summary>
        /// Information about the hosts.
        /// </summary>
        [NameInMap("HostAliases")]
        [Validation(Required=false)]
        public List<ModifyEciScalingConfigurationRequestHostAliases> HostAliases { get; set; }
        public class ModifyEciScalingConfigurationRequestHostAliases : TeaModel {
            /// <summary>
            /// The hostnames that you want to add.
            /// </summary>
            [NameInMap("Hostnames")]
            [Validation(Required=false)]
            public List<string> Hostnames { get; set; }

            /// <summary>
            /// The IP address that you want to add.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

        }

        /// <summary>
        /// The name of the elastic container instance.
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// Information about the image repository.
        /// </summary>
        [NameInMap("ImageRegistryCredentials")]
        [Validation(Required=false)]
        public List<ModifyEciScalingConfigurationRequestImageRegistryCredentials> ImageRegistryCredentials { get; set; }
        public class ModifyEciScalingConfigurationRequestImageRegistryCredentials : TeaModel {
            /// <summary>
            /// The password that is used to access the image repository.
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// The domain name of the image repository.
            /// </summary>
            [NameInMap("Server")]
            [Validation(Required=false)]
            public string Server { get; set; }

            /// <summary>
            /// The username that is used to access the image repository.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// The ID of the image cache.
        /// </summary>
        [NameInMap("ImageSnapshotId")]
        [Validation(Required=false)]
        public string ImageSnapshotId { get; set; }

        /// <summary>
        /// The maximum inbound bandwidth. Unit: bit/s.
        /// </summary>
        [NameInMap("IngressBandwidth")]
        [Validation(Required=false)]
        public long? IngressBandwidth { get; set; }

        /// <summary>
        /// The init containers.
        /// </summary>
        [NameInMap("InitContainers")]
        [Validation(Required=false)]
        public List<ModifyEciScalingConfigurationRequestInitContainers> InitContainers { get; set; }
        public class ModifyEciScalingConfigurationRequestInitContainers : TeaModel {
            [NameInMap("SecurityContext")]
            [Validation(Required=false)]
            public ModifyEciScalingConfigurationRequestInitContainersSecurityContext SecurityContext { get; set; }
            public class ModifyEciScalingConfigurationRequestInitContainersSecurityContext : TeaModel {
                [NameInMap("Capability")]
                [Validation(Required=false)]
                public ModifyEciScalingConfigurationRequestInitContainersSecurityContextCapability Capability { get; set; }
                public class ModifyEciScalingConfigurationRequestInitContainersSecurityContextCapability : TeaModel {
                    [NameInMap("Adds")]
                    [Validation(Required=false)]
                    public List<string> Adds { get; set; }

                }

                [NameInMap("ReadOnlyRootFilesystem")]
                [Validation(Required=false)]
                public bool? ReadOnlyRootFilesystem { get; set; }

                [NameInMap("RunAsUser")]
                [Validation(Required=false)]
                public long? RunAsUser { get; set; }

            }

            /// <summary>
            /// The startup parameter of the container.
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public List<string> Args { get; set; }

            /// <summary>
            /// The commands that you want to run to start the container.
            /// </summary>
            [NameInMap("Commands")]
            [Validation(Required=false)]
            public List<string> Commands { get; set; }

            /// <summary>
            /// The number of vCPUs that you want to allocate to the container.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public float? Cpu { get; set; }

            /// <summary>
            /// The number of GPUs that you want to allocate to the container.
            /// </summary>
            [NameInMap("Gpu")]
            [Validation(Required=false)]
            public int? Gpu { get; set; }

            /// <summary>
            /// The container image.
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// The image pulling policy. Valid values:
            /// 
            /// *   Always: pulls images each time.
            /// *   IfNotPresent: pulls images only if no on-premises images are available. On-premises images are preferentially used. If no on-premises images are available, image pulling is performed.
            /// *   Never: never pulls images. On-premises images are always used. Image pulling is not performed.
            /// </summary>
            [NameInMap("ImagePullPolicy")]
            [Validation(Required=false)]
            public string ImagePullPolicy { get; set; }

            /// <summary>
            /// The environment variables of the init container.
            /// </summary>
            [NameInMap("InitContainerEnvironmentVars")]
            [Validation(Required=false)]
            public List<ModifyEciScalingConfigurationRequestInitContainersInitContainerEnvironmentVars> InitContainerEnvironmentVars { get; set; }
            public class ModifyEciScalingConfigurationRequestInitContainersInitContainerEnvironmentVars : TeaModel {
                [NameInMap("FieldRef")]
                [Validation(Required=false)]
                public ModifyEciScalingConfigurationRequestInitContainersInitContainerEnvironmentVarsFieldRef FieldRef { get; set; }
                public class ModifyEciScalingConfigurationRequestInitContainersInitContainerEnvironmentVarsFieldRef : TeaModel {
                    [NameInMap("FieldPath")]
                    [Validation(Required=false)]
                    public string FieldPath { get; set; }

                }

                /// <summary>
                /// The key of the environment variable. The key must be 1 to 128 characters in length. Specify the name in the `[0-9a-zA-Z]` format. The name can contain underscores and cannot start with a digit.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of the environment variable. The value must be 0 to 256 characters in length.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The ports of the init container.
            /// </summary>
            [NameInMap("InitContainerPorts")]
            [Validation(Required=false)]
            public List<ModifyEciScalingConfigurationRequestInitContainersInitContainerPorts> InitContainerPorts { get; set; }
            public class ModifyEciScalingConfigurationRequestInitContainersInitContainerPorts : TeaModel {
                /// <summary>
                /// The port number. Valid values: 1 to 65535.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The type of the protocol. Valid values:
                /// 
                /// *   TCP
                /// *   UDP
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            /// <summary>
            /// Information about the volume mounts of the init container.
            /// </summary>
            [NameInMap("InitContainerVolumeMounts")]
            [Validation(Required=false)]
            public List<ModifyEciScalingConfigurationRequestInitContainersInitContainerVolumeMounts> InitContainerVolumeMounts { get; set; }
            public class ModifyEciScalingConfigurationRequestInitContainersInitContainerVolumeMounts : TeaModel {
                /// <summary>
                /// The path where the container mounts the volume.
                /// 
                /// >  Data stored in the path of the container is overwritten by the content of the volume.
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// The mount propagation setting of the volume. Mount propagation allows the sharing of volumes that are mounted on one container with other containers in the same pod, or even with other pods on the same node. Valid values:
                /// 
                /// *   None: The volume mount does not receive subsequent mounts that are mounted to this volume or its subdirectories.
                /// *   HostToCotainer: The volume mount receives all subsequent mounts that are mounted to this volume or its subdirectories.
                /// *   Bidirectional: This value is similar to HostToCotainer. The volume mount receives all subsequent mounts that are mounted to this volume or its subdirectories. In addition, all volume mounts that are created by the container are propagated back to the instance and to all containers of all pods that use the same volume.
                /// 
                /// Default value: None.
                /// </summary>
                [NameInMap("MountPropagation")]
                [Validation(Required=false)]
                public string MountPropagation { get; set; }

                /// <summary>
                /// The name of the volume.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Specifies whether the mount path is read-only.
                /// 
                /// Default value: false.
                /// </summary>
                [NameInMap("ReadOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                /// <summary>
                /// The subdirectory of the volume. The elastic container instance can mount different directories of the same volume to different subdirectories of containers.
                /// </summary>
                [NameInMap("SubPath")]
                [Validation(Required=false)]
                public string SubPath { get; set; }

            }

            /// <summary>
            /// The size of the memory. Unit: GiB.
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// The name of the container.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The working directory.
            /// </summary>
            [NameInMap("WorkingDir")]
            [Validation(Required=false)]
            public string WorkingDir { get; set; }

        }

        /// <summary>
        /// The level of the instance type, which is used to filter the instance types that meet the specified criteria. This parameter takes effect only if you set the `CostOptimization` parameter to true. Valid values:
        /// 
        /// *   EntryLevel: shared instance type. Instances of this level are the most cost-effective but may not provide stable computing performance in a consistent manner. Instances of this level are suitable for business scenarios in which the CPU utilization is low. For more information, see [Shared instance families](~~108489~~).
        /// *   EnterpriseLevel: Instances of this level provide stable performance and dedicated resources, and are suitable for business scenarios that require high stability. For more information, see [Instance family](~~25378~~).
        /// *   CreditEntryLevel: This value is valid only for burstable instances. CPU credits are used to ensure computing performance. Instances of this level are suitable for scenarios in which the CPU utilization is low but may fluctuate in specific cases. For more information, see the [Overview](~~59977~~) topic of burstable instances.
        /// </summary>
        [NameInMap("InstanceFamilyLevel")]
        [Validation(Required=false)]
        public string InstanceFamilyLevel { get; set; }

        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// The number of IPv6 addresses.
        /// </summary>
        [NameInMap("Ipv6AddressCount")]
        [Validation(Required=false)]
        public int? Ipv6AddressCount { get; set; }

        /// <summary>
        /// The weight of the elastic container instance as a backend server. Valid values: 1 to 100.
        /// </summary>
        [NameInMap("LoadBalancerWeight")]
        [Validation(Required=false)]
        public int? LoadBalancerWeight { get; set; }

        /// <summary>
        /// The memory size of the elastic container instance. Unit: GiB.
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        /// <summary>
        /// The domain names of the NTP server.
        /// </summary>
        [NameInMap("NtpServers")]
        [Validation(Required=false)]
        public List<string> NtpServers { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The name of the RAM role for the instance. You can use an instance RAM role to access both elastic container instances and Elastic Compute Service (ECS) instances. For more information, see [Use an instance RAM role by calling API operations](~~61178~~).
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The instance restart policy. Valid values:
        /// 
        /// *   Always: always restarts the elastic container instance.
        /// *   Never: never restarts the elastic container instance.
        /// *   OnFailure: restarts the elastic container instance upon failures.
        /// 
        /// Default value: Always.
        /// </summary>
        [NameInMap("RestartPolicy")]
        [Validation(Required=false)]
        public string RestartPolicy { get; set; }

        /// <summary>
        /// The ID of the scaling configuration that you want to modify.
        /// </summary>
        [NameInMap("ScalingConfigurationId")]
        [Validation(Required=false)]
        public string ScalingConfigurationId { get; set; }

        /// <summary>
        /// The name of the scaling configuration. The name must be 2 to 64 characters in length and can contain letters, digits, underscores (\_), hyphens (-), and periods (.). The name must start with a letter or a digit.
        /// 
        /// The name of the scaling configuration must be unique within a scaling group in a region. If you do not specify this parameter, the value of the ScalingConfigurationId parameter is used.
        /// </summary>
        [NameInMap("ScalingConfigurationName")]
        [Validation(Required=false)]
        public string ScalingConfigurationName { get; set; }

        /// <summary>
        /// The system information of the security context in which the elastic container instance runs.
        /// </summary>
        [NameInMap("SecurityContextSysCtls")]
        [Validation(Required=false)]
        public List<ModifyEciScalingConfigurationRequestSecurityContextSysCtls> SecurityContextSysCtls { get; set; }
        public class ModifyEciScalingConfigurationRequestSecurityContextSysCtls : TeaModel {
            /// <summary>
            /// The name of the security context in which the elastic container instance runs.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The variable value of the security context in which the elastic container instance runs.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the security group with which you want to associate the elastic container instance. Elastic container instances that are associated with the same security group can access each other.
        /// 
        /// If you do not specify a security group, the system uses the default security group in the region that you selected. Make sure that the inbound rules of the security group contain the protocols and the port numbers of the containers that you want to expose. If you do not have a default security group in the region, the system creates a default security group, and then adds the declared container protocols and port numbers to the inbound rules of the security group.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// The maximum hourly price of the preemptible elastic container instance. The value can be accurate to three decimal places.
        /// 
        /// If you set the SpotStrategy parameter to SpotWithPriceLimit, you must also specify the SpotPriceLimit parameter.
        /// </summary>
        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public float? SpotPriceLimit { get; set; }

        /// <summary>
        /// The bidding policy for the elastic container instance. Valid values:
        /// 
        /// *   NoSpot: The instance is a pay-as-you-go instance.
        /// *   SpotWithPriceLimit: The instance is a preemptible instance with a user-defined maximum hourly price.
        /// *   SpotAsPriceGo: The instance is a preemptible instance for which the market price at the time of purchase is used as the bid price.
        /// 
        /// Default value: NoSpot.
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// Information about the tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ModifyEciScalingConfigurationRequestTags> Tags { get; set; }
        public class ModifyEciScalingConfigurationRequestTags : TeaModel {
            /// <summary>
            /// The key of the tag.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The buffer time in which the program handles operations before the program is stopped. Unit: seconds.
        /// </summary>
        [NameInMap("TerminationGracePeriodSeconds")]
        [Validation(Required=false)]
        public long? TerminationGracePeriodSeconds { get; set; }

        /// <summary>
        /// Information about the volumes.
        /// </summary>
        [NameInMap("Volumes")]
        [Validation(Required=false)]
        public List<ModifyEciScalingConfigurationRequestVolumes> Volumes { get; set; }
        public class ModifyEciScalingConfigurationRequestVolumes : TeaModel {
            [NameInMap("DiskVolume")]
            [Validation(Required=false)]
            public ModifyEciScalingConfigurationRequestVolumesDiskVolume DiskVolume { get; set; }
            public class ModifyEciScalingConfigurationRequestVolumesDiskVolume : TeaModel {
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public int? DiskSize { get; set; }

                [NameInMap("FsType")]
                [Validation(Required=false)]
                public string FsType { get; set; }

            }

            [NameInMap("EmptyDirVolume")]
            [Validation(Required=false)]
            public ModifyEciScalingConfigurationRequestVolumesEmptyDirVolume EmptyDirVolume { get; set; }
            public class ModifyEciScalingConfigurationRequestVolumesEmptyDirVolume : TeaModel {
                [NameInMap("Medium")]
                [Validation(Required=false)]
                public string Medium { get; set; }

                [NameInMap("SizeLimit")]
                [Validation(Required=false)]
                public string SizeLimit { get; set; }

            }

            [NameInMap("FlexVolume")]
            [Validation(Required=false)]
            public ModifyEciScalingConfigurationRequestVolumesFlexVolume FlexVolume { get; set; }
            public class ModifyEciScalingConfigurationRequestVolumesFlexVolume : TeaModel {
                [NameInMap("Driver")]
                [Validation(Required=false)]
                public string Driver { get; set; }

                [NameInMap("FsType")]
                [Validation(Required=false)]
                public string FsType { get; set; }

                [NameInMap("Options")]
                [Validation(Required=false)]
                public string Options { get; set; }

            }

            [NameInMap("HostPathVolume")]
            [Validation(Required=false)]
            public ModifyEciScalingConfigurationRequestVolumesHostPathVolume HostPathVolume { get; set; }
            public class ModifyEciScalingConfigurationRequestVolumesHostPathVolume : TeaModel {
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("NFSVolume")]
            [Validation(Required=false)]
            public ModifyEciScalingConfigurationRequestVolumesNFSVolume NFSVolume { get; set; }
            public class ModifyEciScalingConfigurationRequestVolumesNFSVolume : TeaModel {
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("ReadOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                [NameInMap("Server")]
                [Validation(Required=false)]
                public string Server { get; set; }

            }

            /// <summary>
            /// The paths to the configuration files.
            /// </summary>
            [NameInMap("ConfigFileVolumeConfigFileToPath")]
            [Validation(Required=false)]
            public List<ModifyEciScalingConfigurationRequestVolumesConfigFileVolumeConfigFileToPath> ConfigFileVolumeConfigFileToPath { get; set; }
            public class ModifyEciScalingConfigurationRequestVolumesConfigFileVolumeConfigFileToPath : TeaModel {
                /// <summary>
                /// The content of the configuration file, which can be up to 32 KB in size.
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// The permissions on ConfigFileVolume.
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public int? Mode { get; set; }

                /// <summary>
                /// The relative path to the configuration file.
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

            /// <summary>
            /// The default permissions on ConfigFileVolume.
            /// </summary>
            [NameInMap("ConfigFileVolumeDefaultMode")]
            [Validation(Required=false)]
            public int? ConfigFileVolumeDefaultMode { get; set; }

            /// <summary>
            /// The name of the volume.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The type of HostPathVolume. Examples: File, Directory, and Socket.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
