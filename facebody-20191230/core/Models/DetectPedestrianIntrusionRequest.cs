// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DetectPedestrianIntrusionRequest : TeaModel {
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public string ImageURL { get; set; }

        [NameInMap("DetectRegion")]
        [Validation(Required=false)]
        public List<DetectPedestrianIntrusionRequestDetectRegion> DetectRegion { get; set; }
        public class DetectPedestrianIntrusionRequestDetectRegion : TeaModel {
            [NameInMap("Rect")]
            [Validation(Required=false)]
            public DetectPedestrianIntrusionRequestDetectRegionRect Rect { get; set; }
            public class DetectPedestrianIntrusionRequestDetectRegionRect : TeaModel {
                [NameInMap("Left")]
                [Validation(Required=false)]
                public long Left { get; set; }
                [NameInMap("Top")]
                [Validation(Required=false)]
                public long Top { get; set; }
                [NameInMap("Right")]
                [Validation(Required=false)]
                public long Right { get; set; }
                [NameInMap("Bottom")]
                [Validation(Required=false)]
                public long Bottom { get; set; }
            };

            [NameInMap("Line")]
            [Validation(Required=false)]
            public DetectPedestrianIntrusionRequestDetectRegionLine Line { get; set; }
            public class DetectPedestrianIntrusionRequestDetectRegionLine : TeaModel {
                [NameInMap("X1")]
                [Validation(Required=false)]
                public long X1 { get; set; }
                [NameInMap("Y1")]
                [Validation(Required=false)]
                public long Y1 { get; set; }
                [NameInMap("X2")]
                [Validation(Required=false)]
                public long X2 { get; set; }
                [NameInMap("Y2")]
                [Validation(Required=false)]
                public long Y2 { get; set; }
            };

        }

        [NameInMap("RegionType")]
        [Validation(Required=false)]
        public string RegionType { get; set; }

    }

}
