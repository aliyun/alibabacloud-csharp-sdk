// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiLLMTrace20240311.Models
{
    public class EvaluateTraceRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the trace belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-llm-app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>If the value retrieved at the JSON path is itself a JSON string, further JSON path definitions within this JSON are necessary to get the actual value.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EvaluationConfig")]
        [Validation(Required=false)]
        public EvaluationConfig EvaluationConfig { get; set; }

        /// <summary>
        /// <para>The ID of the evaluation task. If not specified, the system randomly generates and returns an ID. You can use this ID to quickly search for evaluation results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44aea0ee00000000be5be24b2abb8f98</para>
        /// </summary>
        [NameInMap("EvaluationId")]
        [Validation(Required=false)]
        public string EvaluationId { get; set; }

        /// <summary>
        /// <para>The end time of the search time range, in UTC format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-04-05 13:24:25
        /// 2025-04-05</para>
        /// </summary>
        [NameInMap("MaxTime")]
        [Validation(Required=false)]
        public string MaxTime { get; set; }

        /// <summary>
        /// <para>The start time of the search time range, in UTC format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-04-05 13:24:25
        /// 2025-04-05</para>
        /// </summary>
        [NameInMap("MinTime")]
        [Validation(Required=false)]
        public string MinTime { get; set; }

        /// <summary>
        /// <para>The configuration structure to access the model used internally by the evaluation trace.</para>
        /// </summary>
        [NameInMap("ModelConfig")]
        [Validation(Required=false)]
        public ModelConfig ModelConfig { get; set; }

    }

}
