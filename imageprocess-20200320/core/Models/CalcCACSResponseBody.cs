// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class CalcCACSResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CalcCACSResponseBodyData Data { get; set; }
        public class CalcCACSResponseBodyData : TeaModel {
            [NameInMap("Detections")]
            [Validation(Required=false)]
            public List<CalcCACSResponseBodyDataDetections> Detections { get; set; }
            public class CalcCACSResponseBodyDataDetections : TeaModel {
                [NameInMap("CalciumCenter")]
                [Validation(Required=false)]
                public List<long?> CalciumCenter { get; set; }

                [NameInMap("CalciumId")]
                [Validation(Required=false)]
                public long? CalciumId { get; set; }

                [NameInMap("CalciumScore")]
                [Validation(Required=false)]
                public float? CalciumScore { get; set; }

                [NameInMap("CalciumVolume")]
                [Validation(Required=false)]
                public float? CalciumVolume { get; set; }

            }

            [NameInMap("ResultUrl")]
            [Validation(Required=false)]
            public string ResultUrl { get; set; }

            [NameInMap("Score")]
            [Validation(Required=false)]
            public string Score { get; set; }

            [NameInMap("VolumeScore")]
            [Validation(Required=false)]
            public string VolumeScore { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
