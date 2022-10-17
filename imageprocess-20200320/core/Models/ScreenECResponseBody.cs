// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class ScreenECResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ScreenECResponseBodyData Data { get; set; }
        public class ScreenECResponseBodyData : TeaModel {
            [NameInMap("Lesion")]
            [Validation(Required=false)]
            public ScreenECResponseBodyDataLesion Lesion { get; set; }
            public class ScreenECResponseBodyDataLesion : TeaModel {
                [NameInMap("BenignVolume")]
                [Validation(Required=false)]
                public string BenignVolume { get; set; }

                [NameInMap("EcVolume")]
                [Validation(Required=false)]
                public string EcVolume { get; set; }

                [NameInMap("EsoVolume")]
                [Validation(Required=false)]
                public string EsoVolume { get; set; }

                [NameInMap("Mask")]
                [Validation(Required=false)]
                public string Mask { get; set; }

                [NameInMap("Possibilities")]
                [Validation(Required=false)]
                public List<string> Possibilities { get; set; }

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
