// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntlMarket20250812.Models
{
    public class DescribePriceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;duration\&quot;: 1, \&quot;productCode\&quot;: \&quot;cmjz000325\&quot;, \&quot;quantity\&quot;: 1, \&quot;pricingCycle\&quot;: \&quot;Year\&quot;, \&quot;skuCode\&quot;: \&quot;jichuban\&quot;}</para>
        /// </summary>
        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public string Commodity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DOWNGRADE</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

    }

}
