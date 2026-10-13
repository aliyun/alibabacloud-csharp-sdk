// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DeleteCustomScriptTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the custom scenario template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d31794e2a51f47d2901b4094d88311d7</para>
        /// </summary>
        [NameInMap("AgentProfileId")]
        [Validation(Required=false)]
        public string AgentProfileId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ec0c897-b92c-40e4-9ad7-e6e4f5ce13bb</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
