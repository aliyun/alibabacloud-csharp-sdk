// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateTemplateInput : TeaModel {
        /// <summary>
        /// <para>Specifies whether the data link is allowed to invoke APIs to create, stop, or delete sandboxes</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("allowAnonymousManage")]
        [Validation(Required=false)]
        public bool? AllowAnonymousManage { get; set; }

        /// <summary>
        /// <para>Configuration information for Application Real-Time Monitoring Service (ARMS)</para>
        /// </summary>
        [NameInMap("armsConfiguration")]
        [Validation(Required=false)]
        public ArmsConfiguration ArmsConfiguration { get; set; }

        /// <summary>
        /// <para>Container configuration (built-in and immutable)</para>
        /// </summary>
        [NameInMap("containerConfiguration")]
        [Validation(Required=false)]
        public ContainerConfiguration ContainerConfiguration { get; set; }

        /// <summary>
        /// <para>CPU resource configuration (unit: core)</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// <para>Credential configuration</para>
        /// </summary>
        [NameInMap("credentialConfiguration")]
        [Validation(Required=false)]
        public CredentialConfiguration CredentialConfiguration { get; set; }

        /// <summary>
        /// <para>Template description</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Sandbox Agent toggle</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAgent")]
        [Validation(Required=false)]
        public bool? EnableAgent { get; set; }

        [NameInMap("enablePreStop")]
        [Validation(Required=false)]
        public bool? EnablePreStop { get; set; }

        /// <summary>
        /// <para>Environment variables</para>
        /// </summary>
        [NameInMap("environmentVariables")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// <para>Execution role ARN</para>
        /// 
        /// <b>Example:</b>
        /// <para>arn:acs:agentrun:cn-hangzhou:123456789:xxx/test</para>
        /// </summary>
        [NameInMap("executionRoleArn")]
        [Validation(Required=false)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// <para>Log configuration</para>
        /// </summary>
        [NameInMap("logConfiguration")]
        [Validation(Required=false)]
        public LogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// <para>Memory resource configuration (unit: MB)</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
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
        /// <para>OSS mount configuration</para>
        /// </summary>
        [NameInMap("ossConfiguration")]
        [Validation(Required=false)]
        public List<OssConfiguration> OssConfiguration { get; set; }

        [NameInMap("preStopTimeoutInSeconds")]
        [Validation(Required=false)]
        public int? PreStopTimeoutInSeconds { get; set; }

        /// <summary>
        /// <para>Sandbox idle timeout (seconds)</para>
        /// 
        /// <b>Example:</b>
        /// <para>21600</para>
        /// </summary>
        [NameInMap("sandboxIdleTimeoutInSeconds")]
        [Validation(Required=false)]
        public int? SandboxIdleTimeoutInSeconds { get; set; }

        /// <summary>
        /// <para>Sandbox time to live (seconds)</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("sandboxTTLInSeconds")]
        [Validation(Required=false)]
        public int? SandboxTTLInSeconds { get; set; }

        /// <summary>
        /// <para>Elasticity configuration</para>
        /// </summary>
        [NameInMap("scalingConfig")]
        [Validation(Required=false)]
        public ScalingConfig ScalingConfig { get; set; }

        /// <summary>
        /// <para>Template configuration (a flexible object structure that varies based on templateType)</para>
        /// </summary>
        [NameInMap("templateConfiguration")]
        [Validation(Required=false)]
        public Dictionary<string, object> TemplateConfiguration { get; set; }

        /// <summary>
        /// <para>Associated Space ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-1234567890abcdef</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
