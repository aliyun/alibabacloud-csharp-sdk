// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListExecutionsResponseBody : TeaModel {
        [NameInMap("Executions")]
        [Validation(Required=false)]
        public List<ListExecutionsResponseBodyExecutions> Executions { get; set; }
        public class ListExecutionsResponseBodyExecutions : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("Counters")]
            [Validation(Required=false)]
            public Dictionary<string, object> Counters { get; set; }

            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            [NameInMap("CurrentTasks")]
            [Validation(Required=false)]
            public List<ListExecutionsResponseBodyExecutionsCurrentTasks> CurrentTasks { get; set; }
            public class ListExecutionsResponseBodyExecutionsCurrentTasks : TeaModel {
                [NameInMap("TaskAction")]
                [Validation(Required=false)]
                public string TaskAction { get; set; }

                [NameInMap("TaskExecutionId")]
                [Validation(Required=false)]
                public string TaskExecutionId { get; set; }

                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

            }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            [NameInMap("ExecutedBy")]
            [Validation(Required=false)]
            public string ExecutedBy { get; set; }

            [NameInMap("ExecutionId")]
            [Validation(Required=false)]
            public string ExecutionId { get; set; }

            [NameInMap("IsParent")]
            [Validation(Required=false)]
            public bool? IsParent { get; set; }

            [NameInMap("LastSuccessfulTriggerTime")]
            [Validation(Required=false)]
            public string LastSuccessfulTriggerTime { get; set; }

            [NameInMap("LastTriggerStatus")]
            [Validation(Required=false)]
            public string LastTriggerStatus { get; set; }

            [NameInMap("LastTriggerTime")]
            [Validation(Required=false)]
            public string LastTriggerTime { get; set; }

            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public string Outputs { get; set; }

            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public Dictionary<string, object> Parameters { get; set; }

            [NameInMap("ParentExecutionId")]
            [Validation(Required=false)]
            public string ParentExecutionId { get; set; }

            [NameInMap("RamRole")]
            [Validation(Required=false)]
            public string RamRole { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("ResourceStatus")]
            [Validation(Required=false)]
            public string ResourceStatus { get; set; }

            [NameInMap("SafetyCheck")]
            [Validation(Required=false)]
            public string SafetyCheck { get; set; }

            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

            [NameInMap("Targets")]
            [Validation(Required=false)]
            public string Targets { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }

            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

            [NameInMap("WaitingStatus")]
            [Validation(Required=false)]
            public string WaitingStatus { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
