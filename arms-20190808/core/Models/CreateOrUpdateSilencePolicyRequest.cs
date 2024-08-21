// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateSilencePolicyRequest : TeaModel {
        /// <summary>
        /// The effective duration of the silence policy. Valid values: PERMANENT, CUSTOM_TIME, and CYCLE_EFFECT.
        /// </summary>
        [NameInMap("EffectiveTimeType")]
        [Validation(Required=false)]
        public string EffectiveTimeType { get; set; }

        /// <summary>
        /// The ID of the silence policy.
        /// 
        /// *   If you do not configure this parameter, a new silence policy is created.
        /// *   If you configure this parameter, the specified silence policy is modified.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The matching rules. The following code shows the format of matching rules:
        /// 
        ///     [
        ///          {
        ///     	 "matchingConditions": [
        ///     	 {
        ///     	 "value": "test", // The value of the matching condition. 
        ///     	 "key": "altertname", // The key of the matching condition. 
        ///     	 "operator": "eq" // The logical operator of the matching condition, including eq (equal to), neq (not equal to), in (contains), nin (does not contain), re (regular expression match), and nre (regular expression mismatch).   
        ///     	 }
        ///     	 ]
        ///          }
        ///     	 ]
        /// </summary>
        [NameInMap("MatchingRules")]
        [Validation(Required=false)]
        public string MatchingRules { get; set; }

        /// <summary>
        /// The name of the silence policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to enable the silence policy. Valid values: enable and disable.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// The recurring period. This parameter is required when EffectiveTimeType is set to CYCLE_EFFECT. DAY: The silence policy is effective by day. WEEK: The silence policy is effective by week.
        /// </summary>
        [NameInMap("TimePeriod")]
        [Validation(Required=false)]
        public string TimePeriod { get; set; }

        /// <summary>
        /// The time period during which the silence policy is effective. If you set EffectiveTimeType to CUSTOM_TIME, specify a custom time period in the following format: [{"startTime":"2024-08-04 22:13","endTime":"2024-08-04 22:21"}] If you set EffectiveTimeType to CYCLE_EFFECT and TimePeriod to DAY, specify a custom time period in the following format: [{"startTime":"22:13","endTime":"22:21"}]. The start time cannot be later than the end time. If you set EffectiveTimeType to CYCLE_EFFECT and TimePeriod to WEEK, specify a custom time period in the following format: [{"startWeek":"1", "endWeek":"2" "startTime":"22:13","endTime":"22:21"}]. Valid values of startWeek and endWeek: 1 to 7. The start time cannot be later than the end time.
        /// </summary>
        [NameInMap("TimeSlots")]
        [Validation(Required=false)]
        public string TimeSlots { get; set; }

    }

}
