// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySpeechResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySpeechResponseBodyData Data { get; set; }
        public class QuerySpeechResponseBodyData : TeaModel {
            [NameInMap("AudioFormat")]
            [Validation(Required=false)]
            public string AudioFormat { get; set; }

            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            [NameInMap("EnableSoundCode")]
            [Validation(Required=false)]
            public bool? EnableSoundCode { get; set; }

            [NameInMap("SoundCodeConfig")]
            [Validation(Required=false)]
            public QuerySpeechResponseBodyDataSoundCodeConfig SoundCodeConfig { get; set; }
            public class QuerySpeechResponseBodyDataSoundCodeConfig : TeaModel {
                [NameInMap("AdditionalDuration")]
                [Validation(Required=false)]
                public int? AdditionalDuration { get; set; }

                [NameInMap("SoundCodeContent")]
                [Validation(Required=false)]
                public string SoundCodeContent { get; set; }

            }

            [NameInMap("SpeechCode")]
            [Validation(Required=false)]
            public string SpeechCode { get; set; }

            [NameInMap("SpeechRate")]
            [Validation(Required=false)]
            public int? SpeechRate { get; set; }

            [NameInMap("SpeechType")]
            [Validation(Required=false)]
            public string SpeechType { get; set; }

            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            [NameInMap("Voice")]
            [Validation(Required=false)]
            public string Voice { get; set; }

            [NameInMap("Volume")]
            [Validation(Required=false)]
            public int? Volume { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
