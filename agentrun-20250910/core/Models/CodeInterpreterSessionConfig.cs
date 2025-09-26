// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CodeInterpreterSessionConfig : TeaModel {
        /// <summary>
        /// <para>代码解释器会话的环境变量配置</para>
        /// </summary>
        [NameInMap("environment")]
        [Validation(Required=false)]
        public Dictionary<string, string> Environment { get; set; }

        /// <summary>
        /// <para>代码解释器会话的超时时间，单位为秒</para>
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>代码解释器会话的工作目录路径</para>
        /// </summary>
        [NameInMap("workingDirectory")]
        [Validation(Required=false)]
        public string WorkingDirectory { get; set; }

    }

}
