// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeRegionDdosThresholdResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RegionDdosThreshold")]
        [Validation(Required=false)]
        public DescribeRegionDdosThresholdResponseBodyRegionDdosThreshold RegionDdosThreshold { get; set; }
        public class DescribeRegionDdosThresholdResponseBodyRegionDdosThreshold : TeaModel {
            [NameInMap("ElasticThreshold")]
            [Validation(Required=false)]
            public int? ElasticThreshold { get; set; }
            [NameInMap("BaseThreshold")]
            [Validation(Required=false)]
            public int? BaseThreshold { get; set; }
        };

    }

}
