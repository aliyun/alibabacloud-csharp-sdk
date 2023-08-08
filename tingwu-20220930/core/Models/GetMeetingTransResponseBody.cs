// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tingwu20220930.Models
{
    public class GetMeetingTransResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMeetingTransResponseBodyData Data { get; set; }
        public class GetMeetingTransResponseBodyData : TeaModel {
            [NameInMap("MeetingId")]
            [Validation(Required=false)]
            public string MeetingId { get; set; }

            [NameInMap("MeetingKey")]
            [Validation(Required=false)]
            public string MeetingKey { get; set; }

            [NameInMap("MeetingStatus")]
            [Validation(Required=false)]
            public string MeetingStatus { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
