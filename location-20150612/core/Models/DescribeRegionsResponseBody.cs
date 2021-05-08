// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Location20150612.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public DescribeRegionsResponseBodyRegionIds RegionIds { get; set; }
        public class DescribeRegionsResponseBodyRegionIds : TeaModel {
            [NameInMap("RegionIds")]
            [Validation(Required=false)]
            public List<string> RegionIds { get; set; }
        };

    }

}
