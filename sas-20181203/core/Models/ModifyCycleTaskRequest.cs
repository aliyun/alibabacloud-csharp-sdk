// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyCycleTaskRequest : TeaModel {
        /// <summary>
        /// The ID of the task configuration.
        /// 
        /// >  You can call the [DescribeCycleTaskList](~~DescribeCycleTaskList~~) operation to query the IDs of task configurations.
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        /// <summary>
        /// Specifies whether to enable the task. Valid values:
        /// 
        /// *   **1**: enables the task.
        /// *   **0**: disables the task.
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public int? Enable { get; set; }

        /// <summary>
        /// The time when the task first started.
        /// </summary>
        [NameInMap("FirstDateStr")]
        [Validation(Required=false)]
        public long? FirstDateStr { get; set; }

        /// <summary>
        /// The interval at which the task is run.
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
        /// *   **day**
        /// *   **hour**
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// The end time of the task. The time must be a time frame.
        /// </summary>
        [NameInMap("TargetEndTime")]
        [Validation(Required=false)]
        public int? TargetEndTime { get; set; }

        /// <summary>
        /// The start time of the task. The start time must be a time frame.
        /// </summary>
        [NameInMap("TargetStartTime")]
        [Validation(Required=false)]
        public int? TargetStartTime { get; set; }

        /// <summary>
        /// The name of the task. Valid values:
        /// 
        /// *   **VIRUS_VUL_SCHEDULE_SCAN**: virus detection task
        /// *   **IMAGE_SCAN**: image scan task
        /// *   **EMG_VUL_SCHEDULE_SCAN**: urgent vulnerability scan task
        /// 
        /// Valid values:
        /// 
        /// *   VIRUS_VUL_SCHEDULE_SCAN
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     virus detection task
        /// 
        ///     <!-- -->
        /// 
        /// *   IMAGE_SCAN
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     image scan task
        /// 
        ///     <!-- -->
        /// 
        /// *   EMG_VUL_SCHEDULE_SCAN
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     urgent vulnerability scan task
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// The type of the task. Valid values:
        /// 
        /// *   **VIRUS_VUL_SCHEDULE_SCAN**: virus detection task
        /// *   **IMAGE_SCAN**: image scan task
        /// *   **EMG_VUL_SCHEDULE_SCAN**: urgent vulnerability scan task
        /// 
        /// Valid values:
        /// 
        /// *   VIRUS_VUL_SCHEDULE_SCAN
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     virus detection task
        /// 
        ///     <!-- -->
        /// 
        /// *   IMAGE_SCAN
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     image scan task
        /// 
        ///     <!-- -->
        /// 
        /// *   EMG_VUL_SCHEDULE_SCAN
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     urgent vulnerability scan task
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
