// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class UpdateAutoThrottleRulesAsyncRequest : TeaModel {
        /// <summary>
        /// The duration threshold for triggering automatic SQL throttling. Set this parameter to a positive integer that is greater than or equal to 2. Unit: minutes.
        /// </summary>
        [NameInMap("AbnormalDuration")]
        [Validation(Required=false)]
        public double? AbnormalDuration { get; set; }

        /// <summary>
        /// The maximum number of active sessions.
        /// 
        /// *   Specify an integer that is greater than or equal to 16 when the CPU utilization threshold and the maximum number of active sessions are in the **OR** relationship.
        /// *   Specify an integer that is greater than or equal to 2 when the CPU utilization threshold and the maximum number of active sessions are in the **AND** relationship.
        /// </summary>
        [NameInMap("ActiveSessions")]
        [Validation(Required=false)]
        public long? ActiveSessions { get; set; }

        /// <summary>
        /// The end time of the throttling window. The time must be in UTC.
        /// </summary>
        [NameInMap("AllowThrottleEndTime")]
        [Validation(Required=false)]
        public string AllowThrottleEndTime { get; set; }

        /// <summary>
        /// The start time of the throttling window. The time must be in UTC.
        /// </summary>
        [NameInMap("AllowThrottleStartTime")]
        [Validation(Required=false)]
        public string AllowThrottleStartTime { get; set; }

        /// <summary>
        /// Specifies whether to terminate abnormal SQL statements in execution at the same time. Valid values:
        /// 
        /// >  Abnormal SQL statements use the same template as the SQL statements that need to be throttled.
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("AutoKillSession")]
        [Validation(Required=false)]
        public bool? AutoKillSession { get; set; }

        /// <summary>
        /// The reserved parameter.
        /// </summary>
        [NameInMap("ConsoleContext")]
        [Validation(Required=false)]
        public string ConsoleContext { get; set; }

        /// <summary>
        /// The logical relationship between the CPU utilization threshold and the maximum number of active sessions. Valid values:
        /// 
        /// *   **AND**
        /// *   **OR**
        /// </summary>
        [NameInMap("CpuSessionRelation")]
        [Validation(Required=false)]
        public string CpuSessionRelation { get; set; }

        /// <summary>
        /// The CPU utilization threshold, in percentages. Valid values: 70 to 100.
        /// </summary>
        [NameInMap("CpuUsage")]
        [Validation(Required=false)]
        public double? CpuUsage { get; set; }

        /// <summary>
        /// The database instance IDs.
        /// 
        /// >  Set this parameter to a JSON array that consists of multiple instance IDs. Separate instance IDs with commas (,). Example: `[\"Instance ID1\", \"Instance ID2\"]`.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// The maximum throttling duration. Set this parameter to a positive integer. Unit: minutes.
        /// </summary>
        [NameInMap("MaxThrottleTime")]
        [Validation(Required=false)]
        public double? MaxThrottleTime { get; set; }

        /// <summary>
        /// The ID of the asynchronous request.
        /// 
        /// >  You can leave this parameter empty when you call the operation to initiate the request for the first time, and use the value of this parameter contained in the response to the first request for subsequent requests.
        /// </summary>
        [NameInMap("ResultId")]
        [Validation(Required=false)]
        public string ResultId { get; set; }

    }

}
