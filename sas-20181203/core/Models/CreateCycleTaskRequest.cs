// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateCycleTaskRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the task. Valid values:
        /// 
        /// *   **1**: yes
        /// *   **0**: no
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public int? Enable { get; set; }

        /// <summary>
        /// The first time when the task is performed.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FirstDateStr")]
        [Validation(Required=false)]
        public long? FirstDateStr { get; set; }

        /// <summary>
        /// The interval of the task.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IntervalPeriod")]
        [Validation(Required=false)]
        public int? IntervalPeriod { get; set; }

        /// <summary>
        /// The additional information.
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public string Param { get; set; }

        /// <summary>
        /// The unit of the scan interval. Valid values:
        /// 
        /// *   **day**: days
        /// *   **hour**: hours
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// The additional source for the task.
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// The time when the task ends. Unit: hours.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TargetEndTime")]
        [Validation(Required=false)]
        public int? TargetEndTime { get; set; }

        /// <summary>
        /// The time when the task is started. Unit: hours.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TargetStartTime")]
        [Validation(Required=false)]
        public int? TargetStartTime { get; set; }

        /// <summary>
        /// The name of the task. Valid values:
        /// 
        /// *   **VIRUS_VUL_SCHEDULE_SCAN**: virus scan task
        /// *   **IMAGE_SCAN**: image scan task
        /// *   **EMG_VUL_SCHEDULE_SCAN**: urgent vulnerability scan task
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// The type of the task. Valid values:
        /// 
        /// *   **VIRUS_VUL_SCHEDULE_SCAN**: virus scan task
        /// *   **IMAGE_SCAN**: image scan task
        /// *   **EMG_VUL_SCHEDULE_SCAN**: urgent vulnerability scan task
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
