// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class QuotaListItemsValue : TeaModel {
        /// <summary>
        /// <para>Indicates whether the item type is configured in the custom list.</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The format restrictions for the item type in the custom list.</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public WafQuotaString Value { get; set; }

    }

}
