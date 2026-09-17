// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ObserveResourceListFilter : TeaModel {
        /// <summary>
        /// <para>The match condition that requires the observeResourceList of a rule to contain at least one instance ID from the array (OR semantics).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;i-bp1a2b3c4d5e6f7g8h9i&quot;]</para>
        /// </summary>
        [NameInMap("contains")]
        [Validation(Required=false)]
        public List<string> Contains { get; set; }

    }

}
