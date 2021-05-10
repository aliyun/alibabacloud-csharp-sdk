// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeLicensePlateResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeLicensePlateResponseBodyData Data { get; set; }
        public class RecognizeLicensePlateResponseBodyData : TeaModel {
            [NameInMap("Plates")]
            [Validation(Required=false)]
            public List<RecognizeLicensePlateResponseBodyDataPlates> Plates { get; set; }
            public class RecognizeLicensePlateResponseBodyDataPlates : TeaModel {
                public float? PlateTypeConfidence { get; set; }
                public string PlateType { get; set; }
                public float? Confidence { get; set; }
                public string PlateNumber { get; set; }
                public RecognizeLicensePlateResponseBodyDataPlatesRoi Roi { get; set; }
                public class RecognizeLicensePlateResponseBodyDataPlatesRoi : TeaModel {
                    [NameInMap("W")]
                    [Validation(Required=false)]
                    public int? W { get; set; }

                    [NameInMap("H")]
                    [Validation(Required=false)]
                    public int? H { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public int? Y { get; set; }

                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public int? X { get; set; }

                }
                public List<RecognizeLicensePlateResponseBodyDataPlatesPositions> Positions { get; set; }
                public class RecognizeLicensePlateResponseBodyDataPlatesPositions : TeaModel {
                    public long? X { get; set; }
                    public long? Y { get; set; }
                }
            }
        };

    }

}
