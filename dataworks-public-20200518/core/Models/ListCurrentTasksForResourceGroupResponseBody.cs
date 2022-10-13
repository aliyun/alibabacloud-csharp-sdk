// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListCurrentTasksForResourceGroupResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCurrentTasksForResourceGroupResponseBodyData Data { get; set; }
        public class ListCurrentTasksForResourceGroupResponseBodyData : TeaModel {
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Tasks")]
            [Validation(Required=false)]
            public List<ListCurrentTasksForResourceGroupResponseBodyDataTasks> Tasks { get; set; }
            public class ListCurrentTasksForResourceGroupResponseBodyDataTasks : TeaModel {
                [NameInMap("Concurrency")]
                [Validation(Required=false)]
                public string Concurrency { get; set; }

                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                [NameInMap("TaskSource")]
                [Validation(Required=false)]
                public string TaskSource { get; set; }

                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public int? TaskType { get; set; }

            }

            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
