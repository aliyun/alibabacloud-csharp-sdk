// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeContainerGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the queried elastic container instances.</para>
        /// </summary>
        [NameInMap("ContainerGroups")]
        [Validation(Required=false)]
        public List<DescribeContainerGroupsResponseBodyContainerGroups> ContainerGroups { get; set; }
        public class DescribeContainerGroupsResponseBodyContainerGroups : TeaModel {
            /// <summary>
            /// <para>The computing power type of the elastic container instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>economy: economic computing power.</description></item>
            /// <item><description>general: general-purpose computing power.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>economy</para>
            /// </summary>
            [NameInMap("ComputeCategory")]
            [Validation(Required=false)]
            public string ComputeCategory { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eci-bp1jrgfqqy54kg5hc****</para>
            /// </summary>
            [NameInMap("ContainerGroupId")]
            [Validation(Required=false)]
            public string ContainerGroupId { get; set; }

            /// <summary>
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ContainerGroupName")]
            [Validation(Required=false)]
            public string ContainerGroupName { get; set; }

            /// <summary>
            /// <para>The information about containers in the elastic container instance.</para>
            /// </summary>
            [NameInMap("Containers")]
            [Validation(Required=false)]
            public List<DescribeContainerGroupsResponseBodyContainerGroupsContainers> Containers { get; set; }
            public class DescribeContainerGroupsResponseBodyContainerGroupsContainers : TeaModel {
                /// <summary>
                /// <para>The arguments that are passed to the startup commands of the container.</para>
                /// </summary>
                [NameInMap("Args")]
                [Validation(Required=false)]
                public List<string> Args { get; set; }

                /// <summary>
                /// <para>The startup commands of the container.</para>
                /// </summary>
                [NameInMap("Commands")]
                [Validation(Required=false)]
                public List<string> Commands { get; set; }

                /// <summary>
                /// <para>The number of vCPUs that are allocated to the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.0</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                /// <summary>
                /// <para>The current container status.</para>
                /// </summary>
                [NameInMap("CurrentState")]
                [Validation(Required=false)]
                public DescribeContainerGroupsResponseBodyContainerGroupsContainersCurrentState CurrentState { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsContainersCurrentState : TeaModel {
                    /// <summary>
                    /// <para>The details of the container status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>working</para>
                    /// </summary>
                    [NameInMap("DetailStatus")]
                    [Validation(Required=false)]
                    public string DetailStatus { get; set; }

                    /// <summary>
                    /// <para>The exit code of the container.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ExitCode")]
                    [Validation(Required=false)]
                    public int? ExitCode { get; set; }

                    /// <summary>
                    /// <para>The time when the container stopped running.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2018-08-02T15:00:00Z</para>
                    /// </summary>
                    [NameInMap("FinishTime")]
                    [Validation(Required=false)]
                    public string FinishTime { get; set; }

                    /// <summary>
                    /// <para>The message about the container status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Back-off 5m0s restarting failed container=test pod=test_eci-xxx(xxx)</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// <para>The reason why the container is in this status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Started</para>
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    /// <summary>
                    /// <para>The code of the container status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Signal")]
                    [Validation(Required=false)]
                    public int? Signal { get; set; }

                    /// <summary>
                    /// <para>The time when the container started to run.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2019-12-19T12:05:02Z</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <para>The container status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Waiting</description></item>
                    /// <item><description>Running</description></item>
                    /// <item><description>Terminated</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Terminated</para>
                    /// </summary>
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                }

                /// <summary>
                /// <para>The environment variables of the container.</para>
                /// </summary>
                [NameInMap("EnvironmentVars")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupsResponseBodyContainerGroupsContainersEnvironmentVars> EnvironmentVars { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsContainersEnvironmentVars : TeaModel {
                    /// <summary>
                    /// <para>The name of the environment variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PATH</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of the environment variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/usr/bin/</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    /// <summary>
                    /// <para>The source of the environment variable value. This parameter has a value only when the Value parameter is left empty.</para>
                    /// </summary>
                    [NameInMap("ValueFrom")]
                    [Validation(Required=false)]
                    public DescribeContainerGroupsResponseBodyContainerGroupsContainersEnvironmentVarsValueFrom ValueFrom { get; set; }
                    public class DescribeContainerGroupsResponseBodyContainerGroupsContainersEnvironmentVarsValueFrom : TeaModel {
                        /// <summary>
                        /// <para>The specified field.</para>
                        /// </summary>
                        [NameInMap("FieldRef")]
                        [Validation(Required=false)]
                        public DescribeContainerGroupsResponseBodyContainerGroupsContainersEnvironmentVarsValueFromFieldRef FieldRef { get; set; }
                        public class DescribeContainerGroupsResponseBodyContainerGroupsContainersEnvironmentVarsValueFromFieldRef : TeaModel {
                            /// <summary>
                            /// <para>The path of the field.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>status.podIP</para>
                            /// </summary>
                            [NameInMap("FieldPath")]
                            [Validation(Required=false)]
                            public string FieldPath { get; set; }

                        }

                    }

                }

                /// <summary>
                /// <para>The number of GPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Gpu")]
                [Validation(Required=false)]
                public int? Gpu { get; set; }

                /// <summary>
                /// <para>The image in the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql</para>
                /// </summary>
                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// <para>The image pulling policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Always: Each time the instance is updated, image pulling is performed.</description></item>
                /// <item><description>IfNotPresent: On-premises images are preferentially used. If no on-premises images are available, image pulling is performed.</description></item>
                /// <item><description>Never: On-premises images are always used. Image pulling is not performed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Always</para>
                /// </summary>
                [NameInMap("ImagePullPolicy")]
                [Validation(Required=false)]
                public string ImagePullPolicy { get; set; }

                /// <summary>
                /// <para>The liveness probe of the container.</para>
                /// </summary>
                [NameInMap("LivenessProbe")]
                [Validation(Required=false)]
                public DescribeContainerGroupsResponseBodyContainerGroupsContainersLivenessProbe LivenessProbe { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsContainersLivenessProbe : TeaModel {
                    /// <summary>
                    /// <para>The commands that are used to check the containers.</para>
                    /// </summary>
                    [NameInMap("Execs")]
                    [Validation(Required=false)]
                    public List<string> Execs { get; set; }

                    /// <summary>
                    /// <para>The minimum number of consecutive failures that must occur for the check to be considered failed. Default value: 3.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("FailureThreshold")]
                    [Validation(Required=false)]
                    public int? FailureThreshold { get; set; }

                    /// <summary>
                    /// <para>The HTTP GET method that is used to check the container.</para>
                    /// </summary>
                    [NameInMap("HttpGet")]
                    [Validation(Required=false)]
                    public DescribeContainerGroupsResponseBodyContainerGroupsContainersLivenessProbeHttpGet HttpGet { get; set; }
                    public class DescribeContainerGroupsResponseBodyContainerGroupsContainersLivenessProbeHttpGet : TeaModel {
                        /// <summary>
                        /// <para>The path to which the system sends an HTTP GET request for a health check.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/usr/nginx/</para>
                        /// </summary>
                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                        /// <summary>
                        /// <para>The port to which the system sends an HTTP GET request for a health check.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>80</para>
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        /// <summary>
                        /// <para>The protocol type supported by the method. Valid values: HTTP and HTTPS.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HTTP</para>
                        /// </summary>
                        [NameInMap("Scheme")]
                        [Validation(Required=false)]
                        public string Scheme { get; set; }

                    }

                    /// <summary>
                    /// <para>The number of seconds between the time when the startup of the container ends and the time when the probe starts.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("InitialDelaySeconds")]
                    [Validation(Required=false)]
                    public int? InitialDelaySeconds { get; set; }

                    /// <summary>
                    /// <para>The interval at which the health check is performed. Default value: 10. Minimum value: 1. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("PeriodSeconds")]
                    [Validation(Required=false)]
                    public int? PeriodSeconds { get; set; }

                    /// <summary>
                    /// <para>The minimum number of consecutive successes that must occur for the check to be considered successful. Default value: 1. The value must be 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("SuccessThreshold")]
                    [Validation(Required=false)]
                    public int? SuccessThreshold { get; set; }

                    /// <summary>
                    /// <para>The TCP socket method that is used to check the container.</para>
                    /// </summary>
                    [NameInMap("TcpSocket")]
                    [Validation(Required=false)]
                    public DescribeContainerGroupsResponseBodyContainerGroupsContainersLivenessProbeTcpSocket TcpSocket { get; set; }
                    public class DescribeContainerGroupsResponseBodyContainerGroupsContainersLivenessProbeTcpSocket : TeaModel {
                        /// <summary>
                        /// <para>The hostname.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1.2.3.4</para>
                        /// </summary>
                        [NameInMap("Host")]
                        [Validation(Required=false)]
                        public string Host { get; set; }

                        /// <summary>
                        /// <para>The port number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>80</para>
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                    }

                    /// <summary>
                    /// <para>The timeout period of the check. Default value: 1. Minimum value: 1. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("TimeoutSeconds")]
                    [Validation(Required=false)]
                    public int? TimeoutSeconds { get; set; }

                }

                /// <summary>
                /// <para>The memory size of the container. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.0</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public float? Memory { get; set; }

                /// <summary>
                /// <para>The name of the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nginx</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The exposed port and protocol of the container.</para>
                /// </summary>
                [NameInMap("Ports")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupsResponseBodyContainerGroupsContainersPorts> Ports { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsContainersPorts : TeaModel {
                    /// <summary>
                    /// <para>The port number. Valid values: 1 to 65535.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8080</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The protocol type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TCP</para>
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                }

                /// <summary>
                /// <para>The previous state of the container.</para>
                /// </summary>
                [NameInMap("PreviousState")]
                [Validation(Required=false)]
                public DescribeContainerGroupsResponseBodyContainerGroupsContainersPreviousState PreviousState { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsContainersPreviousState : TeaModel {
                    /// <summary>
                    /// <para>The details of the container status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>working</para>
                    /// </summary>
                    [NameInMap("DetailStatus")]
                    [Validation(Required=false)]
                    public string DetailStatus { get; set; }

                    /// <summary>
                    /// <para>The exit code of the container.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ExitCode")]
                    [Validation(Required=false)]
                    public int? ExitCode { get; set; }

                    /// <summary>
                    /// <para>The time when the container stopped running.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2018-08-02T15:00:00Z</para>
                    /// </summary>
                    [NameInMap("FinishTime")]
                    [Validation(Required=false)]
                    public string FinishTime { get; set; }

                    /// <summary>
                    /// <para>The message about the container status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Back-off 5m0s restarting failed container=test pod=test_eci-xxx(xxx)</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// <para>The reason why the container is in this status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Completed</para>
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    /// <summary>
                    /// <para>The code of the container status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Signal")]
                    [Validation(Required=false)]
                    public int? Signal { get; set; }

                    /// <summary>
                    /// <para>The time when the container started to run.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2018-08-02T15:00:00Z</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <para>The container status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Waiting: The container is being started.</description></item>
                    /// <item><description>Running: The container is running.</description></item>
                    /// <item><description>Terminated: The container stops running.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Terminated</para>
                    /// </summary>
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                }

                /// <summary>
                /// <para>The readiness probe that is used to check whether the container is ready to serve a request.</para>
                /// </summary>
                [NameInMap("ReadinessProbe")]
                [Validation(Required=false)]
                public DescribeContainerGroupsResponseBodyContainerGroupsContainersReadinessProbe ReadinessProbe { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsContainersReadinessProbe : TeaModel {
                    /// <summary>
                    /// <para>The commands that are run in the container when you use a CLI to perform health checks.</para>
                    /// </summary>
                    [NameInMap("Execs")]
                    [Validation(Required=false)]
                    public List<string> Execs { get; set; }

                    /// <summary>
                    /// <para>The minimum number of consecutive failures that must occur for the check to be considered failed. Default value: 3.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("FailureThreshold")]
                    [Validation(Required=false)]
                    public int? FailureThreshold { get; set; }

                    /// <summary>
                    /// <para>The HTTP GET method that is used to check the container.</para>
                    /// </summary>
                    [NameInMap("HttpGet")]
                    [Validation(Required=false)]
                    public DescribeContainerGroupsResponseBodyContainerGroupsContainersReadinessProbeHttpGet HttpGet { get; set; }
                    public class DescribeContainerGroupsResponseBodyContainerGroupsContainersReadinessProbeHttpGet : TeaModel {
                        /// <summary>
                        /// <para>The path to which the system sends an HTTP GET request for a health check.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/usr/local</para>
                        /// </summary>
                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                        /// <summary>
                        /// <para>The port to which the system sends an HTTP GET request for a health check.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>8080</para>
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        /// <summary>
                        /// <para>The protocol type supported by the method. Valid values: HTTP and HTTPS.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HTTP</para>
                        /// </summary>
                        [NameInMap("Scheme")]
                        [Validation(Required=false)]
                        public string Scheme { get; set; }

                    }

                    /// <summary>
                    /// <para>The number of seconds between the time when the startup of the container ends and the time when the probe starts.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("InitialDelaySeconds")]
                    [Validation(Required=false)]
                    public int? InitialDelaySeconds { get; set; }

                    /// <summary>
                    /// <para>The interval at which the health check is performed. Default value: 10. Minimum value: 1. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("PeriodSeconds")]
                    [Validation(Required=false)]
                    public int? PeriodSeconds { get; set; }

                    /// <summary>
                    /// <para>The minimum number of consecutive successes that must occur for the check to be considered successful. Default value: 1. The value must be 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("SuccessThreshold")]
                    [Validation(Required=false)]
                    public int? SuccessThreshold { get; set; }

                    /// <summary>
                    /// <para>The TCP socket method that is used to check the container.</para>
                    /// </summary>
                    [NameInMap("TcpSocket")]
                    [Validation(Required=false)]
                    public DescribeContainerGroupsResponseBodyContainerGroupsContainersReadinessProbeTcpSocket TcpSocket { get; set; }
                    public class DescribeContainerGroupsResponseBodyContainerGroupsContainersReadinessProbeTcpSocket : TeaModel {
                        /// <summary>
                        /// <para>The hostname.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1.2.3.4</para>
                        /// </summary>
                        [NameInMap("Host")]
                        [Validation(Required=false)]
                        public string Host { get; set; }

                        /// <summary>
                        /// <para>The port number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>8888</para>
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                    }

                    /// <summary>
                    /// <para>The timeout period of the check. Default value: 1. Minimum value: 1. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TimeoutSeconds")]
                    [Validation(Required=false)]
                    public int? TimeoutSeconds { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the container passed the readiness probe.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Ready")]
                [Validation(Required=false)]
                public bool? Ready { get; set; }

                /// <summary>
                /// <para>The number of times that the container restarted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RestartCount")]
                [Validation(Required=false)]
                public int? RestartCount { get; set; }

                /// <summary>
                /// <para>The security context of the elastic container instance.</para>
                /// </summary>
                [NameInMap("SecurityContext")]
                [Validation(Required=false)]
                public DescribeContainerGroupsResponseBodyContainerGroupsContainersSecurityContext SecurityContext { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsContainersSecurityContext : TeaModel {
                    /// <summary>
                    /// <para>The permissions specific to the processes in the container.</para>
                    /// </summary>
                    [NameInMap("Capability")]
                    [Validation(Required=false)]
                    public DescribeContainerGroupsResponseBodyContainerGroupsContainersSecurityContextCapability Capability { get; set; }
                    public class DescribeContainerGroupsResponseBodyContainerGroupsContainersSecurityContextCapability : TeaModel {
                        /// <summary>
                        /// <para>The permissions specific to the process in the container.</para>
                        /// </summary>
                        [NameInMap("Adds")]
                        [Validation(Required=false)]
                        public List<string> Adds { get; set; }

                    }

                    /// <summary>
                    /// <para>Indicates whether permissions on the root file system are read-only. Valid value: true.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("ReadOnlyRootFilesystem")]
                    [Validation(Required=false)]
                    public bool? ReadOnlyRootFilesystem { get; set; }

                    /// <summary>
                    /// <para>The user ID (UID) that is used to run the container.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("RunAsUser")]
                    [Validation(Required=false)]
                    public long? RunAsUser { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the container allocates buffer resources to standard input streams when the container is running. If you do not specify this parameter, an end-of-file (EOF) error may occur when standard input streams in the container are read. Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Stdin")]
                [Validation(Required=false)]
                public bool? Stdin { get; set; }

                /// <summary>
                /// <para>Indicates whether standard input streams are disconnected after a client is disconnected. If Stdin is set to true, standard input streams remain connected among multiple sessions. If StdinOnce is set to true, standard input streams are connected after the container is started, and remain idle until a client is connected to receive data. After the client is disconnected, streams are also disconnected, and remain disconnected until the container restarts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("StdinOnce")]
                [Validation(Required=false)]
                public bool? StdinOnce { get; set; }

                /// <summary>
                /// <para>Indicates whether interaction is enabled. Default value: false. If the value of the Command parameter is <c>/bin/bash</c>, the value of this parameter is true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Tty")]
                [Validation(Required=false)]
                public bool? Tty { get; set; }

                /// <summary>
                /// <para>Information about the mounted volumes.</para>
                /// </summary>
                [NameInMap("VolumeMounts")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupsResponseBodyContainerGroupsContainersVolumeMounts> VolumeMounts { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsContainersVolumeMounts : TeaModel {
                    /// <summary>
                    /// <para>The directory of the volume that is mounted to the container. The data in this directory is overwritten by the data on the volume.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/usr/share/</para>
                    /// </summary>
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                    /// <summary>
                    /// <para>The mount propagation setting of the volume. Mount propagation allows volumes that are mounted on one container to be shared with other containers in the same pod, or even with other pods on the same node. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>None: The volume mount does not receive subsequent mounts that are performed on this volume or on the subdirectories of this volume.</description></item>
                    /// <item><description>HostToCotainer: The volume mount receives subsequent mounts that are performed on this volume or on the subdirectories of this volume.</description></item>
                    /// <item><description>Bidirectional: This value is similar to HostToCotainer. The volume mount receives subsequent mounts that are performed on this volume or on the subdirectories of this volume. In addition, all volume mounts that are performed on the container are propagated back to the host and all containers of all pods that use the same volume.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>None</para>
                    /// </summary>
                    [NameInMap("MountPropagation")]
                    [Validation(Required=false)]
                    public string MountPropagation { get; set; }

                    /// <summary>
                    /// <para>The volume name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test-empty</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the volume is read-only.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("ReadOnly")]
                    [Validation(Required=false)]
                    public bool? ReadOnly { get; set; }

                    /// <summary>
                    /// <para>The subdirectory of the volume. You can use this parameter to mount the same volume to different subdirectories of the container.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/usr/sub</para>
                    /// </summary>
                    [NameInMap("SubPath")]
                    [Validation(Required=false)]
                    public string SubPath { get; set; }

                }

                /// <summary>
                /// <para>The working directory of the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/local/nginx</para>
                /// </summary>
                [NameInMap("WorkingDir")]
                [Validation(Required=false)]
                public string WorkingDir { get; set; }

            }

            /// <summary>
            /// <para>The number of vCPUs that are allocated to the elastic container instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public float? Cpu { get; set; }

            /// <summary>
            /// <para>The time when the instance was created. The time follows the RFC 3339 standard. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-08-02T15:00:00Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The discount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("Discount")]
            [Validation(Required=false)]
            public int? Discount { get; set; }

            /// <summary>
            /// <para>The Domain Name System (DNS) settings.</para>
            /// </summary>
            [NameInMap("DnsConfig")]
            [Validation(Required=false)]
            public DescribeContainerGroupsResponseBodyContainerGroupsDnsConfig DnsConfig { get; set; }
            public class DescribeContainerGroupsResponseBodyContainerGroupsDnsConfig : TeaModel {
                /// <summary>
                /// <para>The IP addresses of DNS servers.</para>
                /// </summary>
                [NameInMap("NameServers")]
                [Validation(Required=false)]
                public List<string> NameServers { get; set; }

                /// <summary>
                /// <para>The options. Each option is a name-value pair. The value in the name-value pair is optional.</para>
                /// </summary>
                [NameInMap("Options")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupsResponseBodyContainerGroupsDnsConfigOptions> Options { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsDnsConfigOptions : TeaModel {
                    /// <summary>
                    /// <para>The variable name of the option.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>name</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The variable value of the option.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>value</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The search domains of DNS servers.</para>
                /// </summary>
                [NameInMap("Searches")]
                [Validation(Required=false)]
                public List<string> Searches { get; set; }

            }

            /// <summary>
            /// <para>The Domain Name System (DNS) policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>None: uses the DNS that is specified by DnsConfig.</description></item>
            /// <item><description>Default: uses the DNS that is specified for the runtime environment.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("DnsPolicy")]
            [Validation(Required=false)]
            public string DnsPolicy { get; set; }

            /// <summary>
            /// <para>The security context of the elastic container instance.</para>
            /// </summary>
            [NameInMap("EciSecurityContext")]
            [Validation(Required=false)]
            public DescribeContainerGroupsResponseBodyContainerGroupsEciSecurityContext EciSecurityContext { get; set; }
            public class DescribeContainerGroupsResponseBodyContainerGroupsEciSecurityContext : TeaModel {
                /// <summary>
                /// <para>sysctl parameters.</para>
                /// </summary>
                [NameInMap("Sysctls")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupsResponseBodyContainerGroupsEciSecurityContextSysctls> Sysctls { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsEciSecurityContextSysctls : TeaModel {
                    /// <summary>
                    /// <para>The name of the Sysctl parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>kernel.msgmax</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The value of the Sysctl parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>65536</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The ID of the elastic network interface (ENI).</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-bp14rzqi6fd8satm****</para>
            /// </summary>
            [NameInMap("EniInstanceId")]
            [Validation(Required=false)]
            public string EniInstanceId { get; set; }

            /// <summary>
            /// <para>The size of the temporary storage space. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("EphemeralStorage")]
            [Validation(Required=false)]
            public int? EphemeralStorage { get; set; }

            /// <summary>
            /// <para>The events of the elastic container instance. A maximum of 50 events can be returned.</para>
            /// </summary>
            [NameInMap("Events")]
            [Validation(Required=false)]
            public List<DescribeContainerGroupsResponseBodyContainerGroupsEvents> Events { get; set; }
            public class DescribeContainerGroupsResponseBodyContainerGroupsEvents : TeaModel {
                /// <summary>
                /// <para>The number of the events.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The start time of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-08-02T15:00:00Z</para>
                /// </summary>
                [NameInMap("FirstTimestamp")]
                [Validation(Required=false)]
                public string FirstTimestamp { get; set; }

                /// <summary>
                /// <para>The end time of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-08-02T15:00:00Z</para>
                /// </summary>
                [NameInMap("LastTimestamp")]
                [Validation(Required=false)]
                public string LastTimestamp { get; set; }

                /// <summary>
                /// <para>The event message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Started container</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The category to which the event belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-xxx</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The event name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Created</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <para>The type of the event. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Normal</description></item>
                /// <item><description>Warning</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The time when the elastic container instance failed to run due to overdue payments. The time follows the RFC 3339 standard. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-08-02T15:00:00Z</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The time when the instance failed to run. The time follows the RFC 3339 standard. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-08-02T15:00:00Z</para>
            /// </summary>
            [NameInMap("FailedTime")]
            [Validation(Required=false)]
            public string FailedTime { get; set; }

            /// <summary>
            /// <para>The hostnames and IP addresses for a container that are added to the hosts file of the elastic container instance.</para>
            /// </summary>
            [NameInMap("HostAliases")]
            [Validation(Required=false)]
            public List<DescribeContainerGroupsResponseBodyContainerGroupsHostAliases> HostAliases { get; set; }
            public class DescribeContainerGroupsResponseBodyContainerGroupsHostAliases : TeaModel {
                /// <summary>
                /// <para>The information about the hosts.</para>
                /// </summary>
                [NameInMap("Hostnames")]
                [Validation(Required=false)]
                public List<string> Hostnames { get; set; }

                /// <summary>
                /// <para>The IP address of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.0.XX.XX</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

            }

            /// <summary>
            /// <para>The information about the init containers.</para>
            /// </summary>
            [NameInMap("InitContainers")]
            [Validation(Required=false)]
            public List<DescribeContainerGroupsResponseBodyContainerGroupsInitContainers> InitContainers { get; set; }
            public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainers : TeaModel {
                /// <summary>
                /// <para>The arguments that are passed to the startup commands of the container.</para>
                /// </summary>
                [NameInMap("Args")]
                [Validation(Required=false)]
                public List<string> Args { get; set; }

                /// <summary>
                /// <para>The startup commands of the containers.</para>
                /// </summary>
                [NameInMap("Command")]
                [Validation(Required=false)]
                public List<string> Command { get; set; }

                /// <summary>
                /// <para>The number of vCPUs that are allocated to the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                /// <summary>
                /// <para>The current container status.</para>
                /// </summary>
                [NameInMap("CurrentState")]
                [Validation(Required=false)]
                public DescribeContainerGroupsResponseBodyContainerGroupsInitContainersCurrentState CurrentState { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainersCurrentState : TeaModel {
                    /// <summary>
                    /// <para>The details of the container status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>working</para>
                    /// </summary>
                    [NameInMap("DetailStatus")]
                    [Validation(Required=false)]
                    public string DetailStatus { get; set; }

                    /// <summary>
                    /// <para>The exit code of the container.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ExitCode")]
                    [Validation(Required=false)]
                    public int? ExitCode { get; set; }

                    /// <summary>
                    /// <para>The time when the container stopped running.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2018-08-02T15:00:00Z</para>
                    /// </summary>
                    [NameInMap("FinishTime")]
                    [Validation(Required=false)]
                    public string FinishTime { get; set; }

                    /// <summary>
                    /// <para>The event message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Created container</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// <para>The reason why the container is in this status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Started</para>
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    /// <summary>
                    /// <para>The code of the container status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Signal")]
                    [Validation(Required=false)]
                    public int? Signal { get; set; }

                    /// <summary>
                    /// <para>The time when the container started to run.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2018-08-02T15:00:00Z</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <para>The container status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Waiting</description></item>
                    /// <item><description>Running</description></item>
                    /// <item><description>Terminated</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Running</para>
                    /// </summary>
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                }

                /// <summary>
                /// <para>The environment variables of the init container.</para>
                /// </summary>
                [NameInMap("EnvironmentVars")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupsResponseBodyContainerGroupsInitContainersEnvironmentVars> EnvironmentVars { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainersEnvironmentVars : TeaModel {
                    /// <summary>
                    /// <para>The name of the environment variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PATH</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of the environment variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/usr/local/bin</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    /// <summary>
                    /// <para>The source of the environment variable value. This parameter has a value only when the Value parameter is left empty.</para>
                    /// </summary>
                    [NameInMap("ValueFrom")]
                    [Validation(Required=false)]
                    public DescribeContainerGroupsResponseBodyContainerGroupsInitContainersEnvironmentVarsValueFrom ValueFrom { get; set; }
                    public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainersEnvironmentVarsValueFrom : TeaModel {
                        /// <summary>
                        /// <para>The specified fields.</para>
                        /// </summary>
                        [NameInMap("FieldRef")]
                        [Validation(Required=false)]
                        public DescribeContainerGroupsResponseBodyContainerGroupsInitContainersEnvironmentVarsValueFromFieldRef FieldRef { get; set; }
                        public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainersEnvironmentVarsValueFromFieldRef : TeaModel {
                            /// <summary>
                            /// <para>The path of the field. Only <c>status.podIP</c> is supported.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>status.podIP</para>
                            /// </summary>
                            [NameInMap("FieldPath")]
                            [Validation(Required=false)]
                            public string FieldPath { get; set; }

                        }

                    }

                }

                /// <summary>
                /// <para>The number of GPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Gpu")]
                [Validation(Required=false)]
                public int? Gpu { get; set; }

                /// <summary>
                /// <para>The image of the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nginx</para>
                /// </summary>
                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// <para>The image pulling policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Always: Each time the instance is updated, image pulling is performed.</description></item>
                /// <item><description>IfNotPresent: On-premises images are preferentially used. If no on-premises images are available, image pulling is performed.</description></item>
                /// <item><description>Never: On-premises images are always used. Image pulling is not performed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Always</para>
                /// </summary>
                [NameInMap("ImagePullPolicy")]
                [Validation(Required=false)]
                public string ImagePullPolicy { get; set; }

                /// <summary>
                /// <para>The memory size of the init container. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.0</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public float? Memory { get; set; }

                /// <summary>
                /// <para>The name of the init container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Init-xxx</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The exposed port and protocol of the container.</para>
                /// </summary>
                [NameInMap("Ports")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupsResponseBodyContainerGroupsInitContainersPorts> Ports { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainersPorts : TeaModel {
                    /// <summary>
                    /// <para>The port number. Valid values: 1 to 65535.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8888</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The protocol type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TCP</para>
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                }

                /// <summary>
                /// <para>The previous state of the container.</para>
                /// </summary>
                [NameInMap("PreviousState")]
                [Validation(Required=false)]
                public DescribeContainerGroupsResponseBodyContainerGroupsInitContainersPreviousState PreviousState { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainersPreviousState : TeaModel {
                    /// <summary>
                    /// <para>The details of the container status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>working</para>
                    /// </summary>
                    [NameInMap("DetailStatus")]
                    [Validation(Required=false)]
                    public string DetailStatus { get; set; }

                    /// <summary>
                    /// <para>The exit code of the container.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ExitCode")]
                    [Validation(Required=false)]
                    public int? ExitCode { get; set; }

                    /// <summary>
                    /// <para>The time when the container stopped running.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2019-12-24T05:35:44Z</para>
                    /// </summary>
                    [NameInMap("FinishTime")]
                    [Validation(Required=false)]
                    public string FinishTime { get; set; }

                    /// <summary>
                    /// <para>The message about the container status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Started container</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// <para>The reason why the container is in this status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>completed</para>
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    /// <summary>
                    /// <para>The code of the container status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Signal")]
                    [Validation(Required=false)]
                    public int? Signal { get; set; }

                    /// <summary>
                    /// <para>The time when the container started to run.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2019-12-24T05:35:44Z</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <para>The container status. Valid values: Waiting, Running, and Terminated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Terminated</para>
                    /// </summary>
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the container passed the readiness probe.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Ready")]
                [Validation(Required=false)]
                public bool? Ready { get; set; }

                /// <summary>
                /// <para>The number of times that the container restarted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("RestartCount")]
                [Validation(Required=false)]
                public int? RestartCount { get; set; }

                /// <summary>
                /// <para>The security context of the container.</para>
                /// </summary>
                [NameInMap("SecurityContext")]
                [Validation(Required=false)]
                public DescribeContainerGroupsResponseBodyContainerGroupsInitContainersSecurityContext SecurityContext { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainersSecurityContext : TeaModel {
                    /// <summary>
                    /// <para>The permissions specific to the processes in the container.</para>
                    /// </summary>
                    [NameInMap("Capability")]
                    [Validation(Required=false)]
                    public DescribeContainerGroupsResponseBodyContainerGroupsInitContainersSecurityContextCapability Capability { get; set; }
                    public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainersSecurityContextCapability : TeaModel {
                        /// <summary>
                        /// <para>The permissions specific to the processes in the container.</para>
                        /// </summary>
                        [NameInMap("Adds")]
                        [Validation(Required=false)]
                        public List<string> Adds { get; set; }

                    }

                    /// <summary>
                    /// <para>Indicates whether permissions on the root file system are read-only.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("ReadOnlyRootFilesystem")]
                    [Validation(Required=false)]
                    public bool? ReadOnlyRootFilesystem { get; set; }

                    /// <summary>
                    /// <para>The UID that is used to run the entry point of the container process.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1557</para>
                    /// </summary>
                    [NameInMap("RunAsUser")]
                    [Validation(Required=false)]
                    public long? RunAsUser { get; set; }

                }

                /// <summary>
                /// <para>The information about the volumes that are mounted to the init container.</para>
                /// </summary>
                [NameInMap("VolumeMounts")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupsResponseBodyContainerGroupsInitContainersVolumeMounts> VolumeMounts { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsInitContainersVolumeMounts : TeaModel {
                    /// <summary>
                    /// <para>The directory of the volume that is mounted to the container. The data in this directory is overwritten by the data on the volume.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/usr/share/</para>
                    /// </summary>
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                    /// <summary>
                    /// <para>The mount propagation setting of the volume. Mount propagation allows volumes that are mounted on one container to be shared with other containers in the same pod, or even with other pods on the same node. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>None: The volume mount does not receive subsequent mounts that are performed on this volume or on the subdirectories of this volume.</description></item>
                    /// <item><description>HostToCotainer: The volume mount receives subsequent mounts that are performed on this volume or on the subdirectories of this volume.</description></item>
                    /// <item><description>Bidirectional: This value is similar to HostToCotainer. The volume mount receives subsequent mounts that are performed on this volume or on the subdirectories of this volume. In addition, all volume mounts that are performed on the container are propagated back to the host and all containers of all pods that use the same volume.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>None</para>
                    /// </summary>
                    [NameInMap("MountPropagation")]
                    [Validation(Required=false)]
                    public string MountPropagation { get; set; }

                    /// <summary>
                    /// <para>The name of the volume. The value of this parameter is the same as the name of the volume that you selected when you purchased the container.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test-empty</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the volume is read-only.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("ReadOnly")]
                    [Validation(Required=false)]
                    public bool? ReadOnly { get; set; }

                }

                /// <summary>
                /// <para>The working directory of the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/test</para>
                /// </summary>
                [NameInMap("WorkingDir")]
                [Validation(Required=false)]
                public string WorkingDir { get; set; }

            }

            /// <summary>
            /// <para>The instance type of the specified Elastic Compute Service (ECS) instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.g5.large</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The public IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.0.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The IPv6 address of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2001:XXXX:4:4:4:4:4:4</para>
            /// </summary>
            [NameInMap("Ipv6Address")]
            [Validation(Required=false)]
            public string Ipv6Address { get; set; }

            /// <summary>
            /// <para>The memory size of the instance. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4.0</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// <para>The name of the instance RAM role. The elastic container instance and the ECS instance share a RAM role. For more information, see <a href="https://help.aliyun.com/document_detail/61178.html">Use an instance RAM role by calling API operations</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ram:PassRole</para>
            /// </summary>
            [NameInMap("RamRoleName")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// <para>The region ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-8db03793gfrz****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The restart policy of the elastic container instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Never: Never restarts the instance if a container in the instance exits upon termination.</description></item>
            /// <item><description>Always: Always restarts the instance if a container in the instance exits upon termination.</description></item>
            /// <item><description>OnFailure: Restarts the instance only if a container in the instance exists upon failure with a status code of non-zero.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Never</para>
            /// </summary>
            [NameInMap("RestartPolicy")]
            [Validation(Required=false)]
            public string RestartPolicy { get; set; }

            /// <summary>
            /// <para>The ID of the security group to which the instances belong.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp12ujq5zpxuyjfo3o8r</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The maximum hourly price for the preemptible elastic container instance.</para>
            /// <para>This parameter is returned only when SpotStrategy is set to SpotWithPriceLimit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.025</para>
            /// </summary>
            [NameInMap("SpotPriceLimit")]
            [Validation(Required=false)]
            public double? SpotPriceLimit { get; set; }

            /// <summary>
            /// <para>The bid policy for the instance. Default value: NoSpot. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NoSpot: The instance is a regular pay-as-you-go instance.</description></item>
            /// <item><description>SpotWithPriceLimit: The instance is a preemptible instance that has a user-defined maximum hourly price.</description></item>
            /// <item><description>SpotAsPriceGo: The instance is a preemptible instance for which the market price at the time of purchase is automatically used as the bid price.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NoSpot</para>
            /// </summary>
            [NameInMap("SpotStrategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// <para>The status of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: The instance is being started.</description></item>
            /// <item><description>Running: The instance is running.</description></item>
            /// <item><description>Succeeded: The instance successfully runs.</description></item>
            /// <item><description>Failed: The instance fails to run.</description></item>
            /// <item><description>Scheduling: The instance is being created.</description></item>
            /// <item><description>ScheduleFailed: The instance fails to be created.</description></item>
            /// <item><description>Restarting: The instance is being restarted.</description></item>
            /// <item><description>Updating: The instance is being updated.</description></item>
            /// <item><description>Terminating: The instance is being terminated.</description></item>
            /// <item><description>Expired: The instance is expired.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when all containers exited on success. The time follows the RFC 3339 standard. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-12-11T04:33:42Z</para>
            /// </summary>
            [NameInMap("SucceededTime")]
            [Validation(Required=false)]
            public string SucceededTime { get; set; }

            /// <summary>
            /// <para>The tags that are added to the instance.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeContainerGroupsResponseBodyContainerGroupsTags> Tags { get; set; }
            public class DescribeContainerGroupsResponseBodyContainerGroupsTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-xh</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>This parameter is not publicly available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-xxx</para>
            /// </summary>
            [NameInMap("TenantEniInstanceId")]
            [Validation(Required=false)]
            public string TenantEniInstanceId { get; set; }

            /// <summary>
            /// <para>This parameter is not publicly available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.10.XX.XX</para>
            /// </summary>
            [NameInMap("TenantEniIp")]
            [Validation(Required=false)]
            public string TenantEniIp { get; set; }

            /// <summary>
            /// <para>This parameter is not publicly available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-xxx</para>
            /// </summary>
            [NameInMap("TenantSecurityGroupId")]
            [Validation(Required=false)]
            public string TenantSecurityGroupId { get; set; }

            /// <summary>
            /// <para>This parameter is not publicly available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-xxx</para>
            /// </summary>
            [NameInMap("TenantVSwitchId")]
            [Validation(Required=false)]
            public string TenantVSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch to which the instance is connected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1vzjjflab6wvjox****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The information about the volumes.</para>
            /// </summary>
            [NameInMap("Volumes")]
            [Validation(Required=false)]
            public List<DescribeContainerGroupsResponseBodyContainerGroupsVolumes> Volumes { get; set; }
            public class DescribeContainerGroupsResponseBodyContainerGroupsVolumes : TeaModel {
                /// <summary>
                /// <para>The path of the ConfigFile volume.</para>
                /// </summary>
                [NameInMap("ConfigFileVolumeConfigFileToPaths")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupsResponseBodyContainerGroupsVolumesConfigFileVolumeConfigFileToPaths> ConfigFileVolumeConfigFileToPaths { get; set; }
                public class DescribeContainerGroupsResponseBodyContainerGroupsVolumesConfigFileVolumeConfigFileToPaths : TeaModel {
                    /// <summary>
                    /// <para>The content of the ConfigFile volume. Maximum size: 32 KB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hello world</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The relative path of the ConfigFile volume.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/usr/bin/</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                }

                /// <summary>
                /// <para>The ID of the disk when you set Type to DiskVolume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d-xxxx</para>
                /// </summary>
                [NameInMap("DiskVolumeDiskId")]
                [Validation(Required=false)]
                public string DiskVolumeDiskId { get; set; }

                /// <summary>
                /// <para>The file system type of the disk volume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xfs</para>
                /// </summary>
                [NameInMap("DiskVolumeFsType")]
                [Validation(Required=false)]
                public string DiskVolumeFsType { get; set; }

                /// <summary>
                /// <para>The storage media for the emptyDir volume. This parameter is empty by default, indicating that the node file system is used as the storage media. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Memory: Memory is used as the storage media.</description></item>
                /// <item><description>LocalRaid0: Local disks are formed into RAID 0. This value is valid only if an elastic container instance that has local disks mounted is created. For more information, see <a href="https://help.aliyun.com/document_detail/114664.html">Create an elastic container instance that has local disks mounted</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Memory</para>
                /// </summary>
                [NameInMap("EmptyDirVolumeMedium")]
                [Validation(Required=false)]
                public string EmptyDirVolumeMedium { get; set; }

                /// <summary>
                /// <para>The storage size of the emptyDir volume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>256Mi</para>
                /// </summary>
                [NameInMap("EmptyDirVolumeSizeLimit")]
                [Validation(Required=false)]
                public string EmptyDirVolumeSizeLimit { get; set; }

                /// <summary>
                /// <para>The name of the driver when you set the Type parameter to FlexVolume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>flexvolume</para>
                /// </summary>
                [NameInMap("FlexVolumeDriver")]
                [Validation(Required=false)]
                public string FlexVolumeDriver { get; set; }

                /// <summary>
                /// <para>The file system type when you set the Type parameter to FlexVolume. The default value varies based on the script of the FlexVolume plug-in.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ntfs</para>
                /// </summary>
                [NameInMap("FlexVolumeFsType")]
                [Validation(Required=false)]
                public string FlexVolumeFsType { get; set; }

                /// <summary>
                /// <para>The options when you set the Type parameter to FlexVolume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[nolock,tcp,noresvport]</para>
                /// </summary>
                [NameInMap("FlexVolumeOptions")]
                [Validation(Required=false)]
                public string FlexVolumeOptions { get; set; }

                /// <summary>
                /// <para>The path of the NFS volume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/eci</para>
                /// </summary>
                [NameInMap("NFSVolumePath")]
                [Validation(Required=false)]
                public string NFSVolumePath { get; set; }

                /// <summary>
                /// <para>Indicates whether the NFS volume is read-only.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("NFSVolumeReadOnly")]
                [Validation(Required=false)]
                public bool? NFSVolumeReadOnly { get; set; }

                /// <summary>
                /// <para>The address of the NFS server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0eafxxxxx-xxxxx.cn-hangzhou.nas.aliyuncs.com</para>
                /// </summary>
                [NameInMap("NFSVolumeServer")]
                [Validation(Required=false)]
                public string NFSVolumeServer { get; set; }

                /// <summary>
                /// <para>The volume name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-empty</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of the volume. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>EmptyDirVolume</description></item>
                /// <item><description>NFSVolume</description></item>
                /// <item><description>ConfigFileVolume</description></item>
                /// <item><description>FlexVolume</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>EmptyDirVolume</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The ID of the VPC to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-1vzjjflab6wvjox****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The zone to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-h</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The token that determines the start point of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d78f2dd8-5979-42fe-****-b16db43be5bc</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request. The value is unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>89945DD3-9072-47D0-A318-353284CFC7B3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of queried instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
