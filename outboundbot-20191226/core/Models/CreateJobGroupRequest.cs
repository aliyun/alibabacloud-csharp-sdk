// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateJobGroupRequest : TeaModel {
        /// <summary>
        /// <para>The list of caller numbers. If not specified, all numbers bound to the instance are selected by default.</para>
        /// </summary>
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public List<string> CallingNumber { get; set; }

        /// <summary>
        /// <para>The configuration parameters for flash SMS push in JSON format, including the configuration information of third-party flash SMS.  </para>
        /// <list type="bullet">
        /// <item><description>templateId: the flash SMS template ID.  </description></item>
        /// <item><description>configId: the flash SMS configuration ID.</description></item>
        /// <item><description>templateContent: the flash SMS content.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The value of templateContent must be obtained from the corresponding flash SMS capability partner.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;templateId&quot;:&quot;104xx&quot;,&quot;configId&quot;:&quot;8037f524-6fxxxxx&quot;, &quot;templateContent&quot;: &quot;[Outbound Robot] is calling you. Please answer!&quot;}</para>
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
        /// <para>The description of the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Job description</para>
        /// </summary>
        [NameInMap("JobGroupDescription")]
        [Validation(Required=false)]
        public string JobGroupDescription { get; set; }

        /// <summary>
        /// <para>The name of the job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>First job</para>
        /// </summary>
        [NameInMap("JobGroupName")]
        [Validation(Required=false)]
        public string JobGroupName { get; set; }

        /// <summary>
        /// <para>The guaranteed concurrency.  </para>
        /// <list type="bullet">
        /// <item><description>When the job starts, a minimum of N concurrent calls are guaranteed.</description></item>
        /// <item><description>The sum of guaranteed concurrency for jobs of the same priority cannot exceed the instance concurrency.  </description></item>
        /// <item><description>If the guaranteed concurrency is set to 0, the system intelligently allocates idle concurrency.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinConcurrency")]
        [Validation(Required=false)]
        public long? MinConcurrency { get; set; }

        /// <summary>
        /// <para>The priority of the job group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Urgent</b>: urgent job.</description></item>
        /// <item><description><b>Daily</b>: daily job.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Daily</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// <para>The list of caller numbers for redialing.</para>
        /// </summary>
        [NameInMap("RecallCallingNumber")]
        [Validation(Required=false)]
        public List<string> RecallCallingNumber { get; set; }

        /// <summary>
        /// <para>The redial strategy in JSON format. The default value of the parameters in the JSON object is false.</para>
        /// <list type="bullet">
        /// <item><description><b>emptyNumberIgnore</b>: specifies whether to skip nonexistent numbers.</description></item>
        /// <item><description><b>inArrearsIgnore</b>: specifies whether to skip numbers with overdue payments.</description></item>
        /// <item><description><b>outOfServiceIgnore</b>: specifies whether to skip suspended numbers.</description></item>
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
        /// <para><b>[Deprecated]</b></para>
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
        /// <para>The execution strategy of the job.  </para>
        /// <list type="bullet">
        /// <item><description>repeatBy: the repetition type. Valid values: Once (no repetition), Week (weekly repetition), and Month (monthly repetition).  </description></item>
        /// <item><description>startTime: the start time of the time-based strategy.</description></item>
        /// <item><description>endTime: the end time of the time-based strategy.  <remarks>
        /// <para>Execution methods:</para>
        /// <list type="bullet">
        /// <item><description>If the start and end times of the strategy are not specified, the execution method is immediate execution.</description></item>
        /// <item><description>If the strategy time is specified, the job is executed based on the time, and the repetition type repeatBy must be selected.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>workingTime: the time period during which outbound calls can be made.</description></item>
        /// <item><description>maxAttemptsPerDay: the maximum number of call attempts per day for numbers under this job.</description></item>
        /// <item><description>minAttemptInterval: the retry interval for numbers, in minutes.</description></item>
        /// <item><description>routingStrategy: the number strategy. Valid values: None (not specified), LocalFirst (local numbers first), and LocalProvinceFirst (local province numbers first).</description></item>
        /// <item><description>repeatDays: the execution days corresponding to the repetition type. If the repetition type RepeatBy is Week, 0 represents Sunday, and 1 to 6 represent Monday to Saturday. If the repetition cycle RepeatBy is Month, 1 to 31 represent the 1st to the 31st day. Months without the specified date are not executed. For example, if the 30th is selected, the job is not executed in February.</description></item>
        /// <item><description>repeatable: specifies whether to enable cyclic jobs. Valid values: true and false.</description></item>
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
