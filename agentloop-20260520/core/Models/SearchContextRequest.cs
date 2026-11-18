// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class SearchContextRequest : TeaModel {
        /// <summary>
        /// <para>The structured filter conditions. The experience store supports scene. When __agentloopControl.mode is set to direct, hybrid, or agentic, multi-strategy recall with auditing is used, and you can pass source, callId, application, fields, channels, and budget simultaneously. The management plane can additionally pass contentStatus=all, active, candidate, gray, or deprecated to perform content retrieval, which includes disabled or unreviewed content and is not affected by store-level runtime switches. The API key runtime entry prohibits contentStatus and retains the original governance thresholds. The maximum value of timeoutMs is 60000. If mode is not passed, the existing semantics of fields, channels, minQualityScore, expansion, and debug are retained. When query is *, you can use includeCandidates, cursor, and offset to browse experiences (management plane only).</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;scene&quot;:&quot;incident-recovery&quot;,&quot;__agentloopControl&quot;:{&quot;fields&quot;:[&quot;when_to_use&quot;,&quot;summary&quot;],&quot;channels&quot;:[&quot;vector&quot;,&quot;fulltext&quot;],&quot;minQualityScore&quot;:0.6,&quot;expansion&quot;:false,&quot;debug&quot;:true}}</para>
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public Dictionary<string, object> Filter { get; set; }

        /// <summary>
        /// <para>Specifies whether to apply structured formatting to the returned results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("formatted")]
        [Validation(Required=false)]
        public bool? Formatted { get; set; }

        /// <summary>
        /// <para>Specifies whether to include memories with sourceState set to inactive. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("includeInactive")]
        [Validation(Required=false)]
        public bool? IncludeInactive { get; set; }

        /// <summary>
        /// <para>The maximum number of returned results (Top-N similarity).</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The retrieval query text. Natural language is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Recent user preference settings</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The retrieval options. The experience store supports normal and reranker (deterministic reranking). The memory store uses its own retrieval strategy. For real-time recall in the experience store, the limit ranges from 1 to 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("retrievalOption")]
        [Validation(Required=false)]
        public string RetrievalOption { get; set; }

        /// <summary>
        /// <para>The recall scope. If this field conflicts with a field of the same name in filter, a 400 ScopeFilterConflict error is returned.</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public SearchContextRequestScope Scope { get; set; }
        public class SearchContextRequestScope : TeaModel {
            /// <summary>
            /// <para>The ID of the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sales-copilot</para>
            /// </summary>
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crm-service</para>
            /// </summary>
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The ID of the run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>run-001</para>
            /// </summary>
            [NameInMap("runId")]
            [Validation(Required=false)]
            public string RunId { get; set; }

            /// <summary>
            /// <para>The ID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>u-10001</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>Filters results by extraction strategy IDs. The conditions in the list are combined by using the OR operator. If this parameter is not passed, all strategies are recalled. An empty list returns a 400 error. If the format is valid but no matching IDs are found, an empty result is returned. Historical removed strategy IDs are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;preferences&quot;,&quot;profile&quot;]</para>
        /// </summary>
        [NameInMap("strategyIds")]
        [Validation(Required=false)]
        public List<string> StrategyIds { get; set; }

        /// <summary>
        /// <para>The similarity threshold. Results with a score lower than this value are filtered out. Valid values: 0 to 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("threshold")]
        [Validation(Required=false)]
        public double? Threshold { get; set; }

    }

}
