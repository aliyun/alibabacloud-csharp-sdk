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
        /// The error message.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The information about the task flows returned.
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
                /// The ID of the user who creates the task flow.
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// The name of the user who creates the task flow.
                /// </summary>
                [NameInMap("CreatorNickName")]
                [Validation(Required=false)]
                public string CreatorNickName { get; set; }

                /// <summary>
                /// The name of the task flow owner.
                /// </summary>
                [NameInMap("DagOwnerNickName")]
                [Validation(Required=false)]
                public string DagOwnerNickName { get; set; }

                /// <summary>
                /// The ID of the latest deployment record.
                /// </summary>
                [NameInMap("DeployId")]
                [Validation(Required=false)]
                public long? DeployId { get; set; }

                /// <summary>
                /// The ID of the task flow.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The status of the latest execution. Valid values:
                /// 
                /// *   **0**: invalid.
                /// *   **1**: scheduling disabled.
                /// *   **2**: waiting to be scheduled.
                /// </summary>
                [NameInMap("LatestInstanceStatus")]
                [Validation(Required=false)]
                public int? LatestInstanceStatus { get; set; }

                /// <summary>
                /// The time when the latest execution record was generated.
                /// </summary>
                [NameInMap("LatestInstanceTime")]
                [Validation(Required=false)]
                public string LatestInstanceTime { get; set; }

                /// <summary>
                /// The status of the task flow. Valid values:
                /// 
                /// *   **0**: The task flow is invalid.
                /// *   **1**: Scheduling is disabled for the task flow.
                /// *   **2**: The task flow is waiting to be scheduled.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

    }

}
