// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiLLMTrace20240311.Models
{
    public class ListOnlineEvalTasksResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>InvalidInputParams</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>page number should be greater than 0</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6F352A02-9C0D-54A7-B57C-663CF71D5714</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<ListOnlineEvalTasksResponseBodyTasks> Tasks { get; set; }
        public class ListOnlineEvalTasksResponseBodyTasks : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1512522691911111</para>
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

            [NameInMap("EvaluationConfig")]
            [Validation(Required=false)]
            public EvaluationConfig EvaluationConfig { get; set; }

            [NameInMap("Filters")]
            [Validation(Required=false)]
            public List<ListOnlineEvalTasksResponseBodyTasksFilters> Filters { get; set; }
            public class ListOnlineEvalTasksResponseBodyTasksFilters : TeaModel {
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
            /// <para>2025-04-07 13:24:35</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-04-09 13:24:35</para>
            /// </summary>
            [NameInMap("GmtEndTime")]
            [Validation(Required=false)]
            public string GmtEndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-04-08 13:24:35</para>
            /// </summary>
            [NameInMap("GmtStartTime")]
            [Validation(Required=false)]
            public string GmtStartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9f50cd72efcf36535152ee811a911115</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("ModelConfig")]
            [Validation(Required=false)]
            public ModelConfig ModelConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>my-foo-evaluation-task</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("SamplingFrequencyMinutes")]
            [Validation(Required=false)]
            public int? SamplingFrequencyMinutes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
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
            /// <para>2222222222</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
