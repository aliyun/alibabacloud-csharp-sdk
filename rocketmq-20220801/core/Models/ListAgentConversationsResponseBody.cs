// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListAgentConversationsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;id&quot;:&quot;0198c8a91f4d7f01a3c21e97&quot;,&quot;title&quot;:&quot;消息堆积排查&quot;}]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListAgentConversationsResponseBodyData> Data { get; set; }
        public class ListAgentConversationsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;role&quot;:&quot;owner&quot;,&quot;admin&quot;:false,&quot;canRead&quot;:true,&quot;canWrite&quot;:true,&quot;canManage&quot;:true}</para>
            /// </summary>
            [NameInMap("access")]
            [Validation(Required=false)]
            public object Access { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;runtime&quot;:&quot;claude&quot;,&quot;connectionId&quot;:&quot;connection-example&quot;,&quot;modelId&quot;:&quot;model-example&quot;,&quot;connectionName&quot;:&quot;示例连接&quot;,&quot;modelDisplayName&quot;:&quot;示例模型&quot;}</para>
            /// </summary>
            [NameInMap("agent")]
            [Validation(Required=false)]
            public object Agent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;sessionId&quot;:&quot;0198c8a91f4d7f01a3c21e97&quot;,&quot;purposes&quot;:[]}</para>
            /// </summary>
            [NameInMap("analysisCoverage")]
            [Validation(Required=false)]
            public object AnalysisCoverage { get; set; }

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
            /// <para>1000000000000001</para>
            /// </summary>
            [NameInMap("createdBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>waiting</para>
            /// </summary>
            [NameInMap("currentRunStatus")]
            [Validation(Required=false)]
            public string CurrentRunStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("editMonitorId")]
            [Validation(Required=false)]
            public string EditMonitorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0198c8a91f4d7f01a3c21e97</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;userId&quot;:&quot;1000000000000001&quot;,&quot;name&quot;:null,&quot;nickName&quot;:null,&quot;email&quot;:null,&quot;avatar&quot;:null}</para>
            /// </summary>
            [NameInMap("owner")]
            [Validation(Required=false)]
            public object Owner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;id&quot;:&quot;project-example&quot;,&quot;name&quot;:&quot;RocketMQ 诊断&quot;,&quot;color&quot;:&quot;#1677ff&quot;,&quot;initial&quot;:&quot;R&quot;,&quot;agentProfile&quot;:&quot;customer&quot;}</para>
            /// </summary>
            [NameInMap("project")]
            [Validation(Required=false)]
            public object Project { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rocketmq-customer</para>
            /// </summary>
            [NameInMap("scenarioId")]
            [Validation(Required=false)]
            public string ScenarioId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("shareScope")]
            [Validation(Required=false)]
            public string ShareScope { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("sourceSessionId")]
            [Validation(Required=false)]
            public string SourceSessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("tagging")]
            [Validation(Required=false)]
            public object Tagging { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>消息堆积排查</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("toolCallCount")]
            [Validation(Required=false)]
            public long? ToolCallCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-08-19T12:05:00.000Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;rocketmq-agent&quot;]</para>
            /// </summary>
            [NameInMap("usedSkills")]
            [Validation(Required=false)]
            public List<string> UsedSkills { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eyJpZCI6IjAxOThjOGE5In0=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
