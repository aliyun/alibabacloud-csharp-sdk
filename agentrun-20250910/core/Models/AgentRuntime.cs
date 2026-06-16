// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class AgentRuntime : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the agent runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:agentrun:cn-hangzhou:1760720386195983:runtimes/7a1b6d39-9f8f-4ce2-b9c9-6db1b0b9e169</para>
        /// </summary>
        [NameInMap("agentRuntimeArn")]
        [Validation(Required=false)]
        public string AgentRuntimeArn { get; set; }

        /// <summary>
        /// <para>The unique identifier of the agent runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ar-1234567890abcdef</para>
        /// </summary>
        [NameInMap("agentRuntimeId")]
        [Validation(Required=false)]
        public string AgentRuntimeId { get; set; }

        /// <summary>
        /// <para>The name of the agent runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-agent-runtime</para>
        /// </summary>
        [NameInMap("agentRuntimeName")]
        [Validation(Required=false)]
        public string AgentRuntimeName { get; set; }

        /// <summary>
        /// <para>The version number of the agent runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("agentRuntimeVersion")]
        [Validation(Required=false)]
        public string AgentRuntimeVersion { get; set; }

        /// <summary>
        /// <para>The deployment type of the agent runtime. Valid values: <c>Code</c> and <c>Container</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Code</para>
        /// </summary>
        [NameInMap("artifactType")]
        [Validation(Required=false)]
        public string ArtifactType { get; set; }

        /// <summary>
        /// <para>The code configuration details. This parameter is applicable when <c>artifactType</c> is set to <c>Code</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("codeConfiguration")]
        [Validation(Required=false)]
        public CodeConfiguration CodeConfiguration { get; set; }

        /// <summary>
        /// <para>The container configuration details. This parameter is applicable when <c>artifactType</c> is set to <c>Container</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("containerConfiguration")]
        [Validation(Required=false)]
        public ContainerConfiguration ContainerConfiguration { get; set; }

        /// <summary>
        /// <para>The amount of CPU allocated to the agent runtime, in vCPUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// <para>The creation time of the agent runtime, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-10T10:30:00Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The name of the credential used to authenticate requests to the agent runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-credential</para>
        /// </summary>
        [NameInMap("credentialName")]
        [Validation(Required=false)]
        public string CredentialName { get; set; }

        /// <summary>
        /// <para>The description of the agent runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AI agent runtime for customer service automation</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable on-demand elasticity. Default: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("disableOndemand")]
        [Validation(Required=false)]
        public bool? DisableOndemand { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable session affinity. Default: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("disableSessionAffinity")]
        [Validation(Required=false)]
        public bool? DisableSessionAffinity { get; set; }

        /// <summary>
        /// <para>The disk size.</para>
        /// </summary>
        [NameInMap("diskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        /// <summary>
        /// <para>The edition of the agent runtime.</para>
        /// </summary>
        [NameInMap("edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable session isolation. If enabled, each session runs in an isolated environment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enableSessionIsolation")]
        [Validation(Required=false)]
        public bool? EnableSessionIsolation { get; set; }

        /// <summary>
        /// <para>The environment variables for the agent runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENV_VAR1=value1,ENV_VAR2=value2</para>
        /// </summary>
        [NameInMap("environmentVariables")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// <para>The ARN of the execution role that grants the agent runtime permission to access cloud services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1760720386195983:role/AgentRunExecutionRole</para>
        /// </summary>
        [NameInMap("executionRoleArn")]
        [Validation(Required=false)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// <para>The endpoint URL of an externally deployed agent service.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://external-agent.example.com/api">https://external-agent.example.com/api</a></para>
        /// </summary>
        [NameInMap("externalAgentEndpointUrl")]
        [Validation(Required=false)]
        public string ExternalAgentEndpointUrl { get; set; }

        /// <summary>
        /// <para>The name of the request header used for session affinity when <c>sessionAffinityType</c> is <c>HEADER_FIELD</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>x-agentrun-session-id</para>
        /// </summary>
        [NameInMap("headerFieldName")]
        [Validation(Required=false)]
        public string HeaderFieldName { get; set; }

        /// <summary>
        /// <para>The health check configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("healthCheckConfiguration")]
        [Validation(Required=false)]
        public HealthCheckConfiguration HealthCheckConfiguration { get; set; }

        /// <summary>
        /// <para>The last update time of the agent runtime, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-10T11:45:00Z</para>
        /// </summary>
        [NameInMap("lastUpdatedAt")]
        [Validation(Required=false)]
        public string LastUpdatedAt { get; set; }

        /// <summary>
        /// <para>The Log Service configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("logConfiguration")]
        [Validation(Required=false)]
        public LogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// <para>The amount of memory allocated to the agent runtime, in MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>The NAS file system configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("nasConfig")]
        [Validation(Required=false)]
        public NASConfig NasConfig { get; set; }

        /// <summary>
        /// <para>The network configuration of the agent runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("networkConfiguration")]
        [Validation(Required=false)]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// <para>The OSS bucket mount configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ossMountConfig")]
        [Validation(Required=false)]
        public OSSMountConfig OssMountConfig { get; set; }

        /// <summary>
        /// <para>The port on which the agent runtime listens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The communication protocol configuration for the agent runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("protocolConfiguration")]
        [Validation(Required=false)]
        public ProtocolConfiguration ProtocolConfiguration { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID of the resource group to which the agent runtime belongs.</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        [Obsolete]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The session affinity mode. Valid values: <c>NONE</c>, <c>HEADER_FIELD</c>, and <c>GENERATED_COOKIE</c>. <c>COOKIE</c> is a compatibility alias for <c>GENERATED_COOKIE</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GENERATED_COOKIE</para>
        /// </summary>
        [NameInMap("sessionAffinityType")]
        [Validation(Required=false)]
        public string SessionAffinityType { get; set; }

        /// <summary>
        /// <para>The maximum number of concurrent sessions allowed per runtime instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("sessionConcurrencyLimitPerInstance")]
        [Validation(Required=false)]
        public int? SessionConcurrencyLimitPerInstance { get; set; }

        /// <summary>
        /// <para>The idle timeout period for a session, in seconds. After this period of inactivity, the session expires and can no longer be used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("sessionIdleTimeoutSeconds")]
        [Validation(Required=false)]
        public int? SessionIdleTimeoutSeconds { get; set; }

        /// <summary>
        /// <para>The current status of the agent runtime. Possible values: <c>READY</c>, <c>CREATING</c>, and <c>FAILED</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>READY</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The reason for the current status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Runtime is ready for use</para>
        /// </summary>
        [NameInMap("statusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

        /// <summary>
        /// <para>The system tags for the agent runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system-tag-1,system-tag-2</para>
        /// </summary>
        [NameInMap("systemTags")]
        [Validation(Required=false)]
        public List<string> SystemTags { get; set; }

        /// <summary>
        /// <para>The ID of the workspace for the agent runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-1234567890abcdef</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
