// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeResourceRecommendFiltersResponseBody : TeaModel {
        [NameInMap("RecommendFilters")]
        [Validation(Required=false)]
        public DescribeResourceRecommendFiltersResponseBodyRecommendFilters RecommendFilters { get; set; }
        public class DescribeResourceRecommendFiltersResponseBodyRecommendFilters : TeaModel {
            [NameInMap("RecommendFilter")]
            [Validation(Required=false)]
            public List<DescribeResourceRecommendFiltersResponseBodyRecommendFiltersRecommendFilter> RecommendFilter { get; set; }
            public class DescribeResourceRecommendFiltersResponseBodyRecommendFiltersRecommendFilter : TeaModel {
                [NameInMap("AttributeName")]
                [Validation(Required=false)]
                public string AttributeName { get; set; }

                [NameInMap("AttributeValue")]
                [Validation(Required=false)]
                public string AttributeValue { get; set; }

                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

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
