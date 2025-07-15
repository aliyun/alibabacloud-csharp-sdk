// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateRTCWhipStreamAddressResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>58E7<b>D4-xxxx-xxxx-xxxx-6B5</b>6Cxxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://xxxxxx.media-sh.xxxxx.com/xxxxxxxxxxxx/3723a3xxxxxxxxx223c606b***5f7a2bc7c56ea5cdd0xxxxe?auth_key=17495xxxxx-xxxx-0-f013003067c78c4053f9cd0xxxxxxx&qqzr=H4sIAAAAAAAC_6pWSlayUkrOMxxxxxxrPyCxQ0lFKQTCLlKyUjM2Nj**NDQ1TEy2Mjc3xxxxxxxxxxqRYAAAD__xxxxx__xxxxxxxx">https://xxxxxx.media-sh.xxxxx.com/xxxxxxxxxxxx/3723a3xxxxxxxxx223c606b***5f7a2bc7c56ea5cdd0xxxxe?auth_key=17495xxxxx-xxxx-0-f013003067c78c4053f9cd0xxxxxxx&amp;qqzr=H4sIAAAAAAAC_6pWSlayUkrOMxxxxxxrPyCxQ0lFKQTCLlKyUjM2Nj**NDQ1TEy2Mjc3xxxxxxxxxxqRYAAAD__xxxxx__xxxxxxxx</a></para>
        /// </summary>
        [NameInMap("WhipAddress")]
        [Validation(Required=false)]
        public string WhipAddress { get; set; }

    }

}
