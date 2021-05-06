// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeChildInstanceRegionsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeChildInstanceRegionsResponseBodyRegions Regions { get; set; }
        public class DescribeChildInstanceRegionsResponseBodyRegions : TeaModel {
            [NameInMap("Region")]
            [Validation(Required=false)]
            public List<DescribeChildInstanceRegionsResponseBodyRegionsRegion> Region { get; set; }
            public class DescribeChildInstanceRegionsResponseBodyRegionsRegion : TeaModel {
                public string LocalName { get; set; }
                public string RegionId { get; set; }
            }
        };

    }

}
