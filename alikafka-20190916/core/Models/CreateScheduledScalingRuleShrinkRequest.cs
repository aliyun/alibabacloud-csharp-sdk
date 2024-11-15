// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreateScheduledScalingRuleShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The duration of each scheduled scaling task. Unit: minutes.</para>
        /// <remarks>
        /// <para> The value of this parameter must be greater than or equal to 15.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("DurationMinutes")]
        [Validation(Required=false)]
        public int? DurationMinutes { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the scheduled scaling rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The time when the scheduled scaling task is executed.</para>
        /// <para>If you set ScheduleType to at, make sure that the value of this parameter is at least 30 minutes later than the current point in time.</para>
        /// <remarks>
        /// <para>Notice: To prevent the broker from repeatedly executing instance upgrade and downgrade tasks, make sure that the interval between two consecutive scheduled scaling tasks is at least 60 minutes.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1714467540000</para>
        /// </summary>
        [NameInMap("FirstScheduledTime")]
        [Validation(Required=false)]
        public long? FirstScheduledTime { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka_serverless-cn-vxxxxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The frequency to execute the scheduled scaling task. This parameter is required only if you set ScheduleType to repeat. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Daily: The scheduled scaling task is executed every day.</para>
        /// </description></item>
        /// <item><description><para>Weekly: The scheduled scaling task is executed every week.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Weekly</para>
        /// </summary>
        [NameInMap("RepeatType")]
        [Validation(Required=false)]
        public string RepeatType { get; set; }

        /// <summary>
        /// <para>The reserved production capacity for scheduled scaling. Unit: MB/s.</para>
        /// <remarks>
        /// <para> You must specify a higher value than the instance specification for at least one of ReservedPubFlow and ReservedSubFlow.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("ReservedPubFlow")]
        [Validation(Required=false)]
        public int? ReservedPubFlow { get; set; }

        /// <summary>
        /// <para>The reserved consumption capacity for scheduled scaling. Unit: MB/s.</para>
        /// <remarks>
        /// <para> You must specify a higher value than the instance specification for at least one of ReservedPubFlow and ReservedSubFlow.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("ReservedSubFlow")]
        [Validation(Required=false)]
        public int? ReservedSubFlow { get; set; }

        /// <summary>
        /// <para>The name of the scheduled scaling rule.</para>
        /// <remarks>
        /// <para> The name of the scheduled scaling rule cannot be the same as the names of other rules for the instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The type of the scheduled scaling task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>at: The scheduled scaling task is executed only once.</description></item>
        /// <item><description>repeat: The scheduled scaling task is repeatedly executed.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>at</para>
        /// </summary>
        [NameInMap("ScheduleType")]
        [Validation(Required=false)]
        public string ScheduleType { get; set; }

        /// <summary>
        /// <para>The time zone in Coordinated Universal Time (UTC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GMT+8</para>
        /// </summary>
        [NameInMap("TimeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// <para>The day on which the scheduled scaling task is executed every week. You can specify multiple days.</para>
        /// </summary>
        [NameInMap("WeeklyTypes")]
        [Validation(Required=false)]
        public string WeeklyTypesShrink { get; set; }

    }

}
