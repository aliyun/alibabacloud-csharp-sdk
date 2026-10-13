// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyJobGroupRequest : TeaModel {
        /// <summary>
        /// <para>The caller number.</para>
        /// </summary>
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public List<string> CallingNumber { get; set; }

        /// <summary>
        /// <para>The job description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Modified job group</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The configuration parameters for flash message push in JSON format, including the configuration information of third-party flash messages.</para>
        /// <para>templateId: the flash message template ID.<br>configId: the flash message configuration ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;templateId&quot;:&quot;10471&quot;,&quot;configId&quot;:&quot;8037f524-6ff2-4dbe-bb28-f59234ea7a64&quot;}</para>
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
        /// <para>The job ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3edc0260-6f7c-4de4-8535-09372240618b</para>
        /// </summary>
        [NameInMap("JobGroupId")]
        [Validation(Required=false)]
        public string JobGroupId { get; set; }

        /// <summary>
        /// <para>The job status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Draft: draft.</description></item>
        /// <item><description>Paused: paused.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Draft</para>
        /// </summary>
        [NameInMap("JobGroupStatus")]
        [Validation(Required=false)]
        public string JobGroupStatus { get; set; }

        /// <summary>
        /// <para>The guaranteed concurrency.
        /// When a job starts, a minimum of N concurrent calls are guaranteed.
        /// The sum of guaranteed concurrency values for jobs of the same priority cannot exceed the instance concurrency.
        /// If the guaranteed concurrency is set to 0, the system intelligently allocates idle concurrency.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinConcurrency")]
        [Validation(Required=false)]
        public long? MinConcurrency { get; set; }

        /// <summary>
        /// <para>The job name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Modified job group</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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
        /// <para>The JSON string of the recall strategy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;emptyNumberIgnore&quot;:false,&quot;inArrearsIgnore&quot;:false,&quot;outOfServiceIgnore&quot;:false}</para>
        /// </summary>
        [NameInMap("RecallStrategyJson")]
        [Validation(Required=false)]
        public string RecallStrategyJson { get; set; }

        /// <summary>
        /// <para>The optimal ringing duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("RingingDuration")]
        [Validation(Required=false)]
        public long? RingingDuration { get; set; }

        /// <summary>
        /// <para>The scenario ID. This is a legacy parameter. Use ScriptId instead.</para>
        /// <remarks>
        /// <para>This parameter is a legacy parameter. You can pass any value. Keep it consistent with the ScriptId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>c6a668d1-3145-4048-9101-cb3678bb8884</para>
        /// </summary>
        [NameInMap("ScenarioId")]
        [Validation(Required=false)]
        public string ScenarioId { get; set; }

        /// <summary>
        /// <para>The script ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5a3940ce-a12f-4222-9f0f-605a9b89ea7c</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>The job execution strategy.</para>
        /// <list type="bullet">
        /// <item><description>id: the job group strategy ID. You can obtain it from the StrategyId response parameter of the DescribeJobGroup operation.</description></item>
        /// <item><description>repeatBy: the recurrence type. Valid values: Once (no recurrence), Day (daily), Week (weekly), and Month (monthly).</description></item>
        /// <item><description>startTime: the start time of the strategy.</description></item>
        /// <item><description>endTime: the end time of the strategy.</description></item>
        /// <item><description>workingTime: the time period during which outbound calls are allowed.</description></item>
        /// <item><description>maxAttemptsPerDay: the maximum number of call attempts per day for a phone number under this job.</description></item>
        /// <item><description>minAttemptInterval: the retry interval for a phone number, in minutes.</description></item>
        /// <item><description>routingStrategy: the phone number strategy. Valid values: None (not specified), LocalFirst (local numbers first), and LocalProvinceFirst (local province numbers first).</description></item>
        /// <item><description>repeatDays: the execution days corresponding to the recurrence type. If RepeatBy is Week, 0 indicates Sunday, and 1 to 6 indicate Monday to Saturday. If RepeatBy is Month, 1 to 31 indicate the 1st to the 31st day of the month. If a month does not have the specified day, the job is not executed in that month. For example, if the 30th is selected, the job is not executed in February.</description></item>
        /// <item><description>repeatable: specifies whether to enable recurring jobs. Valid values: true and false.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;maxAttemptsPerDay&quot;:&quot;3&quot;,&quot;minAttemptInterval&quot;:&quot;10&quot;,&quot;routingStrategy&quot;:&quot;LocalProvinceFirst&quot;,&quot;repeatDays&quot;:[&quot;1&quot;,&quot;2&quot;,&quot;3&quot;],&quot;workingTime&quot;:[{&quot;beginTime&quot;:&quot;10:00:00&quot;,&quot;endTime&quot;:&quot;11:00:00&quot;},&quot;id&quot;:&quot;cdca9ed7-6470-42d0-afb3-a41e08b41383&quot;,{&quot;beginTime&quot;:&quot;14:00:00&quot;,&quot;endTime&quot;:&quot;15:00:00&quot;}],&quot;repeatable&quot;:true,&quot;endTime&quot;:1707494400000,&quot;startTime&quot;:1706976000000,&quot;repeatBy&quot;:&quot;Week&quot;}</para>
        /// </summary>
        [NameInMap("StrategyJson")]
        [Validation(Required=false)]
        public string StrategyJson { get; set; }

    }

}
