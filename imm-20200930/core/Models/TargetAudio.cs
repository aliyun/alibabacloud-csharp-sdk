// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class TargetAudio : TeaModel {
        [NameInMap("DisableAudio")]
        [Validation(Required=false)]
        public bool? DisableAudio { get; set; }

        [NameInMap("FilterAudio")]
        [Validation(Required=false)]
        public TargetAudioFilterAudio FilterAudio { get; set; }
        public class TargetAudioFilterAudio : TeaModel {
            [NameInMap("Mixing")]
            [Validation(Required=false)]
            public bool? Mixing { get; set; }

        }

        [NameInMap("Stream")]
        [Validation(Required=false)]
        public List<long?> Stream { get; set; }

        [NameInMap("TranscodeAudio")]
        [Validation(Required=false)]
        public TargetAudioTranscodeAudio TranscodeAudio { get; set; }
        public class TargetAudioTranscodeAudio : TeaModel {
            [NameInMap("Bitrate")]
            [Validation(Required=false)]
            public int? Bitrate { get; set; }

            [NameInMap("BitrateOption")]
            [Validation(Required=false)]
            public string BitrateOption { get; set; }

            [NameInMap("Channel")]
            [Validation(Required=false)]
            public int? Channel { get; set; }

            [NameInMap("Codec")]
            [Validation(Required=false)]
            public string Codec { get; set; }

            [NameInMap("Quality")]
            [Validation(Required=false)]
            public int? Quality { get; set; }

            [NameInMap("SampleRate")]
            [Validation(Required=false)]
            public int? SampleRate { get; set; }

            [NameInMap("SampleRateOption")]
            [Validation(Required=false)]
            public string SampleRateOption { get; set; }

        }

    }

}
