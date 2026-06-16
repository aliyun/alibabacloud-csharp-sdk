// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateAgentRuntimeInput : TeaModel {
        /// <summary>
        /// <para>A unique name for the agent runtime.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-agent-runtime</para>
        /// </summary>
        [NameInMap("agentRuntimeName")]
        [Validation(Required=false)]
        public string AgentRuntimeName { get; set; }

        [NameInMap("armsConfiguration")]
        [Validation(Required=false)]
        public ArmsConfiguration ArmsConfiguration { get; set; }

        /// <summary>
        /// <para>The deployment type for the agent runtime. Valid values: Code and Container.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Code</para>
        /// </summary>
        [NameInMap("artifactType")]
        [Validation(Required=false)]
        public string ArtifactType { get; set; }

        /// <summary>
        /// <para>The code configuration, including the code source and entrypoint. This parameter is required when artifactType is Code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("codeConfiguration")]
        [Validation(Required=false)]
        public CodeConfiguration CodeConfiguration { get; set; }

        /// <summary>
        /// <para>The container configuration, including the image URL and startup command. This parameter is required when artifactType is Container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("containerConfiguration")]
        [Validation(Required=false)]
        public ContainerConfiguration ContainerConfiguration { get; set; }

        /// <summary>
        /// <para>The amount of CPU allocated to the agent runtime, in cores.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID of the credential used to authenticate with external services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cred-1234567890abcdef</para>
        /// </summary>
        [NameInMap("credentialId")]
        [Validation(Required=false)]
        [Obsolete]
        public string CredentialId { get; set; }

        /// <summary>
        /// <para>The name of the credential used to access the agent runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-credential</para>
        /// </summary>
        [NameInMap("credentialName")]
        [Validation(Required=false)]
        public string CredentialName { get; set; }

        /// <summary>
        /// <para>A description of the agent runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AI agent runtime for customer service automation</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable on-demand elasticity. By default, on-demand elasticity is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("disableOndemand")]
        [Validation(Required=false)]
        public bool? DisableOndemand { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable session affinity. By default, session affinity is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("disableSessionAffinity")]
        [Validation(Required=false)]
        public bool? DisableSessionAffinity { get; set; }

        /// <summary>
        /// <para>The disk size allocated to the agent runtime.</para>
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
        /// <para>A key-value map of environment variables to set for the agent runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENV_VAR1=value1,ENV_VAR2=value2</para>
        /// </summary>
        [NameInMap("environmentVariables")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// <para>The ARN of the execution role that the agent runtime uses to access cloud services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1760720386195983:role/AgentRunExecutionRole</para>
        /// </summary>
        [NameInMap("executionRoleArn")]
        [Validation(Required=false)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// <para>The endpoint URL of an external agent service.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://external-agent.example.com/api">https://external-agent.example.com/api</a></para>
        /// </summary>
        [NameInMap("externalAgentEndpointUrl")]
        [Validation(Required=false)]
        public string ExternalAgentEndpointUrl { get; set; }

        /// <summary>
        /// <para>The name of the request header used for session affinity when sessionAffinityType is HEADER_FIELD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>x-agentrun-session-id</para>
        /// </summary>
        [NameInMap("headerFieldName")]
        [Validation(Required=false)]
        public string HeaderFieldName { get; set; }

        /// <summary>
        /// <para>The health check configuration for the agent runtime, used to monitor the health of its instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("healthCheckConfiguration")]
        [Validation(Required=false)]
        public HealthCheckConfiguration HealthCheckConfiguration { get; set; }

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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>The configuration for mounting a NAS file system to the agent runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("nasConfig")]
        [Validation(Required=false)]
        public NASConfig NasConfig { get; set; }

        /// <summary>
        /// <para>The network configuration for the agent runtime, including VPC and security group settings.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("networkConfiguration")]
        [Validation(Required=false)]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// <para>The configuration for mounting an OSS bucket to the agent runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ossMountConfig")]
        [Validation(Required=false)]
        public OSSMountConfig OssMountConfig { get; set; }

        /// <summary>
        /// <para>The port on which the agent runtime listens for external requests.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>The ID of the resource group for the agent runtime.</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        [Obsolete]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The session affinity mode. NONE disables session affinity. HEADER_FIELD enables session affinity based on a request header. GENERATED_COOKIE uses a service-generated cookie to maintain session affinity. COOKIE is a compatibility alias that the server normalizes to GENERATED_COOKIE.</para>
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
        /// <para>The time in seconds that a session can remain idle before it expires and is terminated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("sessionIdleTimeoutSeconds")]
        [Validation(Required=false)]
        public int? SessionIdleTimeoutSeconds { get; set; }

        /// <summary>
        /// <para>The system tags for the agent runtime, used for system-level resource classification and management.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system-tag-1,system-tag-2</para>
        /// </summary>
        [NameInMap("systemTags")]
        [Validation(Required=false)]
        public List<string> SystemTags { get; set; }

        /// <summary>
        /// <para>The ID of the workspace for the agent runtime, used for resource isolation and access control.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-1234567890abcdef</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
