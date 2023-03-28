// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class DetectLymphResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectLymphResponseBodyData Data { get; set; }
        public class DetectLymphResponseBodyData : TeaModel {
            [NameInMap("Lesions")]
            [Validation(Required=false)]
            public List<DetectLymphResponseBodyDataLesions> Lesions { get; set; }
            public class DetectLymphResponseBodyDataLesions : TeaModel {
                [NameInMap("Boxes")]
                [Validation(Required=false)]
                public List<float?> Boxes { get; set; }

                [NameInMap("Diametermm")]
                [Validation(Required=false)]
                public List<float?> Diametermm { get; set; }

                [NameInMap("KeySlice")]
                [Validation(Required=false)]
                public long? KeySlice { get; set; }

                [NameInMap("Recist")]
                [Validation(Required=false)]
                public List<List<float?>> Recist { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

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
