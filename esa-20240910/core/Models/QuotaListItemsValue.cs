// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class QuotaListItemsValue : TeaModel {
        /// <summary>
        /// <para>The switch for the type of item in the custom list.</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>Format restrictions for the type of item in the custom list.</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public WafQuotaString Value { get; set; }

    }

}
