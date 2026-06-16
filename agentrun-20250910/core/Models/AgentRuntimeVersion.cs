// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class AgentRuntimeVersion : TeaModel {
        /// <summary>
        /// <para>The ARN of the agent runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:agentrun:cn-hangzhou:1760720386195983:runtimes/7a1b6d39-9f8f-4ce2-b9c9-6db1b0b9e169</para>
        /// </summary>
        [NameInMap("agentRuntimeArn")]
        [Validation(Required=false)]
        public string AgentRuntimeArn { get; set; }

        /// <summary>
        /// <para>The ID of the agent runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ar-1234567890abcdef</para>
        /// </summary>
        [NameInMap("agentRuntimeId")]
        [Validation(Required=false)]
        public string AgentRuntimeId { get; set; }

        /// <summary>
        /// <para>The name of the agent runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-agent-runtime</para>
        /// </summary>
        [NameInMap("agentRuntimeName")]
        [Validation(Required=false)]
        public string AgentRuntimeName { get; set; }

        /// <summary>
        /// <para>The version of the agent runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LATEST</para>
        /// </summary>
        [NameInMap("agentRuntimeVersion")]
        [Validation(Required=false)]
        public string AgentRuntimeVersion_ { get; set; }

        /// <summary>
        /// <para>The description of the agent runtime version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Initial release with basic functionality</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The timestamp of the agent runtime version\&quot;s last update.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-10T10:30:00Z</para>
        /// </summary>
        [NameInMap("lastUpdatedAt")]
        [Validation(Required=false)]
        public string LastUpdatedAt { get; set; }

    }

}
