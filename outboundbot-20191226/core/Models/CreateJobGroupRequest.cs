// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateJobGroupRequest : TeaModel {
        /// <summary>
        /// <para>List of caller numbers. If not specified, all numbers attached to the instance are selected by default.</para>
        /// </summary>
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public List<string> CallingNumber { get; set; }

        /// <summary>
        /// <para>Configuration parameters for flash SMS push, in JSON format, containing third-party flash SMS configuration information.  </para>
        /// <list type="bullet">
        /// <item><description>templateId: Flash SMS Template ID.  </description></item>
        /// <item><description>configId: Flash SMS configuration ID.  </description></item>
        /// <item><description>templateContent: Flash SMS Content.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Obtain the value of templateContent from the partner providing the flash SMS capability.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;templateId&quot;:&quot;104xx&quot;,&quot;configId&quot;:&quot;8037f524-6fxxxxx&quot;, &quot;templateContent&quot;: &quot;【智能外呼机器人】给您来电，敬请接听！&quot;}</para>
        /// </summary>
        [NameInMap("FlashSmsExtras")]
        [Validation(Required=false)]
        public string FlashSmsExtras { get; set; }

        /// <summary>
        /// <para>Instance ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>174952ab-9825-4cc9-a5e2-de82d7fa4cdd</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Task description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>任务描述</para>
        /// </summary>
        [NameInMap("JobGroupDescription")]
        [Validation(Required=false)]
        public string JobGroupDescription { get; set; }

        /// <summary>
        /// <para>Task name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>第一个任务</para>
        /// </summary>
        [NameInMap("JobGroupName")]
        [Validation(Required=false)]
        public string JobGroupName { get; set; }

        /// <summary>
        /// <para>Concurrent guarantee value.  </para>
        /// <list type="bullet">
        /// <item><description>When a job starts, it is guaranteed a minimum of N concurrent executions.  </description></item>
        /// <item><description>The sum of concurrent guarantee values for jobs with the same priority must not exceed the instance concurrency limit.  </description></item>
        /// <item><description>If the concurrent guarantee value is configured as 0, the system intelligently assigns idle concurrency resources.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinConcurrency")]
        [Validation(Required=false)]
        public long? MinConcurrency { get; set; }

        /// <summary>
        /// <para>Job group priority. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Urgent</b>: Urgent job.</description></item>
        /// <item><description><b>Daily</b>: Daily job.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Daily</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// <para>List of caller numbers for redial.</para>
        /// </summary>
        [NameInMap("RecallCallingNumber")]
        [Validation(Required=false)]
        public List<string> RecallCallingNumber { get; set; }

        /// <summary>
        /// <para>Redial policy in JSON format. The default value of parameters in the JSON is false.</para>
        /// <list type="bullet">
        /// <item><description><b>emptyNumberIgnore</b>: Do not make outbound calls to nonexistent numbers.</description></item>
        /// <item><description><b>inArrearsIgnore</b>: Do not make outbound calls for overdue payments.</description></item>
        /// <item><description><b>outOfServiceIgnore</b>: Do not make outbound calls to out-of-service numbers.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;emptyNumberIgnore&quot;:true,&quot;inArrearsIgnore&quot;:true,&quot;outOfServiceIgnore&quot;:true}</para>
        /// </summary>
        [NameInMap("RecallStrategyJson")]
        [Validation(Required=false)]
        public string RecallStrategyJson { get; set; }

        /// <summary>
        /// <para>Optimal ringing duration. Default value is 25.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("RingingDuration")]
        [Validation(Required=false)]
        public long? RingingDuration { get; set; }

        /// <summary>
        /// <para>Deprecated</para>
        /// 
        /// <b>Example:</b>
        /// <para>b9ff4e88-65f9-4eb3-987c-11ba51f3f24d</para>
        /// </summary>
        [NameInMap("ScenarioId")]
        [Validation(Required=false)]
        public string ScenarioId { get; set; }

        /// <summary>
        /// <para>Scenario ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b9ff4e88-65f9-4eb3-987c-11ba51f3f24d</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>Job execution policy.  </para>
        /// <list type="bullet">
        /// <item><description>repeatBy: Recurrence type. Options are Once (no recurrence), Week (weekly recurrence), and Month (monthly recurrence).  </description></item>
        /// <item><description>startTime: Policy start time for time-based execution.  </description></item>
        /// <item><description>endTime: Policy end time for time-based execution.  <remarks>
        /// <para>Execution modes are as follows:  </para>
        /// <list type="bullet">
        /// <item><description>If no start or end time is specified, the job executes immediately.  </description></item>
        /// <item><description>If start and end times are provided, the job executes based on the schedule, and a recurrence type (repeatBy) must be selected.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>workingTime: Allowed outbound calling time segment.  </description></item>
        /// <item><description>maxAttemptsPerDay: Maximum number of call attempts per day for numbers under this job.  </description></item>
        /// <item><description>minAttemptInterval: Minimum time interval between retry calls for a number, in minutes.  </description></item>
        /// <item><description>routingStrategy: Number routing strategy. Options are None (not specified), LocalFirst (local city numbers prioritized), and LocalProvinceFirst (local province numbers prioritized).  </description></item>
        /// <item><description>repeatDays: Execution dates corresponding to the recurrence type. If repeatBy is Week, 0 represents Sunday and 1–6 represent Monday through Saturday. If repeatBy is Month, values 1–31 represent the 1st through the 31st day of the month; months without the specified date skip execution (for example, if the 30th is selected, February skips execution).  </description></item>
        /// <item><description>repeatable: Whether loop task is enabled, true/false.</description></item>
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
