// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeContainerGroupsResponseBody : TeaModel {
        /// <summary>
        /// Details about the queried elastic container instances.
        /// </summary>
        [NameInMap("ContainerGroups")]
        [Validation(Required=false)]
        public List<DescribeContainerGroupsResponseBodyContainerGroups> ContainerGroups { get; set; }
        public class DescribeContainerGroupsResponseBodyContainerGroups : TeaModel {
            /// <summary>
            /// The computing power type of the elastic container instance. Valid values:
            /// 
            /// *   economy: economic computing power.
            /// *   general: general-purpose computing power.
            /// </summary>
            [NameInMap("ComputeCategory")]
            [Validation(Required=false)]
            public string ComputeCategory { get; set; }

            /// <summary>
            /// The instance ID.
            /// </summary>
            [NameInMap("ContainerGroupId")]
            [Validation(Required=false)]
            public string ContainerGroupId { get; set; }

            /// <summary>
            /// The instance name.
            /// </summary>
            [NameInMap("ContainerGroupName")]
            [Validation(Required=false)]
            public string ContainerGroupName { get; set; }

            /// <summary>
            /// The information about containers in the elastic container instance.
            /// </summary>
            [NameInMap("Containers")]
            [Validation(Required=false)]
            public List<DescribeContainerGroupsResponseBodyContainerGroupsContainers> Containers { get; set; }
            public class DescribeContainerGroupsResponseBodyContainerGroupsContainers : TeaModel {
                /// <summary>
                /// The arguments that are passed to the startup commands of the container.
                /// </summary>
                [NameInMap("Args")]
                [Validation(Required=false)]
                public List<string> Args { get; set; }

                /// <summary>
                /// The startup commands of the container.
                /// </summary>
                [NameInMap("Commands")]
                [Validation(Required=false)]
                public List<string> Commands { get; set; }

                /// <summary>
                /// The number of vCPUs that are allocated to the container.
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                /// <summary>
                /// The current container status.
                /// </summary>
                [NameInMap("CurrentState")]
                [Validation(Required=false)]
                public DescribeContainerGroupsResponseBodyContainerGroupsContainersCurrentState CurrentState { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsContainersCurrentState : TeaModel {
                    /// <summary>
                    /// The details of the container status.
                    /// </summary>
                    [NameInMap("DetailStatus")]
                    [Validation(Required=false)]
                    public string DetailStatus { get; set; }

                    /// <summary>
                    /// The exit code of the container.
                    /// </summary>
                    [NameInMap("ExitCode")]
                    [Validation(Required=false)]
                    public int? ExitCode { get; set; }

                    /// <summary>
                    /// The time when the container stopped running.
                    /// </summary>
                    [NameInMap("FinishTime")]
                    [Validation(Required=false)]
                    public string FinishTime { get; set; }

                    /// <summary>
                    /// The message about the container status.
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// The reason why the container is in this status.
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    /// <summary>
                    /// The code of the container status.
                    /// </summary>
                    [NameInMap("Signal")]
                    [Validation(Required=false)]
                    public int? Signal { get; set; }

                    /// <summary>
                    /// The time when the container started to run.
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// The container status. Valid values:
                    /// 
                    /// *   Waiting
                    /// *   Running
                    /// *   Terminated
                    /// </summary>
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                }

                /// <summary>
                /// The environment variables of the container.
                /// </summary>
                [NameInMap("EnvironmentVars")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupsResponseBodyContainerGroupsContainersEnvironmentVars> EnvironmentVars { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsContainersEnvironmentVars : TeaModel {
                    /// <summary>
                    /// The name of the environment variable.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The value of the environment variable.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    /// <summary>
                    /// The source of the environment variable value. This parameter has a value only when the Value parameter is left empty.
                    /// </summary>
                    [NameInMap("ValueFrom")]
                    [Validation(Required=false)]
                    public DescribeContainerGroupsResponseBodyContainerGroupsContainersEnvironmentVarsValueFrom ValueFrom { get; set; }
                    public class DescribeContainerGroupsResponseBodyContainerGroupsContainersEnvironmentVarsValueFrom : TeaModel {
                        /// <summary>
                        /// The specified field.
                        /// </summary>
                        [NameInMap("FieldRef")]
                        [Validation(Required=false)]
                        public DescribeContainerGroupsResponseBodyContainerGroupsContainersEnvironmentVarsValueFromFieldRef FieldRef { get; set; }
                        public class DescribeContainerGroupsResponseBodyContainerGroupsContainersEnvironmentVarsValueFromFieldRef : TeaModel {
                            /// <summary>
                            /// The path of the field.
                            /// </summary>
                            [NameInMap("FieldPath")]
                            [Validation(Required=false)]
                            public string FieldPath { get; set; }

                        }

                    }

                }

                /// <summary>
                /// The number of GPUs.
                /// </summary>
                [NameInMap("Gpu")]
                [Validation(Required=false)]
                public int? Gpu { get; set; }

                /// <summary>
                /// The image in the container.
                /// </summary>
                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// The image pulling policy. Valid values:
                /// 
                /// *   Always: Each time the instance is updated, image pulling is performed.
                /// *   IfNotPresent: On-premises images are preferentially used. If no on-premises images are available, image pulling is performed.
                /// *   Never: On-premises images are always used. Image pulling is not performed.
                /// </summary>
                [NameInMap("ImagePullPolicy")]
                [Validation(Required=false)]
                public string ImagePullPolicy { get; set; }

                /// <summary>
                /// The liveness probe of the container.
                /// </summary>
                [NameInMap("LivenessProbe")]
                [Validation(Required=false)]
                public DescribeContainerGroupsResponseBodyContainerGroupsContainersLivenessProbe LivenessProbe { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsContainersLivenessProbe : TeaModel {
                    /// <summary>
                    /// The commands that are used to check the containers.
                    /// </summary>
                    [NameInMap("Execs")]
                    [Validation(Required=false)]
                    public List<string> Execs { get; set; }

                    /// <summary>
                    /// The minimum number of consecutive failures that must occur for the check to be considered failed. Default value: 3.
                    /// </summary>
                    [NameInMap("FailureThreshold")]
                    [Validation(Required=false)]
                    public int? FailureThreshold { get; set; }

                    /// <summary>
                    /// The HTTP GET method that is used to check the container.
                    /// </summary>
                    [NameInMap("HttpGet")]
                    [Validation(Required=false)]
                    public DescribeContainerGroupsResponseBodyContainerGroupsContainersLivenessProbeHttpGet HttpGet { get; set; }
                    public class DescribeContainerGroupsResponseBodyContainerGroupsContainersLivenessProbeHttpGet : TeaModel {
                        /// <summary>
                        /// The path to which the system sends an HTTP GET request for a health check.
                        /// </summary>
                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                        /// <summary>
                        /// The port to which the system sends an HTTP GET request for a health check.
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        /// <summary>
                        /// The protocol type supported by the method. Valid values: HTTP and HTTPS.
                        /// </summary>
                        [NameInMap("Scheme")]
                        [Validation(Required=false)]
                        public string Scheme { get; set; }

                    }

                    /// <summary>
                    /// The number of seconds between the time when the startup of the container ends and the time when the probe starts.
                    /// </summary>
                    [NameInMap("InitialDelaySeconds")]
                    [Validation(Required=false)]
                    public int? InitialDelaySeconds { get; set; }

                    /// <summary>
                    /// The interval at which the health check is performed. Default value: 10. Minimum value: 1. Unit: seconds.
                    /// </summary>
                    [NameInMap("PeriodSeconds")]
                    [Validation(Required=false)]
                    public int? PeriodSeconds { get; set; }

                    /// <summary>
                    /// The minimum number of consecutive successes that must occur for the check to be considered successful. Default value: 1. The value must be 1.
                    /// </summary>
                    [NameInMap("SuccessThreshold")]
                    [Validation(Required=false)]
                    public int? SuccessThreshold { get; set; }

                    /// <summary>
                    /// The TCP socket method that is used to check the container.
                    /// </summary>
                    [NameInMap("TcpSocket")]
                    [Validation(Required=false)]
                    public DescribeContainerGroupsResponseBodyContainerGroupsContainersLivenessProbeTcpSocket TcpSocket { get; set; }
                    public class DescribeContainerGroupsResponseBodyContainerGroupsContainersLivenessProbeTcpSocket : TeaModel {
                        /// <summary>
                        /// The hostname.
                        /// </summary>
                        [NameInMap("Host")]
                        [Validation(Required=false)]
                        public string Host { get; set; }

                        /// <summary>
                        /// The port number.
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                    }

                    /// <summary>
                    /// The timeout period of the check. Default value: 1. Minimum value: 1. Unit: seconds.
                    /// </summary>
                    [NameInMap("TimeoutSeconds")]
                    [Validation(Required=false)]
                    public int? TimeoutSeconds { get; set; }

                }

                /// <summary>
                /// The memory size of the container. Unit: GiB.
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
                /// The exposed port and protocol of the container.
                /// </summary>
                [NameInMap("Ports")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupsResponseBodyContainerGroupsContainersPorts> Ports { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsContainersPorts : TeaModel {
                    /// <summary>
                    /// The port number. Valid values: 1 to 65535.
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// The protocol type.
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                }

                /// <summary>
                /// The previous state of the container.
                /// </summary>
                [NameInMap("PreviousState")]
                [Validation(Required=false)]
                public DescribeContainerGroupsResponseBodyContainerGroupsContainersPreviousState PreviousState { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsContainersPreviousState : TeaModel {
                    /// <summary>
                    /// The details of the container status.
                    /// </summary>
                    [NameInMap("DetailStatus")]
                    [Validation(Required=false)]
                    public string DetailStatus { get; set; }

                    /// <summary>
                    /// The exit code of the container.
                    /// </summary>
                    [NameInMap("ExitCode")]
                    [Validation(Required=false)]
                    public int? ExitCode { get; set; }

                    /// <summary>
                    /// The time when the container stopped running.
                    /// </summary>
                    [NameInMap("FinishTime")]
                    [Validation(Required=false)]
                    public string FinishTime { get; set; }

                    /// <summary>
                    /// The message about the container status.
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// The reason why the container is in this status.
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    /// <summary>
                    /// The code of the container status.
                    /// </summary>
                    [NameInMap("Signal")]
                    [Validation(Required=false)]
                    public int? Signal { get; set; }

                    /// <summary>
                    /// The time when the container started to run.
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// The container status. Valid values:
                    /// 
                    /// *   Waiting: The container is being started.
                    /// *   Running: The container is running.
                    /// *   Terminated: The container stops running.
                    /// </summary>
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                }

                /// <summary>
                /// The readiness probe that is used to check whether the container is ready to serve a request.
                /// </summary>
                [NameInMap("ReadinessProbe")]
                [Validation(Required=false)]
                public DescribeContainerGroupsResponseBodyContainerGroupsContainersReadinessProbe ReadinessProbe { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsContainersReadinessProbe : TeaModel {
                    /// <summary>
                    /// The commands that are run in the container when you use a CLI to perform health checks.
                    /// </summary>
                    [NameInMap("Execs")]
                    [Validation(Required=false)]
                    public List<string> Execs { get; set; }

                    /// <summary>
                    /// The minimum number of consecutive failures that must occur for the check to be considered failed. Default value: 3.
                    /// </summary>
                    [NameInMap("FailureThreshold")]
                    [Validation(Required=false)]
                    public int? FailureThreshold { get; set; }

                    /// <summary>
                    /// The HTTP GET method that is used to check the container.
                    /// </summary>
                    [NameInMap("HttpGet")]
                    [Validation(Required=false)]
                    public DescribeContainerGroupsResponseBodyContainerGroupsContainersReadinessProbeHttpGet HttpGet { get; set; }
                    public class DescribeContainerGroupsResponseBodyContainerGroupsContainersReadinessProbeHttpGet : TeaModel {
                        /// <summary>
                        /// The path to which the system sends an HTTP GET request for a health check.
                        /// </summary>
                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                        /// <summary>
                        /// The port to which the system sends an HTTP GET request for a health check.
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        /// <summary>
                        /// The protocol type supported by the method. Valid values: HTTP and HTTPS.
                        /// </summary>
                        [NameInMap("Scheme")]
                        [Validation(Required=false)]
                        public string Scheme { get; set; }

                    }

                    /// <summary>
                    /// The number of seconds between the time when the startup of the container ends and the time when the probe starts.
                    /// </summary>
                    [NameInMap("InitialDelaySeconds")]
                    [Validation(Required=false)]
                    public int? InitialDelaySeconds { get; set; }

                    /// <summary>
                    /// The interval at which the health check is performed. Default value: 10. Minimum value: 1. Unit: seconds.
                    /// </summary>
                    [NameInMap("PeriodSeconds")]
                    [Validation(Required=false)]
                    public int? PeriodSeconds { get; set; }

                    /// <summary>
                    /// The minimum number of consecutive successes that must occur for the check to be considered successful. Default value: 1. The value must be 1.
                    /// </summary>
                    [NameInMap("SuccessThreshold")]
                    [Validation(Required=false)]
                    public int? SuccessThreshold { get; set; }

                    /// <summary>
                    /// The TCP socket method that is used to check the container.
                    /// </summary>
                    [NameInMap("TcpSocket")]
                    [Validation(Required=false)]
                    public DescribeContainerGroupsResponseBodyContainerGroupsContainersReadinessProbeTcpSocket TcpSocket { get; set; }
                    public class DescribeContainerGroupsResponseBodyContainerGroupsContainersReadinessProbeTcpSocket : TeaModel {
                        /// <summary>
                        /// The hostname.
                        /// </summary>
                        [NameInMap("Host")]
                        [Validation(Required=false)]
                        public string Host { get; set; }

                        /// <summary>
                        /// The port number.
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                    }

                    /// <summary>
                    /// The timeout period of the check. Default value: 1. Minimum value: 1. Unit: seconds.
                    /// </summary>
                    [NameInMap("TimeoutSeconds")]
                    [Validation(Required=false)]
                    public int? TimeoutSeconds { get; set; }

                }

                /// <summary>
                /// Indicates whether the container passed the readiness probe.
                /// </summary>
                [NameInMap("Ready")]
                [Validation(Required=false)]
                public bool? Ready { get; set; }

                /// <summary>
                /// The number of times that the container restarted.
                /// </summary>
                [NameInMap("RestartCount")]
                [Validation(Required=false)]
                public int? RestartCount { get; set; }

                /// <summary>
                /// The security context of the elastic container instance.
                /// </summary>
                [NameInMap("SecurityContext")]
                [Validation(Required=false)]
                public DescribeContainerGroupsResponseBodyContainerGroupsContainersSecurityContext SecurityContext { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsContainersSecurityContext : TeaModel {
                    /// <summary>
                    /// The permissions specific to the processes in the container.
                    /// </summary>
                    [NameInMap("Capability")]
                    [Validation(Required=false)]
                    public DescribeContainerGroupsResponseBodyContainerGroupsContainersSecurityContextCapability Capability { get; set; }
                    public class DescribeContainerGroupsResponseBodyContainerGroupsContainersSecurityContextCapability : TeaModel {
                        /// <summary>
                        /// The permissions specific to the process in the container.
                        /// </summary>
                        [NameInMap("Adds")]
                        [Validation(Required=false)]
                        public List<string> Adds { get; set; }

                    }

                    /// <summary>
                    /// Indicates whether permissions on the root file system are read-only. Valid value: true.
                    /// </summary>
                    [NameInMap("ReadOnlyRootFilesystem")]
                    [Validation(Required=false)]
                    public bool? ReadOnlyRootFilesystem { get; set; }

                    /// <summary>
                    /// The user ID (UID) that is used to run the container.
                    /// </summary>
                    [NameInMap("RunAsUser")]
                    [Validation(Required=false)]
                    public long? RunAsUser { get; set; }

                }

                /// <summary>
                /// Indicates whether the container allocates buffer resources to standard input streams when the container is running. If you do not specify this parameter, an end-of-file (EOF) error may occur when standard input streams in the container are read. Default value: false.
                /// </summary>
                [NameInMap("Stdin")]
                [Validation(Required=false)]
                public bool? Stdin { get; set; }

                /// <summary>
                /// Indicates whether standard input streams are disconnected after a client is disconnected. If Stdin is set to true, standard input streams remain connected among multiple sessions. If StdinOnce is set to true, standard input streams are connected after the container is started, and remain idle until a client is connected to receive data. After the client is disconnected, streams are also disconnected, and remain disconnected until the container restarts.
                /// </summary>
                [NameInMap("StdinOnce")]
                [Validation(Required=false)]
                public bool? StdinOnce { get; set; }

                /// <summary>
                /// Indicates whether interaction is enabled. Default value: false. If the value of the Command parameter is `/bin/bash`, the value of this parameter is true.
                /// </summary>
                [NameInMap("Tty")]
                [Validation(Required=false)]
                public bool? Tty { get; set; }

                /// <summary>
                /// Information about the mounted volumes.
                /// </summary>
                [NameInMap("VolumeMounts")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupsResponseBodyContainerGroupsContainersVolumeMounts> VolumeMounts { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsContainersVolumeMounts : TeaModel {
                    /// <summary>
                    /// The directory of the volume that is mounted to the container. The data in this directory is overwritten by the data on the volume.
                    /// </summary>
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                    /// <summary>
                    /// The mount propagation setting of the volume. Mount propagation allows volumes that are mounted on one container to be shared with other containers in the same pod, or even with other pods on the same node. Valid values:
                    /// 
                    /// *   None: The volume mount does not receive subsequent mounts that are performed on this volume or on the subdirectories of this volume.
                    /// *   HostToCotainer: The volume mount receives subsequent mounts that are performed on this volume or on the subdirectories of this volume.
                    /// *   Bidirectional: This value is similar to HostToCotainer. The volume mount receives subsequent mounts that are performed on this volume or on the subdirectories of this volume. In addition, all volume mounts that are performed on the container are propagated back to the host and all containers of all pods that use the same volume.
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
                    /// Indicates whether the volume is read-only.
                    /// </summary>
                    [NameInMap("ReadOnly")]
                    [Validation(Required=false)]
                    public bool? ReadOnly { get; set; }

                    /// <summary>
                    /// The subdirectory of the volume. You can use this parameter to mount the same volume to different subdirectories of the container.
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
            /// The number of vCPUs that are allocated to the elastic container instance.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public float? Cpu { get; set; }

            /// <summary>
            /// The time when the instance was created. The time follows the RFC 3339 standard. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The discount.
            /// </summary>
            [NameInMap("Discount")]
            [Validation(Required=false)]
            public int? Discount { get; set; }

            /// <summary>
            /// The Domain Name System (DNS) settings.
            /// </summary>
            [NameInMap("DnsConfig")]
            [Validation(Required=false)]
            public DescribeContainerGroupsResponseBodyContainerGroupsDnsConfig DnsConfig { get; set; }
            public class DescribeContainerGroupsResponseBodyContainerGroupsDnsConfig : TeaModel {
                /// <summary>
                /// The IP addresses of DNS servers.
                /// </summary>
                [NameInMap("NameServers")]
                [Validation(Required=false)]
                public List<string> NameServers { get; set; }

                /// <summary>
                /// The options. Each option is a name-value pair. The value in the name-value pair is optional.
                /// </summary>
                [NameInMap("Options")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupsResponseBodyContainerGroupsDnsConfigOptions> Options { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsDnsConfigOptions : TeaModel {
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
                /// The search domains of DNS servers.
                /// </summary>
                [NameInMap("Searches")]
                [Validation(Required=false)]
                public List<string> Searches { get; set; }

            }

            /// <summary>
            /// The security context of the elastic container instance.
            /// </summary>
            [NameInMap("EciSecurityContext")]
            [Validation(Required=false)]
            public DescribeContainerGroupsResponseBodyContainerGroupsEciSecurityContext EciSecurityContext { get; set; }
            public class DescribeContainerGroupsResponseBodyContainerGroupsEciSecurityContext : TeaModel {
                /// <summary>
                /// sysctl parameters.
                /// </summary>
                [NameInMap("Sysctls")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupsResponseBodyContainerGroupsEciSecurityContextSysctls> Sysctls { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsEciSecurityContextSysctls : TeaModel {
                    /// <summary>
                    /// The name of the Sysctl parameter.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The value of the Sysctl parameter.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// The ID of the elastic network interface (ENI).
            /// </summary>
            [NameInMap("EniInstanceId")]
            [Validation(Required=false)]
            public string EniInstanceId { get; set; }

            /// <summary>
            /// The size of the temporary storage space. Unit: GiB.
            /// </summary>
            [NameInMap("EphemeralStorage")]
            [Validation(Required=false)]
            public int? EphemeralStorage { get; set; }

            /// <summary>
            /// The events of the elastic container instance. A maximum of 50 events can be returned.
            /// </summary>
            [NameInMap("Events")]
            [Validation(Required=false)]
            public List<DescribeContainerGroupsResponseBodyContainerGroupsEvents> Events { get; set; }
            public class DescribeContainerGroupsResponseBodyContainerGroupsEvents : TeaModel {
                /// <summary>
                /// The number of the events.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The start time of the event.
                /// </summary>
                [NameInMap("FirstTimestamp")]
                [Validation(Required=false)]
                public string FirstTimestamp { get; set; }

                /// <summary>
                /// The end time of the event.
                /// </summary>
                [NameInMap("LastTimestamp")]
                [Validation(Required=false)]
                public string LastTimestamp { get; set; }

                /// <summary>
                /// The event message.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The category to which the event belongs.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The event name.
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// The type of the event. Valid values:
                /// 
                /// *   Normal
                /// *   Warning
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The time when the elastic container instance failed to run due to overdue payments. The time follows the RFC 3339 standard. The time is displayed in UTC.
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// The time when the instance failed to run. The time follows the RFC 3339 standard. The time is displayed in UTC.
            /// </summary>
            [NameInMap("FailedTime")]
            [Validation(Required=false)]
            public string FailedTime { get; set; }

            /// <summary>
            /// The hostnames and IP addresses for a container that are added to the hosts file of the elastic container instance.
            /// </summary>
            [NameInMap("HostAliases")]
            [Validation(Required=false)]
            public List<DescribeContainerGroupsResponseBodyContainerGroupsHostAliases> HostAliases { get; set; }
            public class DescribeContainerGroupsResponseBodyContainerGroupsHostAliases : TeaModel {
                /// <summary>
                /// The information about the hosts.
                /// </summary>
                [NameInMap("Hostnames")]
                [Validation(Required=false)]
                public List<string> Hostnames { get; set; }

                /// <summary>
                /// The IP address of the instance.
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

            }

            /// <summary>
            /// The information about the init containers.
            /// </summary>
            [NameInMap("InitContainers")]
            [Validation(Required=false)]
            public List<DescribeContainerGroupsResponseBodyContainerGroupsInitContainers> InitContainers { get; set; }
            public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainers : TeaModel {
                /// <summary>
                /// The arguments that are passed to the startup commands of the container.
                /// </summary>
                [NameInMap("Args")]
                [Validation(Required=false)]
                public List<string> Args { get; set; }

                /// <summary>
                /// The startup commands of the containers.
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
                /// The current container status.
                /// </summary>
                [NameInMap("CurrentState")]
                [Validation(Required=false)]
                public DescribeContainerGroupsResponseBodyContainerGroupsInitContainersCurrentState CurrentState { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainersCurrentState : TeaModel {
                    /// <summary>
                    /// The details of the container status.
                    /// </summary>
                    [NameInMap("DetailStatus")]
                    [Validation(Required=false)]
                    public string DetailStatus { get; set; }

                    /// <summary>
                    /// The exit code of the container.
                    /// </summary>
                    [NameInMap("ExitCode")]
                    [Validation(Required=false)]
                    public int? ExitCode { get; set; }

                    /// <summary>
                    /// The time when the container stopped running.
                    /// </summary>
                    [NameInMap("FinishTime")]
                    [Validation(Required=false)]
                    public string FinishTime { get; set; }

                    /// <summary>
                    /// The event message.
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// The reason why the container is in this status.
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    /// <summary>
                    /// The code of the container status.
                    /// </summary>
                    [NameInMap("Signal")]
                    [Validation(Required=false)]
                    public int? Signal { get; set; }

                    /// <summary>
                    /// The time when the container started to run.
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// The container status. Valid values:
                    /// 
                    /// *   Waiting
                    /// *   Running
                    /// *   Terminated
                    /// </summary>
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                }

                /// <summary>
                /// The environment variables of the init container.
                /// </summary>
                [NameInMap("EnvironmentVars")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupsResponseBodyContainerGroupsInitContainersEnvironmentVars> EnvironmentVars { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainersEnvironmentVars : TeaModel {
                    /// <summary>
                    /// The name of the environment variable.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The value of the environment variable.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    /// <summary>
                    /// The source of the environment variable value. This parameter has a value only when the Value parameter is left empty.
                    /// </summary>
                    [NameInMap("ValueFrom")]
                    [Validation(Required=false)]
                    public DescribeContainerGroupsResponseBodyContainerGroupsInitContainersEnvironmentVarsValueFrom ValueFrom { get; set; }
                    public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainersEnvironmentVarsValueFrom : TeaModel {
                        /// <summary>
                        /// The specified fields.
                        /// </summary>
                        [NameInMap("FieldRef")]
                        [Validation(Required=false)]
                        public DescribeContainerGroupsResponseBodyContainerGroupsInitContainersEnvironmentVarsValueFromFieldRef FieldRef { get; set; }
                        public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainersEnvironmentVarsValueFromFieldRef : TeaModel {
                            /// <summary>
                            /// The path of the field. Only `status.podIP` is supported.
                            /// </summary>
                            [NameInMap("FieldPath")]
                            [Validation(Required=false)]
                            public string FieldPath { get; set; }

                        }

                    }

                }

                /// <summary>
                /// The number of GPUs.
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
                /// The name of the init container.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The exposed port and protocol of the container.
                /// </summary>
                [NameInMap("Ports")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupsResponseBodyContainerGroupsInitContainersPorts> Ports { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainersPorts : TeaModel {
                    /// <summary>
                    /// The port number. Valid values: 1 to 65535.
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// The protocol type.
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                }

                /// <summary>
                /// The previous state of the container.
                /// </summary>
                [NameInMap("PreviousState")]
                [Validation(Required=false)]
                public DescribeContainerGroupsResponseBodyContainerGroupsInitContainersPreviousState PreviousState { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainersPreviousState : TeaModel {
                    /// <summary>
                    /// The details of the container status.
                    /// </summary>
                    [NameInMap("DetailStatus")]
                    [Validation(Required=false)]
                    public string DetailStatus { get; set; }

                    /// <summary>
                    /// The exit code of the container.
                    /// </summary>
                    [NameInMap("ExitCode")]
                    [Validation(Required=false)]
                    public int? ExitCode { get; set; }

                    /// <summary>
                    /// The time when the container stopped running.
                    /// </summary>
                    [NameInMap("FinishTime")]
                    [Validation(Required=false)]
                    public string FinishTime { get; set; }

                    /// <summary>
                    /// The message about the container status.
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// The reason why the container is in this status.
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    /// <summary>
                    /// The code of the container status.
                    /// </summary>
                    [NameInMap("Signal")]
                    [Validation(Required=false)]
                    public int? Signal { get; set; }

                    /// <summary>
                    /// The time when the container started to run.
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// The container status. Valid values: Waiting, Running, and Terminated.
                    /// </summary>
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                }

                /// <summary>
                /// Indicates whether the container passed the readiness probe.
                /// </summary>
                [NameInMap("Ready")]
                [Validation(Required=false)]
                public bool? Ready { get; set; }

                /// <summary>
                /// The number of times that the container restarted.
                /// </summary>
                [NameInMap("RestartCount")]
                [Validation(Required=false)]
                public int? RestartCount { get; set; }

                /// <summary>
                /// The security context of the container.
                /// </summary>
                [NameInMap("SecurityContext")]
                [Validation(Required=false)]
                public DescribeContainerGroupsResponseBodyContainerGroupsInitContainersSecurityContext SecurityContext { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainersSecurityContext : TeaModel {
                    /// <summary>
                    /// The permissions specific to the processes in the container.
                    /// </summary>
                    [NameInMap("Capability")]
                    [Validation(Required=false)]
                    public DescribeContainerGroupsResponseBodyContainerGroupsInitContainersSecurityContextCapability Capability { get; set; }
                    public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainersSecurityContextCapability : TeaModel {
                        /// <summary>
                        /// The permissions specific to the processes in the container.
                        /// </summary>
                        [NameInMap("Adds")]
                        [Validation(Required=false)]
                        public List<string> Adds { get; set; }

                    }

                    /// <summary>
                    /// Indicates whether permissions on the root file system are read-only.
                    /// </summary>
                    [NameInMap("ReadOnlyRootFilesystem")]
                    [Validation(Required=false)]
                    public bool? ReadOnlyRootFilesystem { get; set; }

                    /// <summary>
                    /// The UID that is used to run the entry point of the container process.
                    /// </summary>
                    [NameInMap("RunAsUser")]
                    [Validation(Required=false)]
                    public long? RunAsUser { get; set; }

                }

                /// <summary>
                /// The information about the volumes that are mounted to the init container.
                /// </summary>
                [NameInMap("VolumeMounts")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupsResponseBodyContainerGroupsInitContainersVolumeMounts> VolumeMounts { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainersVolumeMounts : TeaModel {
                    /// <summary>
                    /// The directory of the volume that is mounted to the container. The data in this directory is overwritten by the data on the volume.
                    /// </summary>
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                    /// <summary>
                    /// The mount propagation setting of the volume. Mount propagation allows volumes that are mounted on one container to be shared with other containers in the same pod, or even with other pods on the same node. Valid values:
                    /// 
                    /// *   None: The volume mount does not receive subsequent mounts that are performed on this volume or on the subdirectories of this volume.
                    /// *   HostToCotainer: The volume mount receives subsequent mounts that are performed on this volume or on the subdirectories of this volume.
                    /// *   Bidirectional: This value is similar to HostToCotainer. The volume mount receives subsequent mounts that are performed on this volume or on the subdirectories of this volume. In addition, all volume mounts that are performed on the container are propagated back to the host and all containers of all pods that use the same volume.
                    /// </summary>
                    [NameInMap("MountPropagation")]
                    [Validation(Required=false)]
                    public string MountPropagation { get; set; }

                    /// <summary>
                    /// The name of the volume. The value of this parameter is the same as the name of the volume that you selected when you purchased the container.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// Indicates whether the volume is read-only.
                    /// </summary>
                    [NameInMap("ReadOnly")]
                    [Validation(Required=false)]
                    public bool? ReadOnly { get; set; }

                }

                /// <summary>
                /// The working directory of the container.
                /// </summary>
                [NameInMap("WorkingDir")]
                [Validation(Required=false)]
                public string WorkingDir { get; set; }

            }

            /// <summary>
            /// The instance type of the specified Elastic Compute Service (ECS) instance.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The public IP address.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The private IP address.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// The IPv6 address of the instance.
            /// </summary>
            [NameInMap("Ipv6Address")]
            [Validation(Required=false)]
            public string Ipv6Address { get; set; }

            /// <summary>
            /// The memory size of the instance. Unit: GiB.
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// The name of the instance RAM role. The elastic container instance and the ECS instance share a RAM role. For more information, see [Use an instance RAM role by calling API operations](https://help.aliyun.com/document_detail/61178.html).
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
            /// The resource group ID.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The restart policy of the elastic container instance. Valid values:
            /// 
            /// *   Never: Never restarts the instance if a container in the instance exits upon termination.
            /// *   Always: Always restarts the instance if a container in the instance exits upon termination.
            /// *   OnFailure: Restarts the instance only if a container in the instance exists upon failure with a status code of non-zero.
            /// </summary>
            [NameInMap("RestartPolicy")]
            [Validation(Required=false)]
            public string RestartPolicy { get; set; }

            /// <summary>
            /// The ID of the security group to which the instances belong.
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// The maximum hourly price for the preemptible elastic container instance.
            /// 
            /// This parameter is returned only when SpotStrategy is set to SpotWithPriceLimit.
            /// </summary>
            [NameInMap("SpotPriceLimit")]
            [Validation(Required=false)]
            public double? SpotPriceLimit { get; set; }

            /// <summary>
            /// The bid policy for the instance. Default value: NoSpot. Valid values:
            /// 
            /// *   NoSpot: The instance is a regular pay-as-you-go instance.
            /// *   SpotWithPriceLimit: The instance is a preemptible instance that has a user-defined maximum hourly price.
            /// *   SpotAsPriceGo: The instance is a preemptible instance for which the market price at the time of purchase is automatically used as the bid price.
            /// </summary>
            [NameInMap("SpotStrategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// The status of the instance. Valid values:
            /// 
            /// *   Pending: The instance is being started.
            /// *   Running: The instance is running.
            /// *   Succeeded: The instance successfully runs.
            /// *   Failed: The instance fails to run.
            /// *   Scheduling: The instance is being created.
            /// *   ScheduleFailed: The instance fails to be created.
            /// *   Restarting: The instance is being restarted.
            /// *   Updating: The instance is being updated.
            /// *   Terminating: The instance is being terminated.
            /// *   Expired: The instance is expired.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The time when all containers exited on success. The time follows the RFC 3339 standard. The time is displayed in UTC.
            /// </summary>
            [NameInMap("SucceededTime")]
            [Validation(Required=false)]
            public string SucceededTime { get; set; }

            /// <summary>
            /// The tags that are added to the instance.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeContainerGroupsResponseBodyContainerGroupsTags> Tags { get; set; }
            public class DescribeContainerGroupsResponseBodyContainerGroupsTags : TeaModel {
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
            /// This parameter is not publicly available.
            /// </summary>
            [NameInMap("TenantEniInstanceId")]
            [Validation(Required=false)]
            public string TenantEniInstanceId { get; set; }

            /// <summary>
            /// This parameter is not publicly available.
            /// </summary>
            [NameInMap("TenantEniIp")]
            [Validation(Required=false)]
            public string TenantEniIp { get; set; }

            /// <summary>
            /// This parameter is not publicly available.
            /// </summary>
            [NameInMap("TenantSecurityGroupId")]
            [Validation(Required=false)]
            public string TenantSecurityGroupId { get; set; }

            /// <summary>
            /// This parameter is not publicly available.
            /// </summary>
            [NameInMap("TenantVSwitchId")]
            [Validation(Required=false)]
            public string TenantVSwitchId { get; set; }

            /// <summary>
            /// The ID of the vSwitch to which the instance is connected.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// The information about the volumes.
            /// </summary>
            [NameInMap("Volumes")]
            [Validation(Required=false)]
            public List<DescribeContainerGroupsResponseBodyContainerGroupsVolumes> Volumes { get; set; }
            public class DescribeContainerGroupsResponseBodyContainerGroupsVolumes : TeaModel {
                /// <summary>
                /// The path of the ConfigFile volume.
                /// </summary>
                [NameInMap("ConfigFileVolumeConfigFileToPaths")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupsResponseBodyContainerGroupsVolumesConfigFileVolumeConfigFileToPaths> ConfigFileVolumeConfigFileToPaths { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsVolumesConfigFileVolumeConfigFileToPaths : TeaModel {
                    /// <summary>
                    /// The content of the ConfigFile volume. Maximum size: 32 KB.
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// The relative path of the ConfigFile volume.
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                }

                /// <summary>
                /// The ID of the disk when you set Type to DiskVolume.
                /// </summary>
                [NameInMap("DiskVolumeDiskId")]
                [Validation(Required=false)]
                public string DiskVolumeDiskId { get; set; }

                /// <summary>
                /// The file system type of the disk volume.
                /// </summary>
                [NameInMap("DiskVolumeFsType")]
                [Validation(Required=false)]
                public string DiskVolumeFsType { get; set; }

                /// <summary>
                /// The storage media for the emptyDir volume. This parameter is empty by default, indicating that the node file system is used as the storage media. Valid values:
                /// 
                /// *   Memory: Memory is used as the storage media.
                /// *   LocalRaid0: Local disks are formed into RAID 0. This value is valid only if an elastic container instance that has local disks mounted is created. For more information, see [Create an elastic container instance that has local disks mounted](https://help.aliyun.com/document_detail/114664.html).
                /// </summary>
                [NameInMap("EmptyDirVolumeMedium")]
                [Validation(Required=false)]
                public string EmptyDirVolumeMedium { get; set; }

                /// <summary>
                /// The storage size of the emptyDir volume.
                /// </summary>
                [NameInMap("EmptyDirVolumeSizeLimit")]
                [Validation(Required=false)]
                public string EmptyDirVolumeSizeLimit { get; set; }

                /// <summary>
                /// The name of the driver when you set the Type parameter to FlexVolume.
                /// </summary>
                [NameInMap("FlexVolumeDriver")]
                [Validation(Required=false)]
                public string FlexVolumeDriver { get; set; }

                /// <summary>
                /// The file system type when you set the Type parameter to FlexVolume. The default value varies based on the script of the FlexVolume plug-in.
                /// </summary>
                [NameInMap("FlexVolumeFsType")]
                [Validation(Required=false)]
                public string FlexVolumeFsType { get; set; }

                /// <summary>
                /// The options when you set the Type parameter to FlexVolume.
                /// </summary>
                [NameInMap("FlexVolumeOptions")]
                [Validation(Required=false)]
                public string FlexVolumeOptions { get; set; }

                /// <summary>
                /// The path of the NFS volume.
                /// </summary>
                [NameInMap("NFSVolumePath")]
                [Validation(Required=false)]
                public string NFSVolumePath { get; set; }

                /// <summary>
                /// Indicates whether the NFS volume is read-only.
                /// </summary>
                [NameInMap("NFSVolumeReadOnly")]
                [Validation(Required=false)]
                public bool? NFSVolumeReadOnly { get; set; }

                /// <summary>
                /// The address of the NFS server.
                /// </summary>
                [NameInMap("NFSVolumeServer")]
                [Validation(Required=false)]
                public string NFSVolumeServer { get; set; }

                /// <summary>
                /// The volume name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The type of the volume. Valid values:
                /// 
                /// *   EmptyDirVolume
                /// *   NFSVolume
                /// *   ConfigFileVolume
                /// *   FlexVolume
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The ID of the VPC to which the instance belongs.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// The zone to which the instance belongs.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// The token that determines the start point of the query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request. The value is unique.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of queried instances.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
