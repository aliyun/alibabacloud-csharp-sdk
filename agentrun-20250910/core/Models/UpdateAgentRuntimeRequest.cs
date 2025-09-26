// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateAgentRuntimeRequest : TeaModel {
        /// <summary>
        /// <para>包含要更新的智能体运行时配置信息的请求体</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateAgentRuntimeInput Body { get; set; }

    }

}
