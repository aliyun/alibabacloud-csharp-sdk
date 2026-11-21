// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class SearchContextRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;metadata.serviceName&quot;:&quot;sls-sop-daily&quot;,&quot;metadata.taskType&quot;:{&quot;in&quot;:[&quot;troubleshooting&quot;,&quot;knowledge_retrieval&quot;]}}</para>
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public Dictionary<string, object> Filter { get; set; }

        /// <summary>
        /// <para>Specifies whether to format the output.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("formatted")]
        [Validation(Required=false)]
        public bool? Formatted { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The query content.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>How is the cost for consuming SLS logs in Flink calculated?</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The retrieval options.</para>
        /// 
        /// <b>Example:</b>
        /// <para>reranker,llm_rank</para>
        /// </summary>
        [NameInMap("retrievalOption")]
        [Validation(Required=false)]
        public string RetrievalOption { get; set; }

        /// <summary>
        /// <para>The similarity threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.3</para>
        /// </summary>
        [NameInMap("threshold")]
        [Validation(Required=false)]
        public double? Threshold { get; set; }

    }

}
