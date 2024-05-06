// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20170115.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeRegionsResponseBodyRegions Regions { get; set; }
        public class DescribeRegionsResponseBodyRegions : TeaModel {
            [NameInMap("Region")]
            [Validation(Required=false)]
            public List<DescribeRegionsResponseBodyRegionsRegion> Region { get; set; }
            public class DescribeRegionsResponseBodyRegionsRegion : TeaModel {
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Zones")]
                [Validation(Required=false)]
                public DescribeRegionsResponseBodyRegionsRegionZones Zones { get; set; }
                public class DescribeRegionsResponseBodyRegionsRegionZones : TeaModel {
                    [NameInMap("Zone")]
                    [Validation(Required=false)]
                    public List<DescribeRegionsResponseBodyRegionsRegionZonesZone> Zone { get; set; }
                    public class DescribeRegionsResponseBodyRegionsRegionZonesZone : TeaModel {
                        [NameInMap("VpcEnabled")]
                        [Validation(Required=false)]
                        public bool? VpcEnabled { get; set; }

                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
