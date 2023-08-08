// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tingwu20220930.Models
{
    public class CreateMeetingTransResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateMeetingTransResponseBodyData Data { get; set; }
        public class CreateMeetingTransResponseBodyData : TeaModel {
            [NameInMap("MeetingId")]
            [Validation(Required=false)]
            public string MeetingId { get; set; }

            [NameInMap("MeetingJoinUrl")]
            [Validation(Required=false)]
            public string MeetingJoinUrl { get; set; }

            [NameInMap("MeetingKey")]
            [Validation(Required=false)]
            public string MeetingKey { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
