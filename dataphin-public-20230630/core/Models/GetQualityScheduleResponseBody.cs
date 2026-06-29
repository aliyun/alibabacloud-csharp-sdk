// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetQualityScheduleResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The details of the backend exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The details of the schedule object.</para>
        /// </summary>
        [NameInMap("QualityScheduleInfo")]
        [Validation(Required=false)]
        public GetQualityScheduleResponseBodyQualityScheduleInfo QualityScheduleInfo { get; set; }
        public class GetQualityScheduleResponseBodyQualityScheduleInfo : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30 00:00:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The user ID of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30012011</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

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
            /// <para>The ID of the schedule object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Indicates whether the schedule object is referenced by a rule.</para>
            /// </summary>
            [NameInMap("IsRefByRule")]
            [Validation(Required=false)]
            public bool? IsRefByRule { get; set; }

            /// <summary>
            /// <para>The user ID of the last modifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30012011</para>
            /// </summary>
            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30 00:00:00</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The name of the schedule object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The custom partition expression.</para>
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
            /// <item><description>PRE_DAY: yesterday.</description></item>
            /// <item><description>TODAY: today.</description></item>
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
            /// <para>The interval type for timed scheduling. Valid values:</para>
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
            /// <para>The interval values for timed scheduling.</para>
            /// </summary>
            [NameInMap("PeriodScheduleParamList")]
            [Validation(Required=false)]
            public List<string> PeriodScheduleParamList { get; set; }

            /// <summary>
            /// <para>The trigger type for fixed task triggers. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ALL_TASKS_FINISHED: triggered when all tasks are finished.</description></item>
            /// <item><description>ONE_TASKS_FINISHED: triggered when one task is finished.</description></item>
            /// <item><description>PRE_ONE_TASKS_START: triggered when the previous task starts.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ONE_TASKS_FINISHED</para>
            /// </summary>
            [NameInMap("StaticTaskTriggerType")]
            [Validation(Required=false)]
            public string StaticTaskTriggerType { get; set; }

            /// <summary>
            /// <para>The list of trigger nodes for trigger-based scheduling.</para>
            /// </summary>
            [NameInMap("TriggerNodeList")]
            [Validation(Required=false)]
            public List<string> TriggerNodeList { get; set; }

            /// <summary>
            /// <para>The trigger type for trigger-based scheduling. Valid values:</para>
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
            /// <para>The schedule type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PERIOD_SCHEDULE: timed scheduling.</description></item>
            /// <item><description>MANUAL_SCHEDULE: manual trigger.</description></item>
            /// <item><description>CODE_CHECK_TRIGGER: code check trigger.</description></item>
            /// <item><description>STATIC_TASK_TRIGGER: fixed task trigger.</description></item>
            /// <item><description>DEPENDENCY_SCHEDULE: dependency scheduling.</description></item>
            /// </list>
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
            /// <item><description>TASK_REFERRED_PARTITION: partition updated by the task.</description></item>
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
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("WatchId")]
            [Validation(Required=false)]
            public long? WatchId { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
