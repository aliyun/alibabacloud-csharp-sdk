// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class DescribeOpenApiRcpStatsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StatList")]
        [Validation(Required=false)]
        public List<DescribeOpenApiRcpStatsResponseBodyStatList> StatList { get; set; }
        public class DescribeOpenApiRcpStatsResponseBodyStatList : TeaModel {
            [NameInMap("BlockCount")]
            [Validation(Required=false)]
            public int? BlockCount { get; set; }

            [NameInMap("Date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            [NameInMap("PassCount")]
            [Validation(Required=false)]
            public int? PassCount { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("ReviewCount")]
            [Validation(Required=false)]
            public int? ReviewCount { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            [NameInMap("TotalDuration")]
            [Validation(Required=false)]
            public int? TotalDuration { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
