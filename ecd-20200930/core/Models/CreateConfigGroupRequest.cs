// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateConfigGroupRequest : TeaModel {
        /// <summary>
        /// <para>The scheduled task groups.</para>
        /// </summary>
        [NameInMap("ConfigTimers")]
        [Validation(Required=false)]
        public List<CreateConfigGroupRequestConfigTimers> ConfigTimers { get; set; }
        public class CreateConfigGroupRequestConfigTimers : TeaModel {
            /// <summary>
            /// <para>Specifies whether to allow end users to configure the scheduled task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AllowClientSetting")]
            [Validation(Required=false)]
            public bool? AllowClientSetting { get; set; }

            /// <summary>
            /// <para>The cron expression specified in the scheduled task.</para>
            /// <remarks>
            /// <para> The time must be in UTC. For example, for 24:00 (UTC+8), you must set the value to 0 0 16 ? \* 1,2,3,4,5,6,7</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0 0 16 ? * 1,2,3,4,5,6,7</para>
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// <para>Specifies whether to forcefully execute the scheduled task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enforce")]
            [Validation(Required=false)]
            public bool? Enforce { get; set; }

            /// <summary>
            /// <para>The interval at which the scheduled task is executed. Unit: minutes.</para>
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
            /// <para>The type of the scheduled operation. If you set TimerType to NoConnect, you can specify this parameter.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Hibernate: scheduled hibernation.</description></item>
            /// <item><description>Shutdown: scheduled shutdown.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Shutdown</para>
            /// </summary>
            [NameInMap("OperationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            /// <summary>
            /// <para>The process whitelist. If whitelisted processes are running, the scheduled task does not take effect.</para>
            /// </summary>
            [NameInMap("ProcessWhitelist")]
            [Validation(Required=false)]
            public List<string> ProcessWhitelist { get; set; }

            /// <summary>
            /// <para>The reset option.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RESET_TYPE_SYSTEM: resets only the system disk.</description></item>
            /// <item><description>RESET_TYPE_USER_DISK: resets only the data disk.</description></item>
            /// <item><description>RESET_TYPE_BOTH: resets the system and data disks.</description></item>
            /// </list>
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
                [NameInMap("EndCronExpression")]
                [Validation(Required=false)]
                public string EndCronExpression { get; set; }

                [NameInMap("Enforce")]
                [Validation(Required=false)]
                public bool? Enforce { get; set; }

                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                [NameInMap("NotificationTime")]
                [Validation(Required=false)]
                public int? NotificationTime { get; set; }

                [NameInMap("OperationType")]
                [Validation(Required=false)]
                public string OperationType { get; set; }

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

            }

            /// <summary>
            /// <para>The scheduled task type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NoOperationDisconnect: scheduled disconnection upon inactivity.</description></item>
            /// <item><description>NoConnect: scheduled disconnection upon specified operation (OperationType).</description></item>
            /// <item><description>TimerBoot: scheduled start.</description></item>
            /// <item><description>TimerReset: scheduled reset.</description></item>
            /// <item><description>NoOperationShutdown: scheduled shutdown upon inactivity.</description></item>
            /// <item><description>NoOperationHibernate: scheduled hibernation upon inactivity.</description></item>
            /// <item><description>TimerShutdown: scheduled shutdown.</description></item>
            /// <item><description>NoOperationReboot: scheduled restart upon inactivity.</description></item>
            /// <item><description>TimerReboot: scheduled restart.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TIMER_BOOT</para>
            /// </summary>
            [NameInMap("TimerType")]
            [Validation(Required=false)]
            public string TimerType { get; set; }

            /// <summary>
            /// <para>The method to trigger the scheduled task upon inactivity.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Advanced: intelligent detection.</description></item>
            /// <item><description>Standard: standard detection.</description></item>
            /// </list>
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
        /// <para>ScheduledTask</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the configuration group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ScheduledTask</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The service type of the configuration group.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>CLOUD_DESKTOP: the cloud computer service.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CLOUD_DESKTOP</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The ID of the region. Set the value to <c>cn-shanghai</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The group type.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>Timer: a scheduled task group.</description></item>
        /// </list>
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
