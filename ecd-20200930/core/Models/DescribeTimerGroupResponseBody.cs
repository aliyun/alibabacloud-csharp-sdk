// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeTimerGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the configuration group.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeTimerGroupResponseBodyData Data { get; set; }
        public class DescribeTimerGroupResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of resources that are bound to the configuration group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("BindCount")]
            [Validation(Required=false)]
            public int? BindCount { get; set; }

            /// <summary>
            /// <para>The number of bound resources.</para>
            /// </summary>
            [NameInMap("BindCountMap")]
            [Validation(Required=false)]
            public Dictionary<string, int?> BindCountMap { get; set; }

            /// <summary>
            /// <para>The scheduled task configuration groups.</para>
            /// </summary>
            [NameInMap("ConfigTimers")]
            [Validation(Required=false)]
            public List<DescribeTimerGroupResponseBodyDataConfigTimers> ConfigTimers { get; set; }
            public class DescribeTimerGroupResponseBodyDataConfigTimers : TeaModel {
                /// <summary>
                /// <para>Indicates whether end users can configure scheduled tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AllowClientSetting")]
                [Validation(Required=false)]
                public bool? AllowClientSetting { get; set; }

                /// <summary>
                /// <para>The CRON expression for the scheduled task.</para>
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
                /// <para>The type of the scheduled disconnection task.</para>
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
                /// <para>The reset operation of the scheduled task.</para>
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
                /// <para>TimerBoot</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>cg-75aazkg2tnqb2*****</para>
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
            /// <para>The service type of the configuration group.</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>CLOUD_DESKTOP: the cloud computer service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CLOUD_DESKTOP</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The state of the configuration group.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AVAILABLE: The configuration group is available.</description></item>
            /// <item><description>UNAVAILABLE: The configuration group is deleted.</description></item>
            /// <item><description>DELETING: The configuration group is being deleted.</description></item>
            /// <item><description>UPDATING: The configuration group is being modified.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the configuration group.</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>Timer: the scheduled task type.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Timer</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
