// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class PrepayOrderInfo : TeaModel {
        [NameInMap("autoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        [NameInMap("duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        [NameInMap("pricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

    }

}
