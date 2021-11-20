// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateAccountComplianceByPackResponseBody : TeaModel {
        [NameInMap("AccountComplianceResult")]
        [Validation(Required=false)]
        public GetAggregateAccountComplianceByPackResponseBodyAccountComplianceResult AccountComplianceResult { get; set; }
        public class GetAggregateAccountComplianceByPackResponseBodyAccountComplianceResult : TeaModel {
            [NameInMap("AccountCompliances")]
            [Validation(Required=false)]
            public List<GetAggregateAccountComplianceByPackResponseBodyAccountComplianceResultAccountCompliances> AccountCompliances { get; set; }
            public class GetAggregateAccountComplianceByPackResponseBodyAccountComplianceResultAccountCompliances : TeaModel {
                public long? AccountId { get; set; }
                public string AccountName { get; set; }
                public string ComplianceType { get; set; }
            }
            [NameInMap("CompliancePackId")]
            [Validation(Required=false)]
            public string CompliancePackId { get; set; }
            [NameInMap("NonCompliantCount")]
            [Validation(Required=false)]
            public int? NonCompliantCount { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
