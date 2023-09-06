// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryScheduleConferenceResponseBody : TeaModel {
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("phones")]
        [Validation(Required=false)]
        public List<string> Phones { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("roomCode")]
        [Validation(Required=false)]
        public string RoomCode { get; set; }

        [NameInMap("scheduleConferenceId")]
        [Validation(Required=false)]
        public string ScheduleConferenceId { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
