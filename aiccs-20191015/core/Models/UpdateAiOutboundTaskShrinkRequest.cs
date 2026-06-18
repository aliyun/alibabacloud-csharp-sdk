// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class UpdateAiOutboundTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The concurrent rate for automated outbound calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ConcurrentRate")]
        [Validation(Required=false)]
        public int? ConcurrentRate { get; set; }

        /// <summary>
        /// <para>The job description. It can contain 0 to 100 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>房产销售</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The job execution time.</para>
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
        /// <para>Fixed dialing ratio for predictive outbound calls. Valid values: <b>≥1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2</para>
        /// </summary>
        [NameInMap("ForecastCallRate")]
        [Validation(Required=false)]
        public float? ForecastCallRate { get; set; }

        /// <summary>
        /// <para>The skill group ID (for predictive outbound calls) or IVR ID (for automated outbound calls).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("HandlerId")]
        [Validation(Required=false)]
        public long? HandlerId { get; set; }

        /// <summary>
        /// <para>AICCS instance ID.<br>You can obtain it from <b>Instance Management</b> in the left-side navigation pane of the <a href="https://aiccs.console.aliyun.com/overview">Artificial Intelligence Cloud Call Service console</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent_***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Job name. Length: 1 to 15 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx外呼</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The policy for handling duplicate callee numbers.</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Remove duplicates within the job.</description></item>
        /// <item><description><b>1</b>: Do not remove duplicates within the job.</description></item>
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
        /// <para>Outbound caller numbers.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OutboundNums")]
        [Validation(Required=false)]
        public string OutboundNumsShrink { get; set; }

        /// <summary>
        /// <para>Failed-call retry policy.</para>
        /// <remarks>
        /// <para>If empty, no retry is performed when an outbound call fails.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RecallRule")]
        [Validation(Required=false)]
        public string RecallRuleShrink { get; set; }

        /// <summary>
        /// <para>The job ID.</para>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/312260.html">CreateAiOutboundTask</a> API and check the <b>Data</b> field in the response, or invoke the <a href="https://help.aliyun.com/document_detail/2718026.html">GetAiOutboundTaskList</a> API and check the <b>TaskId</b> field in the response.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
