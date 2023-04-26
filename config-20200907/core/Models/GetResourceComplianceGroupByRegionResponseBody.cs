// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetResourceComplianceGroupByRegionResponseBody : TeaModel {
        /// <summary>
        /// The queried evaluation results.
        /// </summary>
        [NameInMap("ComplianceResult")]
        [Validation(Required=false)]
        public GetResourceComplianceGroupByRegionResponseBodyComplianceResult ComplianceResult { get; set; }
        public class GetResourceComplianceGroupByRegionResponseBodyComplianceResult : TeaModel {
            /// <summary>
            /// The evaluation results grouped by region.
            /// </summary>
            [NameInMap("ComplianceResultList")]
            [Validation(Required=false)]
            public List<GetResourceComplianceGroupByRegionResponseBodyComplianceResultComplianceResultList> ComplianceResultList { get; set; }
            public class GetResourceComplianceGroupByRegionResponseBodyComplianceResultComplianceResultList : TeaModel {
                /// <summary>
                /// The queried evaluation results.
                /// </summary>
                [NameInMap("Compliances")]
                [Validation(Required=false)]
                public List<GetResourceComplianceGroupByRegionResponseBodyComplianceResultComplianceResultListCompliances> Compliances { get; set; }
                public class GetResourceComplianceGroupByRegionResponseBodyComplianceResultComplianceResultListCompliances : TeaModel {
                    /// <summary>
                    /// The evaluation result. Valid values:
                    /// 
                    /// *   COMPLIANT: The resource is evaluated as compliant.
                    /// *   NON_COMPLIANT: The resource is evaluated as non-compliant.
                    /// *   NOT_APPLICABLE: The rule does not apply to the resource.
                    /// *   INSUFFICIENT_DATA: No data is available.
                    /// </summary>
                    [NameInMap("ComplianceType")]
                    [Validation(Required=false)]
                    public string ComplianceType { get; set; }

                    /// <summary>
                    /// The total number of evaluation results.
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                }

                /// <summary>
                /// The region ID of the evaluated resource.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
