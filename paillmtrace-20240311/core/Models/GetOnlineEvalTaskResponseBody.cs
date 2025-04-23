// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiLLMTrace20240311.Models
{
    public class GetOnlineEvalTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>InvalidInputParams</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>task id is empty</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>POP request id</para>
        /// 
        /// <b>Example:</b>
        /// <para>6F352A02-9C0D-54A7-B57C-663CF71D5714</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Task")]
        [Validation(Required=false)]
        public GetOnlineEvalTaskResponseBodyTask Task { get; set; }
        public class GetOnlineEvalTaskResponseBodyTask : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1195531608511111</para>
            /// </summary>
            [NameInMap("AliyunUid")]
            [Validation(Required=false)]
            public string AliyunUid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>my-llm-app</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EvalResults")]
            [Validation(Required=false)]
            public string EvalResults { get; set; }

            [NameInMap("EvaluationConfig")]
            [Validation(Required=false)]
            public EvaluationConfig EvaluationConfig { get; set; }

            [NameInMap("Filters")]
            [Validation(Required=false)]
            public List<GetOnlineEvalTaskResponseBodyTaskFilters> Filters { get; set; }
            public class GetOnlineEvalTaskResponseBodyTaskFilters : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ServiceId
                /// ServiceName
                /// Input
                /// Output
                /// Status
                /// TraceType
                /// SpanType
                /// TraceName
                /// SpanName</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>=
                /// StartsWith
                /// Contains</para>
                /// </summary>
                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>foo</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-07-31 08:30:00</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-08-10 13:20:00</para>
            /// </summary>
            [NameInMap("GmtEndTime")]
            [Validation(Required=false)]
            public string GmtEndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-08-10 13:14:00</para>
            /// </summary>
            [NameInMap("GmtLastSamplingWindowEndTime")]
            [Validation(Required=false)]
            public string GmtLastSamplingWindowEndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-08-10 13:11:00</para>
            /// </summary>
            [NameInMap("GmtLastSamplingWindowStartTime")]
            [Validation(Required=false)]
            public string GmtLastSamplingWindowStartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-08-02</para>
            /// </summary>
            [NameInMap("GmtStartTime")]
            [Validation(Required=false)]
            public string GmtStartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0839a02d-aa24-4174-90bb-7a773885934d</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("ModelConfig")]
            [Validation(Required=false)]
            public ModelConfig ModelConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>my-eval-task-1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>999</para>
            /// </summary>
            [NameInMap("RecordCount")]
            [Validation(Required=false)]
            public int? RecordCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("SamplingFrequencyMinutes")]
            [Validation(Required=false)]
            public int? SamplingFrequencyMinutes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>70</para>
            /// </summary>
            [NameInMap("SamplingRatio")]
            [Validation(Required=false)]
            public int? SamplingRatio { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CREATED
            /// RUNNING
            /// FINISHED
            /// USER_CANCELED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>222222222222222222</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
