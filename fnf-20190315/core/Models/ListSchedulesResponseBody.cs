// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class ListSchedulesResponseBody : TeaModel {
        /// <summary>
        /// The token for the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The time-based schedules that are queried.
        /// </summary>
        [NameInMap("Schedules")]
        [Validation(Required=false)]
        public List<ListSchedulesResponseBodySchedules> Schedules { get; set; }
        public class ListSchedulesResponseBodySchedules : TeaModel {
            /// <summary>
            /// The time when the time-based schedule was created.
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// The cron expression of the scheduled task.
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// The description of the time-based schedule.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// Indicates whether the time-based schedule is enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// The time when the time-based schedule was last modified.
            /// </summary>
            [NameInMap("LastModifiedTime")]
            [Validation(Required=false)]
            public string LastModifiedTime { get; set; }

            /// <summary>
            /// The trigger message of the time-based schedule.
            /// </summary>
            [NameInMap("Payload")]
            [Validation(Required=false)]
            public string Payload { get; set; }

            /// <summary>
            /// The ID of the time-based schedule.
            /// </summary>
            [NameInMap("ScheduleId")]
            [Validation(Required=false)]
            public string ScheduleId { get; set; }

            /// <summary>
            /// The name of the time-based schedule.
            /// </summary>
            [NameInMap("ScheduleName")]
            [Validation(Required=false)]
            public string ScheduleName { get; set; }

        }

    }

}
