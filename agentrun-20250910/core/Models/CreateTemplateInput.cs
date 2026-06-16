// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateTemplateInput : TeaModel {
        /// <summary>
        /// <para>Controls whether data plane calls can create, stop, or delete the sandbox.</para>
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
        /// <para>The Application Real-Time Monitoring Service (ARMS) configuration.</para>
        /// </summary>
        [NameInMap("armsConfiguration")]
        [Validation(Required=false)]
        public ArmsConfiguration ArmsConfiguration { get; set; }

        /// <summary>
        /// <para>The container configuration. You can only use images based on the Browser or Code Interpreter base images.</para>
        /// </summary>
        [NameInMap("containerConfiguration")]
        [Validation(Required=false)]
        public ContainerConfiguration ContainerConfiguration { get; set; }

        /// <summary>
        /// <para>The number of CPU cores.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// <para>The credential configuration.</para>
        /// </summary>
        [NameInMap("credentialConfiguration")]
        [Validation(Required=false)]
        public CredentialConfiguration CredentialConfiguration { get; set; }

        /// <summary>
        /// <para>The template description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>模板描述</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The disk size in MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("diskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        /// <summary>
        /// <para>Controls whether to enable the Sandbox Agent.</para>
        /// </summary>
        [NameInMap("enableAgent")]
        [Validation(Required=false)]
        public bool? EnableAgent { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the pre-stop hook.</para>
        /// </summary>
        [NameInMap("enablePreStop")]
        [Validation(Required=false)]
        public bool? EnablePreStop { get; set; }

        /// <summary>
        /// <para>The environment variables for the sandbox.</para>
        /// </summary>
        [NameInMap("environmentVariables")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the execution role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789:role/aliyunfcdefaultrole</para>
        /// </summary>
        [NameInMap("executionRoleArn")]
        [Validation(Required=false)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// <para>The log configuration.</para>
        /// </summary>
        [NameInMap("logConfiguration")]
        [Validation(Required=false)]
        public LogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// <para>The memory size in MB.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>The Network Attached Storage (NAS) mount configuration.</para>
        /// </summary>
        [NameInMap("nasConfig")]
        [Validation(Required=false)]
        public NASConfig NasConfig { get; set; }

        /// <summary>
        /// <para>The network configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("networkConfiguration")]
        [Validation(Required=false)]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// <para>A list of Object Storage Service (OSS) configurations.</para>
        /// </summary>
        [NameInMap("ossConfiguration")]
        [Validation(Required=false)]
        public List<OssConfiguration> OssConfiguration { get; set; }

        /// <summary>
        /// <para>The timeout for the pre-stop hook, in seconds. This parameter applies only when <c>enablePreStop</c> is set to <c>true</c>.</para>
        /// </summary>
        [NameInMap("preStopTimeoutInSeconds")]
        [Validation(Required=false)]
        public int? PreStopTimeoutInSeconds { get; set; }

        /// <summary>
        /// <para>The duration in seconds that a sandbox can be idle before it is automatically stopped.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1800</para>
        /// </summary>
        [NameInMap("sandboxIdleTimeoutInSeconds")]
        [Validation(Required=false)]
        public int? SandboxIdleTimeoutInSeconds { get; set; }

        /// <summary>
        /// <para>The maximum time-to-live (TTL) in seconds for the sandbox. The sandbox is terminated after this duration, regardless of activity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>26000</para>
        /// </summary>
        [NameInMap("sandboxTTLInSeconds")]
        [Validation(Required=false)]
        public int? SandboxTTLInSeconds { get; set; }

        /// <summary>
        /// <para>The scaling configuration.</para>
        /// </summary>
        [NameInMap("scalingConfig")]
        [Validation(Required=false)]
        public ScalingConfig ScalingConfig { get; set; }

        /// <summary>
        /// <para>The template configuration. This is a flexible object whose structure varies depending on the <c>templateType</c>.</para>
        /// </summary>
        [NameInMap("templateConfiguration")]
        [Validation(Required=false)]
        public Dictionary<string, object> TemplateConfiguration { get; set; }

        /// <summary>
        /// <para>A unique name for the template within your account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>browser-1766687911567</para>
        /// </summary>
        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The template type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Browser</para>
        /// </summary>
        [NameInMap("templateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        /// <summary>
        /// <para>The ID of the workspace.</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
