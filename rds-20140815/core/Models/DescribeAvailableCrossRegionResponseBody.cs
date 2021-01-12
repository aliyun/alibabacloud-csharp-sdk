// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAvailableCrossRegionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeAvailableCrossRegionResponseBodyRegions Regions { get; set; }
        public class DescribeAvailableCrossRegionResponseBodyRegions : TeaModel {
            [NameInMap("Region")]
            [Validation(Required=false)]
            public List<string> Region { get; set; }
        };

    }

}
