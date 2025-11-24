// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class Sandbox : TeaModel {
        /// <summary>
        /// <para>沙箱创建时间</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("endedAt")]
        [Validation(Required=false)]
        public string EndedAt { get; set; }

        /// <summary>
        /// <para>最后更新时间</para>
        /// </summary>
        [NameInMap("lastUpdatedAt")]
        [Validation(Required=false)]
        public string LastUpdatedAt { get; set; }

        [NameInMap("metadata")]
        [Validation(Required=false)]
        public Dictionary<string, object> Metadata { get; set; }

        [NameInMap("sandboxArn")]
        [Validation(Required=false)]
        public string SandboxArn { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sandboxId")]
        [Validation(Required=false)]
        public string SandboxId { get; set; }

        [NameInMap("sandboxIdleTTLInSeconds")]
        [Validation(Required=false)]
        public int? SandboxIdleTTLInSeconds { get; set; }

        /// <summary>
        /// <para>沙箱空闲超时时间（秒）</para>
        /// </summary>
        [NameInMap("sandboxIdleTimeoutSeconds")]
        [Validation(Required=false)]
        public int? SandboxIdleTimeoutSeconds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
