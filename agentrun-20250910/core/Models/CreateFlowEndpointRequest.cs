// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateFlowEndpointRequest : TeaModel {
        /// <summary>
        /// <para>创建工作流端点所需的完整配置信息</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateFlowEndpointInput Body { get; set; }

    }

}
