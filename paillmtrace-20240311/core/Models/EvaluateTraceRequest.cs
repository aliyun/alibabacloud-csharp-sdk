// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiLLMTrace20240311.Models
{
    public class EvaluateTraceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>my-llm-app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EvaluationConfig")]
        [Validation(Required=false)]
        public EvaluationConfig EvaluationConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>44aea0ee00000000be5be24b2abb8f98</para>
        /// </summary>
        [NameInMap("EvaluationId")]
        [Validation(Required=false)]
        public string EvaluationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-04-05 13:24:25
        /// 2025-04-05</para>
        /// </summary>
        [NameInMap("MaxTime")]
        [Validation(Required=false)]
        public string MaxTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-04-05 13:24:25
        /// 2025-04-05</para>
        /// </summary>
        [NameInMap("MinTime")]
        [Validation(Required=false)]
        public string MinTime { get; set; }

        [NameInMap("ModelConfig")]
        [Validation(Required=false)]
        public ModelConfig ModelConfig { get; set; }

    }

}
