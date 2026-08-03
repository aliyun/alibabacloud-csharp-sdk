// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateJobGroupRequest : TeaModel {
        /// <summary>
        /// <para>The list of calling numbers. If not specified, all numbers bound to the instance are selected by default.</para>
        /// </summary>
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public List<string> CallingNumber { get; set; }

        /// <summary>
        /// <para>The configuration parameters for flash SMS in JSON format, including third-party flash SMS configuration information.  </para>
        /// <list type="bullet">
        /// <item><description>templateId: the flash SMS template ID.  </description></item>
        /// <item><description>configId: the flash SMS configuration ID.</description></item>
        /// <item><description>templateContent: the flash SMS content.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Obtain the value of templateContent from the corresponding flash SMS capability provider.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;templateId&quot;:&quot;104xx&quot;,&quot;configId&quot;:&quot;8037f524-6fxxxxx&quot;, &quot;templateContent&quot;: &quot;【智能外呼机器人】给您来电，敬请接听！&quot;}</para>
        /// </summary>
        [NameInMap("FlashSmsExtras")]
        [Validation(Required=false)]
        public string FlashSmsExtras { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>174952ab-9825-4cc9-a5e2-de82d7fa4cdd</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The task description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>任务描述</para>
        /// </summary>
        [NameInMap("JobGroupDescription")]
        [Validation(Required=false)]
        public string JobGroupDescription { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>第一个任务</para>
        /// </summary>
        [NameInMap("JobGroupName")]
        [Validation(Required=false)]
        public string JobGroupName { get; set; }

        /// <summary>
        /// <para>The guaranteed concurrency value.  </para>
        /// <list type="bullet">
        /// <item><description>When the task starts, a minimum of N concurrent calls are guaranteed.</description></item>
        /// <item><description>The sum of guaranteed concurrency values for tasks with the same priority cannot exceed the instance concurrency.  </description></item>
        /// <item><description>If the guaranteed concurrency value is set to 0, the system intelligently allocates idle concurrency.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinConcurrency")]
        [Validation(Required=false)]
        public long? MinConcurrency { get; set; }

        /// <summary>
        /// <para>The job group priority. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Urgent</b>: urgent task.</description></item>
        /// <item><description><b>Daily</b>: daily task.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Daily</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// <para>The list of redial calling numbers.</para>
        /// </summary>
        [NameInMap("RecallCallingNumber")]
        [Validation(Required=false)]
        public List<string> RecallCallingNumber { get; set; }

        /// <summary>
        /// <para>The redial strategy in JSON format. Parameter values default to false.</para>
        /// <list type="bullet">
        /// <item><description><b>emptyNumberIgnore</b>: does not call nonexistent numbers.</description></item>
        /// <item><description><b>inArrearsIgnore</b>: does not call numbers with overdue payments.</description></item>
        /// <item><description><b>outOfServiceIgnore</b>: does not call numbers that are out of service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;emptyNumberIgnore&quot;:true,&quot;inArrearsIgnore&quot;:true,&quot;outOfServiceIgnore&quot;:true}</para>
        /// </summary>
        [NameInMap("RecallStrategyJson")]
        [Validation(Required=false)]
        public string RecallStrategyJson { get; set; }

        /// <summary>
        /// <para>The optimal ringing duration. Default value: 25.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("RingingDuration")]
        [Validation(Required=false)]
        public long? RingingDuration { get; set; }

        /// <summary>
        /// <para>Deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b9ff4e88-65f9-4eb3-987c-11ba51f3f24d</para>
        /// </summary>
        [NameInMap("ScenarioId")]
        [Validation(Required=false)]
        public string ScenarioId { get; set; }

        /// <summary>
        /// <para>The scenario ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b9ff4e88-65f9-4eb3-987c-11ba51f3f24d</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>The task execution strategy.  </para>
        /// <list type="bullet">
        /// <item><description>repeatBy: the repeat type. Valid values: Once (no repeat), Week (repeat weekly), and Month (repeat monthly).  </description></item>
        /// <item><description>startTime: the strategy start time for time-based execution.</description></item>
        /// <item><description>endTime: the strategy end time for time-based execution.  <remarks>
        /// <para>The execution mode is determined as follows:</para>
        /// <list type="bullet">
        /// <item><description>If no strategy start time or end time is specified, the task is executed immediately.</description></item>
        /// <item><description>If a strategy time is specified, the task is executed based on the schedule. You must also specify the repeat type repeatBy.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>workingTime: the time window during which outbound calls can be made.</description></item>
        /// <item><description>maxAttemptsPerDay: the maximum number of call attempts per day for each number in the task.</description></item>
        /// <item><description>minAttemptInterval: the retry interval for a number, in minutes.</description></item>
        /// <item><description>routingStrategy: the number strategy. Valid values: None (not specified), LocalFirst (local city numbers preferred), and LocalProvinceFirst (local province numbers preferred).</description></item>
        /// <item><description>repeatDays: the execution days corresponding to the repeat type. If RepeatBy is set to Week, 0 indicates Sunday and 1-6 indicate Monday through Saturday. If RepeatBy is set to Month, 1-31 indicate the 1st through 31st day. The task is not executed in months that do not have the specified day. For example, if the 30th is selected, the task is not executed in February.</description></item>
        /// <item><description>repeatable: specifies whether to enable cyclic tasks. Valid values: true and false.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;maxAttemptsPerDay&quot;:&quot;3&quot;,&quot;minAttemptInterval&quot;:&quot;10&quot;,&quot;routingStrategy&quot;:&quot;LocalProvinceFirst&quot;,&quot;repeatDays&quot;:[&quot;1&quot;,&quot;2&quot;,&quot;3&quot;],&quot;workingTime&quot;:[{&quot;beginTime&quot;:&quot;10:00:00&quot;,&quot;endTime&quot;:&quot;11:00:00&quot;},{&quot;beginTime&quot;:&quot;14:00:00&quot;,&quot;endTime&quot;:&quot;15:00:00&quot;}],&quot;repeatable&quot;:true,&quot;endTime&quot;:1707494400000,&quot;startTime&quot;:1706976000000,&quot;repeatBy&quot;:&quot;Week&quot;}</para>
        /// </summary>
        [NameInMap("StrategyJson")]
        [Validation(Required=false)]
        public string StrategyJson { get; set; }

    }

}
