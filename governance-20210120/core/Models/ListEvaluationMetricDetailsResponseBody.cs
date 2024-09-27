// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class ListEvaluationMetricDetailsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAGEaXR18y1rqykZHIqRuBejOqED4S3Xne33c7zbn****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AC9BD94C-D20C-4D27-88D4-89E8D75C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<ListEvaluationMetricDetailsResponseBodyResources> Resources { get; set; }
        public class ListEvaluationMetricDetailsResponseBodyResources : TeaModel {
            [NameInMap("ComplianceType")]
            [Validation(Required=false)]
            public string ComplianceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RecentUnloginRamUser</para>
            /// </summary>
            [NameInMap("ResourceClassification")]
            [Validation(Required=false)]
            public string ResourceClassification { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>26435103783237****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>176618589410****</para>
            /// </summary>
            [NameInMap("ResourceOwnerId")]
            [Validation(Required=false)]
            public long? ResourceOwnerId { get; set; }

            [NameInMap("ResourceProperties")]
            [Validation(Required=false)]
            public List<ListEvaluationMetricDetailsResponseBodyResourcesResourceProperties> ResourceProperties { get; set; }
            public class ListEvaluationMetricDetailsResponseBodyResourcesResourceProperties : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>DisplayName</para>
                /// </summary>
                [NameInMap("PropertyName")]
                [Validation(Required=false)]
                public string PropertyName { get; set; }

                [NameInMap("PropertyValue")]
                [Validation(Required=false)]
                public string PropertyValue { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ACS::RAM::User</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

    }

}
