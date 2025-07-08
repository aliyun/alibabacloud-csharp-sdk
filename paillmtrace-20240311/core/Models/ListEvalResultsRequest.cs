// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiLLMTrace20240311.Models
{
    public class ListEvalResultsRequest : TeaModel {
        /// <summary>
        /// <para>The task ID of the evaluation task to which the trace belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bb05ae2a2dc11ef9757faaa2a1ec0c6</para>
        /// </summary>
        [NameInMap("EvaluationId")]
        [Validation(Required=false)]
        public string EvaluationId { get; set; }

        /// <summary>
        /// <para>The keyword to query from the evaluation inputs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>foo</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The page number. Page starts from page 1. Default value: 1</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Maximum value: 50. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The trace data IDs.</para>
        /// </summary>
        [NameInMap("RecordIds")]
        [Validation(Required=false)]
        public List<string> RecordIds { get; set; }

    }

}
