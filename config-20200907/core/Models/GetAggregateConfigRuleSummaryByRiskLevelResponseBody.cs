// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateConfigRuleSummaryByRiskLevelResponseBody : TeaModel {
        [NameInMap("ConfigRuleSummaries")]
        [Validation(Required=false)]
        public List<GetAggregateConfigRuleSummaryByRiskLevelResponseBodyConfigRuleSummaries> ConfigRuleSummaries { get; set; }
        public class GetAggregateConfigRuleSummaryByRiskLevelResponseBodyConfigRuleSummaries : TeaModel {
            [NameInMap("CompliantCount")]
            [Validation(Required=false)]
            public int? CompliantCount { get; set; }

            [NameInMap("NonCompliantCount")]
            [Validation(Required=false)]
            public int? NonCompliantCount { get; set; }

            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
