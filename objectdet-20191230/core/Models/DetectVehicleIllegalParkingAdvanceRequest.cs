// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectVehicleIllegalParkingAdvanceRequest : TeaModel {
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public Stream ImageURLObject { get; set; }

        [NameInMap("RoadRegions")]
        [Validation(Required=false)]
        public List<DetectVehicleIllegalParkingAdvanceRequestRoadRegions> RoadRegions { get; set; }
        public class DetectVehicleIllegalParkingAdvanceRequestRoadRegions : TeaModel {
            [NameInMap("RoadRegion")]
            [Validation(Required=false)]
            public List<DetectVehicleIllegalParkingAdvanceRequestRoadRegionsRoadRegion> RoadRegion { get; set; }
            public class DetectVehicleIllegalParkingAdvanceRequestRoadRegionsRoadRegion : TeaModel {
                [NameInMap("Point")]
                [Validation(Required=false)]
                public DetectVehicleIllegalParkingAdvanceRequestRoadRegionsRoadRegionPoint Point { get; set; }
                public class DetectVehicleIllegalParkingAdvanceRequestRoadRegionsRoadRegionPoint : TeaModel {
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
