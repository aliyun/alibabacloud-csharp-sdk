// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetChangeOrderInfoResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("changeOrderInfo")]
        [Validation(Required=false)]
        public GetChangeOrderInfoResponseBodyChangeOrderInfo ChangeOrderInfo { get; set; }
        public class GetChangeOrderInfoResponseBodyChangeOrderInfo : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("ChangeOrderDescription")]
            [Validation(Required=false)]
            public string ChangeOrderDescription { get; set; }
            [NameInMap("BatchCount")]
            [Validation(Required=false)]
            public int? BatchCount { get; set; }
            [NameInMap("CreateUserId")]
            [Validation(Required=false)]
            public string CreateUserId { get; set; }
            [NameInMap("SupportRollback")]
            [Validation(Required=false)]
            public bool? SupportRollback { get; set; }
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }
            [NameInMap("ChangeOrderId")]
            [Validation(Required=false)]
            public string ChangeOrderId { get; set; }
            [NameInMap("BatchType")]
            [Validation(Required=false)]
            public string BatchType { get; set; }
            [NameInMap("CoType")]
            [Validation(Required=false)]
            public string CoType { get; set; }
            [NameInMap("TrafficControl")]
            [Validation(Required=false)]
            public GetChangeOrderInfoResponseBodyChangeOrderInfoTrafficControl TrafficControl { get; set; }
            public class GetChangeOrderInfoResponseBodyChangeOrderInfoTrafficControl : TeaModel {
                [NameInMap("Tips")]
                [Validation(Required=false)]
                public string Tips { get; set; }

                [NameInMap("Routes")]
                [Validation(Required=false)]
                public string Routes { get; set; }

                [NameInMap("Rules")]
                [Validation(Required=false)]
                public string Rules { get; set; }

            }
            [NameInMap("PipelineInfoList")]
            [Validation(Required=false)]
            public GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoList PipelineInfoList { get; set; }
            public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoList : TeaModel {
                [NameInMap("PipelineInfo")]
                [Validation(Required=false)]
                public List<GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfo> PipelineInfo { get; set; }
                public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfo : TeaModel {
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    [NameInMap("UpdateTime")]
                    [Validation(Required=false)]
                    public string UpdateTime { get; set; }

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
                            public string StageId { get; set; }
                            public int? StageStatus { get; set; }
                            public GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageDetailListStageDetailDTOTaskList TaskList { get; set; }
                            public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageDetailListStageDetailDTOTaskList : TeaModel {
                                [NameInMap("TaskInfoDTO")]
                                [Validation(Required=false)]
                                public List<GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageDetailListStageDetailDTOTaskListTaskInfoDTO> TaskInfoDTO { get; set; }
                                public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageDetailListStageDetailDTOTaskListTaskInfoDTO : TeaModel {
                                    [NameInMap("TaskErrorIgnorance")]
                                    [Validation(Required=false)]
                                    public int? TaskErrorIgnorance { get; set; }

                                    [NameInMap("ShowManualIgnorance")]
                                    [Validation(Required=false)]
                                    public bool? ShowManualIgnorance { get; set; }

                                    [NameInMap("TaskStatus")]
                                    [Validation(Required=false)]
                                    public string TaskStatus { get; set; }

                                    [NameInMap("TaskName")]
                                    [Validation(Required=false)]
                                    public string TaskName { get; set; }

                                    [NameInMap("TaskMessage")]
                                    [Validation(Required=false)]
                                    public string TaskMessage { get; set; }

                                    [NameInMap("TaskErrorCode")]
                                    [Validation(Required=false)]
                                    public string TaskErrorCode { get; set; }

                                    [NameInMap("TaskId")]
                                    [Validation(Required=false)]
                                    public string TaskId { get; set; }

                                    [NameInMap("TaskErrorMessage")]
                                    [Validation(Required=false)]
                                    public string TaskErrorMessage { get; set; }

                                }

                            }
                            public string StageName { get; set; }
                        }
                    };

                    [NameInMap("PipelineName")]
                    [Validation(Required=false)]
                    public string PipelineName { get; set; }

                    [NameInMap("StageList")]
                    [Validation(Required=false)]
                    public GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageList StageList { get; set; }
                    public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageList : TeaModel {
                        [NameInMap("StageInfoDTO")]
                        [Validation(Required=false)]
                        public List<GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTO> StageInfoDTO { get; set; }
                        public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTO : TeaModel {
                            public string StageId { get; set; }
                            public int? Status { get; set; }
                            public GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTO StageResultDTO { get; set; }
                            public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTO : TeaModel {
                                [NameInMap("ServiceStage")]
                                [Validation(Required=false)]
                                public GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOServiceStage ServiceStage { get; set; }
                                public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOServiceStage : TeaModel {
                                    [NameInMap("StageId")]
                                    [Validation(Required=false)]
                                    public string StageId { get; set; }
                                    [NameInMap("Status")]
                                    [Validation(Required=false)]
                                    public int? Status { get; set; }
                                    [NameInMap("Message")]
                                    [Validation(Required=false)]
                                    public string Message { get; set; }
                                    [NameInMap("StageName")]
                                    [Validation(Required=false)]
                                    public string StageName { get; set; }
                                };

                                [NameInMap("InstanceDTOList")]
                                [Validation(Required=false)]
                                public GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOInstanceDTOList InstanceDTOList { get; set; }
                                public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOInstanceDTOList : TeaModel {
                                    [NameInMap("InstanceDTO")]
                                    [Validation(Required=false)]
                                    public List<GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOInstanceDTOListInstanceDTO> InstanceDTO { get; set; }
                                    public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOInstanceDTOListInstanceDTO : TeaModel {
                                        public int? Status { get; set; }
                                        public string InstanceIp { get; set; }
                                        public string PodName { get; set; }
                                        public GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOInstanceDTOListInstanceDTOInstanceStageDTOList InstanceStageDTOList { get; set; }
                                        public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOInstanceDTOListInstanceDTOInstanceStageDTOList : TeaModel {
                                            [NameInMap("InstanceStageDTO")]
                                            [Validation(Required=false)]
                                            public List<GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOInstanceDTOListInstanceDTOInstanceStageDTOListInstanceStageDTO> InstanceStageDTO { get; set; }
                                            public class GetChangeOrderInfoResponseBodyChangeOrderInfoPipelineInfoListPipelineInfoStageListStageInfoDTOStageResultDTOInstanceDTOListInstanceDTOInstanceStageDTOListInstanceStageDTO : TeaModel {
                                                [NameInMap("StageId")]
                                                [Validation(Required=false)]
                                                public string StageId { get; set; }

                                                [NameInMap("Status")]
                                                [Validation(Required=false)]
                                                public int? Status { get; set; }

                                                [NameInMap("StartTime")]
                                                [Validation(Required=false)]
                                                public string StartTime { get; set; }

                                                [NameInMap("StageMessage")]
                                                [Validation(Required=false)]
                                                public string StageMessage { get; set; }

                                                [NameInMap("FinishTime")]
                                                [Validation(Required=false)]
                                                public string FinishTime { get; set; }

                                                [NameInMap("StageName")]
                                                [Validation(Required=false)]
                                                public string StageName { get; set; }

                                            }

                                        }
                                        public string InstanceName { get; set; }
                                        public string PodStatus { get; set; }
                                    }
                                };

                            }
                            public string StageName { get; set; }
                        }
                    };

                    [NameInMap("PipelineId")]
                    [Validation(Required=false)]
                    public string PipelineId { get; set; }

                }

            }
        };

    }

}
