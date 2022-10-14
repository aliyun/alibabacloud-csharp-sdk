// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeLicensePlateResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeLicensePlateResponseBodyData Data { get; set; }
        public class RecognizeLicensePlateResponseBodyData : TeaModel {
            [NameInMap("Plates")]
            [Validation(Required=false)]
            public List<RecognizeLicensePlateResponseBodyDataPlates> Plates { get; set; }
            public class RecognizeLicensePlateResponseBodyDataPlates : TeaModel {
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                [NameInMap("PlateNumber")]
                [Validation(Required=false)]
                public string PlateNumber { get; set; }

                [NameInMap("PlateType")]
                [Validation(Required=false)]
                public string PlateType { get; set; }

                [NameInMap("PlateTypeConfidence")]
                [Validation(Required=false)]
                public float? PlateTypeConfidence { get; set; }

                [NameInMap("Positions")]
                [Validation(Required=false)]
                public List<RecognizeLicensePlateResponseBodyDataPlatesPositions> Positions { get; set; }
                public class RecognizeLicensePlateResponseBodyDataPlatesPositions : TeaModel {
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public long? X { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public long? Y { get; set; }

                }

                [NameInMap("Roi")]
                [Validation(Required=false)]
                public RecognizeLicensePlateResponseBodyDataPlatesRoi Roi { get; set; }
                public class RecognizeLicensePlateResponseBodyDataPlatesRoi : TeaModel {
                    [NameInMap("H")]
                    [Validation(Required=false)]
                    public int? H { get; set; }

                    [NameInMap("W")]
                    [Validation(Required=false)]
                    public int? W { get; set; }

                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public int? X { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public int? Y { get; set; }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
