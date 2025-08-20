// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LingMou20250527.Models
{
    public class QueryChatInstanceSessionsShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;8C9F2D4E-7A6B-4F1C-9E53-0B2C8D3F9A4B&quot;]</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("sessionIds")]
        [Validation(Required=false)]
        public string SessionIdsShrink { get; set; }

    }

}
