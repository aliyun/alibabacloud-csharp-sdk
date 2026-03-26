// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class McpProxyConfiguration : TeaModel {
        /// <summary>
        /// <para>MCP 代理的钩子函数配置列表，每个钩子可以在请求处理的不同阶段执行自定义逻辑</para>
        /// </summary>
        [NameInMap("hooks")]
        [Validation(Required=false)]
        public List<Hook> Hooks { get; set; }

    }

}
