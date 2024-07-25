// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateCustomizedVoiceJobResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateCustomizedVoiceJobResponseBodyData Data { get; set; }
        public class CreateCustomizedVoiceJobResponseBodyData : TeaModel {
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("VoiceId")]
            [Validation(Required=false)]
            public string VoiceId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
