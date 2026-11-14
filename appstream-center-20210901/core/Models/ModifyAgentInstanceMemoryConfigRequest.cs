// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyAgentInstanceMemoryConfigRequest : TeaModel {
        /// <summary>
        /// <para>The list of agent instance IDs. Specify 1 to 100 IDs. The IDs must be unique. Each instance must belong to the current account, support memory management, and have the memory feature configured.</para>
        /// </summary>
        [NameInMap("AgentInstanceIds")]
        [Validation(Required=false)]
        public List<string> AgentInstanceIds { get; set; }

        /// <summary>
        /// <para>Required. Specifies whether to enable the memory feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enables the memory feature.</description></item>
        /// <item><description>false: Disables the memory feature.
        /// Before enabling the feature, ensure that the tenant-level memory store switch is turned on.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

    }

}
