// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateCustomizedVoiceJobRequest : TeaModel {
        [NameInMap("Gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        [NameInMap("Scenario")]
        [Validation(Required=false)]
        public string Scenario { get; set; }

        [NameInMap("VoiceDesc")]
        [Validation(Required=false)]
        public string VoiceDesc { get; set; }

        [NameInMap("VoiceId")]
        [Validation(Required=false)]
        public string VoiceId { get; set; }

        [NameInMap("VoiceName")]
        [Validation(Required=false)]
        public string VoiceName { get; set; }

    }

}
