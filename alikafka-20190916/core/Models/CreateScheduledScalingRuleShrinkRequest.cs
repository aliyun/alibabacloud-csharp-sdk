// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreateScheduledScalingRuleShrinkRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DurationMinutes")]
        [Validation(Required=false)]
        public int? DurationMinutes { get; set; }

        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("FirstScheduledTime")]
        [Validation(Required=false)]
        public long? FirstScheduledTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RepeatType")]
        [Validation(Required=false)]
        public string RepeatType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReservedPubFlow")]
        [Validation(Required=false)]
        public int? ReservedPubFlow { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReservedSubFlow")]
        [Validation(Required=false)]
        public int? ReservedSubFlow { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScheduleType")]
        [Validation(Required=false)]
        public string ScheduleType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TimeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

        [NameInMap("WeeklyTypes")]
        [Validation(Required=false)]
        public string WeeklyTypesShrink { get; set; }

    }

}
