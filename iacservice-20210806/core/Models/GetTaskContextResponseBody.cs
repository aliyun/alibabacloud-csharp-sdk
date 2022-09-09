// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetTaskContextResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("task")]
        [Validation(Required=false)]
        public GetTaskContextResponseBodyTask Task { get; set; }
        public class GetTaskContextResponseBodyTask : TeaModel {
            [NameInMap("autoApply")]
            [Validation(Required=false)]
            public bool? AutoApply { get; set; }

            [NameInMap("jobConfig")]
            [Validation(Required=false)]
            public GetTaskContextResponseBodyTaskJobConfig JobConfig { get; set; }
            public class GetTaskContextResponseBodyTaskJobConfig : TeaModel {
                [NameInMap("isDestroy")]
                [Validation(Required=false)]
                public bool? IsDestroy { get; set; }

                [NameInMap("jobModuleVersion")]
                [Validation(Required=false)]
                public string JobModuleVersion { get; set; }

                [NameInMap("resourcesChanged")]
                [Validation(Required=false)]
                public string ResourcesChanged { get; set; }

            }

            [NameInMap("jobDescription")]
            [Validation(Required=false)]
            public string JobDescription { get; set; }

            [NameInMap("jobGmtCreate")]
            [Validation(Required=false)]
            public string JobGmtCreate { get; set; }

            [NameInMap("jobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("jobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }

            [NameInMap("moduleId")]
            [Validation(Required=false)]
            public string ModuleId { get; set; }

            [NameInMap("modulePath")]
            [Validation(Required=false)]
            public string ModulePath { get; set; }

            [NameInMap("moduleVersion")]
            [Validation(Required=false)]
            public string ModuleVersion { get; set; }

            [NameInMap("parameters")]
            [Validation(Required=false)]
            public Dictionary<string, string> Parameters { get; set; }

            [NameInMap("ramRole")]
            [Validation(Required=false)]
            public string RamRole { get; set; }

            [NameInMap("resourceCount")]
            [Validation(Required=false)]
            public int? ResourceCount { get; set; }

            [NameInMap("taskGmtCreate")]
            [Validation(Required=false)]
            public string TaskGmtCreate { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("taskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("taskOutputPath")]
            [Validation(Required=false)]
            public string TaskOutputPath { get; set; }

            [NameInMap("taskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            [NameInMap("terraformVersion")]
            [Validation(Required=false)]
            public string TerraformVersion { get; set; }

            [NameInMap("triggerStrategy")]
            [Validation(Required=false)]
            public string TriggerStrategy { get; set; }

        }

    }

}
