// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class BoundConfiguration : TeaModel {
        /// <summary>
        /// <para>绑定的工具配置列表，每个配置项定义一个工具与特定 HTTP 路径和方法的绑定关系</para>
        /// </summary>
        [NameInMap("boundTools")]
        [Validation(Required=false)]
        public List<BoundTool> BoundTools { get; set; }

    }

}
