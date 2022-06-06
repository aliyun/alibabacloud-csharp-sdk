// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeVulOverviewResponseBody : TeaModel {
        [NameInMap("AsapCount")]
        [Validation(Required=false)]
        public int? AsapCount { get; set; }

        [NameInMap("LaterCount")]
        [Validation(Required=false)]
        public int? LaterCount { get; set; }

        [NameInMap("NntfCount")]
        [Validation(Required=false)]
        public int? NntfCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
