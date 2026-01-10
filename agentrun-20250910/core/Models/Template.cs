// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class Template : TeaModel {
        [NameInMap("allowAnonymousManage")]
        [Validation(Required=false)]
        public bool? AllowAnonymousManage { get; set; }

        [NameInMap("containerConfiguration")]
        [Validation(Required=false)]
        public ContainerConfiguration ContainerConfiguration { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

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

        [NameInMap("lastUpdatedAt")]
        [Validation(Required=false)]
        public string LastUpdatedAt { get; set; }

        [NameInMap("logConfiguration")]
        [Validation(Required=false)]
        public LogConfiguration LogConfiguration { get; set; }

        [NameInMap("mcpOptions")]
        [Validation(Required=false)]
        public TemplateMcpOptions McpOptions { get; set; }
        public class TemplateMcpOptions : TeaModel {
            [NameInMap("enabledTools")]
            [Validation(Required=false)]
            public List<string> EnabledTools { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>streamable-http</para>
            /// </summary>
            [NameInMap("transport")]
            [Validation(Required=false)]
            public string Transport { get; set; }

        }

        [NameInMap("mcpState")]
        [Validation(Required=false)]
        public TemplateMcpState McpState { get; set; }
        public class TemplateMcpState : TeaModel {
            [NameInMap("accessEndpoint")]
            [Validation(Required=false)]
            public string AccessEndpoint { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("statusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        [NameInMap("networkConfiguration")]
        [Validation(Required=false)]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        [NameInMap("ossConfiguration")]
        [Validation(Required=false)]
        public List<OssConfiguration> OssConfiguration { get; set; }

        [NameInMap("resourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        [NameInMap("sandboxIdleTimeoutInSeconds")]
        [Validation(Required=false)]
        public string SandboxIdleTimeoutInSeconds { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("sandboxTTLInSeconds")]
        [Validation(Required=false)]
        [Obsolete]
        public string SandboxTTLInSeconds { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("statusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

        [NameInMap("templateArn")]
        [Validation(Required=false)]
        public string TemplateArn { get; set; }

        [NameInMap("templateConfiguration")]
        [Validation(Required=false)]
        public Dictionary<string, object> TemplateConfiguration { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("templateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        [NameInMap("templateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

    }

}
