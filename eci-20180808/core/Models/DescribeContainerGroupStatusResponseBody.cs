// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeContainerGroupStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The collection of the statuses of the container groups.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeContainerGroupStatusResponseBodyData> Data { get; set; }
        public class DescribeContainerGroupStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Annotations that are added to the container groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;{\&quot;tenancy.x-k8s.io/namespace\&quot;:\&quot;redis\&quot;}&quot;</para>
            /// </summary>
            [NameInMap("Annotations")]
            [Validation(Required=false)]
            public string Annotations { get; set; }

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
            /// <para>nginx</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The namespace in which the container group resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The status of the container group.</para>
            /// </summary>
            [NameInMap("PodStatus")]
            [Validation(Required=false)]
            public DescribeContainerGroupStatusResponseBodyDataPodStatus PodStatus { get; set; }
            public class DescribeContainerGroupStatusResponseBodyDataPodStatus : TeaModel {
                /// <summary>
                /// <para>The conditions of the container group.</para>
                /// </summary>
                [NameInMap("Conditions")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupStatusResponseBodyDataPodStatusConditions> Conditions { get; set; }
                public class DescribeContainerGroupStatusResponseBodyDataPodStatusConditions : TeaModel {
                    /// <summary>
                    /// <para>The message about the event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Completed</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// <para>The reason for the transition into the current status of the event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Completed</para>
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    /// <summary>
                    /// <para>The time when the status last changed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2021-05-12T07:02:47Z</para>
                    /// </summary>
                    [NameInMap("lastTransitionTime")]
                    [Validation(Required=false)]
                    public string LastTransitionTime { get; set; }

                    /// <summary>
                    /// <para>The status of the condition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>True</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The type of the condition. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>PodReadyToStartContainers</description></item>
                    /// <item><description>Initialized</description></item>
                    /// <item><description>Ready</description></item>
                    /// <item><description>ContainersReady</description></item>
                    /// <item><description>PodScheduled</description></item>
                    /// <item><description>ContainerHasSufficientDisk</description></item>
                    /// <item><description>ContainerInstanceCreated</description></item>
                    /// <item><description>Unschedulable</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ready</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The statuses about the containers.</para>
                /// </summary>
                [NameInMap("ContainerStatuses")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatuses> ContainerStatuses { get; set; }
                public class DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatuses : TeaModel {
                    /// <summary>
                    /// <para>The image of the container.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>registry-vpc.cn-zhangjiakou.aliyuncs.com/eci_open/ubuntu:18.04</para>
                    /// </summary>
                    [NameInMap("Image")]
                    [Validation(Required=false)]
                    public string Image { get; set; }

                    /// <summary>
                    /// <para>The image ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>registry-vpc.cn-zhangjiakou.aliyuncs.com/eci_open/ubuntu@sha256:134c7fe821b9d359490cd009ce7ca322453f4f2d018623f849e580a89a685e5d</para>
                    /// </summary>
                    [NameInMap("ImageID")]
                    [Validation(Required=false)]
                    public string ImageID { get; set; }

                    /// <summary>
                    /// <para>The last status of the container.</para>
                    /// </summary>
                    [NameInMap("LastState")]
                    [Validation(Required=false)]
                    public DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesLastState LastState { get; set; }
                    public class DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesLastState : TeaModel {
                        /// <summary>
                        /// <para>The container is created and running.</para>
                        /// </summary>
                        [NameInMap("Running")]
                        [Validation(Required=false)]
                        public DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesLastStateRunning Running { get; set; }
                        public class DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesLastStateRunning : TeaModel {
                            /// <summary>
                            /// <para>The time when the container started to run.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2021-05-23T20:49:31Z</para>
                            /// </summary>
                            [NameInMap("StartedAtstartedAt")]
                            [Validation(Required=false)]
                            public string StartedAtstartedAt { get; set; }

                        }

                        /// <summary>
                        /// <para>The container is terminated and exits after a successful or failed running.</para>
                        /// </summary>
                        [NameInMap("Terminated")]
                        [Validation(Required=false)]
                        public DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesLastStateTerminated Terminated { get; set; }
                        public class DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesLastStateTerminated : TeaModel {
                            /// <summary>
                            /// <para>The container ID.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>containerd://3ff993933bea366c4719e43a1b067d89bc7f01f1f573981659a44ff17a******</para>
                            /// </summary>
                            [NameInMap("ContainerID")]
                            [Validation(Required=false)]
                            public string ContainerID { get; set; }

                            /// <summary>
                            /// <para>The exit code.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("ExitCode")]
                            [Validation(Required=false)]
                            public int? ExitCode { get; set; }

                            /// <summary>
                            /// <para>The time when the container ends running.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2021-05-23T20:49:31Z</para>
                            /// </summary>
                            [NameInMap("FinishedAt")]
                            [Validation(Required=false)]
                            public string FinishedAt { get; set; }

                            /// <summary>
                            /// <para>The message about the event.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Completed</para>
                            /// </summary>
                            [NameInMap("Message")]
                            [Validation(Required=false)]
                            public string Message { get; set; }

                            /// <summary>
                            /// <para>The reason for the transition into the current status of the event.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Completed</para>
                            /// </summary>
                            [NameInMap("Reason")]
                            [Validation(Required=false)]
                            public string Reason { get; set; }

                            /// <summary>
                            /// <para>The signal code.</para>
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
                            /// <para>2021-05-12T07:02:52Z</para>
                            /// </summary>
                            [NameInMap("StartedAt")]
                            [Validation(Required=false)]
                            public string StartedAt { get; set; }

                        }

                        /// <summary>
                        /// <para>The container is waiting for being created.</para>
                        /// </summary>
                        [NameInMap("Waiting")]
                        [Validation(Required=false)]
                        public DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesLastStateWaiting Waiting { get; set; }
                        public class DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesLastStateWaiting : TeaModel {
                            /// <summary>
                            /// <para>The message about the event.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Back-off</para>
                            /// </summary>
                            [NameInMap("Message")]
                            [Validation(Required=false)]
                            public string Message { get; set; }

                            /// <summary>
                            /// <para>The reason for the transition into the current status of the event.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Started</para>
                            /// </summary>
                            [NameInMap("Reason")]
                            [Validation(Required=false)]
                            public string Reason { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The name of the container.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ubuntu</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the container is ready.</para>
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
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("RestartCount")]
                    [Validation(Required=false)]
                    public int? RestartCount { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the container is started.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Started")]
                    [Validation(Required=false)]
                    public bool? Started { get; set; }

                    /// <summary>
                    /// <para>The status of the container. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Waiting</description></item>
                    /// <item><description>Running</description></item>
                    /// <item><description>Terminated</description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesState State { get; set; }
                    public class DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesState : TeaModel {
                        /// <summary>
                        /// <para>The container is created and running.</para>
                        /// </summary>
                        [NameInMap("Running")]
                        [Validation(Required=false)]
                        public DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesStateRunning Running { get; set; }
                        public class DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesStateRunning : TeaModel {
                            /// <summary>
                            /// <para>The time when the container started to run.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2021-05-23T20:49:31Z</para>
                            /// </summary>
                            [NameInMap("StartedAtstartedAt")]
                            [Validation(Required=false)]
                            public string StartedAtstartedAt { get; set; }

                        }

                        /// <summary>
                        /// <para>The container is terminated and exits after a successful or failed running.</para>
                        /// </summary>
                        [NameInMap("Terminated")]
                        [Validation(Required=false)]
                        public DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesStateTerminated Terminated { get; set; }
                        public class DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesStateTerminated : TeaModel {
                            /// <summary>
                            /// <para>The container ID.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>containerd://3ff993933bea366c4719e43a1b067d89bc7f01f1f573981659a44ff17a******</para>
                            /// </summary>
                            [NameInMap("ContainerID")]
                            [Validation(Required=false)]
                            public string ContainerID { get; set; }

                            /// <summary>
                            /// <para>The exit code.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("ExitCode")]
                            [Validation(Required=false)]
                            public int? ExitCode { get; set; }

                            /// <summary>
                            /// <para>The time when the container ends running.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2021-05-23T20:55:31Z</para>
                            /// </summary>
                            [NameInMap("FinishedAt")]
                            [Validation(Required=false)]
                            public string FinishedAt { get; set; }

                            /// <summary>
                            /// <para>The message about the event.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Completed</para>
                            /// </summary>
                            [NameInMap("Message")]
                            [Validation(Required=false)]
                            public string Message { get; set; }

                            /// <summary>
                            /// <para>The reason for the transition into the current status of the event.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Completed</para>
                            /// </summary>
                            [NameInMap("Reason")]
                            [Validation(Required=false)]
                            public string Reason { get; set; }

                            /// <summary>
                            /// <para>The signal code.</para>
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
                            /// <para>2021-05-23T20:49:31Z</para>
                            /// </summary>
                            [NameInMap("StartedAt")]
                            [Validation(Required=false)]
                            public string StartedAt { get; set; }

                        }

                        /// <summary>
                        /// <para>The container is waiting for being created.</para>
                        /// </summary>
                        [NameInMap("Waiting")]
                        [Validation(Required=false)]
                        public DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesStateWaiting Waiting { get; set; }
                        public class DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesStateWaiting : TeaModel {
                            /// <summary>
                            /// <para>The message about the event.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Back-off</para>
                            /// </summary>
                            [NameInMap("Message")]
                            [Validation(Required=false)]
                            public string Message { get; set; }

                            /// <summary>
                            /// <para>The reason for the transition into the current status of the event.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Started</para>
                            /// </summary>
                            [NameInMap("Reason")]
                            [Validation(Required=false)]
                            public string Reason { get; set; }

                        }

                    }

                }

                /// <summary>
                /// <para>The IP address of the host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.XX.XX</para>
                /// </summary>
                [NameInMap("HostIp")]
                [Validation(Required=false)]
                public string HostIp { get; set; }

                /// <summary>
                /// <para>The lifecycle phase of the container group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Phase")]
                [Validation(Required=false)]
                public string Phase { get; set; }

                /// <summary>
                /// <para>The IP address of the container group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.XX.XX</para>
                /// </summary>
                [NameInMap("PodIp")]
                [Validation(Required=false)]
                public string PodIp { get; set; }

                /// <summary>
                /// <para>The IP addresses of the container groups.</para>
                /// </summary>
                [NameInMap("PodIps")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupStatusResponseBodyDataPodStatusPodIps> PodIps { get; set; }
                public class DescribeContainerGroupStatusResponseBodyDataPodStatusPodIps : TeaModel {
                    /// <summary>
                    /// <para>The IP address of the container group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.168.XX.XX</para>
                    /// </summary>
                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public string Ip { get; set; }

                }

                /// <summary>
                /// <para>The quality of service (QoS) of the container group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Guaranteed</para>
                /// </summary>
                [NameInMap("QosClass")]
                [Validation(Required=false)]
                public string QosClass { get; set; }

                /// <summary>
                /// <para>The time when the container started to run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-05-12T07:02:47Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// <para>The status of the container group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The universally unique identifier (UUID) of the container group, which is similar to the unique identifier (UID) of the Kubernetes pod in terms of the concept and usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>78ee0657-987g-b8b2-1f507dic4****</para>
            /// </summary>
            [NameInMap("uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d78f2dd8-5979-42fe-****-b16db43be5bc</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1340C38D-6189-54D1-86F6-7D5ECF3E0088</para>
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
