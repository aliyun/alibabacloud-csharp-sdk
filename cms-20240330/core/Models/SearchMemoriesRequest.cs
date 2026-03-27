// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class SearchMemoriesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>972772996913709056</para>
        /// </summary>
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mm_480d961a1b5e4efe84603f4cbc0f</para>
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;sessionId&quot;:&quot;test_session_001&quot;}</para>
        /// </summary>
        [NameInMap("metadata")]
        [Validation(Required=false)]
        public Dictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>What I like</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("rerank")]
        [Validation(Required=false)]
        public bool? Rerank { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test_session_001</para>
        /// </summary>
        [NameInMap("runId")]
        [Validation(Required=false)]
        public string RunId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("topK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test_session_001</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
