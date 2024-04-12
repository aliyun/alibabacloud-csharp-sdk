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
            /// <summary>
            /// The IP addresses of the DNS servers.
            /// </summary>
            [NameInMap("NameServer")]
            [Validation(Required=false)]
            public List<string> NameServer { get; set; }

            /// <summary>
            /// Configuration options of the DNS server.
            /// </summary>
            [NameInMap("Option")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestDnsConfigOption> Option { get; set; }
            public class CreateContainerGroupRequestDnsConfigOption : TeaModel {
                /// <summary>
                /// The name of the option.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The value of the option.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The search domains of the DNS server.
            /// </summary>
            [NameInMap("Search")]
            [Validation(Required=false)]
            public List<string> Search { get; set; }

        }

        [NameInMap("HostSecurityContext")]
        [Validation(Required=false)]
        public CreateContainerGroupRequestHostSecurityContext HostSecurityContext { get; set; }
        public class CreateContainerGroupRequestHostSecurityContext : TeaModel {
            /// <summary>
            /// Configure a security context to modify unsafe sysctls. For more information, see [Configure a security context](~~462313~~).
            /// </summary>
            [NameInMap("Sysctl")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestHostSecurityContextSysctl> Sysctl { get; set; }
            public class CreateContainerGroupRequestHostSecurityContextSysctl : TeaModel {
                /// <summary>
                /// The key of the unsafe sysctl when you modify sysctls by configuring a security context. Valid values:
                /// 
                /// *   kernel.shm \* (except kernel.shm_rmid_forced)
                /// *   kernel.msg\*kernel.sem
                /// *   fs.mqueue.\*
                /// *   net.\*(except net.ipv4.tcp_syncookies, net.ipv4.ping_group_range, and net.ipv4.ip_unprivileged_port_start)
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The value of the unsafe sysctl when you modify sysctls by configuring a security context.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("SecurityContext")]
        [Validation(Required=false)]
        public CreateContainerGroupRequestSecurityContext SecurityContext { get; set; }
        public class CreateContainerGroupRequestSecurityContext : TeaModel {
            /// <summary>
            /// Configure a security context to modify sysctls. For more information, see [Configure a security context](~~462313~~)
            /// </summary>
            [NameInMap("Sysctl")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestSecurityContextSysctl> Sysctl { get; set; }
            public class CreateContainerGroupRequestSecurityContextSysctl : TeaModel {
                /// <summary>
                /// The name of the safe sysctl when you configure a security context to modify sysctls. Valid values:
                /// 
                /// *   net.ipv4.ping_group_range
                /// *   net.ipv4.ip_unprivileged_port_start
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The value of the safe sysctl when you configure a security context to modify sysctls.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The information about the Container Registry Enterprise Edition instance. For more information, see [Pull images from a Container Registry Enterprise Edition instance without using secrets](~~194250~~).
        /// </summary>
        [NameInMap("AcrRegistryInfo")]
        [Validation(Required=false)]
        public List<CreateContainerGroupRequestAcrRegistryInfo> AcrRegistryInfo { get; set; }
        public class CreateContainerGroupRequestAcrRegistryInfo : TeaModel {
            /// <summary>
            /// The Alibaba Cloud Resource Name (ARN) of the RAM roles in the Alibaba Cloud account to which the elastic container instance belongs.
            /// </summary>
            [NameInMap("ArnService")]
            [Validation(Required=false)]
            public string ArnService { get; set; }

            /// <summary>
            /// The ARN of the RAM roles in the Alibaba Cloud account to which the Container Registry instance belongs.
            /// </summary>
            [NameInMap("ArnUser")]
            [Validation(Required=false)]
            public string ArnUser { get; set; }

            /// <summary>
            /// The domain names of the Container Registry Enterprise Edition instance. By default, all domain names of the instance are displayed. You can specify multiple domain names. Separate multiple domain names with commas (,).
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
            /// The region ID of the Container Registry Enterprise Edition instance.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// The validity period of the elastic container instance. When this period expires, the instance is forced to exit. Unit: seconds.
        /// </summary>
        [NameInMap("ActiveDeadlineSeconds")]
        [Validation(Required=false)]
        public long? ActiveDeadlineSeconds { get; set; }

        /// <summary>
        /// Specifies whether to automatically create an EIP and associate it with the elastic container instance.
        /// </summary>
        [NameInMap("AutoCreateEip")]
        [Validation(Required=false)]
        public bool? AutoCreateEip { get; set; }

        /// <summary>
        /// Specifies whether to automatically match image caches. Default value: false.
        /// </summary>
        [NameInMap("AutoMatchImageCache")]
        [Validation(Required=false)]
        public bool? AutoMatchImageCache { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that the value is unique among different requests. The token can only contain ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotency of requests?](~~25693~~)
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The computing power type of the instance.
        /// </summary>
        [NameInMap("ComputeCategory")]
        [Validation(Required=false)]
        public List<string> ComputeCategory { get; set; }

        /// <summary>
        /// The information about the containers.
        /// </summary>
        [NameInMap("Container")]
        [Validation(Required=false)]
        public List<CreateContainerGroupRequestContainer> Container { get; set; }
        public class CreateContainerGroupRequestContainer : TeaModel {
            [NameInMap("LivenessProbe")]
            [Validation(Required=false)]
            public CreateContainerGroupRequestContainerLivenessProbe LivenessProbe { get; set; }
            public class CreateContainerGroupRequestContainerLivenessProbe : TeaModel {
                [NameInMap("Exec")]
                [Validation(Required=false)]
                public CreateContainerGroupRequestContainerLivenessProbeExec Exec { get; set; }
                public class CreateContainerGroupRequestContainerLivenessProbeExec : TeaModel {
                    [NameInMap("Command")]
                    [Validation(Required=false)]
                    public List<string> Command { get; set; }

                }

                [NameInMap("FailureThreshold")]
                [Validation(Required=false)]
                public int? FailureThreshold { get; set; }

                [NameInMap("HttpGet")]
                [Validation(Required=false)]
                public CreateContainerGroupRequestContainerLivenessProbeHttpGet HttpGet { get; set; }
                public class CreateContainerGroupRequestContainerLivenessProbeHttpGet : TeaModel {
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
                public CreateContainerGroupRequestContainerLivenessProbeTcpSocket TcpSocket { get; set; }
                public class CreateContainerGroupRequestContainerLivenessProbeTcpSocket : TeaModel {
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
            public CreateContainerGroupRequestContainerReadinessProbe ReadinessProbe { get; set; }
            public class CreateContainerGroupRequestContainerReadinessProbe : TeaModel {
                [NameInMap("Exec")]
                [Validation(Required=false)]
                public CreateContainerGroupRequestContainerReadinessProbeExec Exec { get; set; }
                public class CreateContainerGroupRequestContainerReadinessProbeExec : TeaModel {
                    [NameInMap("Command")]
                    [Validation(Required=false)]
                    public List<string> Command { get; set; }

                }

                [NameInMap("FailureThreshold")]
                [Validation(Required=false)]
                public int? FailureThreshold { get; set; }

                [NameInMap("HttpGet")]
                [Validation(Required=false)]
                public CreateContainerGroupRequestContainerReadinessProbeHttpGet HttpGet { get; set; }
                public class CreateContainerGroupRequestContainerReadinessProbeHttpGet : TeaModel {
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
                public CreateContainerGroupRequestContainerReadinessProbeTcpSocket TcpSocket { get; set; }
                public class CreateContainerGroupRequestContainerReadinessProbeTcpSocket : TeaModel {
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
            public CreateContainerGroupRequestContainerSecurityContext SecurityContext { get; set; }
            public class CreateContainerGroupRequestContainerSecurityContext : TeaModel {
                [NameInMap("Capability")]
                [Validation(Required=false)]
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

            }

            /// <summary>
            /// The arguments that are passed to the startup command of the container. You can specify up to 10 arguments.
            /// </summary>
            [NameInMap("Arg")]
            [Validation(Required=false)]
            public List<string> Arg { get; set; }

            /// <summary>
            /// The commands that you want to run to perform health checks on containers.
            /// </summary>
            [NameInMap("Command")]
            [Validation(Required=false)]
            public List<string> Command { get; set; }

            /// <summary>
            /// The number of vCPUs that you want to allocate to the container.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public float? Cpu { get; set; }

            /// <summary>
            /// The value of the environment variable for the container.
            /// </summary>
            [NameInMap("EnvironmentVar")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestContainerEnvironmentVar> EnvironmentVar { get; set; }
            public class CreateContainerGroupRequestContainerEnvironmentVar : TeaModel {
                [NameInMap("FieldRef")]
                [Validation(Required=false)]
                public CreateContainerGroupRequestContainerEnvironmentVarFieldRef FieldRef { get; set; }
                public class CreateContainerGroupRequestContainerEnvironmentVarFieldRef : TeaModel {
                    [NameInMap("FieldPath")]
                    [Validation(Required=false)]
                    public string FieldPath { get; set; }

                }

                /// <summary>
                /// The name of the environment variable. The name must be 1 to 128 bits in length and can contain letters, digits, and underscores (\_). It cannot start with a digit.``
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of the environment variable. The value must be 0 to 256 bits in length.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// Specifies whether to hide the information about environment variables when you query the details of an elastic container instance. Default value: false. Valid values:
            /// 
            /// *   false
            /// *   true If environment variables contain sensitive information, you can set this parameter to true to improve security of the information.
            /// </summary>
            [NameInMap("EnvironmentVarHide")]
            [Validation(Required=false)]
            public bool? EnvironmentVarHide { get; set; }

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
            /// The policy that you want to use to pull an image. Valid values:
            /// 
            /// *   Always: Each time instances are created, image pulling is performed.
            /// *   IfNotPresent: On-premises images are preferentially used. If no on-premises images are available, image pulling is performed.
            /// *   Never: On-premises images are always used. Image pulling is not performed.
            /// </summary>
            [NameInMap("ImagePullPolicy")]
            [Validation(Required=false)]
            public string ImagePullPolicy { get; set; }

            /// <summary>
            /// The commands to be executed in containers when you use a CLI to specify the postStart callback function.
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
            /// The HTTP GET request header.
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerHttpGetHttpHeader")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestContainerLifecyclePostStartHandlerHttpGetHttpHeader> LifecyclePostStartHandlerHttpGetHttpHeader { get; set; }
            public class CreateContainerGroupRequestContainerLifecyclePostStartHandlerHttpGetHttpHeader : TeaModel {
                /// <summary>
                /// The name of the custom field in the HTTP GET request header when you use HTTP requests to specify the postStart callback function.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The value of the custom field in the HTTP GET request header when you use HTTP requests to specify the postStart callback function.
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
            /// The port to which the system sends an HTTP GET request when you use an HTTP request to specify the postStart callback function.
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerHttpGetPort")]
            [Validation(Required=false)]
            public int? LifecyclePostStartHandlerHttpGetPort { get; set; }

            /// <summary>
            /// The protocol type of HTTP GET requests when you use HTTP requests to specify the postStart callback function. Valid values:
            /// 
            /// *   HTTP
            /// *   HTTPS
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerHttpGetScheme")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerHttpGetScheme { get; set; }

            /// <summary>
            /// The port to which the system sends a TCP socket request for a health check when you use TCP sockets to specify the postStart callback function.
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
            /// The commands to be executed in containers when you use a CLI to specify the preStop callback function.
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
            /// The HTTP GET request header.
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerHttpGetHttpHeader")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestContainerLifecyclePreStopHandlerHttpGetHttpHeader> LifecyclePreStopHandlerHttpGetHttpHeader { get; set; }
            public class CreateContainerGroupRequestContainerLifecyclePreStopHandlerHttpGetHttpHeader : TeaModel {
                /// <summary>
                /// The key of the custom field in the HTTP GET request header when you use HTTP requests to specify the preStop callback function.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The value of the custom field in the HTTP GET request header when you use HTTP requests to specify the preStop callback function.
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
            /// The port to which the system sends an HTTP GET request for a health check when you use HTTP requests to specify the preStop callback function.
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
            /// The memory size that you want to allocate to the container. Unit: GiB
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
            /// The port to which the system sends an HTTP GET request for a health check when you use HTTP requests to perform health checks.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestContainerPort> Port { get; set; }
            public class CreateContainerGroupRequestContainerPort : TeaModel {
                /// <summary>
                /// The port number. Valid values: 1 to 65535.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The protocol type. Valid values:
                /// 
                /// *   TCP
                /// *   UDP
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            /// <summary>
            /// The user group that runs the container.
            /// </summary>
            [NameInMap("SecurityContextRunAsGroup")]
            [Validation(Required=false)]
            public long? SecurityContextRunAsGroup { get; set; }

            /// <summary>
            /// Specifies whether to run the container as a non-root user.
            /// </summary>
            [NameInMap("SecurityContextRunAsNonRoot")]
            [Validation(Required=false)]
            public bool? SecurityContextRunAsNonRoot { get; set; }

            /// <summary>
            /// Specifies whether the container allocates buffer resources to standard input streams when the container is running. If you do not specify this parameter, an end-of-file (EOF) error may occur when standard input streams in the container are read. Default value: false.
            /// </summary>
            [NameInMap("Stdin")]
            [Validation(Required=false)]
            public bool? Stdin { get; set; }

            /// <summary>
            /// Specifies whether standard input streams are disconnected from multiple sessions after a client is disconnected.\
            /// If StdinOnce is set to true, standard input streams are connected after the container is started, and remain idle until a client is connected to receive data. After the client is disconnected, standard input streams are also disconnected, and remain disconnected until the container restarts.
            /// </summary>
            [NameInMap("StdinOnce")]
            [Validation(Required=false)]
            public bool? StdinOnce { get; set; }

            /// <summary>
            /// The path of the file from which the system retrieves termination messages of the container when the container exits.
            /// </summary>
            [NameInMap("TerminationMessagePath")]
            [Validation(Required=false)]
            public string TerminationMessagePath { get; set; }

            /// <summary>
            /// The message notification policy. This parameter is empty by default. Only Message Service (MNS) queue message notifications can be sent.
            /// </summary>
            [NameInMap("TerminationMessagePolicy")]
            [Validation(Required=false)]
            public string TerminationMessagePolicy { get; set; }

            /// <summary>
            /// Specifies whether to enable interaction. Default value: false.
            /// 
            /// If the command is a /bin/bash command, set the value to true.
            /// </summary>
            [NameInMap("Tty")]
            [Validation(Required=false)]
            public bool? Tty { get; set; }

            /// <summary>
            /// The information about the volume that you want to mount to the container.
            /// </summary>
            [NameInMap("VolumeMount")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestContainerVolumeMount> VolumeMount { get; set; }
            public class CreateContainerGroupRequestContainerVolumeMount : TeaModel {
                /// <summary>
                /// The directory to which the volume is mounted.
                /// 
                /// >  The data stored in this directory is overwritten by the data on the volume. Specify this parameter with caution.
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// The mount propagation settings of the volume. Mount propagation allows volumes that are mounted on one container to be shared with other containers in the same pod, or even with other pods on the same node. Valid values:
                /// 
                /// *   None: The volume mount does not receive subsequent mounts that are performed on this volume or subdirectories of this volume.
                /// *   HostToCotainer: The volume mount receives subsequent mounts that are performed on this volume or the subdirectories of this volume.
                /// *   Bidirectional: This value is similar to HostToContainer. The volume mount receives subsequent mounts that are performed on this volume or the subdirectories of this volume. In addition, all volume mounts that are mounted on the container are propagated back to the host and all containers of all pods that use the same volume.
                /// 
                /// Default value: None.
                /// </summary>
                [NameInMap("MountPropagation")]
                [Validation(Required=false)]
                public string MountPropagation { get; set; }

                /// <summary>
                /// The name of the volume. The name of this parameter is the same as the name of the volume that is mounted to the containers.
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

        /// <summary>
        /// The name of the elastic container instance. Format requirements:
        /// 
        /// *   The name must be 2 to 128 characters in length
        /// *   The name can contain lowercase letters, digits, and hyphens (-). It cannot start or end with a hyphen (-).
        /// </summary>
        [NameInMap("ContainerGroupName")]
        [Validation(Required=false)]
        public string ContainerGroupName { get; set; }

        /// <summary>
        /// Specifies whether to enable container resource view. Container resource view displays the actual container resource data instead of data of the host. If the specifications of the generated elastic container instance are larger than the specifications that you request for when you create the instance, you can enable the ContainerResourceView feature to ensure that the resources that you view in the container are the same as the resources that you request for.
        /// </summary>
        [NameInMap("ContainerResourceView")]
        [Validation(Required=false)]
        public bool? ContainerResourceView { get; set; }

        /// <summary>
        /// The path to store core dump files. For more information, see [Save core files to volumes](~~167801~~).
        /// 
        /// > The path cannot start with a vertical bar (`|`). You cannot use core dump files to configure executable programs.
        /// </summary>
        [NameInMap("CorePattern")]
        [Validation(Required=false)]
        public string CorePattern { get; set; }

        /// <summary>
        /// The number of vCPUs that you want to allocate to the elastic container instance.
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// The CPU architecture of the instance. Default value: AMD64. Valid values:
        /// 
        /// *   AMD64
        /// *   ARM64
        /// </summary>
        [NameInMap("CpuArchitecture")]
        [Validation(Required=false)]
        public string CpuArchitecture { get; set; }

        /// <summary>
        /// The number of physical CPU cores. You can specify this parameter only for specific instance types. For more information, see [Specify custom CPU options](~~197781~~).
        /// </summary>
        [NameInMap("CpuOptionsCore")]
        [Validation(Required=false)]
        public int? CpuOptionsCore { get; set; }

        /// <summary>
        /// This parameter is not available.
        /// </summary>
        [NameInMap("CpuOptionsNuma")]
        [Validation(Required=false)]
        public string CpuOptionsNuma { get; set; }

        /// <summary>
        /// The number of threads per core. You can specify this parameter only for specific instance types. If you set this parameter to 1, Hyper-Threading is disabled. For more information, see [Specify custom CPU options](~~197781~~).
        /// </summary>
        [NameInMap("CpuOptionsThreadsPerCore")]
        [Validation(Required=false)]
        public int? CpuOptionsThreadsPerCore { get; set; }

        /// <summary>
        /// The bucket to store data caches.
        /// </summary>
        [NameInMap("DataCacheBucket")]
        [Validation(Required=false)]
        public string DataCacheBucket { get; set; }

        /// <summary>
        /// Specifies whether to enable the performance burst feature when ESSDs AutoPL are used for data caching. For more information, see [ESSDs AutoPL](~~368372~~).
        /// </summary>
        [NameInMap("DataCacheBurstingEnabled")]
        [Validation(Required=false)]
        public bool? DataCacheBurstingEnabled { get; set; }

        /// <summary>
        /// The performance level of the disk used by data caches.\
        /// Enhanced SSDs (ESSDs) are preferentially used. The default performance level is PL1.
        /// </summary>
        [NameInMap("DataCachePL")]
        [Validation(Required=false)]
        public string DataCachePL { get; set; }

        /// <summary>
        /// The input/output operations per second (IOPS) provisioned for ESSDs AutoPL when ESSDs AutoPL are used for data caching.\
        /// Valid values: 0 to min{50000, 1000 × Capacity - Baseline IOPS}. Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}.\
        /// For more information, see [ESSDs AutoPL](~~368372~~).
        /// </summary>
        [NameInMap("DataCacheProvisionedIops")]
        [Validation(Required=false)]
        public long? DataCacheProvisionedIops { get; set; }

        /// <summary>
        /// The Domain Name System (DNS) policy. Valid values:
        /// 
        /// *   None: uses the DNS that is specified for DnsConfig-related parameters.
        /// *   Default: uses the DNS that is specified for the runtime environment.
        /// </summary>
        [NameInMap("DnsPolicy")]
        [Validation(Required=false)]
        public string DnsPolicy { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run without performing the actual request. Valid values:
        /// 
        /// *   true: performs only a dry run without creating an elastic container instance. The check items include the request format, service limits, resource inventory, and whether the required parameters are specified. If the request fails the dry run, an error is returned. If the request passes the dry run, the DryRun.Success error code is returned.
        /// *   false (default): performs a dry run, and creates an elastic container instance after the request passes the dry run.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The maximum outbound bandwidth. Unit: bytes.
        /// </summary>
        [NameInMap("EgressBandwidth")]
        [Validation(Required=false)]
        public long? EgressBandwidth { get; set; }

        /// <summary>
        /// The bandwidth of the EIP. Unit: Mbit/s. Default value: 5.\
        /// You can specify this parameter when you set AutoCreateEip to true.
        /// </summary>
        [NameInMap("EipBandwidth")]
        [Validation(Required=false)]
        public int? EipBandwidth { get; set; }

        /// <summary>
        /// Specifies the EIP bandwidth plan that you want to use.
        /// </summary>
        [NameInMap("EipCommonBandwidthPackage")]
        [Validation(Required=false)]
        public string EipCommonBandwidthPackage { get; set; }

        /// <summary>
        /// The line type of the elastic IP address (EIP). Valid values:
        /// 
        /// *   BGP: BGP (Multi-ISP) lines
        /// *   BGP_PRO: BGP (Multi-ISP) Pro lines
        /// </summary>
        [NameInMap("EipISP")]
        [Validation(Required=false)]
        public string EipISP { get; set; }

        /// <summary>
        /// The ID of the elastic IP address (EIP).
        /// </summary>
        [NameInMap("EipInstanceId")]
        [Validation(Required=false)]
        public string EipInstanceId { get; set; }

        /// <summary>
        /// The increased storage capacity of the temporary storage space. Unit: GiB.\
        /// For more information, see [Increase the storage capacity of the temporary storage space](~~204066~~).
        /// </summary>
        [NameInMap("EphemeralStorage")]
        [Validation(Required=false)]
        public int? EphemeralStorage { get; set; }

        /// <summary>
        /// Specifies whether to configure the instance to use a fixed IP address. For more information, see [Configure an elastic container instance to use a fixed IP address](~~2381086~~).
        /// </summary>
        [NameInMap("FixedIp")]
        [Validation(Required=false)]
        public string FixedIp { get; set; }

        /// <summary>
        /// The retention period of the fixed IP address after the original instance is released and the fixed IP address becomes idle. Unit: hours. Default value: 48.
        /// </summary>
        [NameInMap("FixedIpRetainHour")]
        [Validation(Required=false)]
        public int? FixedIpRetainHour { get; set; }

        [NameInMap("GpuDriverVersion")]
        [Validation(Required=false)]
        public string GpuDriverVersion { get; set; }

        /// <summary>
        /// The alias of the elastic container instance.
        /// </summary>
        [NameInMap("HostAliase")]
        [Validation(Required=false)]
        public List<CreateContainerGroupRequestHostAliase> HostAliase { get; set; }
        public class CreateContainerGroupRequestHostAliase : TeaModel {
            /// <summary>
            /// The hostname of the elastic container instance.
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public List<string> Hostname { get; set; }

            /// <summary>
            /// The IP address of the host.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

        }

        /// <summary>
        /// The hostname of the instance.
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// The image acceleration mode. Valid values:
        /// 
        /// *   nydus: Nydus is used to accelerate image pulling. The images must support Nydus.
        /// *   dadi: DADI is used to accelerate image pulling. The images must support DADI.
        /// *   p2p: P2P is used to accelerate image pulling. The images must support P2P.
        /// *   imc: Image caches are used to accelerate image pulling.
        /// </summary>
        [NameInMap("ImageAccelerateMode")]
        [Validation(Required=false)]
        public string ImageAccelerateMode { get; set; }

        /// <summary>
        /// The information about the image repository.
        /// </summary>
        [NameInMap("ImageRegistryCredential")]
        [Validation(Required=false)]
        public List<CreateContainerGroupRequestImageRegistryCredential> ImageRegistryCredential { get; set; }
        public class CreateContainerGroupRequestImageRegistryCredential : TeaModel {
            /// <summary>
            /// The password that you use to access the image repository.
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// The address of the image repository.
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
        /// The ID of the image cache. For more information, see [Use image caches to accelerate the creation of instances](~~141281~~).
        /// </summary>
        [NameInMap("ImageSnapshotId")]
        [Validation(Required=false)]
        public string ImageSnapshotId { get; set; }

        /// <summary>
        /// The maximum inbound bandwidth. Unit: bytes.
        /// </summary>
        [NameInMap("IngressBandwidth")]
        [Validation(Required=false)]
        public long? IngressBandwidth { get; set; }

        /// <summary>
        /// The information about the init containers.
        /// </summary>
        [NameInMap("InitContainer")]
        [Validation(Required=false)]
        public List<CreateContainerGroupRequestInitContainer> InitContainer { get; set; }
        public class CreateContainerGroupRequestInitContainer : TeaModel {
            [NameInMap("SecurityContext")]
            [Validation(Required=false)]
            public CreateContainerGroupRequestInitContainerSecurityContext SecurityContext { get; set; }
            public class CreateContainerGroupRequestInitContainerSecurityContext : TeaModel {
                [NameInMap("Capability")]
                [Validation(Required=false)]
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

            }

            /// <summary>
            /// The arguments that are passed to the startup command of the init container.
            /// </summary>
            [NameInMap("Arg")]
            [Validation(Required=false)]
            public List<string> Arg { get; set; }

            /// <summary>
            /// The startup commands of the init container.
            /// </summary>
            [NameInMap("Command")]
            [Validation(Required=false)]
            public List<string> Command { get; set; }

            /// <summary>
            /// The number of vCPUs that you want to allocate to the init container. Unit: cores.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public float? Cpu { get; set; }

            /// <summary>
            /// The environment variable of the init container.
            /// </summary>
            [NameInMap("EnvironmentVar")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestInitContainerEnvironmentVar> EnvironmentVar { get; set; }
            public class CreateContainerGroupRequestInitContainerEnvironmentVar : TeaModel {
                [NameInMap("FieldRef")]
                [Validation(Required=false)]
                public CreateContainerGroupRequestInitContainerEnvironmentVarFieldRef FieldRef { get; set; }
                public class CreateContainerGroupRequestInitContainerEnvironmentVarFieldRef : TeaModel {
                    [NameInMap("FieldPath")]
                    [Validation(Required=false)]
                    public string FieldPath { get; set; }

                }

                /// <summary>
                /// The name of the environment variable. The name must be 1 to 128 characters in length, and can contain letters, digits, and underscores (\_). It cannot start with a digit.``
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of the environment variable. The value can be up to 256 characters in length.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The number of GPUs that you want to allocate to the init container.
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
            /// The policy for image pulling. Valid values:
            /// 
            /// *   Always: Each time instances are created, image pulling is performed.
            /// *   IfNotPresent: On-premises images are preferentially used. If no on-premises images are available, image pulling is performed.
            /// *   Never: On-premises images are always used. Image pulling is not performed.
            /// </summary>
            [NameInMap("ImagePullPolicy")]
            [Validation(Required=false)]
            public string ImagePullPolicy { get; set; }

            /// <summary>
            /// The memory size of the init container. Unit: GiB.
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// The container name.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The port number of the init container.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestInitContainerPort> Port { get; set; }
            public class CreateContainerGroupRequestInitContainerPort : TeaModel {
                /// <summary>
                /// The port number. Valid values: 1 to 65535.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The protocol type. Valid values:
                /// 
                /// *   TCP
                /// *   UDP
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            /// <summary>
            /// The path of the file from which the system retrieves termination messages of the init container when the init container exits.
            /// </summary>
            [NameInMap("TerminationMessagePath")]
            [Validation(Required=false)]
            public string TerminationMessagePath { get; set; }

            /// <summary>
            /// The message notification policy. This parameter is empty by default.
            /// </summary>
            [NameInMap("TerminationMessagePolicy")]
            [Validation(Required=false)]
            public string TerminationMessagePolicy { get; set; }

            /// <summary>
            /// The information about the volume that you want to mount on the init container.
            /// </summary>
            [NameInMap("VolumeMount")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestInitContainerVolumeMount> VolumeMount { get; set; }
            public class CreateContainerGroupRequestInitContainerVolumeMount : TeaModel {
                /// <summary>
                /// The directory to which the volume is mounted. The data stored in this directory is overwritten by the data on the volume. Specify this parameter with caution.
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// The mount propagation settings of the volume. Mount propagation allows volumes that are mounted on one container to be shared with other containers in the same pod, or even with other pods on the same node. Valid values:
                /// 
                /// *   None: The volume mount does not receive subsequent mounts that are mounted to the volume or to the subdirectories of the volume.
                /// *   HostToCotainer: The volume mount receives subsequent mounts that are mounted to the volume or to the subdirectories of the volume.
                /// *   Bidirectional: The volume mount behaves the same as the HostToCotainer mount. The volume mount receives subsequent mounts that are mounted to the volume or to the subdirectories of the volume. In addition, all volume mounts created by the container are propagated back to the host and to all containers of all pods that use the same volume.
                /// 
                /// Default value: None.
                /// </summary>
                [NameInMap("MountPropagation")]
                [Validation(Required=false)]
                public string MountPropagation { get; set; }

                /// <summary>
                /// The volume name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Specifies whether the mount path is read-only. Default value: false.
                /// </summary>
                [NameInMap("ReadOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                /// <summary>
                /// The subdirectory of the volume. The pod can mount different directories of the same volume to different directories of the init container.
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
        /// The address of the self-managed image repository. When you create an elastic container instance by using an image in a self-managed image repository that uses a self-signed certificate, you must specify this parameter to skip the certificate authentication. This prevents image pull failures caused by certificate authentication failures.
        /// </summary>
        [NameInMap("InsecureRegistry")]
        [Validation(Required=false)]
        public string InsecureRegistry { get; set; }

        /// <summary>
        /// The ECS instance type. Different instance types are supported. For more information, see [Specify an ECS instance type to create an elastic container instance](~~114664~~).
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The number of IPv6 addresses. Set the value to 1. You can assign only one IPv6 address to an elastic container instance.
        /// </summary>
        [NameInMap("Ipv6AddressCount")]
        [Validation(Required=false)]
        public int? Ipv6AddressCount { get; set; }

        /// <summary>
        /// The peak Internet bandwidth of the IPv6 address when the Ipv6GatewayBandwidthEnable parameter is set to true. Valid values:
        /// 
        /// *   If the billing method for the Internet bandwidth of the IPv6 gateway is pay-by-bandwidth, the Internet bandwidth of the IPv6 address ranges from 1 to 2,000 Mbit/s.
        /// 
        /// *   If the billing method for the Internet bandwidth of the IPv6 gateway is pay-by-traffic, the Internet bandwidth range of the IPv6 address is based on the edition of the IPv6 gateway.
        /// 
        ///     *   If the IPv6 gateway is of Free Edition, the Internet bandwidth of the IPv6 address ranges from 1 to 200 Mbit/s.
        ///     *   If the IPv6 gateway is of Enterprise Edition, the Internet bandwidth of the IPv6 address ranges from 1 to 500 Mbit/s.
        ///     *   If the IPv6 gateway is of Enhanced Enterprise Edition, the Internet bandwidth of the IPv6 address ranges from 1 to 1,000 Mbit/s.
        /// 
        /// The default value is the maximum value in the Internet bandwidth range of the IPv6 gateway.
        /// </summary>
        [NameInMap("Ipv6GatewayBandwidth")]
        [Validation(Required=false)]
        public string Ipv6GatewayBandwidth { get; set; }

        /// <summary>
        /// Specifies whether to enable IPv6 Internet access for the elastic container instance.
        /// </summary>
        [NameInMap("Ipv6GatewayBandwidthEnable")]
        [Validation(Required=false)]
        public bool? Ipv6GatewayBandwidthEnable { get; set; }

        /// <summary>
        /// The memory size that you want to allocate to the elastic container instance. Unit: GiB.
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        /// <summary>
        /// The domain names of the NTP server.
        /// </summary>
        [NameInMap("NtpServer")]
        [Validation(Required=false)]
        public List<string> NtpServer { get; set; }

        /// <summary>
        /// The operating system of the elastic container instance. Default value: Linux. Valid values:
        /// 
        /// *   Linux
        /// *   Windows
        /// 
        /// >  Windows instances are in invitational preview. To use the operating system, submit a ticket.
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// The options that you can configure when you enable the overhead reservation feature.
        /// </summary>
        [NameInMap("OverheadReservationOption")]
        [Validation(Required=false)]
        public CreateContainerGroupRequestOverheadReservationOption OverheadReservationOption { get; set; }
        public class CreateContainerGroupRequestOverheadReservationOption : TeaModel {
            /// <summary>
            /// Specify whether to enable the overhead reservation feature. Default: false. Valid values: true and false. After you enable the overhead reservation feature, the system automatically adds the overhead to the specification of the elastic container instance, and then adjusts the specification of the instance upward to the most approximate specification. You are charged based on the new specification after the adjustment.
            /// </summary>
            [NameInMap("EnableOverheadReservation")]
            [Validation(Required=false)]
            public bool? EnableOverheadReservation { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The address of the self-managed image repository. When you create an elastic container instance by using an image in a self-managed image repository that uses the HTTP protocol, you must specify this parameter. This allows Elastic Container Instance to pull the image over the HTTP protocol instead over the default HTTPS protocol. This prevents image pull failures caused by different protocols.
        /// </summary>
        [NameInMap("PlainHttpRegistry")]
        [Validation(Required=false)]
        public string PlainHttpRegistry { get; set; }

        /// <summary>
        /// The private IP address of the elastic container instance. Only IPv4 addresses are supported. Make sure that the IP address is idle.
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// The name of the RAM role that you want to associate with the elastic container instance. You can use the RAM role to access elastic container instances and ECS instances. For more information, see [Use an instance RAM role by calling API operations](~~61178~~).
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs.
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
        /// *   Always: Always restarts the instance.
        /// *   Never: Never restarts the instance.
        /// *   OnFailure: Restarts the instance when the last start failed.
        /// 
        /// Default value: Always.
        /// </summary>
        [NameInMap("RestartPolicy")]
        [Validation(Required=false)]
        public string RestartPolicy { get; set; }

        /// <summary>
        /// The resource scheduling policy when you specify multiple zones to create an elastic container instance. To specify multiple zones, you can use the VSwitchId to specify multiple vSwitches. Valid values:
        /// 
        /// *   VSwitchOrdered: The system schedules resources in the sequence of the vSwitches.
        /// *   VSwitchRandom: The system schedules resources at random.
        /// 
        /// For more information, see [Specify multiple zones to create an elastic container instance](~~157290~~).
        /// </summary>
        [NameInMap("ScheduleStrategy")]
        [Validation(Required=false)]
        public string ScheduleStrategy { get; set; }

        /// <summary>
        /// The ID of the security group to which the instance is assigned. Instances within the same security group can access each other.
        /// 
        /// If you do not specify a security group, the system automatically uses the default security group in the region that you selected. Make sure that the inbound rules of the security group contain the container protocols and port numbers that you want to expose. If you do not have a default security group in the region, the system creates a default security group, and then adds the container protocols and port numbers that you specified to the inbound rules of the security group.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// Specifies whether to use a shared namespace. Default value: false.
        /// </summary>
        [NameInMap("ShareProcessNamespace")]
        [Validation(Required=false)]
        public bool? ShareProcessNamespace { get; set; }

        /// <summary>
        /// The protection period of the preemptible instance. Unit: hours. Default value: 1. A value of 0 indicates no protection period.
        /// </summary>
        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public long? SpotDuration { get; set; }

        /// <summary>
        /// The maximum hourly price of the preemptible elastic container instance. The value can contain up to three decimal places.
        /// 
        /// If you set SpotStrategy to SpotWithPriceLimit, you must specify SpotPriceLimit.
        /// </summary>
        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public float? SpotPriceLimit { get; set; }

        /// <summary>
        /// The bidding policy for the instance. Valid values:
        /// 
        /// *   NoSpot: The instance is created as a regular pay-as-you-go instance.
        /// *   SpotWithPriceLimit: The instance is created as a preemptible instance with a user-defined maximum hourly price.
        /// *   SpotAsPriceGo: The instance is created as a preemptible instance whose bidding price is based on the market price at the time of purchase.
        /// 
        /// Default value: NoSpot.
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// Specifies whether to enable periodical execution.
        /// 
        /// *   true: enables periodical execution.
        /// *   false: disables periodical execution.
        /// </summary>
        [NameInMap("StrictSpot")]
        [Validation(Required=false)]
        public bool? StrictSpot { get; set; }

        /// <summary>
        /// The tags that you want to bind with the instance. You can bind a maximum of 20 tags. For more information, see [Use tags to manage elastic container instances](~~146608~~).
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateContainerGroupRequestTag> Tag { get; set; }
        public class CreateContainerGroupRequestTag : TeaModel {
            /// <summary>
            /// The key of a tag. The tag key cannot be an empty string and must be unique. The tag key can be up to 64 characters in length and cannot contain `http://` or `https://`. The tag key cannot start with `acs:` or `aliyun`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of a tag. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot contain `http://` or `https://`. The tag value cannot start with `acs:`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The buffer time during which the program handles operations before the program stops. Unit: seconds.
        /// </summary>
        [NameInMap("TerminationGracePeriodSeconds")]
        [Validation(Required=false)]
        public long? TerminationGracePeriodSeconds { get; set; }

        /// <summary>
        /// The ID of the vSwitch to which the instance is connected. You can specify up to 10 vSwitch IDs. Separate multiple vSwitch IDs with commas (,). Example: `vsw-***,vsw-***`.
        /// 
        /// If no vSwitch is specified, the system automatically uses the default vSwitch in the default VPC in the region that you selected. If you do not have a default VPC or a default vSwitch in the region, the system automatically creates a default VPC and a default vSwitch.
        /// 
        /// > The number of IP addresses in the vSwitch CIDR block determines the maximum number of elastic container instances that can be created for the vSwitch. Before you create elastic container instances, plan the CIDR block of the vSwitch.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// Information about volumes.
        /// </summary>
        [NameInMap("Volume")]
        [Validation(Required=false)]
        public List<CreateContainerGroupRequestVolume> Volume { get; set; }
        public class CreateContainerGroupRequestVolume : TeaModel {
            [NameInMap("ConfigFileVolume")]
            [Validation(Required=false)]
            public CreateContainerGroupRequestVolumeConfigFileVolume ConfigFileVolume { get; set; }
            public class CreateContainerGroupRequestVolumeConfigFileVolume : TeaModel {
                [NameInMap("ConfigFileToPath")]
                [Validation(Required=false)]
                public List<CreateContainerGroupRequestVolumeConfigFileVolumeConfigFileToPath> ConfigFileToPath { get; set; }
                public class CreateContainerGroupRequestVolumeConfigFileVolumeConfigFileToPath : TeaModel {
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("Mode")]
                    [Validation(Required=false)]
                    public int? Mode { get; set; }

                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                }

                [NameInMap("DefaultMode")]
                [Validation(Required=false)]
                public int? DefaultMode { get; set; }

            }

            [NameInMap("DiskVolume")]
            [Validation(Required=false)]
            public CreateContainerGroupRequestVolumeDiskVolume DiskVolume { get; set; }
            public class CreateContainerGroupRequestVolumeDiskVolume : TeaModel {
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
            public CreateContainerGroupRequestVolumeEmptyDirVolume EmptyDirVolume { get; set; }
            public class CreateContainerGroupRequestVolumeEmptyDirVolume : TeaModel {
                [NameInMap("Medium")]
                [Validation(Required=false)]
                public string Medium { get; set; }

                [NameInMap("SizeLimit")]
                [Validation(Required=false)]
                public string SizeLimit { get; set; }

            }

            [NameInMap("FlexVolume")]
            [Validation(Required=false)]
            public CreateContainerGroupRequestVolumeFlexVolume FlexVolume { get; set; }
            public class CreateContainerGroupRequestVolumeFlexVolume : TeaModel {
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
            public CreateContainerGroupRequestVolumeHostPathVolume HostPathVolume { get; set; }
            public class CreateContainerGroupRequestVolumeHostPathVolume : TeaModel {
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("NFSVolume")]
            [Validation(Required=false)]
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

            }

            /// <summary>
            /// The name of the volume.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The type of the volume when you set the Type parameter to HostPathVolume. Valid values:
            /// 
            /// *   Directory
            /// *   File
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The ID of the zone in which the elastic container instance is deployed. If you do not specify this parameter, the system selects a zone.
        /// 
        /// This parameter is empty by default.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
