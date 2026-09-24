// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class CreateAiOutboundTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The call concurrency for automatic outbound calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ConcurrentRate")]
        [Validation(Required=false)]
        public int? ConcurrentRate { get; set; }

        /// <summary>
        /// <para>The task description. The description can be up to 100 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RealEstateSales</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The task execution time. The value is in JSON format.</para>
        /// <remarks>
        /// <para>The end time (end) must be later than the start time (start).</para>
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
        /// <para>The fixed call ratio for predictive outbound calls. Valid values: <b>≥ 1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.5</para>
        /// </summary>
        [NameInMap("ForecastCallRate")]
        [Validation(Required=false)]
        public float? ForecastCallRate { get; set; }

        /// <summary>
        /// <para>The skill group ID (for predictive outbound calls) or IVR ID (for automatic outbound calls). You can obtain this information from the <a href="https://aiccs.console.aliyun.com/overview">Artificial Intelligence Cloud Call Service console</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("HandlerId")]
        [Validation(Required=false)]
        public long? HandlerId { get; set; }

        /// <summary>
        /// <para>The ID of the Artificial Intelligence Cloud Call Service (AICCS) instance.
        /// You can obtain the instance ID from <b>Instance Management</b> in the left-side navigation pane of the <a href="https://aiccs.console.aliyun.com/overview">Artificial Intelligence Cloud Call Service console</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc_xp_pre-cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The task name. The name must be 1 to 15 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestTask</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The callee number deduplication policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: deduplicate within the task.</description></item>
        /// <item><description><b>1</b>: no deduplication.</description></item>
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
        /// <para>The outbound caller numbers.</para>
        /// <remarks>
        /// <para>The numbers must be purchased numbers. Separate multiple numbers with commas (,).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OutboundNums")]
        [Validation(Required=false)]
        public string OutboundNumsShrink { get; set; }

        /// <summary>
        /// <para>The failed call retry policy.</para>
        /// <remarks>
        /// <para>If the value is empty, no retry is performed.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RecallRule")]
        [Validation(Required=false)]
        public string RecallRuleShrink { get; set; }

        /// <summary>
        /// <para>The task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2</b>: predictive outbound call.</description></item>
        /// <item><description><b>3</b>: automatic outbound call.</description></item>
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
