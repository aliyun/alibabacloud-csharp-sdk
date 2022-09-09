// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListTasksResponseBody : TeaModel {
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("tasks")]
        [Validation(Required=false)]
        public List<ListTasksResponseBodyTasks> Tasks { get; set; }
        public class ListTasksResponseBodyTasks : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("currentJobId")]
            [Validation(Required=false)]
            public string CurrentJobId { get; set; }

            [NameInMap("currentJobStatus")]
            [Validation(Required=false)]
            public string CurrentJobStatus { get; set; }

            [NameInMap("groupInfo")]
            [Validation(Required=false)]
            public ListTasksResponseBodyTasksGroupInfo GroupInfo { get; set; }
            public class ListTasksResponseBodyTasksGroupInfo : TeaModel {
                [NameInMap("groupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("projectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                [NameInMap("projectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

            }

            [NameInMap("hasDestroy")]
            [Validation(Required=false)]
            public bool? HasDestroy { get; set; }

            [NameInMap("moduleId")]
            [Validation(Required=false)]
            public string ModuleId { get; set; }

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
