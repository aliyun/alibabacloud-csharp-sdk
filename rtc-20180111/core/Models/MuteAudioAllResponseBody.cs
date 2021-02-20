// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class MuteAudioAllResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ConferenceId")]
        [Validation(Required=false)]
        public string ConferenceId { get; set; }

        [NameInMap("Participants")]
        [Validation(Required=false)]
        public MuteAudioAllResponseBodyParticipants Participants { get; set; }
        public class MuteAudioAllResponseBodyParticipants : TeaModel {
            [NameInMap("Participant")]
            [Validation(Required=false)]
            public List<MuteAudioAllResponseBodyParticipantsParticipant> Participant { get; set; }
            public class MuteAudioAllResponseBodyParticipantsParticipant : TeaModel {
                public string Code { get; set; }
                public string Message { get; set; }
                public string Id { get; set; }
            }
        };

    }

}
