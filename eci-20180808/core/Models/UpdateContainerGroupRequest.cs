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
            /// <summary>
            /// The IP addresses of DNS servers.
            /// </summary>
            [NameInMap("NameServer")]
            [Validation(Required=false)]
            public List<string> NameServer { get; set; }

            /// <summary>
            /// The configurations of DNS.
            /// </summary>
            [NameInMap("Option")]
            [Validation(Required=false)]
            public List<UpdateContainerGroupRequestDnsConfigOption> Option { get; set; }
            public class UpdateContainerGroupRequestDnsConfigOption : TeaModel {
                /// <summary>
                /// The option name of DNS configurations.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The option value of DNS configurations.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The search domains of the Domain Name System (DNS) server.
            /// </summary>
            [NameInMap("Search")]
            [Validation(Required=false)]
            public List<string> Search { get; set; }

        }

        /// <summary>
        /// Details of the Container Registry Enterprise Edition instance that hosts the image of the init container.
        /// </summary>
        [NameInMap("AcrRegistryInfo")]
        [Validation(Required=false)]
        public List<UpdateContainerGroupRequestAcrRegistryInfo> AcrRegistryInfo { get; set; }
        public class UpdateContainerGroupRequestAcrRegistryInfo : TeaModel {
            /// <summary>
            /// The domain names of the Container Registry Enterprise Edition instance. By default, all domain names of the instance are displayed. You can specify specific domain names. Separate multiple domain names with commas (,).
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public List<string> Domain { get; set; }

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
            /// The ID of the region where the Container Registry Enterprise Edition instance resides.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that the value is unique among different requests. The token can only contain ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotency](~~25693~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The new configurations of the container group.
        /// </summary>
        [NameInMap("Container")]
        [Validation(Required=false)]
        public List<UpdateContainerGroupRequestContainer> Container { get; set; }
        public class UpdateContainerGroupRequestContainer : TeaModel {
            [NameInMap("LivenessProbe")]
            [Validation(Required=false)]
            public UpdateContainerGroupRequestContainerLivenessProbe LivenessProbe { get; set; }
            public class UpdateContainerGroupRequestContainerLivenessProbe : TeaModel {
                [NameInMap("Exec")]
                [Validation(Required=false)]
                public UpdateContainerGroupRequestContainerLivenessProbeExec Exec { get; set; }
                public class UpdateContainerGroupRequestContainerLivenessProbeExec : TeaModel {
                    [NameInMap("Command")]
                    [Validation(Required=false)]
                    public List<string> Command { get; set; }

                }

                [NameInMap("FailureThreshold")]
                [Validation(Required=false)]
                public int? FailureThreshold { get; set; }

                [NameInMap("HttpGet")]
                [Validation(Required=false)]
                public UpdateContainerGroupRequestContainerLivenessProbeHttpGet HttpGet { get; set; }
                public class UpdateContainerGroupRequestContainerLivenessProbeHttpGet : TeaModel {
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
                public UpdateContainerGroupRequestContainerLivenessProbeTcpSocket TcpSocket { get; set; }
                public class UpdateContainerGroupRequestContainerLivenessProbeTcpSocket : TeaModel {
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
            public UpdateContainerGroupRequestContainerReadinessProbe ReadinessProbe { get; set; }
            public class UpdateContainerGroupRequestContainerReadinessProbe : TeaModel {
                [NameInMap("Exec")]
                [Validation(Required=false)]
                public UpdateContainerGroupRequestContainerReadinessProbeExec Exec { get; set; }
                public class UpdateContainerGroupRequestContainerReadinessProbeExec : TeaModel {
                    [NameInMap("Command")]
                    [Validation(Required=false)]
                    public List<string> Command { get; set; }

                }

                [NameInMap("FailureThreshold")]
                [Validation(Required=false)]
                public int? FailureThreshold { get; set; }

                [NameInMap("HttpGet")]
                [Validation(Required=false)]
                public UpdateContainerGroupRequestContainerReadinessProbeHttpGet HttpGet { get; set; }
                public class UpdateContainerGroupRequestContainerReadinessProbeHttpGet : TeaModel {
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
                public UpdateContainerGroupRequestContainerReadinessProbeTcpSocket TcpSocket { get; set; }
                public class UpdateContainerGroupRequestContainerReadinessProbeTcpSocket : TeaModel {
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
            public UpdateContainerGroupRequestContainerSecurityContext SecurityContext { get; set; }
            public class UpdateContainerGroupRequestContainerSecurityContext : TeaModel {
                [NameInMap("Capability")]
                [Validation(Required=false)]
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

            }

            /// <summary>
            /// The arguments that you want to pass to the startup command of the container. You can specify up to 10 arguments.
            /// </summary>
            [NameInMap("Arg")]
            [Validation(Required=false)]
            public List<string> Arg { get; set; }

            /// <summary>
            /// The commands that you want to run to perform the health check.
            /// </summary>
            [NameInMap("Command")]
            [Validation(Required=false)]
            public List<string> Command { get; set; }

            /// <summary>
            /// The number of vCPUs that you want to allocate to the container
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public float? Cpu { get; set; }

            /// <summary>
            /// The environment variables for the container.
            /// </summary>
            [NameInMap("EnvironmentVar")]
            [Validation(Required=false)]
            public List<UpdateContainerGroupRequestContainerEnvironmentVar> EnvironmentVar { get; set; }
            public class UpdateContainerGroupRequestContainerEnvironmentVar : TeaModel {
                [NameInMap("FieldRef")]
                [Validation(Required=false)]
                public UpdateContainerGroupRequestContainerEnvironmentVarFieldRef FieldRef { get; set; }
                public class UpdateContainerGroupRequestContainerEnvironmentVarFieldRef : TeaModel {
                    [NameInMap("FieldPath")]
                    [Validation(Required=false)]
                    public string FieldPath { get; set; }

                }

                /// <summary>
                /// The name of the environment variable for the container.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of the environment variable for the container.
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
            /// *   Always: Each time the instance is updated, image pulling is performed.
            /// *   IfNotPresent: On-premises images are used first. If no on-premises images are available, image pulling is performed.
            /// *   Never: On-premises images are always used. Image pulling is not performed.
            /// </summary>
            [NameInMap("ImagePullPolicy")]
            [Validation(Required=false)]
            public string ImagePullPolicy { get; set; }

            /// <summary>
            /// The commands to be executed in the container when you use the CLI to specify the postStart callback function.
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerExec")]
            [Validation(Required=false)]
            public List<string> LifecyclePostStartHandlerExec { get; set; }

            /// <summary>
            /// The IP address of the host that receives the HTTP GET request when you use an HTTP request to specify the postStart callback function.
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerHttpGetHost")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerHttpGetHost { get; set; }

            /// <summary>
            /// The information about the valid HTTP request headers among the generated HTTP request headers.
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerHttpGetHttpHeaders")]
            [Validation(Required=false)]
            public List<UpdateContainerGroupRequestContainerLifecyclePostStartHandlerHttpGetHttpHeaders> LifecyclePostStartHandlerHttpGetHttpHeaders { get; set; }
            public class UpdateContainerGroupRequestContainerLifecyclePostStartHandlerHttpGetHttpHeaders : TeaModel {
                /// <summary>
                /// The request parameter of the HTTP GET request when you use an HTTP request to specify the postStart callback function.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The request parameter value of the HTTP GET request when you use an HTTP request to specify the postStart callback function.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The path to which the system sends an HTTP GET request for a health check when you use an HTTP request to specify the postStart callback function.
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerHttpGetPath")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerHttpGetPath { get; set; }

            /// <summary>
            /// The port to which the system sends the HTTP GET request when you use an HTTP request to specify the postStart callback function.
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerHttpGetPort")]
            [Validation(Required=false)]
            public int? LifecyclePostStartHandlerHttpGetPort { get; set; }

            /// <summary>
            /// The path to which the system sends an HTTP GET request for a health check when you use an HTTP request to specify the postStart callback function.
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerHttpGetScheme")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerHttpGetScheme { get; set; }

            /// <summary>
            /// The IP address of the host that receives the TCP socket request when you use a TCP socket request to specify the postStart callback function.
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerTcpSocketHost")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerTcpSocketHost { get; set; }

            /// <summary>
            /// The port to which the system sends a TCP socket request for a health check when you use TCP sockets to specify the postStart callback function.
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerTcpSocketPort")]
            [Validation(Required=false)]
            public int? LifecyclePostStartHandlerTcpSocketPort { get; set; }

            /// <summary>
            /// The commands to be executed in the container when you use the CLI to specify the preStop callback function.
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerExec")]
            [Validation(Required=false)]
            public List<string> LifecyclePreStopHandlerExec { get; set; }

            /// <summary>
            /// The IP address of the host that receives the HTTP GET request when you use an HTTP request to specify the preStop callback function.
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerHttpGetHost")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerHttpGetHost { get; set; }

            /// <summary>
            /// The information about the generated HTTP request header.
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerHttpGetHttpHeader")]
            [Validation(Required=false)]
            public List<UpdateContainerGroupRequestContainerLifecyclePreStopHandlerHttpGetHttpHeader> LifecyclePreStopHandlerHttpGetHttpHeader { get; set; }
            public class UpdateContainerGroupRequestContainerLifecyclePreStopHandlerHttpGetHttpHeader : TeaModel {
                /// <summary>
                /// The request parameter of the HTTP GET request when you use an HTTP request to specify the preStop callback function.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The request parameter value of the HTTP GET request when you use an HTTP request to specify the preStop callback function.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The path to which the system sends an HTTP GET request for a health check when you use an HTTP request to specify the preSop callback function.
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerHttpGetPath")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerHttpGetPath { get; set; }

            /// <summary>
            /// The port to which the system sends the HTTP GET request for a health check when you use an HTTP request to specify the preStop callback function.
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerHttpGetPort")]
            [Validation(Required=false)]
            public int? LifecyclePreStopHandlerHttpGetPort { get; set; }

            /// <summary>
            /// The protocol type of the HTTP GET request when you use an HTTP request to specify the preStop callback function. Valid values:
            /// 
            /// *   HTTP
            /// *   HTTPS
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerHttpGetScheme")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerHttpGetScheme { get; set; }

            /// <summary>
            /// The IP address of the host that receives the TCP socket request when you use a TCP socket request to specify the preStop callback function.
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerTcpSocketHost")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerTcpSocketHost { get; set; }

            /// <summary>
            /// The port to which the system sends a TCP socket request for a health check when you use TCP sockets to specify the preStop callback function.
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerTcpSocketPort")]
            [Validation(Required=false)]
            public int? LifecyclePreStopHandlerTcpSocketPort { get; set; }

            /// <summary>
            /// The memory size of the container.
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
            /// The port to which the system sends an HTTP GET request for a health check.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public List<UpdateContainerGroupRequestContainerPort> Port { get; set; }
            public class UpdateContainerGroupRequestContainerPort : TeaModel {
                /// <summary>
                /// The port number. Valid values: 1 to 65535.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The protocol of the container. Valid values: TCP and UDP.
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            /// <summary>
            /// Specifies whether the container allocates buffer resources to standard input streams when the container is running. If you do not specify this parameter, an end-of-file (EOF) error may occur when standard input streams in the container are read. Default value: false.
            /// </summary>
            [NameInMap("Stdin")]
            [Validation(Required=false)]
            public bool? Stdin { get; set; }

            /// <summary>
            /// Specifies whether standard input streams are disconnected after a client is disconnected. If Stdin is set to true, standard input streams remain connected among multiple sessions. If StdinOnce is set to true, standard input streams are connected after the container is started, and remain idle until a client is connected to receive data. After the client is disconnected, streams are also disconnected, and remain disconnected until the container restarts.
            /// </summary>
            [NameInMap("StdinOnce")]
            [Validation(Required=false)]
            public bool? StdinOnce { get; set; }

            /// <summary>
            /// Specifies whether to enable interaction. Default value: false. If the command is a /bin/bash command, set the value to true.
            /// </summary>
            [NameInMap("Tty")]
            [Validation(Required=false)]
            public bool? Tty { get; set; }

            /// <summary>
            /// Pod volumes that you want to mount into the filesystem of the container.
            /// </summary>
            [NameInMap("VolumeMount")]
            [Validation(Required=false)]
            public List<UpdateContainerGroupRequestContainerVolumeMount> VolumeMount { get; set; }
            public class UpdateContainerGroupRequestContainerVolumeMount : TeaModel {
                /// <summary>
                /// The directory of the volume that is mounted to the container. The data in this directory is overwritten by the data on the volume. Specify this parameter with caution.
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// The mount propagation settings of the volume. Mount propagation allows volumes that are mounted on one container to be shared with other containers in the same pod, or even with other pods on the same node. Valid values:
                /// 
                /// *   None: This volume mount does not receive subsequent mounts that are performed on this volume or subdirectories of this volume.
                /// *   HostToCotainer: The volume mount receives subsequent mounts that are performed on this volume or the subdirectories of this volume.
                /// *   Bidirectional: The volume mount behaves the same as the HostToContainer mount. The volume mount receives subsequent mounts that are performed on the volume or the subdirectories of the volume. In addition, all volume mounts that are mounted on the container are propagated back to the host and all containers of all pods that use the same volume.
                /// 
                /// Default value: None.
                /// </summary>
                [NameInMap("MountPropagation")]
                [Validation(Required=false)]
                public string MountPropagation { get; set; }

                /// <summary>
                /// The name of the volume that is mounted to the container. Valid values: the values of Volume.N.Name, which are the names of volumes that are mounted to the elastic container instance.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Specifies whether the volume is read-only. Default value: false.
                /// </summary>
                [NameInMap("ReadOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                /// <summary>
                /// The subdirectory of the volume that is mounted to the container. You can use this parameter to mount the same volume to different subdirectories of the container.
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

        /// <summary>
        /// The ID of the elastic container instance that you want to update.
        /// </summary>
        [NameInMap("ContainerGroupId")]
        [Validation(Required=false)]
        public string ContainerGroupId { get; set; }

        /// <summary>
        /// The number of vCPUs that are allocated to the elastic container instance.
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// The information about the credentials of the image repository.
        /// </summary>
        [NameInMap("ImageRegistryCredential")]
        [Validation(Required=false)]
        public List<UpdateContainerGroupRequestImageRegistryCredential> ImageRegistryCredential { get; set; }
        public class UpdateContainerGroupRequestImageRegistryCredential : TeaModel {
            /// <summary>
            /// The password that you use to access the image repository.
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// The address of the image repository. This address does not contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Server")]
            [Validation(Required=false)]
            public string Server { get; set; }

            /// <summary>
            /// The username that you use to access the image repository.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// The information about the new init container.
        /// </summary>
        [NameInMap("InitContainer")]
        [Validation(Required=false)]
        public List<UpdateContainerGroupRequestInitContainer> InitContainer { get; set; }
        public class UpdateContainerGroupRequestInitContainer : TeaModel {
            [NameInMap("SecurityContext")]
            [Validation(Required=false)]
            public UpdateContainerGroupRequestInitContainerSecurityContext SecurityContext { get; set; }
            public class UpdateContainerGroupRequestInitContainerSecurityContext : TeaModel {
                [NameInMap("Capability")]
                [Validation(Required=false)]
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

            }

            /// <summary>
            /// The arguments that you want to pass to the startup command of the init container.
            /// </summary>
            [NameInMap("Arg")]
            [Validation(Required=false)]
            public List<string> Arg { get; set; }

            /// <summary>
            /// The commands that are used to start the init container.
            /// </summary>
            [NameInMap("Command")]
            [Validation(Required=false)]
            public List<string> Command { get; set; }

            /// <summary>
            /// The number of vCPUs that you want to allocate to the init container.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public float? Cpu { get; set; }

            /// <summary>
            /// The environment variable of the init container.
            /// </summary>
            [NameInMap("EnvironmentVar")]
            [Validation(Required=false)]
            public List<UpdateContainerGroupRequestInitContainerEnvironmentVar> EnvironmentVar { get; set; }
            public class UpdateContainerGroupRequestInitContainerEnvironmentVar : TeaModel {
                [NameInMap("FieldRef")]
                [Validation(Required=false)]
                public UpdateContainerGroupRequestInitContainerEnvironmentVarFieldRef FieldRef { get; set; }
                public class UpdateContainerGroupRequestInitContainerEnvironmentVarFieldRef : TeaModel {
                    [NameInMap("FieldPath")]
                    [Validation(Required=false)]
                    public string FieldPath { get; set; }

                }

                /// <summary>
                /// The name of the environment variable for the init container.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of the environment variable for the init container.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The number of GPUs you want to allocate to the init container.
            /// </summary>
            [NameInMap("Gpu")]
            [Validation(Required=false)]
            public int? Gpu { get; set; }

            /// <summary>
            /// The image of the init container.
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// The image pulling policy. Valid values:
            /// 
            /// *   Always: Each time the instance is updated, image pulling is performed.
            /// *   IfNotPresent: On-premises images are used first. If no on-premises images are available, image pulling is performed.
            /// *   Never: On-premises images are always used. Image pulling is not performed.
            /// </summary>
            [NameInMap("ImagePullPolicy")]
            [Validation(Required=false)]
            public string ImagePullPolicy { get; set; }

            /// <summary>
            /// The memory size of the init container.
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// The name of the init container.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The port number. Valid values: 1 to 65535.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public List<UpdateContainerGroupRequestInitContainerPort> Port { get; set; }
            public class UpdateContainerGroupRequestInitContainerPort : TeaModel {
                /// <summary>
                /// The port number of the init container. Valid values: 1 to 65535.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The protocol of the init container. Valid values: TCP and UDP.
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            /// <summary>
            /// Specifies whether the init container allocates buffer resources to standard input streams when the init container is running. If you do not specify this parameter, an EOF error may occur when standard input streams in the init container are read. Default value: false.
            /// </summary>
            [NameInMap("Stdin")]
            [Validation(Required=false)]
            public bool? Stdin { get; set; }

            /// <summary>
            /// Specifies whether standard input streams are disconnected after a client is disconnected. If Stdin is set to true, standard input streams remain connected among multiple sessions. If StdinOnce is set to true, standard input streams are connected after the init container is started, and remain idle until a client is connected to receive data. After the client is disconnected, streams are also disconnected, and remain disconnected until the init container restarts.
            /// </summary>
            [NameInMap("StdinOnce")]
            [Validation(Required=false)]
            public bool? StdinOnce { get; set; }

            /// <summary>
            /// Specifies whether to enable interaction. Default value: false. If the command is a /bin/bash command, set the value to true.
            /// </summary>
            [NameInMap("Tty")]
            [Validation(Required=false)]
            public bool? Tty { get; set; }

            /// <summary>
            /// The information about the volume that you want to mount on the init container.
            /// </summary>
            [NameInMap("VolumeMount")]
            [Validation(Required=false)]
            public List<UpdateContainerGroupRequestInitContainerVolumeMount> VolumeMount { get; set; }
            public class UpdateContainerGroupRequestInitContainerVolumeMount : TeaModel {
                /// <summary>
                /// The mount directory of the init container. The data in this directory is overwritten by the data on the volume. Specify this parameter with caution.
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// The mount propagation settings of the volume. Mount propagation allows volumes that are mounted on one container to be shared with other containers in the same pod, or even with other pods on the same node. Valid values:
                /// 
                /// *   None: The volume mount does not receive subsequent mounts that are performed on this volume or subdirectories of this volume.
                /// *   HostToContainer: The volume mount receives all subsequent mounts that are performed on this volume or subdirectories of this volume.
                /// *   Bidirectional: The volume mount behaves the same as the HostToContainer mount. The volume mount receives subsequent mounts that are performed on the volume or the subdirectories of the volume. In addition, all volume mounts that are mounted on the container are propagated back to the host and all containers of all pods that use the same volume.
                /// 
                /// Default value: None.
                /// </summary>
                [NameInMap("MountPropagation")]
                [Validation(Required=false)]
                public string MountPropagation { get; set; }

                /// <summary>
                /// The name of the volume that is mounted to the init container. Valid values: the values of Volume.N.Name, which are the names of volumes that are mounted to the elastic container instance.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Specifies whether the volume is read-only. Default value: false.
                /// </summary>
                [NameInMap("ReadOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                /// <summary>
                /// The subdirectory of the volume that is mounted to the init container. You can use this parameter to mount the same volume to different subdirectories of the init container.
                /// </summary>
                [NameInMap("SubPath")]
                [Validation(Required=false)]
                public string SubPath { get; set; }

            }

            /// <summary>
            /// The working directory of the init container.
            /// </summary>
            [NameInMap("WorkingDir")]
            [Validation(Required=false)]
            public string WorkingDir { get; set; }

        }

        /// <summary>
        /// The size of the memory that is allocated to the elastic container instance. Unit: GiB.
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The restart policy of the elastic container instance. Valid values:
        /// 
        /// *   Always: Always restarts the instance if a container in the instance exits upon termination.
        /// *   Never: Never restarts the instance if a container in the instance exits upon termination.
        /// *   OnFailure: Restarts the instance only if a container in the instance exists upon failure with a status code of non-zero.
        /// </summary>
        [NameInMap("RestartPolicy")]
        [Validation(Required=false)]
        public string RestartPolicy { get; set; }

        /// <summary>
        /// The tags that are bound to the instance.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<UpdateContainerGroupRequestTag> Tag { get; set; }
        public class UpdateContainerGroupRequestTag : TeaModel {
            /// <summary>
            /// The tag key.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The update type. Valid values:
        /// 
        /// *   RenewUpdate: full updates. You must specify all relevant parameters to update the elastic container instance. For a parameter of the list type, you must specify all the items contained in the parameter even if you want to update only some of the items. For a parameter of the struct type, you must specify all the members even if you want to update only some of the members.
        /// *   IncrementalUpdate: incremental updates. You may specify only the parameter that you want to update. Other related parameters remain unchanged.
        /// 
        /// Default value: RenewUpdate.
        /// </summary>
        [NameInMap("UpdateType")]
        [Validation(Required=false)]
        public string UpdateType { get; set; }

        /// <summary>
        /// The volumes that are mounted to the instance.
        /// </summary>
        [NameInMap("Volume")]
        [Validation(Required=false)]
        public List<UpdateContainerGroupRequestVolume> Volume { get; set; }
        public class UpdateContainerGroupRequestVolume : TeaModel {
            [NameInMap("ConfigFileVolume")]
            [Validation(Required=false)]
            public UpdateContainerGroupRequestVolumeConfigFileVolume ConfigFileVolume { get; set; }
            public class UpdateContainerGroupRequestVolumeConfigFileVolume : TeaModel {
                [NameInMap("ConfigFileToPath")]
                [Validation(Required=false)]
                public List<UpdateContainerGroupRequestVolumeConfigFileVolumeConfigFileToPath> ConfigFileToPath { get; set; }
                public class UpdateContainerGroupRequestVolumeConfigFileVolumeConfigFileToPath : TeaModel {
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                }

            }

            [NameInMap("EmptyDirVolume")]
            [Validation(Required=false)]
            public UpdateContainerGroupRequestVolumeEmptyDirVolume EmptyDirVolume { get; set; }
            public class UpdateContainerGroupRequestVolumeEmptyDirVolume : TeaModel {
                [NameInMap("Medium")]
                [Validation(Required=false)]
                public string Medium { get; set; }

                [NameInMap("SizeLimit")]
                [Validation(Required=false)]
                public string SizeLimit { get; set; }

            }

            [NameInMap("FlexVolume")]
            [Validation(Required=false)]
            public UpdateContainerGroupRequestVolumeFlexVolume FlexVolume { get; set; }
            public class UpdateContainerGroupRequestVolumeFlexVolume : TeaModel {
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
            public UpdateContainerGroupRequestVolumeHostPathVolume HostPathVolume { get; set; }
            public class UpdateContainerGroupRequestVolumeHostPathVolume : TeaModel {
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("NFSVolume")]
            [Validation(Required=false)]
            public UpdateContainerGroupRequestVolumeNFSVolume NFSVolume { get; set; }
            public class UpdateContainerGroupRequestVolumeNFSVolume : TeaModel {
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
            /// The volume name.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The type of the HostPath volume. Valid values:
            /// 
            /// *   Directory
            /// *   File
            /// 
            /// >  This parameter is not publicly available.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
