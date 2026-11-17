// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class CreateCampaignShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The call execution order. Default value: MIN_ATTEMPT_FIRST. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PRIORITY_FIRST: Prioritize by priority.</description></item>
        /// <item><description>MIN_ATTEMPT_FIRST: Prioritize by the number of attempts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MIN_ATTEMPT_FIRST</para>
        /// </summary>
        [NameInMap("AttemptOrder")]
        [Validation(Required=false)]
        public string AttemptOrder { get; set; }

        /// <summary>
        /// <para>The callable time period for the task, formatted as a JSON object that contains two properties: beginTime and EndTime.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;beginTime&quot;:&quot;09:00:00&quot;,&quot;endTime&quot;:&quot;18:00:00&quot; }]。</para>
        /// </summary>
        [NameInMap("CallableTime")]
        [Validation(Required=false)]
        public string CallableTime { get; set; }

        /// <summary>
        /// <para>The task contact list. This is the key of an OSS object, which can be obtained by calling the GenerateFileUploadParams operation. You can also leave this parameter empty and add contacts later by calling the AppendCases operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cases/customer.csv</para>
        /// </summary>
        [NameInMap("CaseFileKey")]
        [Validation(Required=false)]
        public string CaseFileKey { get; set; }

        /// <summary>
        /// <para>The contact list. You can also leave this parameter empty and add contacts later by calling the AppendCases operation.</para>
        /// </summary>
        [NameInMap("Cases")]
        [Validation(Required=false)]
        public string CasesShrink { get; set; }

        /// <summary>
        /// <para>The outbound call timeout in seconds. Default value: 25.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("DialingTimeoutSeconds")]
        [Validation(Required=false)]
        public int? DialingTimeoutSeconds { get; set; }

        /// <summary>
        /// <para>The task end time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1579965079000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The minimum concurrency. This is the minimum concurrency set for the task. A value of 0 indicates that no baseline is set, and resources are allocated based on weights.</para>
        /// <para>If multiple campaigns have the minimum concurrency set:</para>
        /// <list type="bullet">
        /// <item><description><para>If the total concurrency is less than the total concurrency of the instance, the minimum concurrency of each task is prioritized, and the excess resources are allocated proportionally based on weights.</para>
        /// </description></item>
        /// <item><description><para>If the total concurrency is greater than the total concurrency of the instance, the minimum concurrency no longer serves as a baseline, but participates in the calculation as a weight factor.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FixedQuota")]
        [Validation(Required=false)]
        public int? FixedQuota { get; set; }

        /// <summary>
        /// <para>The flash SMS parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("FlashSmsParameters")]
        [Validation(Required=false)]
        public string FlashSmsParameters { get; set; }

        /// <summary>
        /// <para>Specifies whether to prohibit outbound calls on holidays.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HolidayRestricted")]
        [Validation(Required=false)]
        public bool? HolidayRestricted { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12f3dd08-0c55-44ce-9b64-e69d35ed3a76</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The maximum number of attempts, which specifies the maximum number of times to call a number when a call fails.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MaxAttemptCount")]
        [Validation(Required=false)]
        public int? MaxAttemptCount { get; set; }

        /// <summary>
        /// <para>The interval between attempts.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("MinAttemptInterval")]
        [Validation(Required=false)]
        public int? MinAttemptInterval { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Modified job group</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The list of calling numbers for the outbound task.</para>
        /// </summary>
        [NameInMap("Numbers")]
        [Validation(Required=false)]
        public string NumbersShrink { get; set; }

        /// <summary>
        /// <para>The list of restrictions for outbound call attempts. If this parameter is not specified, no restrictions are applied. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CALLEE_NOT_EXISTS: Do not call nonexistent numbers.</description></item>
        /// <item><description>OUT_OF_SERVICE: Do not call suspended numbers.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("RedialRestrictions")]
        [Validation(Required=false)]
        public string RedialRestrictions { get; set; }

        /// <summary>
        /// <para>Specifies whether to maintain the scheduling state until the campaign end time after all contacts are called. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The task remains in the scheduling state, and you can continue to add contacts.</description></item>
        /// <item><description>false: The task changes to the completed state, and you cannot add contacts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RunUntilEndTime")]
        [Validation(Required=false)]
        public bool? RunUntilEndTime { get; set; }

        /// <summary>
        /// <para>The scenario ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aa279896-64a6-4182-864c-4f2b04ec8d17</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>The task start time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1578965079000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The weight, which is an integer ranging from 0 to 100. A larger value indicates that more concurrency is allocated during scheduling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

    }

}
