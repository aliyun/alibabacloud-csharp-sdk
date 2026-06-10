// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeTimerGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the timer group.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeTimerGroupResponseBodyData Data { get; set; }
        public class DescribeTimerGroupResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of resources associated with the timer group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("BindCount")]
            [Validation(Required=false)]
            public int? BindCount { get; set; }

            /// <summary>
            /// <para>A map of associated resource counts, categorized by resource type.</para>
            /// </summary>
            [NameInMap("BindCountMap")]
            [Validation(Required=false)]
            public Dictionary<string, int?> BindCountMap { get; set; }

            /// <summary>
            /// <para>The configurations of the scheduled tasks.</para>
            /// </summary>
            [NameInMap("ConfigTimers")]
            [Validation(Required=false)]
            public List<DescribeTimerGroupResponseBodyDataConfigTimers> ConfigTimers { get; set; }
            public class DescribeTimerGroupResponseBodyDataConfigTimers : TeaModel {
                /// <summary>
                /// <para>Whether to allow end users to configure the scheduled task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AllowClientSetting")]
                [Validation(Required=false)]
                public bool? AllowClientSetting { get; set; }

                /// <summary>
                /// <para>The cron expression for the scheduled task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0 16 ? * 1,2,3,4,5,6,7</para>
                /// </summary>
                [NameInMap("CronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

                /// <summary>
                /// <para>Specifies whether to force the execution of the scheduled task. If set to <c>true</c>, the task runs regardless of the cloud computer\&quot;s status or connection state.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Enforce")]
                [Validation(Required=false)]
                public bool? Enforce { get; set; }

                /// <summary>
                /// <para>The interval. Unit: minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                [NameInMap("NotificationTime")]
                [Validation(Required=false)]
                public int? NotificationTime { get; set; }

                /// <summary>
                /// <para>The operation to perform when <c>TimerType</c> is set to <c>NoConnect</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Shutdown</para>
                /// </summary>
                [NameInMap("OperationType")]
                [Validation(Required=false)]
                public string OperationType { get; set; }

                /// <summary>
                /// <para>The process whitelist for smart detection. A scheduled task based on user inactivity does not run if a whitelisted process is running.</para>
                /// </summary>
                [NameInMap("ProcessWhitelist")]
                [Validation(Required=false)]
                public List<string> ProcessWhitelist { get; set; }

                /// <summary>
                /// <para>The reset type for the scheduled reset task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RESET_TYPE_SYSTEM</para>
                /// </summary>
                [NameInMap("ResetType")]
                [Validation(Required=false)]
                public string ResetType { get; set; }

                [NameInMap("SegmentTimers")]
                [Validation(Required=false)]
                public List<DescribeTimerGroupResponseBodyDataConfigTimersSegmentTimers> SegmentTimers { get; set; }
                public class DescribeTimerGroupResponseBodyDataConfigTimersSegmentTimers : TeaModel {
                    /// <summary>
                    /// <para>The time to execute the scheduled task, specified as a Unix timestamp in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1764660600967</para>
                    /// </summary>
                    [NameInMap("AppointmentTimer")]
                    [Validation(Required=false)]
                    public long? AppointmentTimer { get; set; }

                    [NameInMap("CreateSnapshot")]
                    [Validation(Required=false)]
                    public bool? CreateSnapshot { get; set; }

                    [NameInMap("EndCronExpression")]
                    [Validation(Required=false)]
                    public string EndCronExpression { get; set; }

                    [NameInMap("Enforce")]
                    [Validation(Required=false)]
                    public bool? Enforce { get; set; }

                    /// <summary>
                    /// <para>The image ID for a scheduled image-change task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>m-5b0vjqbiqu010XXXXXX</para>
                    /// </summary>
                    [NameInMap("ImageId")]
                    [Validation(Required=false)]
                    public string ImageId { get; set; }

                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public int? Interval { get; set; }

                    [NameInMap("IpSegments")]
                    [Validation(Required=false)]
                    public List<string> IpSegments { get; set; }

                    /// <summary>
                    /// <para>The duration of user inactivity, in seconds, before the screen locks. This feature applies only to cloud computers joined to an Active Directory (AD) domain.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1800</para>
                    /// </summary>
                    [NameInMap("LockScreenTime")]
                    [Validation(Required=false)]
                    public int? LockScreenTime { get; set; }

                    [NameInMap("NotificationTime")]
                    [Validation(Required=false)]
                    public int? NotificationTime { get; set; }

                    [NameInMap("OperationType")]
                    [Validation(Required=false)]
                    public string OperationType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>KB5082063</para>
                    /// </summary>
                    [NameInMap("PatchId")]
                    [Validation(Required=false)]
                    public string PatchId { get; set; }

                    [NameInMap("ProcessWhitelist")]
                    [Validation(Required=false)]
                    public List<string> ProcessWhitelist { get; set; }

                    [NameInMap("ResetType")]
                    [Validation(Required=false)]
                    public string ResetType { get; set; }

                    [NameInMap("StartCronExpression")]
                    [Validation(Required=false)]
                    public string StartCronExpression { get; set; }

                    [NameInMap("TimerOrder")]
                    [Validation(Required=false)]
                    public int? TimerOrder { get; set; }

                    [NameInMap("Timezone")]
                    [Validation(Required=false)]
                    public string Timezone { get; set; }

                    [NameInMap("TriggerType")]
                    [Validation(Required=false)]
                    public string TriggerType { get; set; }

                    [NameInMap("VerificationNotificationTime")]
                    [Validation(Required=false)]
                    public int? VerificationNotificationTime { get; set; }

                    [NameInMap("VerificationTime")]
                    [Validation(Required=false)]
                    public int? VerificationTime { get; set; }

                }

                /// <summary>
                /// <para>The type of the scheduled task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TimerBoot</para>
                /// </summary>
                [NameInMap("TimerType")]
                [Validation(Required=false)]
                public string TimerType { get; set; }

                /// <summary>
                /// <para>The detection method for user inactivity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Standard</para>
                /// </summary>
                [NameInMap("TriggerType")]
                [Validation(Required=false)]
                public string TriggerType { get; set; }

            }

            /// <summary>
            /// <para>The description of the timer group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Scheduled task</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the timer group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cg-75aazkg2tnqb2*****</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>An internal code used by the frontend to display the description of a system-scheduled task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INNER_TIMER_10_MINUTES_HIBERNATE_NO_UPDATE_DESC</para>
            /// </summary>
            [NameInMap("InnerTimerDesc")]
            [Validation(Required=false)]
            public string InnerTimerDesc { get; set; }

            /// <summary>
            /// <para>An internal code used by the frontend to display the name of a system-scheduled task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INNER_TIMER_10_MINUTES_HIBERNATE_NO_UPDATE</para>
            /// </summary>
            [NameInMap("InnerTimerName")]
            [Validation(Required=false)]
            public string InnerTimerName { get; set; }

            /// <summary>
            /// <para>Indicates that resources cannot be bound to or unbound from this timer group.</para>
            /// </summary>
            [NameInMap("IsBind")]
            [Validation(Required=false)]
            public bool? IsBind { get; set; }

            /// <summary>
            /// <para>Indicates that this timer group cannot be modified.</para>
            /// </summary>
            [NameInMap("IsUpdate")]
            [Validation(Required=false)]
            public bool? IsUpdate { get; set; }

            /// <summary>
            /// <para>The name of the timer group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Scheduled task</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The product type that the timer group supports.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CLOUD_DESKTOP</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The status of the timer group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the timer group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Timer</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
