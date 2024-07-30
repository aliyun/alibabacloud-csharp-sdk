// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreateScheduledScalingRuleShrinkRequest : TeaModel {
        /// <summary>
        /// The duration of each scheduled scaling task. Unit: minutes.
        /// 
        /// >  The value of this parameter must be greater than or equal to 15.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DurationMinutes")]
        [Validation(Required=false)]
        public int? DurationMinutes { get; set; }

        /// <summary>
        /// Specifies whether to enable the scheduled scaling rule. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// The time when the scheduled scaling task is executed.
        /// 
        /// If you set ScheduleType to at, make sure that the value of this parameter is at least 30 minutes later than the current point in time.
        /// 
        /// >Notice: To prevent the broker from repeatedly executing instance upgrade and downgrade tasks, make sure that the interval between two consecutive scheduled scaling tasks is at least 60 minutes.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FirstScheduledTime")]
        [Validation(Required=false)]
        public long? FirstScheduledTime { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the region where the instance resides.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The frequency to execute the scheduled scaling task. This parameter is required only if you set ScheduleType to repeat. Valid values:
        /// 
        /// *   Daily: The scheduled scaling task is executed every day.
        /// 
        /// *   Weekly: The scheduled scaling task is executed every week.
        /// </summary>
        [NameInMap("RepeatType")]
        [Validation(Required=false)]
        public string RepeatType { get; set; }

        /// <summary>
        /// The reserved production capacity for scheduled scaling. Unit: MB/s.
        /// 
        /// >  You must specify a higher value than the instance specification for at least one of ReservedPubFlow and ReservedSubFlow.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReservedPubFlow")]
        [Validation(Required=false)]
        public int? ReservedPubFlow { get; set; }

        /// <summary>
        /// The reserved consumption capacity for scheduled scaling. Unit: MB/s.
        /// 
        /// >  You must specify a higher value than the instance specification for at least one of ReservedPubFlow and ReservedSubFlow.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReservedSubFlow")]
        [Validation(Required=false)]
        public int? ReservedSubFlow { get; set; }

        /// <summary>
        /// The name of the scheduled scaling rule.
        /// 
        /// >  The name of the scheduled scaling rule cannot be the same as the names of other rules for the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// The type of the scheduled scaling task. Valid values:
        /// 
        /// *   at: The scheduled scaling task is executed only once.
        /// *   repeat: The scheduled scaling task is repeatedly executed.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScheduleType")]
        [Validation(Required=false)]
        public string ScheduleType { get; set; }

        /// <summary>
        /// The time zone in Coordinated Universal Time (UTC).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TimeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// The day on which the scheduled scaling task is executed every week. You can specify multiple days.
        /// </summary>
        [NameInMap("WeeklyTypes")]
        [Validation(Required=false)]
        public string WeeklyTypesShrink { get; set; }

    }

}
