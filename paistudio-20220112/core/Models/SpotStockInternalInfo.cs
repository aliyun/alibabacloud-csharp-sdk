// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class SpotStockInternalInfo : TeaModel {
        /// <summary>
        /// <para>The available quantity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("availableQuantity")]
        [Validation(Required=false)]
        public int? AvailableQuantity { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster1</para>
        /// </summary>
        [NameInMap("clusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The high-performance network zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1</para>
        /// </summary>
        [NameInMap("hpnZone")]
        [Validation(Required=false)]
        public string HpnZone { get; set; }

        /// <summary>
        /// <para>The total quantity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("totalQuantity")]
        [Validation(Required=false)]
        public int? TotalQuantity { get; set; }

    }

}
