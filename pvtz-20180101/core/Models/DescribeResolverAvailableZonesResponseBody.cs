// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeResolverAvailableZonesResponseBody : TeaModel {
        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public List<DescribeResolverAvailableZonesResponseBodyAvailableZones> AvailableZones { get; set; }
        public class DescribeResolverAvailableZonesResponseBodyAvailableZones : TeaModel {
            [NameInMap("AzId")]
            [Validation(Required=false)]
            public string AzId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
