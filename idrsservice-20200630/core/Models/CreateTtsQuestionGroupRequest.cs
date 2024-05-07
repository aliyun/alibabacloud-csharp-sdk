// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class CreateTtsQuestionGroupRequest : TeaModel {
        [NameInMap("Request")]
        [Validation(Required=false)]
        public CreateTtsQuestionGroupRequestRequest Request { get; set; }
        public class CreateTtsQuestionGroupRequestRequest : TeaModel {
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

            [NameInMap("Voice")]
            [Validation(Required=false)]
            public string Voice { get; set; }

            [NameInMap("Volume")]
            [Validation(Required=false)]
            public int? Volume { get; set; }

        }

    }

}
