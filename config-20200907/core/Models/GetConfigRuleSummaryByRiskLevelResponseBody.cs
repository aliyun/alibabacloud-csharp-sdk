// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetConfigRuleSummaryByRiskLevelResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ConfigRuleSummaries")]
        [Validation(Required=false)]
        public List<GetConfigRuleSummaryByRiskLevelResponseBodyConfigRuleSummaries> ConfigRuleSummaries { get; set; }
        public class GetConfigRuleSummaryByRiskLevelResponseBodyConfigRuleSummaries : TeaModel {
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

            [NameInMap("CompliantCount")]
            [Validation(Required=false)]
            public int? CompliantCount { get; set; }

            [NameInMap("NonCompliantCount")]
            [Validation(Required=false)]
            public int? NonCompliantCount { get; set; }

        }

    }

}
