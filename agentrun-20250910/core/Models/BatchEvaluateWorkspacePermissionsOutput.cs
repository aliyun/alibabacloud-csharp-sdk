// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class BatchEvaluateWorkspacePermissionsOutput : TeaModel {
        /// <summary>
        /// <para>各 workspace 的权限校验结果列表；顺序与请求 workspaceIds 一致</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<WorkspacePermissionEvaluateResult> Results { get; set; }

    }

}
