// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySpeechResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QuerySpeechResponseData Data { get; set; }
        public class QuerySpeechResponseData : TeaModel {
            [NameInMap("AudioFormat")]
            [Validation(Required=true)]
            public string AudioFormat { get; set; }

            [NameInMap("BizCode")]
            [Validation(Required=true)]
            public string BizCode { get; set; }

            [NameInMap("EnableSoundCode")]
            [Validation(Required=true)]
            public bool? EnableSoundCode { get; set; }

            [NameInMap("SpeechCode")]
            [Validation(Required=true)]
            public string SpeechCode { get; set; }

            [NameInMap("SpeechRate")]
            [Validation(Required=true)]
            public int? SpeechRate { get; set; }

            [NameInMap("SpeechType")]
            [Validation(Required=true)]
            public string SpeechType { get; set; }

            [NameInMap("Text")]
            [Validation(Required=true)]
            public string Text { get; set; }

            [NameInMap("Voice")]
            [Validation(Required=true)]
            public string Voice { get; set; }

            [NameInMap("Volume")]
            [Validation(Required=true)]
            public int? Volume { get; set; }

            [NameInMap("SoundCodeConfig")]
            [Validation(Required=true)]
            public QuerySpeechResponseDataSoundCodeConfig SoundCodeConfig { get; set; }
            public class QuerySpeechResponseDataSoundCodeConfig : TeaModel {
                [NameInMap("AdditionalDuration")]
                [Validation(Required=true)]
                public int? AdditionalDuration { get; set; }

                [NameInMap("SoundCodeContent")]
                [Validation(Required=true)]
                public string SoundCodeContent { get; set; }

            }

        }

    }

}
