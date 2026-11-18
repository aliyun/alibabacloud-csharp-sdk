// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class SceneItem : TeaModel {
        /// <summary>
        /// <para>The result details for vertical scenarios. Different scenarios return different JSON string structures.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;title&quot;:&quot;London time&quot;,&quot;targetTimeZone&quot;:&quot;Europe/London&quot;}</para>
        /// </summary>
        [NameInMap("detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        /// <summary>
        /// <para>The result type for vertical scenarios, such as weather or time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>time</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
