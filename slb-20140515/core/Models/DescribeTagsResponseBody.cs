// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeTagsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TagSets")]
        [Validation(Required=false)]
        public DescribeTagsResponseBodyTagSets TagSets { get; set; }
        public class DescribeTagsResponseBodyTagSets : TeaModel {
            [NameInMap("TagSet")]
            [Validation(Required=false)]
            public List<DescribeTagsResponseBodyTagSetsTagSet> TagSet { get; set; }
            public class DescribeTagsResponseBodyTagSetsTagSet : TeaModel {
                public int? InstanceCount { get; set; }
                public string TagValue { get; set; }
                public string TagKey { get; set; }
            }
        };

    }

}
