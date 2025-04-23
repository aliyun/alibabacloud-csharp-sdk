// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiLLMTrace20240311.Models
{
    public class UpdateOnlineEvalTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>my-llm-one</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-09-02 22:24:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("EvaluationConfig")]
        [Validation(Required=false)]
        public EvaluationConfig EvaluationConfig { get; set; }

        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<UpdateOnlineEvalTaskRequestFilters> Filters { get; set; }
        public class UpdateOnlineEvalTaskRequestFilters : TeaModel {
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
        /// <para>10</para>
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
        /// <para>2024-07-31 08:30:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
