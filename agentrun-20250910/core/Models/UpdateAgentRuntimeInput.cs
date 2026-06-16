// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateAgentRuntimeInput : TeaModel {
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
        /// <para>应用实时监控服务（ARMS）的配置信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("armsConfiguration")]
        [Validation(Required=false)]
        public ArmsConfiguration ArmsConfiguration { get; set; }

        /// <summary>
        /// <para>The artifact type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Code</para>
        /// </summary>
        [NameInMap("artifactType")]
        [Validation(Required=false)]
        public string ArtifactType { get; set; }

        /// <summary>
        /// <para>The code configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("codeConfiguration")]
        [Validation(Required=false)]
        public CodeConfiguration CodeConfiguration { get; set; }

        /// <summary>
        /// <para>The container configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("containerConfiguration")]
        [Validation(Required=false)]
        public ContainerConfiguration ContainerConfiguration { get; set; }

        /// <summary>
        /// <para>The number of CPU cores.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// <para>The name of the credential that the agent runtime uses to authenticate requests.</para>
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
        /// <para>更新后的智能体运行时描述</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable on-demand elasticity. Set to true to disable. Default: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("disableOndemand")]
        [Validation(Required=false)]
        public bool? DisableOndemand { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable session affinity. Set to true to disable. Default: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("disableSessionAffinity")]
        [Validation(Required=false)]
        public bool? DisableSessionAffinity { get; set; }

        /// <summary>
        /// <para>The disk size in gigabytes (GB).</para>
        /// </summary>
        [NameInMap("diskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

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
        /// <para>Environment variables for the agent runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENV_VAR1=value1,ENV_VAR2=value2</para>
        /// </summary>
        [NameInMap("environmentVariables")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// <para>The execution role ARN that grants the agent runtime permissions to access cloud services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1760720386195983:role/AgentRunExecutionRole</para>
        /// </summary>
        [NameInMap("executionRoleArn")]
        [Validation(Required=false)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// <para>The endpoint URL for an externally registered agent. The platform uses this URL to connect to an agent service deployed outside the platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://external-agent.example.com/api">https://external-agent.example.com/api</a></para>
        /// </summary>
        [NameInMap("externalAgentEndpointUrl")]
        [Validation(Required=false)]
        public string ExternalAgentEndpointUrl { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a best-effort eviction of active Function Compute (FC) sessions when the configuration is updated. This helps the new settings take effect faster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("forceEvictInstances")]
        [Validation(Required=false)]
        public bool? ForceEvictInstances { get; set; }

        /// <summary>
        /// <para>The name of the request header used for session affinity when sessionAffinityType is set to &quot;HEADER_FIELD&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>x-agentrun-session-id</para>
        /// </summary>
        [NameInMap("headerFieldName")]
        [Validation(Required=false)]
        public string HeaderFieldName { get; set; }

        /// <summary>
        /// <para>The health check configuration for monitoring the health of agent runtime instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("healthCheckConfiguration")]
        [Validation(Required=false)]
        public HealthCheckConfiguration HealthCheckConfiguration { get; set; }

        /// <summary>
        /// <para>The configuration for Simple Log Service (SLS).</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("logConfiguration")]
        [Validation(Required=false)]
        public LogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// <para>The amount of memory in megabytes (MB).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>Configuration for mounting a NAS file system to the agent runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("nasConfig")]
        [Validation(Required=false)]
        public NASConfig NasConfig { get; set; }

        /// <summary>
        /// <para>The network configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("networkConfiguration")]
        [Validation(Required=false)]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// <para>Configuration for mounting an OSS bucket to the agent runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ossMountConfig")]
        [Validation(Required=false)]
        public OSSMountConfig OssMountConfig { get; set; }

        /// <summary>
        /// <para>The port on which the agent service listens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The protocol configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("protocolConfiguration")]
        [Validation(Required=false)]
        public ProtocolConfiguration ProtocolConfiguration { get; set; }

        /// <summary>
        /// <para>The session affinity mode. Valid values: NONE (disables session affinity), HEADER_FIELD (routes requests based on a request header), and GENERATED_COOKIE (routes requests using a cookie generated by Function Compute (FC)). The value COOKIE is an alias for GENERATED_COOKIE.</para>
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
        /// <para>The idle timeout for a session, in seconds. If an instance remains idle longer than this timeout after receiving no requests, the session expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("sessionIdleTimeoutSeconds")]
        [Validation(Required=false)]
        public int? SessionIdleTimeoutSeconds { get; set; }

        /// <summary>
        /// <para>The system tags for the agent runtime, used for resource classification and management.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system-tag-1,system-tag-2</para>
        /// </summary>
        [NameInMap("systemTags")]
        [Validation(Required=false)]
        public List<string> SystemTags { get; set; }

        /// <summary>
        /// <para>The ID of the workspace.</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
