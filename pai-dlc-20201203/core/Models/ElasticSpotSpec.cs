// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ElasticSpotSpec : TeaModel {
        /// <summary>
        /// <para>The spot instance type.</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The maximum discount percentage for the spot instance. The system does not select an instance if its discount exceeds this limit. For example, if you set this parameter to <c>90</c>, the system considers only instances with a discount of 90% or less.</para>
        /// </summary>
        [NameInMap("SpotDiscountLimit")]
        [Validation(Required=false)]
        public double? SpotDiscountLimit { get; set; }

        /// <summary>
        /// <para>The maximum hourly price you are willing to pay for a spot instance. If omitted, the on-demand price is the default.</para>
        /// </summary>
        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public double? SpotPriceLimit { get; set; }

        /// <summary>
        /// <para>The strategy for allocating spot instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>LowestPrice</c>: Launches instances from the spot capacity pool offering the lowest price. This is the default strategy.</para>
        /// </description></item>
        /// <item><description><para><c>CapacityOptimized</c>: Launches instances from the spot capacity pool offering optimal capacity.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

    }

}
