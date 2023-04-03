// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class CalcBMDResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CalcBMDResponseBodyData Data { get; set; }
        public class CalcBMDResponseBodyData : TeaModel {
            [NameInMap("Detections")]
            [Validation(Required=false)]
            public List<CalcBMDResponseBodyDataDetections> Detections { get; set; }
            public class CalcBMDResponseBodyDataDetections : TeaModel {
                [NameInMap("VertBMD")]
                [Validation(Required=false)]
                public float? VertBMD { get; set; }

                [NameInMap("VertCategory")]
                [Validation(Required=false)]
                public float? VertCategory { get; set; }

                [NameInMap("VertId")]
                [Validation(Required=false)]
                public string VertId { get; set; }

                [NameInMap("VertTScore")]
                [Validation(Required=false)]
                public float? VertTScore { get; set; }

                [NameInMap("VertZScore")]
                [Validation(Required=false)]
                public float? VertZScore { get; set; }

            }

            [NameInMap("Origin")]
            [Validation(Required=false)]
            public List<float?> Origin { get; set; }

            [NameInMap("ResultURL")]
            [Validation(Required=false)]
            public string ResultURL { get; set; }

            [NameInMap("Spacing")]
            [Validation(Required=false)]
            public List<float?> Spacing { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
