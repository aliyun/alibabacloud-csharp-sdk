// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class ScreenCRCResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ScreenCRCResponseBodyData Data { get; set; }
        public class ScreenCRCResponseBodyData : TeaModel {
            [NameInMap("Lesion")]
            [Validation(Required=false)]
            public ScreenCRCResponseBodyDataLesion Lesion { get; set; }
            public class ScreenCRCResponseBodyDataLesion : TeaModel {
                [NameInMap("CRCVolume")]
                [Validation(Required=false)]
                public string CRCVolume { get; set; }

                [NameInMap("ColorectumVolume")]
                [Validation(Required=false)]
                public string ColorectumVolume { get; set; }

                [NameInMap("Mask")]
                [Validation(Required=false)]
                public string Mask { get; set; }

                [NameInMap("Probabilities")]
                [Validation(Required=false)]
                public string Probabilities { get; set; }

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
