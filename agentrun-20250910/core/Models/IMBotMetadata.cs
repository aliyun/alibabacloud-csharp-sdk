// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class IMBotMetadata : TeaModel {
        /// <summary>
        /// <para>可选</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("agentRuntimeEndpointId")]
        [Validation(Required=false)]
        public string AgentRuntimeEndpointId { get; set; }

        /// <summary>
        /// <para>标准模式下必填：下游 Agent 可调用的 URL；custom 模式可省略</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("agentRuntimeEndpointUrl")]
        [Validation(Required=false)]
        public string AgentRuntimeEndpointUrl { get; set; }

        /// <summary>
        /// <para>绑定的 Agent Runtime UUID</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("agentRuntimeId")]
        [Validation(Required=false)]
        public string AgentRuntimeId { get; set; }

        /// <summary>
        /// <para>自定义函数元信息；可选；与后端 IMBotMetadata 持久化字段一致</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("customFunctionMeta")]
        [Validation(Required=false)]
        public string CustomFunctionMeta { get; set; }

        /// <summary>
        /// <para>标准模式下必填，与 ValidateAgentRuntimeProtocolTypeValue 一致（大小写敏感）；custom 模式可省略</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("protocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// <para>不写入单 Bot 持久化 JSON；用于首次/更新时设置租户级 FC RAM 执行角色 ARN（acs:ram::...）；FC 启用且非 custom 时按服务逻辑校验</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

    }

}
