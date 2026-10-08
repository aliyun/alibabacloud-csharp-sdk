// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetChangeOrderInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of the API call or a POP error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Additional information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4JFR-FV9F***************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the change process.</para>
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
            /// <para>The execution mode for the next batch in a phased release.</para>
            /// <list type="bullet">
            /// <item><description><para>Automatic: The next batch is automatically executed.</para>
            /// </description></item>
            /// <item><description><para>Manual: The next batch is manually executed.</para>
            /// </description></item>
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
            /// <para>Application scale-up</para>
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
            /// <para>The classification of the change process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Application Scale Out</para>
            /// </summary>
            [NameInMap("CoType")]
            [Validation(Required=false)]
            public string CoType { get; set; }

            /// <summary>
            /// <para>The time when the change process was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-11-13 14:23:46</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The owner of the change process.</para>
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

            [NameInMap("PipelineInfoList")]
            [Validation(Required=false)]
            public GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoList PipelineInfoList { get; set; }
            public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoList : TeaModel {
                [NameInMap("PipelineInfo")]
                [Validation(Required=false)]
                public List<GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfo> PipelineInfo { get; set; }
                public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfo : TeaModel {
                    [NameInMap("PipelineId")]
                    [Validation(Required=false)]
                    public string PipelineId { get; set; }

                    [NameInMap("PipelineName")]
                    [Validation(Required=false)]
                    public string PipelineName { get; set; }

                    [NameInMap("PipelineStatus")]
                    [Validation(Required=false)]
                    public int? PipelineStatus { get; set; }

                    [NameInMap("StageDetailList")]
                    [Validation(Required=false)]
                    public GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageDetailList StageDetailList { get; set; }
                    public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageDetailList : TeaModel {
                        [NameInMap("StageDetailDTO")]
                        [Validation(Required=false)]
                        public List<GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageDetailListStageDetailDTO> StageDetailDTO { get; set; }
                        public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageDetailListStageDetailDTO : TeaModel {
                            [NameInMap("StageId")]
                            [Validation(Required=false)]
                            public string StageId { get; set; }

                            [NameInMap("StageName")]
                            [Validation(Required=false)]
                            public string StageName { get; set; }

                            [NameInMap("StageStatus")]
                            [Validation(Required=false)]
                            public int? StageStatus { get; set; }

                            [NameInMap("TaskList")]
                            [Validation(Required=false)]
                            public GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageDetailListStageDetailDTOTaskList TaskList { get; set; }
                            public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageDetailListStageDetailDTOTaskList : TeaModel {
                                [NameInMap("TaskInfoDTO")]
                                [Validation(Required=false)]
                                public List<GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageDetailListStageDetailDTOTaskListTaskInfoDTO> TaskInfoDTO { get; set; }
                                public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageDetailListStageDetailDTOTaskListTaskInfoDTO : TeaModel {
                                    [NameInMap("RetryType")]
                                    [Validation(Required=false)]
                                    public int? RetryType { get; set; }

                                    [NameInMap("ShowManualIgnorance")]
                                    [Validation(Required=false)]
                                    public bool? ShowManualIgnorance { get; set; }

                                    [NameInMap("TaskErrorCode")]
                                    [Validation(Required=false)]
                                    public string TaskErrorCode { get; set; }

                                    [NameInMap("TaskErrorIgnorance")]
                                    [Validation(Required=false)]
                                    public int? TaskErrorIgnorance { get; set; }

                                    [NameInMap("TaskErrorMessage")]
                                    [Validation(Required=false)]
                                    public string TaskErrorMessage { get; set; }

                                    [NameInMap("TaskId")]
                                    [Validation(Required=false)]
                                    public string TaskId { get; set; }

                                    [NameInMap("TaskMessage")]
                                    [Validation(Required=false)]
                                    public string TaskMessage { get; set; }

                                    [NameInMap("TaskName")]
                                    [Validation(Required=false)]
                                    public string TaskName { get; set; }

                                    [NameInMap("TaskStatus")]
                                    [Validation(Required=false)]
                                    public string TaskStatus { get; set; }

                                }

                            }

                        }

                    }

                    [NameInMap("StageList")]
                    [Validation(Required=false)]
                    public GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageList StageList { get; set; }
                    public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageList : TeaModel {
                        [NameInMap("StageInfoDTO")]
                        [Validation(Required=false)]
                        public List<GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTO> StageInfoDTO { get; set; }
                        public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTO : TeaModel {
                            [NameInMap("StageId")]
                            [Validation(Required=false)]
                            public string StageId { get; set; }

                            [NameInMap("StageName")]
                            [Validation(Required=false)]
                            public string StageName { get; set; }

                            [NameInMap("StageResultDTO")]
                            [Validation(Required=false)]
                            public GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTO StageResultDTO { get; set; }
                            public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTO : TeaModel {
                                [NameInMap("InstanceDTOList")]
                                [Validation(Required=false)]
                                public GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOInstanceDTOList InstanceDTOList { get; set; }
                                public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOInstanceDTOList : TeaModel {
                                    [NameInMap("InstanceDTO")]
                                    [Validation(Required=false)]
                                    public List<GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOInstanceDTOListInstanceDTO> InstanceDTO { get; set; }
                                    public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOInstanceDTOListInstanceDTO : TeaModel {
                                        [NameInMap("InstanceIp")]
                                        [Validation(Required=false)]
                                        public string InstanceIp { get; set; }

                                        [NameInMap("InstanceName")]
                                        [Validation(Required=false)]
                                        public string InstanceName { get; set; }

                                        [NameInMap("InstanceStageDTOList")]
                                        [Validation(Required=false)]
                                        public GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOInstanceDTOListInstanceDTOInstanceStageDTOList InstanceStageDTOList { get; set; }
                                        public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOInstanceDTOListInstanceDTOInstanceStageDTOList : TeaModel {
                                            [NameInMap("InstanceStageDTO")]
                                            [Validation(Required=false)]
                                            public List<GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOInstanceDTOListInstanceDTOInstanceStageDTOListInstanceStageDTO> InstanceStageDTO { get; set; }
                                            public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOInstanceDTOListInstanceDTOInstanceStageDTOListInstanceStageDTO : TeaModel {
                                                [NameInMap("FinishTime")]
                                                [Validation(Required=false)]
                                                public string FinishTime { get; set; }

                                                [NameInMap("StageId")]
                                                [Validation(Required=false)]
                                                public string StageId { get; set; }

                                                [NameInMap("StageMessage")]
                                                [Validation(Required=false)]
                                                public string StageMessage { get; set; }

                                                [NameInMap("StageName")]
                                                [Validation(Required=false)]
                                                public string StageName { get; set; }

                                                [NameInMap("StartTime")]
                                                [Validation(Required=false)]
                                                public string StartTime { get; set; }

                                                [NameInMap("Status")]
                                                [Validation(Required=false)]
                                                public int? Status { get; set; }

                                            }

                                        }

                                        [NameInMap("PodName")]
                                        [Validation(Required=false)]
                                        public string PodName { get; set; }

                                        [NameInMap("PodStatus")]
                                        [Validation(Required=false)]
                                        public string PodStatus { get; set; }

                                        [NameInMap("Status")]
                                        [Validation(Required=false)]
                                        public int? Status { get; set; }

                                    }

                                }

                                [NameInMap("ServiceStage")]
                                [Validation(Required=false)]
                                public GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOServiceStage ServiceStage { get; set; }
                                public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOServiceStage : TeaModel {
                                    [NameInMap("Message")]
                                    [Validation(Required=false)]
                                    public string Message { get; set; }

                                    [NameInMap("StageId")]
                                    [Validation(Required=false)]
                                    public string StageId { get; set; }

                                    [NameInMap("StageName")]
                                    [Validation(Required=false)]
                                    public string StageName { get; set; }

                                    [NameInMap("Status")]
                                    [Validation(Required=false)]
                                    public int? Status { get; set; }

                                }

                            }

                            [NameInMap("Status")]
                            [Validation(Required=false)]
                            public int? Status { get; set; }

                        }

                    }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    [NameInMap("UpdateTime")]
                    [Validation(Required=false)]
                    public string UpdateTime { get; set; }

                }

            }

            /// <summary>
            /// <para>The status of the change.</para>
            /// <list type="bullet">
            /// <item><description><para>0: ready</para>
            /// </description></item>
            /// <item><description><para>1: in progress</para>
            /// </description></item>
            /// <item><description><para>2: successful</para>
            /// </description></item>
            /// <item><description><para>3: failed</para>
            /// </description></item>
            /// <item><description><para>6: stopped</para>
            /// </description></item>
            /// <item><description><para>7: partially successful</para>
            /// </description></item>
            /// <item><description><para>8: waiting for manual confirmation to proceed with the next batch in manual phased release mode</para>
            /// </description></item>
            /// <item><description><para>9: waiting for the next batch to be executed in automatic phased release mode</para>
            /// </description></item>
            /// <item><description><para>10: failed due to a system exception</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Indicates whether rollback is supported.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Rollback is supported.</para>
            /// </description></item>
            /// <item><description><para>false: Rollback is not supported.</para>
            /// </description></item>
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
            /// <para>The throttling rule.</para>
            /// </summary>
            [NameInMap("TrafficControl")]
            [Validation(Required=false)]
            public GetChangeOrderInfoResponseBodyChangeOrderInfoTrafficControl TrafficControl { get; set; }
            public class GetChangeOrderInfoResponseBodyChangeOrderInfoTrafficControl : TeaModel {
                /// <summary>
                /// <para>The traffic forwarding rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;app&quot;:&quot;9c8247da-91b6-42bb-8f99-92a0b9c6f****&quot;,&quot;type&quot;:&quot;GROUP&quot;}]</para>
                /// </summary>
                [NameInMap("Routes")]
                [Validation(Required=false)]
                public string Routes { get; set; }

                /// <summary>
                /// <para>The routing rule for traffic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;conditionType&quot;:&quot;content&quot;,&quot;conditions&quot;:[{&quot;key&quot;:&quot;name&quot;,&quot;operator&quot;:&quot;EQ&quot;,&quot;strategy&quot;:&quot;PARAM&quot;,&quot;values&quot;:[&quot;jim&quot;]},{&quot;key&quot;:&quot;name&quot;,&quot;operator&quot;:&quot;EQ&quot;,&quot;strategy&quot;:&quot;COOKIE&quot;,&quot;values&quot;:[&quot;jim&quot;]}],&quot;percent&quot;:100,&quot;protocol&quot;:&quot;SPRINGCLOUD&quot;,&quot;triggerPolicy&quot;:&quot;AND&quot;}]</para>
                /// </summary>
                [NameInMap("Rules")]
                [Validation(Required=false)]
                public string Rules { get; set; }

                /// <summary>
                /// <para>The description of the traffic rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Canary batch release completed. Confirmed to proceed to the next batch.</para>
                /// </summary>
                [NameInMap("Tips")]
                [Validation(Required=false)]
                public string Tips { get; set; }

            }

        }

    }

}
