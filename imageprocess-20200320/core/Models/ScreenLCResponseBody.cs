// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class ScreenLCResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ScreenLCResponseBodyData Data { get; set; }
        public class ScreenLCResponseBodyData : TeaModel {
            [NameInMap("Lesion")]
            [Validation(Required=false)]
            public ScreenLCResponseBodyDataLesion Lesion { get; set; }
            public class ScreenLCResponseBodyDataLesion : TeaModel {
                [NameInMap("LesionList")]
                [Validation(Required=false)]
                public List<ScreenLCResponseBodyDataLesionLesionList> LesionList { get; set; }
                public class ScreenLCResponseBodyDataLesionLesionList : TeaModel {
                    [NameInMap("Diameter")]
                    [Validation(Required=false)]
                    public List<float?> Diameter { get; set; }

                    [NameInMap("KeySlice")]
                    [Validation(Required=false)]
                    public long? KeySlice { get; set; }

                    [NameInMap("Malignancy")]
                    [Validation(Required=false)]
                    public float? Malignancy { get; set; }

                    [NameInMap("RecistEndpoints")]
                    [Validation(Required=false)]
                    public List<float?> RecistEndpoints { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("Volume")]
                    [Validation(Required=false)]
                    public float? Volume { get; set; }

                }

                [NameInMap("LiverVolume")]
                [Validation(Required=false)]
                public float? LiverVolume { get; set; }

                [NameInMap("Mask")]
                [Validation(Required=false)]
                public string Mask { get; set; }

                [NameInMap("PatientLevelResult")]
                [Validation(Required=false)]
                public ScreenLCResponseBodyDataLesionPatientLevelResult PatientLevelResult { get; set; }
                public class ScreenLCResponseBodyDataLesionPatientLevelResult : TeaModel {
                    [NameInMap("BenignNonCystProb")]
                    [Validation(Required=false)]
                    public string BenignNonCystProb { get; set; }

                    [NameInMap("CystProb")]
                    [Validation(Required=false)]
                    public float? CystProb { get; set; }

                    [NameInMap("HCCProb")]
                    [Validation(Required=false)]
                    public float? HCCProb { get; set; }

                    [NameInMap("MalignantNonHCCProb")]
                    [Validation(Required=false)]
                    public float? MalignantNonHCCProb { get; set; }

                }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
