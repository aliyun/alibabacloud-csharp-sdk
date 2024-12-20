// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetAiOutboundTaskDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAiOutboundTaskDetailResponseBodyData Data { get; set; }
        public class GetAiOutboundTaskDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ConcurrentRate")]
            [Validation(Required=false)]
            public int? ConcurrentRate { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;TUESDAY&quot;:[{&quot;start&quot;:&quot;06:00&quot;,&quot;end&quot;:&quot;06:05&quot;}],&quot;MONDAY&quot;:[{&quot;start&quot;:&quot;09:00&quot;,&quot;end&quot;:&quot;18:00&quot;},{&quot;start&quot;:&quot;20:30&quot;,&quot;end&quot;:&quot;21:45&quot;},{&quot;start&quot;:&quot;22:30&quot;,&quot;end&quot;:&quot;22:50&quot;}],&quot;WEDNESDAY&quot;:[{&quot;start&quot;:&quot;09:00&quot;,&quot;end&quot;:&quot;18:00&quot;}],&quot;THURSDAY&quot;:[{&quot;start&quot;:&quot;09:00&quot;,&quot;end&quot;:&quot;18:00&quot;}],&quot;FRIDAY&quot;:[{&quot;start&quot;:&quot;09:00&quot;,&quot;end&quot;:&quot;18:00&quot;}],&quot;SATURDAY&quot;:[{&quot;start&quot;:&quot;09:00&quot;,&quot;end&quot;:&quot;18:00&quot;}],&quot;SUNDAY&quot;:[{&quot;start&quot;:&quot;17:00&quot;,&quot;end&quot;:&quot;23:45&quot;}]}</para>
            /// </summary>
            [NameInMap("ExecutionTime")]
            [Validation(Required=false)]
            public string ExecutionTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.2</para>
            /// </summary>
            [NameInMap("ForecastCallRate")]
            [Validation(Required=false)]
            public float? ForecastCallRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("HandlerId")]
            [Validation(Required=false)]
            public long? HandlerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>热线技能组</para>
            /// </summary>
            [NameInMap("HandlerName")]
            [Validation(Required=false)]
            public string HandlerName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xx外呼任务</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NumRepeated")]
            [Validation(Required=false)]
            public int? NumRepeated { get; set; }

            [NameInMap("OutboundNums")]
            [Validation(Required=false)]
            public List<string> OutboundNums { get; set; }

            [NameInMap("RecallRule")]
            [Validation(Required=false)]
            public GetAiOutboundTaskDetailResponseBodyDataRecallRule RecallRule { get; set; }
            public class GetAiOutboundTaskDetailResponseBodyDataRecallRule : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>未开始</para>
            /// </summary>
            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D9CB3933-9FE3-4870-BA8E-2BEE91B69D23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
