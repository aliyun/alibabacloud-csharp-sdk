// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops_rdc20200303.Models
{
    public class GetPipelineInstHistoryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPipelineInstHistoryResponseBodyData Data { get; set; }
        public class GetPipelineInstHistoryResponseBodyData : TeaModel {
            [NameInMap("DataList")]
            [Validation(Required=false)]
            public List<GetPipelineInstHistoryResponseBodyDataDataList> DataList { get; set; }
            public class GetPipelineInstHistoryResponseBodyDataDataList : TeaModel {
                public string Status { get; set; }
                public long? CreateTime { get; set; }
                public string StatusName { get; set; }
                public string Deletion { get; set; }
                public int? PipelineConfigId { get; set; }
                public int? TriggerMode { get; set; }
                public string Creator { get; set; }
                public int? InstNumber { get; set; }
                public string Modifier { get; set; }
                public GetPipelineInstHistoryResponseBodyDataDataListFlowInstance FlowInstance { get; set; }
                public class GetPipelineInstHistoryResponseBodyDataDataListFlowInstance : TeaModel {
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("Stages")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Stages { get; set; }

                    [NameInMap("Result")]
                    [Validation(Required=false)]
                    public GetPipelineInstHistoryResponseBodyDataDataListFlowInstanceResult Result { get; set; }
                    public class GetPipelineInstHistoryResponseBodyDataDataListFlowInstanceResult : TeaModel {
                        [NameInMap("EnginePipelineNumber")]
                        [Validation(Required=false)]
                        public int? EnginePipelineNumber { get; set; }
                        [NameInMap("MixFlowInstId")]
                        [Validation(Required=false)]
                        public string MixFlowInstId { get; set; }
                        [NameInMap("EnginePipelineName")]
                        [Validation(Required=false)]
                        public string EnginePipelineName { get; set; }
                        [NameInMap("EnginePipelineId")]
                        [Validation(Required=false)]
                        public int? EnginePipelineId { get; set; }
                        [NameInMap("EnginePipelineInstId")]
                        [Validation(Required=false)]
                        public int? EnginePipelineInstId { get; set; }
                        [NameInMap("TimeStamp")]
                        [Validation(Required=false)]
                        public string TimeStamp { get; set; }
                        [NameInMap("TriggerMode")]
                        [Validation(Required=false)]
                        public string TriggerMode { get; set; }
                        [NameInMap("Sources")]
                        [Validation(Required=false)]
                        public string Sources { get; set; }
                        [NameInMap("Caches")]
                        [Validation(Required=false)]
                        public string Caches { get; set; }
                        [NameInMap("DateTime")]
                        [Validation(Required=false)]
                        public string DateTime { get; set; }
                    };

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    [NameInMap("StatusName")]
                    [Validation(Required=false)]
                    public string StatusName { get; set; }

                    [NameInMap("RunningStatus")]
                    [Validation(Required=false)]
                    public string RunningStatus { get; set; }

                    [NameInMap("StageTopo")]
                    [Validation(Required=false)]
                    public string StageTopo { get; set; }

                    [NameInMap("Creator")]
                    [Validation(Required=false)]
                    public string Creator { get; set; }

                    [NameInMap("Modifier")]
                    [Validation(Required=false)]
                    public string Modifier { get; set; }

                    [NameInMap("Groups")]
                    [Validation(Required=false)]
                    public List<GetPipelineInstHistoryResponseBodyDataDataListFlowInstanceGroups> Groups { get; set; }
                    public class GetPipelineInstHistoryResponseBodyDataDataListFlowInstanceGroups : TeaModel {
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public long? CreateTime { get; set; }

                        [NameInMap("DeleteStatus")]
                        [Validation(Required=false)]
                        public string DeleteStatus { get; set; }

                        [NameInMap("IdExtent")]
                        [Validation(Required=false)]
                        public int? IdExtent { get; set; }

                        [NameInMap("Creator")]
                        [Validation(Required=false)]
                        public string Creator { get; set; }

                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public long? EndTime { get; set; }

                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public long? StartTime { get; set; }

                        [NameInMap("Modifier")]
                        [Validation(Required=false)]
                        public string Modifier { get; set; }

                        [NameInMap("ResultStatus")]
                        [Validation(Required=false)]
                        public string ResultStatus { get; set; }

                        [NameInMap("FlowInstId")]
                        [Validation(Required=false)]
                        public int? FlowInstId { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public int? Id { get; set; }

                        [NameInMap("ModifyTime")]
                        [Validation(Required=false)]
                        public long? ModifyTime { get; set; }

                    }

                    [NameInMap("AutoDrivenStatus")]
                    [Validation(Required=false)]
                    public bool? AutoDrivenStatus { get; set; }

                    [NameInMap("ResultStatus")]
                    [Validation(Required=false)]
                    public string ResultStatus { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public int? Id { get; set; }

                    [NameInMap("SystemCode")]
                    [Validation(Required=false)]
                    public string SystemCode { get; set; }

                    [NameInMap("ModifyTime")]
                    [Validation(Required=false)]
                    public long? ModifyTime { get; set; }

                    [NameInMap("SystemId")]
                    [Validation(Required=false)]
                    public string SystemId { get; set; }

                }
                public string Packages { get; set; }
                public int? FlowInstId { get; set; }
                public int? PipelineId { get; set; }
                public int? Id { get; set; }
                public long? ModifyTime { get; set; }
            }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
