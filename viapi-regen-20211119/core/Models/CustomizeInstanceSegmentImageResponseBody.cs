// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_regen20211119.Models
{
    public class CustomizeInstanceSegmentImageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CustomizeInstanceSegmentImageResponseBodyData Data { get; set; }
        public class CustomizeInstanceSegmentImageResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<CustomizeInstanceSegmentImageResponseBodyDataElements> Elements { get; set; }
            public class CustomizeInstanceSegmentImageResponseBodyDataElements : TeaModel {
                public CustomizeInstanceSegmentImageResponseBodyDataElementsBoxes Boxes { get; set; }
                public class CustomizeInstanceSegmentImageResponseBodyDataElementsBoxes : TeaModel {
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public int? Height { get; set; }

                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public int? Width { get; set; }

                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public int? X { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public int? Y { get; set; }

                }
                public string Category { get; set; }
                public List<CustomizeInstanceSegmentImageResponseBodyDataElementsContours> Contours { get; set; }
                public class CustomizeInstanceSegmentImageResponseBodyDataElementsContours : TeaModel {
                    public int? X { get; set; }
                    public int? Y { get; set; }
                }
                public CustomizeInstanceSegmentImageResponseBodyDataElementsMask Mask { get; set; }
                public class CustomizeInstanceSegmentImageResponseBodyDataElementsMask : TeaModel {
                    [NameInMap("Counts")]
                    [Validation(Required=false)]
                    public string Counts { get; set; }

                    [NameInMap("Sizes")]
                    [Validation(Required=false)]
                    public List<int?> Sizes { get; set; }

                }
                public float? Score { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
