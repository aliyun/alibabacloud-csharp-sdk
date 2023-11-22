// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetCustomizedVoiceJobResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCustomizedVoiceJobResponseBodyData Data { get; set; }
        public class GetCustomizedVoiceJobResponseBodyData : TeaModel {
            [NameInMap("CustomizedVoiceJob")]
            [Validation(Required=false)]
            public GetCustomizedVoiceJobResponseBodyDataCustomizedVoiceJob CustomizedVoiceJob { get; set; }
            public class GetCustomizedVoiceJobResponseBodyDataCustomizedVoiceJob : TeaModel {
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("VoiceId")]
                [Validation(Required=false)]
                public string VoiceId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
