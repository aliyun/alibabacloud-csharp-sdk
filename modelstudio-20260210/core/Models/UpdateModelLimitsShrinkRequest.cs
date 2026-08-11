// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class UpdateModelLimitsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-ac3ef438bec22dc5</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <para>The throttling values for the workspace.</para>
        /// </summary>
        [NameInMap("workspaceLimits")]
        [Validation(Required=false)]
        public string WorkspaceLimitsShrink { get; set; }

    }

}
