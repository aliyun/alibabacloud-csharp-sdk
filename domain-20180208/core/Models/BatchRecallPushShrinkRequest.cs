// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class BatchRecallPushShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;NL12312323123&quot;, &quot;NL12312323124&quot;]</para>
        /// </summary>
        [NameInMap("OutBizIds")]
        [Validation(Required=false)]
        public string OutBizIdsShrink { get; set; }

    }

}
