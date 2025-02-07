// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class CreateScheduleRequest : TeaModel {
        /// <summary>
        /// The CRON expression.
        /// 
        /// This parameter is required.
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
        /// Specifies whether to enable the time-based schedule. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// The name of the workflow that is associated with the time-based schedule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// The trigger message of the time-based schedule. Specify the value in the JSON format.
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public string Payload { get; set; }

        /// <summary>
        /// The name of the time-based schedule. The name must meet the following conventions:
        /// 
        /// *   The name can contain letters, digits, underscores (_), and hyphens (-).
        /// *   The name must start with a letter or an underscore (_).
        /// *   It is case-sensitive.
        /// *   The name must be 1 to 128 characters in length.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScheduleName")]
        [Validation(Required=false)]
        public string ScheduleName { get; set; }

        [NameInMap("SignatureVersion")]
        [Validation(Required=false)]
        public string SignatureVersion { get; set; }

    }

}
