// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeResourceAggregationsResponseBody : TeaModel {
        [NameInMap("Aggregations")]
        [Validation(Required=false)]
        public DescribeResourceAggregationsResponseBodyAggregations Aggregations { get; set; }
        public class DescribeResourceAggregationsResponseBodyAggregations : TeaModel {
            [NameInMap("Aggregation")]
            [Validation(Required=false)]
            public List<DescribeResourceAggregationsResponseBodyAggregationsAggregation> Aggregation { get; set; }
            public class DescribeResourceAggregationsResponseBodyAggregationsAggregation : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public string Count { get; set; }

                [NameInMap("Keys")]
                [Validation(Required=false)]
                public string Keys { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
