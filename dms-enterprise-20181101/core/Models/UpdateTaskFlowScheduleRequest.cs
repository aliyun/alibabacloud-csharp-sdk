// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class UpdateTaskFlowScheduleRequest : TeaModel {
        /// <summary>
        /// The start of the time range for scheduling.
        /// </summary>
        [NameInMap("CronBeginDate")]
        [Validation(Required=false)]
        public string CronBeginDate { get; set; }

        /// <summary>
        /// The end of the time range for scheduling.
        /// </summary>
        [NameInMap("CronEndDate")]
        [Validation(Required=false)]
        public string CronEndDate { get; set; }

        /// <summary>
        /// The cron expression for timed scheduling.
        /// </summary>
        [NameInMap("CronStr")]
        [Validation(Required=false)]
        public string CronStr { get; set; }

        /// <summary>
        /// The type of the scheduling cycle. Valid values:
        /// 
        /// *   **MINUTE**: scheduling by minute
        /// *   **HOUR**: scheduling by hour
        /// *   **DAY**: scheduling by day
        /// *   **WEEK**: scheduling by week
        /// *   **MONTH**: scheduling by month
        /// </summary>
        [NameInMap("CronType")]
        [Validation(Required=false)]
        public string CronType { get; set; }

        /// <summary>
        /// The ID of the task flow.
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        /// <summary>
        /// The event scheduling configuration. The value of this parameter is a JSON string.
        /// </summary>
        [NameInMap("ScheduleParam")]
        [Validation(Required=false)]
        public string ScheduleParam { get; set; }

        /// <summary>
        /// Specifies whether to enable scheduling. Valid values:
        /// 
        /// *   **Enable**
        /// *   **Disable**
        /// </summary>
        [NameInMap("ScheduleSwitch")]
        [Validation(Required=false)]
        public bool? ScheduleSwitch { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// > : To view the ID of the tenant, go to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see [View information about the current tenant](~~181330~~).
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// The time zone. The default time zone is UTC+8 (Asia/Shanghai).
        /// </summary>
        [NameInMap("TimeZoneId")]
        [Validation(Required=false)]
        public string TimeZoneId { get; set; }

        /// <summary>
        /// The mode in which the task flow is triggered. Valid values:
        /// 
        /// *   **Cron**: The task flow is triggered based on timed scheduling.
        /// *   **Event**: The task flow is triggered by events.
        /// </summary>
        [NameInMap("TriggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

    }

}
