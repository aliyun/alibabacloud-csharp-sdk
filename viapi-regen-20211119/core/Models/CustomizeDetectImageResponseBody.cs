// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_regen20211119.Models
{
    public class CustomizeDetectImageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CustomizeDetectImageResponseBodyData Data { get; set; }
        public class CustomizeDetectImageResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<CustomizeDetectImageResponseBodyDataElements> Elements { get; set; }
            public class CustomizeDetectImageResponseBodyDataElements : TeaModel {
                public CustomizeDetectImageResponseBodyDataElementsBoxes Boxes { get; set; }
                public class CustomizeDetectImageResponseBodyDataElementsBoxes : TeaModel {
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public float? Height { get; set; }

                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public float? Width { get; set; }

                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public float? X { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                }
                public string Category { get; set; }
                public float? Score { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
