// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LingMou20250527.Models
{
    public class GetUploadPolicyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Token</para>
        /// </summary>
        [NameInMap("jwtToken")]
        [Validation(Required=false)]
        public string JwtToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>INPUT_CHAT_BACKGROUND_PIC</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
