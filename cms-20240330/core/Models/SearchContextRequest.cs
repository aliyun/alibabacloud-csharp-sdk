// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class SearchContextRequest : TeaModel {
        [NameInMap("filter")]
        [Validation(Required=false)]
        public Dictionary<string, object> Filter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("formatted")]
        [Validation(Required=false)]
        public bool? Formatted { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>How is the cost for consuming SLS logs in Flink calculated?</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>reranker,llm_rank</para>
        /// </summary>
        [NameInMap("retrievalOption")]
        [Validation(Required=false)]
        public string RetrievalOption { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.3</para>
        /// </summary>
        [NameInMap("threshold")]
        [Validation(Required=false)]
        public double? Threshold { get; set; }

    }

}
