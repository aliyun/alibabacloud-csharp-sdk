// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreateScheduledScalingRuleShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The duration (unit: minutes) of a scheduled elastic task.</para>
        /// <remarks>
        /// <para>The parameter value must be at least 15 minutes.</para>
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
        /// <para>Enables or disables the scheduled task policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enables the policy.</description></item>
        /// <item><description><b>false</b>: Disables the policy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The time when the scheduled policy starts to execute.</para>
        /// <para>For a one-time scheduling policy type, the start execution time must be more than 30 minutes later than the current time.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>To avoid the service from continuously executing upgrade and downgrade tasks, the time interval between different scheduled tasks must be at least 60 minutes.</para>
        /// </notice>
        /// 
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
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>When ScheduleType is set to repeat, you need to fill in this parameter. Enumeration values are:</para>
        /// <list type="bullet">
        /// <item><description><para>Daily: Daily scheduled task.</para>
        /// </description></item>
        /// <item><description><para>Weekly: Weekly scheduled task.</para>
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
        /// <para>The scheduled elastic reserved production specification (unit: MB/s).</para>
        /// <remarks>
        /// <para>At least one of the ReservedPubFlow and ReservedSubFlow parameters must be higher than the current specification.</para>
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
        /// <para>The scheduled elastic reserved consumption specification (unit: MB/s).</para>
        /// <remarks>
        /// <para>At least one of the ReservedSubFlow and ReservedPubFlow parameters must be higher than the current specification.</para>
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
        /// <para>The name of the scheduled policy rule.</para>
        /// <remarks>
        /// <para>The name cannot be the same as other rule names for the same instance.</para>
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
        /// <para>The schedule type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>at: Scheduled only once.</description></item>
        /// <item><description>repeat: Scheduled repeatedly.</description></item>
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
        /// <para>The time zone (Coordinated Universal Time).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GMT+8</para>
        /// </summary>
        [NameInMap("TimeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// <para>The weekly types. Supports execution on multiple days.</para>
        /// </summary>
        [NameInMap("WeeklyTypes")]
        [Validation(Required=false)]
        public string WeeklyTypesShrink { get; set; }

    }

}
