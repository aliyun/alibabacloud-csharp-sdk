// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ElasticSpotSpec : TeaModel {
        /// <summary>
        /// <para>The instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.gn6e-c12g1.3xlarge</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The maximum discount.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.8</para>
        /// </summary>
        [NameInMap("SpotDiscountLimit")]
        [Validation(Required=false)]
        public double? SpotDiscountLimit { get; set; }

        /// <summary>
        /// <para>The maximum bid price.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.4744</para>
        /// </summary>
        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public double? SpotPriceLimit { get; set; }

        /// <summary>
        /// <para>The spot strategy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SpotWithPriceLimit</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

    }

}
