// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTaskFlowsByPageResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
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
        /// The details of the returned task flows.
        /// </summary>
        [NameInMap("TaskFlowList")]
        [Validation(Required=false)]
        public ListTaskFlowsByPageResponseBodyTaskFlowList TaskFlowList { get; set; }
        public class ListTaskFlowsByPageResponseBodyTaskFlowList : TeaModel {
            [NameInMap("TaskFlow")]
            [Validation(Required=false)]
            public List<ListTaskFlowsByPageResponseBodyTaskFlowListTaskFlow> TaskFlow { get; set; }
            public class ListTaskFlowsByPageResponseBodyTaskFlowListTaskFlow : TeaModel {
                /// <summary>
                /// The ID of the user who created the task flow.
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// The username of the user who created the task flow.
                /// </summary>
                [NameInMap("CreatorNickName")]
                [Validation(Required=false)]
                public string CreatorNickName { get; set; }

                /// <summary>
                /// The start time of scheduled scheduling. The task flow is not scheduled before this point in time.
                /// </summary>
                [NameInMap("CronBeginDate")]
                [Validation(Required=false)]
                public string CronBeginDate { get; set; }

                /// <summary>
                /// The end time of scheduled scheduling. The task flow is not scheduled after this point in time.
                /// </summary>
                [NameInMap("CronEndDate")]
                [Validation(Required=false)]
                public string CronEndDate { get; set; }

                /// <summary>
                /// Scheduled Cron.
                /// </summary>
                [NameInMap("CronStr")]
                [Validation(Required=false)]
                public string CronStr { get; set; }

                /// <summary>
                /// Whether to enable scheduled scheduling.
                /// </summary>
                [NameInMap("CronSwitch")]
                [Validation(Required=false)]
                public bool? CronSwitch { get; set; }

                /// <summary>
                /// Scheduling cycle type. Valid values:
                /// - **2**: Hourly scheduling
                /// - **3**: Daily scheduling
                /// - **4**: Weekly scheduling
                /// - **5**: Monthly scheduling
                /// </summary>
                [NameInMap("CronType")]
                [Validation(Required=false)]
                public int? CronType { get; set; }

                /// <summary>
                /// The name of the task flow.
                /// </summary>
                [NameInMap("DagName")]
                [Validation(Required=false)]
                public string DagName { get; set; }

                /// <summary>
                /// The user ID of the task flow owner.
                /// </summary>
                [NameInMap("DagOwnerId")]
                [Validation(Required=false)]
                public string DagOwnerId { get; set; }

                /// <summary>
                /// The username of the owner of the task flow.
                /// </summary>
                [NameInMap("DagOwnerNickName")]
                [Validation(Required=false)]
                public string DagOwnerNickName { get; set; }

                /// <summary>
                /// The ID of the last deployment record of the task flow.
                /// </summary>
                [NameInMap("DeployId")]
                [Validation(Required=false)]
                public long? DeployId { get; set; }

                /// <summary>
                /// The description of the task flow.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the task flow.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The status of the last execution of the task flow. Valid values:
                /// 
                /// *   **0**: invalid
                /// *   **1**: scheduling disabled
                /// *   **2**: waiting to be scheduled
                /// </summary>
                [NameInMap("LatestInstanceStatus")]
                [Validation(Required=false)]
                public int? LatestInstanceStatus { get; set; }

                /// <summary>
                /// The time when the last execution record was created.
                /// </summary>
                [NameInMap("LatestInstanceTime")]
                [Validation(Required=false)]
                public string LatestInstanceTime { get; set; }

                /// <summary>
                /// The ID of the application scenario.
                /// </summary>
                [NameInMap("ScenarioId")]
                [Validation(Required=false)]
                public string ScenarioId { get; set; }

                /// <summary>
                /// Event scheduling configuration, JSON string format.
                /// </summary>
                [NameInMap("ScheduleParam")]
                [Validation(Required=false)]
                public string ScheduleParam { get; set; }

                /// <summary>
                /// The status of the task flow. Valid values:
                /// 
                /// *   **0**: invalid
                /// *   **1**: scheduling disabled
                /// *   **2**: waiting to be scheduled
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// Time zone setting. Default value: East 8(Asia/Shanghai).
                /// </summary>
                [NameInMap("TimeZoneId")]
                [Validation(Required=false)]
                public string TimeZoneId { get; set; }

                /// <summary>
                /// The trigger type. Valid values:
                /// - **0**: Periodic scheduling
                /// - **1**: Run manually
                /// </summary>
                [NameInMap("TriggerType")]
                [Validation(Required=false)]
                public int? TriggerType { get; set; }

            }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
