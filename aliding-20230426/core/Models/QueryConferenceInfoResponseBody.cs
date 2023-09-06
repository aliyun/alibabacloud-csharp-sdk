// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryConferenceInfoResponseBody : TeaModel {
        [NameInMap("confInfo")]
        [Validation(Required=false)]
        public QueryConferenceInfoResponseBodyConfInfo ConfInfo { get; set; }
        public class QueryConferenceInfoResponseBodyConfInfo : TeaModel {
            [NameInMap("ActiveNum")]
            [Validation(Required=false)]
            public int? ActiveNum { get; set; }

            [NameInMap("AttendNum")]
            [Validation(Required=false)]
            public int? AttendNum { get; set; }

            [NameInMap("ConfDuration")]
            [Validation(Required=false)]
            public long? ConfDuration { get; set; }

            [NameInMap("ConferenceId")]
            [Validation(Required=false)]
            public string ConferenceId { get; set; }

            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("CreatorNick")]
            [Validation(Required=false)]
            public string CreatorNick { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("ExternalLinkUrl")]
            [Validation(Required=false)]
            public string ExternalLinkUrl { get; set; }

            [NameInMap("InvitedNum")]
            [Validation(Required=false)]
            public int? InvitedNum { get; set; }

            [NameInMap("RoomCode")]
            [Validation(Required=false)]
            public string RoomCode { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
