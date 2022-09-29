// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectVehicleIllegalParkingResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectVehicleIllegalParkingResponseBodyData Data { get; set; }
        public class DetectVehicleIllegalParkingResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<DetectVehicleIllegalParkingResponseBodyDataElements> Elements { get; set; }
            public class DetectVehicleIllegalParkingResponseBodyDataElements : TeaModel {
                [NameInMap("Boxes")]
                [Validation(Required=false)]
                public List<DetectVehicleIllegalParkingResponseBodyDataElementsBoxes> Boxes { get; set; }
                public class DetectVehicleIllegalParkingResponseBodyDataElementsBoxes : TeaModel {
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

            [NameInMap("RegionIntersects")]
            [Validation(Required=false)]
            public List<DetectVehicleIllegalParkingResponseBodyDataRegionIntersects> RegionIntersects { get; set; }
            public class DetectVehicleIllegalParkingResponseBodyDataRegionIntersects : TeaModel {
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
