// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyJobGroupRequest : TeaModel {
        /// <summary>
        /// <para>The calling numbers for the job group.</para>
        /// </summary>
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public List<string> CallingNumber { get; set; }

        /// <summary>
        /// <para>The description of the job group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>修改后的作业组</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The flash SMS configuration, specified as a JSON string. This may include settings for third-party flash SMS services.</para>
        /// <para><c>templateId</c>: The flash SMS template ID.<br>
        /// <c>configId</c>: The flash SMS configuration ID.<br></para>
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
        /// <para>The job group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3edc0260-6f7c-4de4-8535-09372240618b</para>
        /// </summary>
        [NameInMap("JobGroupId")]
        [Validation(Required=false)]
        public string JobGroupId { get; set; }

        /// <summary>
        /// <para>The status of the job group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Draft</c>: The job group is in a draft state.</para>
        /// </description></item>
        /// <item><description><para><c>Paused</c>: The job group is paused.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Draft</para>
        /// </summary>
        [NameInMap("JobGroupStatus")]
        [Validation(Required=false)]
        public string JobGroupStatus { get; set; }

        /// <summary>
        /// <para>The guaranteed minimum number of concurrent calls for the job group. The sum of this value for all job groups with the same priority cannot exceed the instance\&quot;s total concurrency. If you set this parameter to <c>0</c>, the system dynamically allocates available lines from a shared pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinConcurrency")]
        [Validation(Required=false)]
        public long? MinConcurrency { get; set; }

        /// <summary>
        /// <para>The name of the job group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>修改后的作业组</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The priority of the job group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Urgent</b>: An urgent job.</para>
        /// </description></item>
        /// <item><description><para><b>Daily</b>: A routine job.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Daily</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// <para>The recall calling numbers.</para>
        /// </summary>
        [NameInMap("RecallCallingNumber")]
        [Validation(Required=false)]
        public List<string> RecallCallingNumber { get; set; }

        /// <summary>
        /// <para>A JSON string that defines the recall strategy.</para>
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
        /// <para>The scenario ID. (This is a legacy parameter. Use <c>ScriptId</c> instead.)</para>
        /// <remarks>
        /// <para>You can pass any value for this legacy parameter, but we recommend using the same value as <c>ScriptId</c> for consistency.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>c6a668d1-3145-4048-9101-cb3678bb8884</para>
        /// </summary>
        [NameInMap("ScenarioId")]
        [Validation(Required=false)]
        public string ScenarioId { get; set; }

        /// <summary>
        /// <para>The ID of the script for the scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5a3940ce-a12f-4222-9f0f-605a9b89ea7c</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>A JSON string that defines the execution strategy for the job group.</para>
        /// <list type="bullet">
        /// <item><description><para><c>id</c>: The ID of the job group strategy. You can obtain this ID from the <c>StrategyId</c> parameter returned by the <c>DescribeJobGroup</c> operation.</para>
        /// </description></item>
        /// <item><description><para><c>repeatBy</c>: The frequency of the job. Valid values: <c>Once</c> (does not repeat), <c>Day</c> (repeats daily), <c>Week</c> (repeats weekly), and <c>Month</c> (repeats monthly).</para>
        /// </description></item>
        /// <item><description><para><c>startTime</c>: The start time of the strategy.</para>
        /// </description></item>
        /// <item><description><para><c>endTime</c>: The end time of the strategy.</para>
        /// </description></item>
        /// <item><description><para><c>workingTime</c>: The time windows for making outbound calls.</para>
        /// </description></item>
        /// <item><description><para><c>maxAttemptsPerDay</c>: The maximum number of call attempts per day for a number in this job group.</para>
        /// </description></item>
        /// <item><description><para><c>minAttemptInterval</c>: The minimum interval, in minutes, between call retries to the same number.</para>
        /// </description></item>
        /// <item><description><para><c>routingStrategy</c>: The number routing strategy. Valid values: <c>None</c> (not specified), <c>LocalFirst</c> (prioritizes numbers in the same city), and <c>LocalProvinceFirst</c> (prioritizes numbers in the same province).</para>
        /// </description></item>
        /// <item><description><para><c>repeatDays</c>: The specific days to run the job, based on the <c>repeatBy</c> value. If <c>repeatBy</c> is <c>Week</c>, <c>0</c> indicates Sunday, and <c>1</c> through <c>6</c> indicate Monday through Saturday. If <c>repeatBy</c> is <c>Month</c>, valid values are <c>1</c> through <c>31</c>. If a month does not have the specified day (for example, day 30 in February), the job does not run on that day.</para>
        /// </description></item>
        /// <item><description><para><c>repeatable</c>: Whether the job is recurring. Valid values are <c>true</c> and <c>false</c>.</para>
        /// </description></item>
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
