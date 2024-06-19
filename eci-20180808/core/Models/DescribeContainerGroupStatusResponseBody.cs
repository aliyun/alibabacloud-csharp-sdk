// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeContainerGroupStatusResponseBody : TeaModel {
        /// <summary>
        /// The collection of the statuses of the container groups.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeContainerGroupStatusResponseBodyData> Data { get; set; }
        public class DescribeContainerGroupStatusResponseBodyData : TeaModel {
            /// <summary>
            /// Annotations that are added to the container groups.
            /// </summary>
            [NameInMap("Annotations")]
            [Validation(Required=false)]
            public string Annotations { get; set; }

            /// <summary>
            /// The ID of the container group.
            /// </summary>
            [NameInMap("ContainerGroupId")]
            [Validation(Required=false)]
            public string ContainerGroupId { get; set; }

            /// <summary>
            /// The name of the container group.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The namespace in which the container group resides.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The status of the container group.
            /// </summary>
            [NameInMap("PodStatus")]
            [Validation(Required=false)]
            public DescribeContainerGroupStatusResponseBodyDataPodStatus PodStatus { get; set; }
            public class DescribeContainerGroupStatusResponseBodyDataPodStatus : TeaModel {
                /// <summary>
                /// The conditions of the container group.
                /// </summary>
                [NameInMap("Conditions")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupStatusResponseBodyDataPodStatusConditions> Conditions { get; set; }
                public class DescribeContainerGroupStatusResponseBodyDataPodStatusConditions : TeaModel {
                    /// <summary>
                    /// The message about the event.
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// The reason for the transition into the current status of the event.
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    /// <summary>
                    /// The time when the status last changed.
                    /// </summary>
                    [NameInMap("lastTransitionTime")]
                    [Validation(Required=false)]
                    public string LastTransitionTime { get; set; }

                    /// <summary>
                    /// The status of the condition.
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// The type of the condition. Valid values:
                    /// 
                    /// *   PodReadyToStartContainers
                    /// *   Initialized
                    /// *   Ready
                    /// *   ContainersReady
                    /// *   PodScheduled
                    /// *   ContainerHasSufficientDisk
                    /// *   ContainerInstanceCreated
                    /// *   Unschedulable
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// The statuses about the containers.
                /// </summary>
                [NameInMap("ContainerStatuses")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatuses> ContainerStatuses { get; set; }
                public class DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatuses : TeaModel {
                    /// <summary>
                    /// The image of the container.
                    /// </summary>
                    [NameInMap("Image")]
                    [Validation(Required=false)]
                    public string Image { get; set; }

                    /// <summary>
                    /// The image ID.
                    /// </summary>
                    [NameInMap("ImageID")]
                    [Validation(Required=false)]
                    public string ImageID { get; set; }

                    /// <summary>
                    /// The last status of the container.
                    /// </summary>
                    [NameInMap("LastState")]
                    [Validation(Required=false)]
                    public DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesLastState LastState { get; set; }
                    public class DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesLastState : TeaModel {
                        /// <summary>
                        /// The container is created and running.
                        /// </summary>
                        [NameInMap("Running")]
                        [Validation(Required=false)]
                        public DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesLastStateRunning Running { get; set; }
                        public class DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesLastStateRunning : TeaModel {
                            /// <summary>
                            /// The time when the container started to run.
                            /// </summary>
                            [NameInMap("StartedAtstartedAt")]
                            [Validation(Required=false)]
                            public string StartedAtstartedAt { get; set; }

                        }

                        /// <summary>
                        /// The container is terminated and exits after a successful or failed running.
                        /// </summary>
                        [NameInMap("Terminated")]
                        [Validation(Required=false)]
                        public DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesLastStateTerminated Terminated { get; set; }
                        public class DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesLastStateTerminated : TeaModel {
                            /// <summary>
                            /// The container ID.
                            /// </summary>
                            [NameInMap("ContainerID")]
                            [Validation(Required=false)]
                            public string ContainerID { get; set; }

                            /// <summary>
                            /// The exit code.
                            /// </summary>
                            [NameInMap("ExitCode")]
                            [Validation(Required=false)]
                            public int? ExitCode { get; set; }

                            /// <summary>
                            /// The time when the container ends running.
                            /// </summary>
                            [NameInMap("FinishedAt")]
                            [Validation(Required=false)]
                            public string FinishedAt { get; set; }

                            /// <summary>
                            /// The message about the event.
                            /// </summary>
                            [NameInMap("Message")]
                            [Validation(Required=false)]
                            public string Message { get; set; }

                            /// <summary>
                            /// The reason for the transition into the current status of the event.
                            /// </summary>
                            [NameInMap("Reason")]
                            [Validation(Required=false)]
                            public string Reason { get; set; }

                            /// <summary>
                            /// The signal code.
                            /// </summary>
                            [NameInMap("Signal")]
                            [Validation(Required=false)]
                            public int? Signal { get; set; }

                            /// <summary>
                            /// The time when the container started to run.
                            /// </summary>
                            [NameInMap("StartedAt")]
                            [Validation(Required=false)]
                            public string StartedAt { get; set; }

                        }

                        /// <summary>
                        /// The container is waiting for being created.
                        /// </summary>
                        [NameInMap("Waiting")]
                        [Validation(Required=false)]
                        public DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesLastStateWaiting Waiting { get; set; }
                        public class DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesLastStateWaiting : TeaModel {
                            /// <summary>
                            /// The message about the event.
                            /// </summary>
                            [NameInMap("Message")]
                            [Validation(Required=false)]
                            public string Message { get; set; }

                            /// <summary>
                            /// The reason for the transition into the current status of the event.
                            /// </summary>
                            [NameInMap("Reason")]
                            [Validation(Required=false)]
                            public string Reason { get; set; }

                        }

                    }

                    /// <summary>
                    /// The name of the container.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// Indicates whether the container is ready.
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
                    /// Indicates whether the container is started.
                    /// </summary>
                    [NameInMap("Started")]
                    [Validation(Required=false)]
                    public bool? Started { get; set; }

                    /// <summary>
                    /// The status of the container. Valid values:
                    /// 
                    /// *   Waiting
                    /// *   Running
                    /// *   Terminated
                    /// </summary>
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesState State { get; set; }
                    public class DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesState : TeaModel {
                        /// <summary>
                        /// The container is created and running.
                        /// </summary>
                        [NameInMap("Running")]
                        [Validation(Required=false)]
                        public DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesStateRunning Running { get; set; }
                        public class DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesStateRunning : TeaModel {
                            /// <summary>
                            /// The time when the container started to run.
                            /// </summary>
                            [NameInMap("StartedAtstartedAt")]
                            [Validation(Required=false)]
                            public string StartedAtstartedAt { get; set; }

                        }

                        /// <summary>
                        /// The container is terminated and exits after a successful or failed running.
                        /// </summary>
                        [NameInMap("Terminated")]
                        [Validation(Required=false)]
                        public DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesStateTerminated Terminated { get; set; }
                        public class DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesStateTerminated : TeaModel {
                            /// <summary>
                            /// The container ID.
                            /// </summary>
                            [NameInMap("ContainerID")]
                            [Validation(Required=false)]
                            public string ContainerID { get; set; }

                            /// <summary>
                            /// The exit code.
                            /// </summary>
                            [NameInMap("ExitCode")]
                            [Validation(Required=false)]
                            public int? ExitCode { get; set; }

                            /// <summary>
                            /// The time when the container ends running.
                            /// </summary>
                            [NameInMap("FinishedAt")]
                            [Validation(Required=false)]
                            public string FinishedAt { get; set; }

                            /// <summary>
                            /// The message about the event.
                            /// </summary>
                            [NameInMap("Message")]
                            [Validation(Required=false)]
                            public string Message { get; set; }

                            /// <summary>
                            /// The reason for the transition into the current status of the event.
                            /// </summary>
                            [NameInMap("Reason")]
                            [Validation(Required=false)]
                            public string Reason { get; set; }

                            /// <summary>
                            /// The signal code.
                            /// </summary>
                            [NameInMap("Signal")]
                            [Validation(Required=false)]
                            public int? Signal { get; set; }

                            /// <summary>
                            /// The time when the container started to run.
                            /// </summary>
                            [NameInMap("StartedAt")]
                            [Validation(Required=false)]
                            public string StartedAt { get; set; }

                        }

                        /// <summary>
                        /// The container is waiting for being created.
                        /// </summary>
                        [NameInMap("Waiting")]
                        [Validation(Required=false)]
                        public DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesStateWaiting Waiting { get; set; }
                        public class DescribeContainerGroupStatusResponseBodyDataPodStatusContainerStatusesStateWaiting : TeaModel {
                            /// <summary>
                            /// The message about the event.
                            /// </summary>
                            [NameInMap("Message")]
                            [Validation(Required=false)]
                            public string Message { get; set; }

                            /// <summary>
                            /// The reason for the transition into the current status of the event.
                            /// </summary>
                            [NameInMap("Reason")]
                            [Validation(Required=false)]
                            public string Reason { get; set; }

                        }

                    }

                }

                /// <summary>
                /// The IP address of the host.
                /// </summary>
                [NameInMap("HostIp")]
                [Validation(Required=false)]
                public string HostIp { get; set; }

                /// <summary>
                /// The lifecycle phase of the container group.
                /// </summary>
                [NameInMap("Phase")]
                [Validation(Required=false)]
                public string Phase { get; set; }

                /// <summary>
                /// The IP address of the container group.
                /// </summary>
                [NameInMap("PodIp")]
                [Validation(Required=false)]
                public string PodIp { get; set; }

                /// <summary>
                /// The IP addresses of the container groups.
                /// </summary>
                [NameInMap("PodIps")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupStatusResponseBodyDataPodStatusPodIps> PodIps { get; set; }
                public class DescribeContainerGroupStatusResponseBodyDataPodStatusPodIps : TeaModel {
                    /// <summary>
                    /// The IP address of the container group.
                    /// </summary>
                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public string Ip { get; set; }

                }

                /// <summary>
                /// The quality of service (QoS) of the container group.
                /// </summary>
                [NameInMap("QosClass")]
                [Validation(Required=false)]
                public string QosClass { get; set; }

                /// <summary>
                /// The time when the container started to run.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// The status of the container group.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The universally unique identifier (UUID) of the container group, which is similar to the unique identifier (UID) of the Kubernetes pod in terms of the concept and usage.
            /// </summary>
            [NameInMap("uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
