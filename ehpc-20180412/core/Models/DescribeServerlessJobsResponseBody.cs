// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeServerlessJobsResponseBody : TeaModel {
        /// <summary>
        /// The list of detailed information about the serverless job.
        /// </summary>
        [NameInMap("JobInfos")]
        [Validation(Required=false)]
        public List<DescribeServerlessJobsResponseBodyJobInfos> JobInfos { get; set; }
        public class DescribeServerlessJobsResponseBodyJobInfos : TeaModel {
            /// <summary>
            /// The properties of the array job.
            /// </summary>
            [NameInMap("ArrayProperties")]
            [Validation(Required=false)]
            public DescribeServerlessJobsResponseBodyJobInfosArrayProperties ArrayProperties { get; set; }
            public class DescribeServerlessJobsResponseBodyJobInfosArrayProperties : TeaModel {
                /// <summary>
                /// The end value of the array job index.
                /// </summary>
                [NameInMap("IndexEnd")]
                [Validation(Required=false)]
                public long? IndexEnd { get; set; }

                /// <summary>
                /// The starting value of the array job index.
                /// </summary>
                [NameInMap("IndexStart")]
                [Validation(Required=false)]
                public long? IndexStart { get; set; }

                /// <summary>
                /// The interval of the array job index.
                /// </summary>
                [NameInMap("IndexStep")]
                [Validation(Required=false)]
                public long? IndexStep { get; set; }

            }

            /// <summary>
            /// The information of the container groups that are used to run the serverless job.
            /// </summary>
            [NameInMap("ContainerGroups")]
            [Validation(Required=false)]
            public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroups> ContainerGroups { get; set; }
            public class DescribeServerlessJobsResponseBodyJobInfosContainerGroups : TeaModel {
                /// <summary>
                /// The ID of the container group.
                /// </summary>
                [NameInMap("ContainerGroupId")]
                [Validation(Required=false)]
                public string ContainerGroupId { get; set; }

                /// <summary>
                /// The name of the container group.
                /// </summary>
                [NameInMap("ContainerGroupName")]
                [Validation(Required=false)]
                public string ContainerGroupName { get; set; }

                /// <summary>
                /// The list of containers in the container group.
                /// </summary>
                [NameInMap("Containers")]
                [Validation(Required=false)]
                public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainers> Containers { get; set; }
                public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainers : TeaModel {
                    /// <summary>
                    /// The startup parameter of the container.
                    /// </summary>
                    [NameInMap("Args")]
                    [Validation(Required=false)]
                    public List<string> Args { get; set; }

                    /// <summary>
                    /// The startup command of the container.
                    /// </summary>
                    [NameInMap("Commands")]
                    [Validation(Required=false)]
                    public List<string> Commands { get; set; }

                    /// <summary>
                    /// The number of vCPUs.
                    /// </summary>
                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public float? Cpu { get; set; }

                    /// <summary>
                    /// The current status of the container.
                    /// </summary>
                    [NameInMap("CurrentState")]
                    [Validation(Required=false)]
                    public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersCurrentState CurrentState { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersCurrentState : TeaModel {
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
                        public long? ExitCode { get; set; }

                        /// <summary>
                        /// The time when the container stopped running.
                        /// </summary>
                        [NameInMap("FinishTime")]
                        [Validation(Required=false)]
                        public string FinishTime { get; set; }

                        /// <summary>
                        /// The information about the container status.
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
                        public long? Signal { get; set; }

                        /// <summary>
                        /// The time when the container started to run.
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// The status of the job. Valid values:
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
                    public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersEnvironmentVars> EnvironmentVars { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersEnvironmentVars : TeaModel {
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
                        /// The source of the environment variable value. This parameter can be used only when the variable value is not specified.
                        /// </summary>
                        [NameInMap("ValueFrom")]
                        [Validation(Required=false)]
                        public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersEnvironmentVarsValueFrom ValueFrom { get; set; }
                        public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersEnvironmentVarsValueFrom : TeaModel {
                            /// <summary>
                            /// The specified field.
                            /// </summary>
                            [NameInMap("FieldRef")]
                            [Validation(Required=false)]
                            public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersEnvironmentVarsValueFromFieldRef FieldRef { get; set; }
                            public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersEnvironmentVarsValueFromFieldRef : TeaModel {
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
                    /// The policy to pull images. Valid values:
                    /// 
                    /// *   Always: Each time instances are created, image pulling is performed.
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
                    public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersLivenessProbe LivenessProbe { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersLivenessProbe : TeaModel {
                        /// <summary>
                        /// The commands that are run.
                        /// </summary>
                        [NameInMap("Execs")]
                        [Validation(Required=false)]
                        public List<string> Execs { get; set; }

                        /// <summary>
                        /// The minimum number of consecutive failures that must occur for the probe to be considered as failed. Default value: 3.
                        /// </summary>
                        [NameInMap("FailureThreshold")]
                        [Validation(Required=false)]
                        public long? FailureThreshold { get; set; }

                        /// <summary>
                        /// The HTTP GET method that is used to check the container.
                        /// </summary>
                        [NameInMap("HttpGet")]
                        [Validation(Required=false)]
                        public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersLivenessProbeHttpGet HttpGet { get; set; }
                        public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersLivenessProbeHttpGet : TeaModel {
                            /// <summary>
                            /// The path to which HTTP GET requests are sent.
                            /// </summary>
                            [NameInMap("Path")]
                            [Validation(Required=false)]
                            public string Path { get; set; }

                            /// <summary>
                            /// The port to which HTTP GET requests are sent.
                            /// </summary>
                            [NameInMap("Port")]
                            [Validation(Required=false)]
                            public long? Port { get; set; }

                            /// <summary>
                            /// The protocol type of the HTTP GET requests.
                            /// </summary>
                            [NameInMap("Scheme")]
                            [Validation(Required=false)]
                            public string Scheme { get; set; }

                        }

                        /// <summary>
                        /// The number of seconds after the container is started and before a liveness probe is initiated.
                        /// </summary>
                        [NameInMap("InitialDelaySeconds")]
                        [Validation(Required=false)]
                        public long? InitialDelaySeconds { get; set; }

                        /// <summary>
                        /// The interval at which the probe is run. Unit: seconds. Default value: 10. Minimum value: 1.
                        /// </summary>
                        [NameInMap("PeriodSeconds")]
                        [Validation(Required=false)]
                        public long? PeriodSeconds { get; set; }

                        /// <summary>
                        /// The minimum number of consecutive successes that must occur for the check to be considered successful. Default value: 1. Set the value to 1.
                        /// </summary>
                        [NameInMap("SuccessThreshold")]
                        [Validation(Required=false)]
                        public long? SuccessThreshold { get; set; }

                        /// <summary>
                        /// The TCP socket method that is used to check the container.
                        /// </summary>
                        [NameInMap("TcpSocket")]
                        [Validation(Required=false)]
                        public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersLivenessProbeTcpSocket TcpSocket { get; set; }
                        public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersLivenessProbeTcpSocket : TeaModel {
                            /// <summary>
                            /// The name of the host.
                            /// </summary>
                            [NameInMap("Host")]
                            [Validation(Required=false)]
                            public string Host { get; set; }

                            /// <summary>
                            /// The port number.
                            /// </summary>
                            [NameInMap("Port")]
                            [Validation(Required=false)]
                            public long? Port { get; set; }

                        }

                        /// <summary>
                        /// The timeout period of the check. Default value: 1. Minimum value: 1.
                        /// </summary>
                        [NameInMap("TimeoutSeconds")]
                        [Validation(Required=false)]
                        public long? TimeoutSeconds { get; set; }

                    }

                    /// <summary>
                    /// The memory size of the instance. Unit: GiB.
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
                    /// The exposed ports and protocols of the container.
                    /// </summary>
                    [NameInMap("Ports")]
                    [Validation(Required=false)]
                    public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersPorts> Ports { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersPorts : TeaModel {
                        /// <summary>
                        /// The port number. Valid values: 1 to 65535.
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public long? Port { get; set; }

                        /// <summary>
                        /// The protocol.
                        /// </summary>
                        [NameInMap("Protocol")]
                        [Validation(Required=false)]
                        public string Protocol { get; set; }

                    }

                    /// <summary>
                    /// The previous status of the container.
                    /// </summary>
                    [NameInMap("PreviousState")]
                    [Validation(Required=false)]
                    public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersPreviousState PreviousState { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersPreviousState : TeaModel {
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
                        public long? ExitCode { get; set; }

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
                        public long? Signal { get; set; }

                        /// <summary>
                        /// The time when the container started to run.
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// The status of the container. Valid values:
                        /// 
                        /// *   Waiting: The container is being started.
                        /// *   Running: The container is running.
                        /// *   Terminated: The container terminates running.
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
                    public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersReadinessProbe ReadinessProbe { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersReadinessProbe : TeaModel {
                        /// <summary>
                        /// The commands that are run in the container when you use the command line interface (CLI) to perform health checks.
                        /// </summary>
                        [NameInMap("Execs")]
                        [Validation(Required=false)]
                        public List<string> Execs { get; set; }

                        /// <summary>
                        /// The minimum number of consecutive failures that must occur for the check to be considered as failed. Default value: 3.
                        /// </summary>
                        [NameInMap("FailureThreshold")]
                        [Validation(Required=false)]
                        public long? FailureThreshold { get; set; }

                        /// <summary>
                        /// The HTTP GET method that is used to check the container.
                        /// </summary>
                        [NameInMap("HttpGet")]
                        [Validation(Required=false)]
                        public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersReadinessProbeHttpGet HttpGet { get; set; }
                        public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersReadinessProbeHttpGet : TeaModel {
                            /// <summary>
                            /// The path to which HTTP GET requests are sent.
                            /// </summary>
                            [NameInMap("Path")]
                            [Validation(Required=false)]
                            public string Path { get; set; }

                            /// <summary>
                            /// The port to which the system sends an HTTP GET request for a health check.
                            /// </summary>
                            [NameInMap("Port")]
                            [Validation(Required=false)]
                            public long? Port { get; set; }

                            /// <summary>
                            /// The protocol type of the HTTP GET requests.
                            /// </summary>
                            [NameInMap("Scheme")]
                            [Validation(Required=false)]
                            public string Scheme { get; set; }

                        }

                        /// <summary>
                        /// The number of seconds after the container is started and before a liveness probe is initiated.
                        /// </summary>
                        [NameInMap("InitialDelaySeconds")]
                        [Validation(Required=false)]
                        public long? InitialDelaySeconds { get; set; }

                        /// <summary>
                        /// The interval at which the container is checked. Unit: seconds. Default value: 10. Minimum value: 1.
                        /// </summary>
                        [NameInMap("PeriodSeconds")]
                        [Validation(Required=false)]
                        public long? PeriodSeconds { get; set; }

                        /// <summary>
                        /// The minimum number of consecutive successes for a failed liveness probe to be considered successful. Default value: 1. Set the value to 1.
                        /// </summary>
                        [NameInMap("SuccessThreshold")]
                        [Validation(Required=false)]
                        public long? SuccessThreshold { get; set; }

                        /// <summary>
                        /// The TCP socket method that is used to check the container.
                        /// </summary>
                        [NameInMap("TcpSocket")]
                        [Validation(Required=false)]
                        public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersReadinessProbeTcpSocket TcpSocket { get; set; }
                        public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersReadinessProbeTcpSocket : TeaModel {
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
                            public long? Port { get; set; }

                        }

                        /// <summary>
                        /// The timeout period of the check. Default value: 1. Minimum value: 1.
                        /// </summary>
                        [NameInMap("TimeoutSeconds")]
                        [Validation(Required=false)]
                        public long? TimeoutSeconds { get; set; }

                    }

                    /// <summary>
                    /// Indicates whether the container passed the readiness probe.
                    /// </summary>
                    [NameInMap("Ready")]
                    [Validation(Required=false)]
                    public bool? Ready { get; set; }

                    /// <summary>
                    /// The number of times that the instance worker restarted.
                    /// </summary>
                    [NameInMap("RestartCount")]
                    [Validation(Required=false)]
                    public int? RestartCount { get; set; }

                    /// <summary>
                    /// The security context of the container.
                    /// </summary>
                    [NameInMap("SecurityContext")]
                    [Validation(Required=false)]
                    public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersSecurityContext SecurityContext { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersSecurityContext : TeaModel {
                        /// <summary>
                        /// The permissions specific to the processes in the container.
                        /// </summary>
                        [NameInMap("Capability")]
                        [Validation(Required=false)]
                        public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersSecurityContextCapability Capability { get; set; }
                        public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersSecurityContextCapability : TeaModel {
                            /// <summary>
                            /// The permissions specific to the processes in the container.
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
                        /// The user ID (UID) that is used to run the entry point of the container process.
                        /// </summary>
                        [NameInMap("RunAsUser")]
                        [Validation(Required=false)]
                        public long? RunAsUser { get; set; }

                    }

                    /// <summary>
                    /// Indicates whether the container allocates buffer resources to standard input streams when the container runs. If you do not specify this parameter, an end-of-file (EOF) error may occur when standard input streams in the container are read. Default value: false.
                    /// </summary>
                    [NameInMap("Stdin")]
                    [Validation(Required=false)]
                    public bool? Stdin { get; set; }

                    /// <summary>
                    /// Indicates whether the container runtime closes the stdin channel after the stdin channel has been opened by a single attach session. If stdin is true, the stdin stream remains open across multiple attach sessions. If StdinOnce is set to true, stdin is opened on container start, but remains empty until the first client attaches to stdin, and then remains open and receives data until the client disconnects. When the client disconnects, stdin is closed and remains closed until the container is restarted.
                    /// </summary>
                    [NameInMap("StdinOnce")]
                    [Validation(Required=false)]
                    public bool? StdinOnce { get; set; }

                    /// <summary>
                    /// Indicates whether interaction is enabled. Default value: false. If the value of the Command parameter is /bin/bash, the value of this parameter must be set to true.
                    /// </summary>
                    [NameInMap("Tty")]
                    [Validation(Required=false)]
                    public bool? Tty { get; set; }

                    /// <summary>
                    /// Information about the mounted volumes.
                    /// </summary>
                    [NameInMap("VolumeMounts")]
                    [Validation(Required=false)]
                    public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersVolumeMounts> VolumeMounts { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersVolumeMounts : TeaModel {
                        /// <summary>
                        /// The directory to which the volume is mounted. Data under this directory is overwritten by the data on the volume.
                        /// </summary>
                        [NameInMap("MountPath")]
                        [Validation(Required=false)]
                        public string MountPath { get; set; }

                        /// <summary>
                        /// The mount propagation settings of the volume. Mount propagation allows you to share volumes that are mounted on a container with other containers in the same pod or other pods on the same node. Valid values:
                        /// 
                        /// *   None: The volume mount does not receive subsequent mounts that are mounted to the volume or the subdirectories of the volume.
                        /// *   HostToCotainer: The volume mount receives all subsequent mounts that are mounted to the volume or the subdirectories of the volume.
                        /// *   Bidirectional: This value is similar to HostToCotainer. The volume mount receives all subsequent mounts that are mounted to the volume or the subdirectories of the volume. All volume mounts that are mounted by the container are propagated back to the instance and all containers of all pods that use the same volume.
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
                        /// Indicates whether the volumes are read-only.
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
                    /// The working directory.
                    /// </summary>
                    [NameInMap("WorkingDir")]
                    [Validation(Required=false)]
                    public string WorkingDir { get; set; }

                }

                /// <summary>
                /// The number of vCPUs that are allocated to the container.
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                /// <summary>
                /// The time when the instance is created. The time follows the RFC 3339 standard and must be in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The discount.
                /// </summary>
                [NameInMap("Discount")]
                [Validation(Required=false)]
                public long? Discount { get; set; }

                /// <summary>
                /// The Domain Name System (DNS) settings.
                /// </summary>
                [NameInMap("DnsConfig")]
                [Validation(Required=false)]
                public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsDnsConfig DnsConfig { get; set; }
                public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsDnsConfig : TeaModel {
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
                    public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroupsDnsConfigOptions> Options { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsDnsConfigOptions : TeaModel {
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
                    /// The search domains of the DNS server.
                    /// </summary>
                    [NameInMap("Searches")]
                    [Validation(Required=false)]
                    public List<string> Searches { get; set; }

                }

                /// <summary>
                /// The security context of the container group.
                /// </summary>
                [NameInMap("EciSecurityContext")]
                [Validation(Required=false)]
                public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsEciSecurityContext EciSecurityContext { get; set; }
                public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsEciSecurityContext : TeaModel {
                    /// <summary>
                    /// The Sysctl parameters.
                    /// </summary>
                    [NameInMap("Sysctls")]
                    [Validation(Required=false)]
                    public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroupsEciSecurityContextSysctls> Sysctls { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsEciSecurityContextSysctls : TeaModel {
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
                public long? EphemeralStorage { get; set; }

                /// <summary>
                /// The event information. Up to 50 events can be returned.
                /// </summary>
                [NameInMap("Events")]
                [Validation(Required=false)]
                public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroupsEvents> Events { get; set; }
                public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsEvents : TeaModel {
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
                    /// The name of the category to which the event belongs.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The name of the event.
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
                /// The time when the instance failed to run due to overdue payments. The time follows the RFC 3339 standard and must be in UTC.
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
                public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroupsHostAliases> HostAliases { get; set; }
                public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsHostAliases : TeaModel {
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
                /// The init containers.
                /// </summary>
                [NameInMap("InitContainers")]
                [Validation(Required=false)]
                public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainers> InitContainers { get; set; }
                public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainers : TeaModel {
                    /// <summary>
                    /// The startup parameters.
                    /// </summary>
                    [NameInMap("Args")]
                    [Validation(Required=false)]
                    public List<string> Args { get; set; }

                    /// <summary>
                    /// The startup command.
                    /// </summary>
                    [NameInMap("Command")]
                    [Validation(Required=false)]
                    public List<string> Command { get; set; }

                    /// <summary>
                    /// The number of vCPUs.
                    /// </summary>
                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public long? Cpu { get; set; }

                    /// <summary>
                    /// The current status of the container.
                    /// </summary>
                    [NameInMap("CurrentState")]
                    [Validation(Required=false)]
                    public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersCurrentState CurrentState { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersCurrentState : TeaModel {
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
                        public long? ExitCode { get; set; }

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
                        public long? Signal { get; set; }

                        /// <summary>
                        /// The time when the container started to run.
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// The status of the container. Valid values:
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
                    public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersEnvironmentVars> EnvironmentVars { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersEnvironmentVars : TeaModel {
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
                        /// The source of the environment variable value. This parameter can be used only when the variable value is not specified.
                        /// </summary>
                        [NameInMap("ValueFrom")]
                        [Validation(Required=false)]
                        public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersEnvironmentVarsValueFrom ValueFrom { get; set; }
                        public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersEnvironmentVarsValueFrom : TeaModel {
                            /// <summary>
                            /// The specified field.
                            /// </summary>
                            [NameInMap("FieldRef")]
                            [Validation(Required=false)]
                            public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersEnvironmentVarsValueFromFieldRef FieldRef { get; set; }
                            public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersEnvironmentVarsValueFromFieldRef : TeaModel {
                                /// <summary>
                                /// The path of the field in the specified version. Set the value to `status.podIP`.
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
                    public long? Gpu { get; set; }

                    /// <summary>
                    /// The image.
                    /// </summary>
                    [NameInMap("Image")]
                    [Validation(Required=false)]
                    public string Image { get; set; }

                    /// <summary>
                    /// The policy to pull images.
                    /// </summary>
                    [NameInMap("ImagePullPolicy")]
                    [Validation(Required=false)]
                    public string ImagePullPolicy { get; set; }

                    /// <summary>
                    /// The size of memory that is allocated to the init container. Unit: GiB.
                    /// </summary>
                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public long? Memory { get; set; }

                    /// <summary>
                    /// The container name.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The exposed ports and protocols of the container.
                    /// </summary>
                    [NameInMap("Ports")]
                    [Validation(Required=false)]
                    public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersPorts> Ports { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersPorts : TeaModel {
                        /// <summary>
                        /// The port number. Valid values: 1 to 65535.
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public long? Port { get; set; }

                        /// <summary>
                        /// The protocol.
                        /// </summary>
                        [NameInMap("Protocol")]
                        [Validation(Required=false)]
                        public string Protocol { get; set; }

                    }

                    /// <summary>
                    /// The previous status of the container.
                    /// </summary>
                    [NameInMap("PreviousState")]
                    [Validation(Required=false)]
                    public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersPreviousState PreviousState { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersPreviousState : TeaModel {
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
                        public long? ExitCode { get; set; }

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
                        public long? Signal { get; set; }

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
                    /// The number of times that the instance worker restarted.
                    /// </summary>
                    [NameInMap("RestartCount")]
                    [Validation(Required=false)]
                    public long? RestartCount { get; set; }

                    /// <summary>
                    /// The security context of the container.
                    /// </summary>
                    [NameInMap("SecurityContext")]
                    [Validation(Required=false)]
                    public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersSecurityContext SecurityContext { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersSecurityContext : TeaModel {
                        /// <summary>
                        /// The permissions specific to the processes in the container.
                        /// </summary>
                        [NameInMap("Capability")]
                        [Validation(Required=false)]
                        public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersSecurityContextCapability Capability { get; set; }
                        public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersSecurityContextCapability : TeaModel {
                            /// <summary>
                            /// The permissions specific to the processes in the container.
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
                    public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersVolumeMounts> VolumeMounts { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersVolumeMounts : TeaModel {
                        /// <summary>
                        /// The directory to which the volume is mounted. Data under this directory is overwritten by the data on the volume.
                        /// </summary>
                        [NameInMap("MountPath")]
                        [Validation(Required=false)]
                        public string MountPath { get; set; }

                        /// <summary>
                        /// The mount propagation settings of the volume. Mount propagation allows you to share volumes that are mounted on a container with other containers in the same pod or other pods on the same node. Valid values:
                        /// 
                        /// *   None: The volume mount does not receive subsequent mounts that are mounted to the volume or the subdirectories of the volume.
                        /// *   HostToCotainer: The volume mount receives all subsequent mounts that are mounted to the volume or the subdirectories of the volume.
                        /// *   Bidirectional: This value is similar to HostToCotainer. The volume mount receives all subsequent mounts that are mounted to the volume or the subdirectories of the volume. All volume mounts that are mounted by the container are propagated back to the instance and all containers of all pods that use the same volume.
                        /// 
                        /// Default value: None.
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
                        /// Default value: False.
                        /// </summary>
                        [NameInMap("ReadOnly")]
                        [Validation(Required=false)]
                        public bool? ReadOnly { get; set; }

                    }

                    /// <summary>
                    /// The working directory.
                    /// </summary>
                    [NameInMap("WorkingDir")]
                    [Validation(Required=false)]
                    public string WorkingDir { get; set; }

                }

                /// <summary>
                /// The instance type of the Elastic Compute Service (ECS) instance.
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
                /// The ID of the region in which the instance resides.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the resource group to which the cluster belongs. If you do not specify a resource group when you create an elastic container instance, the system automatically adds the instance to the default resource group in your account.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The instance restart policy. Valid values:
                /// 
                /// *   Always: Always restarts the instance if a container in the instance exits upon termination.
                /// *   Never: Never restarts the instance if a container in the instance exits upon termination.
                /// *   OnFailure: Restarts the instance when the last start failed.
                /// </summary>
                [NameInMap("RestartPolicy")]
                [Validation(Required=false)]
                public string RestartPolicy { get; set; }

                /// <summary>
                /// The ID of the security group.
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// The maximum hourly price for the preemptible instance.
                /// 
                /// This parameter is returned only if you set the SpotStrategy parameter to SpotWithPriceLimit.
                /// </summary>
                [NameInMap("SpotPriceLimit")]
                [Validation(Required=false)]
                public float? SpotPriceLimit { get; set; }

                /// <summary>
                /// The bidding policy of the instance. Valid values:
                /// 
                /// *   NoSpot: The instance is a regular pay-as-you-go instance.
                /// *   SpotWithPriceLimit: The instance is a preemptible instance that has a user-defined maximum hourly price.
                /// *   SpotAsPriceGo: The instance is a preemptible instance for which the market price at the time of purchase is automatically used as the bidding price.
                /// </summary>
                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

                /// <summary>
                /// The status of the instance. Valid values:
                /// 
                /// *   Pending: The instance is being started.
                /// *   Running: The instance is running.
                /// *   Succeeded: The instance runs successfully.
                /// *   Failed: The instance fails to run.
                /// *   Scheduling: The instance is being created.
                /// *   ScheduleFailed: The instance fails to be created.
                /// *   Restarting: The instance is being restarted.
                /// *   Updating: The instance is being updated.
                /// *   Terminating: The instance is being terminated.
                /// *   Expired: The instance expires.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The time when all containers exited on success. The time follows the RFC 3339 standard and must be in UTC.
                /// </summary>
                [NameInMap("SucceededTime")]
                [Validation(Required=false)]
                public string SucceededTime { get; set; }

                /// <summary>
                /// The tags of the instances.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroupsTags> Tags { get; set; }
                public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsTags : TeaModel {
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
                /// The vSwitch ID.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The information about volumes.
                /// </summary>
                [NameInMap("Volumes")]
                [Validation(Required=false)]
                public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroupsVolumes> Volumes { get; set; }
                public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsVolumes : TeaModel {
                    /// <summary>
                    /// The paths to configuration files.
                    /// </summary>
                    [NameInMap("ConfigFileVolumeConfigFileToPaths")]
                    [Validation(Required=false)]
                    public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroupsVolumesConfigFileVolumeConfigFileToPaths> ConfigFileVolumeConfigFileToPaths { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsVolumesConfigFileVolumeConfigFileToPaths : TeaModel {
                        /// <summary>
                        /// The content of the configuration file. Maximum size: 32 KB.
                        /// </summary>
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// The relative path to the configuration file.
                        /// </summary>
                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                    }

                    /// <summary>
                    /// The ID of the disk volume if you set Type to DiskVolume.
                    /// </summary>
                    [NameInMap("DiskVolumeDiskId")]
                    [Validation(Required=false)]
                    public string DiskVolumeDiskId { get; set; }

                    /// <summary>
                    /// The type of the volume.
                    /// </summary>
                    [NameInMap("DiskVolumeFsType")]
                    [Validation(Required=false)]
                    public string DiskVolumeFsType { get; set; }

                    /// <summary>
                    /// The storage media for the emptyDir volume. This parameter is empty by default, which indicates that the node file system is used as the storage media. Valid values:
                    /// 
                    /// *   Memory: uses memory as the storage media.
                    /// *   LocalRaid0: forms local disks into RAID 0. This value is valid only if an elastic container instance that has local disks mounted is created. For more information, see [Create an elastic container instance that has local disks mounted](~~114664~~).
                    /// </summary>
                    [NameInMap("EmptyDirVolumeMedium")]
                    [Validation(Required=false)]
                    public string EmptyDirVolumeMedium { get; set; }

                    /// <summary>
                    /// The storage size of the emptyDir volume. If you specify this parameter, include the unit in the value. We recommend that you use Gi or Mi.
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
                    /// The file system type when you set the Type parameter to FlexVolume. The default value is determined by the script of the FlexVolume plug-in.
                    /// </summary>
                    [NameInMap("FlexVolumeFsType")]
                    [Validation(Required=false)]
                    public string FlexVolumeFsType { get; set; }

                    /// <summary>
                    /// The FlexVolume options.
                    /// </summary>
                    [NameInMap("FlexVolumeOptions")]
                    [Validation(Required=false)]
                    public string FlexVolumeOptions { get; set; }

                    /// <summary>
                    /// The path of the Network File System (NFS) volume.
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
                    /// The endpoint of the server if you set Type to NFSVolume.
                    /// </summary>
                    [NameInMap("NFSVolumeServer")]
                    [Validation(Required=false)]
                    public string NFSVolumeServer { get; set; }

                    /// <summary>
                    /// The name of the volume.
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
                /// The ID of the virtual private cloud (VPC) to which the elastic container instance belongs.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The ID of the zone in which the elastic container instance is deployed.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// The time when the serverless job ended.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// Indicates whether the job is an array job.
            /// </summary>
            [NameInMap("IsArrayJob")]
            [Validation(Required=false)]
            public bool? IsArrayJob { get; set; }

            /// <summary>
            /// The ID of the serverless job or the subtask (array job).
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// The name of the serverless job.
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// The time when the serverless job is last modified.
            /// </summary>
            [NameInMap("LastModifyTime")]
            [Validation(Required=false)]
            public long? LastModifyTime { get; set; }

            /// <summary>
            /// The scheduling priority of the serverless job.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            /// <summary>
            /// The name of the queue in which the serverless job is run.
            /// </summary>
            [NameInMap("Queue")]
            [Validation(Required=false)]
            public string Queue { get; set; }

            /// <summary>
            /// The time when the serverless job started.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// The status of the serverless job. Valid values:
            /// 
            /// *   Pending
            /// *   Initing
            /// *   Running
            /// *   Succeeded
            /// *   Canceled
            /// *   Failed
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The time when the serverless job is submitted.
            /// </summary>
            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public long? SubmitTime { get; set; }

            /// <summary>
            /// The username that is used to run the serverless job.
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
