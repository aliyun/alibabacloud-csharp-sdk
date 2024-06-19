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
            /// The IP addresses of DNS servers.
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
            /// The search domains of DNS servers.
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
            /// Configure a security context to modify unsafe sysctls. For more information, see [Configure a security context](https://help.aliyun.com/document_detail/462313.html).
            /// </summary>
            [NameInMap("Sysctl")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestHostSecurityContextSysctl> Sysctl { get; set; }
            public class CreateContainerGroupRequestHostSecurityContextSysctl : TeaModel {
                /// <summary>
                /// The name of the unsafe sysctl when you modify sysctls by configuring a security context. Valid values:
                /// 
                /// *   kernel.shm \\* (except kernel.shm_rmid_forced)
                /// *   kernel.msg\\*
                /// *   kernel.sem
                /// *   fs.mqueue.\\*
                /// *   net.\\*(except net.ipv4.tcp_syncookies, net.ipv4.ping_group_range, and net.ipv4.ip_unprivileged_port_start)
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
            /// Configure a security context to modify safe sysctls. For more information, see [Configure a security context](https://help.aliyun.com/document_detail/462313.html).
            /// </summary>
            [NameInMap("Sysctl")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestSecurityContextSysctl> Sysctl { get; set; }
            public class CreateContainerGroupRequestSecurityContextSysctl : TeaModel {
                /// <summary>
                /// The name of the safe sysctl when you modify sysctls by configuring a security context. Valid values:
                /// 
                /// *   net.ipv4.ping_group_range
                /// *   net.ipv4.ip_unprivileged_port_start
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The value of the safe sysctl when you modify sysctls by configuring a security context.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The information about the Container Registry Enterprise Edition instance that provides the image for the creation of the elastic container instance. For more information, see [Pull images from a Container Registry Enterprise Edition instance without using a secret](https://help.aliyun.com/document_detail/194250.html).
        /// </summary>
        [NameInMap("AcrRegistryInfo")]
        [Validation(Required=false)]
        public List<CreateContainerGroupRequestAcrRegistryInfo> AcrRegistryInfo { get; set; }
        public class CreateContainerGroupRequestAcrRegistryInfo : TeaModel {
            /// <summary>
            /// The Alibaba Cloud Resource Name (ARN) of the RAM role in the Alibaba Cloud account to which the elastic container instance belongs.
            /// </summary>
            [NameInMap("ArnService")]
            [Validation(Required=false)]
            public string ArnService { get; set; }

            /// <summary>
            /// The ARN of the RAM role in the Alibaba Cloud account to which the Container Registry Enterprise Edition instance belongs.
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
        /// The active period of the elastic container instance. After this period expires, the instance is forced to exit. Unit: seconds.
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
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotency](https://help.aliyun.com/document_detail/25693.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The computing power type of the instance. For more information, see [Set the computing power type to economy when you create an elastic container instance](https://help.aliyun.com/document_detail/2638061.html).
        /// </summary>
        [NameInMap("ComputeCategory")]
        [Validation(Required=false)]
        public List<string> ComputeCategory { get; set; }

        /// <summary>
        /// The information about the container.
        /// 
        /// This parameter is required.
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
            /// The commands to be executed in containers when you use a CLI to perform health checks.
            /// 
            /// >  When you configure ReadinessProbe-related parameters, you can select only one of the HttpGet, Exec, and TcpSocket check methods.
            /// </summary>
            [NameInMap("Command")]
            [Validation(Required=false)]
            public List<string> Command { get; set; }

            /// <summary>
            /// The number of vCPUs that are allocated to the container.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public float? Cpu { get; set; }

            /// <summary>
            /// The environment variables of the container.
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
                /// The name of the environment variable. The name must be 1 to 128 bits in length and can contain letters, digits, and underscores (_). It cannot start with a digit.``
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
            /// Specifies whether to hide the information about environment variables when you query the details of an elastic container instance. Valid values:
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
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// The policy that you want to use to pull images. Valid values:
            /// 
            /// *   Always: Each time instances are created, image pulling is performed.
            /// *   IfNotPresent: On-premises images are preferentially used. If no on-premises images are available, image pulling is performed.
            /// *   Never: On-premises images are always used. Image pulling is not performed.
            /// </summary>
            [NameInMap("ImagePullPolicy")]
            [Validation(Required=false)]
            public string ImagePullPolicy { get; set; }

            /// <summary>
            /// The commands to be executed in containers when you use a CLI to specify a postStart hook.
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerExec")]
            [Validation(Required=false)]
            public List<string> LifecyclePostStartHandlerExec { get; set; }

            /// <summary>
            /// The IP address of the host that receives the HTTP GET request when you use an HTTP request to specify a postStart hook.
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
                /// The name of the custom field in the HTTP GET request header when you use HTTP requests to specify a postStart hook.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The value of the custom field in the HTTP GET request header when you use HTTP requests to specify a postStart hook.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The path to which the system sends an HTTP GET request for a health check when you use an HTTP request to specify a postStart hook.
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerHttpGetPath")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerHttpGetPath { get; set; }

            /// <summary>
            /// The port to which the system sends an HTTP GET request when you use an HTTP request to specify a postStart hook.
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerHttpGetPort")]
            [Validation(Required=false)]
            public int? LifecyclePostStartHandlerHttpGetPort { get; set; }

            /// <summary>
            /// The protocol type of HTTP GET requests when you use HTTP requests to specify a postStart hook. Valid values:
            /// 
            /// *   HTTP
            /// *   HTTPS
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerHttpGetScheme")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerHttpGetScheme { get; set; }

            /// <summary>
            /// The IP address of the host that receives the TCP socket request when you use a TCP socket request to specify a postStart hook.
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerTcpSocketHost")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerTcpSocketHost { get; set; }

            /// <summary>
            /// The port to which the system sends a TCP socket request for a health check when you use TCP sockets to specify a postStart hook.
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerTcpSocketPort")]
            [Validation(Required=false)]
            public int? LifecyclePostStartHandlerTcpSocketPort { get; set; }

            /// <summary>
            /// The commands to be executed in containers when you use a CLI to specify a preStop hook.
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerExec")]
            [Validation(Required=false)]
            public List<string> LifecyclePreStopHandlerExec { get; set; }

            /// <summary>
            /// The IP address of the host that receives the HTTP GET request when you use an HTTP request to specify a preStop hook.
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
                /// The name of the custom field in the HTTP GET request header when you use HTTP requests to specify a presto hook.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The value of the custom field in the HTTP GET request header when you use HTTP requests to specify a preStop hook.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The path to which the system sends an HTTP GET request for a health check when you use an HTTP request to specify a preSop hook.
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerHttpGetPath")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerHttpGetPath { get; set; }

            /// <summary>
            /// The port to which the system sends an HTTP GET request for a health check when you use HTTP requests to specify a preStop hook.
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerHttpGetPort")]
            [Validation(Required=false)]
            public int? LifecyclePreStopHandlerHttpGetPort { get; set; }

            /// <summary>
            /// The protocol type of the HTTP GET request when you use an HTTP request to specify a preStop hook. Valid values:
            /// 
            /// *   HTTP
            /// *   HTTPS
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerHttpGetScheme")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerHttpGetScheme { get; set; }

            /// <summary>
            /// The IP address of the host that receives the TCP socket request when you use a TCP socket request to specify a preStop hook.
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerTcpSocketHost")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerTcpSocketHost { get; set; }

            /// <summary>
            /// The port to which the system sends a TCP socket request for a health check when you use TCP sockets to specify a preStop hook.
            /// </summary>
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
            /// The name of the container.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The port to which the system sends an HTTP GET request for a health check when you use HTTP requests to perform health checks.
            /// 
            /// >  When you configure LivenessProbe-related parameters, you can select only one of the HttpGet, Exec, and TcpSocket check methods.
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
                /// The type of the protocol. Valid values:
                /// 
                /// *   TCP
                /// *   UDP
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            [NameInMap("SecurityContextPrivileged")]
            [Validation(Required=false)]
            public bool? SecurityContextPrivileged { get; set; }

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
            /// Specifies whether standard input streams are disconnected from multiple sessions after a client is disconnected.\\
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
            /// The information about the volume that you want to mount on the container.
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
                /// The name of the volume. The value of this parameter is the same as the value of Volume.N.Name.
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
        /// The name of the elastic container instance (container group). The name must meet the following requirements:
        /// 
        /// *   The name must be 2 to 128 characters in length.
        /// *   The name can contain lowercase letters, digits, and hyphens (-). It cannot start or end with a hyphen (-).
        /// 
        /// This parameter is required.
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
        /// The path to core dump files. For more information, see [Save core files to volumes](https://help.aliyun.com/document_detail/167801.html).
        /// 
        /// >  The path cannot start with |. You cannot use core dump files to configure executable programs.``
        /// </summary>
        [NameInMap("CorePattern")]
        [Validation(Required=false)]
        public string CorePattern { get; set; }

        /// <summary>
        /// The number of vCPUs that you want to allocate to the instance.
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
        /// The number of physical CPU cores. You can specify this parameter for only specific ECS instance types.
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
        /// The number of threads per core. You can specify this parameter for only specific ECS instance types. A value of 1 specifies that Hyper-Threading is disabled.
        /// </summary>
        [NameInMap("CpuOptionsThreadsPerCore")]
        [Validation(Required=false)]
        public int? CpuOptionsThreadsPerCore { get; set; }

        /// <summary>
        /// The bucket that stores the data cache.
        /// </summary>
        [NameInMap("DataCacheBucket")]
        [Validation(Required=false)]
        public string DataCacheBucket { get; set; }

        /// <summary>
        /// Specifies whether to enable the performance burst feature when ESSDs AutoPL are used to store data caches. For more information, see [ESSDs AutoPL](https://help.aliyun.com/document_detail/368372.html).
        /// </summary>
        [NameInMap("DataCacheBurstingEnabled")]
        [Validation(Required=false)]
        public bool? DataCacheBurstingEnabled { get; set; }

        /// <summary>
        /// The performance level (PL) of the disk that you want to use to store data caches.\\
        /// Enhanced SSDs (ESSDs) are preferentially used to store data caches. The default performance level is PL1.
        /// </summary>
        [NameInMap("DataCachePL")]
        [Validation(Required=false)]
        public string DataCachePL { get; set; }

        /// <summary>
        /// The input/output operations per second (IOPS) provisioned for ESSDs AutoPL when ESSDs AutoPL are used to store data caches.\\
        /// Valid values: 0 to min{50000, 1000 × Storage capacity - Baseline IOPS}. Baseline IOPS = min{1,800 + 50 × Storage capacity, 50,000}.\\
        /// For more information, see [ESSDs AutoPL](https://help.aliyun.com/document_detail/368372.html).
        /// </summary>
        [NameInMap("DataCacheProvisionedIops")]
        [Validation(Required=false)]
        public long? DataCacheProvisionedIops { get; set; }

        /// <summary>
        /// The Domain Name System (DNS) policy. Valid values:
        /// 
        /// *   None: uses the DNS that is specified by DnsConfig.
        /// *   Default: uses the DNS that is specified for the runtime environment.
        /// </summary>
        [NameInMap("DnsPolicy")]
        [Validation(Required=false)]
        public string DnsPolicy { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid values:
        /// 
        /// *   true: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, service limits, and available resources. If the request passes the dry run, the DryRunOperation error code is returned. Otherwise, an error message is returned.
        /// *   false (default): performs a dry run and performs the actual request. If the request passes the dry run, the elastic container instance is created.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The maximum outbound bandwidth. Unit: bit/s.
        /// </summary>
        [NameInMap("EgressBandwidth")]
        [Validation(Required=false)]
        public long? EgressBandwidth { get; set; }

        /// <summary>
        /// The maximum bandwidth value for the EIP. Unit: Mbit/s. Default value: 5.\\
        /// This parameter is valid only when AutoCreateEip is set to true.
        /// </summary>
        [NameInMap("EipBandwidth")]
        [Validation(Required=false)]
        public int? EipBandwidth { get; set; }

        /// <summary>
        /// The EIP bandwidth plan that you want to associate with the instance.
        /// </summary>
        [NameInMap("EipCommonBandwidthPackage")]
        [Validation(Required=false)]
        public string EipCommonBandwidthPackage { get; set; }

        /// <summary>
        /// The line type of the EIP. Default value: BGP. Valid values:
        /// 
        /// *   BGP: BGP (Multi-ISP) line
        /// *   BGP_PRO: BGP (Multi-ISP) Pro line
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
        /// The increased capacity of the temporary storage space. Unit: GiB.\\
        /// For more information, see [Increase the size of the temporary storage space](https://help.aliyun.com/document_detail/204066.html).
        /// </summary>
        [NameInMap("EphemeralStorage")]
        [Validation(Required=false)]
        public int? EphemeralStorage { get; set; }

        /// <summary>
        /// Specifies whether to configure the instance to use a fixed IP address. For more information, see [Configure an elastic container instance to use a fixed IP address](https://help.aliyun.com/document_detail/2381086.html).
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

        /// <summary>
        /// The version of the GPU driver. Default value: tesla=470.82.01. Valid values:
        /// 
        /// *   tesla=470.82.01
        /// *   tesla=525.85.12
        /// 
        /// >  You can switch the GPU driver version only for a few Elastic Compute Service (ECS) instance types. For more information, see [Specify GPU-accelerated ECS instance types to create an elastic container instance](https://help.aliyun.com/document_detail/2579486.html).
        /// </summary>
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
            /// The hostnames of the elastic container instance.
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public List<string> Hostname { get; set; }

            /// <summary>
            /// The IP address of the elastic container instance.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

        }

        /// <summary>
        /// The hostname.
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// The image acceleration mode. Valid values:
        /// 
        /// *   nydus: uses Nydus to accelerate image pulling. The images must support Nydus.
        /// *   dadi: uses DADI to accelerate image pulling. The images must support DADI.
        /// *   p2p: uses P2P to accelerate image pulling. The images must support p2p.
        /// *   imc: uses image caches to accelerate image pulling.
        /// </summary>
        [NameInMap("ImageAccelerateMode")]
        [Validation(Required=false)]
        public string ImageAccelerateMode { get; set; }

        /// <summary>
        /// The information about the logon credentials.
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
        /// The ID of the image cache. For more information, see [Use image caches to accelerate the creation of instances](https://help.aliyun.com/document_detail/141281.html).
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
                /// The name of the environment variable. The name must be 1 to 128 bits in length and can contain letters, digits, and underscores (_). It cannot start with a digit.``
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
            /// The policy that you want to use to pull images. Valid values:
            /// 
            /// *   Always: Each time instances are created, image pulling is performed.
            /// *   IfNotPresent: On-premises images are preferentially used. If no on-premises images are available, image pulling is performed.
            /// *   Never: On-premises images are always used. Image pulling is not performed.
            /// </summary>
            [NameInMap("ImagePullPolicy")]
            [Validation(Required=false)]
            public string ImagePullPolicy { get; set; }

            /// <summary>
            /// The memory size that you want to allocate to the init container. Unit: GiB.
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
            /// The information about the port.
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
            /// The information about the volumes that you want to mount to the init containers.
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
                /// The mount propagation settings of the volume. Mount propagation allows volumes that are mounted on one init container to be shared with other init containers in the same pod, or even with other pods on the same node. Valid values:
                /// 
                /// *   None: The volume mount does not receive subsequent mounts that are performed on this volume or subdirectories of this volume.
                /// *   HostToCotainer: The volume mount receives subsequent mounts that are performed on this volume or the subdirectories of this volume.
                /// *   Bidirectional: This value is similar to HostToContainer. The volume mount receives subsequent mounts that are performed on this volume or the subdirectories of this volume. In addition, all volume mounts that are mounted on the init container are propagated back to the host and all init containers of all pods that use the same volume.
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
                /// Specifies whether the mount path is read-only. Default value: false.
                /// </summary>
                [NameInMap("ReadOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                /// <summary>
                /// The subdirectory of the volume. The pod can mount different directories of the same volume to different subdirectories of init containers.
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
        /// The ECS instance types that you specify to create the elastic container instance. Multiple instance types are supported. For more information, see [Specify ECS instance types to create an elastic container instance](https://help.aliyun.com/document_detail/114664.html).
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The number of IPv6 addresses that are assigned to the instance. Set the value to 1. You can assign only one IPv6 address to an elastic container instance.
        /// </summary>
        [NameInMap("Ipv6AddressCount")]
        [Validation(Required=false)]
        public int? Ipv6AddressCount { get; set; }

        /// <summary>
        /// The maximum IPv6 Internet bandwidth when you set Ipv6GatewayBandwidthEnable to true. Valid values:
        /// 
        /// *   If the billing method for IPv6 network usage is pay-by-bandwidth, the maximum IPv6 Internet bandwidth ranges from 1 to 2,000 Mbit/s.
        /// 
        /// *   If the billing method for IPv6 network usage is pay-by-traffic, the maximum IPv6 Internet bandwidth varies based on the edition of the IPv6 gateway.
        /// 
        ///     *   If the IPv6 gateway is of Free Edition, the maximum IPv6 Internet bandwidth ranges from 1 to 200 Mbit/s.
        ///     *   If the IPv6 gateway is of Enterprise Edition, the maximum IPv6 Internet bandwidth ranges from 1 to 500 Mbit/s.
        ///     *   If the IPv6 gateway is of Enhanced Enterprise Edition, the maximum IPv6 Internet bandwidth ranges from 1 to 1000 Mbit/s.
        /// 
        /// The default value is the maximum value in the Internet bandwidth range of the IPv6 gateway.
        /// </summary>
        [NameInMap("Ipv6GatewayBandwidth")]
        [Validation(Required=false)]
        public string Ipv6GatewayBandwidth { get; set; }

        /// <summary>
        /// Specifies whether to enable Internet access to the elastic container instance over IPv6 addresses.
        /// </summary>
        [NameInMap("Ipv6GatewayBandwidthEnable")]
        [Validation(Required=false)]
        public bool? Ipv6GatewayBandwidthEnable { get; set; }

        /// <summary>
        /// The memory size that you want to allocate to the instance. Unit: GiB.
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        /// <summary>
        /// The endpoints of the Network Time Protocol (NTP) servers.
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
        /// The address of the self-managed image repository. When you create an elastic container instance by using an image in a self-managed image repository that uses the HTTP protocol, you must specify this parameter. This way, Elastic Container Instance pulls the image over the HTTP protocol instead of the default HTTPS protocol. This prevents image pull failures caused by different protocols.
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
        /// The name of the instance Resource Access Management (RAM) role. You can use the same RAM role to access elastic container instances and ECS instances. For more information, see [Use an instance RAM role by calling API operations](https://help.aliyun.com/document_detail/61178.html).
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// 
        /// This parameter is required.
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
        /// The restart policy of the instance. Valid values:
        /// 
        /// *   Always: Always restarts the instance if a container in the instance exits upon termination.
        /// *   Never: Never restarts the instance if a container in the instance exits upon termination.
        /// *   OnFailure: Restarts the instance only if a container in the instance exists upon failure with a status code of non-zero.
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
        /// For more information, see [Specify multiple zones to create an elastic container instance](https://help.aliyun.com/document_detail/157290.html).
        /// </summary>
        [NameInMap("ScheduleStrategy")]
        [Validation(Required=false)]
        public string ScheduleStrategy { get; set; }

        /// <summary>
        /// The ID of the security group to which the instance belongs. Instances in the same security group can access each other.
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
        /// The protection period of the preemptible elastic container instance. Unit: hours. Default value: 1. A value of 0 indicates no protection period.
        /// </summary>
        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public long? SpotDuration { get; set; }

        /// <summary>
        /// The maximum hourly price of the preemptible elastic container instance. The value can be accurate to three decimal places.
        /// 
        /// If you set SpotStrategy to SpotWithPriceLimit, you must specify the SpotPriceLimit parameter.
        /// </summary>
        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public float? SpotPriceLimit { get; set; }

        /// <summary>
        /// The bid policy for the instance. Valid values:
        /// 
        /// *   NoSpot: The instance is created as a pay-as-you-go instance.
        /// *   SpotWithPriceLimit: The instance is created as a preemptible instance for which you specify the maximum hourly price.
        /// *   SpotAsPriceGo: The instance is created as a preemptible instance for which the market price at the time of purchase is automatically used as the bid price.
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
        /// The tags that you want to add to the instance. You can bind a maximum of 20 tags. For more information, see [Use tags to manage elastic container instances](https://help.aliyun.com/document_detail/146608.html).
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateContainerGroupRequestTag> Tag { get; set; }
        public class CreateContainerGroupRequestTag : TeaModel {
            /// <summary>
            /// The tag key. The tag key cannot be an empty string and must be unique. The tag key can be up to 64 characters in length and cannot contain `http://` or `https://`. The tag key cannot start with `acs:` or `aliyun`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value. The tag value can be an empty string. The tag value can be up to 128 characters in length. It cannot start with `acs:` and cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The buffer period of time during which the program handles operations before the program is stopped. Unit: seconds.
        /// </summary>
        [NameInMap("TerminationGracePeriodSeconds")]
        [Validation(Required=false)]
        public long? TerminationGracePeriodSeconds { get; set; }

        /// <summary>
        /// The IDs of the vSwitches that connect to the instance. You can specify up to 10 vSwitch IDs at a time. Separate multiple vSwitch IDs with commas (,). Example: `vsw-***,vsw-***`.
        /// 
        /// If you do not specify a vSwitch, the system automatically uses the default vSwitch in the default VPC in the region that you selected. If you do not have a default VPC or a default vSwitch in the region, the system automatically creates a default VPC and a default vSwitch.
        /// 
        /// >  The number of IP addresses in the vSwitch CIDR block determines the maximum number of elastic container instances that you can create for the vSwitch. Before you create elastic container instances, you must plan the CIDR block of the vSwitch.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The information about the volume that you want to mount to the container.
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
            /// The type of the HostPath volume. Valid values:
            /// 
            /// *   Directory
            /// *   File
            /// 
            /// >  Only users in the whitelist can mount HostPath volumes.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The zone ID of the instance. If you do not specify this parameter, the system selects a zone.
        /// 
        /// This parameter is empty by default.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
