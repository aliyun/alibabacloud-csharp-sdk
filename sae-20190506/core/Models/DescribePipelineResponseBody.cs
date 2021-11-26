// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribePipelineResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribePipelineResponseBodyData Data { get; set; }
        public class DescribePipelineResponseBodyData : TeaModel {
            [NameInMap("CoStatus")]
            [Validation(Required=false)]
            public string CoStatus { get; set; }
            [NameInMap("CurrentStageId")]
            [Validation(Required=false)]
            public string CurrentStageId { get; set; }
            [NameInMap("NextPipelineId")]
            [Validation(Required=false)]
            public string NextPipelineId { get; set; }
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }
            [NameInMap("PipelineName")]
            [Validation(Required=false)]
            public string PipelineName { get; set; }
            [NameInMap("PipelineStatus")]
            [Validation(Required=false)]
            public int? PipelineStatus { get; set; }
            [NameInMap("ShowBatch")]
            [Validation(Required=false)]
            public bool? ShowBatch { get; set; }
            [NameInMap("StageList")]
            [Validation(Required=false)]
            public List<DescribePipelineResponseBodyDataStageList> StageList { get; set; }
            public class DescribePipelineResponseBodyDataStageList : TeaModel {
                public int? ExecutorType { get; set; }
                public string StageId { get; set; }
                public string StageName { get; set; }
                public int? Status { get; set; }
                public List<DescribePipelineResponseBodyDataStageListTaskList> TaskList { get; set; }
                public class DescribePipelineResponseBodyDataStageListTaskList : TeaModel {
                    public string ErrorCode { get; set; }
                    public int? ErrorIgnore { get; set; }
                    public string ErrorMessage { get; set; }
                    public string Message { get; set; }
                    public bool? ShowManualIgnore { get; set; }
                    public string StageId { get; set; }
                    public int? Status { get; set; }
                    public string TaskId { get; set; }
                    public string TaskName { get; set; }
                }
            }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
