// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateConfigRuleComplianceByPackResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ConfigRuleComplianceResult")]
        [Validation(Required=false)]
        public GetAggregateConfigRuleComplianceByPackResponseBodyConfigRuleComplianceResult ConfigRuleComplianceResult { get; set; }
        public class GetAggregateConfigRuleComplianceByPackResponseBodyConfigRuleComplianceResult : TeaModel {
            [NameInMap("CompliancePackId")]
            [Validation(Required=false)]
            public string CompliancePackId { get; set; }
            [NameInMap("NonCompliantCount")]
            [Validation(Required=false)]
            public int? NonCompliantCount { get; set; }
            [NameInMap("ConfigRuleCompliances")]
            [Validation(Required=false)]
            public List<GetAggregateConfigRuleComplianceByPackResponseBodyConfigRuleComplianceResultConfigRuleCompliances> ConfigRuleCompliances { get; set; }
            public class GetAggregateConfigRuleComplianceByPackResponseBodyConfigRuleComplianceResultConfigRuleCompliances : TeaModel {
                public string ComplianceType { get; set; }
                public string ConfigRuleName { get; set; }
                public string ConfigRuleId { get; set; }
            }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

    }

}
