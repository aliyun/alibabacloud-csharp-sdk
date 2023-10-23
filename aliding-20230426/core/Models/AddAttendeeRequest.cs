// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class AddAttendeeRequest : TeaModel {
        [NameInMap("AttendeesToAdd")]
        [Validation(Required=false)]
        public List<AddAttendeeRequestAttendeesToAdd> AttendeesToAdd { get; set; }
        public class AddAttendeeRequestAttendeesToAdd : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("isOptional")]
            [Validation(Required=false)]
            public bool? IsOptional { get; set; }

        }

        [NameInMap("CalendarId")]
        [Validation(Required=false)]
        public string CalendarId { get; set; }

        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        [NameInMap("chatNotification")]
        [Validation(Required=false)]
        public bool? ChatNotification { get; set; }

        [NameInMap("pushNotification")]
        [Validation(Required=false)]
        public bool? PushNotification { get; set; }

    }

}
