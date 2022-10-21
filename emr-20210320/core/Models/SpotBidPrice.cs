// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class SpotBidPrice : TeaModel {
        [NameInMap("BidPrice")]
        [Validation(Required=false)]
        public double? BidPrice { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

    }

}
