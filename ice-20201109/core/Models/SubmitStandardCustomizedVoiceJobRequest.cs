// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitStandardCustomizedVoiceJobRequest : TeaModel {
        [NameInMap("Audios")]
        [Validation(Required=false)]
        public string Audios { get; set; }

        [NameInMap("Authentication")]
        [Validation(Required=false)]
        public string Authentication { get; set; }

        [NameInMap("DemoAudioMediaURL")]
        [Validation(Required=false)]
        public string DemoAudioMediaURL { get; set; }

        [NameInMap("Gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        [NameInMap("VoiceName")]
        [Validation(Required=false)]
        public string VoiceName { get; set; }

    }

}
