// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiLLMTrace20240311.Models
{
    public class ListOnlineEvalTaskResultsShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0bb05ae8888c11ef9757faaa2a1ec0c6</para>
        /// </summary>
        [NameInMap("EvaluationId")]
        [Validation(Required=false)]
        public string EvaluationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("MostRecentResultsOnly")]
        [Validation(Required=false)]
        public bool? MostRecentResultsOnly { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TraceIds")]
        [Validation(Required=false)]
        public string TraceIdsShrink { get; set; }

    }

}
