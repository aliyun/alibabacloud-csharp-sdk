// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectVehicleICongestionResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectVehicleICongestionResponseBodyData Data { get; set; }
        public class DetectVehicleICongestionResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<DetectVehicleICongestionResponseBodyDataElements> Elements { get; set; }
            public class DetectVehicleICongestionResponseBodyDataElements : TeaModel {
                public List<DetectVehicleICongestionResponseBodyDataElementsBoxes> Boxes { get; set; }
                public class DetectVehicleICongestionResponseBodyDataElementsBoxes : TeaModel {
                    public long? Left { get; set; }
                    public long? Top { get; set; }
                    public long? Right { get; set; }
                    public long? Bottom { get; set; }
                }
                public float? Score { get; set; }
                public string TypeName { get; set; }
            }
            [NameInMap("RegionIntersectFeatures")]
            [Validation(Required=false)]
            public List<DetectVehicleICongestionResponseBodyDataRegionIntersectFeatures> RegionIntersectFeatures { get; set; }
            public class DetectVehicleICongestionResponseBodyDataRegionIntersectFeatures : TeaModel {
                public List<string> Features { get; set; }
            }
            [NameInMap("RegionIntersectMatched")]
            [Validation(Required=false)]
            public List<DetectVehicleICongestionResponseBodyDataRegionIntersectMatched> RegionIntersectMatched { get; set; }
            public class DetectVehicleICongestionResponseBodyDataRegionIntersectMatched : TeaModel {
                public List<string> Ids { get; set; }
            }
            [NameInMap("RegionIntersects")]
            [Validation(Required=false)]
            public List<DetectVehicleICongestionResponseBodyDataRegionIntersects> RegionIntersects { get; set; }
            public class DetectVehicleICongestionResponseBodyDataRegionIntersects : TeaModel {
                public List<string> Ids { get; set; }
            }
        };

    }

}
