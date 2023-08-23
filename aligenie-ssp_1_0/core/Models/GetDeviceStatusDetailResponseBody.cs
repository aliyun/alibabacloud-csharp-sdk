// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class GetDeviceStatusDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetDeviceStatusDetailResponseBodyResult Result { get; set; }
        public class GetDeviceStatusDetailResponseBodyResult : TeaModel {
            [NameInMap("Player")]
            [Validation(Required=false)]
            public GetDeviceStatusDetailResponseBodyResultPlayer Player { get; set; }
            public class GetDeviceStatusDetailResponseBodyResultPlayer : TeaModel {
                [NameInMap("AudioAlbum")]
                [Validation(Required=false)]
                public string AudioAlbum { get; set; }

                [NameInMap("AudioAnchor")]
                [Validation(Required=false)]
                public string AudioAnchor { get; set; }

                [NameInMap("AudioExt")]
                [Validation(Required=false)]
                public string AudioExt { get; set; }

                [NameInMap("AudioId")]
                [Validation(Required=false)]
                public string AudioId { get; set; }

                [NameInMap("AudioLength")]
                [Validation(Required=false)]
                public string AudioLength { get; set; }

                [NameInMap("AudioName")]
                [Validation(Required=false)]
                public string AudioName { get; set; }

                [NameInMap("AudioSource")]
                [Validation(Required=false)]
                public string AudioSource { get; set; }

                [NameInMap("AudioUrl")]
                [Validation(Required=false)]
                public string AudioUrl { get; set; }

                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

            [NameInMap("Power")]
            [Validation(Required=false)]
            public GetDeviceStatusDetailResponseBodyResultPower Power { get; set; }
            public class GetDeviceStatusDetailResponseBodyResultPower : TeaModel {
                [NameInMap("Quantity")]
                [Validation(Required=false)]
                public int? Quantity { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("Speaker")]
            [Validation(Required=false)]
            public GetDeviceStatusDetailResponseBodyResultSpeaker Speaker { get; set; }
            public class GetDeviceStatusDetailResponseBodyResultSpeaker : TeaModel {
                [NameInMap("Muted")]
                [Validation(Required=false)]
                public bool? Muted { get; set; }

                [NameInMap("Volume")]
                [Validation(Required=false)]
                public int? Volume { get; set; }

            }

        }

    }

}
