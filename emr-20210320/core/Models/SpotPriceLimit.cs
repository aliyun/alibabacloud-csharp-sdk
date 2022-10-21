// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class SpotPriceLimit : TeaModel {
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("PriceLimit")]
        [Validation(Required=false)]
        public double? PriceLimit { get; set; }

    }

}
