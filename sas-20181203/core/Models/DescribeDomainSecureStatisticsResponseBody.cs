// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeDomainSecureStatisticsResponseBody : TeaModel {
        [NameInMap("AlarmCount")]
        [Validation(Required=false)]
        public int? AlarmCount { get; set; }

        [NameInMap("NoSslCount")]
        [Validation(Required=false)]
        public int? NoSslCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RiskCount")]
        [Validation(Required=false)]
        public int? RiskCount { get; set; }

        [NameInMap("TotalDomainCount")]
        [Validation(Required=false)]
        public int? TotalDomainCount { get; set; }

        [NameInMap("VulCount")]
        [Validation(Required=false)]
        public int? VulCount { get; set; }

    }

}
