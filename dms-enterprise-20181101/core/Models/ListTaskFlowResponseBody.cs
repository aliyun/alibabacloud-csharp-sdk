// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTaskFlowResponseBody : TeaModel {
        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The ID of the latest deployment record.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the task flow.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **ListTaskFlow**.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The name of the user who creates the task flow.
        /// </summary>
        [NameInMap("TaskFlowList")]
        [Validation(Required=false)]
        public ListTaskFlowResponseBodyTaskFlowList TaskFlowList { get; set; }
        public class ListTaskFlowResponseBodyTaskFlowList : TeaModel {
            [NameInMap("TaskFlow")]
            [Validation(Required=false)]
            public List<ListTaskFlowResponseBodyTaskFlowListTaskFlow> TaskFlow { get; set; }
            public class ListTaskFlowResponseBodyTaskFlowListTaskFlow : TeaModel {
                /// <summary>
                /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) or [ListUserTenants](~~198074~~) operation to obtain the tenant ID.
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// The ID of the user who creates the task flow.
                /// </summary>
                [NameInMap("CreatorNickName")]
                [Validation(Required=false)]
                public string CreatorNickName { get; set; }

                /// <summary>
                /// The status of the task flow. Valid values:
                /// 
                /// *   **0**: The task flow is invalid.
                /// *   **1**: Scheduling is disabled for the task flow.
                /// *   **2**: The task flow is waiting to be scheduled.
                /// </summary>
                [NameInMap("DagOwnerNickName")]
                [Validation(Required=false)]
                public string DagOwnerNickName { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("DeployId")]
                [Validation(Required=false)]
                public long? DeployId { get; set; }

                /// <summary>
                /// The error message.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("LatestInstanceStatus")]
                [Validation(Required=false)]
                public int? LatestInstanceStatus { get; set; }

                [NameInMap("LatestInstanceTime")]
                [Validation(Required=false)]
                public string LatestInstanceTime { get; set; }

                /// <summary>
                /// The time when the latest execution record was generated.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

    }

}
