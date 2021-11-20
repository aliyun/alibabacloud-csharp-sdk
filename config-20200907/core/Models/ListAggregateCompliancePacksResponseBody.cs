// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregateCompliancePacksResponseBody : TeaModel {
        [NameInMap("CompliancePacksResult")]
        [Validation(Required=false)]
        public ListAggregateCompliancePacksResponseBodyCompliancePacksResult CompliancePacksResult { get; set; }
        public class ListAggregateCompliancePacksResponseBodyCompliancePacksResult : TeaModel {
            [NameInMap("CompliancePacks")]
            [Validation(Required=false)]
            public List<ListAggregateCompliancePacksResponseBodyCompliancePacksResultCompliancePacks> CompliancePacks { get; set; }
            public class ListAggregateCompliancePacksResponseBodyCompliancePacksResultCompliancePacks : TeaModel {
                public long? AccountId { get; set; }
                public string AggregatorId { get; set; }
                public string CompliancePackId { get; set; }
                public string CompliancePackName { get; set; }
                public string CompliancePackTemplateId { get; set; }
                public long? CreateTimestamp { get; set; }
                public string Description { get; set; }
                public int? RiskLevel { get; set; }
                public string Status { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
