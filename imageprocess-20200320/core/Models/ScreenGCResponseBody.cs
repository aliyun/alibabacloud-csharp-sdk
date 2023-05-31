// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class ScreenGCResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ScreenGCResponseBodyData Data { get; set; }
        public class ScreenGCResponseBodyData : TeaModel {
            [NameInMap("Lesion")]
            [Validation(Required=false)]
            public ScreenGCResponseBodyDataLesion Lesion { get; set; }
            public class ScreenGCResponseBodyDataLesion : TeaModel {
                [NameInMap("GCVolume")]
                [Validation(Required=false)]
                public string GCVolume { get; set; }

                [NameInMap("Mask")]
                [Validation(Required=false)]
                public string Mask { get; set; }

                [NameInMap("NonGCVolume")]
                [Validation(Required=false)]
                public string NonGCVolume { get; set; }

                [NameInMap("Probabilities")]
                [Validation(Required=false)]
                public string Probabilities { get; set; }

                [NameInMap("StomachVolume")]
                [Validation(Required=false)]
                public string StomachVolume { get; set; }

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
