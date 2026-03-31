// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetResourceComplianceGroupByRegionResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried evaluation results.</para>
        /// </summary>
        [NameInMap("ComplianceResult")]
        [Validation(Required=false)]
        public GetResourceComplianceGroupByRegionResponseBodyComplianceResult ComplianceResult { get; set; }
        public class GetResourceComplianceGroupByRegionResponseBodyComplianceResult : TeaModel {
            /// <summary>
            /// <para>The evaluation results grouped by region.</para>
            /// </summary>
            [NameInMap("ComplianceResultList")]
            [Validation(Required=false)]
            public List<GetResourceComplianceGroupByRegionResponseBodyComplianceResultComplianceResultList> ComplianceResultList { get; set; }
            public class GetResourceComplianceGroupByRegionResponseBodyComplianceResultComplianceResultList : TeaModel {
                /// <summary>
                /// <para>The queried evaluation results.</para>
                /// </summary>
                [NameInMap("Compliances")]
                [Validation(Required=false)]
                public List<GetResourceComplianceGroupByRegionResponseBodyComplianceResultComplianceResultListCompliances> Compliances { get; set; }
                public class GetResourceComplianceGroupByRegionResponseBodyComplianceResultComplianceResultListCompliances : TeaModel {
                    /// <summary>
                    /// <para>The evaluation result. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>COMPLIANT: The resources are evaluated as compliant.</description></item>
                    /// <item><description>NON_COMPLIANT: The resources are evaluated as non-compliant.</description></item>
                    /// <item><description>NOT_APPLICABLE: The rule does not apply to the resources.</description></item>
                    /// <item><description>INSUFFICIENT_DATA: No resource data is available.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>COMPLIANT</para>
                    /// </summary>
                    [NameInMap("ComplianceType")]
                    [Validation(Required=false)]
                    public string ComplianceType { get; set; }

                    /// <summary>
                    /// <para>The total number of evaluation results.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                }

                /// <summary>
                /// <para>The region ID of the evaluated resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FDF8006-34A0-5334-8C79-48F64EAB34F1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
