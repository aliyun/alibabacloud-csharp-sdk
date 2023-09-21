// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetSecurityScoreRuleResponseBody : TeaModel {
        [NameInMap("EnableStatus")]
        [Validation(Required=false)]
        public bool? EnableStatus { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecurityScoreRuleList")]
        [Validation(Required=false)]
        public List<GetSecurityScoreRuleResponseBodySecurityScoreRuleList> SecurityScoreRuleList { get; set; }
        public class GetSecurityScoreRuleResponseBodySecurityScoreRuleList : TeaModel {
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            [NameInMap("SecurityScoreItemList")]
            [Validation(Required=false)]
            public List<GetSecurityScoreRuleResponseBodySecurityScoreRuleListSecurityScoreItemList> SecurityScoreItemList { get; set; }
            public class GetSecurityScoreRuleResponseBodySecurityScoreRuleListSecurityScoreItemList : TeaModel {
                [NameInMap("Score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                [NameInMap("ScoreThreshold")]
                [Validation(Required=false)]
                public int? ScoreThreshold { get; set; }

                [NameInMap("SubRuleType")]
                [Validation(Required=false)]
                public string SubRuleType { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
