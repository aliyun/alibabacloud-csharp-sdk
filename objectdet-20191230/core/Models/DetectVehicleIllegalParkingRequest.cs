// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectVehicleIllegalParkingRequest : TeaModel {
        /// <summary>
        /// A short description of struct
        /// </summary>
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public string ImageURL { get; set; }

        [NameInMap("RoadRegions")]
        [Validation(Required=false)]
        public List<DetectVehicleIllegalParkingRequestRoadRegions> RoadRegions { get; set; }
        public class DetectVehicleIllegalParkingRequestRoadRegions : TeaModel {
            [NameInMap("RoadRegion")]
            [Validation(Required=false)]
            public List<DetectVehicleIllegalParkingRequestRoadRegionsRoadRegion> RoadRegion { get; set; }
            public class DetectVehicleIllegalParkingRequestRoadRegionsRoadRegion : TeaModel {
                [NameInMap("Point")]
                [Validation(Required=false)]
                public DetectVehicleIllegalParkingRequestRoadRegionsRoadRegionPoint Point { get; set; }
                public class DetectVehicleIllegalParkingRequestRoadRegionsRoadRegionPoint : TeaModel {
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public long? X { get; set; }
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public long? Y { get; set; }
                };

            }

        }

    }

}
