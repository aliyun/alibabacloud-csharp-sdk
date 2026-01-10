// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class RouteConfig : TeaModel {
        /// <summary>
        /// <para>路由表：自定义域名访问时的 PATH 到 Function 的映射列表。</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("routes")]
        [Validation(Required=false)]
        public List<PathConfig> Routes { get; set; }

    }

}
