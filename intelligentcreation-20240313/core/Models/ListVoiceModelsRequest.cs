// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class ListVoiceModelsRequest : TeaModel {
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("resSpecType")]
        [Validation(Required=false)]
        public string ResSpecType { get; set; }

        [NameInMap("useScene")]
        [Validation(Required=false)]
        public string UseScene { get; set; }

        [NameInMap("voiceLanguage")]
        [Validation(Required=false)]
        public string VoiceLanguage { get; set; }

        [NameInMap("voiceType")]
        [Validation(Required=false)]
        public string VoiceType { get; set; }

    }

}
