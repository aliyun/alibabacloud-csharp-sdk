// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class StartExecutionResponseBody : TeaModel {
        [NameInMap("Execution")]
        [Validation(Required=false)]
        public StartExecutionResponseBodyExecution Execution { get; set; }
        public class StartExecutionResponseBodyExecution : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public string Outputs { get; set; }
            [NameInMap("ExecutedBy")]
            [Validation(Required=false)]
            public string ExecutedBy { get; set; }
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }
            [NameInMap("IsParent")]
            [Validation(Required=false)]
            public bool? IsParent { get; set; }
            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, string> Tags { get; set; }
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }
            [NameInMap("SafetyCheck")]
            [Validation(Required=false)]
            public string SafetyCheck { get; set; }
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }
            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }
            [NameInMap("ExecutionId")]
            [Validation(Required=false)]
            public string ExecutionId { get; set; }
            [NameInMap("CurrentTasks")]
            [Validation(Required=false)]
            public List<StartExecutionResponseBodyExecutionCurrentTasks> CurrentTasks { get; set; }
            public class StartExecutionResponseBodyExecutionCurrentTasks : TeaModel {
                public string TaskExecutionId { get; set; }
                public string TaskName { get; set; }
                public string TaskAction { get; set; }
            }
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public string Parameters { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("Counters")]
            [Validation(Required=false)]
            public Dictionary<string, string> Counters { get; set; }
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }
            [NameInMap("ParentExecutionId")]
            [Validation(Required=false)]
            public string ParentExecutionId { get; set; }
            [NameInMap("RamRole")]
            [Validation(Required=false)]
            public string RamRole { get; set; }
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }
            [NameInMap("LoopMode")]
            [Validation(Required=false)]
            public string LoopMode { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
