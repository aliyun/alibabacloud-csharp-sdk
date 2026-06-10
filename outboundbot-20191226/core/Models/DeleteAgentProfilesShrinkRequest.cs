// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DeleteAgentProfilesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Collection of agent profile IDs</para>
        /// </summary>
        [NameInMap("AgentProfileIds")]
        [Validation(Required=false)]
        public string AgentProfileIdsShrink { get; set; }

        /// <summary>
        /// <para>app_ip (system field, optional)</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("AppIp")]
        [Validation(Required=false)]
        public string AppIp { get; set; }

    }

}
