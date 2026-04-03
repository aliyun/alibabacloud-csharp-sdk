// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class WorkspacePermissionItem : TeaModel {
        /// <summary>
        /// <para>RAM 明确拒绝且可构造 detail 时返回；通过或非 RAM 拒绝场景省略</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("accessDeniedDetail")]
        [Validation(Required=false)]
        public AccessDeniedDetail AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>归一化后的 RAM action，始终含 agentrun: 前缀，如 agentrun:ListTemplates</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>RAM 判定通过为 true；workspace 不存在、非法/不支持 action、RAM SDK 报错等均为 false</para>
        /// </summary>
        [NameInMap("allowed")]
        [Validation(Required=false)]
        public bool? Allowed { get; set; }

        /// <summary>
        /// <para>人类可读原因；通过时通常为空字符串</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
