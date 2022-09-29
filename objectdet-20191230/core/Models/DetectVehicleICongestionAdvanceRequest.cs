// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectVehicleICongestionAdvanceRequest : TeaModel {
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public Stream ImageURLObject { get; set; }

        [NameInMap("PreRegionIntersectFeatures")]
        [Validation(Required=false)]
        public List<DetectVehicleICongestionAdvanceRequestPreRegionIntersectFeatures> PreRegionIntersectFeatures { get; set; }
        public class DetectVehicleICongestionAdvanceRequestPreRegionIntersectFeatures : TeaModel {
            [NameInMap("Features")]
            [Validation(Required=false)]
            public List<string> Features { get; set; }

        }

        [NameInMap("RoadRegions")]
        [Validation(Required=false)]
        public List<DetectVehicleICongestionAdvanceRequestRoadRegions> RoadRegions { get; set; }
        public class DetectVehicleICongestionAdvanceRequestRoadRegions : TeaModel {
            [NameInMap("RoadRegion")]
            [Validation(Required=false)]
            public List<DetectVehicleICongestionAdvanceRequestRoadRegionsRoadRegion> RoadRegion { get; set; }
            public class DetectVehicleICongestionAdvanceRequestRoadRegionsRoadRegion : TeaModel {
                [NameInMap("Point")]
                [Validation(Required=false)]
                public DetectVehicleICongestionAdvanceRequestRoadRegionsRoadRegionPoint Point { get; set; }
                public class DetectVehicleICongestionAdvanceRequestRoadRegionsRoadRegionPoint : TeaModel {
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public long? X { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public long? Y { get; set; }

                }

            }

        }

    }

}
