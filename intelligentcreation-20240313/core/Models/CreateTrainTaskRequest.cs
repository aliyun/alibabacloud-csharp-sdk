// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class CreateTrainTaskRequest : TeaModel {
        [NameInMap("aliyunMainId")]
        [Validation(Required=false)]
        public string AliyunMainId { get; set; }

        [NameInMap("resSpecType")]
        [Validation(Required=false)]
        public string ResSpecType { get; set; }

        [NameInMap("taskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        [NameInMap("useScene")]
        [Validation(Required=false)]
        public string UseScene { get; set; }

        [NameInMap("voiceGender")]
        [Validation(Required=false)]
        public string VoiceGender { get; set; }

        [NameInMap("voiceLanguage")]
        [Validation(Required=false)]
        public string VoiceLanguage { get; set; }

        [NameInMap("voiceName")]
        [Validation(Required=false)]
        public string VoiceName { get; set; }

        [NameInMap("voicePath")]
        [Validation(Required=false)]
        public string VoicePath { get; set; }

    }

}
