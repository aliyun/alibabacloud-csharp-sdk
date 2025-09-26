// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class AgentRuntimeVersion : TeaModel {
        /// <summary>
        /// <para>智能体运行时的ARN</para>
        /// </summary>
        [NameInMap("agentRuntimeArn")]
        [Validation(Required=false)]
        public string AgentRuntimeArn { get; set; }

        /// <summary>
        /// <para>智能体运行时的ID</para>
        /// </summary>
        [NameInMap("agentRuntimeId")]
        [Validation(Required=false)]
        public string AgentRuntimeId { get; set; }

        /// <summary>
        /// <para>智能体运行时的名称</para>
        /// </summary>
        [NameInMap("agentRuntimeName")]
        [Validation(Required=false)]
        public string AgentRuntimeName { get; set; }

        /// <summary>
        /// <para>已发布版本的版本号</para>
        /// </summary>
        [NameInMap("agentRuntimeVersion")]
        [Validation(Required=false)]
        public string AgentRuntimeVersion_ { get; set; }

        /// <summary>
        /// <para>此版本的描述</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>最后更新的时间戳</para>
        /// </summary>
        [NameInMap("lastUpdatedAt")]
        [Validation(Required=false)]
        public string LastUpdatedAt { get; set; }

    }

}
