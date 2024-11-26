// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribePriceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;components&quot;:{&quot;package_version&quot;:&quot;yuncode12928000016&quot;},&quot;duration&quot;:1,&quot;pricingCycle&quot;:&quot;YEAR&quot;,&quot;productCode&quot;:&quot;cmgj01**28&quot;,&quot;quantity&quot;:1,&quot;skuCode&quot;:&quot;prepay&quot;}</para>
        /// </summary>
        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public string Commodity { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INSTANCE_BUY</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

    }

}
