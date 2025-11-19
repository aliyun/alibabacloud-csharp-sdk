// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateTemplateInput : TeaModel {
        [NameInMap("armsConfiguration")]
        [Validation(Required=false)]
        public ArmsConfiguration ArmsConfiguration { get; set; }

        /// <summary>
        /// <para>容器配置，只允许基于 Browser/Code Interpreter 基础镜像的 image</para>
        /// </summary>
        [NameInMap("containerConfiguration")]
        [Validation(Required=false)]
        public ContainerConfiguration ContainerConfiguration { get; set; }

        /// <summary>
        /// <para>CPU资源配置（单位：核心）</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        [NameInMap("credentialConfiguration")]
        [Validation(Required=false)]
        public CredentialConfiguration CredentialConfiguration { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("diskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        [NameInMap("environmentVariables")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvironmentVariables { get; set; }

        [NameInMap("executionRoleArn")]
        [Validation(Required=false)]
        public string ExecutionRoleArn { get; set; }

        [NameInMap("logConfiguration")]
        [Validation(Required=false)]
        public LogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// <para>内存资源配置（单位：MB）</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("networkConfiguration")]
        [Validation(Required=false)]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        [NameInMap("ossConfiguration")]
        [Validation(Required=false)]
        public List<OssConfiguration> OssConfiguration { get; set; }

        /// <summary>
        /// <para>沙箱空闲超时时间（秒）</para>
        /// </summary>
        [NameInMap("sandboxIdleTimeoutInSeconds")]
        [Validation(Required=false)]
        public int? SandboxIdleTimeoutInSeconds { get; set; }

        /// <summary>
        /// <para>沙箱存活时间（秒）</para>
        /// </summary>
        [NameInMap("sandboxTTLInSeconds")]
        [Validation(Required=false)]
        public int? SandboxTTLInSeconds { get; set; }

        /// <summary>
        /// <para>模板配置（灵活的对象结构，根据 templateType 不同而不同）</para>
        /// </summary>
        [NameInMap("templateConfiguration")]
        [Validation(Required=false)]
        public Dictionary<string, object> TemplateConfiguration { get; set; }

        /// <summary>
        /// <para>模板名称（要求账号唯一的）</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("templateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
