// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateFlowRequest : TeaModel {
        /// <summary>
        /// <para>创建工作流所需的完整配置信息，包括工作流名称、定义、执行模式等</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateFlowInput Body { get; set; }

    }

}
