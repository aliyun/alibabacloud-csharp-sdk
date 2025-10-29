// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ContainerConfiguration : TeaModel {
        /// <summary>
        /// <para>在容器中运行的命令（例如：[&quot;python3&quot;, &quot;app.py&quot;]）</para>
        /// 
        /// <b>Example:</b>
        /// <para>python3,app.py</para>
        /// </summary>
        [NameInMap("command")]
        [Validation(Required=false)]
        public List<string> Command { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>registry.cn-hangzhou.aliyuncs.com/my-namespace/agent-runtime:latest</para>
        /// </summary>
        [NameInMap("image")]
        [Validation(Required=false)]
        public string Image { get; set; }

    }

}
