// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpsertQualityScheduleRequest : TeaModel {
        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The update instruction.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpsertCommand")]
        [Validation(Required=false)]
        public UpsertQualityScheduleRequestUpsertCommand UpsertCommand { get; set; }
        public class UpsertQualityScheduleRequestUpsertCommand : TeaModel {
            /// <summary>
            /// <para>The cron expression for timed scheduling.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description><list type="bullet">
            /// <item><description>1/* * * *</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// <para>The ID of the schedule resource. If specified, the operation updates the existing resource. If not specified, the operation creates a new resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the schedule resource.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The partition expression for custom expressions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds=${yyyyMMdd}</para>
            /// </summary>
            [NameInMap("PartitionExpression")]
            [Validation(Required=false)]
            public string PartitionExpression { get; set; }

            /// <summary>
            /// <para>The partition type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>EVERY_DAY: every day.</description></item>
            /// <item><description>PRE_DAY: previous day.</description></item>
            /// <item><description>TODAY: current day.</description></item>
            /// <item><description>FIRST_DAY_OF_WEEK: first day of the week (Sunday).</description></item>
            /// <item><description>CUSTOM: custom.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CUSTOM</para>
            /// </summary>
            [NameInMap("PartitionType")]
            [Validation(Required=false)]
            public string PartitionType { get; set; }

            /// <summary>
            /// <para>The scheduling interval type for timed scheduling. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DAILY: day.</description></item>
            /// <item><description>WEEKLY: week.</description></item>
            /// <item><description>MONTHLY: month.</description></item>
            /// <item><description>HOURLY: hour.</description></item>
            /// <item><description>MINUTELY: minute.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DAILY</para>
            /// </summary>
            [NameInMap("PeriodScheduleIntervalType")]
            [Validation(Required=false)]
            public string PeriodScheduleIntervalType { get; set; }

            /// <summary>
            /// <para>The scheduling interval values for timed scheduling.</para>
            /// </summary>
            [NameInMap("PeriodScheduleParamList")]
            [Validation(Required=false)]
            public List<string> PeriodScheduleParamList { get; set; }

            /// <summary>
            /// <para>The trigger method for fixed task triggers. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ALL_TASKS_FINISHED</description></item>
            /// <item><description>ONE_TASKS_FINISHED</description></item>
            /// <item><description>PRE_ONE_TASKS_START.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ONE_TASKS_FINISHED</para>
            /// </summary>
            [NameInMap("StaticTaskTriggerType")]
            [Validation(Required=false)]
            public string StaticTaskTriggerType { get; set; }

            /// <summary>
            /// <para>The checklist of trigger nodes for trigger scheduling.</para>
            /// </summary>
            [NameInMap("TriggerNodeList")]
            [Validation(Required=false)]
            public List<string> TriggerNodeList { get; set; }

            /// <summary>
            /// <para>The trigger method for trigger scheduling. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>STATIC_TASK_TRIGGER: fixed task trigger.</description></item>
            /// <item><description>CODE_CHECK_TRIGGER: code check trigger.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>STATIC_TASK_TRIGGER</para>
            /// </summary>
            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

            /// <summary>
            /// <para>The scheduling type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PERIOD_SCHEDULE: timed scheduling.</description></item>
            /// <item><description>MANUAL_SCHEDULE: manual trigger.</description></item>
            /// <item><description>CODE_CHECK_TRIGGER: code check trigger.</description></item>
            /// <item><description>STATIC_TASK_TRIGGER: fixed task trigger.</description></item>
            /// <item><description>DEPENDENCY_SCHEDULE: dependency scheduling.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PERIOD_SCHEDULE</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The validation scope. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TASK_REFERRED_PARTITION: task update partition.</description></item>
            /// <item><description>USER_DEFINED_PARTITION: custom partition.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TASK_REFERRED_PARTITION</para>
            /// </summary>
            [NameInMap("ValidatePartitionType")]
            [Validation(Required=false)]
            public string ValidatePartitionType { get; set; }

            /// <summary>
            /// <para>The ID of the monitored object.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("WatchId")]
            [Validation(Required=false)]
            public long? WatchId { get; set; }

        }

    }

}
