// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetResourceComplianceByConfigRuleResponseBody : TeaModel {
        [NameInMap("ComplianceResult")]
        [Validation(Required=false)]
        public GetResourceComplianceByConfigRuleResponseBodyComplianceResult ComplianceResult { get; set; }
        public class GetResourceComplianceByConfigRuleResponseBodyComplianceResult : TeaModel {
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
            [NameInMap("Compliances")]
            [Validation(Required=false)]
            public List<GetResourceComplianceByConfigRuleResponseBodyComplianceResultCompliances> Compliances { get; set; }
            public class GetResourceComplianceByConfigRuleResponseBodyComplianceResultCompliances : TeaModel {
                public string ComplianceType { get; set; }
                public int? Count { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
