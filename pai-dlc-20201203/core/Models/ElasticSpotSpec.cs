// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ElasticSpotSpec : TeaModel {
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("SpotDiscountLimit")]
        [Validation(Required=false)]
        public double? SpotDiscountLimit { get; set; }

        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public double? SpotPriceLimit { get; set; }

        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

    }

}
