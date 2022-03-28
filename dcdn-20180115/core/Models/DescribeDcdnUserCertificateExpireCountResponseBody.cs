// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserCertificateExpireCountResponseBody : TeaModel {
        [NameInMap("ExpireWithin30DaysCount")]
        [Validation(Required=false)]
        public int? ExpireWithin30DaysCount { get; set; }

        [NameInMap("ExpiredCount")]
        [Validation(Required=false)]
        public int? ExpiredCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
