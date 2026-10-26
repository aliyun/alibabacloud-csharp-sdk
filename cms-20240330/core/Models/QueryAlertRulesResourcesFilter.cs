// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class QueryAlertRulesResourcesFilter : TeaModel {
        /// <summary>
        /// <para>Matches any item in the list (OR semantics).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;i-bp1a2b3c4d5e6f7g8h9i&quot;,&quot;i-bp9h8g7f6e5d4c3b2a1&quot;]</para>
        /// </summary>
        [NameInMap("contains")]
        [Validation(Required=false)]
        public List<string> Contains { get; set; }

        /// <summary>
        /// <para>The resource instance ID blacklist filter that excludes alert rules whose associated resources contain any instance ID in the array.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;i-bp0z9y8x7w6v5u4t3s2&quot;]</para>
        /// </summary>
        [NameInMap("notContains")]
        [Validation(Required=false)]
        public List<string> NotContains { get; set; }

    }

}
