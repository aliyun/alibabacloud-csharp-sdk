// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetChangeOrderInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4JFR-FV9F***************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details about the change process.</para>
        /// </summary>
        [NameInMap("changeOrderInfo")]
        [Validation(Required=false)]
        public GetChangeOrderInfoResponseBodyChangeOrderInfo ChangeOrderInfo { get; set; }
        public class GetChangeOrderInfoResponseBodyChangeOrderInfo : TeaModel {
            /// <summary>
            /// <para>The number of batches for the change.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BatchCount")]
            [Validation(Required=false)]
            public int? BatchCount { get; set; }

            /// <summary>
            /// <para>Indicates whether the change for the next batch is automatically or manually triggered when phased release is performed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Automatic: The change for the next batch is automatically triggered.</description></item>
            /// <item><description>Manual: The change for the next batch is manually triggered.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Automatic</para>
            /// </summary>
            [NameInMap("BatchType")]
            [Validation(Required=false)]
            public string BatchType { get; set; }

            /// <summary>
            /// <para>The description of the change process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Application scale-out</para>
            /// </summary>
            [NameInMap("ChangeOrderDescription")]
            [Validation(Required=false)]
            public string ChangeOrderDescription { get; set; }

            /// <summary>
            /// <para>The ID of the change process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1074f3e2-e974-4a0e-<b><b>-</b></b>********</para>
            /// </summary>
            [NameInMap("ChangeOrderId")]
            [Validation(Required=false)]
            public string ChangeOrderId { get; set; }

            /// <summary>
            /// <para>The type of the change process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Application Scale Out</para>
            /// </summary>
            [NameInMap("CoType")]
            [Validation(Required=false)]
            public string CoType { get; set; }

            /// <summary>
            /// <para>The time when the change process is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-11-13 14:23:46</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The person in charge of the change process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>edas_com***_****@<em><em><b><b>-</b></b></em>.</em>**</para>
            /// </summary>
            [NameInMap("CreateUserId")]
            [Validation(Required=false)]
            public string CreateUserId { get; set; }

            /// <summary>
            /// <para>The description of the change process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IP of Scale-Out Instance: 47.107.XX.XX</para>
            /// </summary>
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// <para>The information about the batches of the change task.</para>
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
                    /// <para>The ID of each batch for the change during the phased release.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4c4ee320-5e47-4a48-<b><b>-</b></b>********</para>
                    /// </summary>
                    [NameInMap("PipelineId")]
                    [Validation(Required=false)]
                    public string PipelineId { get; set; }

                    /// <summary>
                    /// <para>The name of the batch.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Batch: 1</para>
                    /// </summary>
                    [NameInMap("PipelineName")]
                    [Validation(Required=false)]
                    public string PipelineName { get; set; }

                    /// <summary>
                    /// <para>The state of the change task. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: ready</description></item>
                    /// <item><description>1: in progress</description></item>
                    /// <item><description>2: successful</description></item>
                    /// <item><description>3: failed</description></item>
                    /// <item><description>6: terminated</description></item>
                    /// <item><description>8: wait for manual confirmation to trigger the next batch during a manual phased release</description></item>
                    /// <item><description>9: wait to trigger the next batch during an automatic phased release</description></item>
                    /// <item><description>10: failed due to a system exception</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("PipelineStatus")]
                    [Validation(Required=false)]
                    public int? PipelineStatus { get; set; }

                    /// <summary>
                    /// <para>The execution results in each stage.</para>
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
                            /// <para>The ID of the stage.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>d7561440-10a6-452f-8a90-62f6e7ec****</para>
                            /// </summary>
                            [NameInMap("StageId")]
                            [Validation(Required=false)]
                            public string StageId { get; set; }

                            /// <summary>
                            /// <para>The name of the stage.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Process Start</para>
                            /// </summary>
                            [NameInMap("StageName")]
                            [Validation(Required=false)]
                            public string StageName { get; set; }

                            /// <summary>
                            /// <para>The status of the stage. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>0: ready</description></item>
                            /// <item><description>1: in progress</description></item>
                            /// <item><description>2: successful</description></item>
                            /// <item><description>3: failed</description></item>
                            /// <item><description>6: terminated</description></item>
                            /// <item><description>8: wait for manual confirmation to trigger the next batch during a manual phased release</description></item>
                            /// <item><description>9: wait to trigger the next batch during an automatic phased release</description></item>
                            /// <item><description>10: failed due to a system exception</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2</para>
                            /// </summary>
                            [NameInMap("StageStatus")]
                            [Validation(Required=false)]
                            public int? StageStatus { get; set; }

                            /// <summary>
                            /// <para>The information about the task.</para>
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
                                    /// <para>The type of the retry policy. Value 0 indicates no retry, value 1 indicates automatic retry, and value 2 indicates manual retry.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>0</para>
                                    /// </summary>
                                    [NameInMap("RetryType")]
                                    [Validation(Required=false)]
                                    public int? RetryType { get; set; }

                                    /// <summary>
                                    /// <para>Indicates whether errors that occur in the change process are ignored. Valid values:``</para>
                                    /// <list type="bullet">
                                    /// <item><description>true: Errors that occur in the change process are ignored. This parameter can be set to true only when URL health checks are performed.</description></item>
                                    /// <item><description>false: Errors that occur in the change process are not ignored.</description></item>
                                    /// </list>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>false</para>
                                    /// </summary>
                                    [NameInMap("ShowManualIgnorance")]
                                    [Validation(Required=false)]
                                    public bool? ShowManualIgnorance { get; set; }

                                    /// <summary>
                                    /// <para>Error codes</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>400</para>
                                    /// </summary>
                                    [NameInMap("TaskErrorCode")]
                                    [Validation(Required=false)]
                                    public string TaskErrorCode { get; set; }

                                    /// <summary>
                                    /// <para>Indicates whether the task is error-tolerant. If the task can tolerate errors, the errors that occur in the change process are ignored and the next task is executed.</para>
                                    /// <list type="bullet">
                                    /// <item><description>0: The task is not error-tolerant.</description></item>
                                    /// <item><description>1: The task is error-tolerant.</description></item>
                                    /// </list>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>0</para>
                                    /// </summary>
                                    [NameInMap("TaskErrorIgnorance")]
                                    [Validation(Required=false)]
                                    public int? TaskErrorIgnorance { get; set; }

                                    /// <summary>
                                    /// <para>The error message for the task.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>400</para>
                                    /// </summary>
                                    [NameInMap("TaskErrorMessage")]
                                    [Validation(Required=false)]
                                    public string TaskErrorMessage { get; set; }

                                    /// <summary>
                                    /// <para>The ID of the task.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>d6d3b934-90a1-4ae8-8cbd-2446003d****</para>
                                    /// </summary>
                                    [NameInMap("TaskId")]
                                    [Validation(Required=false)]
                                    public string TaskId { get; set; }

                                    /// <summary>
                                    /// <para>Task information</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>[CALLBACK] 2020-03-11 15:28:44.781  requestId: c952ab99-8c5b-4ff1-9412-ae3bf9b1****, message: success</para>
                                    /// </summary>
                                    [NameInMap("TaskMessage")]
                                    [Validation(Required=false)]
                                    public string TaskMessage { get; set; }

                                    /// <summary>
                                    /// <para>The name of the task.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>Build Image</para>
                                    /// </summary>
                                    [NameInMap("TaskName")]
                                    [Validation(Required=false)]
                                    public string TaskName { get; set; }

                                    /// <summary>
                                    /// <para>The state of the task. Valid values:</para>
                                    /// <list type="bullet">
                                    /// <item><description>0: ready</description></item>
                                    /// <item><description>1: in progress</description></item>
                                    /// <item><description>2: successful</description></item>
                                    /// <item><description>3: failed</description></item>
                                    /// <item><description>6: terminated</description></item>
                                    /// <item><description>8: wait for manual confirmation to trigger the next batch during a manual phased release</description></item>
                                    /// <item><description>9: wait to trigger the next batch during an automatic phased release</description></item>
                                    /// <item><description>10: failed due to a system exception</description></item>
                                    /// </list>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>2</para>
                                    /// </summary>
                                    [NameInMap("TaskStatus")]
                                    [Validation(Required=false)]
                                    public string TaskStatus { get; set; }

                                }

                            }

                        }

                    }

                    /// <summary>
                    /// <para>The stages of the change process.</para>
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
                            /// <para>The ID of the stage.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>358a143f-09a0-45e0-<b><b>-</b></b>********@<b><em>*******</em>***</b></para>
                            /// </summary>
                            [NameInMap("StageId")]
                            [Validation(Required=false)]
                            public string StageId { get; set; }

                            /// <summary>
                            /// <para>The name of the stage.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Scale Out</para>
                            /// </summary>
                            [NameInMap("StageName")]
                            [Validation(Required=false)]
                            public string StageName { get; set; }

                            /// <summary>
                            /// <para>The results of the task executed in the stage.</para>
                            /// </summary>
                            [NameInMap("StageResultDTO")]
                            [Validation(Required=false)]
                            public GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTO StageResultDTO { get; set; }
                            public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTO : TeaModel {
                                /// <summary>
                                /// <para>The results of the task executed on each Elastic Compute Service (ECS) instance in each stage.</para>
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
                                        /// <para>The IP address of the ECS instance.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>47.XX.XX.12 (Public)<br><em><b>.</b>.</em>.*** (*******)</para>
                                        /// </summary>
                                        [NameInMap("InstanceIp")]
                                        [Validation(Required=false)]
                                        public string InstanceIp { get; set; }

                                        /// <summary>
                                        /// <para>The name of the ECS instance.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>EDAS-scaled</para>
                                        /// </summary>
                                        [NameInMap("InstanceName")]
                                        [Validation(Required=false)]
                                        public string InstanceName { get; set; }

                                        /// <summary>
                                        /// <para>The results of the task executed on the ECS instance in each stage.</para>
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
                                                /// <para>The time when the execution stopped.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>2020-03-11T07:28:52Z</para>
                                                /// </summary>
                                                [NameInMap("FinishTime")]
                                                [Validation(Required=false)]
                                                public string FinishTime { get; set; }

                                                /// <summary>
                                                /// <para>The ID of the stage.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>5dd4c0f2-d81a-406f-<b><b>-</b></b>********</para>
                                                /// </summary>
                                                [NameInMap("StageId")]
                                                [Validation(Required=false)]
                                                public string StageId { get; set; }

                                                /// <summary>
                                                /// <para>The information about the stage.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>Pulling image \&quot;registry-vpc.cn-hangzhou.aliyuncs.com****-user/1172745****_shared_repo:428084d6-265f-<b><b>-911a-7eb0d2c3</b></b>_15839117****\</para>
                                                /// </summary>
                                                [NameInMap("StageMessage")]
                                                [Validation(Required=false)]
                                                public string StageMessage { get; set; }

                                                /// <summary>
                                                /// <para>The name of the stage.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>scale out</para>
                                                /// </summary>
                                                [NameInMap("StageName")]
                                                [Validation(Required=false)]
                                                public string StageName { get; set; }

                                                /// <summary>
                                                /// <para>The time when the execution was started.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>2020-03-11T07:28:49Z</para>
                                                /// </summary>
                                                [NameInMap("StartTime")]
                                                [Validation(Required=false)]
                                                public string StartTime { get; set; }

                                                /// <summary>
                                                /// <para>The state of the stage. Valid values:</para>
                                                /// <list type="bullet">
                                                /// <item><description>0: ready</description></item>
                                                /// <item><description>1: in progress</description></item>
                                                /// <item><description>2: successful</description></item>
                                                /// <item><description>3: failed</description></item>
                                                /// <item><description>6: terminated</description></item>
                                                /// <item><description>8: wait for manual confirmation to trigger the next batch during a manual phased release</description></item>
                                                /// <item><description>9: wait to trigger the next batch during an automatic phased release</description></item>
                                                /// <item><description>10: failed due to a system exception</description></item>
                                                /// </list>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>2</para>
                                                /// </summary>
                                                [NameInMap("Status")]
                                                [Validation(Required=false)]
                                                public int? Status { get; set; }

                                            }

                                        }

                                        /// <summary>
                                        /// <para>The name of the node.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>canary-test</para>
                                        /// </summary>
                                        [NameInMap("PodName")]
                                        [Validation(Required=false)]
                                        public string PodName { get; set; }

                                        /// <summary>
                                        /// <para>The state of the pod.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>In progress</para>
                                        /// </summary>
                                        [NameInMap("PodStatus")]
                                        [Validation(Required=false)]
                                        public string PodStatus { get; set; }

                                        /// <summary>
                                        /// <para>The running state. Valid values:</para>
                                        /// <list type="bullet">
                                        /// <item><description>0: ready</description></item>
                                        /// <item><description>1: in progress</description></item>
                                        /// <item><description>2: successful</description></item>
                                        /// <item><description>3: failed</description></item>
                                        /// <item><description>6: terminated</description></item>
                                        /// <item><description>8: wait for manual confirmation to trigger the next batch during a manual phased release</description></item>
                                        /// <item><description>9: wait to trigger the next batch during an automatic phased release</description></item>
                                        /// <item><description>10: failed due to a system exception</description></item>
                                        /// </list>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>2</para>
                                        /// </summary>
                                        [NameInMap("Status")]
                                        [Validation(Required=false)]
                                        public int? Status { get; set; }

                                    }

                                }

                                /// <summary>
                                /// <para>The results of tasks executed in each service-oriented stage.</para>
                                /// </summary>
                                [NameInMap("ServiceStage")]
                                [Validation(Required=false)]
                                public GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOServiceStage ServiceStage { get; set; }
                                public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOServiceStage : TeaModel {
                                    /// <summary>
                                    /// <para>The execution result in the stage.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>Success</para>
                                    /// </summary>
                                    [NameInMap("Message")]
                                    [Validation(Required=false)]
                                    public string Message { get; set; }

                                    /// <summary>
                                    /// <para>The ID of the stage.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>358a143f-09a0-45e0-<b><b>-</b></b>********</para>
                                    /// </summary>
                                    [NameInMap("StageId")]
                                    [Validation(Required=false)]
                                    public string StageId { get; set; }

                                    /// <summary>
                                    /// <para>Phase Name</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>Enable Tengine</para>
                                    /// </summary>
                                    [NameInMap("StageName")]
                                    [Validation(Required=false)]
                                    public string StageName { get; set; }

                                    /// <summary>
                                    /// <para>The running state. Valid values:</para>
                                    /// <list type="bullet">
                                    /// <item><description>0: ready</description></item>
                                    /// <item><description>1: in progress</description></item>
                                    /// <item><description>2: successful</description></item>
                                    /// <item><description>3: failed</description></item>
                                    /// <item><description>6: terminated</description></item>
                                    /// <item><description>8: wait for manual confirmation to trigger the next batch during a manual phased release</description></item>
                                    /// <item><description>9: wait to trigger the next batch during an automatic phased release</description></item>
                                    /// <item><description>10: failed due to a system exception</description></item>
                                    /// </list>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>2</para>
                                    /// </summary>
                                    [NameInMap("Status")]
                                    [Validation(Required=false)]
                                    public int? Status { get; set; }

                                }

                            }

                            /// <summary>
                            /// <para>The state of the stage. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>0: ready</description></item>
                            /// <item><description>1: in progress</description></item>
                            /// <item><description>2: successful</description></item>
                            /// <item><description>3: failed</description></item>
                            /// <item><description>6: terminated</description></item>
                            /// <item><description>8: wait for manual confirmation to trigger the next batch during a manual phased release</description></item>
                            /// <item><description>9: wait to trigger the next batch during an automatic phased release</description></item>
                            /// <item><description>10: failed due to a system exception</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2</para>
                            /// </summary>
                            [NameInMap("Status")]
                            [Validation(Required=false)]
                            public int? Status { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The time when the change task was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1583911702158</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <para>The time when the change task was updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1583911743633</para>
                    /// </summary>
                    [NameInMap("UpdateTime")]
                    [Validation(Required=false)]
                    public string UpdateTime { get; set; }

                }

            }

            /// <summary>
            /// <para>The state of the change process. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: ready</description></item>
            /// <item><description>1: in progress</description></item>
            /// <item><description>2: successful</description></item>
            /// <item><description>3: failed</description></item>
            /// <item><description>6: terminated</description></item>
            /// <item><description>7: partially executed</description></item>
            /// <item><description>8: wait for manual confirmation to trigger the next batch during a manual phased release</description></item>
            /// <item><description>9: wait to trigger the next batch during an automatic phased release</description></item>
            /// <item><description>10: failed due to a system exception</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Indicates whether rollbacks are allowed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Rollbacks are allowed.</description></item>
            /// <item><description>false: Rollbacks are not allowed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
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
            /// <para>The throttling rules.</para>
            /// </summary>
            [NameInMap("TrafficControl")]
            [Validation(Required=false)]
            public GetChangeOrderInfoResponseBodyChangeOrderInfoTrafficControl TrafficControl { get; set; }
            public class GetChangeOrderInfoResponseBodyChangeOrderInfoTrafficControl : TeaModel {
                /// <summary>
                /// <para>The route forwarding policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;app&quot;:&quot;9c8247da-91b6-42bb-8f99-92a0b9c6f****&quot;,&quot;type&quot;:&quot;GROUP&quot;}]</para>
                /// </summary>
                [NameInMap("Routes")]
                [Validation(Required=false)]
                public string Routes { get; set; }

                /// <summary>
                /// <para>The traffic routing rules.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;conditionType&quot;:&quot;content&quot;,&quot;conditions&quot;:[{&quot;key&quot;:&quot;name&quot;,&quot;operator&quot;:&quot;EQ&quot;,&quot;strategy&quot;:&quot;PARAM&quot;,&quot;values&quot;:[&quot;jim&quot;]},{&quot;key&quot;:&quot;name&quot;,&quot;operator&quot;:&quot;EQ&quot;,&quot;strategy&quot;:&quot;COOKIE&quot;,&quot;values&quot;:[&quot;jim&quot;]}],&quot;percent&quot;:100,&quot;protocol&quot;:&quot;SPRINGCLOUD&quot;,&quot;triggerPolicy&quot;:&quot;AND&quot;}]</para>
                /// </summary>
                [NameInMap("Rules")]
                [Validation(Required=false)]
                public string Rules { get; set; }

                /// <summary>
                /// <para>The description of throttling rules.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This canary release batch is complete, and the user has confirmed to proceed to the next batch.</para>
                /// </summary>
                [NameInMap("Tips")]
                [Validation(Required=false)]
                public string Tips { get; set; }

            }

        }

    }

}
