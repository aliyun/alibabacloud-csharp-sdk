// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyContainerDefenseRuleShrinkRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("RuleAction")]
        [Validation(Required=false)]
        public int? RuleAction { get; set; }

        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        [NameInMap("RuleSwitch")]
        [Validation(Required=false)]
        public int? RuleSwitch { get; set; }

        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

        [NameInMap("Scope")]
        [Validation(Required=false)]
        public List<ModifyContainerDefenseRuleShrinkRequestScope> Scope { get; set; }
        public class ModifyContainerDefenseRuleShrinkRequestScope : TeaModel {
            [NameInMap("AllNamespace")]
            [Validation(Required=false)]
            public int? AllNamespace { get; set; }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("Namespaces")]
            [Validation(Required=false)]
            public List<string> Namespaces { get; set; }

        }

        [NameInMap("Whitelist")]
        [Validation(Required=false)]
        public string WhitelistShrink { get; set; }

    }

}
