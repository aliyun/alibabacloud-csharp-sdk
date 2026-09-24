// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetAiOutboundTaskDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the outbound call task.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAiOutboundTaskDetailResponseBodyData Data { get; set; }
        public class GetAiOutboundTaskDetailResponseBodyData : TeaModel {
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
            /// <para>The task description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Real estate sales</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The task execution time. Time periods are configured by day of the week using a JSON object. The start and end values are in the HH:mm format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;TUESDAY&quot;:[{&quot;start&quot;:&quot;06:00&quot;,&quot;end&quot;:&quot;06:05&quot;}],&quot;MONDAY&quot;:[{&quot;start&quot;:&quot;09:00&quot;,&quot;end&quot;:&quot;18:00&quot;},{&quot;start&quot;:&quot;20:30&quot;,&quot;end&quot;:&quot;21:45&quot;},{&quot;start&quot;:&quot;22:30&quot;,&quot;end&quot;:&quot;22:50&quot;}],&quot;WEDNESDAY&quot;:[{&quot;start&quot;:&quot;09:00&quot;,&quot;end&quot;:&quot;18:00&quot;}],&quot;THURSDAY&quot;:[{&quot;start&quot;:&quot;09:00&quot;,&quot;end&quot;:&quot;18:00&quot;}],&quot;FRIDAY&quot;:[{&quot;start&quot;:&quot;09:00&quot;,&quot;end&quot;:&quot;18:00&quot;}],&quot;SATURDAY&quot;:[{&quot;start&quot;:&quot;09:00&quot;,&quot;end&quot;:&quot;18:00&quot;}],&quot;SUNDAY&quot;:[{&quot;start&quot;:&quot;17:00&quot;,&quot;end&quot;:&quot;23:45&quot;}]}</para>
            /// </summary>
            [NameInMap("ExecutionTime")]
            [Validation(Required=false)]
            public string ExecutionTime { get; set; }

            /// <summary>
            /// <para>The fixed call rate for predictive outbound calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2</para>
            /// </summary>
            [NameInMap("ForecastCallRate")]
            [Validation(Required=false)]
            public float? ForecastCallRate { get; set; }

            /// <summary>
            /// <para>The skill group ID (for predictive outbound calls) or IVR ID (for automatic outbound calls).</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("HandlerId")]
            [Validation(Required=false)]
            public long? HandlerId { get; set; }

            /// <summary>
            /// <para>The skill group name or IVR name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hotline skill group</para>
            /// </summary>
            [NameInMap("HandlerName")]
            [Validation(Required=false)]
            public string HandlerName { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxx outbound call</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The callee number deduplication policy.</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Deduplicate.</description></item>
            /// <item><description><b>1</b>: Do not deduplicate.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NumRepeated")]
            [Validation(Required=false)]
            public int? NumRepeated { get; set; }

            /// <summary>
            /// <para>The outbound caller numbers.</para>
            /// </summary>
            [NameInMap("OutboundNums")]
            [Validation(Required=false)]
            public List<string> OutboundNums { get; set; }

            /// <summary>
            /// <para>The failed recall policy.</para>
            /// </summary>
            [NameInMap("RecallRule")]
            [Validation(Required=false)]
            public GetAiOutboundTaskDetailResponseBodyDataRecallRule RecallRule { get; set; }
            public class GetAiOutboundTaskDetailResponseBodyDataRecallRule : TeaModel {
                /// <summary>
                /// <para>The number of recall attempts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The recall interval. Unit: minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

            }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Not started.</description></item>
            /// <item><description><b>1</b>: In progress.</description></item>
            /// <item><description><b>2</b>: System paused.</description></item>
            /// <item><description><b>3</b>: Manually paused.</description></item>
            /// <item><description><b>4</b>: Completed.</description></item>
            /// <item><description><b>5</b>: Stopped.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The task status description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Not started</para>
            /// </summary>
            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// <para>The task type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>2</b>: Predictive outbound call.</description></item>
            /// <item><description><b>3</b>: Automatic outbound call.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9CB3933-9FE3-4870-BA8E-2BEE91B69D23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Successful.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
