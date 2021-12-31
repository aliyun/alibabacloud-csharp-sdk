// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class DescribeRegionResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public DescribeRegionResponseBodyResult Result { get; set; }
        public class DescribeRegionResponseBodyResult : TeaModel {
            [NameInMap("config")]
            [Validation(Required=false)]
            public Dictionary<string, string> Config { get; set; }
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
        };

    }

}
