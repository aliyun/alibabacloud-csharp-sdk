// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateAgentRuntimeEndpointRequest : TeaModel {
        /// <summary>
        /// <para>包含要创建的智能体运行时端点配置信息的请求体</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateAgentRuntimeEndpointInput Body { get; set; }

    }

}
