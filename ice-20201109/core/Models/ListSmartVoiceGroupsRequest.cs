// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListSmartVoiceGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The voice type. If you do not specify this parameter, the operation returns voices from the small model by default. Set this parameter to <c>CosyVoice</c> to retrieve voices from the Cosyvoice large model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CosyVoice</para>
        /// </summary>
        [NameInMap("VoiceType")]
        [Validation(Required=false)]
        public string VoiceType { get; set; }

    }

}
