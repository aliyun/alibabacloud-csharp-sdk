// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeContainerGroupsResponseBody : TeaModel {
        /// <summary>
        /// Details about the elastic container instances.
        /// </summary>
        [NameInMap("ContainerGroups")]
        [Validation(Required=false)]
        public List<DescribeContainerGroupsResponseBodyContainerGroups> ContainerGroups { get; set; }
        public class DescribeContainerGroupsResponseBodyContainerGroups : TeaModel {
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
            /// The containers in the elastic container instance.
            /// </summary>
            [NameInMap("Containers")]
            [Validation(Required=false)]
            public List<DescribeContainerGroupsResponseBodyContainerGroupsContainers> Containers { get; set; }
            public class DescribeContainerGroupsResponseBodyContainerGroupsContainers : TeaModel {
                /// <summary>
                /// The arguments that are passed to the startup command of the container.
                /// </summary>
                [NameInMap("Args")]
                [Validation(Required=false)]
                public List<string> Args { get; set; }

                /// <summary>
                /// The container startup commands.
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
                    /// The reason why the container is in this state.
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
                /// The environment variables.
                /// </summary>
                [NameInMap("EnvironmentVars")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupsResponseBodyContainerGroupsContainersEnvironmentVars> EnvironmentVars { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsContainersEnvironmentVars : TeaModel {
                    /// <summary>
                    /// The environment variable.
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
                    /// The source of the variable value. This parameter has a value only when the Value parameter is not empty.
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
                /// The image of the container.
                /// </summary>
                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// The policy for image pulling. Valid values:
                /// 
                /// *   Always: Image pulling is always performed.
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
                        /// The path to which HTTP GET requests were sent.
                        /// </summary>
                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                        /// <summary>
                        /// The port to which HTTP GET requests were sent.
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        /// <summary>
                        /// The protocol type of the HTTP GET requests.
                        /// </summary>
                        [NameInMap("Scheme")]
                        [Validation(Required=false)]
                        public string Scheme { get; set; }

                    }

                    /// <summary>
                    /// The number of seconds between the time when the startup of the container ends and the time when the check starts.
                    /// </summary>
                    [NameInMap("InitialDelaySeconds")]
                    [Validation(Required=false)]
                    public int? InitialDelaySeconds { get; set; }

                    /// <summary>
                    /// The interval at which the container is checked. Unit: seconds. Default value: 10. Minimum value: 1.
                    /// </summary>
                    [NameInMap("PeriodSeconds")]
                    [Validation(Required=false)]
                    public int? PeriodSeconds { get; set; }

                    /// <summary>
                    /// The minimum number of consecutive successes that must occur for the check to be considered successful. Default value: 1. Set the value to 1.
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
                    /// The timeout period of the health check. Unit: seconds. Default value: 1. Minimum value: 1.
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
                /// The container name.
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
                    /// The protocol.
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
                    /// The reason why the container is in this state.
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
                    /// The commands to be executed in containers when you use a command-line interface (CLI) to perform health checks.
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
                        /// The path to which the system sends an HTTP GET request for a probe.
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
                        /// The protocol type of the HTTP GET requests.
                        /// </summary>
                        [NameInMap("Scheme")]
                        [Validation(Required=false)]
                        public string Scheme { get; set; }

                    }

                    /// <summary>
                    /// The number of seconds between the time when the startup of the container ends and the time when the check starts.
                    /// </summary>
                    [NameInMap("InitialDelaySeconds")]
                    [Validation(Required=false)]
                    public int? InitialDelaySeconds { get; set; }

                    /// <summary>
                    /// The interval at which the container is checked. Unit: seconds. Default value: 10. Minimum value: 1.
                    /// </summary>
                    [NameInMap("PeriodSeconds")]
                    [Validation(Required=false)]
                    public int? PeriodSeconds { get; set; }

                    /// <summary>
                    /// The minimum number of consecutive successes that must occur for the check to be considered successful. Default value: 1. Set the value to 1.
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
                        /// The IP address of the host.
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
                    /// The timeout period of the health check. Unit: seconds. Default value: 1. Minimum value: 1.
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
                    /// Indicates whether the root file system is set to the read-only mode. The only valid value is true.
                    /// </summary>
                    [NameInMap("ReadOnlyRootFilesystem")]
                    [Validation(Required=false)]
                    public bool? ReadOnlyRootFilesystem { get; set; }

                    /// <summary>
                    /// The ID of the user that runs the container.
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
                /// Indicates whether the container runtime closes the stdin channel after the stdin channel has been opened by a sing attach. If stdin is true, the stdin stream remains open across multiple attach sessions. If StdinOnce is set to true, stdin is opened on container start, is empty until the first client attaches to stdin, and then remains open and receive data until the client disconnects. When the client disconnects, stdin is closed and remains closed until the container is restarted.
                /// </summary>
                [NameInMap("StdinOnce")]
                [Validation(Required=false)]
                public bool? StdinOnce { get; set; }

                /// <summary>
                /// Indicates whether interaction is enabled. Default value: false If the Command parameter is a `/bin/bash` command, the value is true.
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
                    /// The directory to which the volume is mounted. Data under this directory is overwritten by the data on the volume.
                    /// </summary>
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                    /// <summary>
                    /// The mount propagation settings of volumes. Mount propagation allows the sharing of volumes that are mounted on a container to other containers in the same pod, or even to other pods on the same node. Valid values:
                    /// 
                    /// *   None: The volume mount does not receive subsequent mounts that are mounted to the volume or the subdirectories of the volume.
                    /// *   HostToCotainer: The volume mount receives all subsequent mounts that are mounted to the volume or to the subdirectories of the volume.
                    /// *   Bidirectional: The volume mount behaves the same as the HostToCotainer mount. The volume mount receives all subsequent mounts that are mounted to the volume or to the subdirectories of the volume. In addition, all volume mounts created by the container are propagated back to the host and to all containers of all pods that use the same volume.
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
                    /// The subdirectory of the volume. This parameter specifies different subdirectories of the same volume that the instance can mount to different subdirectories of containers.
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
            /// The time when the system created the elastic container instance after the system received the request. The time follows the RFC 3339 standard and must be in UTC.
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
                /// The objects. Each object is a name-value pair. The value is optional.
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
                    /// The value of the object.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The lookup domains of DNS server N.
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
                /// The Sysctl parameters.
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
            /// The events about the elastic container instance. A maximum of 50 events can be returned.
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
                /// The time when the event started.
                /// </summary>
                [NameInMap("FirstTimestamp")]
                [Validation(Required=false)]
                public string FirstTimestamp { get; set; }

                /// <summary>
                /// The time when the event ended.
                /// </summary>
                [NameInMap("LastTimestamp")]
                [Validation(Required=false)]
                public string LastTimestamp { get; set; }

                /// <summary>
                /// The message about the event.
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
            /// The time when the elastic container instance failed to run due to overdue payments. The time follows the RFC 3339 standard and must be in UTC.
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// The time when the instance failed to run. The time follows the RFC 3339 standard and must be in UTC.
            /// </summary>
            [NameInMap("FailedTime")]
            [Validation(Required=false)]
            public string FailedTime { get; set; }

            /// <summary>
            /// The hostname mapping of a container in the elastic container instance.
            /// </summary>
            [NameInMap("HostAliases")]
            [Validation(Required=false)]
            public List<DescribeContainerGroupsResponseBodyContainerGroupsHostAliases> HostAliases { get; set; }
            public class DescribeContainerGroupsResponseBodyContainerGroupsHostAliases : TeaModel {
                /// <summary>
                /// The information about the host.
                /// </summary>
                [NameInMap("Hostnames")]
                [Validation(Required=false)]
                public List<string> Hostnames { get; set; }

                /// <summary>
                /// The IP address.
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
                /// The arguments that are passed to the startup command.
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
                /// The number of vCPUs.
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
                    /// The message about the event.
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// The reason why the container is in this state.
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
                /// The environment variables.
                /// </summary>
                [NameInMap("EnvironmentVars")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupsResponseBodyContainerGroupsInitContainersEnvironmentVars> EnvironmentVars { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainersEnvironmentVars : TeaModel {
                    /// <summary>
                    /// The environment variable.
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
                    /// The source of the variable value. This parameter has a value only when the Value parameter is not empty.
                    /// </summary>
                    [NameInMap("ValueFrom")]
                    [Validation(Required=false)]
                    public DescribeContainerGroupsResponseBodyContainerGroupsInitContainersEnvironmentVarsValueFrom ValueFrom { get; set; }
                    public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainersEnvironmentVarsValueFrom : TeaModel {
                        /// <summary>
                        /// The specified field.
                        /// </summary>
                        [NameInMap("FieldRef")]
                        [Validation(Required=false)]
                        public DescribeContainerGroupsResponseBodyContainerGroupsInitContainersEnvironmentVarsValueFromFieldRef FieldRef { get; set; }
                        public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainersEnvironmentVarsValueFromFieldRef : TeaModel {
                            /// <summary>
                            /// The path from which the fields come in the specified version. Only `status.podIP` is supported.
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
                /// The image.
                /// </summary>
                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// The policy for image pulling. Valid values:
                /// 
                /// *   Always: Image pulling is always performed.
                /// *   IfNotPresent: On-premises images are preferentially used. If no on-premises images are available, image pulling is performed.
                /// *   Never: On-premises images are always used. Image pulling is not performed.
                /// </summary>
                [NameInMap("ImagePullPolicy")]
                [Validation(Required=false)]
                public string ImagePullPolicy { get; set; }

                /// <summary>
                /// The size of memory that is allocated to the init container. Unit: GiB.
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
                    /// The protocol.
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
                    /// The reason why the container is in this state.
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
                    /// The status of the container. Valid values: Waiting, Running, and Terminated.
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
                /// The number of times the container restarted.
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
                        /// The permissions specific to the process in the container.
                        /// </summary>
                        [NameInMap("Adds")]
                        [Validation(Required=false)]
                        public List<string> Adds { get; set; }

                    }

                    /// <summary>
                    /// Indicates whether the root file system is set to the read-only mode. The only valid value is true.
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
                    /// The directory to which the volume is mounted. Data under this directory is overwritten by the data on the volume.
                    /// </summary>
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                    /// <summary>
                    /// The mount propagation settings of volumes. Mount propagation allows the sharing of volumes that are mounted on a container to other containers in the same pod, or even to other pods on the same node. Valid values:
                    /// 
                    /// *   None: The volume mount does not receive subsequent mounts that are mounted to the volume or the subdirectories of the volume.
                    /// *   HostToCotainer: The volume mount receives all subsequent mounts that are mounted to the volume or to the subdirectories of the volume.
                    /// *   Bidirectional: The volume mount behaves the same as the HostToCotainer mount. The volume mount receives all subsequent mounts that are mounted to the volume or to the subdirectories of the volume. In addition, all volume mounts created by the container are propagated back to the host and to all containers of all pods that use the same volume.
                    /// </summary>
                    [NameInMap("MountPropagation")]
                    [Validation(Required=false)]
                    public string MountPropagation { get; set; }

                    /// <summary>
                    /// The name of the volume. The name is the same as the volume you selected when you purchased the container.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// Default value: false.
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
            /// The instance type of the Elastic Compute Service (ECS) instance that is used to create the elastic container instance.
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
            /// The IPv6 address.
            /// </summary>
            [NameInMap("Ipv6Address")]
            [Validation(Required=false)]
            public string Ipv6Address { get; set; }

            /// <summary>
            /// The memory size of the elastic container instance. Unit: GiB.
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// The name of the instance RAM role. You can use an instance RAM role to access both elastic container instances and ECS instances. For more information, see [Use the instance RAM role by calling APIs](~~61178~~).
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
            /// *   Never: never restarts the elastic container instance.
            /// *   Always: always restarts the elastic container instance.
            /// *   OnFailure: restarts the instance if it fails to run.
            /// </summary>
            [NameInMap("RestartPolicy")]
            [Validation(Required=false)]
            public string RestartPolicy { get; set; }

            /// <summary>
            /// The ID of the security group to which the instance belongs.
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// The maximum hourly price for the preemptible elastic container instance.
            /// 
            /// This parameter is returned only if you set the SpotStrategy parameter to SpotWithPriceLimit.
            /// </summary>
            [NameInMap("SpotPriceLimit")]
            [Validation(Required=false)]
            public double? SpotPriceLimit { get; set; }

            /// <summary>
            /// The bidding policy for the instance. Valid values:
            /// 
            /// *   NoSpot (default): The instance is created as a regular pay-as-you-go instance.
            /// *   SpotWithPriceLimit: The instance is a preemptible instance that has a maximum price.
            /// *   SpotAsPriceGo: The instance is a preemptible instance for which the market price at the time of purchase is automatically used as the bidding price.
            /// </summary>
            [NameInMap("SpotStrategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// The status of the instance. Valid values:
            /// 
            /// *   Pending: The elastic container instance is being started.
            /// *   Running: The elastic container instance is running.
            /// *   Succeeded: The elastic container instance runs successfully.
            /// *   Failed: The elastic container instance fails to run.
            /// *   Scheduling: The elastic container instance is being created.
            /// *   ScheduleFailed: The elastic container instance fails to be created.
            /// *   Restarting: The elastic container instance is being restarted.
            /// *   Updating: The elastic container instance is being updated.
            /// *   Terminating: The elastic container instance is being terminated.
            /// *   Expired: The instance expired.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The time when all containers in the elastic container instance exit. The time follows the RFC 3339 standard and must be in UTC.
            /// </summary>
            [NameInMap("SucceededTime")]
            [Validation(Required=false)]
            public string SucceededTime { get; set; }

            /// <summary>
            /// The tags of the instance.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeContainerGroupsResponseBodyContainerGroupsTags> Tags { get; set; }
            public class DescribeContainerGroupsResponseBodyContainerGroupsTags : TeaModel {
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
            /// This parameter is unavailable.
            /// </summary>
            [NameInMap("TenantEniInstanceId")]
            [Validation(Required=false)]
            public string TenantEniInstanceId { get; set; }

            /// <summary>
            /// This parameter is unavailable.
            /// </summary>
            [NameInMap("TenantEniIp")]
            [Validation(Required=false)]
            public string TenantEniIp { get; set; }

            /// <summary>
            /// This parameter is unavailable.
            /// </summary>
            [NameInMap("TenantSecurityGroupId")]
            [Validation(Required=false)]
            public string TenantSecurityGroupId { get; set; }

            /// <summary>
            /// This parameter is unavailable.
            /// </summary>
            [NameInMap("TenantVSwitchId")]
            [Validation(Required=false)]
            public string TenantVSwitchId { get; set; }

            /// <summary>
            /// The ID of the vSwitch.
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
                /// The paths to configuration files.
                /// </summary>
                [NameInMap("ConfigFileVolumeConfigFileToPaths")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupsResponseBodyContainerGroupsVolumesConfigFileVolumeConfigFileToPaths> ConfigFileVolumeConfigFileToPaths { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsVolumesConfigFileVolumeConfigFileToPaths : TeaModel {
                    /// <summary>
                    /// The content of the configuration file. Maximum size: 32 KB.
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// The relative path of the configuration file.
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                }

                /// <summary>
                /// The ID of the disk when you set the Type parameter to DiskVolume.
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
                /// The storage media of emptyDir volume N. This parameter is empty by default, indicating that the node file system is used as the storage media. Valid values:
                /// 
                /// *   Memory: uses memory as the storage media.
                /// *   LocalRaid0: forms local disks into RAID 0. This value is applicable only to scenarios in which an elastic container instance that has local disks mounted is created. For more information, see [Create an elastic container instance that has local disks mounted](~~114664~~).
                /// </summary>
                [NameInMap("EmptyDirVolumeMedium")]
                [Validation(Required=false)]
                public string EmptyDirVolumeMedium { get; set; }

                /// <summary>
                /// The storage capacity of emptyDir volume N.
                /// </summary>
                [NameInMap("EmptyDirVolumeSizeLimit")]
                [Validation(Required=false)]
                public string EmptyDirVolumeSizeLimit { get; set; }

                /// <summary>
                /// The name of the FlexVolume driver.
                /// </summary>
                [NameInMap("FlexVolumeDriver")]
                [Validation(Required=false)]
                public string FlexVolumeDriver { get; set; }

                /// <summary>
                /// The file system type when you set the Type parameter to FlexVolume. The default value is determined by the script of the FlexVolume plug-in.
                /// </summary>
                [NameInMap("FlexVolumeFsType")]
                [Validation(Required=false)]
                public string FlexVolumeFsType { get; set; }

                /// <summary>
                /// The options when you set the Volume.N.Type parameter to FlexVolume.
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
                /// Indicates whether the volume is read-only.
                /// </summary>
                [NameInMap("NFSVolumeReadOnly")]
                [Validation(Required=false)]
                public bool? NFSVolumeReadOnly { get; set; }

                /// <summary>
                /// The endpoint of the server when you set the Type parameter to NFSVolume.
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
            /// The ID of the virtual private cloud (VPC) to which the elastic container instances belong.
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
