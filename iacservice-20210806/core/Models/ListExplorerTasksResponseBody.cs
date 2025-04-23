// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListExplorerTasksResponseBody : TeaModel {
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("tasks")]
        [Validation(Required=false)]
        public List<ListExplorerTasksResponseBodyTasks> Tasks { get; set; }
        public class ListExplorerTasksResponseBodyTasks : TeaModel {
            [NameInMap("autoApply")]
            [Validation(Required=false)]
            public bool? AutoApply { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("currentJobId")]
            [Validation(Required=false)]
            public string CurrentJobId { get; set; }

            [NameInMap("currentJobStatus")]
            [Validation(Required=false)]
            public string CurrentJobStatus { get; set; }

            [NameInMap("deletionProtection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

            [NameInMap("moduleId")]
            [Validation(Required=false)]
            public string ModuleId { get; set; }

            [NameInMap("moduleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

            [NameInMap("moduleVersion")]
            [Validation(Required=false)]
            public string ModuleVersion { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
