// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class ListEvaluationMetricDetailsResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<ListEvaluationMetricDetailsResponseBodyResources> Resources { get; set; }
        public class ListEvaluationMetricDetailsResponseBodyResources : TeaModel {
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ResourceClassification")]
            [Validation(Required=false)]
            public string ResourceClassification { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            [NameInMap("ResourceOwnerId")]
            [Validation(Required=false)]
            public long? ResourceOwnerId { get; set; }

            [NameInMap("ResourceProperties")]
            [Validation(Required=false)]
            public List<ListEvaluationMetricDetailsResponseBodyResourcesResourceProperties> ResourceProperties { get; set; }
            public class ListEvaluationMetricDetailsResponseBodyResourcesResourceProperties : TeaModel {
                [NameInMap("PropertyName")]
                [Validation(Required=false)]
                public string PropertyName { get; set; }

                [NameInMap("PropertyValue")]
                [Validation(Required=false)]
                public string PropertyValue { get; set; }

            }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

    }

}
