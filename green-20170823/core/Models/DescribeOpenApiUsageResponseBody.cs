// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class DescribeOpenApiUsageResponseBody : TeaModel {
        [NameInMap("OpenApiUsageList")]
        [Validation(Required=false)]
        public List<DescribeOpenApiUsageResponseBodyOpenApiUsageList> OpenApiUsageList { get; set; }
        public class DescribeOpenApiUsageResponseBodyOpenApiUsageList : TeaModel {
            [NameInMap("BlockCount")]
            [Validation(Required=false)]
            public int? BlockCount { get; set; }

            [NameInMap("BlockDuration")]
            [Validation(Required=false)]
            public int? BlockDuration { get; set; }

            [NameInMap("Date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            [NameInMap("InnerTotalCount")]
            [Validation(Required=false)]
            public int? InnerTotalCount { get; set; }

            [NameInMap("OuterTotalCount")]
            [Validation(Required=false)]
            public int? OuterTotalCount { get; set; }

            [NameInMap("PassCount")]
            [Validation(Required=false)]
            public int? PassCount { get; set; }

            [NameInMap("PassDuration")]
            [Validation(Required=false)]
            public int? PassDuration { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("ReviewCount")]
            [Validation(Required=false)]
            public int? ReviewCount { get; set; }

            [NameInMap("ReviewDuration")]
            [Validation(Required=false)]
            public int? ReviewDuration { get; set; }

            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            [NameInMap("TotalDuration")]
            [Validation(Required=false)]
            public int? TotalDuration { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
