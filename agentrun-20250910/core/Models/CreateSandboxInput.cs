// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateSandboxInput : TeaModel {
        [NameInMap("sandboxId")]
        [Validation(Required=false)]
        public string SandboxId { get; set; }

        /// <summary>
        /// <para>沙箱空闲超时时间（秒）</para>
        /// </summary>
        [NameInMap("sandboxIdleTimeoutSeconds")]
        [Validation(Required=false)]
        public int? SandboxIdleTimeoutSeconds { get; set; }

        /// <summary>
        /// <para>模板名称（系统内部通过 templateName 查询 template_id）</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
