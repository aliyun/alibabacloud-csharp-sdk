// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeMultiZoneAvailableRegionsResponseBody : TeaModel {
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeMultiZoneAvailableRegionsResponseBodyRegions Regions { get; set; }
        public class DescribeMultiZoneAvailableRegionsResponseBodyRegions : TeaModel {
            [NameInMap("Region")]
            [Validation(Required=false)]
            public List<DescribeMultiZoneAvailableRegionsResponseBodyRegionsRegion> Region { get; set; }
            public class DescribeMultiZoneAvailableRegionsResponseBodyRegionsRegion : TeaModel {
                public DescribeMultiZoneAvailableRegionsResponseBodyRegionsRegionAvailableCombines AvailableCombines { get; set; }
                public class DescribeMultiZoneAvailableRegionsResponseBodyRegionsRegionAvailableCombines : TeaModel {
                    [NameInMap("AvailableCombine")]
                    [Validation(Required=false)]
                    public List<DescribeMultiZoneAvailableRegionsResponseBodyRegionsRegionAvailableCombinesAvailableCombine> AvailableCombine { get; set; }
                    public class DescribeMultiZoneAvailableRegionsResponseBodyRegionsRegionAvailableCombinesAvailableCombine : TeaModel {
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        [NameInMap("Zones")]
                        [Validation(Required=false)]
                        public DescribeMultiZoneAvailableRegionsResponseBodyRegionsRegionAvailableCombinesAvailableCombineZones Zones { get; set; }
                        public class DescribeMultiZoneAvailableRegionsResponseBodyRegionsRegionAvailableCombinesAvailableCombineZones : TeaModel {
                            [NameInMap("Zone")]
                            [Validation(Required=false)]
                            public List<string> Zone { get; set; }
                        };

                    }

                }
                public string LocalName { get; set; }
                public string RegionEndpoint { get; set; }
                public string RegionId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
