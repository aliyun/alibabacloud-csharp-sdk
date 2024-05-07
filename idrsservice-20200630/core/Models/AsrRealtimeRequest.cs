/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class AsrRealtimeRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("CustomizationId")]
        [Validation(Required=false)]
        public string CustomizationId { get; set; }

        [NameInMap("Disfluency")]
        [Validation(Required=false)]
        public bool? Disfluency { get; set; }

        [NameInMap("EnableIgnoreSentenceTimeout")]
        [Validation(Required=false)]
        public bool? EnableIgnoreSentenceTimeout { get; set; }

        [NameInMap("EnableIntermediateResult")]
        [Validation(Required=false)]
        public bool? EnableIntermediateResult { get; set; }

        [NameInMap("EnableInverseTextNormalization")]
        [Validation(Required=false)]
        public bool? EnableInverseTextNormalization { get; set; }

        [NameInMap("EnablePunctuationPrediction")]
        [Validation(Required=false)]
        public bool? EnablePunctuationPrediction { get; set; }

        [NameInMap("EnableSemanticSentenceDetection")]
        [Validation(Required=false)]
        public bool? EnableSemanticSentenceDetection { get; set; }

        [NameInMap("EnableWords")]
        [Validation(Required=false)]
        public bool? EnableWords { get; set; }

        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        [NameInMap("Format")]
        [Validation(Required=false)]
        public string Format { get; set; }

        [NameInMap("MaxSentenceSilence")]
        [Validation(Required=false)]
        public long? MaxSentenceSilence { get; set; }

        [NameInMap("SampleRate")]
        [Validation(Required=false)]
        public long? SampleRate { get; set; }

        [NameInMap("SpeechNoiseThreshold")]
        [Validation(Required=false)]
        public float? SpeechNoiseThreshold { get; set; }

        [NameInMap("VocabularyId")]
        [Validation(Required=false)]
        public string VocabularyId { get; set; }

    }

}
