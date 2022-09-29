// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DetectPedestrianIntrusionAdvanceRequest : TeaModel {
        [NameInMap("DetectRegion")]
        [Validation(Required=false)]
        public List<DetectPedestrianIntrusionAdvanceRequestDetectRegion> DetectRegion { get; set; }
        public class DetectPedestrianIntrusionAdvanceRequestDetectRegion : TeaModel {
            [NameInMap("Line")]
            [Validation(Required=false)]
            public DetectPedestrianIntrusionAdvanceRequestDetectRegionLine Line { get; set; }
            public class DetectPedestrianIntrusionAdvanceRequestDetectRegionLine : TeaModel {
                [NameInMap("X1")]
                [Validation(Required=false)]
                public long? X1 { get; set; }

                [NameInMap("X2")]
                [Validation(Required=false)]
                public long? X2 { get; set; }

                [NameInMap("Y1")]
                [Validation(Required=false)]
                public long? Y1 { get; set; }

                [NameInMap("Y2")]
                [Validation(Required=false)]
                public long? Y2 { get; set; }

            }

            [NameInMap("Rect")]
            [Validation(Required=false)]
            public DetectPedestrianIntrusionAdvanceRequestDetectRegionRect Rect { get; set; }
            public class DetectPedestrianIntrusionAdvanceRequestDetectRegionRect : TeaModel {
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

        }

        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public Stream ImageURLObject { get; set; }

        [NameInMap("RegionType")]
        [Validation(Required=false)]
        public string RegionType { get; set; }

    }

}
