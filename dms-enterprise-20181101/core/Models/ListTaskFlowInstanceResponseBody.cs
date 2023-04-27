// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTaskFlowInstanceResponseBody : TeaModel {
        /// <summary>
        /// The status of the task flow. Valid values:
        /// 
        /// *   **0**: The task flow is waiting to be scheduled.
        /// *   **1**: The task flow is being executed.
        /// *   **2**: The task flow is paused.
        /// *   **3**: The task flow failed.
        /// *   **4**: The task flow is executed.
        /// *   **5**: The task flow is complete.
        /// </summary>
        [NameInMap("DAGInstanceList")]
        [Validation(Required=false)]
        public ListTaskFlowInstanceResponseBodyDAGInstanceList DAGInstanceList { get; set; }
        public class ListTaskFlowInstanceResponseBodyDAGInstanceList : TeaModel {
            [NameInMap("DAGInstance")]
            [Validation(Required=false)]
            public List<ListTaskFlowInstanceResponseBodyDAGInstanceListDAGInstance> DAGInstance { get; set; }
            public class ListTaskFlowInstanceResponseBodyDAGInstanceListDAGInstance : TeaModel {
                /// <summary>
                /// The information about the execution records returned.
                /// </summary>
                [NameInMap("BusinessTime")]
                [Validation(Required=false)]
                public string BusinessTime { get; set; }

                /// <summary>
                /// The description of the task.
                /// </summary>
                [NameInMap("DagId")]
                [Validation(Required=false)]
                public string DagId { get; set; }

                [NameInMap("DagName")]
                [Validation(Required=false)]
                public string DagName { get; set; }

                [NameInMap("DagVersion")]
                [Validation(Required=false)]
                public string DagVersion { get; set; }

                /// <summary>
                /// The end of the time range to query the execution records of the task flow. Specify the time in the yyyy-MM-DD format.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// Queries the execution records of a task flow.
                /// </summary>
                [NameInMap("HistoryDagId")]
                [Validation(Required=false)]
                public long? HistoryDagId { get; set; }

                /// <summary>
                /// The error message returned if the request fails.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The mode in which the task flow is triggered. Valid values:
                /// 
                /// *   **0**: The task flow is automatically triggered based on periodic scheduling.
                /// *   **1**: The task flow is manually triggered.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("OwnerName")]
                [Validation(Required=false)]
                public string OwnerName { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// The time when the execution of the task flow was complete. The time is displayed in the yyyy-MM-DD HH:mm:ss format.
                /// </summary>
                [NameInMap("TriggerType")]
                [Validation(Required=false)]
                public int? TriggerType { get; set; }

            }

        }

        /// <summary>
        /// The beginning of the time range to query the execution records of the task flow. Specify the time in the yyyy-MM-DD format.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) or [ListUserTenants](~~198074~~) operation to obtain the tenant ID.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The mode in which the task flow is triggered. Valid values:
        /// 
        /// *   **0**: The task flow is automatically triggered based on periodic scheduling.
        /// *   **1**: The task flow is manually triggered.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The name of the task flow.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
