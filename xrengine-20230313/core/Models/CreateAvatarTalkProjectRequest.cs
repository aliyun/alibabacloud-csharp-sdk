// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.XrEngine20230313.Models
{
    public class CreateAvatarTalkProjectRequest : TeaModel {
        [NameInMap("AvatarProjectId")]
        [Validation(Required=false)]
        public string AvatarProjectId { get; set; }

        [NameInMap("JwtToken")]
        [Validation(Required=false)]
        public string JwtToken { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("TtsVoice")]
        [Validation(Required=false)]
        public string TtsVoice { get; set; }

        [NameInMap("TxtContent")]
        [Validation(Required=false)]
        public string TxtContent { get; set; }

    }

}
