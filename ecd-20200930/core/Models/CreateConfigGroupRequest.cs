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
            /// <para>Specifies whether to allow end users to configure scheduled tasks on their own.</para>
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
            /// <para>Notice: Specify the time in UTC. For example, to specify 00:00 (UTC+8) every day, use 0 0 16 ? * 1,2,3,4,5,6,7.</notice></para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0 0 16 ? * 1,2,3,4,5,6,7</para>
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// <para>Specifies whether to forcibly execute the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
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
            /// <para>The reset type of the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RESET_TYPE_SYSTEM</para>
            /// </summary>
            [NameInMap("ResetType")]
            [Validation(Required=false)]
            public string ResetType { get; set; }

            [NameInMap("SegmentTimers")]
            [Validation(Required=false)]
            public List<CreateConfigGroupRequestConfigTimersSegmentTimers> SegmentTimers { get; set; }
            public class CreateConfigGroupRequestConfigTimersSegmentTimers : TeaModel {
                /// <summary>
                /// <para>The specified time point for executing a scheduled task. After this parameter is specified, the scheduled task is executed at the specified time point.</para>
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
                /// <para>The image ID to change to. This parameter is used for image change scheduled tasks.</para>
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
                /// <para>The lock screen time point for the no-operation lock screen feature. This parameter cannot be used for non-AD desktops.</para>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TIMER_BOOT</para>
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
        /// <para>Scheduled task description content</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the configuration group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Scheduled task group</para>
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
