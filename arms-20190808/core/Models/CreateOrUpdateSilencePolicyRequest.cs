// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateSilencePolicyRequest : TeaModel {
        /// <summary>
        /// <para>The effective duration of the silence policy. Valid values: PERMANENT, CUSTOM_TIME, and CYCLE_EFFECT.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PERMANENT</para>
        /// </summary>
        [NameInMap("EffectiveTimeType")]
        [Validation(Required=false)]
        public string EffectiveTimeType { get; set; }

        /// <summary>
        /// <para>The ID of the silence policy.</para>
        /// <list type="bullet">
        /// <item><description>If you do not configure this parameter, a new silence policy is created.</description></item>
        /// <item><description>If you configure this parameter, the specified silence policy is modified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The matching rules. The following code shows the format of matching rules:</para>
        /// <pre><c>[
        ///      {
        ///      &quot;matchingConditions&quot;: [
        ///      {
        ///      &quot;value&quot;: &quot;test&quot;, // The value of the matching condition. 
        ///      &quot;key&quot;: &quot;altertname&quot;, // The key of the matching condition. 
        ///      &quot;operator&quot;: &quot;eq&quot; // The logical operator of the matching condition, including eq (equal to), neq (not equal to), in (contains), nin (does not contain), re (regular expression match), and nre (regular expression mismatch).   
        ///      }
        ///      ]
        ///      }
        ///      ]
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para>[ 	 { 	 &quot;matchingConditions&quot;: [ 	 { 	 &quot;value&quot;: &quot;test&quot;, 	 &quot;key&quot;: &quot;altertname&quot;, 	 &quot;operator&quot;: &quot;eq&quot; 	 } 	 ]      } 	 ]</para>
        /// </summary>
        [NameInMap("MatchingRules")]
        [Validation(Required=false)]
        public string MatchingRules { get; set; }

        /// <summary>
        /// <para>The name of the silence policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>silencepolicy_test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the silence policy. Valid values: enable and disable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The recurring period. This parameter is required when EffectiveTimeType is set to CYCLE_EFFECT. DAY: The silence policy is effective by day. WEEK: The silence policy is effective by week.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DAY</para>
        /// </summary>
        [NameInMap("TimePeriod")]
        [Validation(Required=false)]
        public string TimePeriod { get; set; }

        /// <summary>
        /// <para>The time period during which the silence policy is effective. If you set EffectiveTimeType to CUSTOM_TIME, specify a custom time period in the following format: [{&quot;startTime&quot;:&quot;2024-08-04 22:13&quot;,&quot;endTime&quot;:&quot;2024-08-04 22:21&quot;}] If you set EffectiveTimeType to CYCLE_EFFECT and TimePeriod to DAY, specify a custom time period in the following format: [{&quot;startTime&quot;:&quot;22:13&quot;,&quot;endTime&quot;:&quot;22:21&quot;}]. The start time cannot be later than the end time. If you set EffectiveTimeType to CYCLE_EFFECT and TimePeriod to WEEK, specify a custom time period in the following format: [{&quot;startWeek&quot;:&quot;1&quot;, &quot;endWeek&quot;:&quot;2&quot; &quot;startTime&quot;:&quot;22:13&quot;,&quot;endTime&quot;:&quot;22:21&quot;}]. Valid values of startWeek and endWeek: 1 to 7. The start time cannot be later than the end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;startTime&quot;:&quot;2024-08-04 22:13&quot;,&quot;endTime&quot;:&quot;2024-08-04 22:21&quot;}]</para>
        /// </summary>
        [NameInMap("TimeSlots")]
        [Validation(Required=false)]
        public string TimeSlots { get; set; }

    }

}
