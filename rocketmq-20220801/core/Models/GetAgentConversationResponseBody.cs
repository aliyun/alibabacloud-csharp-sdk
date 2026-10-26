// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class GetAgentConversationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0198c8a91f4d7f01a3c21e97</para>
        /// </summary>
        [NameInMap("conversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-08-19T12:00:00.000Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>waiting_input</para>
        /// </summary>
        [NameInMap("currentRunStatus")]
        [Validation(Required=false)]
        public string CurrentRunStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0198c8a91f4d7f01a3c21e97</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;toolUseId&quot;:&quot;tool_01&quot;,&quot;tool&quot;:&quot;AskUserQuestion&quot;}</para>
        /// </summary>
        [NameInMap("pendingTool")]
        [Validation(Required=false)]
        public object PendingTool { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>diagnosis</para>
        /// </summary>
        [NameInMap("scenarioId")]
        [Validation(Required=false)]
        public string ScenarioId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>消息堆积排查</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-08-19T12:05:00.000Z</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
