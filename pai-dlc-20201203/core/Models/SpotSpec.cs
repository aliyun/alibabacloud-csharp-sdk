// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class SpotSpec : TeaModel {
        /// <summary>
        /// <para>The maximum discount. Specify only one of SpotDiscountLimit and SpotPriceLimit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.8</para>
        /// </summary>
        [NameInMap("SpotDiscountLimit")]
        [Validation(Required=false)]
        public float? SpotDiscountLimit { get; set; }

        /// <summary>
        /// <para>The maximum price. Unit: CNY/minute. Specify only one of SpotDiscountLimit and SpotPriceLimit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.4744</para>
        /// </summary>
        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public float? SpotPriceLimit { get; set; }

        /// <summary>
        /// <para>The spot policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SpotWithPriceLimit</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SpotWithPriceLimit</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

    }

}
