// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class UpdateAiOutboundTaskRequest : TeaModel {
        /// <summary>
        /// <para>The concurrency for automatic outbound calls.</para>
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
        /// <para>PropertySales</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The task execution time. Use a JSON object to configure time periods by day of the week. The start and end values must be in the HH:mm format. The end time must be later than the start time.</para>
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
        /// <para>1.2</para>
        /// </summary>
        [NameInMap("ForecastCallRate")]
        [Validation(Required=false)]
        public float? ForecastCallRate { get; set; }

        /// <summary>
        /// <para>The skill group ID for predictive outbound calls, or the IVR ID for automatic outbound calls.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
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
        /// <para>agent_***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The task name. The name must be 1 to 15 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleOutboundCall</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The called number deduplication policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Deduplicate within the task.</description></item>
        /// <item><description><b>1</b>: Do not deduplicate within the task.</description></item>
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
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OutboundNums")]
        [Validation(Required=false)]
        public List<string> OutboundNums { get; set; }

        /// <summary>
        /// <para>The failed recall policy.</para>
        /// <remarks>
        /// <para>If this parameter is left empty, the system does not recall when an outbound call fails.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RecallRule")]
        [Validation(Required=false)]
        public UpdateAiOutboundTaskRequestRecallRule RecallRule { get; set; }
        public class UpdateAiOutboundTaskRequestRecallRule : TeaModel {
            /// <summary>
            /// <para>The number of failed recall attempts. Valid values: <b>1 to 3</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The interval between failed recall attempts. Valid values: <b>1 to 60</b>. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

        }

        /// <summary>
        /// <para>The task ID.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/312260.html">CreateAiOutboundTask</a> operation and check the <b>Data</b> parameter in the response, or call the <a href="https://help.aliyun.com/document_detail/2718026.html">GetAiOutboundTaskList</a> operation and check the <b>TaskId</b> parameter in the response.</para>
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
