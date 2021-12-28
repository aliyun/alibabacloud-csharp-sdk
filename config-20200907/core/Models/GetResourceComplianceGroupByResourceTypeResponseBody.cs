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
                public List<GetResourceComplianceGroupByResourceTypeResponseBodyComplianceResultComplianceResultListCompliances> Compliances { get; set; }
                public class GetResourceComplianceGroupByResourceTypeResponseBodyComplianceResultComplianceResultListCompliances : TeaModel {
                    public string ComplianceType { get; set; }
                    public long? Count { get; set; }
                }
                public string ResourceType { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
