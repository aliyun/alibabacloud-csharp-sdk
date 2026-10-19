// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetNodeDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>按思考、技能、工具、回复和产物分组的实际工作过程</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;thoughts&quot;:[],&quot;skillCalls&quot;:[],&quot;toolCalls&quot;:[],&quot;replies&quot;:[],&quot;artifacts&quot;:[]}</para>
        /// </summary>
        [NameInMap("agentWorkProcess")]
        [Validation(Required=false)]
        public GetNodeDetailResponseBodyAgentWorkProcess AgentWorkProcess { get; set; }
        public class GetNodeDetailResponseBodyAgentWorkProcess : TeaModel {
            /// <summary>
            /// <para>节点产物摘要与稳定引用，与顶层artifacts一致；无产物时为空列表</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("artifacts")]
            [Validation(Required=false)]
            public List<GetNodeDetailResponseBodyAgentWorkProcessArtifacts> Artifacts { get; set; }
            public class GetNodeDetailResponseBodyAgentWorkProcessArtifacts : TeaModel {
                /// <summary>
                /// <para>登记产物ID；仅来自结果摘要的产物可能为空</para>
                /// 
                /// <b>Example:</b>
                /// <para>artifact_example</para>
                /// </summary>
                [NameInMap("artifactId")]
                [Validation(Required=false)]
                public string ArtifactId { get; set; }

                /// <summary>
                /// <para>产物在节点结果中的唯一key</para>
                /// 
                /// <b>Example:</b>
                /// <para>amount_report</para>
                /// </summary>
                [NameInMap("artifactKey")]
                [Validation(Required=false)]
                public string ArtifactKey { get; set; }

                /// <summary>
                /// <para>产物稳定引用，包含kind、id、url；登记产物URL为重新鉴权入口，可为空</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;kind&quot;:&quot;INLINE&quot;,&quot;id&quot;:&quot;amount_report&quot;,&quot;url&quot;:&quot;inline://amount_report&quot;}</para>
                /// </summary>
                [NameInMap("ref")]
                [Validation(Required=false)]
                public Dictionary<string, string> Ref { get; set; }

                /// <summary>
                /// <para>产物摘要，不含inline正文</para>
                /// 
                /// <b>Example:</b>
                /// <para>已完成签单金额统计</para>
                /// </summary>
                [NameInMap("summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                /// <summary>
                /// <para>产物展示标题</para>
                /// 
                /// <b>Example:</b>
                /// <para>签单金额统计报告</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>产物类型</para>
                /// 
                /// <b>Example:</b>
                /// <para>TEXT</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>已保存的回复记录，action为REPLY；无记录时为空列表</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("replies")]
            [Validation(Required=false)]
            public List<GetNodeDetailResponseBodyAgentWorkProcessReplies> Replies { get; set; }
            public class GetNodeDetailResponseBodyAgentWorkProcessReplies : TeaModel {
                /// <summary>
                /// <para>记录类型：THINK、REPLY、TOOL_CALL、SKILL_CALL或ARTIFACT</para>
                /// 
                /// <b>Example:</b>
                /// <para>REPLY</para>
                /// </summary>
                [NameInMap("action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>已保存的原始记录内容；工具调用与产物元数据为JSON字符串</para>
                /// 
                /// <b>Example:</b>
                /// <para>已完成本轮数据查询</para>
                /// </summary>
                [NameInMap("detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                /// <summary>
                /// <para>该条工作记录耗时，单位毫秒；产物记录为0</para>
                /// 
                /// <b>Example:</b>
                /// <para>1200</para>
                /// </summary>
                [NameInMap("duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                /// <summary>
                /// <para>所属节点key（nodeKey），不是会话ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>query.amount</para>
                /// </summary>
                [NameInMap("nodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>记录事件时间，ISO-8601格式；源记录无时间时为空字符串</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-10-14T08:00:00Z</para>
                /// </summary>
                [NameInMap("timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

            /// <summary>
            /// <para>已保存的技能调用记录，action为SKILL_CALL；无记录时为空列表</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("skillCalls")]
            [Validation(Required=false)]
            public List<GetNodeDetailResponseBodyAgentWorkProcessSkillCalls> SkillCalls { get; set; }
            public class GetNodeDetailResponseBodyAgentWorkProcessSkillCalls : TeaModel {
                /// <summary>
                /// <para>记录类型：THINK、REPLY、TOOL_CALL、SKILL_CALL或ARTIFACT</para>
                /// 
                /// <b>Example:</b>
                /// <para>SKILL_CALL</para>
                /// </summary>
                [NameInMap("action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>已保存的原始记录内容；工具调用与产物元数据为JSON字符串</para>
                /// 
                /// <b>Example:</b>
                /// <para>已完成本轮数据查询</para>
                /// </summary>
                [NameInMap("detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                /// <summary>
                /// <para>该条工作记录耗时，单位毫秒；产物记录为0</para>
                /// 
                /// <b>Example:</b>
                /// <para>1200</para>
                /// </summary>
                [NameInMap("duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                /// <summary>
                /// <para>所属节点key（nodeKey），不是会话ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>query.amount</para>
                /// </summary>
                [NameInMap("nodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>记录事件时间，ISO-8601格式；源记录无时间时为空字符串</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-10-14T08:00:00Z</para>
                /// </summary>
                [NameInMap("timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

            /// <summary>
            /// <para>已保存的思考记录，action为THINK；无记录时为空列表</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("thoughts")]
            [Validation(Required=false)]
            public List<GetNodeDetailResponseBodyAgentWorkProcessThoughts> Thoughts { get; set; }
            public class GetNodeDetailResponseBodyAgentWorkProcessThoughts : TeaModel {
                /// <summary>
                /// <para>记录类型：THINK、REPLY、TOOL_CALL、SKILL_CALL或ARTIFACT</para>
                /// 
                /// <b>Example:</b>
                /// <para>THINK</para>
                /// </summary>
                [NameInMap("action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>已保存的原始记录内容；工具调用与产物元数据为JSON字符串</para>
                /// 
                /// <b>Example:</b>
                /// <para>已完成本轮数据查询</para>
                /// </summary>
                [NameInMap("detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                /// <summary>
                /// <para>该条工作记录耗时，单位毫秒；产物记录为0</para>
                /// 
                /// <b>Example:</b>
                /// <para>1200</para>
                /// </summary>
                [NameInMap("duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                /// <summary>
                /// <para>所属节点key（nodeKey），不是会话ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>query.amount</para>
                /// </summary>
                [NameInMap("nodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>记录事件时间，ISO-8601格式；源记录无时间时为空字符串</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-10-14T08:00:00Z</para>
                /// </summary>
                [NameInMap("timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

            /// <summary>
            /// <para>已保存的工具调用记录，action为TOOL_CALL；无记录时为空列表</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("toolCalls")]
            [Validation(Required=false)]
            public List<GetNodeDetailResponseBodyAgentWorkProcessToolCalls> ToolCalls { get; set; }
            public class GetNodeDetailResponseBodyAgentWorkProcessToolCalls : TeaModel {
                /// <summary>
                /// <para>记录类型：THINK、REPLY、TOOL_CALL、SKILL_CALL或ARTIFACT</para>
                /// 
                /// <b>Example:</b>
                /// <para>TOOL_CALL</para>
                /// </summary>
                [NameInMap("action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>已保存的原始记录内容；工具调用与产物元数据为JSON字符串</para>
                /// 
                /// <b>Example:</b>
                /// <para>已完成本轮数据查询</para>
                /// </summary>
                [NameInMap("detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                /// <summary>
                /// <para>该条工作记录耗时，单位毫秒；产物记录为0</para>
                /// 
                /// <b>Example:</b>
                /// <para>1200</para>
                /// </summary>
                [NameInMap("duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                /// <summary>
                /// <para>所属节点key（nodeKey），不是会话ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>query.amount</para>
                /// </summary>
                [NameInMap("nodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>记录事件时间，ISO-8601格式；源记录无时间时为空字符串</para>
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
        /// <para>已保存的节点产物摘要与稳定引用，不包含inline正文；无产物时为空列表</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("artifacts")]
        [Validation(Required=false)]
        public List<GetNodeDetailResponseBodyArtifacts> Artifacts { get; set; }
        public class GetNodeDetailResponseBodyArtifacts : TeaModel {
            /// <summary>
            /// <para>登记产物ID；仅来自结果摘要的产物可能为空</para>
            /// 
            /// <b>Example:</b>
            /// <para>artifact_example</para>
            /// </summary>
            [NameInMap("artifactId")]
            [Validation(Required=false)]
            public string ArtifactId { get; set; }

            /// <summary>
            /// <para>产物在节点结果中的唯一key</para>
            /// 
            /// <b>Example:</b>
            /// <para>amount_report</para>
            /// </summary>
            [NameInMap("artifactKey")]
            [Validation(Required=false)]
            public string ArtifactKey { get; set; }

            /// <summary>
            /// <para>产物稳定引用，包含kind、id、url；登记产物URL为重新鉴权入口，可为空</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;kind&quot;:&quot;INLINE&quot;,&quot;id&quot;:&quot;amount_report&quot;,&quot;url&quot;:&quot;inline://amount_report&quot;}</para>
            /// </summary>
            [NameInMap("ref")]
            [Validation(Required=false)]
            public Dictionary<string, string> Ref { get; set; }

            /// <summary>
            /// <para>产物摘要，不含inline正文</para>
            /// 
            /// <b>Example:</b>
            /// <para>已完成签单金额统计</para>
            /// </summary>
            [NameInMap("summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <para>产物展示标题</para>
            /// 
            /// <b>Example:</b>
            /// <para>签单金额统计报告</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>产物类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>TEXT</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>节点执行尝试序号</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("attemptSeq")]
        [Validation(Required=false)]
        public long? AttemptSeq { get; set; }

        /// <summary>
        /// <para>业务状态码；成功为200</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>节点会话ID，未创建时为空</para>
        /// 
        /// <b>Example:</b>
        /// <para>conversation_example</para>
        /// </summary>
        [NameInMap("conversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <para>当前节点会话是否可以继续输入</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("conversationWritable")]
        [Validation(Required=false)]
        public bool? ConversationWritable { get; set; }

        /// <summary>
        /// <para>节点负责人展示名称，未知时为空</para>
        /// 
        /// <b>Example:</b>
        /// <para>数字员工</para>
        /// </summary>
        [NameInMap("handler")]
        [Validation(Required=false)]
        public string Handler { get; set; }

        /// <summary>
        /// <para>错误描述</para>
        /// 
        /// <b>Example:</b>
        /// <para>请求的资源不存在</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>节点 key（nodeKey）</para>
        /// 
        /// <b>Example:</b>
        /// <para>query.amount</para>
        /// </summary>
        [NameInMap("nodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>节点展示名称，与节点列表同源</para>
        /// 
        /// <b>Example:</b>
        /// <para>查询签单金额</para>
        /// </summary>
        [NameInMap("nodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// <para>节点类型，返回实际枚举</para>
        /// 
        /// <b>Example:</b>
        /// <para>AGENT</para>
        /// </summary>
        [NameInMap("nodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// <para>请求追踪ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>节点结果摘要，不含inline正文</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public Dictionary<string, object> Result { get; set; }

        /// <summary>
        /// <para>是否有待派发续轮</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("resumePending")]
        [Validation(Required=false)]
        public bool? ResumePending { get; set; }

        /// <summary>
        /// <para>节点AI工作记录时间线，与GetAgentWorkLog同源，duration单位毫秒；无记录时为空列表</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("runLog")]
        [Validation(Required=false)]
        public List<GetNodeDetailResponseBodyRunLog> RunLog { get; set; }
        public class GetNodeDetailResponseBodyRunLog : TeaModel {
            /// <summary>
            /// <para>记录类型：THINK、REPLY、TOOL_CALL、SKILL_CALL或ARTIFACT</para>
            /// 
            /// <b>Example:</b>
            /// <para>REPLY</para>
            /// </summary>
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>已保存的原始记录内容；工具调用与产物元数据为JSON字符串</para>
            /// 
            /// <b>Example:</b>
            /// <para>已完成本轮数据查询</para>
            /// </summary>
            [NameInMap("detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <para>该条工作记录耗时，单位毫秒；产物记录为0</para>
            /// 
            /// <b>Example:</b>
            /// <para>1200</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>所属节点key（nodeKey），不是会话ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>query.amount</para>
            /// </summary>
            [NameInMap("nodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>记录事件时间，ISO-8601格式；源记录无时间时为空字符串</para>
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
        /// <para>节点运行状态，返回实际枚举</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>当前节点关联的待办ID列表，元素为待办ID字符串</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("todoIds")]
        [Validation(Required=false)]
        public List<string> TodoIds { get; set; }

        /// <summary>
        /// <para>当前尝试的对话轮序号</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("turnSeq")]
        [Validation(Required=false)]
        public long? TurnSeq { get; set; }

        /// <summary>
        /// <para>节点等待原因，未等待时为空</para>
        /// 
        /// <b>Example:</b>
        /// <para>HUMAN_INPUT</para>
        /// </summary>
        [NameInMap("waitType")]
        [Validation(Required=false)]
        public string WaitType { get; set; }

    }

}
