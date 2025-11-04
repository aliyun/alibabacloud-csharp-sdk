// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SetAIAgentVoiceprintShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The input file.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string InputShrink { get; set; }

        /// <summary>
        /// <para>A unique identifier for the voiceprint. Generate this ID based on your own business rules. Requirement: 1 to 127 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vp_1699123456_8527</para>
        /// </summary>
        [NameInMap("VoiceprintId")]
        [Validation(Required=false)]
        public string VoiceprintId { get; set; }

    }

}
