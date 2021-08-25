// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CreateAggregateCompliancePackShrinkRequest : TeaModel {
        [NameInMap("CompliancePackTemplateId")]
        [Validation(Required=false)]
        public string CompliancePackTemplateId { get; set; }

        [NameInMap("CompliancePackName")]
        [Validation(Required=false)]
        public string CompliancePackName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public int? RiskLevel { get; set; }

        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        [NameInMap("ConfigRules")]
        [Validation(Required=false)]
        public string ConfigRulesShrink { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
