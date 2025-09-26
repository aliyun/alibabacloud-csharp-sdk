// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class AgentRuntime : TeaModel {
        /// <summary>
        /// <para>智能体运行时的全局唯一资源名称</para>
        /// </summary>
        [NameInMap("agentRuntimeArn")]
        [Validation(Required=false)]
        public string AgentRuntimeArn { get; set; }

        /// <summary>
        /// <para>智能体运行时的唯一标识符</para>
        /// </summary>
        [NameInMap("agentRuntimeId")]
        [Validation(Required=false)]
        public string AgentRuntimeId { get; set; }

        /// <summary>
        /// <para>智能体运行时的名称，用于标识和区分不同的运行时实例</para>
        /// </summary>
        [NameInMap("agentRuntimeName")]
        [Validation(Required=false)]
        public string AgentRuntimeName { get; set; }

        /// <summary>
        /// <para>智能体运行时的版本号，用于版本管理和回滚</para>
        /// </summary>
        [NameInMap("agentRuntimeVersion")]
        [Validation(Required=false)]
        public string AgentRuntimeVersion { get; set; }

        /// <summary>
        /// <para>智能体运行时的部署类型，支持Code（代码模式）和Container（容器模式）</para>
        /// </summary>
        [NameInMap("artifactType")]
        [Validation(Required=false)]
        public string ArtifactType { get; set; }

        /// <summary>
        /// <para>当artifactType为Code时的代码配置信息</para>
        /// </summary>
        [NameInMap("codeConfiguration")]
        [Validation(Required=false)]
        public CodeConfiguration CodeConfiguration { get; set; }

        /// <summary>
        /// <para>当artifactType为Container时的容器配置信息</para>
        /// </summary>
        [NameInMap("containerConfiguration")]
        [Validation(Required=false)]
        public ContainerConfiguration ContainerConfiguration { get; set; }

        /// <summary>
        /// <para>智能体运行时分配的CPU资源，单位为核数</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// <para>智能体运行时的创建时间，采用ISO 8601格式</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>智能体运行时的描述信息，说明该运行时的用途和功能</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>智能体运行时的环境变量配置</para>
        /// </summary>
        [NameInMap("environmentVariables")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// <para>为智能体运行时提供访问云服务权限的执行角色ARN</para>
        /// </summary>
        [NameInMap("executionRoleArn")]
        [Validation(Required=false)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// <para>智能体运行时的健康检查配置，用于监控运行时实例的健康状态</para>
        /// </summary>
        [NameInMap("healthCheckConfiguration")]
        [Validation(Required=false)]
        public HealthCheckConfiguration HealthCheckConfiguration { get; set; }

        /// <summary>
        /// <para>智能体运行时最后一次更新的时间，采用ISO 8601格式</para>
        /// </summary>
        [NameInMap("lastUpdatedAt")]
        [Validation(Required=false)]
        public string LastUpdatedAt { get; set; }

        /// <summary>
        /// <para>SLS（简单日志服务）配置</para>
        /// </summary>
        [NameInMap("logConfiguration")]
        [Validation(Required=false)]
        public LogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// <para>智能体运行时分配的内存资源，单位为MB</para>
        /// </summary>
        [NameInMap("memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>智能体运行时的网络配置信息</para>
        /// </summary>
        [NameInMap("networkConfiguration")]
        [Validation(Required=false)]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// <para>智能体运行时监听的端口号</para>
        /// </summary>
        [NameInMap("port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>智能体运行时的通信协议配置</para>
        /// </summary>
        [NameInMap("protocolConfiguration")]
        [Validation(Required=false)]
        public ProtocolConfiguration ProtocolConfiguration { get; set; }

        /// <summary>
        /// <para>每个运行时实例允许的最大并发会话数</para>
        /// </summary>
        [NameInMap("sessionConcurrencyLimitPerInstance")]
        [Validation(Required=false)]
        public int? SessionConcurrencyLimitPerInstance { get; set; }

        /// <summary>
        /// <para>会话的空闲超时时间，单位为秒。实例没有会话请求后处于空闲状态，空闲态为闲置计费模式，超过此超时时间后会话自动过期，不可继续使用</para>
        /// </summary>
        [NameInMap("sessionIdleTimeoutSeconds")]
        [Validation(Required=false)]
        public int? SessionIdleTimeoutSeconds { get; set; }

        /// <summary>
        /// <para>智能体运行时的当前状态，如READY（就绪）、CREATING（创建中）、FAILED（失败）等</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>当前状态的原因说明（如适用）</para>
        /// </summary>
        [NameInMap("statusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

    }

}
