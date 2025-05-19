// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20180308.Models
{
    public class TaskConfigListResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageTotal")]
        [Validation(Required=false)]
        public int? PageTotal { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public TaskConfigListResponseBodyTaskList TaskList { get; set; }
        public class TaskConfigListResponseBodyTaskList : TeaModel {
            [NameInMap("NodeTaskConfig")]
            [Validation(Required=false)]
            public List<TaskConfigListResponseBodyTaskListNodeTaskConfig> NodeTaskConfig { get; set; }
            public class TaskConfigListResponseBodyTaskListNodeTaskConfig : TeaModel {
                [NameInMap("AlertConfig")]
                [Validation(Required=false)]
                public string AlertConfig { get; set; }

                [NameInMap("Disabled")]
                [Validation(Required=false)]
                public bool? Disabled { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("InstanceList")]
                [Validation(Required=false)]
                public TaskConfigListResponseBodyTaskListNodeTaskConfigInstanceList InstanceList { get; set; }
                public class TaskConfigListResponseBodyTaskListNodeTaskConfigInstanceList : TeaModel {
                    [NameInMap("String")]
                    [Validation(Required=false)]
                    public List<string> String { get; set; }

                }

                [NameInMap("JsonData")]
                [Validation(Required=false)]
                public string JsonData { get; set; }

                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                [NameInMap("TaskScope")]
                [Validation(Required=false)]
                public string TaskScope { get; set; }

                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

            }

        }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
