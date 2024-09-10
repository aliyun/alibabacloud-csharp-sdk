// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSoarStrategyTasksResponseBody : TeaModel {
        /// <summary>
        /// The page number. Pages start from page 1.
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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The policy tasks.
        /// </summary>
        [NameInMap("SoarStrategyTasks")]
        [Validation(Required=false)]
        public List<DescribeSoarStrategyTasksResponseBodySoarStrategyTasks> SoarStrategyTasks { get; set; }
        public class DescribeSoarStrategyTasksResponseBodySoarStrategyTasks : TeaModel {
            /// <summary>
            /// The number of execution failures.
            /// </summary>
            [NameInMap("FailedNum")]
            [Validation(Required=false)]
            public int? FailedNum { get; set; }

            /// <summary>
            /// The timestamp when the policy task was created. Unit: milliseconds.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// The timestamp when the policy task was complete. Unit: milliseconds.
            /// </summary>
            [NameInMap("GmtFinish")]
            [Validation(Required=false)]
            public long? GmtFinish { get; set; }

            /// <summary>
            /// The timestamp when the policy task was modified. Unit: milliseconds.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// The ID of the policy task.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The name of the policy task.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The execution mode. Valid values:
            /// 
            /// *   runmode_TRIGGER_BY_USER: manually executed
            /// </summary>
            [NameInMap("RunMode")]
            [Validation(Required=false)]
            public string RunMode { get; set; }

            /// <summary>
            /// The status of the policy task. Valid values:
            /// 
            /// *   \\-1: waiting
            /// *   0: starting
            /// *   1: running
            /// *   2: finished
            /// *   3: schedule
            /// *   4: pause
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the policy.
            /// </summary>
            [NameInMap("StrategyId")]
            [Validation(Required=false)]
            public long? StrategyId { get; set; }

            /// <summary>
            /// The number of successful executions.
            /// </summary>
            [NameInMap("SuccessNum")]
            [Validation(Required=false)]
            public int? SuccessNum { get; set; }

            /// <summary>
            /// The total number of executions.
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
