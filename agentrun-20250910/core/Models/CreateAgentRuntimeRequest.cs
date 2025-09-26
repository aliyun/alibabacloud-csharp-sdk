// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateAgentRuntimeRequest : TeaModel {
        /// <summary>
        /// <para>创建智能体运行时所需的完整配置信息，包括运行时名称、资源规格、网络配置、协议配置等</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateAgentRuntimeInput Body { get; set; }

    }

}
