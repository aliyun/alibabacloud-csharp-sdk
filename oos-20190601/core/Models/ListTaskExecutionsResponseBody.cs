// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListTaskExecutionsResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("TaskExecutions")]
        [Validation(Required=false)]
        public List<ListTaskExecutionsResponseBodyTaskExecutions> TaskExecutions { get; set; }
        public class ListTaskExecutionsResponseBodyTaskExecutions : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public string Outputs { get; set; }

            [NameInMap("ChildExecutionId")]
            [Validation(Required=false)]
            public string ChildExecutionId { get; set; }

            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            [NameInMap("ParentTaskExecutionId")]
            [Validation(Required=false)]
            public string ParentTaskExecutionId { get; set; }

            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            [NameInMap("LoopItem")]
            [Validation(Required=false)]
            public string LoopItem { get; set; }

            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            [NameInMap("ExecutionId")]
            [Validation(Required=false)]
            public string ExecutionId { get; set; }

            [NameInMap("TaskAction")]
            [Validation(Required=false)]
            public string TaskAction { get; set; }

            [NameInMap("TaskExecutionId")]
            [Validation(Required=false)]
            public string TaskExecutionId { get; set; }

            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

            [NameInMap("Loop")]
            [Validation(Required=false)]
            public Dictionary<string, object> Loop { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("LoopBatchNumber")]
            [Validation(Required=false)]
            public int? LoopBatchNumber { get; set; }

            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

            [NameInMap("ExtraData")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtraData { get; set; }

            [NameInMap("Properties")]
            [Validation(Required=false)]
            public string Properties { get; set; }

        }

    }

}
