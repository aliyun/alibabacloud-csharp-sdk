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
        /// <para>To obtain the value of templateContent, contact the partner that provides the corresponding flash SMS capability.</para>
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
        /// <para>The job description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Job description</para>
        /// </summary>
        [NameInMap("JobGroupDescription")]
        [Validation(Required=false)]
        public string JobGroupDescription { get; set; }

        /// <summary>
        /// <para>The job name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>First job</para>
        /// </summary>
        [NameInMap("JobGroupName")]
        [Validation(Required=false)]
        public string JobGroupName { get; set; }

        /// <summary>
        /// <para>The guaranteed concurrency value.  </para>
        /// <list type="bullet">
        /// <item><description>When the job starts, a minimum of N concurrent calls are guaranteed.</description></item>
        /// <item><description>The sum of guaranteed concurrency values for jobs of the same priority cannot exceed the instance concurrency.  </description></item>
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
        /// <para>The list of caller numbers for recall.</para>
        /// </summary>
        [NameInMap("RecallCallingNumber")]
        [Validation(Required=false)]
        public List<string> RecallCallingNumber { get; set; }

        /// <summary>
        /// <para>The recall strategy in JSON format. The default value of parameters in the JSON string is false.</para>
        /// <list type="bullet">
        /// <item><description><b>emptyNumberIgnore</b>: does not call nonexistent numbers.</description></item>
        /// <item><description><b>inArrearsIgnore</b>: does not call numbers with overdue payments.</description></item>
        /// <item><description><b>outOfServiceIgnore</b>: does not call suspended numbers.</description></item>
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
        /// <para>The script ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b9ff4e88-65f9-4eb3-987c-11ba51f3f24d</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>The job execution strategy.  </para>
        /// <list type="bullet">
        /// <item><description>repeatBy: the recurrence type. Valid values: Once (no recurrence), Week (weekly recurrence), and Month (monthly recurrence).  </description></item>
        /// <item><description>startTime: the start time of the strategy when executed by time.</description></item>
        /// <item><description>endTime: the end time of the strategy when executed by time.  <remarks>
        /// <para>Execution methods are divided into:</para>
        /// <list type="bullet">
        /// <item><description>If the start and end times are not specified, the job is executed immediately.</description></item>
        /// <item><description>If the start and end times are specified, the job is executed by time, and the repeatBy recurrence type must be selected.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>workingTime: the time period during which outbound calls can be made.</description></item>
        /// <item><description>maxAttemptsPerDay: the maximum number of call attempts per day for numbers in this job.</description></item>
        /// <item><description>minAttemptInterval: the retry interval for calling a number, in minutes.</description></item>
        /// <item><description>routingStrategy: the number routing strategy. Valid values: None (not specified), LocalFirst (local city numbers first), and LocalProvinceFirst (local province numbers first).</description></item>
        /// <item><description>repeatDays: the execution days corresponding to the recurrence type. If the repeatBy recurrence type is Week, 0 indicates Sunday, and 1 to 6 indicate Monday to Saturday. If the repeatBy recurrence type is Month, 1 to 31 indicate the 1st to the 31st day. Months without the specified date are not executed. For example, if the 30th is selected, the job is not executed in February.</description></item>
        /// <item><description>repeatable: specifies whether to enable recurring jobs. Valid values: true and false.</description></item>
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
