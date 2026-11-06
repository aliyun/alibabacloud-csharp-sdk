// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateAgentVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>业务状态码，请求成功时为 SUCCESS，失败时为错误码。</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>已保存的智能体固定版本详情；重复提交命中已有版本时返回该已有版本。</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateAgentVersionResponseBodyData Data { get; set; }
        public class CreateAgentVersionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>版本所属的托管智能体或自定义智能体 ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent-0123456789abcdef0123456789abcdef</para>
            /// </summary>
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>系统按 Agent 递增生成的版本号，例如 v1、v2。查询、删除版本及服务端点引用版本时使用。</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("agentVersion")]
            [Validation(Required=false)]
            public string AgentVersion { get; set; }

            /// <summary>
            /// <para>仅表示版本模板与制品归档是否完整，不代表部署或运行状态。READY 为完整，INVALID 为归档缺失或不一致。</para>
            /// 
            /// <b>Example:</b>
            /// <para>READY</para>
            /// </summary>
            [NameInMap("artifactStatus")]
            [Validation(Required=false)]
            public string ArtifactStatus { get; set; }

            /// <summary>
            /// <para>托管智能体与 GetManagedAgent 的 data 结构一致，自定义智能体与 GetCustomAgent 的 data 结构一致，脱敏规则相同。</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;agentId&quot;:&quot;agent-0123456789abcdef0123456789abcdef&quot;,&quot;workspaceId&quot;:&quot;ws-0123456789abcdef01234&quot;,&quot;name&quot;:&quot;customer-service&quot;,&quot;description&quot;:&quot;客服智能体&quot;,&quot;status&quot;:&quot;Running&quot;,&quot;latestSpecVersion&quot;:2,&quot;instruction&quot;:&quot;你是一名客服助手。&quot;}</para>
            /// </summary>
            [NameInMap("configuration")]
            [Validation(Required=false)]
            public Dictionary<string, object> Configuration { get; set; }

            /// <summary>
            /// <para>版本保存的时间，采用 ISO 8601 UTC 格式。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-12T01:02:03Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>保存该版本的调用者阿里云账号 UID；RAM 用户调用时为其所属阿里云主账号 UID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890123456</para>
            /// </summary>
            [NameInMap("createdBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            /// <summary>
            /// <para>保存版本时填写的版本描述，最多 1024 个字符；保存时未填写则为空。</para>
            /// 
            /// <b>Example:</b>
            /// <para>生产环境稳定版本</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>保存版本时 Agent 已生效的发布流水号，即当时的 effectiveSpecVersion。版本保存后该值不再变化。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("targetSpecVersion")]
            [Validation(Required=false)]
            public long? TargetSpecVersion { get; set; }

            /// <summary>
            /// <para>保存版本时用户指定的展示名称。早期保存且未记录名称的版本返回 agentVersion。</para>
            /// 
            /// <b>Example:</b>
            /// <para>生产稳定版 V1.0</para>
            /// </summary>
            [NameInMap("versionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

            /// <summary>
            /// <para>版本所属智能体所在的 AgentCore 工作空间 ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-0123456789abcdef01234</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>HTTP 状态码。</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>响应消息，请求成功时为 success，失败时为错误信息。</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>请求 ID，用于定位和排查请求。</para>
        /// 
        /// <b>Example:</b>
        /// <para>5E8F3C2A-1B4D-4F6E-9A7C-0D2B8E6F4A1C</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>请求是否成功。</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
