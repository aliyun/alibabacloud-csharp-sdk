// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class SearchContextResponseBody : TeaModel {
        /// <summary>
        /// <para>The audit write status. Valid values: ok and degraded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("auditStatus")]
        [Validation(Required=false)]
        public string AuditStatus { get; set; }

        /// <summary>
        /// <para>The call ID for multi-strategy recall in the experience store.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e8400-e29b-41d4-a716-446655440000</para>
        /// </summary>
        [NameInMap("callId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        /// <summary>
        /// <para>The diagnostics information for the current experience recall, including duration, model call volume, and filtering. The actual diagnostics items are determined by the running mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;durationMs&quot;: 386.5,
        ///     &quot;modelCalls&quot;: 2,
        ///     &quot;relevanceValidation&quot;: &quot;semantic&quot;,
        ///     &quot;candidateCount&quot;: 1,
        ///     &quot;filtering&quot;: {
        ///         &quot;model_not_relevant&quot;: 0
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("diagnostics")]
        [Validation(Required=false)]
        public Dictionary<string, object> Diagnostics { get; set; }

        /// <summary>
        /// <para>The experience recall mode actually used for the current request. Valid values: direct, agentic, and hybrid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agentic</para>
        /// </summary>
        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The ID of the recall event. You can use this ID to call GetContextStoreRecall to view audit details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0190f1c2-7d3e-7a1b-9c4d-2e5f6a7b8c9d</para>
        /// </summary>
        [NameInMap("recallEventId")]
        [Validation(Required=false)]
        public string RecallEventId { get; set; }

        /// <summary>
        /// <para>The list of relevance judgment results for candidate experiences.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///   {
        ///     &quot;contextId&quot;: &quot;a:1&quot;,
        ///     &quot;judgment&quot;: &quot;relevant&quot;,
        ///     &quot;reason&quot;: &quot;This experience explains how to skip tasks with unchanged inputs, which is relevant to the search query.&quot;
        ///   }
        /// ]</para>
        /// </summary>
        [NameInMap("relevance")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Relevance { get; set; }

        /// <summary>
        /// <para>The ID of the request. You can use this ID to locate the request when troubleshooting issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ACFB10A-1B2C-3D4E-5F6G-7H8I9J0K1L2M</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of retrieval results, sorted by similarity in descending order. Each item contains contextId, context, metadata, score, rank, revision, strategyVersion, and strategyId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;contextId&quot;:&quot;01a1cf08-c368-7c83******&quot;,&quot;strategyId&quot;:&quot;default&quot;,&quot;context&quot;:&quot;The assistant recommends steamed seafood because it is fresh and not spicy, which aligns with the user\&quot;s preference for seafood and constraint against spicy food.&quot;,&quot;metadata&quot;:{&quot;contextType&quot;:&quot;memory&quot;,&quot;memoryType&quot;:&quot;long&quot;,&quot;userId&quot;:&quot;test_user_002&quot;,&quot;agentId&quot;:&quot;95273000000000&quot;,&quot;appId&quot;:&quot;mm_480d961******&quot;,&quot;runId&quot;:&quot;jr-80ded1d6******&quot;,&quot;strategyId&quot;:&quot;default&quot;,&quot;category&quot;:&quot;recommendation&quot;,&quot;kind&quot;:&quot;state&quot;,&quot;sourceKind&quot;:&quot;api&quot;,&quot;sourceId&quot;:&quot;addctx:75395808-cb81-54cd******&quot;,&quot;revision&quot;:1,&quot;reviewStatus&quot;:&quot;unreviewed&quot;,&quot;sourceState&quot;:&quot;active&quot;,&quot;factKey&quot;:&quot;assistant:recommendation:dish******&quot;,&quot;sessionId&quot;:&quot;test_session_001&quot;},&quot;score&quot;:0.6617179,&quot;rank&quot;:1,&quot;revision&quot;:1,&quot;strategyVersion&quot;:1}]</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Results { get; set; }

        /// <summary>
        /// <para>The list of rewritten queries generated based on the original retrieval query. The original query is not included.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;How to avoid repeatedly executing unchanged inputs&quot;]</para>
        /// </summary>
        [NameInMap("rewrittenQueries")]
        [Validation(Required=false)]
        public List<string> RewrittenQueries { get; set; }

        /// <summary>
        /// <para>The processing status of the current experience recall call. Valid values: success, degraded, failed, and error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The implementation version of the strategy used for the current experience recall. This is used for auditing and result tracing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>experience-recall-20261031-v5</para>
        /// </summary>
        [NameInMap("strategyVersion")]
        [Validation(Required=false)]
        public string StrategyVersion { get; set; }

    }

}
