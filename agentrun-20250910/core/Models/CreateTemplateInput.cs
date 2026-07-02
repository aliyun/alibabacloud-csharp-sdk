// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateTemplateInput : TeaModel {
        /// <summary>
        /// <para>Whether to allow data channel to call create/stop/delete sandbox APIs</para>
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
        /// <para>ARMS configuration</para>
        /// </summary>
        [NameInMap("armsConfiguration")]
        [Validation(Required=false)]
        public ArmsConfiguration ArmsConfiguration { get; set; }

        /// <summary>
        /// <para>Container configuration, only images based on Browser/Code Interpreter base images are allowed</para>
        /// </summary>
        [NameInMap("containerConfiguration")]
        [Validation(Required=false)]
        public ContainerConfiguration ContainerConfiguration { get; set; }

        /// <summary>
        /// <para>CPU resource configuration (unit: cores)</para>
        /// <para>This parameter is required.</para>
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
        /// <para>模板描述</para>
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
        /// <para>Sandbox Agent switch</para>
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
        /// <para>acs:ram::123456789:role/aliyunfcdefaultrole</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>NAS mount configuration</para>
        /// </summary>
        [NameInMap("nasConfig")]
        [Validation(Required=false)]
        public NASConfig NasConfig { get; set; }

        /// <summary>
        /// <para>Network configuration</para>
        /// <para>This parameter is required.</para>
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
        /// <para>Sandbox idle timeout (in seconds)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1800</para>
        /// </summary>
        [NameInMap("sandboxIdleTimeoutInSeconds")]
        [Validation(Required=false)]
        public int? SandboxIdleTimeoutInSeconds { get; set; }

        /// <summary>
        /// <para>Sandbox time-to-live (in seconds)</para>
        /// 
        /// <b>Example:</b>
        /// <para>26000</para>
        /// </summary>
        [NameInMap("sandboxTTLInSeconds")]
        [Validation(Required=false)]
        public int? SandboxTTLInSeconds { get; set; }

        /// <summary>
        /// <para>Scaling configuration</para>
        /// </summary>
        [NameInMap("scalingConfig")]
        [Validation(Required=false)]
        public ScalingConfig ScalingConfig { get; set; }

        /// <summary>
        /// <para>Template configuration (flexible object structure that varies depending on templateType)</para>
        /// </summary>
        [NameInMap("templateConfiguration")]
        [Validation(Required=false)]
        public Dictionary<string, object> TemplateConfiguration { get; set; }

        /// <summary>
        /// <para>Template name (must be unique within the account)</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>browser-1766687911567</para>
        /// </summary>
        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>Template type</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Browser</para>
        /// </summary>
        [NameInMap("templateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
