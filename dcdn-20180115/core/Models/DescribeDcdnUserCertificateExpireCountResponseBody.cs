// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserCertificateExpireCountResponseBody : TeaModel {
        /// <summary>
        /// The number of domain names whose SSL certificates are about to expire within 30 days.
        /// </summary>
        [NameInMap("ExpireWithin30DaysCount")]
        [Validation(Required=false)]
        public int? ExpireWithin30DaysCount { get; set; }

        /// <summary>
        /// The number of domain names whose SSL certificates have already expired.
        /// </summary>
        [NameInMap("ExpiredCount")]
        [Validation(Required=false)]
        public int? ExpiredCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
