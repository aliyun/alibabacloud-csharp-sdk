// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyTimerGroupRequest : TeaModel {
        /// <summary>
        /// <para>The configuration information of scheduled tasks.</para>
        /// </summary>
        [NameInMap("ConfigTimers")]
        [Validation(Required=false)]
        public List<ModifyTimerGroupRequestConfigTimers> ConfigTimers { get; set; }
        public class ModifyTimerGroupRequestConfigTimers : TeaModel {
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
            /// <para>You must specify the time in UTC. For example, to specify 00:00:00 every day in UTC+8 (Beijing time), set this parameter to 0 0 16 ? * 1,2,3,4,5,6,7.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0 0 16 ? * 1,2,3,4,5,6,7</para>
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// <para>Specifies whether to forcibly execute the scheduled task. A value of true indicates that the system ignores the desktop and connection status checks and forcibly executes the scheduled task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
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
            /// <para>The operation type of the scheduled task. Currently, only disconnect scheduled tasks are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Shutdown</para>
            /// </summary>
            [NameInMap("OperationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            /// <summary>
            /// <para>The process whitelist for intelligent judgment of no-operation scheduled tasks. If a specified process is running, the no-operation scheduled task is not executed.</para>
            /// </summary>
            [NameInMap("ProcessWhitelist")]
            [Validation(Required=false)]
            public List<string> ProcessWhitelist { get; set; }

            /// <summary>
            /// <para>The reset type. This parameter specifies whether to reset the desktop and the scope of cloud disks to be reset.</para>
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
            public List<ModifyTimerGroupRequestConfigTimersSegmentTimers> SegmentTimers { get; set; }
            public class ModifyTimerGroupRequestConfigTimersSegmentTimers : TeaModel {
                /// <summary>
                /// <para>The appointment timer for scheduled tasks. After you specify this parameter, the scheduled task is executed at the specified time point.</para>
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
                /// <para>Specifies whether to forcibly execute the scheduled task. A value of true indicates that the system ignores the desktop and connection status checks and forcibly executes the scheduled task.</para>
                /// </summary>
                [NameInMap("Enforce")]
                [Validation(Required=false)]
                public bool? Enforce { get; set; }

                /// <summary>
                /// <para>The ID of the image.</para>
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
                /// <para>The duration of inactivity before the screen is locked for the no-operation lock screen feature. Unit: minutes. Only AD cloud desktops are supported.</para>
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
                /// <para>The operation type of the scheduled task. Currently, only disconnect scheduled tasks are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Shutdown</para>
                /// </summary>
                [NameInMap("OperationType")]
                [Validation(Required=false)]
                public string OperationType { get; set; }

                /// <summary>
                /// <para>The process whitelist for intelligent judgment of no-operation scheduled tasks. If a specified process is running, the no-operation scheduled task is not executed.</para>
                /// </summary>
                [NameInMap("ProcessWhitelist")]
                [Validation(Required=false)]
                public List<string> ProcessWhitelist { get; set; }

                /// <summary>
                /// <para>The reset type. This parameter specifies whether to reset the desktop and the scope of cloud disks to be reset.</para>
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
        /// <para>The ID of the configuration group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg-i1ruuudp92qpj****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

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
        /// <para>The region ID. This feature is not region-specific. Set this parameter to <c>cn-shanghai</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
