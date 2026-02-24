// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateResourceComplianceGroupByResourceTypeResponseBody : TeaModel {
        [NameInMap("ComplianceResult")]
        [Validation(Required=false)]
        public GetAggregateResourceComplianceGroupByResourceTypeResponseBodyComplianceResult ComplianceResult { get; set; }
        public class GetAggregateResourceComplianceGroupByResourceTypeResponseBodyComplianceResult : TeaModel {
            [NameInMap("ComplianceResultList")]
            [Validation(Required=false)]
            public List<GetAggregateResourceComplianceGroupByResourceTypeResponseBodyComplianceResultComplianceResultList> ComplianceResultList { get; set; }
            public class GetAggregateResourceComplianceGroupByResourceTypeResponseBodyComplianceResultComplianceResultList : TeaModel {
                [NameInMap("Compliances")]
                [Validation(Required=false)]
                public List<GetAggregateResourceComplianceGroupByResourceTypeResponseBodyComplianceResultComplianceResultListCompliances> Compliances { get; set; }
                public class GetAggregateResourceComplianceGroupByResourceTypeResponseBodyComplianceResultComplianceResultListCompliances : TeaModel {
                    [NameInMap("ComplianceType")]
                    [Validation(Required=false)]
                    public string ComplianceType { get; set; }

                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                }

                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
