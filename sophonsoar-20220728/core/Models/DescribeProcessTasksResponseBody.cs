// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeProcessTasksResponseBody : TeaModel {
        [NameInMap("Page")]
        [Validation(Required=false)]
        public DescribeProcessTasksResponseBodyPage Page { get; set; }
        public class DescribeProcessTasksResponseBodyPage : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("ProcessTasks")]
        [Validation(Required=false)]
        public List<DescribeProcessTasksResponseBodyProcessTasks> ProcessTasks { get; set; }
        public class DescribeProcessTasksResponseBodyProcessTasks : TeaModel {
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("EntityName")]
            [Validation(Required=false)]
            public string EntityName { get; set; }

            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            [NameInMap("GmtCreateMillis")]
            [Validation(Required=false)]
            public long? GmtCreateMillis { get; set; }

            [NameInMap("GmtModifiedMillis")]
            [Validation(Required=false)]
            public long? GmtModifiedMillis { get; set; }

            [NameInMap("InputParams")]
            [Validation(Required=false)]
            public string InputParams { get; set; }

            [NameInMap("ProcessStrategyUuid")]
            [Validation(Required=false)]
            public string ProcessStrategyUuid { get; set; }

            [NameInMap("ProcessTime")]
            [Validation(Required=false)]
            public long? ProcessTime { get; set; }

            [NameInMap("RemoveTime")]
            [Validation(Required=false)]
            public long? RemoveTime { get; set; }

            [NameInMap("SceneCode")]
            [Validation(Required=false)]
            public string SceneCode { get; set; }

            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public int? TaskStatus { get; set; }

            [NameInMap("YunCode")]
            [Validation(Required=false)]
            public string YunCode { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
