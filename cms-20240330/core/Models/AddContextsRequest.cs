// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AddContextsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>memory</para>
        /// </summary>
        [NameInMap("contextType")]
        [Validation(Required=false)]
        public string ContextType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<AddContextsRequestItems> Items { get; set; }
        public class AddContextsRequestItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>952730733889060865</para>
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

            [NameInMap("categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>You are a conversation assistant.</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Your custom instructions here</para>
            /// </summary>
            [NameInMap("customInstructions")]
            [Validation(Required=false)]
            public string CustomInstructions { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;taskType&quot;: &quot;troubleshooting&quot;,
            ///     &quot;complexity&quot;: &quot;medium&quot;,
            ///     &quot;confidence&quot;: 0.95
            /// }</para>
            /// </summary>
            [NameInMap("experience")]
            [Validation(Required=false)]
            public Dictionary<string, object> Experience { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1731231212334396</para>
            /// </summary>
            [NameInMap("expirationDate")]
            [Validation(Required=false)]
            public string ExpirationDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("immutable")]
            [Validation(Required=false)]
            public bool? Immutable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("infer")]
            [Validation(Required=false)]
            public bool? Infer { get; set; }

            [NameInMap("labels")]
            [Validation(Required=false)]
            public Dictionary<string, string> Labels { get; set; }

            [NameInMap("messages")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Messages { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;sessionId&quot;:&quot;test_session_001&quot;}</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metadata { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>jr-80ded1d6953c64ea</para>
            /// </summary>
            [NameInMap("runId")]
            [Validation(Required=false)]
            public string RunId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1774578167</para>
            /// </summary>
            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            [NameInMap("triggerCondition")]
            [Validation(Required=false)]
            public string TriggerCondition { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_user_001</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>short</para>
        /// </summary>
        [NameInMap("memoryType")]
        [Validation(Required=false)]
        public string MemoryType { get; set; }

    }

}
