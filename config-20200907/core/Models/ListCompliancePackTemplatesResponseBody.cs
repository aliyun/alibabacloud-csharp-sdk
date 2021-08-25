// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListCompliancePackTemplatesResponseBody : TeaModel {
        [NameInMap("CompliancePackTemplatesResult")]
        [Validation(Required=false)]
        public ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResult CompliancePackTemplatesResult { get; set; }
        public class ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResult : TeaModel {
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
            [NameInMap("CompliancePackTemplates")]
            [Validation(Required=false)]
            public List<ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResultCompliancePackTemplates> CompliancePackTemplates { get; set; }
            public class ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResultCompliancePackTemplates : TeaModel {
                public int? RiskLevel { get; set; }
                public string Description { get; set; }
                public List<ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResultCompliancePackTemplatesConfigRules> ConfigRules { get; set; }
                public class ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResultCompliancePackTemplatesConfigRules : TeaModel {
                    public string Description { get; set; }
                    public string ManagedRuleIdentifier { get; set; }
                    public string ManagedRuleName { get; set; }
                    public List<ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResultCompliancePackTemplatesConfigRulesConfigRuleParameters> ConfigRuleParameters { get; set; }
                    public class ListCompliancePackTemplatesResponseBodyCompliancePackTemplatesResultCompliancePackTemplatesConfigRulesConfigRuleParameters : TeaModel {
                        public bool? Required { get; set; }
                        public string ParameterName { get; set; }
                        public string ParameterValue { get; set; }
                    }
                }
                public string CompliancePackTemplateName { get; set; }
                public string CompliancePackTemplateId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
