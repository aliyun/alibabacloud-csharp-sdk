// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateResourceComplianceGroupByRegionResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried evaluation results.</para>
        /// </summary>
        [NameInMap("ComplianceResult")]
        [Validation(Required=false)]
        public GetAggregateResourceComplianceGroupByRegionResponseBodyComplianceResult ComplianceResult { get; set; }
        public class GetAggregateResourceComplianceGroupByRegionResponseBodyComplianceResult : TeaModel {
            /// <summary>
            /// <para>The evaluation results grouped by region.</para>
            /// </summary>
            [NameInMap("ComplianceResultList")]
            [Validation(Required=false)]
            public List<GetAggregateResourceComplianceGroupByRegionResponseBodyComplianceResultComplianceResultList> ComplianceResultList { get; set; }
            public class GetAggregateResourceComplianceGroupByRegionResponseBodyComplianceResultComplianceResultList : TeaModel {
                /// <summary>
                /// <para>The queried evaluation results.</para>
                /// </summary>
                [NameInMap("Compliances")]
                [Validation(Required=false)]
                public List<GetAggregateResourceComplianceGroupByRegionResponseBodyComplianceResultComplianceResultListCompliances> Compliances { get; set; }
                public class GetAggregateResourceComplianceGroupByRegionResponseBodyComplianceResultComplianceResultListCompliances : TeaModel {
                    /// <summary>
                    /// <para>The evaluation result. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>COMPLIANT: The resource is evaluated as compliant.</description></item>
                    /// <item><description>NON_COMPLIANT: The resource is evaluated as non-compliant.</description></item>
                    /// <item><description>NOT_APPLICABLE: The rule does not apply to the resource.</description></item>
                    /// <item><description>INSUFFICIENT_DATA: No data is available.</description></item>
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
        /// <para>5E3A847A-5D40-54A1-A2CE-77A87823ED07</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
