// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class RemoveMeetingRoomsShrinkRequest : TeaModel {
        [NameInMap("CalendarId")]
        [Validation(Required=false)]
        public string CalendarId { get; set; }

        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        [NameInMap("MeetingRoomsToRemove")]
        [Validation(Required=false)]
        public string MeetingRoomsToRemoveShrink { get; set; }

    }

}
