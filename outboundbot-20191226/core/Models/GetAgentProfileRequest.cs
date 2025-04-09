// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class GetAgentProfileRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>37ca3ca1ac4b4e57adf3da5b5d939d04</para>
        /// </summary>
        [NameInMap("AgentProfileId")]
        [Validation(Required=false)]
        public string AgentProfileId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("AppIp")]
        [Validation(Required=false)]
        public string AppIp { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ec0c897-b92c-40e4-9ad7-e6e4f5ce13bb</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
