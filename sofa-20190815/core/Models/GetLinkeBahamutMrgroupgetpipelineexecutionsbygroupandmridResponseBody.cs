// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutMrgroupgetpipelineexecutionsbygroupandmridResponseBody : TeaModel {
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
        public GetLinkeBahamutMrgroupgetpipelineexecutionsbygroupandmridResponseBodyResult Result { get; set; }
        public class GetLinkeBahamutMrgroupgetpipelineexecutionsbygroupandmridResponseBodyResult : TeaModel {
            [NameInMap("Assignee")]
            [Validation(Required=false)]
            public string Assignee { get; set; }
            [NameInMap("Author")]
            [Validation(Required=false)]
            public string Author { get; set; }
            [NameInMap("Created")]
            [Validation(Required=false)]
            public long? Created { get; set; }
            [NameInMap("ExtraDiv")]
            [Validation(Required=false)]
            public string ExtraDiv { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("IterationName")]
            [Validation(Required=false)]
            public string IterationName { get; set; }
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public long? LastModified { get; set; }
            [NameInMap("MergeRequestId")]
            [Validation(Required=false)]
            public long? MergeRequestId { get; set; }
            [NameInMap("MergeRequestIid")]
            [Validation(Required=false)]
            public long? MergeRequestIid { get; set; }
            [NameInMap("MrState")]
            [Validation(Required=false)]
            public string MrState { get; set; }
            [NameInMap("MrType")]
            [Validation(Required=false)]
            public string MrType { get; set; }
            [NameInMap("MrWebUrl")]
            [Validation(Required=false)]
            public string MrWebUrl { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("PipelineExecutionStatus")]
            [Validation(Required=false)]
            public string PipelineExecutionStatus { get; set; }
            [NameInMap("PipelineTag")]
            [Validation(Required=false)]
            public string PipelineTag { get; set; }
            [NameInMap("Reviewed")]
            [Validation(Required=false)]
            public bool? Reviewed { get; set; }
            [NameInMap("ShowState")]
            [Validation(Required=false)]
            public bool? ShowState { get; set; }
            [NameInMap("SourceBranch")]
            [Validation(Required=false)]
            public string SourceBranch { get; set; }
            [NameInMap("TimelimeComparingTime")]
            [Validation(Required=false)]
            public long? TimelimeComparingTime { get; set; }
            [NameInMap("TriggerByAdmin")]
            [Validation(Required=false)]
            public bool? TriggerByAdmin { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("PipelineExecutionVOS")]
            [Validation(Required=false)]
            public List<string> PipelineExecutionVOS { get; set; }
            [NameInMap("Stages")]
            [Validation(Required=false)]
            public List<string> Stages { get; set; }
        };

    }

}
