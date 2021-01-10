// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutPipelinegetexecutionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ErrorMsgParamsMap")]
        [Validation(Required=false)]
        public string ErrorMsgParamsMap { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetLinkeBahamutPipelinegetexecutionResponseBodyResult Result { get; set; }
        public class GetLinkeBahamutPipelinegetexecutionResponseBodyResult : TeaModel {
            [NameInMap("Context")]
            [Validation(Required=false)]
            public string Context { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }
            [NameInMap("ExecutionId")]
            [Validation(Required=false)]
            public long? ExecutionId { get; set; }
            [NameInMap("ExtraKey")]
            [Validation(Required=false)]
            public string ExtraKey { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public long? PipelineId { get; set; }
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("HistoryOperators")]
            [Validation(Required=false)]
            public List<string> HistoryOperators { get; set; }
            [NameInMap("StageExecutions")]
            [Validation(Required=false)]
            public List<string> StageExecutions { get; set; }
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }
        };

    }

}
