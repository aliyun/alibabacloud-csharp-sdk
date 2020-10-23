// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class PutConfigRuleRequest : TeaModel {
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

        [NameInMap("ConfigRuleName")]
        [Validation(Required=true)]
        public string ConfigRuleName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("InputParameters")]
        [Validation(Required=false)]
        public string InputParameters { get; set; }

        [NameInMap("SourceOwner")]
        [Validation(Required=true)]
        public string SourceOwner { get; set; }

        [NameInMap("SourceIdentifier")]
        [Validation(Required=true)]
        public string SourceIdentifier { get; set; }

        [NameInMap("SourceDetailMessageType")]
        [Validation(Required=true)]
        public string SourceDetailMessageType { get; set; }

        [NameInMap("SourceMaximumExecutionFrequency")]
        [Validation(Required=false)]
        public string SourceMaximumExecutionFrequency { get; set; }

        [NameInMap("ScopeComplianceResourceId")]
        [Validation(Required=false)]
        public string ScopeComplianceResourceId { get; set; }

        [NameInMap("ScopeComplianceResourceTypes")]
        [Validation(Required=true)]
        public string ScopeComplianceResourceTypes { get; set; }

        [NameInMap("RiskLevel")]
        [Validation(Required=true)]
        public int? RiskLevel { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("MultiAccount")]
        [Validation(Required=false)]
        public bool? MultiAccount { get; set; }

        [NameInMap("MemberId")]
        [Validation(Required=false)]
        public long MemberId { get; set; }

    }

}
