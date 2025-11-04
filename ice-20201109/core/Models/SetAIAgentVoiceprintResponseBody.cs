// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SetAIAgentVoiceprintResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e8400********55440000</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the registered voiceprint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vp_1699123456_8527</para>
        /// </summary>
        [NameInMap("VoiceprintId")]
        [Validation(Required=false)]
        public string VoiceprintId { get; set; }

    }

}
