// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateResourceComplianceGroupByResourceTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried evaluation results.</para>
        /// </summary>
        [NameInMap("ComplianceResult")]
        [Validation(Required=false)]
        public GetAggregateResourceComplianceGroupByResourceTypeResponseBodyComplianceResult ComplianceResult { get; set; }
        public class GetAggregateResourceComplianceGroupByResourceTypeResponseBodyComplianceResult : TeaModel {
            /// <summary>
            /// <para>The evaluation results grouped by resource type.</para>
            /// </summary>
            [NameInMap("ComplianceResultList")]
            [Validation(Required=false)]
            public List<GetAggregateResourceComplianceGroupByResourceTypeResponseBodyComplianceResultComplianceResultList> ComplianceResultList { get; set; }
            public class GetAggregateResourceComplianceGroupByResourceTypeResponseBodyComplianceResultComplianceResultList : TeaModel {
                /// <summary>
                /// <para>The queried evaluation results.</para>
                /// </summary>
                [NameInMap("Compliances")]
                [Validation(Required=false)]
                public List<GetAggregateResourceComplianceGroupByResourceTypeResponseBodyComplianceResultComplianceResultListCompliances> Compliances { get; set; }
                public class GetAggregateResourceComplianceGroupByResourceTypeResponseBodyComplianceResultComplianceResultListCompliances : TeaModel {
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
                    /// <para>The number of statistical results.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                }

                /// <summary>
                /// <para>The type of the evaluated resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACS::ECS::Instance</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0CE6AEE1-B3D8-530A-9302-6606B20503BB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
