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
            /// <para>The information about the number of resources bound to the configuration.</para>
            /// </summary>
            [NameInMap("BindCountMap")]
            [Validation(Required=false)]
            public Dictionary<string, int?> BindCountMap { get; set; }

            /// <summary>
            /// <para>The configuration information of scheduled tasks.</para>
            /// </summary>
            [NameInMap("ConfigTimers")]
            [Validation(Required=false)]
            public List<DescribeTimerGroupResponseBodyDataConfigTimers> ConfigTimers { get; set; }
            public class DescribeTimerGroupResponseBodyDataConfigTimers : TeaModel {
                /// <summary>
                /// <para>Specifies whether end users are allowed to configure scheduled tasks.</para>
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
                /// <para>Specifies whether to forcibly execute the task. A value of true indicates that the scheduled task is forcibly executed, ignoring the desktop and connection status checks.</para>
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

                /// <summary>
                /// <para>The advance notification time before the scheduled task is executed, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("NotificationTime")]
                [Validation(Required=false)]
                public int? NotificationTime { get; set; }

                /// <summary>
                /// <para>The type of the disconnection scheduled task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Shutdown</para>
                /// </summary>
                [NameInMap("OperationType")]
                [Validation(Required=false)]
                public string OperationType { get; set; }

                /// <summary>
                /// <para>The process whitelist for the intelligent evaluation of no-operation scheduled tasks. If a specified process is running, the no-operation scheduled task is not triggered.</para>
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

                /// <summary>
                /// <para>The list of segment timer configurations.</para>
                /// </summary>
                [NameInMap("SegmentTimers")]
                [Validation(Required=false)]
                public List<DescribeTimerGroupResponseBodyDataConfigTimersSegmentTimers> SegmentTimers { get; set; }
                public class DescribeTimerGroupResponseBodyDataConfigTimersSegmentTimers : TeaModel {
                    /// <summary>
                    /// <para>Specifies the time to execute the scheduled task. After this parameter is specified, the scheduled task is executed at the specified time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1764660600967</para>
                    /// </summary>
                    [NameInMap("AppointmentTimer")]
                    [Validation(Required=false)]
                    public long? AppointmentTimer { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to create a snapshot.</para>
                    /// </summary>
                    [NameInMap("CreateSnapshot")]
                    [Validation(Required=false)]
                    public bool? CreateSnapshot { get; set; }

                    /// <summary>
                    /// <para>The cron expression for ending the execution of the scheduled task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0 0 18 ? * 1-5</para>
                    /// </summary>
                    [NameInMap("EndCronExpression")]
                    [Validation(Required=false)]
                    public string EndCronExpression { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to forcibly execute the task. A value of true indicates that the scheduled task is forcibly executed, ignoring the desktop and connection status checks.</para>
                    /// </summary>
                    [NameInMap("Enforce")]
                    [Validation(Required=false)]
                    public bool? Enforce { get; set; }

                    /// <summary>
                    /// <para>Specifies the ID of the image to be replaced. This parameter is used for scheduled image replacement tasks.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>m-5b0vjqbiqu010XXXXXX</para>
                    /// </summary>
                    [NameInMap("ImageId")]
                    [Validation(Required=false)]
                    public string ImageId { get; set; }

                    /// <summary>
                    /// <para>The time interval, in minutes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public int? Interval { get; set; }

                    /// <summary>
                    /// <para>The list of effective IP CIDR blocks.</para>
                    /// </summary>
                    [NameInMap("IpSegments")]
                    [Validation(Required=false)]
                    public List<string> IpSegments { get; set; }

                    /// <summary>
                    /// <para>Specifies the duration of inactivity before the screen is locked, in minutes. This parameter is used for the no-operation lock screen feature and is supported only by AD cloud desktops.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("LockScreenTime")]
                    [Validation(Required=false)]
                    public int? LockScreenTime { get; set; }

                    /// <summary>
                    /// <para>The advance notification time before the scheduled task is executed, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300</para>
                    /// </summary>
                    [NameInMap("NotificationTime")]
                    [Validation(Required=false)]
                    public int? NotificationTime { get; set; }

                    /// <summary>
                    /// <para>The operation type of the scheduled task. Currently, only disconnection scheduled tasks are supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Shutdown</para>
                    /// </summary>
                    [NameInMap("OperationType")]
                    [Validation(Required=false)]
                    public string OperationType { get; set; }

                    /// <summary>
                    /// <para>The patch ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>KB5082063</para>
                    /// </summary>
                    [NameInMap("PatchId")]
                    [Validation(Required=false)]
                    public string PatchId { get; set; }

                    /// <summary>
                    /// <para>The process whitelist for the intelligent evaluation of no-operation scheduled tasks. If a specified process is running, the no-operation scheduled task is not triggered.</para>
                    /// </summary>
                    [NameInMap("ProcessWhitelist")]
                    [Validation(Required=false)]
                    public List<string> ProcessWhitelist { get; set; }

                    /// <summary>
                    /// <para>The reset type, which determines whether to reset and the scope of cloud disks to be reset.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ResetType")]
                    [Validation(Required=false)]
                    public string ResetType { get; set; }

                    /// <summary>
                    /// <para>The cron expression for starting the execution of the scheduled task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0 0 8 ? * 1-5</para>
                    /// </summary>
                    [NameInMap("StartCronExpression")]
                    [Validation(Required=false)]
                    public string StartCronExpression { get; set; }

                    /// <summary>
                    /// <para>The execution sequence number of the timer.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TimerOrder")]
                    [Validation(Required=false)]
                    public int? TimerOrder { get; set; }

                    /// <summary>
                    /// <para>The time zone used by the scheduled task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Asia/Shanghai</para>
                    /// </summary>
                    [NameInMap("Timezone")]
                    [Validation(Required=false)]
                    public string Timezone { get; set; }

                    /// <summary>
                    /// <para>The trigger configuration type for no-operation scheduled tasks.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Standard</para>
                    /// </summary>
                    [NameInMap("TriggerType")]
                    [Validation(Required=false)]
                    public string TriggerType { get; set; }

                    /// <summary>
                    /// <para>The advance notification time before execution verification, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300</para>
                    /// </summary>
                    [NameInMap("VerificationNotificationTime")]
                    [Validation(Required=false)]
                    public int? VerificationNotificationTime { get; set; }

                    /// <summary>
                    /// <para>The verification wait duration, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>600</para>
                    /// </summary>
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
                /// <para>The trigger configuration type for no-operation scheduled tasks.</para>
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
            /// <para>Used for frontend display. The description of the system scheduled task uses a code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INNER_TIMER_10_MINUTES_HIBERNATE_NO_UPDATE_DESC</para>
            /// </summary>
            [NameInMap("InnerTimerDesc")]
            [Validation(Required=false)]
            public string InnerTimerDesc { get; set; }

            /// <summary>
            /// <para>Used for frontend display. The name mapping of the system scheduled task uses a code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INNER_TIMER_10_MINUTES_HIBERNATE_NO_UPDATE</para>
            /// </summary>
            [NameInMap("InnerTimerName")]
            [Validation(Required=false)]
            public string InnerTimerName { get; set; }

            /// <summary>
            /// <para>Used for system scheduled task checks. The current scheduled task cannot be bound or unbound.</para>
            /// </summary>
            [NameInMap("IsBind")]
            [Validation(Required=false)]
            public bool? IsBind { get; set; }

            /// <summary>
            /// <para>Used for system scheduled task checks. The current scheduled task cannot be modified.</para>
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
            /// <para>The configuration group type.</para>
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
