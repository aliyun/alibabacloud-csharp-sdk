// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class SpotStockInternalInfo : TeaModel {
        /// <summary>
        /// <para>The number of available Spot Instances.</para>
        /// </summary>
        [NameInMap("availableQuantity")]
        [Validation(Required=false)]
        public int? AvailableQuantity { get; set; }

        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// </summary>
        [NameInMap("clusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the high-performance network (HPN) zone.</para>
        /// </summary>
        [NameInMap("hpnZone")]
        [Validation(Required=false)]
        public string HpnZone { get; set; }

        /// <summary>
        /// <para>The total number of Spot Instances.</para>
        /// </summary>
        [NameInMap("totalQuantity")]
        [Validation(Required=false)]
        public int? TotalQuantity { get; set; }

    }

}
