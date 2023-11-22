// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DetectAudioForCustomizedVoiceJobResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectAudioForCustomizedVoiceJobResponseBodyData Data { get; set; }
        public class DetectAudioForCustomizedVoiceJobResponseBodyData : TeaModel {
            [NameInMap("Pass")]
            [Validation(Required=false)]
            public bool? Pass { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
