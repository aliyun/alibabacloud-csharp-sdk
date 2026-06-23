// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class UnifiedSceneItem : TeaModel {
        /// <summary>
        /// <para>The result in JSON structure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;title\&quot;: \&quot;伦敦时间\&quot;, \&quot;targetTimeZone\&quot;: \&quot;Europe/London\&quot;, \&quot;targetTimeMillisecond\&quot;: \&quot;1745820817178\&quot;, \&quot;targetTime\&quot;: \&quot;2025-04-28 14:13:37\&quot;, \&quot;beijingTimeZone\&quot;: \&quot;PRC\&quot;, \&quot;beijingTimeMillisecond\&quot;: \&quot;1745846017178\&quot;}</para>
        /// </summary>
        [NameInMap("detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        /// <summary>
        /// <para>The type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>time</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
