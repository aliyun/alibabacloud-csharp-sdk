// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectVehicleICongestionRequest : TeaModel {
        /// <summary>
        /// A short description of struct
        /// </summary>
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public string ImageURL { get; set; }

        [NameInMap("PreRegionIntersectFeatures")]
        [Validation(Required=false)]
        public List<DetectVehicleICongestionRequestPreRegionIntersectFeatures> PreRegionIntersectFeatures { get; set; }
        public class DetectVehicleICongestionRequestPreRegionIntersectFeatures : TeaModel {
            [NameInMap("Features")]
            [Validation(Required=false)]
            public List<string> Features { get; set; }

        }

        [NameInMap("RoadRegions")]
        [Validation(Required=false)]
        public List<DetectVehicleICongestionRequestRoadRegions> RoadRegions { get; set; }
        public class DetectVehicleICongestionRequestRoadRegions : TeaModel {
            [NameInMap("RoadRegion")]
            [Validation(Required=false)]
            public List<DetectVehicleICongestionRequestRoadRegionsRoadRegion> RoadRegion { get; set; }
            public class DetectVehicleICongestionRequestRoadRegionsRoadRegion : TeaModel {
                [NameInMap("Point")]
                [Validation(Required=false)]
                public DetectVehicleICongestionRequestRoadRegionsRoadRegionPoint Point { get; set; }
                public class DetectVehicleICongestionRequestRoadRegionsRoadRegionPoint : TeaModel {
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
