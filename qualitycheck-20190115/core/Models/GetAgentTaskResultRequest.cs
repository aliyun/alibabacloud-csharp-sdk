// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetAgentTaskResultRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the business workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public string BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>The complete JSON string. For more information, see the following details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;vid\&quot;:\&quot;sip-11-1766561862.293393\&quot;,\&quot;taskId\&quot;:\&quot;20251224-D3B32484-2D53-5B53-A618-483A7941029E\&quot;}</para>
        /// </summary>
        [NameInMap("JsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
