// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetChangeOrderInfoResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The additional information that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details about the change process.
        /// </summary>
        [NameInMap("changeOrderInfo")]
        [Validation(Required=false)]
        public GetChangeOrderInfoResponseBodyChangeOrderInfo ChangeOrderInfo { get; set; }
        public class GetChangeOrderInfoResponseBodyChangeOrderInfo : TeaModel {
            /// <summary>
            /// The number of batches for the change.
            /// </summary>
            [NameInMap("BatchCount")]
            [Validation(Required=false)]
            public int? BatchCount { get; set; }

            /// <summary>
            /// Indicates whether the change for the next batch is automatically or manually triggered when phased release is performed. Valid values:
            /// 
            /// *   Automatic: The change for the next batch is automatically triggered.
            /// *   Manual: The change for the next batch is manually triggered.
            /// </summary>
            [NameInMap("BatchType")]
            [Validation(Required=false)]
            public string BatchType { get; set; }

            /// <summary>
            /// The description of the change process.
            /// </summary>
            [NameInMap("ChangeOrderDescription")]
            [Validation(Required=false)]
            public string ChangeOrderDescription { get; set; }

            /// <summary>
            /// The ID of the change process.
            /// </summary>
            [NameInMap("ChangeOrderId")]
            [Validation(Required=false)]
            public string ChangeOrderId { get; set; }

            /// <summary>
            /// The type of the change process.
            /// </summary>
            [NameInMap("CoType")]
            [Validation(Required=false)]
            public string CoType { get; set; }

            /// <summary>
            /// The time when the change process is created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The person in charge of the change process.
            /// </summary>
            [NameInMap("CreateUserId")]
            [Validation(Required=false)]
            public string CreateUserId { get; set; }

            /// <summary>
            /// The description of the change process.
            /// </summary>
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// The information about the batches of the change task.
            /// </summary>
            [NameInMap("PipelineInfoList")]
            [Validation(Required=false)]
            public GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoList PipelineInfoList { get; set; }
            public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoList : TeaModel {
                [NameInMap("PipelineInfo")]
                [Validation(Required=false)]
                public List<GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfo> PipelineInfo { get; set; }
                public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfo : TeaModel {
                    /// <summary>
                    /// The ID of each batch for the change during the phased release.
                    /// </summary>
                    [NameInMap("PipelineId")]
                    [Validation(Required=false)]
                    public string PipelineId { get; set; }

                    /// <summary>
                    /// The name of the batch.
                    /// </summary>
                    [NameInMap("PipelineName")]
                    [Validation(Required=false)]
                    public string PipelineName { get; set; }

                    /// <summary>
                    /// The state of the change task. Valid values:
                    /// 
                    /// *   0: ready
                    /// *   1: in progress
                    /// *   2: successful
                    /// *   3: failed
                    /// *   6: terminated
                    /// *   8: wait for manual confirmation to trigger the next batch during a manual phased release
                    /// *   9: wait to trigger the next batch during an automatic phased release
                    /// *   10: failed due to a system exception
                    /// </summary>
                    [NameInMap("PipelineStatus")]
                    [Validation(Required=false)]
                    public int? PipelineStatus { get; set; }

                    /// <summary>
                    /// The execution results in each stage.
                    /// </summary>
                    [NameInMap("StageDetailList")]
                    [Validation(Required=false)]
                    public GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageDetailList StageDetailList { get; set; }
                    public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageDetailList : TeaModel {
                        [NameInMap("StageDetailDTO")]
                        [Validation(Required=false)]
                        public List<GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageDetailListStageDetailDTO> StageDetailDTO { get; set; }
                        public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageDetailListStageDetailDTO : TeaModel {
                            /// <summary>
                            /// The ID of the stage.
                            /// </summary>
                            [NameInMap("StageId")]
                            [Validation(Required=false)]
                            public string StageId { get; set; }

                            /// <summary>
                            /// The name of the stage.
                            /// </summary>
                            [NameInMap("StageName")]
                            [Validation(Required=false)]
                            public string StageName { get; set; }

                            /// <summary>
                            /// The status of the stage. Valid values:
                            /// 
                            /// *   0: ready
                            /// *   1: in progress
                            /// *   2: successful
                            /// *   3: failed
                            /// *   6: terminated
                            /// *   8: wait for manual confirmation to trigger the next batch during a manual phased release
                            /// *   9: wait to trigger the next batch during an automatic phased release
                            /// *   10: failed due to a system exception
                            /// </summary>
                            [NameInMap("StageStatus")]
                            [Validation(Required=false)]
                            public int? StageStatus { get; set; }

                            /// <summary>
                            /// The information about the task.
                            /// </summary>
                            [NameInMap("TaskList")]
                            [Validation(Required=false)]
                            public GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageDetailListStageDetailDTOTaskList TaskList { get; set; }
                            public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageDetailListStageDetailDTOTaskList : TeaModel {
                                [NameInMap("TaskInfoDTO")]
                                [Validation(Required=false)]
                                public List<GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageDetailListStageDetailDTOTaskListTaskInfoDTO> TaskInfoDTO { get; set; }
                                public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageDetailListStageDetailDTOTaskListTaskInfoDTO : TeaModel {
                                    /// <summary>
                                    /// The type of the retry policy. Value 0 indicates no retry, value 1 indicates automatic retry, and value 2 indicates manual retry.
                                    /// </summary>
                                    [NameInMap("RetryType")]
                                    [Validation(Required=false)]
                                    public int? RetryType { get; set; }

                                    /// <summary>
                                    /// Indicates whether errors that occur in the change process are ignored. Valid values:``
                                    /// 
                                    /// *   true: Errors that occur in the change process are ignored. This parameter can be set to true only when URL health checks are performed.
                                    /// *   false: Errors that occur in the change process are not ignored.
                                    /// </summary>
                                    [NameInMap("ShowManualIgnorance")]
                                    [Validation(Required=false)]
                                    public bool? ShowManualIgnorance { get; set; }

                                    /// <summary>
                                    /// Error codes
                                    /// </summary>
                                    [NameInMap("TaskErrorCode")]
                                    [Validation(Required=false)]
                                    public string TaskErrorCode { get; set; }

                                    /// <summary>
                                    /// Indicates whether the task is error-tolerant. If the task can tolerate errors, the errors that occur in the change process are ignored and the next task is executed.
                                    /// 
                                    /// *   0: The task is not error-tolerant.
                                    /// *   1: The task is error-tolerant.
                                    /// </summary>
                                    [NameInMap("TaskErrorIgnorance")]
                                    [Validation(Required=false)]
                                    public int? TaskErrorIgnorance { get; set; }

                                    /// <summary>
                                    /// The error message for the task.
                                    /// </summary>
                                    [NameInMap("TaskErrorMessage")]
                                    [Validation(Required=false)]
                                    public string TaskErrorMessage { get; set; }

                                    /// <summary>
                                    /// The ID of the task.
                                    /// </summary>
                                    [NameInMap("TaskId")]
                                    [Validation(Required=false)]
                                    public string TaskId { get; set; }

                                    /// <summary>
                                    /// Task information
                                    /// </summary>
                                    [NameInMap("TaskMessage")]
                                    [Validation(Required=false)]
                                    public string TaskMessage { get; set; }

                                    /// <summary>
                                    /// The name of the task.
                                    /// </summary>
                                    [NameInMap("TaskName")]
                                    [Validation(Required=false)]
                                    public string TaskName { get; set; }

                                    /// <summary>
                                    /// The state of the task. Valid values:
                                    /// 
                                    /// *   0: ready
                                    /// *   1: in progress
                                    /// *   2: successful
                                    /// *   3: failed
                                    /// *   6: terminated
                                    /// *   8: wait for manual confirmation to trigger the next batch during a manual phased release
                                    /// *   9: wait to trigger the next batch during an automatic phased release
                                    /// *   10: failed due to a system exception
                                    /// </summary>
                                    [NameInMap("TaskStatus")]
                                    [Validation(Required=false)]
                                    public string TaskStatus { get; set; }

                                }

                            }

                        }

                    }

                    /// <summary>
                    /// The stages of the change process.
                    /// </summary>
                    [NameInMap("StageList")]
                    [Validation(Required=false)]
                    public GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageList StageList { get; set; }
                    public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageList : TeaModel {
                        [NameInMap("StageInfoDTO")]
                        [Validation(Required=false)]
                        public List<GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTO> StageInfoDTO { get; set; }
                        public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTO : TeaModel {
                            /// <summary>
                            /// The ID of the stage.
                            /// </summary>
                            [NameInMap("StageId")]
                            [Validation(Required=false)]
                            public string StageId { get; set; }

                            /// <summary>
                            /// The name of the stage.
                            /// </summary>
                            [NameInMap("StageName")]
                            [Validation(Required=false)]
                            public string StageName { get; set; }

                            /// <summary>
                            /// The results of the task executed in the stage.
                            /// </summary>
                            [NameInMap("StageResultDTO")]
                            [Validation(Required=false)]
                            public GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTO StageResultDTO { get; set; }
                            public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTO : TeaModel {
                                /// <summary>
                                /// The results of the task executed on each Elastic Compute Service (ECS) instance in each stage.
                                /// </summary>
                                [NameInMap("InstanceDTOList")]
                                [Validation(Required=false)]
                                public GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOInstanceDTOList InstanceDTOList { get; set; }
                                public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOInstanceDTOList : TeaModel {
                                    [NameInMap("InstanceDTO")]
                                    [Validation(Required=false)]
                                    public List<GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOInstanceDTOListInstanceDTO> InstanceDTO { get; set; }
                                    public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOInstanceDTOListInstanceDTO : TeaModel {
                                        /// <summary>
                                        /// The IP address of the ECS instance.
                                        /// </summary>
                                        [NameInMap("InstanceIp")]
                                        [Validation(Required=false)]
                                        public string InstanceIp { get; set; }

                                        /// <summary>
                                        /// The name of the ECS instance.
                                        /// </summary>
                                        [NameInMap("InstanceName")]
                                        [Validation(Required=false)]
                                        public string InstanceName { get; set; }

                                        /// <summary>
                                        /// The results of the task executed on the ECS instance in each stage.
                                        /// </summary>
                                        [NameInMap("InstanceStageDTOList")]
                                        [Validation(Required=false)]
                                        public GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOInstanceDTOListInstanceDTOInstanceStageDTOList InstanceStageDTOList { get; set; }
                                        public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOInstanceDTOListInstanceDTOInstanceStageDTOList : TeaModel {
                                            [NameInMap("InstanceStageDTO")]
                                            [Validation(Required=false)]
                                            public List<GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOInstanceDTOListInstanceDTOInstanceStageDTOListInstanceStageDTO> InstanceStageDTO { get; set; }
                                            public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOInstanceDTOListInstanceDTOInstanceStageDTOListInstanceStageDTO : TeaModel {
                                                /// <summary>
                                                /// The time when the execution stopped.
                                                /// </summary>
                                                [NameInMap("FinishTime")]
                                                [Validation(Required=false)]
                                                public string FinishTime { get; set; }

                                                /// <summary>
                                                /// The ID of the stage.
                                                /// </summary>
                                                [NameInMap("StageId")]
                                                [Validation(Required=false)]
                                                public string StageId { get; set; }

                                                /// <summary>
                                                /// The information about the stage.
                                                /// </summary>
                                                [NameInMap("StageMessage")]
                                                [Validation(Required=false)]
                                                public string StageMessage { get; set; }

                                                /// <summary>
                                                /// The name of the stage.
                                                /// </summary>
                                                [NameInMap("StageName")]
                                                [Validation(Required=false)]
                                                public string StageName { get; set; }

                                                /// <summary>
                                                /// The time when the execution was started.
                                                /// </summary>
                                                [NameInMap("StartTime")]
                                                [Validation(Required=false)]
                                                public string StartTime { get; set; }

                                                /// <summary>
                                                /// The state of the stage. Valid values:
                                                /// 
                                                /// *   0: ready
                                                /// *   1: in progress
                                                /// *   2: successful
                                                /// *   3: failed
                                                /// *   6: terminated
                                                /// *   8: wait for manual confirmation to trigger the next batch during a manual phased release
                                                /// *   9: wait to trigger the next batch during an automatic phased release
                                                /// *   10: failed due to a system exception
                                                /// </summary>
                                                [NameInMap("Status")]
                                                [Validation(Required=false)]
                                                public int? Status { get; set; }

                                            }

                                        }

                                        /// <summary>
                                        /// The name of the node.
                                        /// </summary>
                                        [NameInMap("PodName")]
                                        [Validation(Required=false)]
                                        public string PodName { get; set; }

                                        /// <summary>
                                        /// The state of the pod.
                                        /// </summary>
                                        [NameInMap("PodStatus")]
                                        [Validation(Required=false)]
                                        public string PodStatus { get; set; }

                                        /// <summary>
                                        /// The running state. Valid values:
                                        /// 
                                        /// *   0: ready
                                        /// *   1: in progress
                                        /// *   2: successful
                                        /// *   3: failed
                                        /// *   6: terminated
                                        /// *   8: wait for manual confirmation to trigger the next batch during a manual phased release
                                        /// *   9: wait to trigger the next batch during an automatic phased release
                                        /// *   10: failed due to a system exception
                                        /// </summary>
                                        [NameInMap("Status")]
                                        [Validation(Required=false)]
                                        public int? Status { get; set; }

                                    }

                                }

                                /// <summary>
                                /// The results of tasks executed in each service-oriented stage.
                                /// </summary>
                                [NameInMap("ServiceStage")]
                                [Validation(Required=false)]
                                public GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOServiceStage ServiceStage { get; set; }
                                public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOServiceStage : TeaModel {
                                    /// <summary>
                                    /// The execution result in the stage.
                                    /// </summary>
                                    [NameInMap("Message")]
                                    [Validation(Required=false)]
                                    public string Message { get; set; }

                                    /// <summary>
                                    /// The ID of the stage.
                                    /// </summary>
                                    [NameInMap("StageId")]
                                    [Validation(Required=false)]
                                    public string StageId { get; set; }

                                    /// <summary>
                                    /// Phase Name
                                    /// </summary>
                                    [NameInMap("StageName")]
                                    [Validation(Required=false)]
                                    public string StageName { get; set; }

                                    /// <summary>
                                    /// The running state. Valid values:
                                    /// 
                                    /// *   0: ready
                                    /// *   1: in progress
                                    /// *   2: successful
                                    /// *   3: failed
                                    /// *   6: terminated
                                    /// *   8: wait for manual confirmation to trigger the next batch during a manual phased release
                                    /// *   9: wait to trigger the next batch during an automatic phased release
                                    /// *   10: failed due to a system exception
                                    /// </summary>
                                    [NameInMap("Status")]
                                    [Validation(Required=false)]
                                    public int? Status { get; set; }

                                }

                            }

                            /// <summary>
                            /// The state of the stage. Valid values:
                            /// 
                            /// *   0: ready
                            /// *   1: in progress
                            /// *   2: successful
                            /// *   3: failed
                            /// *   6: terminated
                            /// *   8: wait for manual confirmation to trigger the next batch during a manual phased release
                            /// *   9: wait to trigger the next batch during an automatic phased release
                            /// *   10: failed due to a system exception
                            /// </summary>
                            [NameInMap("Status")]
                            [Validation(Required=false)]
                            public int? Status { get; set; }

                        }

                    }

                    /// <summary>
                    /// The time when the change task was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// The time when the change task was updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                    /// </summary>
                    [NameInMap("UpdateTime")]
                    [Validation(Required=false)]
                    public string UpdateTime { get; set; }

                }

            }

            /// <summary>
            /// The state of the change process. Valid values:
            /// 
            /// *   0: ready
            /// *   1: in progress
            /// *   2: successful
            /// *   3: failed
            /// *   6: terminated
            /// *   7: partially executed
            /// *   8: wait for manual confirmation to trigger the next batch during a manual phased release
            /// *   9: wait to trigger the next batch during an automatic phased release
            /// *   10: failed due to a system exception
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// Indicates whether rollbacks are allowed. Valid values:
            /// 
            /// *   true: Rollbacks are allowed.
            /// *   false: Rollbacks are not allowed.
            /// </summary>
            [NameInMap("SupportRollback")]
            [Validation(Required=false)]
            public bool? SupportRollback { get; set; }

            [NameInMap("Targets")]
            [Validation(Required=false)]
            public GetChangeOrderInfoResponseBodyChangeOrderInfoTargets Targets { get; set; }
            public class GetChangeOrderInfoResponseBodyChangeOrderInfoTargets : TeaModel {
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<string> Items { get; set; }

            }

            /// <summary>
            /// The throttling rules.
            /// </summary>
            [NameInMap("TrafficControl")]
            [Validation(Required=false)]
            public GetChangeOrderInfoResponseBodyChangeOrderInfoTrafficControl TrafficControl { get; set; }
            public class GetChangeOrderInfoResponseBodyChangeOrderInfoTrafficControl : TeaModel {
                /// <summary>
                /// The route forwarding policy.
                /// </summary>
                [NameInMap("Routes")]
                [Validation(Required=false)]
                public string Routes { get; set; }

                /// <summary>
                /// The traffic routing rules.
                /// </summary>
                [NameInMap("Rules")]
                [Validation(Required=false)]
                public string Rules { get; set; }

                /// <summary>
                /// The description of throttling rules.
                /// </summary>
                [NameInMap("Tips")]
                [Validation(Required=false)]
                public string Tips { get; set; }

            }

        }

    }

}
