// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class AsrSentenceRequest : TeaModel {
        [NameInMap("AsrRequest")]
        [Validation(Required=false)]
        public AsrSentenceRequestAsrRequest AsrRequest { get; set; }
        public class AsrSentenceRequestAsrRequest : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("EnableInverseTextNormalization")]
            [Validation(Required=false)]
            public bool? EnableInverseTextNormalization { get; set; }

            [NameInMap("EnablePunctuationPrediction")]
            [Validation(Required=false)]
            public bool? EnablePunctuationPrediction { get; set; }

            [NameInMap("EnableVoiceDetection")]
            [Validation(Required=false)]
            public bool? EnableVoiceDetection { get; set; }

            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }

            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            [NameInMap("SampleRate")]
            [Validation(Required=false)]
            public int? SampleRate { get; set; }

        }

    }

}
