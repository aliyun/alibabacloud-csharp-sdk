// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AddContextsRequest : TeaModel {
        /// <summary>
        /// <para>The context type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>memory</para>
        /// </summary>
        [NameInMap("contextType")]
        [Validation(Required=false)]
        public string ContextType { get; set; }

        /// <summary>
        /// <para>An array of context items.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<AddContextsRequestItems> Items { get; set; }
        public class AddContextsRequestItems : TeaModel {
            /// <summary>
            /// <para>The unique agent ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>952730733889060865</para>
            /// </summary>
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mm_480d961a1b5e4efe84603f4cbc0f</para>
            /// </summary>
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>A list of categories to apply to the context item.</para>
            /// </summary>
            [NameInMap("categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            /// <summary>
            /// <para>The content of the context item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>You are a conversation assistant.</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The custom instructions for processing the context.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Your custom instructions here</para>
            /// </summary>
            [NameInMap("customInstructions")]
            [Validation(Required=false)]
            public string CustomInstructions { get; set; }

            /// <summary>
            /// <para>An object containing experience information for the context.</para>
            /// 
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
            /// <para>The expiration timestamp for the context item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1731231212334396</para>
            /// </summary>
            [NameInMap("expirationDate")]
            [Validation(Required=false)]
            public string ExpirationDate { get; set; }

            /// <summary>
            /// <para>Specifies whether the context item is immutable. If set to <c>true</c>, the item cannot be changed after it is created. The default value is <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("immutable")]
            [Validation(Required=false)]
            public bool? Immutable { get; set; }

            /// <summary>
            /// <para>Specifies whether to perform inference based on the context. The default value is <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("infer")]
            [Validation(Required=false)]
            public bool? Infer { get; set; }

            /// <summary>
            /// <para>A map of key-value pairs to apply as labels.</para>
            /// </summary>
            [NameInMap("labels")]
            [Validation(Required=false)]
            public Dictionary<string, string> Labels { get; set; }

            /// <summary>
            /// <para>An array of message objects.</para>
            /// </summary>
            [NameInMap("messages")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Messages { get; set; }

            /// <summary>
            /// <para>Key-value pairs to store as metadata.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;sessionId&quot;:&quot;test_session_001&quot;}</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metadata { get; set; }

            /// <summary>
            /// <para>The run ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jr-80ded1d6953c64ea</para>
            /// </summary>
            [NameInMap("runId")]
            [Validation(Required=false)]
            public string RunId { get; set; }

            /// <summary>
            /// <para>The timestamp of the context item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1774578167</para>
            /// </summary>
            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            /// <summary>
            /// <para>The condition that triggers the context.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Identify and troubleshoot SLs issues</para>
            /// </summary>
            [NameInMap("triggerCondition")]
            [Validation(Required=false)]
            public string TriggerCondition { get; set; }

            /// <summary>
            /// <para>The unique user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_user_001</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The memory type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>short</para>
        /// </summary>
        [NameInMap("memoryType")]
        [Validation(Required=false)]
        public string MemoryType { get; set; }

    }

}
