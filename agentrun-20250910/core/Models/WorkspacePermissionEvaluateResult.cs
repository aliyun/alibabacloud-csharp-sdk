// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class WorkspacePermissionEvaluateResult : TeaModel {
        /// <summary>
        /// <para>各 action 的校验结果；顺序与请求 actions 一致</para>
        /// </summary>
        [NameInMap("permissions")]
        [Validation(Required=false)]
        public List<WorkspacePermissionItem> Permissions { get; set; }

        /// <summary>
        /// <para>当前租户下是否解析到该 workspace；为 false 时各 permissions 一般为 allowed: false，不会调用 RAM</para>
        /// </summary>
        [NameInMap("workspaceFound")]
        [Validation(Required=false)]
        public bool? WorkspaceFound { get; set; }

        /// <summary>
        /// <para>回显请求中的 workspace ID（trim 后）</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
