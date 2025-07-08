// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiLLMTrace20240311.Models
{
    public class ListOnlineEvalTaskResultsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the evaluation task. At least one of the trace ID or task ID must be set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bb05ae8888c11ef9757faaa2a1ec0c6</para>
        /// </summary>
        [NameInMap("EvaluationId")]
        [Validation(Required=false)]
        public string EvaluationId { get; set; }

        /// <summary>
        /// <para>The same trace data may have been evaluated by different tasks. If no task ID is specified and there are multiple evaluation results for the same trace ID, this parameter specifies whether to return only the most recent evaluation result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("MostRecentResultsOnly")]
        [Validation(Required=false)]
        public bool? MostRecentResultsOnly { get; set; }

        /// <summary>
        /// <para>The current page number. Value range: integers greater than 0. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size, default is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Specify a set of trace IDs, and only return the evaluation results for these traces. At least one of the trace ID or task ID must be set.</para>
        /// </summary>
        [NameInMap("TraceIds")]
        [Validation(Required=false)]
        public List<string> TraceIds { get; set; }

    }

}
