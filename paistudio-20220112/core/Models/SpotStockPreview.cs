// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class SpotStockPreview : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ml.gu8xf.8xlarge-gu108</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.1</para>
        /// </summary>
        [NameInMap("SpotDiscount")]
        [Validation(Required=false)]
        public float? SpotDiscount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>WithStock</para>
        /// </summary>
        [NameInMap("StockStatus")]
        [Validation(Required=false)]
        public string StockStatus { get; set; }

    }

}
