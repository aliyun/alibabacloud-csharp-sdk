// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class TtsCommonRequest : TeaModel {
        [NameInMap("TtsRequest")]
        [Validation(Required=false)]
        public TtsCommonRequestTtsRequest TtsRequest { get; set; }
        public class TtsCommonRequestTtsRequest : TeaModel {
            /// <summary>
            /// appid
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            [NameInMap("PitchRate")]
            [Validation(Required=false)]
            public int? PitchRate { get; set; }

            [NameInMap("SampleRate")]
            [Validation(Required=false)]
            public int? SampleRate { get; set; }

            [NameInMap("SpeechRate")]
            [Validation(Required=false)]
            public int? SpeechRate { get; set; }

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

    }

}
