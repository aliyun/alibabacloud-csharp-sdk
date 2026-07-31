// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SfmMultiModalApp20250909.Models
{
    public class ListVoiceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VoiceList")]
        [Validation(Required=false)]
        public List<ListVoiceResponseBodyVoiceList> VoiceList { get; set; }
        public class ListVoiceResponseBodyVoiceList : TeaModel {
            [NameInMap("Gender")]
            [Validation(Required=false)]
            public string Gender { get; set; }

            [NameInMap("Illustration")]
            [Validation(Required=false)]
            public string Illustration { get; set; }

            [NameInMap("IllustrationAudio")]
            [Validation(Required=false)]
            public string IllustrationAudio { get; set; }

            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            [NameInMap("ModelId")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Voice")]
            [Validation(Required=false)]
            public string Voice { get; set; }

        }

    }

}
