// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeServerlessJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of detailed information about the serverless job.</para>
        /// </summary>
        [NameInMap("JobInfos")]
        [Validation(Required=false)]
        public List<DescribeServerlessJobsResponseBodyJobInfos> JobInfos { get; set; }
        public class DescribeServerlessJobsResponseBodyJobInfos : TeaModel {
            /// <summary>
            /// <para>The properties of the array job.</para>
            /// </summary>
            [NameInMap("ArrayProperties")]
            [Validation(Required=false)]
            public DescribeServerlessJobsResponseBodyJobInfosArrayProperties ArrayProperties { get; set; }
            public class DescribeServerlessJobsResponseBodyJobInfosArrayProperties : TeaModel {
                /// <summary>
                /// <para>The end value of the array job index.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("IndexEnd")]
                [Validation(Required=false)]
                public long? IndexEnd { get; set; }

                /// <summary>
                /// <para>The starting value of the array job index.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IndexStart")]
                [Validation(Required=false)]
                public long? IndexStart { get; set; }

                /// <summary>
                /// <para>The interval of the array job index.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("IndexStep")]
                [Validation(Required=false)]
                public long? IndexStep { get; set; }

            }

            /// <summary>
            /// <para>The information of the container groups that are used to run the serverless job.</para>
            /// </summary>
            [NameInMap("ContainerGroups")]
            [Validation(Required=false)]
            public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroups> ContainerGroups { get; set; }
            public class DescribeServerlessJobsResponseBodyJobInfosContainerGroups : TeaModel {
                /// <summary>
                /// <para>The ID of the container group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eci-bp1jrgfqqy54kg5hc****</para>
                /// </summary>
                [NameInMap("ContainerGroupId")]
                [Validation(Required=false)]
                public string ContainerGroupId { get; set; }

                /// <summary>
                /// <para>The name of the container group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ContainerGroupName")]
                [Validation(Required=false)]
                public string ContainerGroupName { get; set; }

                /// <summary>
                /// <para>The list of containers in the container group.</para>
                /// </summary>
                [NameInMap("Containers")]
                [Validation(Required=false)]
                public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainers> Containers { get; set; }
                public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainers : TeaModel {
                    /// <summary>
                    /// <para>The startup parameter of the container.</para>
                    /// </summary>
                    [NameInMap("Args")]
                    [Validation(Required=false)]
                    public List<string> Args { get; set; }

                    /// <summary>
                    /// <para>The startup command of the container.</para>
                    /// </summary>
                    [NameInMap("Commands")]
                    [Validation(Required=false)]
                    public List<string> Commands { get; set; }

                    /// <summary>
                    /// <para>The number of vCPUs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2.0</para>
                    /// </summary>
                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public float? Cpu { get; set; }

                    /// <summary>
                    /// <para>The current status of the container.</para>
                    /// </summary>
                    [NameInMap("CurrentState")]
                    [Validation(Required=false)]
                    public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersCurrentState CurrentState { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersCurrentState : TeaModel {
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
                        public long? ExitCode { get; set; }

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
                        /// <para>The information about the container status.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Back-off 5m0s restarting failed container=test pod=test_eci-xxx(xxx)</para>
                        /// </summary>
                        [NameInMap("Message")]
                        [Validation(Required=false)]
                        public string Message { get; set; }

                        /// <summary>
                        /// <para>The reason why the container is in this state.</para>
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
                        public long? Signal { get; set; }

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
                        /// <para>The status of the job. Valid values:</para>
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
                    /// <para>The environment variables.</para>
                    /// </summary>
                    [NameInMap("EnvironmentVars")]
                    [Validation(Required=false)]
                    public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersEnvironmentVars> EnvironmentVars { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersEnvironmentVars : TeaModel {
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
                        /// <para>The source of the environment variable value. This parameter can be used only when the variable value is not specified.</para>
                        /// </summary>
                        [NameInMap("ValueFrom")]
                        [Validation(Required=false)]
                        public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersEnvironmentVarsValueFrom ValueFrom { get; set; }
                        public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersEnvironmentVarsValueFrom : TeaModel {
                            /// <summary>
                            /// <para>The specified field.</para>
                            /// </summary>
                            [NameInMap("FieldRef")]
                            [Validation(Required=false)]
                            public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersEnvironmentVarsValueFromFieldRef FieldRef { get; set; }
                            public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersEnvironmentVarsValueFromFieldRef : TeaModel {
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
                    /// <para>The image of the container.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HPL</para>
                    /// </summary>
                    [NameInMap("Image")]
                    [Validation(Required=false)]
                    public string Image { get; set; }

                    /// <summary>
                    /// <para>The policy to pull images. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Always: Each time instances are created, image pulling is performed.</description></item>
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
                    public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersLivenessProbe LivenessProbe { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersLivenessProbe : TeaModel {
                        /// <summary>
                        /// <para>The commands that are run.</para>
                        /// </summary>
                        [NameInMap("Execs")]
                        [Validation(Required=false)]
                        public List<string> Execs { get; set; }

                        /// <summary>
                        /// <para>The minimum number of consecutive failures that must occur for the probe to be considered as failed. Default value: 3.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("FailureThreshold")]
                        [Validation(Required=false)]
                        public long? FailureThreshold { get; set; }

                        /// <summary>
                        /// <para>The HTTP GET method that is used to check the container.</para>
                        /// </summary>
                        [NameInMap("HttpGet")]
                        [Validation(Required=false)]
                        public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersLivenessProbeHttpGet HttpGet { get; set; }
                        public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersLivenessProbeHttpGet : TeaModel {
                            /// <summary>
                            /// <para>The path to which HTTP GET requests are sent.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>/usr/nginx/</para>
                            /// </summary>
                            [NameInMap("Path")]
                            [Validation(Required=false)]
                            public string Path { get; set; }

                            /// <summary>
                            /// <para>The port to which HTTP GET requests are sent.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>80</para>
                            /// </summary>
                            [NameInMap("Port")]
                            [Validation(Required=false)]
                            public long? Port { get; set; }

                            /// <summary>
                            /// <para>The protocol type of the HTTP GET requests.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>HTTP</para>
                            /// </summary>
                            [NameInMap("Scheme")]
                            [Validation(Required=false)]
                            public string Scheme { get; set; }

                        }

                        /// <summary>
                        /// <para>The number of seconds after the container is started and before a liveness probe is initiated.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("InitialDelaySeconds")]
                        [Validation(Required=false)]
                        public long? InitialDelaySeconds { get; set; }

                        /// <summary>
                        /// <para>The interval at which the probe is run. Unit: seconds. Default value: 10. Minimum value: 1.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("PeriodSeconds")]
                        [Validation(Required=false)]
                        public long? PeriodSeconds { get; set; }

                        /// <summary>
                        /// <para>The minimum number of consecutive successes that must occur for the check to be considered successful. Default value: 1. Set the value to 1.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("SuccessThreshold")]
                        [Validation(Required=false)]
                        public long? SuccessThreshold { get; set; }

                        /// <summary>
                        /// <para>The TCP socket method that is used to check the container.</para>
                        /// </summary>
                        [NameInMap("TcpSocket")]
                        [Validation(Required=false)]
                        public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersLivenessProbeTcpSocket TcpSocket { get; set; }
                        public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersLivenessProbeTcpSocket : TeaModel {
                            /// <summary>
                            /// <para>The name of the host.</para>
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
                            public long? Port { get; set; }

                        }

                        /// <summary>
                        /// <para>The timeout period of the check. Default value: 1. Minimum value: 1.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("TimeoutSeconds")]
                        [Validation(Required=false)]
                        public long? TimeoutSeconds { get; set; }

                    }

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
                    /// <para>The container name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HPL</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The exposed ports and protocols of the container.</para>
                    /// </summary>
                    [NameInMap("Ports")]
                    [Validation(Required=false)]
                    public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersPorts> Ports { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersPorts : TeaModel {
                        /// <summary>
                        /// <para>The port number. Valid values: 1 to 65535.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>8080</para>
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public long? Port { get; set; }

                        /// <summary>
                        /// <para>The protocol.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TCP</para>
                        /// </summary>
                        [NameInMap("Protocol")]
                        [Validation(Required=false)]
                        public string Protocol { get; set; }

                    }

                    /// <summary>
                    /// <para>The previous status of the container.</para>
                    /// </summary>
                    [NameInMap("PreviousState")]
                    [Validation(Required=false)]
                    public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersPreviousState PreviousState { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersPreviousState : TeaModel {
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
                        public long? ExitCode { get; set; }

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
                        /// <para>The reason why the container is in this state.</para>
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
                        public long? Signal { get; set; }

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
                        /// <para>The status of the container. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Waiting: The container is being started.</description></item>
                        /// <item><description>Running: The container is running.</description></item>
                        /// <item><description>Terminated: The container terminates running.</description></item>
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
                    public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersReadinessProbe ReadinessProbe { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersReadinessProbe : TeaModel {
                        /// <summary>
                        /// <para>The commands that are run in the container when you use the command line interface (CLI) to perform health checks.</para>
                        /// </summary>
                        [NameInMap("Execs")]
                        [Validation(Required=false)]
                        public List<string> Execs { get; set; }

                        /// <summary>
                        /// <para>The minimum number of consecutive failures that must occur for the check to be considered as failed. Default value: 3.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("FailureThreshold")]
                        [Validation(Required=false)]
                        public long? FailureThreshold { get; set; }

                        /// <summary>
                        /// <para>The HTTP GET method that is used to check the container.</para>
                        /// </summary>
                        [NameInMap("HttpGet")]
                        [Validation(Required=false)]
                        public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersReadinessProbeHttpGet HttpGet { get; set; }
                        public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersReadinessProbeHttpGet : TeaModel {
                            /// <summary>
                            /// <para>The path to which HTTP GET requests are sent.</para>
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
                            public long? Port { get; set; }

                            /// <summary>
                            /// <para>The protocol type of the HTTP GET requests.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>HTTP</para>
                            /// </summary>
                            [NameInMap("Scheme")]
                            [Validation(Required=false)]
                            public string Scheme { get; set; }

                        }

                        /// <summary>
                        /// <para>The number of seconds after the container is started and before a liveness probe is initiated.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("InitialDelaySeconds")]
                        [Validation(Required=false)]
                        public long? InitialDelaySeconds { get; set; }

                        /// <summary>
                        /// <para>The interval at which the container is checked. Unit: seconds. Default value: 10. Minimum value: 1.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("PeriodSeconds")]
                        [Validation(Required=false)]
                        public long? PeriodSeconds { get; set; }

                        /// <summary>
                        /// <para>The minimum number of consecutive successes for a failed liveness probe to be considered successful. Default value: 1. Set the value to 1.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("SuccessThreshold")]
                        [Validation(Required=false)]
                        public long? SuccessThreshold { get; set; }

                        /// <summary>
                        /// <para>The TCP socket method that is used to check the container.</para>
                        /// </summary>
                        [NameInMap("TcpSocket")]
                        [Validation(Required=false)]
                        public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersReadinessProbeTcpSocket TcpSocket { get; set; }
                        public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersReadinessProbeTcpSocket : TeaModel {
                            /// <summary>
                            /// <para>The IP address of the host.</para>
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
                            public long? Port { get; set; }

                        }

                        /// <summary>
                        /// <para>The timeout period of the check. Default value: 1. Minimum value: 1.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("TimeoutSeconds")]
                        [Validation(Required=false)]
                        public long? TimeoutSeconds { get; set; }

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
                    /// <para>The number of times that the instance worker restarted.</para>
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
                    public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersSecurityContext SecurityContext { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersSecurityContext : TeaModel {
                        /// <summary>
                        /// <para>The permissions specific to the processes in the container.</para>
                        /// </summary>
                        [NameInMap("Capability")]
                        [Validation(Required=false)]
                        public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersSecurityContextCapability Capability { get; set; }
                        public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersSecurityContextCapability : TeaModel {
                            /// <summary>
                            /// <para>The permissions specific to the processes in the container.</para>
                            /// </summary>
                            [NameInMap("Adds")]
                            [Validation(Required=false)]
                            public List<string> Adds { get; set; }

                        }

                        /// <summary>
                        /// <para>Indicates whether the root file system is set to the read-only mode. The only valid value is true.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("ReadOnlyRootFilesystem")]
                        [Validation(Required=false)]
                        public bool? ReadOnlyRootFilesystem { get; set; }

                        /// <summary>
                        /// <para>The user ID (UID) that is used to run the entry point of the container process.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1558</para>
                        /// </summary>
                        [NameInMap("RunAsUser")]
                        [Validation(Required=false)]
                        public long? RunAsUser { get; set; }

                    }

                    /// <summary>
                    /// <para>Indicates whether the container allocates buffer resources to standard input streams when the container runs. If you do not specify this parameter, an end-of-file (EOF) error may occur when standard input streams in the container are read. Default value: false.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Stdin")]
                    [Validation(Required=false)]
                    public bool? Stdin { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the container runtime closes the stdin channel after the stdin channel has been opened by a single attach session. If stdin is true, the stdin stream remains open across multiple attach sessions. If StdinOnce is set to true, stdin is opened on container start, but remains empty until the first client attaches to stdin, and then remains open and receives data until the client disconnects. When the client disconnects, stdin is closed and remains closed until the container is restarted.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("StdinOnce")]
                    [Validation(Required=false)]
                    public bool? StdinOnce { get; set; }

                    /// <summary>
                    /// <para>Indicates whether interaction is enabled. Default value: false. If the value of the Command parameter is /bin/bash, the value of this parameter must be set to true.</para>
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
                    public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersVolumeMounts> VolumeMounts { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsContainersVolumeMounts : TeaModel {
                        /// <summary>
                        /// <para>The directory to which the volume is mounted. Data under this directory is overwritten by the data on the volume.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/usr/share/</para>
                        /// </summary>
                        [NameInMap("MountPath")]
                        [Validation(Required=false)]
                        public string MountPath { get; set; }

                        /// <summary>
                        /// <para>The mount propagation settings of the volume. Mount propagation allows you to share volumes that are mounted on a container with other containers in the same pod or other pods on the same node. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>None: The volume mount does not receive subsequent mounts that are mounted to the volume or the subdirectories of the volume.</description></item>
                        /// <item><description>HostToCotainer: The volume mount receives all subsequent mounts that are mounted to the volume or the subdirectories of the volume.</description></item>
                        /// <item><description>Bidirectional: This value is similar to HostToCotainer. The volume mount receives all subsequent mounts that are mounted to the volume or the subdirectories of the volume. All volume mounts that are mounted by the container are propagated back to the instance and all containers of all pods that use the same volume.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>None</para>
                        /// </summary>
                        [NameInMap("MountPropagation")]
                        [Validation(Required=false)]
                        public string MountPropagation { get; set; }

                        /// <summary>
                        /// <para>The name of the volume.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test-empty</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the volumes are read-only.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("ReadOnly")]
                        [Validation(Required=false)]
                        public bool? ReadOnly { get; set; }

                        /// <summary>
                        /// <para>The subdirectory of the volume. This parameter specifies different subdirectories of the same volume that the instance can mount to different subdirectories of containers.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/usr/sub</para>
                        /// </summary>
                        [NameInMap("SubPath")]
                        [Validation(Required=false)]
                        public string SubPath { get; set; }

                    }

                    /// <summary>
                    /// <para>The working directory.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/usr/local/nginx</para>
                    /// </summary>
                    [NameInMap("WorkingDir")]
                    [Validation(Required=false)]
                    public string WorkingDir { get; set; }

                }

                /// <summary>
                /// <para>The number of vCPUs that are allocated to the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                /// <summary>
                /// <para>The time when the instance is created. The time follows the RFC 3339 standard and must be in UTC.</para>
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
                public long? Discount { get; set; }

                /// <summary>
                /// <para>The Domain Name System (DNS) settings.</para>
                /// </summary>
                [NameInMap("DnsConfig")]
                [Validation(Required=false)]
                public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsDnsConfig DnsConfig { get; set; }
                public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsDnsConfig : TeaModel {
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
                    public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroupsDnsConfigOptions> Options { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsDnsConfigOptions : TeaModel {
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
                    /// <para>The search domains of the DNS server.</para>
                    /// </summary>
                    [NameInMap("Searches")]
                    [Validation(Required=false)]
                    public List<string> Searches { get; set; }

                }

                /// <summary>
                /// <para>The security context of the container group.</para>
                /// </summary>
                [NameInMap("EciSecurityContext")]
                [Validation(Required=false)]
                public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsEciSecurityContext EciSecurityContext { get; set; }
                public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsEciSecurityContext : TeaModel {
                    /// <summary>
                    /// <para>The Sysctl parameters.</para>
                    /// </summary>
                    [NameInMap("Sysctls")]
                    [Validation(Required=false)]
                    public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroupsEciSecurityContextSysctls> Sysctls { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsEciSecurityContextSysctls : TeaModel {
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
                public long? EphemeralStorage { get; set; }

                /// <summary>
                /// <para>The event information. Up to 50 events can be returned.</para>
                /// </summary>
                [NameInMap("Events")]
                [Validation(Required=false)]
                public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroupsEvents> Events { get; set; }
                public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsEvents : TeaModel {
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
                    /// <para>The time when the event started.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2018-08-02T15:00:00Z</para>
                    /// </summary>
                    [NameInMap("FirstTimestamp")]
                    [Validation(Required=false)]
                    public string FirstTimestamp { get; set; }

                    /// <summary>
                    /// <para>The time when the event ended.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2018-08-02T15:00:00Z</para>
                    /// </summary>
                    [NameInMap("LastTimestamp")]
                    [Validation(Required=false)]
                    public string LastTimestamp { get; set; }

                    /// <summary>
                    /// <para>The message about the event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Started container</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// <para>The name of the category to which the event belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test-xxx</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The name of the event.</para>
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
                /// <para>The time when the instance failed to run due to overdue payments. The time follows the RFC 3339 standard and must be in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-08-02T15:00:00Z</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <para>The time when the instance failed to run. The time follows the RFC 3339 standard and must be in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-08-02T15:00:00Z</para>
                /// </summary>
                [NameInMap("FailedTime")]
                [Validation(Required=false)]
                public string FailedTime { get; set; }

                /// <summary>
                /// <para>The hostname mapping of a container in the elastic container instance.</para>
                /// </summary>
                [NameInMap("HostAliases")]
                [Validation(Required=false)]
                public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroupsHostAliases> HostAliases { get; set; }
                public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsHostAliases : TeaModel {
                    /// <summary>
                    /// <para>The information about the host.</para>
                    /// </summary>
                    [NameInMap("Hostnames")]
                    [Validation(Required=false)]
                    public List<string> Hostnames { get; set; }

                    /// <summary>
                    /// <para>The IP address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.0.XX.XX</para>
                    /// </summary>
                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public string Ip { get; set; }

                }

                /// <summary>
                /// <para>The init containers.</para>
                /// </summary>
                [NameInMap("InitContainers")]
                [Validation(Required=false)]
                public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainers> InitContainers { get; set; }
                public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainers : TeaModel {
                    /// <summary>
                    /// <para>The startup parameters.</para>
                    /// </summary>
                    [NameInMap("Args")]
                    [Validation(Required=false)]
                    public List<string> Args { get; set; }

                    /// <summary>
                    /// <para>The startup command.</para>
                    /// </summary>
                    [NameInMap("Command")]
                    [Validation(Required=false)]
                    public List<string> Command { get; set; }

                    /// <summary>
                    /// <para>The number of vCPUs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.0</para>
                    /// </summary>
                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public long? Cpu { get; set; }

                    /// <summary>
                    /// <para>The current status of the container.</para>
                    /// </summary>
                    [NameInMap("CurrentState")]
                    [Validation(Required=false)]
                    public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersCurrentState CurrentState { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersCurrentState : TeaModel {
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
                        public long? ExitCode { get; set; }

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
                        /// <para>The message about the event.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Created container</para>
                        /// </summary>
                        [NameInMap("Message")]
                        [Validation(Required=false)]
                        public string Message { get; set; }

                        /// <summary>
                        /// <para>The reason why the container is in this state.</para>
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
                        public long? Signal { get; set; }

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
                        /// <para>The status of the container. Valid values:</para>
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
                    /// <para>The environment variables.</para>
                    /// </summary>
                    [NameInMap("EnvironmentVars")]
                    [Validation(Required=false)]
                    public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersEnvironmentVars> EnvironmentVars { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersEnvironmentVars : TeaModel {
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
                        /// <para>The source of the environment variable value. This parameter can be used only when the variable value is not specified.</para>
                        /// </summary>
                        [NameInMap("ValueFrom")]
                        [Validation(Required=false)]
                        public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersEnvironmentVarsValueFrom ValueFrom { get; set; }
                        public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersEnvironmentVarsValueFrom : TeaModel {
                            /// <summary>
                            /// <para>The specified field.</para>
                            /// </summary>
                            [NameInMap("FieldRef")]
                            [Validation(Required=false)]
                            public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersEnvironmentVarsValueFromFieldRef FieldRef { get; set; }
                            public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersEnvironmentVarsValueFromFieldRef : TeaModel {
                                /// <summary>
                                /// <para>The path of the field in the specified version. Set the value to <c>status.podIP</c>.</para>
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
                    public long? Gpu { get; set; }

                    /// <summary>
                    /// <para>The image.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>nginx</para>
                    /// </summary>
                    [NameInMap("Image")]
                    [Validation(Required=false)]
                    public string Image { get; set; }

                    /// <summary>
                    /// <para>The policy to pull images.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Always</para>
                    /// </summary>
                    [NameInMap("ImagePullPolicy")]
                    [Validation(Required=false)]
                    public string ImagePullPolicy { get; set; }

                    /// <summary>
                    /// <para>The size of memory that is allocated to the init container. Unit: GiB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2.0</para>
                    /// </summary>
                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public long? Memory { get; set; }

                    /// <summary>
                    /// <para>The container name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Init-xxx</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The exposed ports and protocols of the container.</para>
                    /// </summary>
                    [NameInMap("Ports")]
                    [Validation(Required=false)]
                    public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersPorts> Ports { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersPorts : TeaModel {
                        /// <summary>
                        /// <para>The port number. Valid values: 1 to 65535.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>8888</para>
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public long? Port { get; set; }

                        /// <summary>
                        /// <para>The protocol.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TCP</para>
                        /// </summary>
                        [NameInMap("Protocol")]
                        [Validation(Required=false)]
                        public string Protocol { get; set; }

                    }

                    /// <summary>
                    /// <para>The previous status of the container.</para>
                    /// </summary>
                    [NameInMap("PreviousState")]
                    [Validation(Required=false)]
                    public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersPreviousState PreviousState { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersPreviousState : TeaModel {
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
                        public long? ExitCode { get; set; }

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
                        /// <para>The reason why the container is in this state.</para>
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
                        public long? Signal { get; set; }

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
                        /// <para>The status of the container. Valid values: Waiting, Running, and Terminated.</para>
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
                    /// <para>The number of times that the instance worker restarted.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("RestartCount")]
                    [Validation(Required=false)]
                    public long? RestartCount { get; set; }

                    /// <summary>
                    /// <para>The security context of the container.</para>
                    /// </summary>
                    [NameInMap("SecurityContext")]
                    [Validation(Required=false)]
                    public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersSecurityContext SecurityContext { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersSecurityContext : TeaModel {
                        /// <summary>
                        /// <para>The permissions specific to the processes in the container.</para>
                        /// </summary>
                        [NameInMap("Capability")]
                        [Validation(Required=false)]
                        public DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersSecurityContextCapability Capability { get; set; }
                        public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersSecurityContextCapability : TeaModel {
                            /// <summary>
                            /// <para>The permissions specific to the processes in the container.</para>
                            /// </summary>
                            [NameInMap("Adds")]
                            [Validation(Required=false)]
                            public List<string> Adds { get; set; }

                        }

                        /// <summary>
                        /// <para>Indicates whether the root file system is set to the read-only mode. The only valid value is true.</para>
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
                    public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersVolumeMounts> VolumeMounts { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsInitContainersVolumeMounts : TeaModel {
                        /// <summary>
                        /// <para>The directory to which the volume is mounted. Data under this directory is overwritten by the data on the volume.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/usr/share/</para>
                        /// </summary>
                        [NameInMap("MountPath")]
                        [Validation(Required=false)]
                        public string MountPath { get; set; }

                        /// <summary>
                        /// <para>The mount propagation settings of the volume. Mount propagation allows you to share volumes that are mounted on a container with other containers in the same pod or other pods on the same node. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>None: The volume mount does not receive subsequent mounts that are mounted to the volume or the subdirectories of the volume.</description></item>
                        /// <item><description>HostToCotainer: The volume mount receives all subsequent mounts that are mounted to the volume or the subdirectories of the volume.</description></item>
                        /// <item><description>Bidirectional: This value is similar to HostToCotainer. The volume mount receives all subsequent mounts that are mounted to the volume or the subdirectories of the volume. All volume mounts that are mounted by the container are propagated back to the instance and all containers of all pods that use the same volume.</description></item>
                        /// </list>
                        /// <para>Default value: None.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>None</para>
                        /// </summary>
                        [NameInMap("MountPropagation")]
                        [Validation(Required=false)]
                        public string MountPropagation { get; set; }

                        /// <summary>
                        /// <para>The name of the volume. The name is the same as the volume you selected when you purchased the container.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test-empty</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>Default value: False.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("ReadOnly")]
                        [Validation(Required=false)]
                        public bool? ReadOnly { get; set; }

                    }

                    /// <summary>
                    /// <para>The working directory.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/usr/test</para>
                    /// </summary>
                    [NameInMap("WorkingDir")]
                    [Validation(Required=false)]
                    public string WorkingDir { get; set; }

                }

                /// <summary>
                /// <para>The instance type of the Elastic Compute Service (ECS) instance.</para>
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
                /// <para>The IPv6 address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2001:XXXX:4:4:4:4:4:4</para>
                /// </summary>
                [NameInMap("Ipv6Address")]
                [Validation(Required=false)]
                public string Ipv6Address { get; set; }

                /// <summary>
                /// <para>The memory size of the elastic container instance. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4.0</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public float? Memory { get; set; }

                /// <summary>
                /// <para>The name of the instance RAM role. You can use an instance RAM role to access both elastic container instances and ECS instances. For more information, see <a href="https://help.aliyun.com/document_detail/61178.html">Use the instance RAM role by calling APIs</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ram:PassRole</para>
                /// </summary>
                [NameInMap("RamRoleName")]
                [Validation(Required=false)]
                public string RamRoleName { get; set; }

                /// <summary>
                /// <para>The ID of the region in which the instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the cluster belongs. If you do not specify a resource group when you create an elastic container instance, the system automatically adds the instance to the default resource group in your account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aekzh43v*****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The instance restart policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Always: Always restarts the instance if a container in the instance exits upon termination.</description></item>
                /// <item><description>Never: Never restarts the instance if a container in the instance exits upon termination.</description></item>
                /// <item><description>OnFailure: Restarts the instance when the last start failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Never</para>
                /// </summary>
                [NameInMap("RestartPolicy")]
                [Validation(Required=false)]
                public string RestartPolicy { get; set; }

                /// <summary>
                /// <para>The ID of the security group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-bp12ujq5zpxuyjfo3o8r</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The maximum hourly price for the preemptible instance.</para>
                /// <para>This parameter is returned only if you set the SpotStrategy parameter to SpotWithPriceLimit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.025</para>
                /// </summary>
                [NameInMap("SpotPriceLimit")]
                [Validation(Required=false)]
                public float? SpotPriceLimit { get; set; }

                /// <summary>
                /// <para>The bidding policy of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NoSpot: The instance is a regular pay-as-you-go instance.</description></item>
                /// <item><description>SpotWithPriceLimit: The instance is a preemptible instance that has a user-defined maximum hourly price.</description></item>
                /// <item><description>SpotAsPriceGo: The instance is a preemptible instance for which the market price at the time of purchase is automatically used as the bidding price.</description></item>
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
                /// <item><description>Succeeded: The instance runs successfully.</description></item>
                /// <item><description>Failed: The instance fails to run.</description></item>
                /// <item><description>Scheduling: The instance is being created.</description></item>
                /// <item><description>ScheduleFailed: The instance fails to be created.</description></item>
                /// <item><description>Restarting: The instance is being restarted.</description></item>
                /// <item><description>Updating: The instance is being updated.</description></item>
                /// <item><description>Terminating: The instance is being terminated.</description></item>
                /// <item><description>Expired: The instance expires.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The time when all containers exited on success. The time follows the RFC 3339 standard and must be in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-12-11T04:33:42Z</para>
                /// </summary>
                [NameInMap("SucceededTime")]
                [Validation(Required=false)]
                public string SucceededTime { get; set; }

                /// <summary>
                /// <para>The tags of the instances.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroupsTags> Tags { get; set; }
                public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsTags : TeaModel {
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
                /// <para>This parameter is unavailable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-xxx</para>
                /// </summary>
                [NameInMap("TenantEniInstanceId")]
                [Validation(Required=false)]
                public string TenantEniInstanceId { get; set; }

                /// <summary>
                /// <para>This parameter is unavailable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.10.XX.XX</para>
                /// </summary>
                [NameInMap("TenantEniIp")]
                [Validation(Required=false)]
                public string TenantEniIp { get; set; }

                /// <summary>
                /// <para>This parameter is unavailable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-xxx</para>
                /// </summary>
                [NameInMap("TenantSecurityGroupId")]
                [Validation(Required=false)]
                public string TenantSecurityGroupId { get; set; }

                /// <summary>
                /// <para>This parameter is unavailable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-xxx</para>
                /// </summary>
                [NameInMap("TenantVSwitchId")]
                [Validation(Required=false)]
                public string TenantVSwitchId { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1vzjjflab6wvjox****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The information about volumes.</para>
                /// </summary>
                [NameInMap("Volumes")]
                [Validation(Required=false)]
                public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroupsVolumes> Volumes { get; set; }
                public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsVolumes : TeaModel {
                    /// <summary>
                    /// <para>The paths to configuration files.</para>
                    /// </summary>
                    [NameInMap("ConfigFileVolumeConfigFileToPaths")]
                    [Validation(Required=false)]
                    public List<DescribeServerlessJobsResponseBodyJobInfosContainerGroupsVolumesConfigFileVolumeConfigFileToPaths> ConfigFileVolumeConfigFileToPaths { get; set; }
                    public class DescribeServerlessJobsResponseBodyJobInfosContainerGroupsVolumesConfigFileVolumeConfigFileToPaths : TeaModel {
                        /// <summary>
                        /// <para>The content of the configuration file. Maximum size: 32 KB.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>hello world</para>
                        /// </summary>
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// <para>The relative path to the configuration file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/usr/bin/</para>
                        /// </summary>
                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                    }

                    /// <summary>
                    /// <para>The ID of the disk volume if you set Type to DiskVolume.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>d-xxxx</para>
                    /// </summary>
                    [NameInMap("DiskVolumeDiskId")]
                    [Validation(Required=false)]
                    public string DiskVolumeDiskId { get; set; }

                    /// <summary>
                    /// <para>The type of the volume.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xfs</para>
                    /// </summary>
                    [NameInMap("DiskVolumeFsType")]
                    [Validation(Required=false)]
                    public string DiskVolumeFsType { get; set; }

                    /// <summary>
                    /// <para>The storage media for the emptyDir volume. This parameter is empty by default, which indicates that the node file system is used as the storage media. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Memory: uses memory as the storage media.</description></item>
                    /// <item><description>LocalRaid0: forms local disks into RAID 0. This value is valid only if an elastic container instance that has local disks mounted is created. For more information, see <a href="https://help.aliyun.com/document_detail/114664.html">Create an elastic container instance that has local disks mounted</a>.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Memory</para>
                    /// </summary>
                    [NameInMap("EmptyDirVolumeMedium")]
                    [Validation(Required=false)]
                    public string EmptyDirVolumeMedium { get; set; }

                    /// <summary>
                    /// <para>The storage size of the emptyDir volume. If you specify this parameter, include the unit in the value. We recommend that you use Gi or Mi.</para>
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
                    /// <para>The file system type when you set the Type parameter to FlexVolume. The default value is determined by the script of the FlexVolume plug-in.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ntfs</para>
                    /// </summary>
                    [NameInMap("FlexVolumeFsType")]
                    [Validation(Required=false)]
                    public string FlexVolumeFsType { get; set; }

                    /// <summary>
                    /// <para>The FlexVolume options.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[nolock,tcp,noresvport]</para>
                    /// </summary>
                    [NameInMap("FlexVolumeOptions")]
                    [Validation(Required=false)]
                    public string FlexVolumeOptions { get; set; }

                    /// <summary>
                    /// <para>The path of the Network File System (NFS) volume.</para>
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
                    /// <para>The endpoint of the server if you set Type to NFSVolume.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0eafxxxxx-xxxxx.cn-hangzhou.nas.aliyuncs.com</para>
                    /// </summary>
                    [NameInMap("NFSVolumeServer")]
                    [Validation(Required=false)]
                    public string NFSVolumeServer { get; set; }

                    /// <summary>
                    /// <para>The name of the volume.</para>
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
                /// <para>The ID of the virtual private cloud (VPC) to which the elastic container instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-1vzjjflab6wvjox****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The ID of the zone in which the elastic container instance is deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-h</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <para>The time when the serverless job ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1662016121</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the job is an array job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsArrayJob")]
            [Validation(Required=false)]
            public bool? IsArrayJob { get; set; }

            /// <summary>
            /// <para>The ID of the serverless job or the subtask (array job).</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The name of the serverless job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testjob</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <para>The time when the serverless job is last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1663831441000</para>
            /// </summary>
            [NameInMap("LastModifyTime")]
            [Validation(Required=false)]
            public long? LastModifyTime { get; set; }

            /// <summary>
            /// <para>The scheduling priority of the serverless job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            /// <summary>
            /// <para>The name of the queue in which the serverless job is run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comp</para>
            /// </summary>
            [NameInMap("Queue")]
            [Validation(Required=false)]
            public string Queue { get; set; }

            /// <summary>
            /// <para>The time when the serverless job started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1647427667</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The status of the serverless job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending</description></item>
            /// <item><description>Initing</description></item>
            /// <item><description>Running</description></item>
            /// <item><description>Succeeded</description></item>
            /// <item><description>Canceled</description></item>
            /// <item><description>Failed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The time when the serverless job is submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1647423718</para>
            /// </summary>
            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public long? SubmitTime { get; set; }

            /// <summary>
            /// <para>The username that is used to run the serverless job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testuser</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
