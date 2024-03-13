// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePostpayTrafficTotalResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalAssets")]
        [Validation(Required=false)]
        public long? TotalAssets { get; set; }

        [NameInMap("TotalNatAssets")]
        [Validation(Required=false)]
        public long? TotalNatAssets { get; set; }

        [NameInMap("TotalNatTraffic")]
        [Validation(Required=false)]
        public long? TotalNatTraffic { get; set; }

        [NameInMap("TotalTraffic")]
        [Validation(Required=false)]
        public long? TotalTraffic { get; set; }

    }

}
