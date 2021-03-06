// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeRegionsResponseBodyRegions Regions { get; set; }
        public class DescribeRegionsResponseBodyRegions : TeaModel {
            [NameInMap("DdsRegion")]
            [Validation(Required=false)]
            public List<DescribeRegionsResponseBodyRegionsDdsRegion> DdsRegion { get; set; }
            public class DescribeRegionsResponseBodyRegionsDdsRegion : TeaModel {
                [NameInMap("Zone")]
                [Validation(Required=false)]
                public List<DescribeRegionsResponseBodyRegionsDdsRegionZone> Zone { get; set; }
                public class DescribeRegionsResponseBodyRegionsDdsRegionZone : TeaModel {
                    [NameInMap("VpcEnabled")]
                    [Validation(Required=false)]
                    public bool? VpcEnabled { get; set; }

                    [NameInMap("ZoneName")]
                    [Validation(Required=false)]
                    public string ZoneName { get; set; }

                }

            }
        };

    }

}
