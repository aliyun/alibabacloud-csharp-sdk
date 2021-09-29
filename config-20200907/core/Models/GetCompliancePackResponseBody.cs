// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetCompliancePackResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CompliancePack")]
        [Validation(Required=false)]
        public GetCompliancePackResponseBodyCompliancePack CompliancePack { get; set; }
        public class GetCompliancePackResponseBodyCompliancePack : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("CompliancePackId")]
            [Validation(Required=false)]
            public string CompliancePackId { get; set; }
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("ConfigRules")]
            [Validation(Required=false)]
            public List<GetCompliancePackResponseBodyCompliancePackConfigRules> ConfigRules { get; set; }
            public class GetCompliancePackResponseBodyCompliancePackConfigRules : TeaModel {
                public string ManagedRuleIdentifier { get; set; }
                public string ConfigRuleName { get; set; }
                public string ConfigRuleId { get; set; }
                public List<GetCompliancePackResponseBodyCompliancePackConfigRulesConfigRuleParameters> ConfigRuleParameters { get; set; }
                public class GetCompliancePackResponseBodyCompliancePackConfigRulesConfigRuleParameters : TeaModel {
                    public bool? Required { get; set; }
                    public string ParameterName { get; set; }
                    public string ParameterValue { get; set; }
                }
                public string Description { get; set; }
                public int? RiskLevel { get; set; }
            }
            [NameInMap("CompliancePackName")]
            [Validation(Required=false)]
            public string CompliancePackName { get; set; }
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }
            [NameInMap("CompliancePackTemplateId")]
            [Validation(Required=false)]
            public string CompliancePackTemplateId { get; set; }
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }
        };

    }

}
