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
                public List<DetectVehicleIllegalParkingResponseBodyDataElementsBoxes> Boxes { get; set; }
                public class DetectVehicleIllegalParkingResponseBodyDataElementsBoxes : TeaModel {
                    public long? Bottom { get; set; }
                    public long? Left { get; set; }
                    public long? Right { get; set; }
                    public long? Top { get; set; }
                }
                public float? Score { get; set; }
                public string TypeName { get; set; }
            }
            [NameInMap("RegionIntersects")]
            [Validation(Required=false)]
            public List<DetectVehicleIllegalParkingResponseBodyDataRegionIntersects> RegionIntersects { get; set; }
            public class DetectVehicleIllegalParkingResponseBodyDataRegionIntersects : TeaModel {
                public List<string> Ids { get; set; }
            }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
