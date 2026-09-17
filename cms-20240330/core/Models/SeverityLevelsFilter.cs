// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class SeverityLevelsFilter : TeaModel {
        /// <summary>
        /// <para>The hit condition: the set of severity levels covered by the rule contains at least one level in the array (OR semantics).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;CRITICAL&quot;,&quot;ERROR&quot;]</para>
        /// </summary>
        [NameInMap("contains")]
        [Validation(Required=false)]
        public List<string> Contains { get; set; }

    }

}
