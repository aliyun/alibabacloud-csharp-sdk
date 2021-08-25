// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateResourceComplianceByConfigRuleResponseBody : TeaModel {
        [NameInMap("ComplianceResult")]
        [Validation(Required=false)]
        public GetAggregateResourceComplianceByConfigRuleResponseBodyComplianceResult ComplianceResult { get; set; }
        public class GetAggregateResourceComplianceByConfigRuleResponseBodyComplianceResult : TeaModel {
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
            [NameInMap("Compliances")]
            [Validation(Required=false)]
            public List<GetAggregateResourceComplianceByConfigRuleResponseBodyComplianceResultCompliances> Compliances { get; set; }
            public class GetAggregateResourceComplianceByConfigRuleResponseBodyComplianceResultCompliances : TeaModel {
                public string ComplianceType { get; set; }
                public int? Count { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
