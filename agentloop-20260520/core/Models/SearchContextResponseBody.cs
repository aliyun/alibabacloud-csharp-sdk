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
        /// <para>The recall event ID. You can use this ID to call the GetContextStoreRecall operation to view audit details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0190f1c2-7d3e-7a1b-9c4d-2e5f6a7b8c9d</para>
        /// </summary>
        [NameInMap("recallEventId")]
        [Validation(Required=false)]
        public string RecallEventId { get; set; }

        /// <summary>
        /// <para>The request ID, which can be used to locate the request during troubleshooting.</para>
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

    }

}
