// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeSpotInstanceAdviceResponseBody : TeaModel {
        [NameInMap("AvailableSpotZones")]
        [Validation(Required=false)]
        public DescribeSpotInstanceAdviceResponseBodyAvailableSpotZones AvailableSpotZones { get; set; }
        public class DescribeSpotInstanceAdviceResponseBodyAvailableSpotZones : TeaModel {
            [NameInMap("AvailableSpotZone")]
            [Validation(Required=false)]
            public List<string> AvailableSpotZone { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
