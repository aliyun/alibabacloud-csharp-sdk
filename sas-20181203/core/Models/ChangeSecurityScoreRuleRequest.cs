// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ChangeSecurityScoreRuleRequest : TeaModel {
        [NameInMap("ResetSecurityScoreRule")]
        [Validation(Required=false)]
        public bool? ResetSecurityScoreRule { get; set; }

        [NameInMap("SecurityScoreRuleList")]
        [Validation(Required=false)]
        public List<ChangeSecurityScoreRuleRequestSecurityScoreRuleList> SecurityScoreRuleList { get; set; }
        public class ChangeSecurityScoreRuleRequestSecurityScoreRuleList : TeaModel {
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            [NameInMap("SecurityScoreItemList")]
            [Validation(Required=false)]
            public List<ChangeSecurityScoreRuleRequestSecurityScoreRuleListSecurityScoreItemList> SecurityScoreItemList { get; set; }
            public class ChangeSecurityScoreRuleRequestSecurityScoreRuleListSecurityScoreItemList : TeaModel {
                [NameInMap("Score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                [NameInMap("ScoreThreshold")]
                [Validation(Required=false)]
                public int? ScoreThreshold { get; set; }

                [NameInMap("SubRuleType")]
                [Validation(Required=false)]
                public string SubRuleType { get; set; }

            }

        }

    }

}
