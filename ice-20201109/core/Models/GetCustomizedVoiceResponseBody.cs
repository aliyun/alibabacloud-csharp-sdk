// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetCustomizedVoiceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCustomizedVoiceResponseBodyData Data { get; set; }
        public class GetCustomizedVoiceResponseBodyData : TeaModel {
            [NameInMap("CustomizedVoice")]
            [Validation(Required=false)]
            public GetCustomizedVoiceResponseBodyDataCustomizedVoice CustomizedVoice { get; set; }
            public class GetCustomizedVoiceResponseBodyDataCustomizedVoice : TeaModel {
                [NameInMap("DemoAudioMediaId")]
                [Validation(Required=false)]
                public string DemoAudioMediaId { get; set; }

                [NameInMap("Gender")]
                [Validation(Required=false)]
                public string Gender { get; set; }

                [NameInMap("Scenario")]
                [Validation(Required=false)]
                public string Scenario { get; set; }

                [NameInMap("VoiceDesc")]
                [Validation(Required=false)]
                public string VoiceDesc { get; set; }

                [NameInMap("VoiceId")]
                [Validation(Required=false)]
                public string VoiceId { get; set; }

                [NameInMap("VoiceName")]
                [Validation(Required=false)]
                public string VoiceName { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
