// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class Template : TeaModel {
        /// <summary>
        /// <para>Indicates whether the data link can invoke APIs to create, stop, or delete sandbox instances</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("allowAnonymousManage")]
        [Validation(Required=false)]
        public bool? AllowAnonymousManage { get; set; }

        /// <summary>
        /// <para>Custom image configuration</para>
        /// </summary>
        [NameInMap("containerConfiguration")]
        [Validation(Required=false)]
        public ContainerConfiguration ContainerConfiguration { get; set; }

        /// <summary>
        /// <para>Number of CPU cores</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// <para>Creation Time</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-15T17:12:59.375168+08:00</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>Authentication configuration</para>
        /// </summary>
        [NameInMap("credentialConfiguration")]
        [Validation(Required=false)]
        public CredentialConfiguration CredentialConfiguration { get; set; }

        /// <summary>
        /// <para>Description</para>
        /// 
        /// <b>Example:</b>
        /// <para>template描述</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Disk size</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("diskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        /// <summary>
        /// <para>Sandbox Agent Toggle</para>
        /// </summary>
        [NameInMap("enableAgent")]
        [Validation(Required=false)]
        public bool? EnableAgent { get; set; }

        [NameInMap("enablePreStop")]
        [Validation(Required=false)]
        public bool? EnablePreStop { get; set; }

        /// <summary>
        /// <para>Environment variable configuration for the agent runtime</para>
        /// </summary>
        [NameInMap("environmentVariables")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// <para>Execution role</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:agentrun:cn-hangzhou:12345678:templates/efb6de2f-1814-42a2-b7f3-474a0e0b3a48</para>
        /// </summary>
        [NameInMap("executionRoleArn")]
        [Validation(Required=false)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// <para>Update Time</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-15T17:12:59.375168+08:00</para>
        /// </summary>
        [NameInMap("lastUpdatedAt")]
        [Validation(Required=false)]
        public string LastUpdatedAt { get; set; }

        /// <summary>
        /// <para>Log configuration</para>
        /// </summary>
        [NameInMap("logConfiguration")]
        [Validation(Required=false)]
        public LogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// <para>MCP options</para>
        /// </summary>
        [NameInMap("mcpOptions")]
        [Validation(Required=false)]
        public TemplateMcpOptions McpOptions { get; set; }
        public class TemplateMcpOptions : TeaModel {
            /// <summary>
            /// <para>List of enabled tools</para>
            /// </summary>
            [NameInMap("enabledTools")]
            [Validation(Required=false)]
            public List<string> EnabledTools { get; set; }

            /// <summary>
            /// <para>Transport type</para>
            /// 
            /// <b>Example:</b>
            /// <para>streamable-http</para>
            /// </summary>
            [NameInMap("transport")]
            [Validation(Required=false)]
            public string Transport { get; set; }

        }

        /// <summary>
        /// <para>MCP server status</para>
        /// </summary>
        [NameInMap("mcpState")]
        [Validation(Required=false)]
        public TemplateMcpState McpState { get; set; }
        public class TemplateMcpState : TeaModel {
            /// <summary>
            /// <para>Access Endpoint</para>
            /// 
            /// <b>Example:</b>
            /// <para>/mcp</para>
            /// </summary>
            [NameInMap("accessEndpoint")]
            [Validation(Required=false)]
            public string AccessEndpoint { get; set; }

            /// <summary>
            /// <para>MCP Status</para>
            /// 
            /// <b>Example:</b>
            /// <para>CREATING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Status reason</para>
            /// 
            /// <b>Example:</b>
            /// <para>SDK Error</para>
            /// </summary>
            [NameInMap("statusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

        }

        /// <summary>
        /// <para>Memory specification</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4096</para>
        /// </summary>
        [NameInMap("memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>NAS mount configuration item</para>
        /// </summary>
        [NameInMap("nasConfig")]
        [Validation(Required=false)]
        public NASConfig NasConfig { get; set; }

        /// <summary>
        /// <para>Network configuration</para>
        /// </summary>
        [NameInMap("networkConfiguration")]
        [Validation(Required=false)]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// <para>OSS configuration</para>
        /// </summary>
        [NameInMap("ossConfiguration")]
        [Validation(Required=false)]
        public List<OssConfiguration> OssConfiguration { get; set; }

        [NameInMap("preStopTimeoutInSeconds")]
        [Validation(Required=false)]
        public int? PreStopTimeoutInSeconds { get; set; }

        /// <summary>
        /// <para>Resource Name</para>
        /// 
        /// <b>Example:</b>
        /// <para>agentrun-f2570dd4-c8a2-452c-8bd5-4ef74b0a69b5</para>
        /// </summary>
        [NameInMap("resourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>Sandbox idle timeout</para>
        /// 
        /// <b>Example:</b>
        /// <para>1800</para>
        /// </summary>
        [NameInMap("sandboxIdleTimeoutInSeconds")]
        [Validation(Required=false)]
        public string SandboxIdleTimeoutInSeconds { get; set; }

        /// <summary>
        /// <para>Sandbox lifecycle time to live (deprecated)</para>
        /// 
        /// <b>Example:</b>
        /// <para>已弃用</para>
        /// </summary>
        [NameInMap("sandboxTTLInSeconds")]
        [Validation(Required=false)]
        public string SandboxTTLInSeconds { get; set; }

        /// <summary>
        /// <para>Elasticity Status</para>
        /// </summary>
        [NameInMap("scalingStatus")]
        [Validation(Required=false)]
        public ScalingStatus ScalingStatus { get; set; }

        /// <summary>
        /// <para>Status</para>
        /// 
        /// <b>Example:</b>
        /// <para>READY</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Status reason</para>
        /// 
        /// <b>Example:</b>
        /// <para>SDK Error</para>
        /// </summary>
        [NameInMap("statusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

        /// <summary>
        /// <para>Template ARN</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:agentrun:cn-hangzhou:12345678:templates/efb6de2f-1814-42a2-b7f3-474a0e0b3a48</para>
        /// </summary>
        [NameInMap("templateArn")]
        [Validation(Required=false)]
        public string TemplateArn { get; set; }

        /// <summary>
        /// <para>Template Configuration (flexible object structure that varies based on templateType)</para>
        /// </summary>
        [NameInMap("templateConfiguration")]
        [Validation(Required=false)]
        public Dictionary<string, object> TemplateConfiguration { get; set; }

        /// <summary>
        /// <para>Template ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>996ffd5e-003f-4700-9f24-9e2a1c19019b.schema</para>
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>Template Name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>browser-1767874121726</para>
        /// </summary>
        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>templatetype</para>
        /// 
        /// <b>Example:</b>
        /// <para>Browser</para>
        /// </summary>
        [NameInMap("templateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        /// <summary>
        /// <para>Template Version</para>
        /// 
        /// <b>Example:</b>
        /// <para>预留</para>
        /// </summary>
        [NameInMap("templateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// <para>Associated Space ID</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
