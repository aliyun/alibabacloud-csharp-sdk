// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateSandboxRequest : TeaModel {
        /// <summary>
        /// <para>创建沙箱所需的配置信息，包括模板名称、沙箱名称等</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateSandboxInput Body { get; set; }

    }

}
