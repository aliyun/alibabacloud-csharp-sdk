// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateToolRequest : TeaModel {
        /// <summary>
        /// <para>创建工具的请求参数，包含工具的所有配置信息</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateToolInputV2 Body { get; set; }

    }

}
