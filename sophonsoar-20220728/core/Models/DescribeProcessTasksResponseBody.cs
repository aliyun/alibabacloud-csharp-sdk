// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeProcessTasksResponseBody : TeaModel {
        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public DescribeProcessTasksResponseBodyPage Page { get; set; }
        public class DescribeProcessTasksResponseBodyPage : TeaModel {
            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The handling tasks.
        /// </summary>
        [NameInMap("ProcessTasks")]
        [Validation(Required=false)]
        public List<DescribeProcessTasksResponseBodyProcessTasks> ProcessTasks { get; set; }
        public class DescribeProcessTasksResponseBodyProcessTasks : TeaModel {
            /// <summary>
            /// The ID of the Alibaba Cloud account that is used to submit the handling task.
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// The name of the handling entity.
            /// </summary>
            [NameInMap("EntityName")]
            [Validation(Required=false)]
            public string EntityName { get; set; }

            /// <summary>
            /// The type of the handling entity.
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            /// <summary>
            /// The creation time of the handling task. The value is a 13-digit timestamp.
            /// </summary>
            [NameInMap("GmtCreateMillis")]
            [Validation(Required=false)]
            public long? GmtCreateMillis { get; set; }

            /// <summary>
            /// The modification time of the handling task. The value is a 13-digit timestamp.
            /// </summary>
            [NameInMap("GmtModifiedMillis")]
            [Validation(Required=false)]
            public long? GmtModifiedMillis { get; set; }

            /// <summary>
            /// The input parameter of the handling task.
            /// </summary>
            [NameInMap("InputParams")]
            [Validation(Required=false)]
            public string InputParams { get; set; }

            /// <summary>
            /// The ID of the associated policy.
            /// </summary>
            [NameInMap("ProcessStrategyUuid")]
            [Validation(Required=false)]
            public string ProcessStrategyUuid { get; set; }

            /// <summary>
            /// The delivery time of the handling task. The value is a 13-digit timestamp.
            /// </summary>
            [NameInMap("ProcessTime")]
            [Validation(Required=false)]
            public long? ProcessTime { get; set; }

            /// <summary>
            /// The unblocking time of the handling task. The value is a 13-digit timestamp.
            /// </summary>
            [NameInMap("RemoveTime")]
            [Validation(Required=false)]
            public long? RemoveTime { get; set; }

            /// <summary>
            /// The scenario code of the handling task.
            /// </summary>
            [NameInMap("SceneCode")]
            [Validation(Required=false)]
            public string SceneCode { get; set; }

            /// <summary>
            /// The scenario name of the handling task.
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account that is specified in the handling task.
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// The submission source of the handling task.
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// The unique identifier of the handling task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// The status of the handling task.
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public int? TaskStatus { get; set; }

            /// <summary>
            /// The code of the cloud service that is associated with the handling task.
            /// </summary>
            [NameInMap("YunCode")]
            [Validation(Required=false)]
            public string YunCode { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
