// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetNodeDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The actual work process grouped by thoughts, skills, tools, replies, and artifacts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;thoughts&quot;:[],&quot;skillCalls&quot;:[],&quot;toolCalls&quot;:[],&quot;replies&quot;:[],&quot;artifacts&quot;:[]}</para>
        /// </summary>
        [NameInMap("agentWorkProcess")]
        [Validation(Required=false)]
        public GetNodeDetailResponseBodyAgentWorkProcess AgentWorkProcess { get; set; }
        public class GetNodeDetailResponseBodyAgentWorkProcess : TeaModel {
            /// <summary>
            /// <para>The artifacts: saved node work records and artifacts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("artifacts")]
            [Validation(Required=false)]
            public List<GetNodeDetailResponseBodyAgentWorkProcessArtifacts> Artifacts { get; set; }
            public class GetNodeDetailResponseBodyAgentWorkProcessArtifacts : TeaModel {
                /// <summary>
                /// <para>The registered artifact ID. This parameter may be empty for artifacts derived only from the result summary.</para>
                /// 
                /// <b>Example:</b>
                /// <para>artifact_example</para>
                /// </summary>
                [NameInMap("artifactId")]
                [Validation(Required=false)]
                public string ArtifactId { get; set; }

                /// <summary>
                /// <para>The unique key of the artifact in the node result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>amount_report</para>
                /// </summary>
                [NameInMap("artifactKey")]
                [Validation(Required=false)]
                public string ArtifactKey { get; set; }

                /// <summary>
                /// <para>The stable reference of the artifact, including kind, id, and url. The URL of a registered artifact is a re-authentication entry point and can be empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;kind&quot;:&quot;INLINE&quot;,&quot;id&quot;:&quot;amount_report&quot;,&quot;url&quot;:&quot;inline://amount_report&quot;}</para>
                /// </summary>
                [NameInMap("ref")]
                [Validation(Required=false)]
                public Dictionary<string, string> Ref { get; set; }

                /// <summary>
                /// <para>The artifact summary, excluding inline content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Signed amount statistics completed</para>
                /// </summary>
                [NameInMap("summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                /// <summary>
                /// <para>The display title of the artifact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Signed amount statistics report</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The artifact type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TEXT</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The replies: saved node work records and artifacts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("replies")]
            [Validation(Required=false)]
            public List<GetNodeDetailResponseBodyAgentWorkProcessReplies> Replies { get; set; }
            public class GetNodeDetailResponseBodyAgentWorkProcessReplies : TeaModel {
                /// <summary>
                /// <para>The record type. Valid values: THINK, REPLY, TOOL_CALL, SKILL_CALL, or ARTIFACT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>REPLY</para>
                /// </summary>
                [NameInMap("action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The saved original record content. Tool invocation and artifact metadata are JSON strings.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Data query for this turn completed</para>
                /// </summary>
                [NameInMap("detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                /// <summary>
                /// <para>The time taken for this work record, in milliseconds. The value is 0 for artifact records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1200</para>
                /// </summary>
                [NameInMap("duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                /// <summary>
                /// <para>The key of the parent node, not the conversation ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>query.amount</para>
                /// </summary>
                [NameInMap("nodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The time when the event is recorded, in ISO-8601 format. This is an empty string if the source record has no time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-10-14T08:00:00Z</para>
                /// </summary>
                [NameInMap("timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

            /// <summary>
            /// <para>The skill calls: saved node work records and artifacts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("skillCalls")]
            [Validation(Required=false)]
            public List<GetNodeDetailResponseBodyAgentWorkProcessSkillCalls> SkillCalls { get; set; }
            public class GetNodeDetailResponseBodyAgentWorkProcessSkillCalls : TeaModel {
                /// <summary>
                /// <para>The record type. Valid values: THINK, REPLY, TOOL_CALL, SKILL_CALL, or ARTIFACT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SKILL_CALL</para>
                /// </summary>
                [NameInMap("action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The saved original record content. Tool invocation and artifact metadata are JSON strings.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Data query for this turn completed</para>
                /// </summary>
                [NameInMap("detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                /// <summary>
                /// <para>The time taken for this work record, in milliseconds. The value is 0 for artifact records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1200</para>
                /// </summary>
                [NameInMap("duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                /// <summary>
                /// <para>The key of the parent node, not the conversation ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>query.amount</para>
                /// </summary>
                [NameInMap("nodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The time when the event is recorded, in ISO-8601 format. This is an empty string if the source record has no time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-10-14T08:00:00Z</para>
                /// </summary>
                [NameInMap("timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

            /// <summary>
            /// <para>The thoughts: saved node work records and artifacts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("thoughts")]
            [Validation(Required=false)]
            public List<GetNodeDetailResponseBodyAgentWorkProcessThoughts> Thoughts { get; set; }
            public class GetNodeDetailResponseBodyAgentWorkProcessThoughts : TeaModel {
                /// <summary>
                /// <para>The record type. Valid values: THINK, REPLY, TOOL_CALL, SKILL_CALL, or ARTIFACT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>THINK</para>
                /// </summary>
                [NameInMap("action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The saved original record content. Tool invocation and artifact metadata are JSON strings.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Data query for this turn completed</para>
                /// </summary>
                [NameInMap("detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                /// <summary>
                /// <para>The time taken for this work record, in milliseconds. The value is 0 for artifact records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1200</para>
                /// </summary>
                [NameInMap("duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                /// <summary>
                /// <para>The key of the parent node, not the conversation ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>query.amount</para>
                /// </summary>
                [NameInMap("nodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The time when the event is recorded, in ISO-8601 format. This is an empty string if the source record has no time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-10-14T08:00:00Z</para>
                /// </summary>
                [NameInMap("timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

            /// <summary>
            /// <para>The tool calls: saved node work records and artifacts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("toolCalls")]
            [Validation(Required=false)]
            public List<GetNodeDetailResponseBodyAgentWorkProcessToolCalls> ToolCalls { get; set; }
            public class GetNodeDetailResponseBodyAgentWorkProcessToolCalls : TeaModel {
                /// <summary>
                /// <para>The record type. Valid values: THINK, REPLY, TOOL_CALL, SKILL_CALL, or ARTIFACT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TOOL_CALL</para>
                /// </summary>
                [NameInMap("action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The saved original record content. Tool invocation and artifact metadata are JSON strings.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Data query for this turn completed</para>
                /// </summary>
                [NameInMap("detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                /// <summary>
                /// <para>The time taken for this work record, in milliseconds. The value is 0 for artifact records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1200</para>
                /// </summary>
                [NameInMap("duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                /// <summary>
                /// <para>The key of the parent node, not the conversation ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>query.amount</para>
                /// </summary>
                [NameInMap("nodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The time when the event is recorded, in ISO-8601 format. This is an empty string if the source record has no time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-10-14T08:00:00Z</para>
                /// </summary>
                [NameInMap("timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The artifacts: saved node work records and artifacts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("artifacts")]
        [Validation(Required=false)]
        public List<GetNodeDetailResponseBodyArtifacts> Artifacts { get; set; }
        public class GetNodeDetailResponseBodyArtifacts : TeaModel {
            /// <summary>
            /// <para>The registered artifact ID. This parameter may be empty for artifacts derived only from the result summary.</para>
            /// 
            /// <b>Example:</b>
            /// <para>artifact_example</para>
            /// </summary>
            [NameInMap("artifactId")]
            [Validation(Required=false)]
            public string ArtifactId { get; set; }

            /// <summary>
            /// <para>The unique key of the artifact in the node result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amount_report</para>
            /// </summary>
            [NameInMap("artifactKey")]
            [Validation(Required=false)]
            public string ArtifactKey { get; set; }

            /// <summary>
            /// <para>The stable reference of the artifact, including kind, id, and url. The URL of a registered artifact is a re-authentication entry point and can be empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;kind&quot;:&quot;INLINE&quot;,&quot;id&quot;:&quot;amount_report&quot;,&quot;url&quot;:&quot;inline://amount_report&quot;}</para>
            /// </summary>
            [NameInMap("ref")]
            [Validation(Required=false)]
            public Dictionary<string, string> Ref { get; set; }

            /// <summary>
            /// <para>The artifact summary, excluding inline content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Signed amount statistics completed</para>
            /// </summary>
            [NameInMap("summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <para>The display title of the artifact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Signed amount statistics report</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The artifact type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TEXT</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The sequence number of the node execution attempt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("attemptSeq")]
        [Validation(Required=false)]
        public long? AttemptSeq { get; set; }

        /// <summary>
        /// <para>The business status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The node conversation ID. This parameter is empty if no conversation is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>conversation_example</para>
        /// </summary>
        [NameInMap("conversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <para>Indicates whether the current node conversation can continue to receive input.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("conversationWritable")]
        [Validation(Required=false)]
        public bool? ConversationWritable { get; set; }

        /// <summary>
        /// <para>The display name of the node owner. This parameter is empty if the owner is unknown.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Digital worker</para>
        /// </summary>
        [NameInMap("handler")]
        [Validation(Required=false)]
        public string Handler { get; set; }

        /// <summary>
        /// <para>The error description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The requested resource does not exist</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The node key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>query.amount</para>
        /// </summary>
        [NameInMap("nodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The display name of the node, which shares the same source as the node list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Query signed amount</para>
        /// </summary>
        [NameInMap("nodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// <para>The node type. The actual enum value is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AGENT</para>
        /// </summary>
        [NameInMap("nodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// <para>The request tracking ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The node result summary, excluding inline content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public Dictionary<string, object> Result { get; set; }

        /// <summary>
        /// <para>Indicates whether there are pending follow-up turns to be dispatched.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("resumePending")]
        [Validation(Required=false)]
        public bool? ResumePending { get; set; }

        /// <summary>
        /// <para>The run log: saved node work records and artifacts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("runLog")]
        [Validation(Required=false)]
        public List<GetNodeDetailResponseBodyRunLog> RunLog { get; set; }
        public class GetNodeDetailResponseBodyRunLog : TeaModel {
            /// <summary>
            /// <para>The record type. Valid values: THINK, REPLY, TOOL_CALL, SKILL_CALL, or ARTIFACT.</para>
            /// 
            /// <b>Example:</b>
            /// <para>REPLY</para>
            /// </summary>
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The saved original record content. Tool invocation and artifact metadata are JSON strings.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Data query for this turn completed</para>
            /// </summary>
            [NameInMap("detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <para>The time taken for this work record, in milliseconds. The value is 0 for artifact records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1200</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>The key of the parent node, not the conversation ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>query.amount</para>
            /// </summary>
            [NameInMap("nodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The time when the event is recorded, in ISO-8601 format. This is an empty string if the source record has no time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-14T08:00:00Z</para>
            /// </summary>
            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

        }

        /// <summary>
        /// <para>stateVersion</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("stateVersion")]
        [Validation(Required=false)]
        public long? StateVersion { get; set; }

        /// <summary>
        /// <para>The node running status. The actual enum value is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of to-do IDs associated with the current node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("todoIds")]
        [Validation(Required=false)]
        public List<string> TodoIds { get; set; }

        /// <summary>
        /// <para>The sequence number of the conversation turn in the current attempt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("turnSeq")]
        [Validation(Required=false)]
        public long? TurnSeq { get; set; }

        /// <summary>
        /// <para>The reason why the node is waiting. This parameter is empty if the node is not waiting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HUMAN_INPUT</para>
        /// </summary>
        [NameInMap("waitType")]
        [Validation(Required=false)]
        public string WaitType { get; set; }

    }

}
