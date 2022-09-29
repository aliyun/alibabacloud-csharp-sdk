// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectVehicleICongestionResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectVehicleICongestionResponseBodyData Data { get; set; }
        public class DetectVehicleICongestionResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<DetectVehicleICongestionResponseBodyDataElements> Elements { get; set; }
            public class DetectVehicleICongestionResponseBodyDataElements : TeaModel {
                [NameInMap("Boxes")]
                [Validation(Required=false)]
                public List<DetectVehicleICongestionResponseBodyDataElementsBoxes> Boxes { get; set; }
                public class DetectVehicleICongestionResponseBodyDataElementsBoxes : TeaModel {
                    [NameInMap("Bottom")]
                    [Validation(Required=false)]
                    public long? Bottom { get; set; }

                    [NameInMap("Left")]
                    [Validation(Required=false)]
                    public long? Left { get; set; }

                    [NameInMap("Right")]
                    [Validation(Required=false)]
                    public long? Right { get; set; }

                    [NameInMap("Top")]
                    [Validation(Required=false)]
                    public long? Top { get; set; }

                }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                [NameInMap("TypeName")]
                [Validation(Required=false)]
                public string TypeName { get; set; }

            }

            [NameInMap("RegionIntersectFeatures")]
            [Validation(Required=false)]
            public List<DetectVehicleICongestionResponseBodyDataRegionIntersectFeatures> RegionIntersectFeatures { get; set; }
            public class DetectVehicleICongestionResponseBodyDataRegionIntersectFeatures : TeaModel {
                [NameInMap("Features")]
                [Validation(Required=false)]
                public List<string> Features { get; set; }

            }

            [NameInMap("RegionIntersectMatched")]
            [Validation(Required=false)]
            public List<DetectVehicleICongestionResponseBodyDataRegionIntersectMatched> RegionIntersectMatched { get; set; }
            public class DetectVehicleICongestionResponseBodyDataRegionIntersectMatched : TeaModel {
                [NameInMap("Ids")]
                [Validation(Required=false)]
                public List<long?> Ids { get; set; }

            }

            [NameInMap("RegionIntersects")]
            [Validation(Required=false)]
            public List<DetectVehicleICongestionResponseBodyDataRegionIntersects> RegionIntersects { get; set; }
            public class DetectVehicleICongestionResponseBodyDataRegionIntersects : TeaModel {
                [NameInMap("Ids")]
                [Validation(Required=false)]
                public List<long?> Ids { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
