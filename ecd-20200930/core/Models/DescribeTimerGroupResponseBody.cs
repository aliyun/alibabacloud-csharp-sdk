// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeTimerGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration group information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeTimerGroupResponseBodyData Data { get; set; }
        public class DescribeTimerGroupResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of resources bound to the configuration group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("BindCount")]
            [Validation(Required=false)]
            public int? BindCount { get; set; }

            /// <summary>
            /// <para>The quantity information of resources bound to the configuration.</para>
            /// </summary>
            [NameInMap("BindCountMap")]
            [Validation(Required=false)]
            public Dictionary<string, int?> BindCountMap { get; set; }

            /// <summary>
            /// <para>The configuration information of scheduled tasks, in list format.</para>
            /// </summary>
            [NameInMap("ConfigTimers")]
            [Validation(Required=false)]
            public List<DescribeTimerGroupResponseBodyDataConfigTimers> ConfigTimers { get; set; }
            public class DescribeTimerGroupResponseBodyDataConfigTimers : TeaModel {
                /// <summary>
                /// <para>Specifies whether end users are allowed to configure scheduled tasks on their own.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AllowClientSetting")]
                [Validation(Required=false)]
                public bool? AllowClientSetting { get; set; }

                /// <summary>
                /// <para>The cron expression of the scheduled task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0 16 ? * 1,2,3,4,5,6,7</para>
                /// </summary>
                [NameInMap("CronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

                /// <summary>
                /// <para>Specifies whether to forcefully execute the task. A value of true indicates that the desktop and connection status checks are ignored and the scheduled task is forcefully executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Enforce")]
                [Validation(Required=false)]
                public bool? Enforce { get; set; }

                /// <summary>
                /// <para>The time interval, in minutes.</para>
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
                /// <para>The type of the disconnect scheduled task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Shutdown</para>
                /// </summary>
                [NameInMap("OperationType")]
                [Validation(Required=false)]
                public string OperationType { get; set; }

                /// <summary>
                /// <para>The process whitelist for intelligent detection of no-operation scheduled tasks. If a specified process is running, the no-operation scheduled task is not triggered.</para>
                /// </summary>
                [NameInMap("ProcessWhitelist")]
                [Validation(Required=false)]
                public List<string> ProcessWhitelist { get; set; }

                /// <summary>
                /// <para>The reset type of the reset scheduled task.</para>
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
                    /// <para>The specified time point for the fixed-time scheduled task. After this parameter is specified, the scheduled task is executed at the specified time point.</para>
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
                    /// <para>The image ID specified for the image change scheduled task.</para>
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
                    /// <para>The lock screen time point for the no-operation lock screen feature. This feature cannot be used for non-AD desktops.</para>
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
                /// <para>The trigger configuration type of the no-operation scheduled task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Standard</para>
                /// </summary>
                [NameInMap("TriggerType")]
                [Validation(Required=false)]
                public string TriggerType { get; set; }

            }

            /// <summary>
            /// <para>The description of the configuration group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Scheduled task</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The configuration group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cg-75aazkg2tnqb2*****</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The mapping code for the system scheduled task description, used for frontend display.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INNER_TIMER_10_MINUTES_HIBERNATE_NO_UPDATE_DESC</para>
            /// </summary>
            [NameInMap("InnerTimerDesc")]
            [Validation(Required=false)]
            public string InnerTimerDesc { get; set; }

            /// <summary>
            /// <para>The mapping code for the system scheduled task name, used for frontend display.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INNER_TIMER_10_MINUTES_HIBERNATE_NO_UPDATE</para>
            /// </summary>
            [NameInMap("InnerTimerName")]
            [Validation(Required=false)]
            public string InnerTimerName { get; set; }

            /// <summary>
            /// <para>Used for system scheduled task checks. The current scheduled task does not support unbinding or binding.</para>
            /// </summary>
            [NameInMap("IsBind")]
            [Validation(Required=false)]
            public bool? IsBind { get; set; }

            /// <summary>
            /// <para>Used for system scheduled task checks. The current scheduled task does not support modification.</para>
            /// </summary>
            [NameInMap("IsUpdate")]
            [Validation(Required=false)]
            public bool? IsUpdate { get; set; }

            /// <summary>
            /// <para>The name of the configuration group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Scheduled task</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The product type used by the configuration group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CLOUD_DESKTOP</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The status of the configuration group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the configuration group.</para>
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
