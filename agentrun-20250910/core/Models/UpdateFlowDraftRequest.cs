// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateFlowDraftRequest : TeaModel {
        /// <summary>
        /// <para>包含要更新的工作流草稿配置信息的请求体</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateFlowDraftInput Body { get; set; }

    }

}
