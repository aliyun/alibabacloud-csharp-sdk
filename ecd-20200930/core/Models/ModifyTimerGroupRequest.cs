// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyTimerGroupRequest : TeaModel {
        /// <summary>
        /// <para>The configuration groups.</para>
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
            /// <para>The CRON expression for the scheduled task.</para>
            /// <remarks>
            /// <para> The time must be in UTC. For example, for 24:00 (UTC+8), you must set the value to 0 0 16 ? \* 1,2,3,4,5,6,7.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0 0 16 ? * 1,2,3,4,5,6,7</para>
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// <para>Specifies whether to forcibly execute the scheduled task. A value of true specifies the scheduled task will run forcefully, ignoring the cloud computer and connection status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
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
            /// <para>The process whitelist. If whitelisted processes are running, the scheduled task upon inactivity does not take effect.</para>
            /// </summary>
            [NameInMap("ProcessWhitelist")]
            [Validation(Required=false)]
            public List<string> ProcessWhitelist { get; set; }

            /// <summary>
            /// <para>The reset operation.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RESET_TYPE_SYSTEM: resets the system disk.</description></item>
            /// <item><description>RESET_TYPE_USER_DISK: resets the data disk.</description></item>
            /// <item><description>RESET_TYPE_BOTH: resets the system disk and data disk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RESET_TYPE_SYSTEM</para>
            /// </summary>
            [NameInMap("ResetType")]
            [Validation(Required=false)]
            public string ResetType { get; set; }

            /// <summary>
            /// <para>The type of the scheduled task.</para>
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
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the region. Set the value to <c>cn-shanghai</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
