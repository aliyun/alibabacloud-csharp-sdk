// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetResourceComplianceGroupByRegionResponseBody : TeaModel {
        [NameInMap("ComplianceResult")]
        [Validation(Required=false)]
        public GetResourceComplianceGroupByRegionResponseBodyComplianceResult ComplianceResult { get; set; }
        public class GetResourceComplianceGroupByRegionResponseBodyComplianceResult : TeaModel {
            [NameInMap("ComplianceResultList")]
            [Validation(Required=false)]
            public List<GetResourceComplianceGroupByRegionResponseBodyComplianceResultComplianceResultList> ComplianceResultList { get; set; }
            public class GetResourceComplianceGroupByRegionResponseBodyComplianceResultComplianceResultList : TeaModel {
                [NameInMap("Compliances")]
                [Validation(Required=false)]
                public List<GetResourceComplianceGroupByRegionResponseBodyComplianceResultComplianceResultListCompliances> Compliances { get; set; }
                public class GetResourceComplianceGroupByRegionResponseBodyComplianceResultComplianceResultListCompliances : TeaModel {
                    [NameInMap("ComplianceType")]
                    [Validation(Required=false)]
                    public string ComplianceType { get; set; }

                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
