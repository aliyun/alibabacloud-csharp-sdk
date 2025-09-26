// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateAgentRuntimeInput : TeaModel {
        [NameInMap("agentRuntimeName")]
        [Validation(Required=false)]
        public string AgentRuntimeName { get; set; }

        [NameInMap("artifactType")]
        [Validation(Required=false)]
        public string ArtifactType { get; set; }

        [NameInMap("codeConfiguration")]
        [Validation(Required=false)]
        public CodeConfiguration CodeConfiguration { get; set; }

        [NameInMap("containerConfiguration")]
        [Validation(Required=false)]
        public ContainerConfiguration ContainerConfiguration { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

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
        /// <para>SLS（简单日志服务）配置</para>
        /// </summary>
        [NameInMap("logConfiguration")]
        [Validation(Required=false)]
        public LogConfiguration LogConfiguration { get; set; }

        [NameInMap("memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        [NameInMap("networkConfiguration")]
        [Validation(Required=false)]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        [NameInMap("port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

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

    }

}
