// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class GetAgentRuntimeRequest : TeaModel {
        /// <summary>
        /// <para>指定要获取的智能体运行时版本，如果不指定则返回最新版本</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1.0.0</para>
        /// </summary>
        [NameInMap("agentRuntimeVersion")]
        [Validation(Required=false)]
        public string AgentRuntimeVersion { get; set; }

    }

}
