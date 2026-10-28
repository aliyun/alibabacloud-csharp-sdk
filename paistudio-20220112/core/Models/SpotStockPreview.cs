// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class SpotStockPreview : TeaModel {
        /// <summary>
        /// <para>The available quantity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("AvailableQuantity")]
        [Validation(Required=false)]
        public int? AvailableQuantity { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c1a2b3c4d5e6f7a8b9c0d1e2f3a4b5c6</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The spot instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ml.gu8xf.8xlarge-gu108</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The current spot instance discount.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.1</para>
        /// </summary>
        [NameInMap("SpotDiscount")]
        [Validation(Required=false)]
        public float? SpotDiscount { get; set; }

        /// <summary>
        /// <para>The spot instance inventory status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WithStock</para>
        /// </summary>
        [NameInMap("StockStatus")]
        [Validation(Required=false)]
        public string StockStatus { get; set; }

    }

}
