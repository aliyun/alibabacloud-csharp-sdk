// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class SpotPriceItem : TeaModel {
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("SpotDiscount")]
        [Validation(Required=false)]
        public float? SpotDiscount { get; set; }

        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public string Timestamp { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
