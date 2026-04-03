// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class BatchEvaluateWorkspacePermissionsInput : TeaModel {
        /// <summary>
        /// <para>RAM List 类 action 列表；支持带 agentrun: 前缀或不带（服务端归一化）；顺序与每条 permissions 一致；上限 20 条</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("actions")]
        [Validation(Required=false)]
        public List<string> Actions { get; set; }

        /// <summary>
        /// <para>Workspace 资源 ID 列表（UUID 字符串）；顺序与响应 results 一致；上限 50 条</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("workspaceIds")]
        [Validation(Required=false)]
        public List<string> WorkspaceIds { get; set; }

    }

}
