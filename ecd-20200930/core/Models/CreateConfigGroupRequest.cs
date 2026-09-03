// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateConfigGroupRequest : TeaModel {
        /// <summary>
        /// <para>The configuration information of scheduled tasks. This parameter is a list.</para>
        /// </summary>
        [NameInMap("ConfigTimers")]
        [Validation(Required=false)]
        public List<CreateConfigGroupRequestConfigTimers> ConfigTimers { get; set; }
        public class CreateConfigGroupRequestConfigTimers : TeaModel {
            /// <summary>
            /// <para>Specifies whether to allow end users to configure scheduled tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AllowClientSetting")]
            [Validation(Required=false)]
            public bool? AllowClientSetting { get; set; }

            /// <summary>
            /// <para>The cron expression of the scheduled task.</para>
            /// <remarks>
            /// <para>Notice: Specify the time in UTC. For example, to schedule a task at 00:00 (UTC+8) every day, use 0 0 16 ? * 1,2,3,4,5,6,7.</notice></para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0 0 16 ? * 1,2,3,4,5,6,7</para>
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// <para>Specifies whether to forcefully execute the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enforce")]
            [Validation(Required=false)]
            public bool? Enforce { get; set; }

            /// <summary>
            /// <para>The time interval. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// <para>The advance notification time before the scheduled task is executed. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("NotificationTime")]
            [Validation(Required=false)]
            public int? NotificationTime { get; set; }

            /// <summary>
            /// <para>The operation type of the scheduled task. Currently, only disconnect scheduled tasks support this parameter.</para>
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
            /// <para>The reset type of the cloud desktop.</para>
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
            public List<CreateConfigGroupRequestConfigTimersSegmentTimers> SegmentTimers { get; set; }
            public class CreateConfigGroupRequestConfigTimersSegmentTimers : TeaModel {
                /// <summary>
                /// <para>The appointment timer used for executing scheduled tasks at specified time points.</para>
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
                /// <para>The cron expression for the end of the scheduled task execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0 18 ? * 1-5</para>
                /// </summary>
                [NameInMap("EndCronExpression")]
                [Validation(Required=false)]
                public string EndCronExpression { get; set; }

                /// <summary>
                /// <para>Specifies whether to forcefully execute the task. If set to true, the scheduled task is forcefully executed regardless of the desktop and connection status.</para>
                /// </summary>
                [NameInMap("Enforce")]
                [Validation(Required=false)]
                public bool? Enforce { get; set; }

                /// <summary>
                /// <para>The image ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m-4zfb6zj728hhr****</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The time interval. Unit: minutes.</para>
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
                /// <para>The duration of inactivity before the screen is locked, used by the no-operation lock screen feature. Unit: minutes. Only AD cloud desktops are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("LockScreenTime")]
                [Validation(Required=false)]
                public int? LockScreenTime { get; set; }

                /// <summary>
                /// <para>The advance notification time before the scheduled task is executed. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("NotificationTime")]
                [Validation(Required=false)]
                public int? NotificationTime { get; set; }

                /// <summary>
                /// <para>The operation type of the scheduled task. Currently, only disconnect scheduled tasks support this parameter.</para>
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
                /// <para>The process whitelist for intelligent detection of no-operation scheduled tasks. If a specified process is running, the no-operation scheduled task is not triggered.</para>
                /// </summary>
                [NameInMap("ProcessWhitelist")]
                [Validation(Required=false)]
                public List<string> ProcessWhitelist { get; set; }

                /// <summary>
                /// <para>The reset type, which determines whether to reset and the scope of cloud disks to reset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ResetType")]
                [Validation(Required=false)]
                public string ResetType { get; set; }

                /// <summary>
                /// <para>The cron expression for the start of the scheduled task execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0 8 ? * 1-5</para>
                /// </summary>
                [NameInMap("StartCronExpression")]
                [Validation(Required=false)]
                public string StartCronExpression { get; set; }

                /// <summary>
                /// <para>The execution order number of the timer.</para>
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
                /// <para>The advance notification time before verification is executed. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("VerificationNotificationTime")]
                [Validation(Required=false)]
                public int? VerificationNotificationTime { get; set; }

                /// <summary>
                /// <para>The verification wait duration. Unit: seconds.</para>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TIMER_BOOT</para>
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
        /// <para>Description of the scheduled task</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the configuration group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ScheduledTaskGroup</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The product type used by the configuration group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CLOUD_DESKTOP</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The region ID. This feature is not region-specific. Set this parameter to <c>cn-shanghai</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The type of the configuration group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Timer</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
