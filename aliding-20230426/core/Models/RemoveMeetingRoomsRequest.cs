// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class RemoveMeetingRoomsRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CalendarId")]
        [Validation(Required=false)]
        public string CalendarId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        [NameInMap("MeetingRoomsToRemove")]
        [Validation(Required=false)]
        public List<RemoveMeetingRoomsRequestMeetingRoomsToRemove> MeetingRoomsToRemove { get; set; }
        public class RemoveMeetingRoomsRequestMeetingRoomsToRemove : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("RoomId")]
            [Validation(Required=false)]
            public string RoomId { get; set; }

        }

    }

}
