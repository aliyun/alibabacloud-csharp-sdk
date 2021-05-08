// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Location20150612.Models
{
    public class DescribeServicesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Services")]
        [Validation(Required=false)]
        public DescribeServicesResponseBodyServices Services { get; set; }
        public class DescribeServicesResponseBodyServices : TeaModel {
            [NameInMap("Services")]
            [Validation(Required=false)]
            public List<string> Services { get; set; }
        };

    }

}
