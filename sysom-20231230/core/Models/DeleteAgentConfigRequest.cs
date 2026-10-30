// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class DeleteAgentConfigRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the component associated with the configuration to be deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74a86327-3170-412c-8e67-da3389ec56a9</para>
        /// </summary>
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The ID of the component configuration to delete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4d5ecf02-3d01-11f0-8c90-00163e1029af</para>
        /// </summary>
        [NameInMap("configId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

    }

}
