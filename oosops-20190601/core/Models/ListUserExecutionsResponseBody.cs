// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oosops20190601.Models
{
    public class ListUserExecutionsResponseBody : TeaModel {
        [NameInMap("Executions")]
        [Validation(Required=false)]
        public List<ListUserExecutionsResponseBodyExecutions> Executions { get; set; }
        public class ListUserExecutionsResponseBodyExecutions : TeaModel {
            [NameInMap("Counters")]
            [Validation(Required=false)]
            public string Counters { get; set; }

            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            [NameInMap("CurrentTasks")]
            [Validation(Required=false)]
            public List<ListUserExecutionsResponseBodyExecutionsCurrentTasks> CurrentTasks { get; set; }
            public class ListUserExecutionsResponseBodyExecutionsCurrentTasks : TeaModel {
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

            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public string Outputs { get; set; }

            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public string Parameters { get; set; }

            [NameInMap("ParentExecutionId")]
            [Validation(Required=false)]
            public string ParentExecutionId { get; set; }

            [NameInMap("RamRole")]
            [Validation(Required=false)]
            public string RamRole { get; set; }

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
