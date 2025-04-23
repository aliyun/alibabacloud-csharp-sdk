// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiLLMTrace20240311.Models
{
    public class CreateOnlineEvalTaskRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateOnlineEvalTaskRequestBody Body { get; set; }
        public class CreateOnlineEvalTaskRequestBody : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>my-best-llm-app</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-06-05 14:00:01
            /// 2025-06-05</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("EvaluationConfig")]
            [Validation(Required=false)]
            public EvaluationConfig EvaluationConfig { get; set; }

            [NameInMap("Filters")]
            [Validation(Required=false)]
            public List<CreateOnlineEvalTaskRequestBodyFilters> Filters { get; set; }
            public class CreateOnlineEvalTaskRequestBodyFilters : TeaModel {
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

            [NameInMap("ModelConfig")]
            [Validation(Required=false)]
            public ModelConfig ModelConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9</para>
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
            /// <para>2025-04-05 14:00:01
            /// 2025-04-05</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>my-llm-app-eval-task-1</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

        }

    }

}
