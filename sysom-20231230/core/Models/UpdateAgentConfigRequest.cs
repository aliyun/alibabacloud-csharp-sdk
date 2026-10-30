// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class UpdateAgentConfigRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the component whose configuration is to be updated.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74a86327-3170-412c-8e67-da3389ec56a9</para>
        /// </summary>
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The ID of the component configuration to update.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f0078fbb-4213-11f0-a19b-00163e4ae208</para>
        /// </summary>
        [NameInMap("configId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        /// <summary>
        /// <para>The new content of the component configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;oomkill&quot;:{&quot;enable&quot;:false}}</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

    }

}
