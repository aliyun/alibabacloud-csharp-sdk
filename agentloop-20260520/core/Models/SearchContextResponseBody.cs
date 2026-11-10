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
        /// <para>The call ID for the multi-strategy recall of the experience store.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e8400-e29b-41d4-a716-446655440000</para>
        /// </summary>
        [NameInMap("callId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        /// <summary>
        /// <para>The diagnostics information for the current experience recall, including duration, model call volume, and filtering. The actual diagnostics items are determined by the running mode.</para>
        /// </summary>
        [NameInMap("diagnostics")]
        [Validation(Required=false)]
        public Dictionary<string, object> Diagnostics { get; set; }

        /// <summary>
        /// <para>The actual experience recall mode used for the current request. Valid values: direct, agentic, and hybrid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agentic</para>
        /// </summary>
        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The ID of the recall event. You can use this ID to call the GetContextStoreRecall operation to view audit details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0190f1c2-7d3e-7a1b-9c4d-2e5f6a7b8c9d</para>
        /// </summary>
        [NameInMap("recallEventId")]
        [Validation(Required=false)]
        public string RecallEventId { get; set; }

        /// <summary>
        /// <para>The list of relevance judgment results for candidate experiences.</para>
        /// </summary>
        [NameInMap("relevance")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Relevance { get; set; }

        /// <summary>
        /// <para>The ID of the request. You can use this ID to locate the request for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ACFB10A-1B2C-3D4E-5F6G-7H8I9J0K1L2M</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of retrieval results, sorted by similarity in descending order.</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Results { get; set; }

        /// <summary>
        /// <para>The list of rewritten queries generated based on the original retrieval query. The original query is not included.</para>
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
        /// <para>The strategy implementation version used for the current experience recall. This is used for auditing and result tracing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>experience-recall-20261031-v5</para>
        /// </summary>
        [NameInMap("strategyVersion")]
        [Validation(Required=false)]
        public string StrategyVersion { get; set; }

    }

}
