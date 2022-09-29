// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectKitchenAnimalsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectKitchenAnimalsResponseBodyData Data { get; set; }
        public class DetectKitchenAnimalsResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<DetectKitchenAnimalsResponseBodyDataElements> Elements { get; set; }
            public class DetectKitchenAnimalsResponseBodyDataElements : TeaModel {
                [NameInMap("Rectangles")]
                [Validation(Required=false)]
                public DetectKitchenAnimalsResponseBodyDataElementsRectangles Rectangles { get; set; }
                public class DetectKitchenAnimalsResponseBodyDataElementsRectangles : TeaModel {
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public long? Height { get; set; }

                    [NameInMap("Left")]
                    [Validation(Required=false)]
                    public long? Left { get; set; }

                    [NameInMap("Top")]
                    [Validation(Required=false)]
                    public long? Top { get; set; }

                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public long? Width { get; set; }

                }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
