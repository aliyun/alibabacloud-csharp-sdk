// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DetectPedestrianIntrusionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectPedestrianIntrusionResponseBodyData Data { get; set; }
        public class DetectPedestrianIntrusionResponseBodyData : TeaModel {
            [NameInMap("ImageWidth")]
            [Validation(Required=false)]
            public long ImageWidth { get; set; }
            [NameInMap("ImageHeight")]
            [Validation(Required=false)]
            public long ImageHeight { get; set; }
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<DetectPedestrianIntrusionResponseBodyDataElements> Elements { get; set; }
            public class DetectPedestrianIntrusionResponseBodyDataElements : TeaModel {
                public long Score { get; set; }
                public string Type { get; set; }
                public bool? IsIntrude { get; set; }
                public DetectPedestrianIntrusionResponseBodyDataElementsBox Box { get; set; }
                public class DetectPedestrianIntrusionResponseBodyDataElementsBox : TeaModel {
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

                }
                public long BoxId { get; set; }
            }
        };

    }

}
