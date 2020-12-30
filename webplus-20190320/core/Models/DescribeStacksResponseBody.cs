// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class DescribeStacksResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Stacks")]
        [Validation(Required=false)]
        public DescribeStacksResponseBodyStacks Stacks { get; set; }
        public class DescribeStacksResponseBodyStacks : TeaModel {
            [NameInMap("Stack")]
            [Validation(Required=false)]
            public List<DescribeStacksResponseBodyStacksStack> Stack { get; set; }
            public class DescribeStacksResponseBodyStacksStack : TeaModel {
                public long? UpdateTime { get; set; }
                public string StackId { get; set; }
                public long? CreateTime { get; set; }
                public bool? RecommendedStack { get; set; }
                public string StackName { get; set; }
                public string CategoryName { get; set; }
                public int? VersionCode { get; set; }
                public bool? LatestStack { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
