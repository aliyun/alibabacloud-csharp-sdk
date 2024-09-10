// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeDomainSecureRiskListResponseBody : TeaModel {
        [NameInMap("NoSslCount")]
        [Validation(Required=false)]
        public int? NoSslCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RiskCount")]
        [Validation(Required=false)]
        public int? RiskCount { get; set; }

        [NameInMap("RiskList")]
        [Validation(Required=false)]
        public List<DescribeDomainSecureRiskListResponseBodyRiskList> RiskList { get; set; }
        public class DescribeDomainSecureRiskListResponseBodyRiskList : TeaModel {
            [NameInMap("AlarmCount")]
            [Validation(Required=false)]
            public int? AlarmCount { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("SslBrand")]
            [Validation(Required=false)]
            public string SslBrand { get; set; }

            [NameInMap("SslStatus")]
            [Validation(Required=false)]
            public int? SslStatus { get; set; }

            [NameInMap("UuidList")]
            [Validation(Required=false)]
            public List<string> UuidList { get; set; }

            [NameInMap("VulCount")]
            [Validation(Required=false)]
            public int? VulCount { get; set; }

        }

    }

}
