// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class VoiceModelResponse : TeaModel {
        [NameInMap("resourceTypeDesc")]
        [Validation(Required=false)]
        public string ResourceTypeDesc { get; set; }

        [NameInMap("ttsVersion")]
        [Validation(Required=false)]
        public int? TtsVersion { get; set; }

        [NameInMap("useScene")]
        [Validation(Required=false)]
        public string UseScene { get; set; }

        [NameInMap("voiceDesc")]
        [Validation(Required=false)]
        public string VoiceDesc { get; set; }

        [NameInMap("voiceGender")]
        [Validation(Required=false)]
        public string VoiceGender { get; set; }

        [NameInMap("voiceId")]
        [Validation(Required=false)]
        public long? VoiceId { get; set; }

        [NameInMap("voiceLanguage")]
        [Validation(Required=false)]
        public string VoiceLanguage { get; set; }

        [NameInMap("voiceModel")]
        [Validation(Required=false)]
        public string VoiceModel { get; set; }

        [NameInMap("voiceName")]
        [Validation(Required=false)]
        public string VoiceName { get; set; }

        [NameInMap("voiceType")]
        [Validation(Required=false)]
        public string VoiceType { get; set; }

        [NameInMap("voiceUrl")]
        [Validation(Required=false)]
        public string VoiceUrl { get; set; }

    }

}
