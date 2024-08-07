// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class AddMeetingRoomsRequest : TeaModel {
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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("MeetingRoomsToAdd")]
        [Validation(Required=false)]
        public List<AddMeetingRoomsRequestMeetingRoomsToAdd> MeetingRoomsToAdd { get; set; }
        public class AddMeetingRoomsRequestMeetingRoomsToAdd : TeaModel {
            [NameInMap("RoomId")]
            [Validation(Required=false)]
            public string RoomId { get; set; }

        }

    }

}
