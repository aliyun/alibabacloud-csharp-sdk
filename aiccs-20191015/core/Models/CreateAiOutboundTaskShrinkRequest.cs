// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class CreateAiOutboundTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Concurrent call rate for automated outbound calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ConcurrentRate")]
        [Validation(Required=false)]
        public int? ConcurrentRate { get; set; }

        /// <summary>
        /// <para>Job description. Length: 0 to 100 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>房产销售</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Job execution time, in JSON format.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;TUESDAY&quot;:[{&quot;start&quot;:&quot;06:00&quot;,&quot;end&quot;:&quot;06:05&quot;}],&quot;MONDAY&quot;:[{&quot;start&quot;:&quot;09:00&quot;,&quot;end&quot;:&quot;18:00&quot;},{&quot;start&quot;:&quot;20:30&quot;,&quot;end&quot;:&quot;21:45&quot;},{&quot;start&quot;:&quot;22:30&quot;,&quot;end&quot;:&quot;22:50&quot;}],&quot;WEDNESDAY&quot;:[{&quot;start&quot;:&quot;09:00&quot;,&quot;end&quot;:&quot;18:00&quot;}],&quot;THURSDAY&quot;:[{&quot;start&quot;:&quot;09:00&quot;,&quot;end&quot;:&quot;18:00&quot;}],&quot;FRIDAY&quot;:[{&quot;start&quot;:&quot;09:00&quot;,&quot;end&quot;:&quot;18:00&quot;}],&quot;SATURDAY&quot;:[{&quot;start&quot;:&quot;09:00&quot;,&quot;end&quot;:&quot;18:00&quot;}],&quot;SUNDAY&quot;:[{&quot;start&quot;:&quot;17:00&quot;,&quot;end&quot;:&quot;23:45&quot;}]}</para>
        /// </summary>
        [NameInMap("ExecutionTime")]
        [Validation(Required=false)]
        public string ExecutionTime { get; set; }

        /// <summary>
        /// <para>Fixed outbound ratio for predictive dialing. Valid values: <b>≥1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.5</para>
        /// </summary>
        [NameInMap("ForecastCallRate")]
        [Validation(Required=false)]
        public float? ForecastCallRate { get; set; }

        /// <summary>
        /// <para>The skill group ID (for predictive outbound calls) or IVR ID (for automated outbound calls). You can obtain this information in the <a href="https://aiccs.console.aliyun.com/overview">Artificial Intelligence Cloud Call Service console</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("HandlerId")]
        [Validation(Required=false)]
        public long? HandlerId { get; set; }

        /// <summary>
        /// <para>AICCS instance ID.<br>You can obtain it from <b>Instance Management</b> in the left-side navigation pane of the <a href="https://aiccs.console.aliyun.com/overview">Artificial Intelligence Cloud Call Service console</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc_xp_pre-cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Job name. Length: 1 to 15 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试任务</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Called number deduplication policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Remove duplicates within the job.</description></item>
        /// <item><description><b>1</b>: Do not remove duplicates.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NumRepeated")]
        [Validation(Required=false)]
        public int? NumRepeated { get; set; }

        /// <summary>
        /// <para>Outbound caller numbers.  </para>
        /// <remarks>
        /// <para>Must be purchased numbers. Separate multiple numbers with commas (,).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OutboundNums")]
        [Validation(Required=false)]
        public string OutboundNumsShrink { get; set; }

        /// <summary>
        /// <para>Failed call retry policy.  </para>
        /// <remarks>
        /// <para>If empty, no retries are performed.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RecallRule")]
        [Validation(Required=false)]
        public string RecallRuleShrink { get; set; }

        /// <summary>
        /// <para>Task Type. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>2</b>: Predictive outbound call.  </description></item>
        /// <item><description><b>3</b>: Automated outbound call.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
