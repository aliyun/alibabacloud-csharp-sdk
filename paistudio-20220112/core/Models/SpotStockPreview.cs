// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class SpotStockPreview : TeaModel {
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("SpotDiscount")]
        [Validation(Required=false)]
        public float? SpotDiscount { get; set; }

        [NameInMap("StockStatus")]
        [Validation(Required=false)]
        public string StockStatus { get; set; }

    }

}
