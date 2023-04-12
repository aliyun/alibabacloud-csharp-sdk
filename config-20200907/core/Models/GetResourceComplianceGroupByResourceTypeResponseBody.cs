// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetResourceComplianceGroupByResourceTypeResponseBody : TeaModel {
        [NameInMap("ComplianceResult")]
        [Validation(Required=false)]
        public GetResourceComplianceGroupByResourceTypeResponseBodyComplianceResult ComplianceResult { get; set; }
        public class GetResourceComplianceGroupByResourceTypeResponseBodyComplianceResult : TeaModel {
            [NameInMap("ComplianceResultList")]
            [Validation(Required=false)]
            public List<GetResourceComplianceGroupByResourceTypeResponseBodyComplianceResultComplianceResultList> ComplianceResultList { get; set; }
            public class GetResourceComplianceGroupByResourceTypeResponseBodyComplianceResultComplianceResultList : TeaModel {
                [NameInMap("Compliances")]
                [Validation(Required=false)]
                public List<GetResourceComplianceGroupByResourceTypeResponseBodyComplianceResultComplianceResultListCompliances> Compliances { get; set; }
                public class GetResourceComplianceGroupByResourceTypeResponseBodyComplianceResultComplianceResultListCompliances : TeaModel {
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
