// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateCompliancePackResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CompliancePack")]
        [Validation(Required=false)]
        public GetAggregateCompliancePackResponseBodyCompliancePack CompliancePack { get; set; }
        public class GetAggregateCompliancePackResponseBodyCompliancePack : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }
            [NameInMap("CompliancePackId")]
            [Validation(Required=false)]
            public string CompliancePackId { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("ConfigRules")]
            [Validation(Required=false)]
            public List<GetAggregateCompliancePackResponseBodyCompliancePackConfigRules> ConfigRules { get; set; }
            public class GetAggregateCompliancePackResponseBodyCompliancePackConfigRules : TeaModel {
                public string ManagedRuleIdentifier { get; set; }
                public string ConfigRuleName { get; set; }
                public string ConfigRuleId { get; set; }
                public List<GetAggregateCompliancePackResponseBodyCompliancePackConfigRulesConfigRuleParameters> ConfigRuleParameters { get; set; }
                public class GetAggregateCompliancePackResponseBodyCompliancePackConfigRulesConfigRuleParameters : TeaModel {
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
            [NameInMap("AggregatorId")]
            [Validation(Required=false)]
            public string AggregatorId { get; set; }
            [NameInMap("CompliancePackTemplateId")]
            [Validation(Required=false)]
            public string CompliancePackTemplateId { get; set; }
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }
        };

    }

}
