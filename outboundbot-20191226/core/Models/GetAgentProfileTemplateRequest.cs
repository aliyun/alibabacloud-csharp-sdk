// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class GetAgentProfileTemplateRequest : TeaModel {
        /// <summary>
        /// <para>ID of the agent profile template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-survey</para>
        /// </summary>
        [NameInMap("AgentProfileTemplateId")]
        [Validation(Required=false)]
        public string AgentProfileTemplateId { get; set; }

        /// <summary>
        /// <para>IP address of the application. This is a system field and is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("AppIp")]
        [Validation(Required=false)]
        public string AppIp { get; set; }

    }

}
