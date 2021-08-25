// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetConfigRuleComplianceByPackResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ConfigRuleComplianceResult")]
        [Validation(Required=false)]
        public GetConfigRuleComplianceByPackResponseBodyConfigRuleComplianceResult ConfigRuleComplianceResult { get; set; }
        public class GetConfigRuleComplianceByPackResponseBodyConfigRuleComplianceResult : TeaModel {
            [NameInMap("CompliancePackId")]
            [Validation(Required=false)]
            public string CompliancePackId { get; set; }
            [NameInMap("NonCompliantCount")]
            [Validation(Required=false)]
            public int? NonCompliantCount { get; set; }
            [NameInMap("ConfigRuleCompliances")]
            [Validation(Required=false)]
            public List<GetConfigRuleComplianceByPackResponseBodyConfigRuleComplianceResultConfigRuleCompliances> ConfigRuleCompliances { get; set; }
            public class GetConfigRuleComplianceByPackResponseBodyConfigRuleComplianceResultConfigRuleCompliances : TeaModel {
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
